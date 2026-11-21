using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E11 RID: 7697
	public class IMotorRadioDisableByAreaId : IMotorRadioDisableRange
	{
		// Token: 0x0600A3BB RID: 41915 RVA: 0x001765EC File Offset: 0x001747EC
		private IMotorRadioDisableByAreaId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioDisableByAreaId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioDisableByAreaId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioDisableByAreaId_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x00176624 File Offset: 0x00174824
		public static IMotorRadioDisableByAreaId Create([Nullable(2)] IMotorRadioDisableByAreaId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioDisableByAreaId
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x00176637 File Offset: 0x00174837
		public static IMotorRadioDisableByAreaId CreateFromSetValue([Nullable(2)] IMotorRadioDisableByAreaId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioDisableByAreaId
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x0017664A File Offset: 0x0017484A
		public new IMotorRadioDisableByAreaId_SetValue ToSetValue()
		{
			return new IMotorRadioDisableByAreaId_SetValue
			{
				Type = this.Type,
				AreaIdList = this.AreaIdList
			};
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600A3BF RID: 41919 RVA: 0x00176669 File Offset: 0x00174869
		// (set) Token: 0x0600A3C0 RID: 41920 RVA: 0x00176694 File Offset: 0x00174894
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

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x001766A2 File Offset: 0x001748A2
		// (set) Token: 0x0600A3C2 RID: 41922 RVA: 0x001766C9 File Offset: 0x001748C9
		public virtual List<int> AreaIdList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIdList;
				}
				IMotorRadioDisableByAreaId_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIdList;
			}
			set
			{
				this.GetOrCreatePoco().AreaIdList = value;
			}
		}

		// Token: 0x04006323 RID: 25379
		[Nullable(2)]
		protected new IMotorRadioDisableByAreaId FbInstance;

		// Token: 0x04006324 RID: 25380
		[Nullable(2)]
		protected new IMotorRadioDisableByAreaId_SetValue PocoInterface;
	}
}
