using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000868 RID: 2152
	public class IViewDistanceMode
	{
		// Token: 0x06002E51 RID: 11857 RVA: 0x00077D6C File Offset: 0x00075F6C
		private IViewDistanceMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IViewDistanceMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IViewDistanceMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IViewDistanceMode_SetValue());
			}
			return result;
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x00077DA4 File Offset: 0x00075FA4
		public static IViewDistanceMode Create([Nullable(2)] IViewDistanceMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IViewDistanceMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00077DB7 File Offset: 0x00075FB7
		public static IViewDistanceMode CreateFromSetValue([Nullable(2)] IViewDistanceMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IViewDistanceMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00077DCA File Offset: 0x00075FCA
		public IViewDistanceMode_SetValue ToSetValue()
		{
			return new IViewDistanceMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x00077DDD File Offset: 0x00075FDD
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00077E08 File Offset: 0x00076008
		public virtual EViewDistanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewDistanceType.Low;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001EB4 RID: 7860
		[Nullable(2)]
		protected IViewDistanceMode FbInstance;

		// Token: 0x04001EB5 RID: 7861
		[Nullable(2)]
		protected IViewDistanceMode_SetValue PocoInterface;
	}
}
