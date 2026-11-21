using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow;
using CSharpScript.Game;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020027D2 RID: 10194
[NullableContext(1)]
[Nullable(0)]
public class SimpleNpcFlowLogic : INpcIconFunction
{
	// Token: 0x060199C5 RID: 104901 RVA: 0x007DDCC7 File Offset: 0x007DBEC7
	public SimpleNpcFlowLogic(TsSimpleNpc target)
	{
		this.Target = target;
		this.SelfLocation = new FVectorDouble?(target.D_K2_GetActorLocation());
	}

	// Token: 0x060199C6 RID: 104902 RVA: 0x007DDCE8 File Offset: 0x007DBEE8
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

	// Token: 0x060199C7 RID: 104903 RVA: 0x007DDD58 File Offset: 0x007DBF58
	private void InitTriggerRange()
	{
		FFloatRange checkRange = this.FlowComponent.CheckRange;
		this.MinCheckDistanceSquared = new float?(checkRange.LowerBound.Value * checkRange.LowerBound.Value);
		this.MaxCheckDistanceSquared = new float?(checkRange.UpperBound.Value * checkRange.UpperBound.Value);
	}

	// Token: 0x060199C8 RID: 104904 RVA: 0x007DDDB8 File Offset: 0x007DBFB8
	public UniTask AddHeadView()
	{
		SimpleNpcFlowLogic.<AddHeadView>d__14 <AddHeadView>d__;
		<AddHeadView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddHeadView>d__.<>4__this = this;
		<AddHeadView>d__.<>1__state = -1;
		<AddHeadView>d__.<>t__builder.Start<SimpleNpcFlowLogic.<AddHeadView>d__14>(ref <AddHeadView>d__);
		return <AddHeadView>d__.<>t__builder.Task;
	}

