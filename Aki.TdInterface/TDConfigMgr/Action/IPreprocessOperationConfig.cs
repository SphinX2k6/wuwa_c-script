using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F63 RID: 8035
	public class IPreprocessOperationConfig
	{
		// Token: 0x0600AAF1 RID: 43761 RVA: 0x001834FC File Offset: 0x001816FC
		private IPreprocessOperationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreprocessOperationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreprocessOperationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreprocessOperationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x00183534 File Offset: 0x00181734
		public static IPreprocessOperationConfig Create([Nullable(2)] IPreprocessOperationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreprocessOperationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x00183547 File Offset: 0x00181747
		public static IPreprocessOperationConfig CreateFromSetValue([Nullable(2)] IPreprocessOperationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreprocessOperationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x0018355A File Offset: 0x0018175A
		public IPreprocessOperationConfig_SetValue ToSetValue()
		{
			return new IPreprocessOperationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600AAF5 RID: 43765 RVA: 0x0018356D File Offset: 0x0018176D
		// (set) Token: 0x0600AAF6 RID: 43766 RVA: 0x00183598 File Offset: 0x00181798
		public virtual EPreprocessOperation Type
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

		// Token: 0x04006673 RID: 26227
		[Nullable(2)]
		protected IPreprocessOperationConfig FbInstance;

		// Token: 0x04006674 RID: 26228
		[Nullable(2)]
		protected IPreprocessOperationConfig_SetValue PocoInterface;
	}
}
