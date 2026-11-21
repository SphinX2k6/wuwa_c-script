using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0C RID: 7180
	public class IFloatingSubtitleLanguageDiff : IPreprocessOperationConfig
	{
		// Token: 0x06009880 RID: 39040 RVA: 0x00161D94 File Offset: 0x0015FF94
		private IFloatingSubtitleLanguageDiff_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFloatingSubtitleLanguageDiff 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFloatingSubtitleLanguageDiff_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFloatingSubtitleLanguageDiff_SetValue());
			}
			return result;
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x00161DCC File Offset: 0x0015FFCC
		public static IFloatingSubtitleLanguageDiff Create([Nullable(2)] IFloatingSubtitleLanguageDiff instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFloatingSubtitleLanguageDiff
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x00161DDF File Offset: 0x0015FFDF
		public static IFloatingSubtitleLanguageDiff CreateFromSetValue([Nullable(2)] IFloatingSubtitleLanguageDiff_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFloatingSubtitleLanguageDiff
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x00161DF2 File Offset: 0x0015FFF2
		public new IFloatingSubtitleLanguageDiff_SetValue ToSetValue()
		{
			return new IFloatingSubtitleLanguageDiff_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06009884 RID: 39044 RVA: 0x00161E05 File Offset: 0x00160005
		// (set) Token: 0x06009885 RID: 39045 RVA: 0x00161E30 File Offset: 0x00160030
		public override EPreprocessOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreprocessOperation.FloatingSubtitleLanguageDiff;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005DEA RID: 24042
		[Nullable(2)]
		protected new IFloatingSubtitleLanguageDiff FbInstance;

		// Token: 0x04005DEB RID: 24043
		[Nullable(2)]
		protected new IFloatingSubtitleLanguageDiff_SetValue PocoInterface;
	}
}
