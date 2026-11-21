using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002201 RID: 8705
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextUiConfig
	{
		// Token: 0x0600BDC0 RID: 48576 RVA: 0x001B6AE4 File Offset: 0x001B4CE4
		[NullableContext(0)]
		private ITextUiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITextUiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITextUiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITextUiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x001B6B1C File Offset: 0x001B4D1C
		[NullableContext(0)]
		public static ITextUiConfig Create([Nullable(2)] ITextUiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITextUiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x001B6B2F File Offset: 0x001B4D2F
		[NullableContext(0)]
		public static ITextUiConfig CreateFromSetValue([Nullable(2)] ITextUiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITextUiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDC3 RID: 48579 RVA: 0x001B6B44 File Offset: 0x001B4D44
		[NullableContext(0)]
		public ITextUiConfig_SetValue ToSetValue()
		{
			return new ITextUiConfig_SetValue
			{
				Type = this.Type,
				InitTipText = this.InitTipText,
				ProgressTipText = this.ProgressTipText,
				SkipText = this.SkipText,
				FinishText = this.FinishText,
				InitDialogues = this.InitDialogues,
				SkipConfirmBoxId = this.SkipConfirmBoxId,
				LoopAudioEvent = this.LoopAudioEvent
			};
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x001B6BB6 File Offset: 0x001B4DB6
		// (set) Token: 0x0600BDC5 RID: 48581 RVA: 0x001B6BE1 File Offset: 0x001B4DE1
		public virtual ETextUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETextUiType.Astrology;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600BDC6 RID: 48582 RVA: 0x001B6BEF File Offset: 0x001B4DEF
		// (set) Token: 0x0600BDC7 RID: 48583 RVA: 0x001B6C16 File Offset: 0x001B4E16
		public virtual string InitTipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitTipText;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitTipText;
			}
			set
			{
				this.GetOrCreatePoco().InitTipText = value;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600BDC8 RID: 48584 RVA: 0x001B6C24 File Offset: 0x001B4E24
		// (set) Token: 0x0600BDC9 RID: 48585 RVA: 0x001B6C4B File Offset: 0x001B4E4B
		public virtual string ProgressTipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressTipText;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressTipText;
			}
			set
			{
				this.GetOrCreatePoco().ProgressTipText = value;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600BDCA RID: 48586 RVA: 0x001B6C59 File Offset: 0x001B4E59
		// (set) Token: 0x0600BDCB RID: 48587 RVA: 0x001B6C80 File Offset: 0x001B4E80
		public virtual string SkipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkipText;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkipText;
			}
			set
			{
				this.GetOrCreatePoco().SkipText = value;
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600BDCC RID: 48588 RVA: 0x001B6C8E File Offset: 0x001B4E8E
		// (set) Token: 0x0600BDCD RID: 48589 RVA: 0x001B6CB5 File Offset: 0x001B4EB5
		public virtual string FinishText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishText;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishText;
			}
			set
			{
				this.GetOrCreatePoco().FinishText = value;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600BDCE RID: 48590 RVA: 0x001B6CC3 File Offset: 0x001B4EC3
		// (set) Token: 0x0600BDCF RID: 48591 RVA: 0x001B6CEA File Offset: 0x001B4EEA
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitDialogues
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitDialogues;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitDialogues;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitDialogues = value;
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600BDD0 RID: 48592 RVA: 0x001B6CF8 File Offset: 0x001B4EF8
		// (set) Token: 0x0600BDD1 RID: 48593 RVA: 0x001B6D32 File Offset: 0x001B4F32
		public virtual int? SkipConfirmBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkipConfirmBoxId;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkipConfirmBoxId;
			}
			set
			{
				this.GetOrCreatePoco().SkipConfirmBoxId = value;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600BDD2 RID: 48594 RVA: 0x001B6D40 File Offset: 0x001B4F40
		// (set) Token: 0x0600BDD3 RID: 48595 RVA: 0x001B6D67 File Offset: 0x001B4F67
		public virtual string LoopAudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopAudioEvent;
				}
				ITextUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopAudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().LoopAudioEvent = value;
			}
		}

		// Token: 0x040071E7 RID: 29159
		protected ITextUiConfig FbInstance;

		// Token: 0x040071E8 RID: 29160
		protected ITextUiConfig_SetValue PocoInterface;
	}
}
