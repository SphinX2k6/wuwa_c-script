using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBE RID: 8126
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextUiConfig
	{
		// Token: 0x0600B2BC RID: 45756 RVA: 0x001A0734 File Offset: 0x0019E934
		[NullableContext(1)]
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

		// Token: 0x0600B2BD RID: 45757 RVA: 0x001A076C File Offset: 0x0019E96C
		[NullableContext(1)]
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

		// Token: 0x0600B2BE RID: 45758 RVA: 0x001A077F File Offset: 0x0019E97F
		[NullableContext(1)]
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

		// Token: 0x0600B2BF RID: 45759 RVA: 0x001A0794 File Offset: 0x0019E994
		[NullableContext(1)]
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

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600B2C0 RID: 45760 RVA: 0x001A0806 File Offset: 0x0019EA06
		// (set) Token: 0x0600B2C1 RID: 45761 RVA: 0x001A0831 File Offset: 0x0019EA31
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

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600B2C2 RID: 45762 RVA: 0x001A083F File Offset: 0x0019EA3F
		// (set) Token: 0x0600B2C3 RID: 45763 RVA: 0x001A0866 File Offset: 0x0019EA66
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

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x001A0874 File Offset: 0x0019EA74
		// (set) Token: 0x0600B2C5 RID: 45765 RVA: 0x001A089B File Offset: 0x0019EA9B
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

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600B2C6 RID: 45766 RVA: 0x001A08A9 File Offset: 0x0019EAA9
		// (set) Token: 0x0600B2C7 RID: 45767 RVA: 0x001A08D0 File Offset: 0x0019EAD0
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

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600B2C8 RID: 45768 RVA: 0x001A08DE File Offset: 0x0019EADE
		// (set) Token: 0x0600B2C9 RID: 45769 RVA: 0x001A0905 File Offset: 0x0019EB05
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

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x001A0913 File Offset: 0x0019EB13
		// (set) Token: 0x0600B2CB RID: 45771 RVA: 0x001A093A File Offset: 0x0019EB3A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> InitDialogues
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().InitDialogues = value;
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x001A0948 File Offset: 0x0019EB48
		// (set) Token: 0x0600B2CD RID: 45773 RVA: 0x001A0982 File Offset: 0x0019EB82
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

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x001A0990 File Offset: 0x0019EB90
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x001A09B7 File Offset: 0x0019EBB7
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

		// Token: 0x04006BEC RID: 27628
		protected ITextUiConfig FbInstance;

		// Token: 0x04006BED RID: 27629
		protected ITextUiConfig_SetValue PocoInterface;
	}
}
