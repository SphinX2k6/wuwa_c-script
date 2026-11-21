using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AFB RID: 6907
	public class IDeadeyeCameraConfig
	{
		// Token: 0x060092B5 RID: 37557 RVA: 0x0015795C File Offset: 0x00155B5C
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

		// Token: 0x060092B6 RID: 37558 RVA: 0x00157994 File Offset: 0x00155B94
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

		// Token: 0x060092B7 RID: 37559 RVA: 0x001579A7 File Offset: 0x00155BA7
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

		// Token: 0x060092B8 RID: 37560 RVA: 0x001579BA File Offset: 0x00155BBA
		public IDeadeyeCameraConfig_SetValue ToSetValue()
		{
			return new IDeadeyeCameraConfig_SetValue
			{
				LookAtPointId = this.LookAtPointId,
				SubLensTag = this.SubLensTag,
				TransitionTime = this.TransitionTime
			};
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x060092B9 RID: 37561 RVA: 0x001579E5 File Offset: 0x00155BE5
		// (set) Token: 0x060092BA RID: 37562 RVA: 0x00157A10 File Offset: 0x00155C10
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

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x060092BB RID: 37563 RVA: 0x00157A20 File Offset: 0x00155C20
		// (set) Token: 0x060092BC RID: 37564 RVA: 0x00157A5A File Offset: 0x00155C5A
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

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x00157A68 File Offset: 0x00155C68
		// (set) Token: 0x060092BE RID: 37566 RVA: 0x00157A97 File Offset: 0x00155C97
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

		// Token: 0x04005B57 RID: 23383
		[Nullable(2)]
		protected IDeadeyeCameraConfig FbInstance;

		// Token: 0x04005B58 RID: 23384
		[Nullable(2)]
		protected IDeadeyeCameraConfig_SetValue PocoInterface;
	}
}
