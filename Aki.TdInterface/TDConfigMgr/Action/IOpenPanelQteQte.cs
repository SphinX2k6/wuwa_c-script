using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA2 RID: 7330
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenPanelQteQte : IOpenQteConfig
	{
		// Token: 0x06009D53 RID: 40275 RVA: 0x00168604 File Offset: 0x00166804
		private IOpenPanelQteQte_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenPanelQteQte 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenPanelQteQte_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenPanelQteQte_SetValue());
			}
			return result;
		}

		// Token: 0x06009D54 RID: 40276 RVA: 0x0016863C File Offset: 0x0016683C
		public static IOpenPanelQteQte Create([Nullable(2)] IOpenPanelQteQte instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenPanelQteQte
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D55 RID: 40277 RVA: 0x0016864F File Offset: 0x0016684F
		public static IOpenPanelQteQte CreateFromSetValue([Nullable(2)] IOpenPanelQteQte_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenPanelQteQte
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x00168662 File Offset: 0x00166862
		public new IOpenPanelQteQte_SetValue ToSetValue()
		{
			return new IOpenPanelQteQte_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x00168681 File Offset: 0x00166881
		// (set) Token: 0x06009D58 RID: 40280 RVA: 0x001686AC File Offset: 0x001668AC
		public override EOpenQteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOpenQteType.PanelQte;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06009D59 RID: 40281 RVA: 0x001686BA File Offset: 0x001668BA
		// (set) Token: 0x06009D5A RID: 40282 RVA: 0x001686E5 File Offset: 0x001668E5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005F40 RID: 24384
		[Nullable(2)]
		protected new IOpenPanelQteQte FbInstance;

		// Token: 0x04005F41 RID: 24385
		[Nullable(2)]
		protected new IOpenPanelQteQte_SetValue PocoInterface;
	}
}
