using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005830 RID: 22576
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CoopRoleItem : GridProxyAbstract<CoopRoleData>
	{
		// Token: 0x06037B1E RID: 228126 RVA: 0x00F92646 File Offset: 0x00F90846
		[NullableContext(1)]
		public CoopRoleItem(CoopActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x06037B1F RID: 228127 RVA: 0x00F92658 File Offset: 0x00F90858
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogClick))
			};
		}

		// Token: 0x06037B20 RID: 228128 RVA: 0x00F92717 File Offset: 0x00F90917
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanExecuteChangeFunc == null || this.CanExecuteChangeFunc(base.GridIndex));
		}

		// Token: 0x06037B21 RID: 228129 RVA: 0x00F92747 File Offset: 0x00F90947
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.Clear();
			}
			this.SeqPlayer = null;
		}

		// Token: 0x06037B22 RID: 228130 RVA: 0x00F92761 File Offset: 0x00F90961
		private void OnTogClick(EToggleState _)
		{
			Action<int, CoopRoleData> onTogClickCallBack = this.OnTogClickCallBack;
			if (onTogClickCallBack == null)
			{
				return;
			}
			onTogClickCallBack(base.GridIndex, this.Data);
		}

		// Token: 0x06037B23 RID: 228131 RVA: 0x00F92780 File Offset: 0x00F90980
		[NullableContext(1)]
		public override void Refresh(CoopRoleData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool isUnLock = data.IsUnLock;
			if (isUnLock)
			{
				base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
			}
			base.GetItem(5).SetUIActive(this.ActivityData.IsRoleHasRedDot(data.RoleId));
			base.GetItem(2).SetUIActive(isUnLock);
			base.GetItem(3).SetUIActive(!isUnLock);
			base.GetItem(4).SetUIActive(data.IsMaxLevel);
		}

		// Token: 0x06037B24 RID: 228132 RVA: 0x00F92808 File Offset: 0x00F90A08
		public override void OnSelected(bool fireEvent)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Select", false, null, false);
			}
			this.SetToggleState(true);
		}

		// Token: 0x06037B25 RID: 228133 RVA: 0x00F9283D File Offset: 0x00F90A3D
		public override void OnDeselected(bool fireEvent)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopSequenceByKey("Select", false, false);
			}
			this.SetToggleState(false);
		}

		// Token: 0x06037B26 RID: 228134 RVA: 0x00F92860 File Offset: 0x00F90A60
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x0401D641 RID: 120385
		public CoopRoleData Data;

		// Token: 0x0401D642 RID: 120386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, CoopRoleData> OnTogClickCallBack;

		// Token: 0x0401D643 RID: 120387
		public Func<int, bool> CanExecuteChangeFunc;

		// Token: 0x0401D644 RID: 120388
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401D645 RID: 120389
		private readonly CoopActivityData ActivityData;
	}
}
