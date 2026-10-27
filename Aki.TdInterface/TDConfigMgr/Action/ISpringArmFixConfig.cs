using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EAD RID: 7853
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpringArmFixConfig
	{
		// Token: 0x0600A7FA RID: 43002 RVA: 0x0017B634 File Offset: 0x00179834
		private ISpringArmFixConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpringArmFixConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpringArmFixConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpringArmFixConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x0017B66C File Offset: 0x0017986C
		public static ISpringArmFixConfig Create([Nullable(2)] ISpringArmFixConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpringArmFixConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x0017B67F File Offset: 0x0017987F
		public static ISpringArmFixConfig CreateFromSetValue([Nullable(2)] ISpringArmFixConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpringArmFixConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x0017B692 File Offset: 0x00179892
		public ISpringArmFixConfig_SetValue ToSetValue()
		{
			return new ISpringArmFixConfig_SetValue
			{
				LeftRightFix = this.LeftRightFix,
				ForwardBackFix = this.ForwardBackFix,
				UpDownFix = this.UpDownFix
			};
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600A7FE RID: 43006 RVA: 0x0017B6C0 File Offset: 0x001798C0
		// (set) Token: 0x0600A7FF RID: 43007 RVA: 0x0017B6FA File Offset: 0x001798FA
		public virtual bool? LeftRightFix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeftRightFix;
				}
				ISpringArmFixConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LeftRightFix;
			}
			set
			{
				this.GetOrCreatePoco().LeftRightFix = value;
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600A800 RID: 43008 RVA: 0x0017B708 File Offset: 0x00179908
		// (set) Token: 0x0600A801 RID: 43009 RVA: 0x0017B742 File Offset: 0x00179942
		public virtual bool? ForwardBackFix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardBackFix;
				}
				ISpringArmFixConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForwardBackFix;
			}
			set
			{
				this.GetOrCreatePoco().ForwardBackFix = value;
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600A802 RID: 43010 RVA: 0x0017B750 File Offset: 0x00179950
		// (set) Token: 0x0600A803 RID: 43011 RVA: 0x0017B78A File Offset: 0x0017998A
		public virtual bool? UpDownFix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpDownFix;
				}
				ISpringArmFixConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpDownFix;
			}
			set
			{
				this.GetOrCreatePoco().UpDownFix = value;
			}
		}

		// Token: 0x0400641C RID: 25628
		[Nullable(2)]
		protected ISpringArmFixConfig FbInstance;

		// Token: 0x0400641D RID: 25629
		[Nullable(2)]
		protected ISpringArmFixConfig_SetValue PocoInterface;
	}
}
