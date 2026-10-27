using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay.Common;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020025E3 RID: 9699
[NullableContext(1)]
[Nullable(0)]
public class PilotThrowTargetItem : CommonMarkItem
{
	// Token: 0x06013B7C RID: 80764 RVA: 0x004F1978 File Offset: 0x004EFB78
	public PilotThrowTargetItem(IPilotThrowTarget config)
	{
		FVectorDouble fvectorDouble = Vector.Create((double)config.Position.X.GetValueOrDefault(), (double)config.Position.Y.GetValueOrDefault(), (double)config.Position.Z.GetValueOrDefault()).ToUeVector(false);
		base..ctor(fvectorDouble, null);
		this.AimTarget.Set(this.TargetPosition.X, this.TargetPosition.Y, this.TargetPosition.Z);
		this.IsMainStoryTarget = (config.VisualType == EPilotThrowPointVisualType.MainStory);
		this.IsPlantFlagTarget = (config.VisualType == EPilotThrowPointVisualType.PlantFlag);
	}

	// Token: 0x06013B7D RID: 80765 RVA: 0x004F1A38 File Offset: 0x004EFC38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x06013B7E RID: 80766 RVA: 0x004F1B18 File Offset: 0x004EFD18
	protected override void OnStart()
	{
		Rotator rootActorRotation = this.RootActorRotation;
		FRotator frotator = this.RootActor.K2_GetActorRotation();
		rootActorRotation.FromUeRotator(frotator);
		this.LockContent = base.GetItem(3);
		UUIItem lockContent = this.LockContent;
		if (lockContent != null)
		{
			lockContent.SetUIActive(false);
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAsFirstHierarchy();
		}
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(!this.IsMainStoryTarget);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(this.IsMainStoryTarget);
		}
		UUIItem item3 = base.GetItem(4);
		if (item3 != null)
		{
			item3.SetUIActive(this.IsMainStoryTarget);
		}
		UUIItem item4 = base.GetItem(6);
		if (item4 != null)
		{
			item4.SetUIActive(!this.IsMainStoryTarget);
		}
		UUIItem item5 = base.GetItem(7);
		if (item5 != null)
		{
			item5.SetUIActive(this.IsMainStoryTarget);
		}
		if (this.IsPlantFlagTarget)
		{
			UUIItem item6 = base.GetItem(5);
			if (item6 != null)
			{
				item6.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "FlagChallenge_BossWarning", Array.Empty<object>());
		}
		else
		{
			UUIItem item7 = base.GetItem(5);
			if (item7 != null)
			{
				item7.SetUIActive(false);
			}
		}
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		UUIItem rootItem2 = this.RootItem;
		if (rootItem2 != null)
		{
			rootItem2.SetUIRelativeLocation(UKismetMathLibrary.Conv_VectorDoubleToVector(this.TargetPosition));
		}
		this.UpdateScale();
		UUIItem item8 = base.GetItem(0);
		if (item8 != null)
		{
			item8.SetUIActive(false);
		}
		this.InitEffect();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.PilotThrow;
		ELogAuthor author = ELogAuthor.CH;
		string message = "[PilotThrowTargetItem.OnStart] 初始化目标点";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", PilotThrowModel.Instance.GetCurrentInteractHookPoint());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06013B7F RID: 80767 RVA: 0x004F1CF4 File Offset: 0x004EFEF4
	private void InitEffect()
	{
		if (PilotThrowTargetItem.LineTrace == null)
		{
			PilotThrowTargetItem.InitLineTraceInfo();
		}
		TraceElementCommon.Instance.SetStartLocation(PilotThrowTargetItem.LineTrace, this.TargetPosition);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, -6000.0);
		FVectorDouble fvectorDouble2 = this.TargetPosition + fvectorDouble;
		TraceElementCommon.Instance.SetEndLocation(PilotThrowTargetItem.LineTrace, fvectorDouble2);
		if (TraceElementCommon.Instance.LineTrace(PilotThrowTargetItem.LineTrace, "PilotThrowTargetItem"))
		{
			Vector vector = Vector.Create();
			TraceElementCommon.Instance.GetHitLocation(PilotThrowTargetItem.LineTrace.HitResult, 0, vector);
			FTransformDouble value = new FTransformDouble(ref MathUtils.Instance.DefaultTransform);
			fvectorDouble = vector.ToUeVector(false);
			value.SetLocation(fvectorDouble);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			this.EffectHandle = new int?(instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/BigWorld/LHL/DA_Fx_Group_Sl2_LHL_Guangzhu_60M.DA_Fx_Group_Sl2_LHL_Guangzhu_60M", "PilotThrowTargetItem", null, EEffectType.Scene, null, null, null, false, false));
		}
	}

	// Token: 0x06013B80 RID: 80768 RVA: 0x004F1DF4 File Offset: 0x004EFFF4
	private static void InitLineTraceInfo()
	{
		PilotThrowTargetItem.LineTrace = new UTraceLineElement();
		PilotThrowTargetItem.LineTrace.WorldContextObject = GlobalData.World;
		PilotThrowTargetItem.LineTrace.bIsSingle = false;
		PilotThrowTargetItem.LineTrace.bIgnoreSelf = true;
		PilotThrowTargetItem.LineTrace.bIsProfile = true;
		PilotThrowTargetItem.LineTrace.DrawTime = 0.5f;
		TraceElementCommon.Instance.SetTraceColor(PilotThrowTargetItem.LineTrace, PilotThrowTargetItem.LineTraceColor);
		TraceElementCommon.Instance.SetTraceHitColor(PilotThrowTargetItem.LineTrace, new FLinearColor(0f, 1f, 0f, 1f));
	}

