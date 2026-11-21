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
	// Token: 0x02004717 RID: 18199
	internal class KurotatoSaveArchivePanel : UiPanelBase
	{
		// Token: 0x0602DBA0 RID: 187296 RVA: 0x00CC9F58 File Offset: 0x00CC8158
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

		// Token: 0x0602DBA1 RID: 187297 RVA: 0x00CCA064 File Offset: 0x00CC8264
		public void SetGoDetailActive(bool active)
		{
			UUIItem uuiitem = base.GetButton(4).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x0602DBA2 RID: 187298 RVA: 0x00CCA090 File Offset: 0x00CC8290
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

		// Token: 0x0602DBA3 RID: 187299 RVA: 0x00CCA114 File Offset: 0x00CC8314
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

		// Token: 0x04018727 RID: 100135
		private int SaveIndex;

		// Token: 0x0200A34A RID: 41802
		private enum ESaveArchiveComp
		{
			// Token: 0x04032A16 RID: 207382
			PanelEmpty,
			// Token: 0x04032A17 RID: 207383
			PanelInfo,
			// Token: 0x04032A18 RID: 207384
			TextSaveTime,
			// Token: 0x04032A19 RID: 207385
			TextSaveLevel,
			// Token: 0x04032A1A RID: 207386
			BtnGoDetail
		}
	}
}
