using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA3 RID: 7843
	public class IOpenLevelQte : IOpenQteConfig
	{
		// Token: 0x0600A6D3 RID: 42707 RVA: 0x0017BD38 File Offset: 0x00179F38
		private IOpenLevelQte_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenLevelQte 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenLevelQte_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenLevelQte_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x0017BD70 File Offset: 0x00179F70
		public static IOpenLevelQte Create([Nullable(2)] IOpenLevelQte instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenLevelQte
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x0017BD83 File Offset: 0x00179F83
		public static IOpenLevelQte CreateFromSetValue([Nullable(2)] IOpenLevelQte_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenLevelQte
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x0017BD96 File Offset: 0x00179F96
		public new IOpenLevelQte_SetValue ToSetValue()
		{
			return new IOpenLevelQte_SetValue
			{
				Type = this.Type,
				LevelQteEntity = this.LevelQteEntity
			};
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600A6D7 RID: 42711 RVA: 0x0017BDB5 File Offset: 0x00179FB5
		// (set) Token: 0x0600A6D8 RID: 42712 RVA: 0x0017BDE0 File Offset: 0x00179FE0
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

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x0017BDEE File Offset: 0x00179FEE
		// (set) Token: 0x0600A6DA RID: 42714 RVA: 0x0017BE15 File Offset: 0x0017A015
		public virtual ITargetEntityType LevelQteEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelQteEntity;
				}
				IOpenLevelQte_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LevelQteEntity;
			}
			set
			{
				this.GetOrCreatePoco().LevelQteEntity = value;
			}
		}

		// Token: 0x04006488 RID: 25736
		[Nullable(2)]
		protected new IOpenLevelQte FbInstance;

		// Token: 0x04006489 RID: 25737
		[Nullable(2)]
		protected new IOpenLevelQte_SetValue PocoInterface;
	}
}
