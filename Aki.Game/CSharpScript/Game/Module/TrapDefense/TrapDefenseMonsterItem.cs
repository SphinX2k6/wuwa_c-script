using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A69 RID: 14953
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMonsterItem : LoopScrollMediumItemGrid<TrapDefenseMonsterData>
	{
		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x060266C5 RID: 157381 RVA: 0x00AC2EEC File Offset: 0x00AC10EC
		// (set) Token: 0x060266C6 RID: 157382 RVA: 0x00AC2EF4 File Offset: 0x00AC10F4
		public bool IsWave { get; set; }

		// Token: 0x060266C7 RID: 157383 RVA: 0x00AC2EFD File Offset: 0x00AC10FD
		public TrapDefenseMonsterItem(bool isWave = false)
		{
			this.IsWave = isWave;
		}

		// Token: 0x060266C8 RID: 157384 RVA: 0x00AC2F0C File Offset: 0x00AC110C
		protected override void OnStart()
		{
			this.AllComponentLoadedCallback = new Action(this.OnAllComponentLoadedCallback);
		}

		// Token: 0x060266C9 RID: 157385 RVA: 0x00AC2F20 File Offset: 0x00AC1120
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x060266CA RID: 157386 RVA: 0x00AC2F22 File Offset: 0x00AC1122
		protected override void OnRefresh(TrapDefenseMonsterData data, bool isSelected, int gridIndex)
		{
			this.BdBuffData = data;
			this.UpdateBuffInfo();
		}

		// Token: 0x060266CB RID: 157387 RVA: 0x00AC2F34 File Offset: 0x00AC1134
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

		// Token: 0x060266CC RID: 157388 RVA: 0x00AC2FAC File Offset: 0x00AC11AC
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

		// Token: 0x060266CD RID: 157389 RVA: 0x00AC3002 File Offset: 0x00AC1202
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

		// Token: 0x060266CE RID: 157390 RVA: 0x00AC3022 File Offset: 0x00AC1222
		public override void OnDeselected(bool _)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x060266CF RID: 157391 RVA: 0x00AC302C File Offset: 0x00AC122C
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060266D0 RID: 157392 RVA: 0x00AC302E File Offset: 0x00AC122E
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

		// Token: 0x060266D1 RID: 157393 RVA: 0x00AC3062 File Offset: 0x00AC1262
		protected override bool OnCanExecuteChange()
		{
			Func<TrapDefenseMonsterData, bool> canExecuteChangeCallback = this.CanExecuteChangeCallback;
			return canExecuteChangeCallback == null || canExecuteChangeCallback(this.BdBuffData);
		}

		// Token: 0x060266D2 RID: 157394 RVA: 0x00AC307B File Offset: 0x00AC127B
		protected override void OnExtendToggleClicked()
		{
			Action<TrapDefenseMonsterData> onClickMonsterItemCallback = this.OnClickMonsterItemCallback;
			if (onClickMonsterItemCallback == null)
			{
				return;
			}
			onClickMonsterItemCallback(this.BdBuffData);
		}

		// Token: 0x060266D3 RID: 157395 RVA: 0x00AC3093 File Offset: 0x00AC1293
		private void OnAllComponentLoadedCallback()
		{
			if (this.BdBuffData != this.Data)
			{
				this.UpdateBuffInfo();
			}
		}

		// Token: 0x0401511F RID: 86303
		protected TrapDefenseMonsterData BdBuffData;

		// Token: 0x04015120 RID: 86304
		public Action<TrapDefenseMonsterData> OnSelectMonsterItemCallback;

		// Token: 0x04015121 RID: 86305
		public Action<TrapDefenseMonsterData> OnClickMonsterItemCallback;

		// Token: 0x04015122 RID: 86306
		public Func<TrapDefenseMonsterData, bool> CanExecuteChangeCallback;

		// Token: 0x04015123 RID: 86307
		public Func<TrapDefenseMonsterData, string> OnShowNumCallback;
	}
}
