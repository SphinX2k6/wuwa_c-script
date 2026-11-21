using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A31 RID: 14897
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardViewModel
	{
		// Token: 0x060264F4 RID: 156916 RVA: 0x00ABAF2F File Offset: 0x00AB912F
		public static TrapDefenseRewardViewModel Create()
		{
			return new TrapDefenseRewardViewModel();
		}

		// Token: 0x060264F5 RID: 156917 RVA: 0x00ABAF36 File Offset: 0x00AB9136
		public void Clear()
		{
			this.CurSelectRewardType = ETrapDefenseRewardType.Default;
			this.OnSelectRewardTypeChangeDelegates.Clear();
		}

		// Token: 0x060264F6 RID: 156918 RVA: 0x00ABAF4A File Offset: 0x00AB914A
		public void RegisterOnSelectRewardTypeChange(Action<ETrapDefenseRewardType> @delegate)
		{
			if (this.OnSelectRewardTypeChangeDelegates.Contains(@delegate))
			{
				return;
			}
			this.OnSelectRewardTypeChangeDelegates.Add(@delegate);
		}

		// Token: 0x060264F7 RID: 156919 RVA: 0x00ABAF68 File Offset: 0x00AB9168
		public void UnregisterOnSelectRewardTypeChange(Action<ETrapDefenseRewardType> @delegate)
		{
			int num = this.OnSelectRewardTypeChangeDelegates.IndexOf(@delegate);
			if (num >= 0)
			{
				this.OnSelectRewardTypeChangeDelegates.RemoveAt(num);
			}
		}

		// Token: 0x060264F8 RID: 156920 RVA: 0x00ABAF92 File Offset: 0x00AB9192
		public void SetCurSelectRewardType(ETrapDefenseRewardType type)
		{
			if (this.CurSelectRewardType == type)
			{
				return;
			}
			this.CurSelectRewardType = type;
			this.NotifyOnSelectRewardTypeChange(type);
		}

		// Token: 0x060264F9 RID: 156921 RVA: 0x00ABAFAC File Offset: 0x00AB91AC
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

		// Token: 0x060264FA RID: 156922 RVA: 0x00ABAFF4 File Offset: 0x00AB91F4
		private void NotifyOnSelectRewardTypeChange(ETrapDefenseRewardType type)
		{
			foreach (Action<ETrapDefenseRewardType> action in this.OnSelectRewardTypeChangeDelegates)
			{
				action(type);
			}
		}

		// Token: 0x04015087 RID: 86151
		public ETrapDefenseRewardType CurSelectRewardType;

		// Token: 0x04015088 RID: 86152
		private readonly List<Action<ETrapDefenseRewardType>> OnSelectRewardTypeChangeDelegates = new List<Action<ETrapDefenseRewardType>>();
	}
}
