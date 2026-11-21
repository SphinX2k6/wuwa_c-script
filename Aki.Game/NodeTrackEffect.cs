using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express;
using UnrealEngine;

// Token: 0x0200121B RID: 4635
[NullableContext(2)]
[Nullable(0)]
public class NodeTrackEffect : IStaticVariableResetter
{
	// Token: 0x0600B88B RID: 47243 RVA: 0x00366A30 File Offset: 0x00364C30
	static NodeTrackEffect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NodeTrackEffect.CreateStaticDefaultValue), new Action(NodeTrackEffect.ResetStaticDefaultValue));
	}

	// Token: 0x0600B88C RID: 47244 RVA: 0x00366A50 File Offset: 0x00364C50
	[NullableContext(1)]
	public NodeTrackEffect(BehaviorTreeExpressionComponent owner, int nodeId, ITrackEffectAutoChange effectOption)
	{
		if (NodeTrackEffect.LineTrace == null)
		{
			NodeTrackEffect.InitLineTrace();
		}
		this.NodeId = nodeId;
		this.Owner = owner;
		this.TrackEffectEnterRange = (double)effectOption.EnterRange;
		this.TrackEffectLeaveRange = (double)effectOption.LeaveRange;
		this.HitLocation = Vector.Create();
	}

	// Token: 0x0600B88D RID: 47245 RVA: 0x00366AA2 File Offset: 0x00364CA2
	public void Destroy()
	{
		this.End();
		this.Owner = null;
	}

	// Token: 0x0600B88E RID: 47246 RVA: 0x00366AB1 File Offset: 0x00364CB1
	private static void InitLineTrace()
	{
		UTraceLineElement utraceLineElement = new UTraceLineElement();
		utraceLineElement.WorldContextObject = GlobalData.World;
		utraceLineElement.bIsSingle = true;
		utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		NodeTrackEffect.LineTrace = utraceLineElement;
	}

	// Token: 0x0600B88F RID: 47247 RVA: 0x00366ADC File Offset: 0x00364CDC
	public void OnBattleViewActive()
	{
		double trackDistance = this.Owner.GetTrackDistance(this.NodeId);
		this.IsInEnterRange = (trackDistance < this.TrackEffectEnterRange);
		NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, !this.IsInEnterRange);
		NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, this.IsInEnterRange);
		if (this.Timer == null || !this.Timer.IsPause())
		{
			return;
		}
		this.Timer.Resume();
	}

	// Token: 0x0600B890 RID: 47248 RVA: 0x00366B51 File Offset: 0x00364D51
	public void OnBattleViewHide()
	{
		this.SetTrackedEffectHidden();
		if (this.Timer == null || this.Timer.IsPause())
		{
			return;
		}
		this.Timer.Pause();
	}

	// Token: 0x0600B891 RID: 47249 RVA: 0x00366B7C File Offset: 0x00364D7C
	public unsafe void Start()
	{
		this.IsInEnterRange = false;
		this.LoadedCompleteCount = 0;
		string trackEffectPath = QuestNewConfig.Instance.GetTrackEffectPath(ETrackEffect.LongLightBeam.ToEnumString());
		if (StringUtils.IsEmpty(trackEffectPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到追踪特效配置路径";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("trackEffectType", ETrackEffect.LongLightBeam);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string trackEffectPath2 = QuestNewConfig.Instance.GetTrackEffectPath(ETrackEffect.ShortLightBeam.ToEnumString());
		if (StringUtils.IsEmpty(trackEffectPath2))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GeneralLogicTree;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "找不到追踪特效配置路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("trackEffectType", ETrackEffect.ShortLightBeam);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		Vector nodeTrackPosition = this.Owner.GetNodeTrackPosition(this.NodeId);
		if (nodeTrackPosition == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.GeneralLogicTree;
			ELogAuthor author3 = ELogAuthor.YSQ;
			string message3 = "找不到追踪位置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trackEffectType", ETrackEffect.ShortLightBeam);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", this.NodeId);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.LongLightBeam = this.CreateTrackEffect(ETrackEffect.LongLightBeam, trackEffectPath, nodeTrackPosition);
		this.ShortLightBeam = this.CreateTrackEffect(ETrackEffect.ShortLightBeam, trackEffectPath2, nodeTrackPosition);
	}

	// Token: 0x0600B892 RID: 47250 RVA: 0x00366CC4 File Offset: 0x00364EC4
	public void End()
	{
		if (this.Timer != null && TimerSystem.Instance.Has(this.Timer))
		{
			TimerSystem.Instance.Remove(this.Timer);
		}
		this.Timer = null;
		EffectSystem instance = EffectSystem.Instance;
		if (this.LongLightBeam != 0 && instance.IsValid(this.LongLightBeam))
		{
			instance.StopEffectById(this.LongLightBeam, "[TrackEffectExpress.End]", true, null);
		}
		this.LongLightBeam = 0;
		if (this.ShortLightBeam != 0 && instance.IsValid(this.ShortLightBeam))
		{
			instance.StopEffectById(this.ShortLightBeam, "[TrackEffectExpress.End]", true, null);
		}
		this.ShortLightBeam = 0;
	}

	// Token: 0x0600B893 RID: 47251 RVA: 0x00366D7C File Offset: 0x00364F7C
	[NullableContext(1)]
	private int CreateTrackEffect(ETrackEffect effectType, string effectPath, IVector trackPosition)
	{
		UTraceLineElement lineTrace = NodeTrackEffect.LineTrace;
		TraceElementCommon.Instance.SetStartLocation(lineTrace, trackPosition);
		lineTrace.SetEndLocation(trackPosition.X, trackPosition.Y, trackPosition.Z + 1000.0);
		this.HitLocation.FromUeVector(trackPosition);
		bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "TrackedMark_CreateTrackEffect");
		UKuroHitResult hitResult = lineTrace.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			this.HitLocation.Z = (double)hitResult.LocationZ_Array.Get(0);
		}
		this.HitLocation.Z -= 5.0;
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FVectorDouble fvectorDouble = this.HitLocation.ToUeVector(false);
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref Rotator.ZeroRotator, ref fvectorDouble, ref Vector.OneVector));
		return instance.SpawnEffect(world, ftransformDouble, effectPath, "[TrackEffectExpress.CreateTrackEffect]", null, EEffectType.Scene, null, delegate(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			this.OnEffectLoadComplete(effectType, handle);
		}, null, false, false);
	}

	// Token: 0x0600B894 RID: 47252 RVA: 0x00366E80 File Offset: 0x00365080
	private void OnEffectLoadComplete(ETrackEffect effectType, int handle)
	{
		EffectSystem.Instance.RegisterCustomCheckOwnerFunc(handle, (int _) => this.Owner != null);
		double trackDistance = this.Owner.GetTrackDistance(this.NodeId);
		this.IsInEnterRange = (trackDistance < this.TrackEffectEnterRange);
		bool bActive = (effectType == ETrackEffect.LongLightBeam) ? (!this.IsInEnterRange) : this.IsInEnterRange;
		NodeTrackEffect.SetTrackEffectActive(handle, bActive);
		this.LoadedCompleteCount++;
		if (this.LoadedCompleteCount != 2)
		{
			return;
		}
		this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.UpdateTrackEffect), 1000f, 1f, null, null, true);
	}

	// Token: 0x0600B895 RID: 47253 RVA: 0x00366F24 File Offset: 0x00365124
	private void UpdateTrackEffect(float _)
	{
		if (this.IsOccupied)
		{
			this.SetTrackedEffectHidden();
			return;
		}
		double trackDistance = this.Owner.GetTrackDistance(this.NodeId);
		if (trackDistance <= 0.0)
		{
			this.SetTrackedEffectHidden();
			return;
		}
		if (!this.IsInEnterRange && trackDistance < this.TrackEffectEnterRange)
		{
			this.IsInEnterRange = true;
			NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, false);
			NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, true);
		}
		if (this.IsInEnterRange && trackDistance >= this.TrackEffectLeaveRange)
		{
			this.IsInEnterRange = false;
			NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, true);
			NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, false);
		}
	}

	// Token: 0x0600B896 RID: 47254 RVA: 0x00366FC5 File Offset: 0x003651C5
	private void SetTrackedEffectHidden()
	{
		NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, false);
		NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, false);
	}

	// Token: 0x0600B897 RID: 47255 RVA: 0x00366FDF File Offset: 0x003651DF
	private static void SetTrackEffectActive(int handle, bool bActive)
	{
		EffectSystem.Instance.SetEffectHidden(handle, !bActive, null, false);
	}

	// Token: 0x0600B898 RID: 47256 RVA: 0x00366FF2 File Offset: 0x003651F2
	public void OnExpressOccupied()
	{
		this.IsOccupied = true;
	}

	// Token: 0x0600B899 RID: 47257 RVA: 0x00366FFB File Offset: 0x003651FB
	public void OnExpressOccupationRelease()
	{
		this.IsOccupied = false;
	}

	// Token: 0x0600B89A RID: 47258 RVA: 0x00367004 File Offset: 0x00365204
	public static void CreateStaticDefaultValue()
	{
		NodeTrackEffect.LineTrace = null;
	}

	// Token: 0x0600B89B RID: 47259 RVA: 0x0036700C File Offset: 0x0036520C
	public static void ResetStaticDefaultValue()
	{
		NodeTrackEffect.LineTrace = null;
	}

	// Token: 0x04006A2D RID: 27181
	[Nullable(1)]
	private const string PROFILE_KEY = "TrackedMark_CreateTrackEffect";

	// Token: 0x04006A2E RID: 27182
	private const int OFFSET_Z = 1000;

	// Token: 0x04006A2F RID: 27183
	private static UTraceLineElement LineTrace;

	// Token: 0x04006A30 RID: 27184
	private BehaviorTreeExpressionComponent Owner;

	// Token: 0x04006A31 RID: 27185
	private readonly int NodeId;

	// Token: 0x04006A32 RID: 27186
	private int LongLightBeam;

	// Token: 0x04006A33 RID: 27187
	private int ShortLightBeam;

	// Token: 0x04006A34 RID: 27188
	private readonly double TrackEffectEnterRange;

	// Token: 0x04006A35 RID: 27189
	private readonly double TrackEffectLeaveRange;

	// Token: 0x04006A36 RID: 27190
	private readonly Vector HitLocation;

	// Token: 0x04006A37 RID: 27191
	private TimerHandle Timer;

	// Token: 0x04006A38 RID: 27192
	private int LoadedCompleteCount;

	// Token: 0x04006A39 RID: 27193
	private bool IsInEnterRange;

	// Token: 0x04006A3A RID: 27194
	private bool IsOccupied;
}
