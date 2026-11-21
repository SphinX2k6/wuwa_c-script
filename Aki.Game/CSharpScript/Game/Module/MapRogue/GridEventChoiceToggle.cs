using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A9 RID: 17833
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GridEventChoiceToggle : GridProxyAbstract<IToggleItemData>
	{
		// Token: 0x0602CEE0 RID: 184032 RVA: 0x00C9104C File Offset: 0x00C8F24C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggleSpriteTransition)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
			};
		}

		// Token: 0x0602CEE1 RID: 184033 RVA: 0x00C91121 File Offset: 0x00C8F321
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x0602CEE2 RID: 184034 RVA: 0x00C91140 File Offset: 0x00C8F340
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
		}

		// Token: 0x0602CEE3 RID: 184035 RVA: 0x00C91153 File Offset: 0x00C8F353
		private void OnToggleClick(EToggleState state)
		{
			Action<EToggleState, int> onExtendToggleStateChanged = this.OnExtendToggleStateChanged;
			if (onExtendToggleStateChanged == null)
			{
				return;
			}
			onExtendToggleStateChanged(base.GetExtendToggle(0).GetToggleState(), this.OptionId);
		}

		// Token: 0x0602CEE4 RID: 184036 RVA: 0x00C91177 File Offset: 0x00C8F377
		private bool CanExecuteChange()
		{
			return this.OnCanExecuteChangeFunc == null || this.OnCanExecuteChangeFunc(base.GetExtendToggle(0).GetToggleState(), this.OptionId);
		}

		// Token: 0x0602CEE5 RID: 184037 RVA: 0x00C911A0 File Offset: 0x00C8F3A0
		[NullableContext(1)]
		public override void Refresh(IToggleItemData data, bool isSelected, int gridIndex)
		{
			this.OptionId = data.Id;
			UUIText text = base.GetText(5);
			UUIText text2 = base.GetText(3);
			UUIText text3 = base.GetText(4);
			EToggleState state = data.IsDisabled ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
			UUISprite spriteIcon = base.GetSprite(1);
			this.SetSpriteByPath(data.Icon, spriteIcon, false, null, delegate(bool _)
			{
				this.GetUiExtendToggleSpriteTransition(2).SetAllStateSprite(spriteIcon.GetSprite());
			});
			LguiUtil.Instance.SetLocalTextNew(text2, data.TitleId, Array.Empty<object>());
			text3.SetUIActive(!StringUtils.IsEmpty(data.DescId));
			if (!StringUtils.IsEmpty(data.DescId))
			{
				if (data.DescParams != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text3, data.DescId, data.DescParams);
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text3, data.DescId, Array.Empty<object>());
				}
			}
			text.SetUIActive(!StringUtils.IsEmpty(data.ProgressId));
			if (!StringUtils.IsEmpty(data.ProgressId))
			{
				if (data.ProgressParams != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text, data.ProgressId, data.ProgressParams);
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text, data.ProgressId, Array.Empty<object>());
				}
			}
			bool uiactive = !StringUtils.IsEmpty(data.DescId) || !StringUtils.IsEmpty(data.ProgressId);
			base.GetItem(6).SetUIActive(uiactive);
		}

		// Token: 0x04018121 RID: 98593
		private int OptionId;

		// Token: 0x04018122 RID: 98594
		public Action<EToggleState, int> OnExtendToggleStateChanged;

		// Token: 0x04018123 RID: 98595
		public Func<EToggleState, int, bool> OnCanExecuteChangeFunc;
	}
}
