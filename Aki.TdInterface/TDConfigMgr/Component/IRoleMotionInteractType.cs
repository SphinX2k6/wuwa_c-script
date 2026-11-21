using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072F RID: 1839
	public class IRoleMotionInteractType
	{
		// Token: 0x0600270A RID: 9994 RVA: 0x00068B50 File Offset: 0x00066D50
		private IRoleMotionInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleMotionInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleMotionInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleMotionInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00068B88 File Offset: 0x00066D88
		public static IRoleMotionInteractType Create([Nullable(2)] IRoleMotionInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleMotionInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00068B9B File Offset: 0x00066D9B
		public static IRoleMotionInteractType CreateFromSetValue([Nullable(2)] IRoleMotionInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleMotionInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00068BAE File Offset: 0x00066DAE
		public IRoleMotionInteractType_SetValue ToSetValue()
		{
			return new IRoleMotionInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x00068BC1 File Offset: 0x00066DC1
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x00068BEC File Offset: 0x00066DEC
		public virtual ERoleMotionInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001ABA RID: 6842
		[Nullable(2)]
		protected IRoleMotionInteractType FbInstance;

		// Token: 0x04001ABB RID: 6843
		[Nullable(2)]
		protected IRoleMotionInteractType_SetValue PocoInterface;
	}
}
