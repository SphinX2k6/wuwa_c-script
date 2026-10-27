using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062EE RID: 25326
	public class PinballRoleGainView : UiViewBase
	{
		// Token: 0x0603FBBB RID: 261051 RVA: 0x00F6BB4C File Offset: 0x00F69D4C
		[NullableContext(1)]
		public PinballRoleGainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170092AC RID: 37548
		// (get) Token: 0x0603FBBC RID: 261052 RVA: 0x00F6BB55 File Offset: 0x00F69D55
		[Nullable(2)]
		public new PinballRoleGainViewParam OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as PinballRoleGainViewParam;
			}
		}

		// Token: 0x0603FBBD RID: 261053 RVA: 0x00F6BB64 File Offset: 0x00F69D64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FBBE RID: 261054 RVA: 0x00F6BC4C File Offset: 0x00F69E4C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleGainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleGainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FBBF RID: 261055 RVA: 0x00F6BC90 File Offset: 0x00F69E90
		protected override void OnStart()
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(this.OpenParam.RoleId);
			if (pinballRoleConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游角色配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", this.OpenParam.RoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(pinballRoleConfigById.Value.RoleId);
			if (roleConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "角色表角色配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RoleId", pinballRoleConfigById.Value.RoleId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "Pinball_Character_unlock", new <>z__ReadOnlySingleElementList<object>(localTextNew));
		}

		// Token: 0x0603FBC0 RID: 261056 RVA: 0x00F6BD8C File Offset: 0x00F69F8C
		private void OnClickBtnMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200C4E3 RID: 50403
		private enum EComponent
		{
			// Token: 0x0403B6A7 RID: 243367
			SpineRoleShadow,
			// Token: 0x0403B6A8 RID: 243368
			SpineRole,
			// Token: 0x0403B6A9 RID: 243369
			RoleName,
			// Token: 0x0403B6AA RID: 243370
			BtnMask
		}
	}
}
