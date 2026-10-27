using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDB RID: 7899
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeConfig
	{
		// Token: 0x0600A904 RID: 43268 RVA: 0x0017D59C File Offset: 0x0017B79C
		private ISubScreenModeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenModeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenModeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenModeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x0017D5D4 File Offset: 0x0017B7D4
		public static ISubScreenModeConfig Create([Nullable(2)] ISubScreenModeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x0017D5E7 File Offset: 0x0017B7E7
		public static ISubScreenModeConfig CreateFromSetValue([Nullable(2)] ISubScreenModeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenModeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x0017D5FA File Offset: 0x0017B7FA
		public ISubScreenModeConfig_SetValue ToSetValue()
		{
			return new ISubScreenModeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600A908 RID: 43272 RVA: 0x0017D60D File Offset: 0x0017B80D
		// (set) Token: 0x0600A909 RID: 43273 RVA: 0x0017D638 File Offset: 0x0017B838
		public virtual ESubScreenOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenOperationType.Init;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064A0 RID: 25760
		[Nullable(2)]
		protected ISubScreenModeConfig FbInstance;

		// Token: 0x040064A1 RID: 25761
		[Nullable(2)]
		protected ISubScreenModeConfig_SetValue PocoInterface;
	}
}
