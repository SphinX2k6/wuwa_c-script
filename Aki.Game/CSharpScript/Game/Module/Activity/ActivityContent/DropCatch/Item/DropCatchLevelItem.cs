using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066DD RID: 26333
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropCatchLevelItem : GridProxyAbstract<IDropCatchLevelItemData>
	{
		// Token: 0x06041D2F RID: 269615 RVA: 0x00FF6B8C File Offset: 0x00FF4D8C
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

		// Token: 0x06041D30 RID: 269616 RVA: 0x00FF6C77 File Offset: 0x00FF4E77
		public void SetClickCallback(Action<int, int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06041D31 RID: 269617 RVA: 0x00FF6C80 File Offset: 0x00FF4E80
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

		// Token: 0x06041D32 RID: 269618 RVA: 0x00FF6D82 File Offset: 0x00FF4F82
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleSelect(true);
		}

		// Token: 0x06041D33 RID: 269619 RVA: 0x00FF6D8B File Offset: 0x00FF4F8B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false);
		}

		// Token: 0x06041D34 RID: 269620 RVA: 0x00FF6D94 File Offset: 0x00FF4F94
		private void OnClicked(EToggleState state)
		{
			Action<int, int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.CfgId, base.GridIndex);
		}

		// Token: 0x06041D35 RID: 269621 RVA: 0x00FF6DB2 File Offset: 0x00FF4FB2
		public void SetToggleSelect(bool select)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06041D36 RID: 269622 RVA: 0x00FF6DCF File Offset: 0x00FF4FCF
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

		// Token: 0x0402248A RID: 140426
		private int CfgId;

		// Token: 0x0402248B RID: 140427
		private Action<int, int> ClickCallback = delegate(int configId, int index)
		{
		};

		// Token: 0x0402248C RID: 140428
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}";
	}
}
