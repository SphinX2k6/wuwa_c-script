using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E13 RID: 7699
	public class IMotorRadioDisableByRangeEntities : IMotorRadioDisableRange
	{
		// Token: 0x0600A3C5 RID: 41925 RVA: 0x001766E8 File Offset: 0x001748E8
		private IMotorRadioDisableByRangeEntities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioDisableByRangeEntities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioDisableByRangeEntities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioDisableByRangeEntities_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x00176720 File Offset: 0x00174920
		public static IMotorRadioDisableByRangeEntities Create([Nullable(2)] IMotorRadioDisableByRangeEntities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioDisableByRangeEntities
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x00176733 File Offset: 0x00174933
		public static IMotorRadioDisableByRangeEntities CreateFromSetValue([Nullable(2)] IMotorRadioDisableByRangeEntities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioDisableByRangeEntities
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x00176746 File Offset: 0x00174946
		public new IMotorRadioDisableByRangeEntities_SetValue ToSetValue()
		{
			return new IMotorRadioDisableByRangeEntities_SetValue
			{
				Type = this.Type,
				RangeEntities = this.RangeEntities
			};
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600A3C9 RID: 41929 RVA: 0x00176765 File Offset: 0x00174965
		// (set) Token: 0x0600A3CA RID: 41930 RVA: 0x00176790 File Offset: 0x00174990
		public override EMotorRadioDisableRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorRadioDisableRangeType.ByAreaId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x0017679E File Offset: 0x0017499E
		// (set) Token: 0x0600A3CC RID: 41932 RVA: 0x001767C5 File Offset: 0x001749C5
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntities;
				}
				IMotorRadioDisableByRangeEntities_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntities = value;
			}
		}

		// Token: 0x04006327 RID: 25383
		[Nullable(2)]
		protected new IMotorRadioDisableByRangeEntities FbInstance;

		// Token: 0x04006328 RID: 25384
		[Nullable(2)]
		protected new IMotorRadioDisableByRangeEntities_SetValue PocoInterface;
	}
}
