using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A51 RID: 14929
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultOrganUnlockItem : GridProxyAbstract<ITrapDefenseResultUnlockInfo>
	{
		// Token: 0x060265F1 RID: 157169 RVA: 0x00ABF660 File Offset: 0x00ABD860
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

		// Token: 0x060265F2 RID: 157170 RVA: 0x00ABF748 File Offset: 0x00ABD948
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(3));
		}

		// Token: 0x060265F3 RID: 157171 RVA: 0x00ABF75C File Offset: 0x00ABD95C
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

		// Token: 0x060265F4 RID: 157172 RVA: 0x00ABF83B File Offset: 0x00ABDA3B
		private void OnClicked()
		{
			if (this.Data.Type != ETrapDefenseResultUnlockType.Organ)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingMachineInfoView, this.OrganData, null);
		}

		// Token: 0x060265F5 RID: 157173 RVA: 0x00ABF864 File Offset: 0x00ABDA64
		public void PlayUnlockAnim()
		{
			if (this.Data.Type != ETrapDefenseResultUnlockType.Organ)
			{
				return;
			}
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Unlock", false, null);
		}

		// Token: 0x040150DE RID: 86238
		protected ITrapDefenseResultUnlockInfo Data;

		// Token: 0x040150DF RID: 86239
		protected TrapDefenseBuildingDevelopItemData OrganData;

		// Token: 0x040150E0 RID: 86240
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
