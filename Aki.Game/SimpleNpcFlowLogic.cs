using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow;
using CSharpScript.Game;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02003263 RID: 12899
[NullableContext(1)]
[Nullable(0)]
public class SimpleNpcFlowLogic : INpcIconFunction
{
	// Token: 0x0601BDEE RID: 114158 RVA: 0x007B5B53 File Offset: 0x007B3D53
	public SimpleNpcFlowLogic(TsSimpleNpc target)
	{
		this.Target = target;
		this.SelfLocation = new FVectorDouble?(target.D_K2_GetActorLocation());
	}

	// Token: 0x0601BDEF RID: 114159 RVA: 0x007B5B74 File Offset: 0x007B3D74
	public void StartFlowLogic()
	{
		this.FlowComponent = (this.Target.GetComponentByClass(SimpleNpcFlowComponent_C.StaticClass()) as SimpleNpcFlowComponent_C);
		if (this.FlowComponent == null)
		{
			return;
		}
		TArray<SimpleNpcFlowData> flowList = this.FlowComponent.FlowList;
		if (flowList != null && flowList.Num() > 0)
		{
			this.MultiplyLogic = new SimpleNpcMultiplyLogic(this.FlowComponent);
			this.InitTriggerRange();
			this.CheckFlowRangeLogic();
		}
	}

	// Token: 0x0601BDF0 RID: 114160 RVA: 0x007B5BE4 File Offset: 0x007B3DE4
	private void InitTriggerRange()
	{
		FFloatRange checkRange = this.FlowComponent.CheckRange;
		this.MinCheckDistanceSquared = new float?(checkRange.LowerBound.Value * checkRange.LowerBound.Value);
		this.MaxCheckDistanceSquared = new float?(checkRange.UpperBound.Value * checkRange.UpperBound.Value);
	}

	// Token: 0x0601BDF1 RID: 114161 RVA: 0x007B5C44 File Offset: 0x007B3E44
	public UniTask AddHeadView()
	{
		SimpleNpcFlowLogic.<AddHeadView>d__14 <AddHeadView>d__;
		<AddHeadView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddHeadView>d__.<>4__this = this;
		<AddHeadView>d__.<>1__state = -1;
		<AddHeadView>d__.<>t__builder.Start<SimpleNpcFlowLogic.<AddHeadView>d__14>(ref <AddHeadView>d__);
		return <AddHeadView>d__.<>t__builder.Task;
	}

