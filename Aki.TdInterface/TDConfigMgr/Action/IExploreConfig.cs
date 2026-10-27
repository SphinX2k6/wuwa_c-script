using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A31 RID: 6705
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreConfig
	{
		// Token: 0x06008F92 RID: 36754 RVA: 0x0014F2E0 File Offset: 0x0014D4E0
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

		// Token: 0x06008F93 RID: 36755 RVA: 0x0014F318 File Offset: 0x0014D518
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

		// Token: 0x06008F94 RID: 36756 RVA: 0x0014F32B File Offset: 0x0014D52B
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

		// Token: 0x06008F95 RID: 36757 RVA: 0x0014F33E File Offset: 0x0014D53E
		public IExploreConfig_SetValue ToSetValue()
		{
			return new IExploreConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x0014F351 File Offset: 0x0014D551
		// (set) Token: 0x06008F97 RID: 36759 RVA: 0x0014F37C File Offset: 0x0014D57C
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

		// Token: 0x040058CE RID: 22734
		[Nullable(2)]
		protected IExploreConfig FbInstance;

		// Token: 0x040058CF RID: 22735
		[Nullable(2)]
		protected IExploreConfig_SetValue PocoInterface;
	}
}
