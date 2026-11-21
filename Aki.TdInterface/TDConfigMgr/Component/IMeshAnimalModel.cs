using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000553 RID: 1363
	public class IMeshAnimalModel : IAnimalModelConfig
	{
		// Token: 0x06001BAC RID: 7084 RVA: 0x00050AD4 File Offset: 0x0004ECD4
		private IMeshAnimalModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMeshAnimalModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMeshAnimalModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMeshAnimalModel_SetValue());
			}
			return result;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00050B0C File Offset: 0x0004ED0C
		public static IMeshAnimalModel Create([Nullable(2)] IMeshAnimalModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshAnimalModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00050B1F File Offset: 0x0004ED1F
		public static IMeshAnimalModel CreateFromSetValue([Nullable(2)] IMeshAnimalModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMeshAnimalModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00050B32 File Offset: 0x0004ED32
		public new IMeshAnimalModel_SetValue ToSetValue()
		{
			return new IMeshAnimalModel_SetValue
			{
				Type = this.Type,
				Mesh = this.Mesh
			};
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00050B51 File Offset: 0x0004ED51
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00050B7C File Offset: 0x0004ED7C
		public override EAnimalModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAnimalModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00050B8A File Offset: 0x0004ED8A
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x00050BB5 File Offset: 0x0004EDB5
		public virtual string Mesh
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mesh;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mesh;
			}
			set
			{
				this.GetOrCreatePoco().Mesh = value;
			}
		}

		// Token: 0x0400143F RID: 5183
		[Nullable(2)]
		protected new IMeshAnimalModel FbInstance;

		// Token: 0x04001440 RID: 5184
		[Nullable(2)]
		protected new IMeshAnimalModel_SetValue PocoInterface;
	}
}
