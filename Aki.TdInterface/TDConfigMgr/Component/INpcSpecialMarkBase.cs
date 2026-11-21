using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DB RID: 1499
	public class INpcSpecialMarkBase
	{
		// Token: 0x06001E96 RID: 7830 RVA: 0x00056788 File Offset: 0x00054988
		private INpcSpecialMarkBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSpecialMarkBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSpecialMarkBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSpecialMarkBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000567C0 File Offset: 0x000549C0
		public static INpcSpecialMarkBase Create([Nullable(2)] INpcSpecialMarkBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x000567D3 File Offset: 0x000549D3
		public static INpcSpecialMarkBase CreateFromSetValue([Nullable(2)] INpcSpecialMarkBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSpecialMarkBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000567E6 File Offset: 0x000549E6
		public INpcSpecialMarkBase_SetValue ToSetValue()
		{
			return new INpcSpecialMarkBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x000567F9 File Offset: 0x000549F9
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x00056824 File Offset: 0x00054A24
		public virtual ESpecialNpcMarkType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialNpcMarkType.TrafficLight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040015C8 RID: 5576
		[Nullable(2)]
		protected INpcSpecialMarkBase FbInstance;

		// Token: 0x040015C9 RID: 5577
		[Nullable(2)]
		protected INpcSpecialMarkBase_SetValue PocoInterface;
	}
}
