using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF9 RID: 7929
	public class IPhotographCameraTransformBase
	{
		// Token: 0x0600A8BD RID: 43197 RVA: 0x0017F4E4 File Offset: 0x0017D6E4
		private IPhotographCameraTransformBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographCameraTransformBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographCameraTransformBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographCameraTransformBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x0017F51C File Offset: 0x0017D71C
		public static IPhotographCameraTransformBase Create([Nullable(2)] IPhotographCameraTransformBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCameraTransformBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x0017F52F File Offset: 0x0017D72F
		public static IPhotographCameraTransformBase CreateFromSetValue([Nullable(2)] IPhotographCameraTransformBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographCameraTransformBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x0017F542 File Offset: 0x0017D742
		public IPhotographCameraTransformBase_SetValue ToSetValue()
		{
			return new IPhotographCameraTransformBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600A8C1 RID: 43201 RVA: 0x0017F555 File Offset: 0x0017D755
		// (set) Token: 0x0600A8C2 RID: 43202 RVA: 0x0017F580 File Offset: 0x0017D780
		public virtual EPhotographCameraTransform Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhotographCameraTransform.Absolute;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006568 RID: 25960
		[Nullable(2)]
		protected IPhotographCameraTransformBase FbInstance;

		// Token: 0x04006569 RID: 25961
		[Nullable(2)]
		protected IPhotographCameraTransformBase_SetValue PocoInterface;
	}
}
