using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;

// Token: 0x02002FCB RID: 12235
public class GameplayCueMotorcycleAssemble : GameplayCueBase
{
	// Token: 0x06019F07 RID: 106247 RVA: 0x006C91EC File Offset: 0x006C73EC
	protected override void OnInit()
	{
		base.OnInit();
		this.Resource = null;
	}

	// Token: 0x06019F08 RID: 106248 RVA: 0x006C91FB File Offset: 0x006C73FB
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
	}

	// Token: 0x06019F09 RID: 106249 RVA: 0x006C9204 File Offset: 0x006C7404
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

	// Token: 0x06019F0A RID: 106250 RVA: 0x006C9230 File Offset: 0x006C7430
	protected override void OnDestroy()
	{
		base.OnDestroy();
		this.Resource = null;
		this.RemoveMotorcycleAssemble();
	}

	// Token: 0x06019F0B RID: 106251 RVA: 0x006C9248 File Offset: 0x006C7448
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

	// Token: 0x06019F0C RID: 106252 RVA: 0x006C92F4 File Offset: 0x006C74F4
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

	// Token: 0x0400C44D RID: 50253
	[Nullable(2)]
	private UObject Resource;
}
