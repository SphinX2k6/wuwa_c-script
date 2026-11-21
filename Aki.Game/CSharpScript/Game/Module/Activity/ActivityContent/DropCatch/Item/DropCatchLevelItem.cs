using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x0200562D RID: 22061
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropCatchLevelItem : GridProxyAbstract<IDropCatchLevelItemData>
	{
		// Token: 0x0603687B RID: 223355 RVA: 0x00F37F90 File Offset: 0x00F36190
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClicked))
			};
		}

		// Token: 0x0603687C RID: 223356 RVA: 0x00F3807B File Offset: 0x00F3627B
		public void SetClickCallback(Action<int, int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0603687D RID: 223357 RVA: 0x00F38084 File Offset: 0x00F36284
		public override void Refresh(IDropCatchLevelItemData data, bool isSelected, int gridIndex)
		{
			if (data == null)
			{
				return;
			}
			this.CfgId = data.CfgId;
			this.SetToggleSelect(isSelected);
			string text = (gridIndex + 1).ToString();
			int romaIndex = this.GetRomaIndex(data.State.GetValueOrDefault());
			this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}", new string[]
			{
				text,
				text
			}), base.GetSprite(romaIndex), false, null, null);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				EDropCatchLevelState? state = data.State;
				EDropCatchLevelState edropCatchLevelState = EDropCatchLevelState.Lock;
				item.SetUIActive(state.GetValueOrDefault() == edropCatchLevelState & state != null);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 != null)
			{
				item2.SetUIActive(data.State.GetValueOrDefault() == EDropCatchLevelState.Unlock);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(data.State.GetValueOrDefault() == EDropCatchLevelState.Rewarded);
			}
			UUIItem item4 = base.GetItem(7);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(data.HasRedPoint);
		}

		// Token: 0x0603687E RID: 223358 RVA: 0x00F38186 File Offset: 0x00F36386
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleSelect(true);
		}

		// Token: 0x0603687F RID: 223359 RVA: 0x00F3818F File Offset: 0x00F3638F
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false);
		}

		// Token: 0x06036880 RID: 223360 RVA: 0x00F38198 File Offset: 0x00F36398
		private void OnClicked(EToggleState state)
		{
			Action<int, int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.CfgId, base.GridIndex);
		}

		// Token: 0x06036881 RID: 223361 RVA: 0x00F381B6 File Offset: 0x00F363B6
		public void SetToggleSelect(bool select)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06036882 RID: 223362 RVA: 0x00F381D3 File Offset: 0x00F363D3
		private int GetRomaIndex(EDropCatchLevelState state)
		{
			if (state == EDropCatchLevelState.Unlock)
			{
				return 1;
			}
			if (state != EDropCatchLevelState.Rewarded)
			{
				return 3;
			}
			return 5;
		}

		// Token: 0x0401CCE3 RID: 117987
		private int CfgId;

		// Token: 0x0401CCE4 RID: 117988
		private Action<int, int> ClickCallback = delegate(int configId, int index)
		{
		};

		// Token: 0x0401CCE5 RID: 117989
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}";
	}
}
