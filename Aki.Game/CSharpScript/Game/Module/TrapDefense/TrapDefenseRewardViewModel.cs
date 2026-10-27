using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A89 RID: 19081
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardViewModel
	{
		// Token: 0x06031764 RID: 202596 RVA: 0x00B76F7B File Offset: 0x00B7517B
		public static TrapDefenseRewardViewModel Create()
		{
			return new TrapDefenseRewardViewModel();
		}

		// Token: 0x06031765 RID: 202597 RVA: 0x00B76F82 File Offset: 0x00B75182
		public void Clear()
		{
			this.CurSelectRewardType = ETrapDefenseRewardType.Default;
			this.OnSelectRewardTypeChangeDelegates.Clear();
		}

		// Token: 0x06031766 RID: 202598 RVA: 0x00B76F96 File Offset: 0x00B75196
		public void RegisterOnSelectRewardTypeChange(Action<ETrapDefenseRewardType> @delegate)
		{
			if (this.OnSelectRewardTypeChangeDelegates.Contains(@delegate))
			{
				return;
			}
			this.OnSelectRewardTypeChangeDelegates.Add(@delegate);
		}

		// Token: 0x06031767 RID: 202599 RVA: 0x00B76FB4 File Offset: 0x00B751B4
		public void UnregisterOnSelectRewardTypeChange(Action<ETrapDefenseRewardType> @delegate)
		{
			int num = this.OnSelectRewardTypeChangeDelegates.IndexOf(@delegate);
			if (num >= 0)
			{
				this.OnSelectRewardTypeChangeDelegates.RemoveAt(num);
			}
		}

		// Token: 0x06031768 RID: 202600 RVA: 0x00B76FDE File Offset: 0x00B751DE
		public void SetCurSelectRewardType(ETrapDefenseRewardType type)
		{
			if (this.CurSelectRewardType == type)
			{
				return;
			}
			this.CurSelectRewardType = type;
			this.NotifyOnSelectRewardTypeChange(type);
		}

		// Token: 0x06031769 RID: 202601 RVA: 0x00B76FF8 File Offset: 0x00B751F8
		public List<TrapDefenseRewardTabData> GetRewardTypeDataList()
		{
			List<TrapDefenseRewardTabData> list = new List<TrapDefenseRewardTabData>();
			for (int i = 1; i < 5; i++)
			{
				ETrapDefenseRewardType type = (ETrapDefenseRewardType)i;
				if (TrapDefenseModel.Instance.RewardData.GetRewardListByType(type).Count != 0)
				{
					list.Add(new TrapDefenseRewardTabData(type));
				}
			}
			return list;
		}

		// Token: 0x0603176A RID: 202602 RVA: 0x00B77040 File Offset: 0x00B75240
		private void NotifyOnSelectRewardTypeChange(ETrapDefenseRewardType type)
		{
			foreach (Action<ETrapDefenseRewardType> action in this.OnSelectRewardTypeChangeDelegates)
			{
				action(type);
			}
		}

		// Token: 0x0401A735 RID: 108341
		public ETrapDefenseRewardType CurSelectRewardType;

		// Token: 0x0401A736 RID: 108342
		private readonly List<Action<ETrapDefenseRewardType>> OnSelectRewardTypeChangeDelegates = new List<Action<ETrapDefenseRewardType>>();
	}
}
