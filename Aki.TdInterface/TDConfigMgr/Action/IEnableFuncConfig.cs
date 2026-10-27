using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E4 RID: 6628
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableFuncConfig
	{
		// Token: 0x06008DEF RID: 36335 RVA: 0x0014C3B4 File Offset: 0x0014A5B4
		private IEnableFuncConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableFuncConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableFuncConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableFuncConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x0014C3EC File Offset: 0x0014A5EC
		public static IEnableFuncConfig Create([Nullable(2)] IEnableFuncConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableFuncConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x0014C3FF File Offset: 0x0014A5FF
		public static IEnableFuncConfig CreateFromSetValue([Nullable(2)] IEnableFuncConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableFuncConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x0014C412 File Offset: 0x0014A612
		public IEnableFuncConfig_SetValue ToSetValue()
		{
			return new IEnableFuncConfig_SetValue
			{
				DelayDuration = this.DelayDuration,
				IsEnableEsc = this.IsEnableEsc,
				IsEnablePhoto = this.IsEnablePhoto
			};
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x06008DF3 RID: 36339 RVA: 0x0014C440 File Offset: 0x0014A640
		// (set) Token: 0x06008DF4 RID: 36340 RVA: 0x0014C47A File Offset: 0x0014A67A
		public virtual float? DelayDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDuration;
				}
				IEnableFuncConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayDuration;
			}
			set
			{
				this.GetOrCreatePoco().DelayDuration = value;
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x0014C488 File Offset: 0x0014A688
		// (set) Token: 0x06008DF6 RID: 36342 RVA: 0x0014C4C2 File Offset: 0x0014A6C2
		public virtual bool? IsEnableEsc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnableEsc;
				}
				IEnableFuncConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnableEsc;
			}
			set
			{
				this.GetOrCreatePoco().IsEnableEsc = value;
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x06008DF7 RID: 36343 RVA: 0x0014C4D0 File Offset: 0x0014A6D0
		// (set) Token: 0x06008DF8 RID: 36344 RVA: 0x0014C50A File Offset: 0x0014A70A
		public virtual bool? IsEnablePhoto
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnablePhoto;
				}
				IEnableFuncConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnablePhoto;
			}
			set
			{
				this.GetOrCreatePoco().IsEnablePhoto = value;
			}
		}

		// Token: 0x04005815 RID: 22549
		[Nullable(2)]
		protected IEnableFuncConfig FbInstance;

		// Token: 0x04005816 RID: 22550
		[Nullable(2)]
		protected IEnableFuncConfig_SetValue PocoInterface;
	}
}
