using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0B RID: 6923
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlay : IHideRangeType
	{
		// Token: 0x0600943C RID: 37948 RVA: 0x00157698 File Offset: 0x00155898
		[NullableContext(1)]
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

		// Token: 0x0600943D RID: 37949 RVA: 0x001576D0 File Offset: 0x001558D0
		[NullableContext(1)]
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

		// Token: 0x0600943E RID: 37950 RVA: 0x001576E3 File Offset: 0x001558E3
		[NullableContext(1)]
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

		// Token: 0x0600943F RID: 37951 RVA: 0x001576F6 File Offset: 0x001558F6
		[NullableContext(1)]
		public new IHideWorldEntityAndLevelPlay_SetValue ToSetValue()
		{
			return new IHideWorldEntityAndLevelPlay_SetValue
			{
				Type = this.Type,
				ExcludeEntities = this.ExcludeEntities
			};
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x00157715 File Offset: 0x00155915
		// (set) Token: 0x06009441 RID: 37953 RVA: 0x00157740 File Offset: 0x00155940
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

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x0015774E File Offset: 0x0015594E
		// (set) Token: 0x06009443 RID: 37955 RVA: 0x00157775 File Offset: 0x00155975
		public virtual List<int> ExcludeEntities
		{
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
			set
			{
				this.GetOrCreatePoco().ExcludeEntities = value;
			}
		}

		// Token: 0x04005AEC RID: 23276
		protected new IHideWorldEntityAndLevelPlay FbInstance;

		// Token: 0x04005AED RID: 23277
		protected new IHideWorldEntityAndLevelPlay_SetValue PocoInterface;
	}
}
