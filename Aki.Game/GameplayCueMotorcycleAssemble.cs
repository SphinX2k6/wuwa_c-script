using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;

// Token: 0x0200251F RID: 9503
public class GameplayCueMotorcycleAssemble : GameplayCueBase
{
	// Token: 0x06017819 RID: 96281 RVA: 0x006EFAC0 File Offset: 0x006EDCC0
	protected override void OnInit()
	{
		base.OnInit();
		this.Resource = null;
	}

	// Token: 0x0601781A RID: 96282 RVA: 0x006EFACF File Offset: 0x006EDCCF
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
	}

	// Token: 0x0601781B RID: 96283 RVA: 0x006EFAD8 File Offset: 0x006EDCD8
	protected override void OnCreate()
	{
		base.OnCreate();
		ResourceSystem.Instance.LoadAsync<UObject>(base.GetPath(), delegate([Nullable(2)] UObject res, string _)
		{
			if (!this.IsActive)
			{
				return;
			}
			this.Resource = res;
			this.AddMotorcycleAssemble();
		}, 100, "js_undefined");
	}

	// Token: 0x0601781C RID: 96284 RVA: 0x006EFB04 File Offset: 0x006EDD04
	protected override void OnDestroy()
	{
		base.OnDestroy();
		this.Resource = null;
		this.RemoveMotorcycleAssemble();
	}

	// Token: 0x0601781D RID: 96285 RVA: 0x006EFB1C File Offset: 0x006EDD1C
	private unsafe void AddMotorcycleAssemble()
	{
		if (!this.ActorInternal.IsValid() || this.Resource == null)
		{
			return;
		}
		PD_MotorExtraComponentData_C pd_MotorExtraComponentData_C = this.Resource as PD_MotorExtraComponentData_C;
		if (pd_MotorExtraComponentData_C != null)
		{
			base.GetCharRenderingComponent().AddMotorExtraComp(pd_MotorExtraComponentData_C);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.GHY;
		string message = "摩托车拼装传入DA类型错误:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Buff特效Id", this.CueConfig.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DA路径", this.CueConfig.Path);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0601781E RID: 96286 RVA: 0x006EFBC8 File Offset: 0x006EDDC8
	private void RemoveMotorcycleAssemble()
	{
		CharRenderingComponent charRenderingComponent = base.GetCharRenderingComponent();
		if (charRenderingComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "RemoveMaterialController CharRenderingComponent为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.CueConfig.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		charRenderingComponent.RemoveMotorExtraComp();
	}

	// Token: 0x0400C7F6 RID: 51190
	[Nullable(2)]
	private UObject Resource;
}
