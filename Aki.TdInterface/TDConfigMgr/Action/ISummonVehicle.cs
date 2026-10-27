using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EED RID: 7917
	[NullableContext(1)]
	[Nullable(0)]
	public class ISummonVehicle : ISummonEntityType
	{
		// Token: 0x0600A956 RID: 43350 RVA: 0x0017DDFC File Offset: 0x0017BFFC
		private ISummonVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISummonVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISummonVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISummonVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600A957 RID: 43351 RVA: 0x0017DE34 File Offset: 0x0017C034
		public static ISummonVehicle Create([Nullable(2)] ISummonVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A958 RID: 43352 RVA: 0x0017DE47 File Offset: 0x0017C047
		public static ISummonVehicle CreateFromSetValue([Nullable(2)] ISummonVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISummonVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x0017DE5A File Offset: 0x0017C05A
		public new ISummonVehicle_SetValue ToSetValue()
		{
			return new ISummonVehicle_SetValue
			{
				Type = this.Type,
				TemplateId = this.TemplateId,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600A95A RID: 43354 RVA: 0x0017DE85 File Offset: 0x0017C085
		// (set) Token: 0x0600A95B RID: 43355 RVA: 0x0017DEB0 File Offset: 0x0017C0B0
		public override ESummonEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESummonEntityType.Vehicle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600A95C RID: 43356 RVA: 0x0017DEBE File Offset: 0x0017C0BE
		// (set) Token: 0x0600A95D RID: 43357 RVA: 0x0017DEE9 File Offset: 0x0017C0E9
		public virtual string TemplateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TemplateId;
			}
			set
			{
				this.GetOrCreatePoco().TemplateId = value;
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600A95E RID: 43358 RVA: 0x0017DEF7 File Offset: 0x0017C0F7
		// (set) Token: 0x0600A95F RID: 43359 RVA: 0x0017DF22 File Offset: 0x0017C122
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x040064C2 RID: 25794
		[Nullable(2)]
		protected new ISummonVehicle FbInstance;

		// Token: 0x040064C3 RID: 25795
		[Nullable(2)]
		protected new ISummonVehicle_SetValue PocoInterface;
	}
}
