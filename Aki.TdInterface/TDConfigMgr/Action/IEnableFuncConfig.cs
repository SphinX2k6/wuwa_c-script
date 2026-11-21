using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B71 RID: 7025
	public class IEnableFuncConfig
	{
		// Token: 0x06009531 RID: 38193 RVA: 0x0015BEC0 File Offset: 0x0015A0C0
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

		// Token: 0x06009532 RID: 38194 RVA: 0x0015BEF8 File Offset: 0x0015A0F8
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

		// Token: 0x06009533 RID: 38195 RVA: 0x0015BF0B File Offset: 0x0015A10B
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

		// Token: 0x06009534 RID: 38196 RVA: 0x0015BF1E File Offset: 0x0015A11E
		public IEnableFuncConfig_SetValue ToSetValue()
		{
			return new IEnableFuncConfig_SetValue
			{
				DelayDuration = this.DelayDuration,
				IsEnableEsc = this.IsEnableEsc,
				IsEnablePhoto = this.IsEnablePhoto
			};
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x06009535 RID: 38197 RVA: 0x0015BF4C File Offset: 0x0015A14C
		// (set) Token: 0x06009536 RID: 38198 RVA: 0x0015BF86 File Offset: 0x0015A186
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

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x06009537 RID: 38199 RVA: 0x0015BF94 File Offset: 0x0015A194
		// (set) Token: 0x06009538 RID: 38200 RVA: 0x0015BFCE File Offset: 0x0015A1CE
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

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x06009539 RID: 38201 RVA: 0x0015BFDC File Offset: 0x0015A1DC
		// (set) Token: 0x0600953A RID: 38202 RVA: 0x0015C016 File Offset: 0x0015A216
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

		// Token: 0x04005C6A RID: 23658
		[Nullable(2)]
		protected IEnableFuncConfig FbInstance;

		// Token: 0x04005C6B RID: 23659
		[Nullable(2)]
		protected IEnableFuncConfig_SetValue PocoInterface;
	}
}
