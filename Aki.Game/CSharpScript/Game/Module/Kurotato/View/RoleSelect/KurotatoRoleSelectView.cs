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
	// Token: 0x0200470C RID: 18188
	public class KurotatoRoleSelectView : UiViewBase
	{
		// Token: 0x0602DB2E RID: 187182 RVA: 0x00CC7ADB File Offset: 0x00CC5CDB
		[NullableContext(1)]
		public KurotatoRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DB2F RID: 187183 RVA: 0x00CC7AE4 File Offset: 0x00CC5CE4
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

		// Token: 0x0602DB30 RID: 187184 RVA: 0x00CC7B50 File Offset: 0x00CC5D50
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoRoleSelectView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoRoleSelectView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB31 RID: 187185 RVA: 0x00CC7B93 File Offset: 0x00CC5D93
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DB32 RID: 187186 RVA: 0x00CC7B9C File Offset: 0x00CC5D9C
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(574);
		}

		// Token: 0x04018704 RID: 100100
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018705 RID: 100101
		[Nullable(2)]
		private KurotatoRoleSelectPanel RoleSelectPanel;

		// Token: 0x0200A32D RID: 41773
		private enum EComponent
		{
			// Token: 0x04032994 RID: 207252
			ItemCaption,
			// Token: 0x04032995 RID: 207253
			ItemContent
		}
	}
}
