using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000552 RID: 1362
	[NullableContext(1)]
	[Nullable(0)]
	public class INoiseRemovalSphereBoarder : INoiseRemovalBoarderBase
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x00050404 File Offset: 0x0004E604
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

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0005043C File Offset: 0x0004E63C
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

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0005044F File Offset: 0x0004E64F
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

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00050462 File Offset: 0x0004E662
		public new INoiseRemovalSphereBoarder_SetValue ToSetValue()
		{
			return new INoiseRemovalSphereBoarder_SetValue
			{
				Type = this.Type,
				Radius = this.Radius
			};
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00050481 File Offset: 0x0004E681
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x000504AC File Offset: 0x0004E6AC
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

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000504BA File Offset: 0x0004E6BA
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x000504E9 File Offset: 0x0004E6E9
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

		// Token: 0x04001400 RID: 5120
		[Nullable(2)]
		protected new INoiseRemovalSphereBoarder FbInstance;

		// Token: 0x04001401 RID: 5121
		[Nullable(2)]
		protected new INoiseRemovalSphereBoarder_SetValue PocoInterface;
	}
}
