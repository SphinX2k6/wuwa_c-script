using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A77 RID: 6775
	[NullableContext(1)]
	[Nullable(0)]
	public class IFloatingSubtitleLanguageDiff : IPreprocessOperationConfig
	{
		// Token: 0x06009116 RID: 37142 RVA: 0x00151E68 File Offset: 0x00150068
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

		// Token: 0x06009117 RID: 37143 RVA: 0x00151EA0 File Offset: 0x001500A0
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

		// Token: 0x06009118 RID: 37144 RVA: 0x00151EB3 File Offset: 0x001500B3
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

		// Token: 0x06009119 RID: 37145 RVA: 0x00151EC6 File Offset: 0x001500C6
		public new IFloatingSubtitleLanguageDiff_SetValue ToSetValue()
		{
			return new IFloatingSubtitleLanguageDiff_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x00151ED9 File Offset: 0x001500D9
		// (set) Token: 0x0600911B RID: 37147 RVA: 0x00151F04 File Offset: 0x00150104
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

		// Token: 0x04005985 RID: 22917
		[Nullable(2)]
		protected new IFloatingSubtitleLanguageDiff FbInstance;

		// Token: 0x04005986 RID: 22918
		[Nullable(2)]
		protected new IFloatingSubtitleLanguageDiff_SetValue PocoInterface;
	}
}
