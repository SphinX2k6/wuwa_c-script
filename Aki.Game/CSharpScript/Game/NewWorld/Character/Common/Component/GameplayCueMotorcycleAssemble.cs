using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200631E RID: 25374
	public class GameplayCueMotorcycleAssemble : GameplayCueBase
	{
		// Token: 0x0603D6B9 RID: 251577 RVA: 0x011C2B68 File Offset: 0x011C0D68
		protected override void OnInit()
		{
			base.OnInit();
			this.Resource = null;
		}

		// Token: 0x0603D6BA RID: 251578 RVA: 0x011C2B77 File Offset: 0x011C0D77
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

		// Token: 0x0603D6BB RID: 251579 RVA: 0x011C2BA3 File Offset: 0x011C0DA3
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.Resource = null;
			this.RemoveMotorcycleAssemble();
		}

		// Token: 0x0603D6BC RID: 251580 RVA: 0x011C2BB8 File Offset: 0x011C0DB8
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

		// Token: 0x0603D6BD RID: 251581 RVA: 0x011C2C70 File Offset: 0x011C0E70
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

		// Token: 0x0402091F RID: 133407
		[Nullable(2)]
		private UObject Resource;
	}
}
