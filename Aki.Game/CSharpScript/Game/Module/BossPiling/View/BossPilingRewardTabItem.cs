using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BFA RID: 19450
	public class BossPilingRewardTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06030888 RID: 198792 RVA: 0x00D85AA0 File Offset: 0x00D83CA0
		[NullableContext(1)]
		public void SetClickCallBack(Action<BossPilingRewardTabItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x06030889 RID: 198793 RVA: 0x00D85AAC File Offset: 0x00D83CAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603088A RID: 198794 RVA: 0x00D85B94 File Offset: 0x00D83D94
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Id = data;
			if (gridIndex == 0)
			{
				Action<BossPilingRewardTabItem> clickCallBack = this.ClickCallBack;
				if (clickCallBack != null)
				{
					clickCallBack(this);
				}
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			else
			{
				this.SetToggleUnCheck();
			}
			BossPilingLevels? levelInfo = BossPilingConfig.Instance.GetLevelInfo(data);
			if (levelInfo == null)
			{
				return;
			}
			base.GetText(1).ShowTextNew(levelInfo.Value.LevelName);
			base.SetTextureByPath(levelInfo.Value.TaskIndexTex, base.GetTexture(2), null, null);
			this.RefreshRedDot();
		}

		// Token: 0x0603088B RID: 198795 RVA: 0x00D85C34 File Offset: 0x00D83E34
		public void RefreshRedDot()
		{
			BossPilingActivityData activityData = BossPilingModel.Instance.GetActivityData();
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(activityData.CheckLevelTaskRedDot(this.Id));
		}

		// Token: 0x0603088C RID: 198796 RVA: 0x00D85C69 File Offset: 0x00D83E69
		private void OnClickToggle(EToggleState state)
		{
			Action<BossPilingRewardTabItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this);
		}

		// Token: 0x0603088D RID: 198797 RVA: 0x00D85C7C File Offset: 0x00D83E7C
		public void SetToggleUnCheck()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603088E RID: 198798 RVA: 0x00D85C8F File Offset: 0x00D83E8F
		public int GetLevelId()
		{
			return this.Id;
		}

		// Token: 0x04019B05 RID: 105221
		private int Id;

		// Token: 0x04019B06 RID: 105222
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<BossPilingRewardTabItem> ClickCallBack;

		// Token: 0x0200A80E RID: 43022
		private enum ETab
		{
			// Token: 0x04033E84 RID: 212612
			Toggle,
			// Token: 0x04033E85 RID: 212613
			Text,
			// Token: 0x04033E86 RID: 212614
			Texture,
			// Token: 0x04033E87 RID: 212615
			RedDotItem
		}
	}
}
