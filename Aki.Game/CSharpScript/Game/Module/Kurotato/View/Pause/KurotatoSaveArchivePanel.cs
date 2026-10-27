using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Pause
{
	// Token: 0x02005740 RID: 22336
	internal class KurotatoSaveArchivePanel : UiPanelBase
	{
		// Token: 0x06038C90 RID: 232592 RVA: 0x00D7B8A8 File Offset: 0x00D79AA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnGoDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C91 RID: 232593 RVA: 0x00D7B9B4 File Offset: 0x00D79BB4
		public void SetGoDetailActive(bool active)
		{
			UUIItem uuiitem = base.GetButton(4).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x06038C92 RID: 232594 RVA: 0x00D7B9E0 File Offset: 0x00D79BE0
		[NullableContext(2)]
		public void RefreshSaveInfo(KurotatoSaveData saveData, int saveIndex)
		{
			this.SaveIndex = saveIndex;
			bool flag = saveData != null;
			base.GetItem(0).SetUIActive(!flag);
			base.GetItem(1).SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			base.GetText(2).SetText(TimeUtil.Instance.DateFormatString((double)saveData.SaveTimestamp), true);
			base.GetText(3).SetText(ConfigMultiTextLang.GetLocalTextNew("Kurotato_Lv", null) + saveData.RoleLevel.ToString(), true);
		}

		// Token: 0x06038C93 RID: 232595 RVA: 0x00D7BA64 File Offset: 0x00D79C64
		private void OnClickBtnGoDetail()
		{
			List<KurotatoInstInfo> roleSaveInstInfos = KurotatoModel.Instance.GetRoleSaveInstInfos();
			KurotatoSaveViewOpenParam param = new KurotatoSaveViewOpenParam
			{
				InstInfos = roleSaveInstInfos,
				DefaultIndex = this.SaveIndex
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, param, null);
		}

		// Token: 0x0401DC91 RID: 122001
		private int SaveIndex;

		// Token: 0x0200B929 RID: 47401
		private enum ESaveArchiveComp
		{
			// Token: 0x04038006 RID: 229382
			PanelEmpty,
			// Token: 0x04038007 RID: 229383
			PanelInfo,
			// Token: 0x04038008 RID: 229384
			TextSaveTime,
			// Token: 0x04038009 RID: 229385
			TextSaveLevel,
			// Token: 0x0403800A RID: 229386
			BtnGoDetail
		}
	}
}
