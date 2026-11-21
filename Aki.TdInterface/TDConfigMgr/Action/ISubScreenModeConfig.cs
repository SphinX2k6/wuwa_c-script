using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002114 RID: 8468
	public class ISubScreenModeConfig
	{
		// Token: 0x0600B3D6 RID: 46038 RVA: 0x00193594 File Offset: 0x00191794
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

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x001935CC File Offset: 0x001917CC
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

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x001935DF File Offset: 0x001917DF
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

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x001935F2 File Offset: 0x001917F2
		public ISubScreenModeConfig_SetValue ToSetValue()
		{
			return new ISubScreenModeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x00193605 File Offset: 0x00191805
		// (set) Token: 0x0600B3DB RID: 46043 RVA: 0x00193630 File Offset: 0x00191830
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

		// Token: 0x04006A8F RID: 27279
		[Nullable(2)]
		protected ISubScreenModeConfig FbInstance;

		// Token: 0x04006A90 RID: 27280
		[Nullable(2)]
		protected ISubScreenModeConfig_SetValue PocoInterface;
	}
}