	// Token: 0x0601BDF2 RID: 114162 RVA: 0x007B5C87 File Offset: 0x007B3E87
	public void ShowDialog(string text, float removeSeconds)
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetDialogueText(text, removeSeconds, false);
	}

	// Token: 0x0601BDF3 RID: 114163 RVA: 0x007B5C9C File Offset: 0x007B3E9C
	public void HideDialog()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.HideDialogueText();
	}

	// Token: 0x0601BDF4 RID: 114164 RVA: 0x007B5CB0 File Offset: 0x007B3EB0
	public bool TryPlayMontage(string montagePath)
	{
		if (this.Target.Mesh == null)
		{
			return false;
		}
		if (this.Target.Mesh.AnimationMode == EAnimationMode.AnimationSingleNode)
		{
			return false;
		}
		UAnimInstance animInstance = this.Target.Mesh.AnimScriptInstance;
		if (animInstance == null)
		{
			return false;
		}
		string montageResPathByName = this.GetMontageResPathByName(montagePath);
		if (!string.IsNullOrEmpty(montageResPathByName))
		{
			ResourceSystem.Instance.LoadAsync<UAnimMontage>(montageResPathByName, delegate([Nullable(2)] UAnimMontage montageAsset, string _)
			{
				if (ObjectUtils.IsValid(montageAsset) && animInstance != null)
				{
					this.TempMontageRemoveTime = montageAsset.SequenceLength;
					animInstance.Montage_Play(montageAsset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
				}
			}, 100, "js_undefined");
		}
		return false;
	}

	// Token: 0x0601BDF5 RID: 114165 RVA: 0x007B5D48 File Offset: 0x007B3F48
	private void InitMontageResPath()
	{
		if (!string.IsNullOrEmpty(this.MontageResPath))
		{
			return;
		}
		UAnimInstance animScriptInstance = this.Target.Mesh.AnimScriptInstance;
		if (animScriptInstance == null)
		{
			return;
		}
		string pathName = UKismetSystemLibrary.GetPathName(animScriptInstance);
		if (string.IsNullOrEmpty(pathName))
		{
			return;
		}
		string text = pathName.Substring(0, pathName.LastIndexOf("/"));
		text = text.Substring(0, text.LastIndexOf("/"));
		this.MontageResPath = string.Join("", new List<string>
		{
			text,
			"/Montage"
		});
	}

	// Token: 0x0601BDF6 RID: 114166 RVA: 0x007B5DD8 File Offset: 0x007B3FD8
	[return: Nullable(2)]
	private string GetMontageResPathByName(string montageName)
	{
		if (string.IsNullOrEmpty(montageName) || montageName.Contains("/"))
		{
			return montageName;
		}
		this.InitMontageResPath();
		if (!string.IsNullOrEmpty(this.MontageResPath))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(this.MontageResPath);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(montageName);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted(montageName);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return null;
	}

	// Token: 0x0601BDF7 RID: 114167 RVA: 0x007B5E58 File Offset: 0x007B4058
	public void Tick(float deltaSeconds)
	{
		if (this.TempMontageRemoveTime > 0f)
		{
			this.TempMontageRemoveTime -= deltaSeconds;
			if (this.TempMontageRemoveTime < 0f)
			{
				this.StopMontage();
			}
		}
		if (this.MultiplyLogic != null)
		{
			this.CheckFlowRangeLogic();
			this.MultiplyLogic.Tick(deltaSeconds);
		}
	}

	// Token: 0x0601BDF8 RID: 114168 RVA: 0x007B5EB0 File Offset: 0x007B40B0
	public void StopMontage()
	{
		this.TempMontageRemoveTime = 0f;
		if (this.Target == null || this.Target.Mesh == null)
		{
			return;
		}
		if (this.Target.Mesh.AnimationMode == EAnimationMode.AnimationSingleNode)
		{
			return;
		}
		UAnimInstance animScriptInstance = this.Target.Mesh.AnimScriptInstance;
		if (animScriptInstance == null)
		{
			return;
		}
		if (animScriptInstance.IsAnyMontagePlaying())
		{
			animScriptInstance.Montage_Stop(0.3f, null);
		}
	}

	// Token: 0x0601BDF9 RID: 114169 RVA: 0x007B5F28 File Offset: 0x007B4128
	private void CheckFlowRangeLogic()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return;
		}
		FVectorDouble actorLocation = baseCharacter.CharacterActorComponent.ActorLocation;
		FVectorDouble value = this.SelfLocation.Value;
		double num = FVectorDouble.DistSquared2D(actorLocation, value);
		double num2 = num;
		float? num3 = this.MinCheckDistanceSquared;
		double? num4 = (num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null;
		if (num2 < num4.GetValueOrDefault() & num4 != null)
		{
			if (!this.IsEnter)
			{
				if (!this.MultiplyLogic.IsPlaying && !this.Target.IsHiding)
				{
					this.MultiplyLogic.StartFlow();
				}
				else
				{
					this.MultiplyLogic.IsPause = false;
				}
			}
			this.IsEnter = true;
			return;
		}
		double num5 = num;
		num3 = this.MaxCheckDistanceSquared;
		num4 = ((num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null);
		if (num5 < num4.GetValueOrDefault() & num4 != null)
		{
			this.IsEnter = false;
			this.MultiplyLogic.IsPause = true;
			return;
		}
		this.IsEnter = false;
		this.MultiplyLogic.IsPause = true;
		if (this.MultiplyLogic.IsPlaying)
		{
			this.MultiplyLogic.StopFlow();
		}
	}

	// Token: 0x0601BDFA RID: 114170 RVA: 0x007B6063 File Offset: 0x007B4263
	public void FilterFlowWorldState()
	{
		SimpleNpcMultiplyLogic multiplyLogic = this.MultiplyLogic;
		if (multiplyLogic == null)
		{
			return;
		}
		multiplyLogic.FilterFlowWorldState();
	}

	// Token: 0x0601BDFB RID: 114171 RVA: 0x007B6075 File Offset: 0x007B4275
	public void ForceStopFlow()
	{
		this.IsEnter = false;
		SimpleNpcMultiplyLogic multiplyLogic = this.MultiplyLogic;
		if (multiplyLogic != null && multiplyLogic.IsPlaying)
		{
			this.MultiplyLogic.StopFlow();
		}
	}

	// Token: 0x0601BDFC RID: 114172 RVA: 0x007B609D File Offset: 0x007B429D
	public void Dispose()
	{
		this.Target = null;
		this.FlowComponent = null;
		this.MultiplyLogic = null;
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.Destroy();
	}

	// Token: 0x0601BDFD RID: 114173 RVA: 0x007B60C4 File Offset: 0x007B42C4
	public Vector GetSelfLocation()
	{
		return this.Target.SelfLocationProxy;
	}

	// Token: 0x0601BDFE RID: 114174 RVA: 0x007B60D1 File Offset: 0x007B42D1
	[NullableContext(2)]
	public UPrimitiveComponent GetAttachToMeshComponent()
	{
		return this.Target.Mesh;
	}

	// Token: 0x0601BDFF RID: 114175 RVA: 0x007B60DE File Offset: 0x007B42DE
	public string GetAttachToSocketName()
	{
		return NpcIconConfig.Instance.GetNpcIconSocketName();
	}

	// Token: 0x0601BE00 RID: 114176 RVA: 0x007B60EC File Offset: 0x007B42EC
	public void GetAttachToLocation(Vector outVec)
	{
		float capsuleHalfHeight = this.Target.CapsuleCollision.CapsuleHalfHeight;
		Vector selfLocationProxy = this.Target.SelfLocationProxy;
		outVec.Set(selfLocationProxy.X, selfLocationProxy.Y, selfLocationProxy.Z + (double)capsuleHalfHeight);
	}

	// Token: 0x0601BE01 RID: 114177 RVA: 0x007B6131 File Offset: 0x007B4331
	public double GetAddOffsetZ()
	{
		return 0.0;
	}

	// Token: 0x0601BE02 RID: 114178 RVA: 0x007B613C File Offset: 0x007B433C
	public bool IsShowNameInfo()
	{
		return false;
	}

	// Token: 0x0601BE03 RID: 114179 RVA: 0x007B613F File Offset: 0x007B433F
	public bool IsShowQuestInfo()
	{
		return false;
	}

	// Token: 0x0601BE04 RID: 114180 RVA: 0x007B6142 File Offset: 0x007B4342
	public bool IsShowPlayerInfo()
	{
		return false;
	}

	// Token: 0x0601BE05 RID: 114181 RVA: 0x007B6145 File Offset: 0x007B4345
	public bool CanTick(float deltaTime)
	{
		return true;
	}

	// Token: 0x0601BE06 RID: 114182 RVA: 0x007B6148 File Offset: 0x007B4348
	public bool IsInHeadItemShowRange(double disSquared, double maxShowRangeDisSquared, double minShowRangeDisSquared)
	{
		return disSquared < maxShowRangeDisSquared && disSquared > minShowRangeDisSquared;
	}

	// Token: 0x0601BE07 RID: 114183 RVA: 0x007B6154 File Offset: 0x007B4354
	public float GetDialogWorldScale3D()
	{
		return 0.5f;
	}

	// Token: 0x0601BE08 RID: 114184 RVA: 0x007B615B File Offset: 0x007B435B
	public bool TryGetHeadStateFollowData(HeadStateFollowData outData)
	{
		return false;
	}

	// Token: 0x0400DBE8 RID: 56296
	private const float STOP_MONTAGE_BLEND_OUT_TIME = 0.3f;

	// Token: 0x0400DBE9 RID: 56297
	[Nullable(2)]
	private TsSimpleNpc Target;

	// Token: 0x0400DBEA RID: 56298
	[Nullable(2)]
	private SimpleNpcFlowComponent_C FlowComponent;

	// Token: 0x0400DBEB RID: 56299
	[Nullable(2)]
	private NpcIconComponent IconComponent;

	// Token: 0x0400DBEC RID: 56300
	[Nullable(2)]
	private SimpleNpcMultiplyLogic MultiplyLogic;

	// Token: 0x0400DBED RID: 56301
	private float TempMontageRemoveTime;

	// Token: 0x0400DBEE RID: 56302
	private bool IsEnter;

	// Token: 0x0400DBEF RID: 56303
	[Nullable(2)]
	private string MontageResPath;

	// Token: 0x0400DBF0 RID: 56304
	private float? MinCheckDistanceSquared;

	// Token: 0x0400DBF1 RID: 56305
	private float? MaxCheckDistanceSquared;

	// Token: 0x0400DBF2 RID: 56306
	private readonly FVectorDouble? SelfLocation;
}
