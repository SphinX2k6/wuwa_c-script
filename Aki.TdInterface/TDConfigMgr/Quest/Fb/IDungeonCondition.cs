using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200137F RID: 4991
	public class IDungeonCondition
	{
		// Token: 0x06007234 RID: 29236 RVA: 0x00112DFC File Offset: 0x00110FFC
		[NullableContext(1)]
		public static IDungeonCondition Create(IDungeonCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x00112E1B File Offset: 0x0011101B
		public virtual EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x00112E28 File Offset: 0x00111028
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x00112E38 File Offset: 0x00111038
		public virtual bool? IsExitDungeon
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsExitDungeon);
			}
		}

		// Token: 0x04004207 RID: 16903
		private IDungeonCondition Instance;
	}
}
