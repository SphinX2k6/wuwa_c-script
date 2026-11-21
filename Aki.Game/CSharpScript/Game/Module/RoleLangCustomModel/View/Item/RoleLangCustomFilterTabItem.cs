using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02003D4A RID: 15690
	public class RoleLangCustomFilterTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06028320 RID: 164640 RVA: 0x00B41C38 File Offset: 0x00B3FE38
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

		// Token: 0x06028321 RID: 164641 RVA: 0x00B41D68 File Offset: 0x00B3FF68
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

		// Token: 0x06028322 RID: 164642 RVA: 0x00B41DC8 File Offset: 0x00B3FFC8
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

		// Token: 0x06028323 RID: 164643 RVA: 0x00B41E5F File Offset: 0x00B4005F
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback(this.ItemData);
		}

		// Token: 0x04015D5A RID: 89434
		[Nullable(2)]
		public Func<int, bool> CheckIsSelected;

		// Token: 0x04015D5B RID: 89435
		[Nullable(2)]
		public Action<int> OnClickedCallback;

		// Token: 0x04015D5C RID: 89436
		protected int ItemData;

		// Token: 0x0200992D RID: 39213
		private enum EToggle
		{
			// Token: 0x0402FC8D RID: 195725
			ToggleItem,
			// Token: 0x0402FC8E RID: 195726
			TxtName,
			// Token: 0x0402FC8F RID: 195727
			PanelCheckState,
			// Token: 0x0402FC90 RID: 195728
			BtnDownloadProgress,
			// Token: 0x0402FC91 RID: 195729
			SpriteDownloadFill,
			// Token: 0x0402FC92 RID: 195730
			SpritePauseIcon,
			// Token: 0x0402FC93 RID: 195731
			SpritePlayIcon,
			// Token: 0x0402FC94 RID: 195732
			BtnDownload
		}
	}
}
