using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C16 RID: 7190
	public class IFlowCameraShake
	{
		// Token: 0x060098C0 RID: 39104 RVA: 0x0016254C File Offset: 0x0016074C
		private IFlowCameraShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowCameraShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowCameraShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowCameraShake_SetValue());
			}
			return result;
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x00162584 File Offset: 0x00160784
		public static IFlowCameraShake Create([Nullable(2)] IFlowCameraShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowCameraShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x00162597 File Offset: 0x00160797
		public static IFlowCameraShake CreateFromSetValue([Nullable(2)] IFlowCameraShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowCameraShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x001625AA File Offset: 0x001607AA
		public IFlowCameraShake_SetValue ToSetValue()
		{
			return new IFlowCameraShake_SetValue
			{
				CameraShakeBp = this.CameraShakeBp
			};
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x060098C4 RID: 39108 RVA: 0x001625BD File Offset: 0x001607BD
		// (set) Token: 0x060098C5 RID: 39109 RVA: 0x001625E8 File Offset: 0x001607E8
		public virtual string CameraShakeBp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraShakeBp;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CameraShakeBp;
			}
			set
			{
				this.GetOrCreatePoco().CameraShakeBp = value;
			}
		}

		// Token: 0x04005E0B RID: 24075
		[Nullable(2)]
		protected IFlowCameraShake FbInstance;

		// Token: 0x04005E0C RID: 24076
		[Nullable(2)]
		protected IFlowCameraShake_SetValue PocoInterface;
	}
}
