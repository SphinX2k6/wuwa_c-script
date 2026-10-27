using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A81 RID: 6785
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowCameraShake
	{
		// Token: 0x06009156 RID: 37206 RVA: 0x00152620 File Offset: 0x00150820
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

		// Token: 0x06009157 RID: 37207 RVA: 0x00152658 File Offset: 0x00150858
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

		// Token: 0x06009158 RID: 37208 RVA: 0x0015266B File Offset: 0x0015086B
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

		// Token: 0x06009159 RID: 37209 RVA: 0x0015267E File Offset: 0x0015087E
		public IFlowCameraShake_SetValue ToSetValue()
		{
			return new IFlowCameraShake_SetValue
			{
				CameraShakeBp = this.CameraShakeBp
			};
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600915A RID: 37210 RVA: 0x00152691 File Offset: 0x00150891
		// (set) Token: 0x0600915B RID: 37211 RVA: 0x001526BC File Offset: 0x001508BC
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

		// Token: 0x040059A6 RID: 22950
		[Nullable(2)]
		protected IFlowCameraShake FbInstance;

		// Token: 0x040059A7 RID: 22951
		[Nullable(2)]
		protected IFlowCameraShake_SetValue PocoInterface;
	}
}
