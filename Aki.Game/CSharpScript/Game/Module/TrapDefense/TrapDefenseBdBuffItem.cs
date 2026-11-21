using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A83 RID: 14979
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdBuffItem : LoopScrollMediumItemGrid<TrapDefenseBdBuffData>
	{
		// Token: 0x060267B1 RID: 157617 RVA: 0x00AC7C8D File Offset: 0x00AC5E8D
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
			this.AllComponentLoadedCallback = new Action(this.OnAllComponentLoadedCallback);
		}

		// Token: 0x060267B2 RID: 157618 RVA: 0x00AC7CA8 File Offset: 0x00AC5EA8
		protected override void OnRefresh(TrapDefenseBdBuffData data, bool isSelected, int gridIndex)
		{
			this.BdBuffData = data;
			this.UpdateBuffInfo();
		}

		// Token: 0x060267B3 RID: 157619 RVA: 0x00AC7CB8 File Offset: 0x00AC5EB8
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

		// Token: 0x060267B4 RID: 157620 RVA: 0x00AC7DC4 File Offset: 0x00AC5FC4
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

		// Token: 0x060267B5 RID: 157621 RVA: 0x00AC7DE5 File Offset: 0x00AC5FE5
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x060267B6 RID: 157622 RVA: 0x00AC7DEF File Offset: 0x00AC5FEF
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060267B7 RID: 157623 RVA: 0x00AC7DF1 File Offset: 0x00AC5FF1
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

		// Token: 0x060267B8 RID: 157624 RVA: 0x00AC7E25 File Offset: 0x00AC6025
		protected override bool OnCanExecuteChange()
		{
			Func<TrapDefenseBdBuffData, bool> canExecuteChangeCallback = this.CanExecuteChangeCallback;
			return canExecuteChangeCallback == null || canExecuteChangeCallback(this.BdBuffData);
		}

		// Token: 0x060267B9 RID: 157625 RVA: 0x00AC7E3E File Offset: 0x00AC603E
		protected override void OnExtendToggleClicked()
		{
			Action<TrapDefenseBdBuffData> onClickBuffItemCallback = this.OnClickBuffItemCallback;
			if (onClickBuffItemCallback == null)
			{
				return;
			}
			onClickBuffItemCallback(this.BdBuffData);
		}

		// Token: 0x060267BA RID: 157626 RVA: 0x00AC7E56 File Offset: 0x00AC6056
		private void OnAllComponentLoadedCallback()
		{
			if (this.IsNeedUpdate)
			{
				this.IsNeedUpdate = false;
				this.UpdateBuffInfo();
			}
		}

		// Token: 0x060267BB RID: 157627 RVA: 0x00AC7E6D File Offset: 0x00AC606D
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x04015178 RID: 86392
		protected TrapDefenseBdBuffData BdBuffData;

		// Token: 0x04015179 RID: 86393
		public Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem> OnSelectBuffItemCallback;

		// Token: 0x0401517A RID: 86394
		public Action<TrapDefenseBdBuffData> OnClickBuffItemCallback;

		// Token: 0x0401517B RID: 86395
		public Func<TrapDefenseBdBuffData, bool> CanExecuteChangeCallback;

		// Token: 0x0401517C RID: 86396
		public Func<TrapDefenseBdBuffData, bool> OnIsShowBdBuffLockStateCallback;

		// Token: 0x0401517D RID: 86397
		public Func<TrapDefenseBdBuffData, bool> OnIsNewTagStateCallback;

		// Token: 0x0401517E RID: 86398
		public Func<TrapDefenseBdBuffData, TrapDefenseBdBuff> OnGetBdBuffConfig;

		// Token: 0x0401517F RID: 86399
		private bool IsNeedUpdate;
	}
}
