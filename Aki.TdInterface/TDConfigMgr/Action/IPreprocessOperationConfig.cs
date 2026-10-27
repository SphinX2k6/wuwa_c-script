using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D52 RID: 7506
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreprocessOperationConfig
	{
		// Token: 0x0600A105 RID: 41221 RVA: 0x0016F0D8 File Offset: 0x0016D2D8
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

		// Token: 0x0600A106 RID: 41222 RVA: 0x0016F110 File Offset: 0x0016D310
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

		// Token: 0x0600A107 RID: 41223 RVA: 0x0016F123 File Offset: 0x0016D323
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

		// Token: 0x0600A108 RID: 41224 RVA: 0x0016F136 File Offset: 0x0016D336
		public IPreprocessOperationConfig_SetValue ToSetValue()
		{
			return new IPreprocessOperationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600A109 RID: 41225 RVA: 0x0016F149 File Offset: 0x0016D349
		// (set) Token: 0x0600A10A RID: 41226 RVA: 0x0016F174 File Offset: 0x0016D374
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

		// Token: 0x040060F7 RID: 24823
		[Nullable(2)]
		protected IPreprocessOperationConfig FbInstance;

		// Token: 0x040060F8 RID: 24824
		[Nullable(2)]
		protected IPreprocessOperationConfig_SetValue PocoInterface;
	}
}
