using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001970 RID: 6512
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeadeyeCameraConfig
	{
		// Token: 0x06008B7D RID: 35709 RVA: 0x00147ECC File Offset: 0x001460CC
		private IDeadeyeCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x00147F04 File Offset: 0x00146104
		public static IDeadeyeCameraConfig Create([Nullable(2)] IDeadeyeCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x00147F17 File Offset: 0x00146117
		public static IDeadeyeCameraConfig CreateFromSetValue([Nullable(2)] IDeadeyeCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x00147F2A File Offset: 0x0014612A
		public IDeadeyeCameraConfig_SetValue ToSetValue()
		{
			return new IDeadeyeCameraConfig_SetValue
			{
				LookAtPointId = this.LookAtPointId,
				SubLensTag = this.SubLensTag,
				TransitionTime = this.TransitionTime
			};
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x06008B81 RID: 35713 RVA: 0x00147F55 File Offset: 0x00146155
		// (set) Token: 0x06008B82 RID: 35714 RVA: 0x00147F80 File Offset: 0x00146180
		public virtual int LookAtPointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LookAtPointId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LookAtPointId;
			}
			set
			{
				this.GetOrCreatePoco().LookAtPointId = value;
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x06008B83 RID: 35715 RVA: 0x00147F90 File Offset: 0x00146190
		// (set) Token: 0x06008B84 RID: 35716 RVA: 0x00147FCA File Offset: 0x001461CA
		public virtual int? SubLensTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubLensTag;
				}
				IDeadeyeCameraConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SubLensTag;
			}
			set
			{
				this.GetOrCreatePoco().SubLensTag = value;
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x06008B85 RID: 35717 RVA: 0x00147FD8 File Offset: 0x001461D8
		// (set) Token: 0x06008B86 RID: 35718 RVA: 0x00148007 File Offset: 0x00146207
		public virtual float TransitionTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TransitionTime;
			}
			set
			{
				this.GetOrCreatePoco().TransitionTime = value;
			}
		}

		// Token: 0x04005702 RID: 22274
		[Nullable(2)]
		protected IDeadeyeCameraConfig FbInstance;

		// Token: 0x04005703 RID: 22275
		[Nullable(2)]
		protected IDeadeyeCameraConfig_SetValue PocoInterface;
	}
}
