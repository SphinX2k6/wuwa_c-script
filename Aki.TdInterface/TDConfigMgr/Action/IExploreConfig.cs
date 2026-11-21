using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC6 RID: 7110
	public class IExploreConfig
	{
		// Token: 0x060096FC RID: 38652 RVA: 0x0015F20C File Offset: 0x0015D40C
		private IExploreConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x0015F244 File Offset: 0x0015D444
		public static IExploreConfig Create([Nullable(2)] IExploreConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x0015F257 File Offset: 0x0015D457
		public static IExploreConfig CreateFromSetValue([Nullable(2)] IExploreConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x0015F26A File Offset: 0x0015D46A
		public IExploreConfig_SetValue ToSetValue()
		{
			return new IExploreConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x06009700 RID: 38656 RVA: 0x0015F27D File Offset: 0x0015D47D
		// (set) Token: 0x06009701 RID: 38657 RVA: 0x0015F2A8 File Offset: 0x0015D4A8
		public virtual EExploreStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreStateType.TeleControl;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D33 RID: 23859
		[Nullable(2)]
		protected IExploreConfig FbInstance;

		// Token: 0x04005D34 RID: 23860
		[Nullable(2)]
		protected IExploreConfig_SetValue PocoInterface;
	}
}