	// Token: 0x06013B81 RID: 80769 RVA: 0x004F1E86 File Offset: 0x004F0086
	private void OnSequenceClose(string sequenceName)
	{
		if (!(sequenceName == "Lock_Out_new"))
		{
			if (sequenceName == "Close")
			{
				this.CloseMeAsync().Forget<bool>();
			}
			return;
		}
		UUIItem lockContent = this.LockContent;
		if (lockContent == null)
		{
			return;
		}
		lockContent.SetUIActive(false);
	}

	// Token: 0x06013B82 RID: 80770 RVA: 0x004F1EC0 File Offset: 0x004F00C0
	public void Close()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}
		int? effectHandle = this.EffectHandle;
		if (effectHandle != null && effectHandle.GetValueOrDefault() != 0)
		{
			EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "PilotThrowTargetItem", false, null);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.PilotThrow;
		ELogAuthor author = ELogAuthor.CH;
		string message = "[PilotThrowTargetItem.Close] 关闭目标点";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", PilotThrowModel.Instance.GetCurrentInteractHookPoint());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06013B83 RID: 80771 RVA: 0x004F1F64 File Offset: 0x004F0164
	public override void OnTick(float delta)
	{
		this.UpdateRotation();
		bool flag = PilotThrowModel.Instance.IsInProjectileSplineLastPointRange(this.AimTarget);
		if (flag != this.LastInTargetRange)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopPlayingSequence(false, true);
			}
			if (flag)
			{
				UUIItem lockContent = this.LockContent;
				if (lockContent != null)
				{
					lockContent.SetUIActive(flag);
				}
				PilotThrowModel.Instance.CurrentInRangePoint = Vector.Create(this.TargetPosition.X, this.TargetPosition.Y, this.TargetPosition.Z);
			}
			else
			{
				PilotThrowModel.Instance.CurrentInRangePoint = null;
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.PlayLevelSequenceByName(flag ? "Lock_In_new" : "Lock_Out_new", false, null, false);
			}
			this.LastInTargetRange = flag;
			Action<bool> onTargetInOutRange = this.OnTargetInOutRange;
			if (onTargetInOutRange == null)
			{
				return;
			}
			onTargetInOutRange(flag);
		}
	}

	// Token: 0x06013B84 RID: 80772 RVA: 0x004F203C File Offset: 0x004F023C
	public void UpdateRotation()
	{
		Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
		this.RootActorRotation.Yaw = cameraRotator.Yaw + 90f;
		this.RootActorRotation.Roll = cameraRotator.Pitch - 90f;
		this.RootActorRotation.Pitch = 0f;
		UUIItem rootItem = this.RootItem;
		FRotator frotator = this.RootActorRotation.ToUeRotator();
		rootItem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06013B85 RID: 80773 RVA: 0x004F20B0 File Offset: 0x004F02B0
	public void UpdateScale()
	{
		float inTime = (float)Vector.Dist(Vector.Create(CameraController.Instance.MainModel.CameraLocation), this.AimTarget) / 100f;
		float floatValue = PilotThrowModel.Instance.Setting.缩放曲线.GetFloatValue(inTime);
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetRelativeScale3D(new FVector(floatValue, floatValue, floatValue));
	}

	// Token: 0x0400948E RID: 38030
	[Nullable(2)]
	private UUIItem LockContent;

	// Token: 0x0400948F RID: 38031
	protected Rotator RootActorRotation = Rotator.Create();

	// Token: 0x04009490 RID: 38032
	private readonly Vector AimTarget = Vector.Create();

	// Token: 0x04009491 RID: 38033
	private readonly bool IsMainStoryTarget;

	// Token: 0x04009492 RID: 38034
	private readonly bool IsPlantFlagTarget;

	// Token: 0x04009493 RID: 38035
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04009494 RID: 38036
	[Nullable(2)]
	public Action<bool> OnTargetInOutRange;

	// Token: 0x04009495 RID: 38037
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	private static UTraceLineElement LineTrace = null;

	// Token: 0x04009496 RID: 38038
	private int? EffectHandle;

	// Token: 0x04009497 RID: 38039
	private bool LastInTargetRange;

	// Token: 0x04009498 RID: 38040
	private const string EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/BigWorld/LHL/DA_Fx_Group_Sl2_LHL_Guangzhu_60M.DA_Fx_Group_Sl2_LHL_Guangzhu_60M";

	// Token: 0x04009499 RID: 38041
	private static readonly FLinearColor LineTraceColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400949A RID: 38042
	private const string TEXT_TARGET_NAME_KEY = "FlagChallenge_BossWarning";

	// Token: 0x02008C1B RID: 35867
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x0402D7C0 RID: 186304
		public const int DirectionItem = 0;

		// Token: 0x0402D7C1 RID: 186305
		public const int DefaultContent = 1;

		// Token: 0x0402D7C2 RID: 186306
		public const int MainContent = 2;

		// Token: 0x0402D7C3 RID: 186307
		public const int LockContent = 3;

		// Token: 0x0402D7C4 RID: 186308
		public const int MainEffect = 4;

		// Token: 0x0402D7C5 RID: 186309
		public const int PnlInfo = 5;

		// Token: 0x0402D7C6 RID: 186310
		public const int LockDefaultContent = 6;

		// Token: 0x0402D7C7 RID: 186311
		public const int LockMainContent = 7;

		// Token: 0x0402D7C8 RID: 186312
		public const int TargetNameText = 8;
	}
}
