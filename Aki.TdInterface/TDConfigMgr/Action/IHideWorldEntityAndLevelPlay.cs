using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CBA RID: 7354
	public class IHideWorldEntityAndLevelPlay : IHideRangeType
	{
		// Token: 0x06009C26 RID: 39974 RVA: 0x00168374 File Offset: 0x00166574
		private IHideWorldEntityAndLevelPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideWorldEntityAndLevelPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideWorldEntityAndLevelPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideWorldEntityAndLevelPlay_SetValue());
			}
			return result;
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x001683AC File Offset: 0x001665AC
		public static IHideWorldEntityAndLevelPlay Create([Nullable(2)] IHideWorldEntityAndLevelPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x001683BF File Offset: 0x001665BF
		public static IHideWorldEntityAndLevelPlay CreateFromSetValue([Nullable(2)] IHideWorldEntityAndLevelPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x001683D2 File Offset: 0x001665D2
		public new IHideWorldEntityAndLevelPlay_SetValue ToSetValue()
		{
			return new IHideWorldEntityAndLevelPlay_SetValue
			{
				Type = this.Type,
				ExcludeEntities = this.ExcludeEntities
			};
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x06009C2A RID: 39978 RVA: 0x001683F1 File Offset: 0x001665F1
		// (set) Token: 0x06009C2B RID: 39979 RVA: 0x0016841C File Offset: 0x0016661C
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x06009C2C RID: 39980 RVA: 0x0016842A File Offset: 0x0016662A
		// (set) Token: 0x06009C2D RID: 39981 RVA: 0x00168451 File Offset: 0x00166651
		[Nullable(2)]
		public virtual List<int> ExcludeEntities
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExcludeEntities;
				}
				IHideWorldEntityAndLevelPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExcludeEntities;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExcludeEntities = value;
			}
		}

		// Token: 0x04005F8A RID: 24458
		[Nullable(2)]
		protected new IHideWorldEntityAndLevelPlay FbInstance;

		// Token: 0x04005F8B RID: 24459
		[Nullable(2)]
		protected new IHideWorldEntityAndLevelPlay_SetValue PocoInterface;
	}
}
