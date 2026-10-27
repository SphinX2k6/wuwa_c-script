using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F53 RID: 3923
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterDungeon
	{
		// Token: 0x06005734 RID: 22324 RVA: 0x000D565C File Offset: 0x000D385C
		private IEnterDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x000D5694 File Offset: 0x000D3894
		public static IEnterDungeon Create([Nullable(2)] IEnterDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x000D56A7 File Offset: 0x000D38A7
		public static IEnterDungeon CreateFromSetValue([Nullable(2)] IEnterDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x000D56BA File Offset: 0x000D38BA
		public IEnterDungeon_SetValue ToSetValue()
		{
			return new IEnterDungeon_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06005738 RID: 22328 RVA: 0x000D56CD File Offset: 0x000D38CD
		// (set) Token: 0x06005739 RID: 22329 RVA: 0x000D56F8 File Offset: 0x000D38F8
		public virtual EDungeonConditionType Type
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

		// Token: 0x040034C8 RID: 13512
		[Nullable(2)]
		protected IEnterDungeon FbInstance;

		// Token: 0x040034C9 RID: 13513
		[Nullable(2)]
		protected IEnterDungeon_SetValue PocoInterface;
	}
}
