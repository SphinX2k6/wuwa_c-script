using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014C2 RID: 5314
	[NullableContext(1)]
	[Nullable(0)]
	public class CaptureElementalBox : ActionParams
	{
		// Token: 0x0600790A RID: 30986 RVA: 0x00121FF0 File Offset: 0x001201F0
		private CaptureElementalBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CaptureElementalBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CaptureElementalBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CaptureElementalBox_SetValue());
			}
			return result;
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x00122028 File Offset: 0x00120228
		public static CaptureElementalBox Create([Nullable(2)] CaptureElementalBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CaptureElementalBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x0012203B File Offset: 0x0012023B
		public static CaptureElementalBox CreateFromSetValue([Nullable(2)] CaptureElementalBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CaptureElementalBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x0012204E File Offset: 0x0012024E
		public CaptureElementalBox_SetValue ToSetValue()
		{
			return new CaptureElementalBox_SetValue
			{
				CtrlConfig = this.CtrlConfig,
				TargetPosConfig = this.TargetPosConfig,
				MoveSpeed = this.MoveSpeed
			};
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x00122079 File Offset: 0x00120279
		// (set) Token: 0x0600790F RID: 30991 RVA: 0x001220A0 File Offset: 0x001202A0
		public virtual IControlElementalBoxTypeBase CtrlConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CtrlConfig;
				}
				CaptureElementalBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CtrlConfig;
			}
			set
			{
				this.GetOrCreatePoco().CtrlConfig = value;
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x06007910 RID: 30992 RVA: 0x001220AE File Offset: 0x001202AE
		// (set) Token: 0x06007911 RID: 30993 RVA: 0x001220D5 File Offset: 0x001202D5
		public virtual IElementalBoxTargetPosTypeBase TargetPosConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPosConfig;
				}
				CaptureElementalBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetPosConfig;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosConfig = value;
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x06007912 RID: 30994 RVA: 0x001220E3 File Offset: 0x001202E3
		// (set) Token: 0x06007913 RID: 30995 RVA: 0x00122112 File Offset: 0x00120312
		public virtual float MoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MoveSpeed = value;
			}
		}

		// Token: 0x0400464D RID: 17997
		[Nullable(2)]
		protected new CaptureElementalBox FbInstance;

		// Token: 0x0400464E RID: 17998
		[Nullable(2)]
		protected CaptureElementalBox_SetValue PocoInterface;
	}
}
