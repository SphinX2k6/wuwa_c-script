using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068E0 RID: 26848
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CoopRoleItem : GridProxyAbstract<CoopRoleData>
	{
		// Token: 0x06042FC6 RID: 274374 RVA: 0x0105101E File Offset: 0x0104F21E
		[NullableContext(1)]
		public CoopRoleItem(CoopActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x06042FC7 RID: 274375 RVA: 0x01051030 File Offset: 0x0104F230
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

		// Token: 0x06042FC8 RID: 274376 RVA: 0x010510EF File Offset: 0x0104F2EF
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanExecuteChangeFunc == null || this.CanExecuteChangeFunc(base.GridIndex));
		}

		// Token: 0x06042FC9 RID: 274377 RVA: 0x0105111F File Offset: 0x0104F31F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.Clear();
			}
			this.SeqPlayer = null;
		}

		// Token: 0x06042FCA RID: 274378 RVA: 0x01051139 File Offset: 0x0104F339
		private void OnTogClick(EToggleState _)
		{
			Action<int, CoopRoleData> onTogClickCallBack = this.OnTogClickCallBack;
			if (onTogClickCallBack == null)
			{
				return;
			}
			onTogClickCallBack(base.GridIndex, this.Data);
		}

		// Token: 0x06042FCB RID: 274379 RVA: 0x01051158 File Offset: 0x0104F358
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

		// Token: 0x06042FCC RID: 274380 RVA: 0x010511E0 File Offset: 0x0104F3E0
		public override void OnSelected(bool fireEvent)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Select", false, null, false);
			}
			this.SetToggleState(true);
		}

		// Token: 0x06042FCD RID: 274381 RVA: 0x01051215 File Offset: 0x0104F415
		public override void OnDeselected(bool fireEvent)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopSequenceByKey("Select", false, false);
			}
			this.SetToggleState(false);
		}

		// Token: 0x06042FCE RID: 274382 RVA: 0x01051238 File Offset: 0x0104F438
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x04022DE5 RID: 142821
		public CoopRoleData Data;

		// Token: 0x04022DE6 RID: 142822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, CoopRoleData> OnTogClickCallBack;

		// Token: 0x04022DE7 RID: 142823
		public Func<int, bool> CanExecuteChangeFunc;

		// Token: 0x04022DE8 RID: 142824
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04022DE9 RID: 142825
		private readonly CoopActivityData ActivityData;
	}
}
