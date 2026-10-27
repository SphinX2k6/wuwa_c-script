using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.RoleSelect
{
	// Token: 0x02005735 RID: 22325
	public class KurotatoRoleSelectView : UiViewBase
	{
		// Token: 0x06038C1E RID: 232478 RVA: 0x00D7942B File Offset: 0x00D7762B
		[NullableContext(1)]
		public KurotatoRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C1F RID: 232479 RVA: 0x00D79434 File Offset: 0x00D77634
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038C20 RID: 232480 RVA: 0x00D794A0 File Offset: 0x00D776A0
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoRoleSelectView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoRoleSelectView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C21 RID: 232481 RVA: 0x00D794E3 File Offset: 0x00D776E3
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038C22 RID: 232482 RVA: 0x00D794EC File Offset: 0x00D776EC
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(574);
		}

		// Token: 0x0401DC6E RID: 121966
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DC6F RID: 121967
		[Nullable(2)]
		private KurotatoRoleSelectPanel RoleSelectPanel;

		// Token: 0x0200B90C RID: 47372
		private enum EComponent
		{
			// Token: 0x04037F84 RID: 229252
			ItemCaption,
			// Token: 0x04037F85 RID: 229253
			ItemContent
		}
	}
}
