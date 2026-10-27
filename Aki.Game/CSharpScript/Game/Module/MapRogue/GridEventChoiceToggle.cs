using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055D3 RID: 21971
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GridEventChoiceToggle : GridProxyAbstract<IToggleItemData>
	{
		// Token: 0x06037FE2 RID: 229346 RVA: 0x00D43304 File Offset: 0x00D41504
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

		// Token: 0x06037FE3 RID: 229347 RVA: 0x00D433D9 File Offset: 0x00D415D9
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06037FE4 RID: 229348 RVA: 0x00D433F8 File Offset: 0x00D415F8
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
		}

		// Token: 0x06037FE5 RID: 229349 RVA: 0x00D4340B File Offset: 0x00D4160B
		private void OnToggleClick(EToggleState state)
		{
			Action<EToggleState, int> onExtendToggleStateChanged = this.OnExtendToggleStateChanged;
			if (onExtendToggleStateChanged == null)
			{
				return;
			}
			onExtendToggleStateChanged(base.GetExtendToggle(0).GetToggleState(), this.OptionId);
		}

		// Token: 0x06037FE6 RID: 229350 RVA: 0x00D4342F File Offset: 0x00D4162F
		private bool CanExecuteChange()
		{
			return this.OnCanExecuteChangeFunc == null || this.OnCanExecuteChangeFunc(base.GetExtendToggle(0).GetToggleState(), this.OptionId);
		}

		// Token: 0x06037FE7 RID: 229351 RVA: 0x00D43458 File Offset: 0x00D41658
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

		// Token: 0x0401D696 RID: 120470
		private int OptionId;

		// Token: 0x0401D697 RID: 120471
		public Action<EToggleState, int> OnExtendToggleStateChanged;

		// Token: 0x0401D698 RID: 120472
		public Func<EToggleState, int, bool> OnCanExecuteChangeFunc;
	}
}
