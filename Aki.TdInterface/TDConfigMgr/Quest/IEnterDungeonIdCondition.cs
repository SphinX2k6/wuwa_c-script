using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F57 RID: 3927
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterDungeonIdCondition : IEnterDungeon
	{
		// Token: 0x06005748 RID: 22344 RVA: 0x000D5898 File Offset: 0x000D3A98
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

		// Token: 0x06005749 RID: 22345 RVA: 0x000D58D0 File Offset: 0x000D3AD0
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

		// Token: 0x0600574A RID: 22346 RVA: 0x000D58E3 File Offset: 0x000D3AE3
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

		// Token: 0x0600574B RID: 22347 RVA: 0x000D58F6 File Offset: 0x000D3AF6
		public new IEnterDungeonIdCondition_SetValue ToSetValue()
		{
			return new IEnterDungeonIdCondition_SetValue
			{
				Type = this.Type,
				DungeonId = this.DungeonId
			};
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x000D5915 File Offset: 0x000D3B15
		// (set) Token: 0x0600574D RID: 22349 RVA: 0x000D5940 File Offset: 0x000D3B40
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

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x0600574E RID: 22350 RVA: 0x000D594E File Offset: 0x000D3B4E
		// (set) Token: 0x0600574F RID: 22351 RVA: 0x000D5979 File Offset: 0x000D3B79
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

		// Token: 0x040034D2 RID: 13522
		[Nullable(2)]
		protected new IEnterDungeonIdCondition FbInstance;

		// Token: 0x040034D3 RID: 13523
		[Nullable(2)]
		protected new IEnterDungeonIdCondition_SetValue PocoInterface;
	}
}
