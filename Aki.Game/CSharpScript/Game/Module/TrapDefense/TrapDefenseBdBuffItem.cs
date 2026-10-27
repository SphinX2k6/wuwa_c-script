using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ADB RID: 19163
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdBuffItem : LoopScrollMediumItemGrid<TrapDefenseBdBuffData>
	{
		// Token: 0x06031A21 RID: 203297 RVA: 0x00B83CD9 File Offset: 0x00B81ED9
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
			this.AllComponentLoadedCallback = new Action(this.OnAllComponentLoadedCallback);
		}

		// Token: 0x06031A22 RID: 203298 RVA: 0x00B83CF4 File Offset: 0x00B81EF4
		protected override void OnRefresh(TrapDefenseBdBuffData data, bool isSelected, int gridIndex)
		{
			this.BdBuffData = data;
			this.UpdateBuffInfo();
		}

		// Token: 0x06031A23 RID: 203299 RVA: 0x00B83D04 File Offset: 0x00B81F04
		public void UpdateBuffInfo()
		{
			if (this.IsAnyComponentLoading)
			{
				this.IsNeedUpdate = true;
				return;
			}
			TrapDefenseBdBuffData bdBuffData = this.BdBuffData;
			Func<TrapDefenseBdBuffData, bool> onIsShowBdBuffLockStateCallback = this.OnIsShowBdBuffLockStateCallback;
			bool flag = onIsShowBdBuffLockStateCallback != null && onIsShowBdBuffLockStateCallback(bdBuffData);
			Func<TrapDefenseBdBuffData, TrapDefenseBdBuff> onGetBdBuffConfig = this.OnGetBdBuffConfig;
			TrapDefenseBdBuff config = (onGetBdBuffConfig != null) ? onGetBdBuffConfig(bdBuffData) : bdBuffData.BdBuffConfig;
			string bottomTextId = flag ? ETrapDefenseTextKey.BdBuffLockShowName.ToString() : config.Name;
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
			propMediumItemGrid.IconPath = config.Icon;
			propMediumItemGrid.QualityId = new int?(bdBuffData.Config.Quality);
			propMediumItemGrid.IsLockVisible = new bool?(flag);
			propMediumItemGrid.IsDisable = new bool?(flag);
			propMediumItemGrid.BottomTextId = bottomTextId;
			propMediumItemGrid.IsUpGrade = new bool?(bdBuffData.IsStrengthen(config));
			Func<TrapDefenseBdBuffData, bool> onIsNewTagStateCallback = this.OnIsNewTagStateCallback;
			propMediumItemGrid.IsNewVisible = ((onIsNewTagStateCallback != null) ? new bool?(onIsNewTagStateCallback(bdBuffData)) : null);
			propMediumItemGrid.SubIconPath = config.SubIcon;
			propMediumItemGrid.Data = bdBuffData;
			PropMediumItemGrid parameters = propMediumItemGrid;
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x06031A24 RID: 203300 RVA: 0x00B83E10 File Offset: 0x00B82010
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
			Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem> onSelectBuffItemCallback = this.OnSelectBuffItemCallback;
			if (onSelectBuffItemCallback == null)
			{
				return;
			}
			onSelectBuffItemCallback(this.BdBuffData, this);
		}

		// Token: 0x06031A25 RID: 203301 RVA: 0x00B83E31 File Offset: 0x00B82031
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06031A26 RID: 203302 RVA: 0x00B83E3B File Offset: 0x00B8203B
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06031A27 RID: 203303 RVA: 0x00B83E3D File Offset: 0x00B8203D
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				if (this.IsSelected)
				{
					this.SetSelected(true, false);
				}
				return;
			}
			IScrollViewDelegate<IGridProxy<TrapDefenseBdBuffData>, TrapDefenseBdBuffData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}

		// Token: 0x06031A28 RID: 203304 RVA: 0x00B83E71 File Offset: 0x00B82071
		protected override bool OnCanExecuteChange()
		{
			Func<TrapDefenseBdBuffData, bool> canExecuteChangeCallback = this.CanExecuteChangeCallback;
			return canExecuteChangeCallback == null || canExecuteChangeCallback(this.BdBuffData);
		}

		// Token: 0x06031A29 RID: 203305 RVA: 0x00B83E8A File Offset: 0x00B8208A
		protected override void OnExtendToggleClicked()
		{
			Action<TrapDefenseBdBuffData> onClickBuffItemCallback = this.OnClickBuffItemCallback;
			if (onClickBuffItemCallback == null)
			{
				return;
			}
			onClickBuffItemCallback(this.BdBuffData);
		}

		// Token: 0x06031A2A RID: 203306 RVA: 0x00B83EA2 File Offset: 0x00B820A2
		private void OnAllComponentLoadedCallback()
		{
			if (this.IsNeedUpdate)
			{
				this.IsNeedUpdate = false;
				this.UpdateBuffInfo();
			}
		}

		// Token: 0x06031A2B RID: 203307 RVA: 0x00B83EB9 File Offset: 0x00B820B9
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x0401A826 RID: 108582
		protected TrapDefenseBdBuffData BdBuffData;

		// Token: 0x0401A827 RID: 108583
		public Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem> OnSelectBuffItemCallback;

		// Token: 0x0401A828 RID: 108584
		public Action<TrapDefenseBdBuffData> OnClickBuffItemCallback;

		// Token: 0x0401A829 RID: 108585
		public Func<TrapDefenseBdBuffData, bool> CanExecuteChangeCallback;

		// Token: 0x0401A82A RID: 108586
		public Func<TrapDefenseBdBuffData, bool> OnIsShowBdBuffLockStateCallback;

		// Token: 0x0401A82B RID: 108587
		public Func<TrapDefenseBdBuffData, bool> OnIsNewTagStateCallback;

		// Token: 0x0401A82C RID: 108588
		public Func<TrapDefenseBdBuffData, TrapDefenseBdBuff> OnGetBdBuffConfig;

		// Token: 0x0401A82D RID: 108589
		private bool IsNeedUpdate;
	}
}
