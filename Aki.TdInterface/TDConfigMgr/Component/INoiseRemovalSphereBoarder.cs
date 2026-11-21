using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B9 RID: 1465
	public class INoiseRemovalSphereBoarder : INoiseRemovalBoarderBase
	{
		// Token: 0x06001DDC RID: 7644 RVA: 0x000551C0 File Offset: 0x000533C0
		private INoiseRemovalSphereBoarder_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INoiseRemovalSphereBoarder 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INoiseRemovalSphereBoarder_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INoiseRemovalSphereBoarder_SetValue());
			}
			return result;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000551F8 File Offset: 0x000533F8
		public static INoiseRemovalSphereBoarder Create([Nullable(2)] INoiseRemovalSphereBoarder instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalSphereBoarder
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0005520B File Offset: 0x0005340B
		public static INoiseRemovalSphereBoarder CreateFromSetValue([Nullable(2)] INoiseRemovalSphereBoarder_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INoiseRemovalSphereBoarder
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0005521E File Offset: 0x0005341E
		public new INoiseRemovalSphereBoarder_SetValue ToSetValue()
		{
			return new INoiseRemovalSphereBoarder_SetValue
			{
				Type = this.Type,
				Radius = this.Radius
			};
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0005523D File Offset: 0x0005343D
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00055268 File Offset: 0x00053468
		public override ENoiseRemovalBoarderShape Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00055276 File Offset: 0x00053476
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x000552A5 File Offset: 0x000534A5
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x0400156A RID: 5482
		[Nullable(2)]
		protected new INoiseRemovalSphereBoarder FbInstance;

		// Token: 0x0400156B RID: 5483
		[Nullable(2)]
		protected new INoiseRemovalSphereBoarder_SetValue PocoInterface;
	}
}
