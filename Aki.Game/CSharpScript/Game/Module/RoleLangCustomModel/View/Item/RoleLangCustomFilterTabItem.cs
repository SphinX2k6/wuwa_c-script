using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02004D81 RID: 19841
	public class RoleLangCustomFilterTabItem : GridProxyAbstract<int>
	{
		// Token: 0x060334B3 RID: 210099 RVA: 0x00BF863C File Offset: 0x00BF683C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060334B4 RID: 210100 RVA: 0x00BF876C File Offset: 0x00BF696C
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x060334B5 RID: 210101 RVA: 0x00BF87CC File Offset: 0x00BF69CC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			if (data < 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Btn_VoiceDIY_Filter_All", Array.Empty<object>());
			}
			else
			{
				RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(data);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleLangCustomConfigById.Value.Text, Array.Empty<object>());
			}
			if (this.CheckIsSelected != null)
			{
				EToggleState state = this.CheckIsSelected(data) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(state, false, false, false);
			}
		}

		// Token: 0x060334B6 RID: 210102 RVA: 0x00BF8863 File Offset: 0x00BF6A63
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback(this.ItemData);
		}

		// Token: 0x0401B387 RID: 111495
		[Nullable(2)]
		public Func<int, bool> CheckIsSelected;

		// Token: 0x0401B388 RID: 111496
		[Nullable(2)]
		public Action<int> OnClickedCallback;

		// Token: 0x0401B389 RID: 111497
		protected int ItemData;

		// Token: 0x0200AEF9 RID: 44793
		private enum EToggle
		{
			// Token: 0x04035259 RID: 217689
			ToggleItem,
			// Token: 0x0403525A RID: 217690
			TxtName,
			// Token: 0x0403525B RID: 217691
			PanelCheckState,
			// Token: 0x0403525C RID: 217692
			BtnDownloadProgress,
			// Token: 0x0403525D RID: 217693
			SpriteDownloadFill,
			// Token: 0x0403525E RID: 217694
			SpritePauseIcon,
			// Token: 0x0403525F RID: 217695
			SpritePlayIcon,
			// Token: 0x04035260 RID: 217696
			BtnDownload
		}
	}
}
