using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F59 RID: 3929
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterDungeonSubTypeCondition : IEnterDungeon
	{
		// Token: 0x06005752 RID: 22354 RVA: 0x000D5998 File Offset: 0x000D3B98
		private IEnterDungeonSubTypeCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterDungeonSubTypeCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterDungeonSubTypeCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterDungeonSubTypeCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x000D59D0 File Offset: 0x000D3BD0
		public static IEnterDungeonSubTypeCondition Create([Nullable(2)] IEnterDungeonSubTypeCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeonSubTypeCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x000D59E3 File Offset: 0x000D3BE3
		public static IEnterDungeonSubTypeCondition CreateFromSetValue([Nullable(2)] IEnterDungeonSubTypeCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterDungeonSubTypeCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x000D59F6 File Offset: 0x000D3BF6
		public new IEnterDungeonSubTypeCondition_SetValue ToSetValue()
		{
			return new IEnterDungeonSubTypeCondition_SetValue
			{
				Type = this.Type,
				DungeonSubType = this.DungeonSubType
			};
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x000D5A15 File Offset: 0x000D3C15
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x000D5A40 File Offset: 0x000D3C40
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

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x000D5A4E File Offset: 0x000D3C4E
		// (set) Token: 0x06005759 RID: 22361 RVA: 0x000D5A79 File Offset: 0x000D3C79
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonSubType;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonSubType.Test;
				}
				return this.PocoInterface.DungeonSubType;
			}
			set
			{
				this.GetOrCreatePoco().DungeonSubType = value;
			}
		}

		// Token: 0x040034D6 RID: 13526
		[Nullable(2)]
		protected new IEnterDungeonSubTypeCondition FbInstance;

		// Token: 0x040034D7 RID: 13527
		[Nullable(2)]
		protected new IEnterDungeonSubTypeCondition_SetValue PocoInterface;
	}
}
