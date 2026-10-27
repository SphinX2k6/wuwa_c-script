using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B07 RID: 6919
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyEntityGroup : IHideGroupType
	{
		// Token: 0x06009426 RID: 37926 RVA: 0x0015744C File Offset: 0x0015564C
		private IHideSpecifyEntityGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideSpecifyEntityGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideSpecifyEntityGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideSpecifyEntityGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x00157484 File Offset: 0x00155684
		public static IHideSpecifyEntityGroup Create([Nullable(2)] IHideSpecifyEntityGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntityGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00157497 File Offset: 0x00155697
		public static IHideSpecifyEntityGroup CreateFromSetValue([Nullable(2)] IHideSpecifyEntityGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideSpecifyEntityGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x001574AA File Offset: 0x001556AA
		public new IHideSpecifyEntityGroup_SetValue ToSetValue()
		{
			return new IHideSpecifyEntityGroup_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ForceClean = this.ForceClean
			};
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x001574D5 File Offset: 0x001556D5
		// (set) Token: 0x0600942B RID: 37931 RVA: 0x00157500 File Offset: 0x00155700
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

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x0015750E File Offset: 0x0015570E
		// (set) Token: 0x0600942D RID: 37933 RVA: 0x00157535 File Offset: 0x00155735
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IHideSpecifyEntityGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x00157544 File Offset: 0x00155744
		// (set) Token: 0x0600942F RID: 37935 RVA: 0x0015757E File Offset: 0x0015577E
		public virtual bool? ForceClean
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceClean;
				}
				IHideSpecifyEntityGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForceClean;
			}
			set
			{
				this.GetOrCreatePoco().ForceClean = value;
			}
		}

		// Token: 0x04005AE3 RID: 23267
		[Nullable(2)]
		protected new IHideSpecifyEntityGroup FbInstance;

		// Token: 0x04005AE4 RID: 23268
		[Nullable(2)]
		protected new IHideSpecifyEntityGroup_SetValue PocoInterface;
	}
}
