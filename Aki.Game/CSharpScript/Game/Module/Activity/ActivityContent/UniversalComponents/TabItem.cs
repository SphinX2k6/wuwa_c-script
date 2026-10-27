using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02005F7E RID: 24446
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabItem : GridProxyAbstract<IActivityTab>
	{
		// Token: 0x0603E0AB RID: 254123 RVA: 0x00EFAB4C File Offset: 0x00EF8D4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x0603E0AC RID: 254124 RVA: 0x00EFABCC File Offset: 0x00EF8DCC
		protected override void OnStart()
		{
			UUIExtendToggle toggle = base.GetExtendToggle(0);
			toggle.CanExecuteChange.Bind(() => this.CanTabToggleExecuteChange(toggle.ToggleState));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x0603E0AD RID: 254125 RVA: 0x00EFAC1C File Offset: 0x00EF8E1C
		private bool CanTabToggleExecuteChange(EToggleState state)
		{
			return this.TabCanExecuteChangedFunction == null || this.TabCanExecuteChangedFunction(state == EToggleState.ETT_Checked, base.GridIndex);
		}

		// Token: 0x0603E0AE RID: 254126 RVA: 0x00EFAC3D File Offset: 0x00EF8E3D
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<int> tabFunction = this.TabFunction;
			if (tabFunction != null)
			{
				tabFunction(base.GridIndex);
			}
			Action<int> tabClickExtraFunction = this.TabClickExtraFunction;
			if (tabClickExtraFunction == null)
			{
				return;
			}
			tabClickExtraFunction(base.GridIndex);
		}

		// Token: 0x0603E0AF RID: 254127 RVA: 0x00EFAC6C File Offset: 0x00EF8E6C
		[NullableContext(1)]
		public override void Refresh(IActivityTab data, bool isSelected, int gridIndex)
		{
			if (data.TabData.TabName != null && !StringUtils.IsEmpty(data.TabData.TabName))
			{
				base.GetText(1).SetText(data.TabData.TabName, true);
				this.SetActive(true);
			}
			else
			{
				this.SetActive(false);
			}
			bool uiactive = false;
			using (List<IActivityRewardData>.Enumerator enumerator = data.TabData.DataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == EActivityRewardState.Enable)
					{
						uiactive = true;
						break;
					}
				}
			}
			base.GetItem(2).SetUIActive(uiactive);
			if (data.TabData.TabExtraFunction != null)
			{
				this.TabClickExtraFunction = data.TabData.TabExtraFunction;
			}
			this.TabFunction = data.TabFunction;
			this.TabCanExecuteChangedFunction = data.TabCanExecuteFunction;
		}

		// Token: 0x0603E0B0 RID: 254128 RVA: 0x00EFAD54 File Offset: 0x00EF8F54
		public void SetTabToggleState(bool state, bool? fireEvent = null)
		{
			base.GetExtendToggle(0).SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			if (state && fireEvent.GetValueOrDefault())
			{
				this.OnClickToggle(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
			}
		}

		// Token: 0x04020669 RID: 132713
		private Action<int> TabFunction;

		// Token: 0x0402066A RID: 132714
		private Action<int> TabClickExtraFunction;

		// Token: 0x0402066B RID: 132715
		private Func<bool, int, bool> TabCanExecuteChangedFunction;
	}
}
