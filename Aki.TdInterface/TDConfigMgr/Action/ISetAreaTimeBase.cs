using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203F RID: 8255
	public class ISetAreaTimeBase
	{
		// Token: 0x0600AF39 RID: 44857 RVA: 0x0018ACF4 File Offset: 0x00188EF4
		private ISetAreaTimeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAreaTimeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAreaTimeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAreaTimeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x0018AD2C File Offset: 0x00188F2C
		public static ISetAreaTimeBase Create([Nullable(2)] ISetAreaTimeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF3B RID: 44859 RVA: 0x0018AD3F File Offset: 0x00188F3F
		public static ISetAreaTimeBase CreateFromSetValue([Nullable(2)] ISetAreaTimeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAreaTimeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x0018AD52 File Offset: 0x00188F52
		public ISetAreaTimeBase_SetValue ToSetValue()
		{
			return new ISetAreaTimeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600AF3D RID: 44861 RVA: 0x0018AD65 File Offset: 0x00188F65
		// (set) Token: 0x0600AF3E RID: 44862 RVA: 0x0018AD90 File Offset: 0x00188F90
		public virtual ESetAreaTime Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetAreaTime.Lock;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400685D RID: 26717
		[Nullable(2)]
		protected ISetAreaTimeBase FbInstance;

		// Token: 0x0400685E RID: 26718
		[Nullable(2)]
		protected ISetAreaTimeBase_SetValue PocoInterface;
	}
}