	// Token: 0x060199C9 RID: 104905 RVA: 0x007DDDFB File Offset: 0x007DBFFB
	public void ShowDialog(string text, float removeSeconds)
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetDialogueText(text, removeSeconds, false);
	}

	// Token: 0x060199CA RID: 104906 RVA: 0x007DDE10 File Offset: 0x007DC010
	public void HideDialog()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.HideDialogueText();
	}

	// Token: 0x060199CB RID: 104907 RVA: 0x007DDE24 File Offset: 0x007DC024
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

	// Token: 0x060199CC RID: 104908 RVA: 0x007DDEBC File Offset: 0x007DC0BC
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

	// Token: 0x060199CD RID: 104909 RVA: 0x007DDF4C File Offset: 0x007DC14C
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

	// Token: 0x060199CE RID: 104910 RVA: 0x007DDFCC File Offset: 0x007DC1CC
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

	// Token: 0x060199CF RID: 104911 RVA: 0x007DE024 File Offset: 0x007DC224
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

	// Token: 0x060199D0 RID: 104912 RVA: 0x007DE09C File Offset: 0x007DC29C
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

	// Token: 0x060199D1 RID: 104913 RVA: 0x007DE1D7 File Offset: 0x007DC3D7
	public void FilterFlowWorldState()
	{
		SimpleNpcMultiplyLogic multiplyLogic = this.MultiplyLogic;
		if (multiplyLogic == null)
		{
			return;
		}
		multiplyLogic.FilterFlowWorldState();
	}

	// Token: 0x060199D2 RID: 104914 RVA: 0x007DE1E9 File Offset: 0x007DC3E9
	public void ForceStopFlow()
	{
		this.IsEnter = false;
		SimpleNpcMultiplyLogic multiplyLogic = this.MultiplyLogic;
		if (multiplyLogic != null && multiplyLogic.IsPlaying)
		{
			this.MultiplyLogic.StopFlow();
		}
	}

	// Token: 0x060199D3 RID: 104915 RVA: 0x007DE211 File Offset: 0x007DC411
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

	// Token: 0x060199D4 RID: 104916 RVA: 0x007DE238 File Offset: 0x007DC438
	public Vector GetSelfLocation()
	{
		return this.Target.SelfLocationProxy;
	}

	// Token: 0x060199D5 RID: 104917 RVA: 0x007DE245 File Offset: 0x007DC445
	[NullableContext(2)]
	public UPrimitiveComponent GetAttachToMeshComponent()
	{
		return this.Target.Mesh;
	}

	// Token: 0x060199D6 RID: 104918 RVA: 0x007DE252 File Offset: 0x007DC452
	public string GetAttachToSocketName()
	{
		return NpcIconConfig.Instance.GetNpcIconSocketName();
	}

	// Token: 0x060199D7 RID: 104919 RVA: 0x007DE260 File Offset: 0x007DC460
	public void GetAttachToLocation(Vector outVec)
	{
		float capsuleHalfHeight = this.Target.CapsuleCollision.CapsuleHalfHeight;
		Vector selfLocationProxy = this.Target.SelfLocationProxy;
		outVec.Set(selfLocationProxy.X, selfLocationProxy.Y, selfLocationProxy.Z + (double)capsuleHalfHeight);
	}

	// Token: 0x060199D8 RID: 104920 RVA: 0x007DE2A5 File Offset: 0x007DC4A5
	public double GetAddOffsetZ()
	{
		return 0.0;
	}

	// Token: 0x060199D9 RID: 104921 RVA: 0x007DE2B0 File Offset: 0x007DC4B0
	public bool IsShowNameInfo()
	{
		return false;
	}

	// Token: 0x060199DA RID: 104922 RVA: 0x007DE2B3 File Offset: 0x007DC4B3
	public bool IsShowQuestInfo()
	{
		return false;
	}

	// Token: 0x060199DB RID: 104923 RVA: 0x007DE2B6 File Offset: 0x007DC4B6
	public bool IsShowPlayerInfo()
	{
		return false;
	}

	// Token: 0x060199DC RID: 104924 RVA: 0x007DE2B9 File Offset: 0x007DC4B9
	public bool CanTick(float deltaTime)
	{
		return true;
	}

	// Token: 0x060199DD RID: 104925 RVA: 0x007DE2BC File Offset: 0x007DC4BC
	public bool IsInHeadItemShowRange(double disSquared, double maxShowRangeDisSquared, double minShowRangeDisSquared)
	{
		return disSquared < maxShowRangeDisSquared && disSquared > minShowRangeDisSquared;
	}

	// Token: 0x060199DE RID: 104926 RVA: 0x007DE2C8 File Offset: 0x007DC4C8
	public float GetDialogWorldScale3D()
	{
		return 0.5f;
	}

	// Token: 0x060199DF RID: 104927 RVA: 0x007DE2CF File Offset: 0x007DC4CF
	public bool TryGetHeadStateFollowData(HeadStateFollowData outData)
	{
		return false;
	}

	// Token: 0x0400E087 RID: 57479
	private const float STOP_MONTAGE_BLEND_OUT_TIME = 0.3f;

	// Token: 0x0400E088 RID: 57480
	[Nullable(2)]
	private TsSimpleNpc Target;

	// Token: 0x0400E089 RID: 57481
	[Nullable(2)]
	private SimpleNpcFlowComponent_C FlowComponent;

	// Token: 0x0400E08A RID: 57482
	[Nullable(2)]
	private NpcIconComponent IconComponent;

	// Token: 0x0400E08B RID: 57483
	[Nullable(2)]
	private SimpleNpcMultiplyLogic MultiplyLogic;

	// Token: 0x0400E08C RID: 57484
	private float TempMontageRemoveTime;

	// Token: 0x0400E08D RID: 57485
	private bool IsEnter;

	// Token: 0x0400E08E RID: 57486
	[Nullable(2)]
	private string MontageResPath;

	// Token: 0x0400E08F RID: 57487
	private float? MinCheckDistanceSquared;

	// Token: 0x0400E090 RID: 57488
	private float? MaxCheckDistanceSquared;

	// Token: 0x0400E091 RID: 57489
	private readonly FVectorDouble? SelfLocation;
}
