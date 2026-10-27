using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E9F RID: 7839
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineMoveConfig
	{
		// Token: 0x0600A7AE RID: 42926 RVA: 0x0017AD90 File Offset: 0x00178F90
		private ISplineMoveConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x0017ADC8 File Offset: 0x00178FC8
		public static ISplineMoveConfig Create([Nullable(2)] ISplineMoveConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x0017ADDB File Offset: 0x00178FDB
		public static ISplineMoveConfig CreateFromSetValue([Nullable(2)] ISplineMoveConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x0017ADEE File Offset: 0x00178FEE
		public ISplineMoveConfig_SetValue ToSetValue()
		{
			return new ISplineMoveConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600A7B2 RID: 42930 RVA: 0x0017AE19 File Offset: 0x00179019
		// (set) Token: 0x0600A7B3 RID: 42931 RVA: 0x0017AE44 File Offset: 0x00179044
		public virtual ESplineMoveConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveConfigType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600A7B4 RID: 42932 RVA: 0x0017AE52 File Offset: 0x00179052
		// (set) Token: 0x0600A7B5 RID: 42933 RVA: 0x0017AE79 File Offset: 0x00179079
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ISplineMoveConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600A7B6 RID: 42934 RVA: 0x0017AE87 File Offset: 0x00179087
		// (set) Token: 0x0600A7B7 RID: 42935 RVA: 0x0017AEB2 File Offset: 0x001790B2
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x040063FB RID: 25595
		[Nullable(2)]
		protected ISplineMoveConfig FbInstance;

		// Token: 0x040063FC RID: 25596
		[Nullable(2)]
		protected ISplineMoveConfig_SetValue PocoInterface;
	}
}
