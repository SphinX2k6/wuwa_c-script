using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070BA RID: 28858
	public class GameplayCueMotorcycleAssemble : GameplayCueBase
	{
		// Token: 0x060465E0 RID: 288224 RVA: 0x011A2E83 File Offset: 0x011A1083
		protected override void OnInit()
		{
			base.OnInit();
			this.Resource = null;
		}

		// Token: 0x060465E1 RID: 288225 RVA: 0x011A2E92 File Offset: 0x011A1092
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

		// Token: 0x060465E2 RID: 288226 RVA: 0x011A2EBE File Offset: 0x011A10BE
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.Resource = null;
			this.RemoveMotorcycleAssemble();
		}

		// Token: 0x060465E3 RID: 288227 RVA: 0x011A2ED4 File Offset: 0x011A10D4
		private unsafe void AddMotorcycleAssemble()
		{
			if (this.ActorInternal == null || !this.ActorInternal.IsValid() || this.Resource == null)
			{
				return;
			}
			PD_MotorExtraComponentData_C pd_MotorExtraComponentData_C = this.Resource as PD_MotorExtraComponentData_C;
			if (pd_MotorExtraComponentData_C == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.GHY;
				string message = "摩托车拼装传入DA类型错误:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Buff特效Id", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DA路径", this.CueConfig.Path);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			CharRenderingComponent charRenderingComponent = base.GetCharRenderingComponent();
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.AddMotorExtraComp(pd_MotorExtraComponentData_C);
		}

		// Token: 0x060465E4 RID: 288228 RVA: 0x011A2F8C File Offset: 0x011A118C
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

		// Token: 0x04024DE1 RID: 151009
		[Nullable(2)]
		private UObject Resource;
	}
}
