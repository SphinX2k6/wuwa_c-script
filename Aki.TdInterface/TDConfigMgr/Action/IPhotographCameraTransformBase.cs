using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEA RID: 7402
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographCameraTransformBase
	{
		// Token: 0x06009EDD RID: 40669 RVA: 0x0016B284 File Offset: 0x00169484
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

		// Token: 0x06009EDE RID: 40670 RVA: 0x0016B2BC File Offset: 0x001694BC
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

		// Token: 0x06009EDF RID: 40671 RVA: 0x0016B2CF File Offset: 0x001694CF
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

		// Token: 0x06009EE0 RID: 40672 RVA: 0x0016B2E2 File Offset: 0x001694E2
		public IPhotographCameraTransformBase_SetValue ToSetValue()
		{
			return new IPhotographCameraTransformBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x06009EE1 RID: 40673 RVA: 0x0016B2F5 File Offset: 0x001694F5
		// (set) Token: 0x06009EE2 RID: 40674 RVA: 0x0016B320 File Offset: 0x00169520
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

		// Token: 0x04005FF5 RID: 24565
		[Nullable(2)]
		protected IPhotographCameraTransformBase FbInstance;

		// Token: 0x04005FF6 RID: 24566
		[Nullable(2)]
		protected IPhotographCameraTransformBase_SetValue PocoInterface;
	}
}
