using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001081 RID: 4225
	public class IEnterDungeonIdCondition : IEnterDungeon
	{
		// Token: 0x06005D1C RID: 23836 RVA: 0x000E2304 File Offset: 0x000E0504
		private IEnterDungeonIdCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterDungeonIdCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterDungeonIdCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterDungeonIdCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x000E233C File Offset: 0x000E053C
		public static IEnterDungeonIdCondition Create([Nullable(2)] IEnterDungeonIdCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeonIdCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x000E234F File Offset: 0x000E054F
		public static IEnterDungeonIdCondition CreateFromSetValue([Nullable(2)] IEnterDungeonIdCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterDungeonIdCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x000E2362 File Offset: 0x000E0562
		public new IEnterDungeonIdCondition_SetValue ToSetValue()
		{
			return new IEnterDungeonIdCondition_SetValue
			{
				Type = this.Type,
				DungeonId = this.DungeonId
			};
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x000E2381 File Offset: 0x000E0581
		// (set) Token: 0x06005D21 RID: 23841 RVA: 0x000E23AC File Offset: 0x000E05AC
		public override EDungeonConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06005D22 RID: 23842 RVA: 0x000E23BA File Offset: 0x000E05BA
		// (set) Token: 0x06005D23 RID: 23843 RVA: 0x000E23E5 File Offset: 0x000E05E5
		public virtual int DungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DungeonId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonId = value;
			}
		}

		// Token: 0x04003803 RID: 14339
		[Nullable(2)]
		protected new IEnterDungeonIdCondition FbInstance;

		// Token: 0x04003804 RID: 14340
		[Nullable(2)]
		protected new IEnterDungeonIdCondition_SetValue PocoInterface;
	}
}
