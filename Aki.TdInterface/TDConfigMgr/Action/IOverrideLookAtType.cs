using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC3 RID: 7875
	public class IOverrideLookAtType
	{
		// Token: 0x0600A79F RID: 42911 RVA: 0x0017D428 File Offset: 0x0017B628
		private IOverrideLookAtType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOverrideLookAtType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOverrideLookAtType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOverrideLookAtType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x0017D460 File Offset: 0x0017B660
		public static IOverrideLookAtType Create([Nullable(2)] IOverrideLookAtType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOverrideLookAtType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x0017D473 File Offset: 0x0017B673
		public static IOverrideLookAtType CreateFromSetValue([Nullable(2)] IOverrideLookAtType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOverrideLookAtType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x0017D486 File Offset: 0x0017B686
		public IOverrideLookAtType_SetValue ToSetValue()
		{
			return new IOverrideLookAtType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x0017D499 File Offset: 0x0017B699
		// (set) Token: 0x0600A7A4 RID: 42916 RVA: 0x0017D4C4 File Offset: 0x0017B6C4
		public virtual EOverrideLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064E6 RID: 25830
		[Nullable(2)]
		protected IOverrideLookAtType FbInstance;

		// Token: 0x040064E7 RID: 25831
		[Nullable(2)]
		protected IOverrideLookAtType_SetValue PocoInterface;
	}
}
