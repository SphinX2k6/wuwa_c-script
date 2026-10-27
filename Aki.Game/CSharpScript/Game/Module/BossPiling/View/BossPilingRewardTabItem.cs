using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C1A RID: 23578
	public class BossPilingRewardTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603B93D RID: 244029 RVA: 0x00E35744 File Offset: 0x00E33944
		[NullableContext(1)]
		public void SetClickCallBack(Action<BossPilingRewardTabItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x0603B93E RID: 244030 RVA: 0x00E35750 File Offset: 0x00E33950
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

		// Token: 0x0603B93F RID: 244031 RVA: 0x00E35838 File Offset: 0x00E33A38
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

		// Token: 0x0603B940 RID: 244032 RVA: 0x00E358D8 File Offset: 0x00E33AD8
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

		// Token: 0x0603B941 RID: 244033 RVA: 0x00E3590D File Offset: 0x00E33B0D
		private void OnClickToggle(EToggleState state)
		{
			Action<BossPilingRewardTabItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this);
		}

		// Token: 0x0603B942 RID: 244034 RVA: 0x00E35920 File Offset: 0x00E33B20
		public void SetToggleUnCheck()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603B943 RID: 244035 RVA: 0x00E35933 File Offset: 0x00E33B33
		public int GetLevelId()
		{
			return this.Id;
		}

		// Token: 0x0401F054 RID: 127060
		private int Id;

		// Token: 0x0401F055 RID: 127061
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<BossPilingRewardTabItem> ClickCallBack;

		// Token: 0x0200BE06 RID: 48646
		private enum ETab
		{
			// Token: 0x040394C1 RID: 234689
			Toggle,
			// Token: 0x040394C2 RID: 234690
			Text,
			// Token: 0x040394C3 RID: 234691
			Texture,
			// Token: 0x040394C4 RID: 234692
			RedDotItem
		}
	}
}
