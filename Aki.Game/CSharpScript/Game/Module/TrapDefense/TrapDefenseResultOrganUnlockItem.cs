using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA9 RID: 19113
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultOrganUnlockItem : GridProxyAbstract<ITrapDefenseResultUnlockInfo>
	{
		// Token: 0x06031861 RID: 202849 RVA: 0x00B7B6AC File Offset: 0x00B798AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031862 RID: 202850 RVA: 0x00B7B794 File Offset: 0x00B79994
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(3));
		}

		// Token: 0x06031863 RID: 202851 RVA: 0x00B7B7A8 File Offset: 0x00B799A8
		public override void Refresh(ITrapDefenseResultUnlockInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (data.Type != ETrapDefenseResultUnlockType.Organ && data.Type != ETrapDefenseResultUnlockType.OrganShare)
			{
				return;
			}
			if (this.OrganData == null || this.OrganData.Id != data.Id)
			{
				ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(data.Id);
				this.OrganData = TrapDefenseBuildingDevelopItemData.Create(data.Id, trapDefenseMachineIdInfo.MachineType);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(data.IsFinish.GetValueOrDefault());
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsNewUnlock.GetValueOrDefault());
			}
			base.SetTextureByPath(this.OrganData.GetIconPath(), base.GetTexture(1), null, null);
			this.Data.IsNewUnlock = null;
		}

		// Token: 0x06031864 RID: 202852 RVA: 0x00B7B887 File Offset: 0x00B79A87
		private void OnClicked()
		{
			if (this.Data.Type != ETrapDefenseResultUnlockType.Organ)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingMachineInfoView, this.OrganData, null);
		}

		// Token: 0x06031865 RID: 202853 RVA: 0x00B7B8B0 File Offset: 0x00B79AB0
		public void PlayUnlockAnim()
		{
			if (this.Data.Type != ETrapDefenseResultUnlockType.Organ)
			{
				return;
			}
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Unlock", false, null);
		}

		// Token: 0x0401A78C RID: 108428
		protected ITrapDefenseResultUnlockInfo Data;

		// Token: 0x0401A78D RID: 108429
		protected TrapDefenseBuildingDevelopItemData OrganData;

		// Token: 0x0401A78E RID: 108430
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
