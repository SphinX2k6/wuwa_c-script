using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC1 RID: 19137
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMonsterItem : LoopScrollMediumItemGrid<TrapDefenseMonsterData>
	{
		// Token: 0x17007AE8 RID: 31464
		// (get) Token: 0x06031935 RID: 203061 RVA: 0x00B7EF38 File Offset: 0x00B7D138
		// (set) Token: 0x06031936 RID: 203062 RVA: 0x00B7EF40 File Offset: 0x00B7D140
		public bool IsWave { get; set; }

		// Token: 0x06031937 RID: 203063 RVA: 0x00B7EF49 File Offset: 0x00B7D149
		public TrapDefenseMonsterItem(bool isWave = false)
		{
			this.IsWave = isWave;
		}

		// Token: 0x06031938 RID: 203064 RVA: 0x00B7EF58 File Offset: 0x00B7D158
		protected override void OnStart()
		{
			this.AllComponentLoadedCallback = new Action(this.OnAllComponentLoadedCallback);
		}

		// Token: 0x06031939 RID: 203065 RVA: 0x00B7EF6C File Offset: 0x00B7D16C
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x0603193A RID: 203066 RVA: 0x00B7EF6E File Offset: 0x00B7D16E
		protected override void OnRefresh(TrapDefenseMonsterData data, bool isSelected, int gridIndex)
		{
			this.BdBuffData = data;
			this.UpdateBuffInfo();
		}

		// Token: 0x0603193B RID: 203067 RVA: 0x00B7EF80 File Offset: 0x00B7D180
		public void UpdateBuffInfo()
		{
			if (this.IsAnyComponentLoading)
			{
				return;
			}
			TrapDefenseMonsterData bdBuffData = this.BdBuffData;
			Func<TrapDefenseMonsterData, string> onShowNumCallback = this.OnShowNumCallback;
			string rightTopValue = (onShowNumCallback != null) ? onShowNumCallback(bdBuffData) : null;
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				IconPath = bdBuffData.IconPath,
				QualityIcon = bdBuffData.GetQualityPathGrid(),
				TagPathList = bdBuffData.GetGridTagPathList().ToArray(),
				RightTopValue = rightTopValue,
				Data = bdBuffData
			};
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0603193C RID: 203068 RVA: 0x00B7EFF8 File Offset: 0x00B7D1F8
		public void CheckWaveUpdate(TrapDefenseMonsterWaveData waveData)
		{
			if (!this.IsWave)
			{
				return;
			}
			bool flag = TrapDefenseModel.Instance.ViewModelMonster.IsSameWaveAndMonster(waveData, this.BdBuffData);
			if (this.IsSelected && !flag)
			{
				ScrollViewDelegate<IGridProxy<TrapDefenseMonsterData>, TrapDefenseMonsterData> scrollViewDelegate = base.ScrollViewDelegate as ScrollViewDelegate<IGridProxy<TrapDefenseMonsterData>, TrapDefenseMonsterData>;
				if (scrollViewDelegate != null)
				{
					scrollViewDelegate.ClearSelectInfo();
				}
			}
			this.SetSelected(flag, false);
		}

		// Token: 0x0603193D RID: 203069 RVA: 0x00B7F04E File Offset: 0x00B7D24E
		public override void OnSelected(bool _)
		{
			this.SetSelected(true, false);
			Action<TrapDefenseMonsterData> onSelectMonsterItemCallback = this.OnSelectMonsterItemCallback;
			if (onSelectMonsterItemCallback == null)
			{
				return;
			}
			onSelectMonsterItemCallback(this.BdBuffData);
		}

		// Token: 0x0603193E RID: 203070 RVA: 0x00B7F06E File Offset: 0x00B7D26E
		public override void OnDeselected(bool _)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0603193F RID: 203071 RVA: 0x00B7F078 File Offset: 0x00B7D278
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06031940 RID: 203072 RVA: 0x00B7F07A File Offset: 0x00B7D27A
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
			IScrollViewDelegate<IGridProxy<TrapDefenseMonsterData>, TrapDefenseMonsterData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}

		// Token: 0x06031941 RID: 203073 RVA: 0x00B7F0AE File Offset: 0x00B7D2AE
		protected override bool OnCanExecuteChange()
		{
			Func<TrapDefenseMonsterData, bool> canExecuteChangeCallback = this.CanExecuteChangeCallback;
			return canExecuteChangeCallback == null || canExecuteChangeCallback(this.BdBuffData);
		}

		// Token: 0x06031942 RID: 203074 RVA: 0x00B7F0C7 File Offset: 0x00B7D2C7
		protected override void OnExtendToggleClicked()
		{
			Action<TrapDefenseMonsterData> onClickMonsterItemCallback = this.OnClickMonsterItemCallback;
			if (onClickMonsterItemCallback == null)
			{
				return;
			}
			onClickMonsterItemCallback(this.BdBuffData);
		}

		// Token: 0x06031943 RID: 203075 RVA: 0x00B7F0DF File Offset: 0x00B7D2DF
		private void OnAllComponentLoadedCallback()
		{
			if (this.BdBuffData != this.Data)
			{
				this.UpdateBuffInfo();
			}
		}

		// Token: 0x0401A7CD RID: 108493
		protected TrapDefenseMonsterData BdBuffData;

		// Token: 0x0401A7CE RID: 108494
		public Action<TrapDefenseMonsterData> OnSelectMonsterItemCallback;

		// Token: 0x0401A7CF RID: 108495
		public Action<TrapDefenseMonsterData> OnClickMonsterItemCallback;

		// Token: 0x0401A7D0 RID: 108496
		public Func<TrapDefenseMonsterData, bool> CanExecuteChangeCallback;

		// Token: 0x0401A7D1 RID: 108497
		public Func<TrapDefenseMonsterData, string> OnShowNumCallback;
	}
}
