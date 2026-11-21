using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200599A RID: 22938
	public class SolarSchoolPlotTextItem : UiPanelBase
	{
		// Token: 0x060388F7 RID: 231671 RVA: 0x00FD31FC File Offset: 0x00FD13FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060388F8 RID: 231672 RVA: 0x00FD3288 File Offset: 0x00FD1488
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolPlotTextItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolPlotTextItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060388F9 RID: 231673 RVA: 0x00FD32CC File Offset: 0x00FD14CC
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x060388FA RID: 231674 RVA: 0x00FD32F8 File Offset: 0x00FD14F8
		[NullableContext(1)]
		public void ShowRoleTalk(string roleName, string content, bool showSpine = false)
		{
			this.SetFormVisible(true);
			SolarSchoolRoleTalkItem roleTalkItem = this.RoleTalkItem;
			if (roleTalkItem == null)
			{
				return;
			}
			roleTalkItem.Refresh(roleName, content, showSpine);
		}

		// Token: 0x060388FB RID: 231675 RVA: 0x00FD3314 File Offset: 0x00FD1514
		[NullableContext(1)]
		public void ShowTalk(string content)
		{
			this.SetFormVisible(false);
			SolarSchoolTalkItem talkItem = this.TalkItem;
			if (talkItem == null)
			{
				return;
			}
			talkItem.Refresh(content);
		}

		// Token: 0x060388FC RID: 231676 RVA: 0x00FD332E File Offset: 0x00FD152E
		private void SetFormVisible(bool roleTalk)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(roleTalk);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!roleTalk);
		}

		// Token: 0x0401DC9C RID: 122012
		[Nullable(2)]
		private SolarSchoolRoleTalkItem RoleTalkItem;

		// Token: 0x0401DC9D RID: 122013
		[Nullable(2)]
		private SolarSchoolTalkItem TalkItem;

		// Token: 0x0200B543 RID: 46403
		private class EComponents
		{
			// Token: 0x040380B1 RID: 229553
			public const int PnlRoleTalk = 0;

			// Token: 0x040380B2 RID: 229554
			public const int PnlTalk = 1;

			// Token: 0x040380B3 RID: 229555
			public const int BtnNext = 2;
		}
	}
}
