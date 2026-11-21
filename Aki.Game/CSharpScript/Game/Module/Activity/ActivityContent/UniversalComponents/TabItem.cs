using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F65 RID: 20325
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabItem : GridProxyAbstract<IActivityTab>
	{
		// Token: 0x06033045 RID: 208965 RVA: 0x00E4C82C File Offset: 0x00E4AA2C
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

		// Token: 0x06033046 RID: 208966 RVA: 0x00E4C8AC File Offset: 0x00E4AAAC
		protected override void OnStart()
		{
			UUIExtendToggle toggle = base.GetExtendToggle(0);
			toggle.CanExecuteChange.Bind(() => this.CanTabToggleExecuteChange(toggle.ToggleState));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06033047 RID: 208967 RVA: 0x00E4C8FC File Offset: 0x00E4AAFC
		private bool CanTabToggleExecuteChange(EToggleState state)
		{
			return this.TabCanExecuteChangedFunction == null || this.TabCanExecuteChangedFunction(state == EToggleState.ETT_Checked, base.GridIndex);
		}

		// Token: 0x06033048 RID: 208968 RVA: 0x00E4C91D File Offset: 0x00E4AB1D
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

		// Token: 0x06033049 RID: 208969 RVA: 0x00E4C94C File Offset: 0x00E4AB4C
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

		// Token: 0x0603304A RID: 208970 RVA: 0x00E4CA34 File Offset: 0x00E4AC34
		public void SetTabToggleState(bool state, bool? fireEvent = null)
		{
			base.GetExtendToggle(0).SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			if (state && fireEvent.GetValueOrDefault())
			{
				this.OnClickToggle(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
			}
		}

		// Token: 0x0401B13B RID: 110907
		private Action<int> TabFunction;

		// Token: 0x0401B13C RID: 110908
		private Action<int> TabClickExtraFunction;

		// Token: 0x0401B13D RID: 110909
		private Func<bool, int, bool> TabCanExecuteChangedFunction;
	}
}
