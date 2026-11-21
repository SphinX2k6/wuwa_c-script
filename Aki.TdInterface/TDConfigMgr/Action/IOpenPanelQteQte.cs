using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA9 RID: 7849
	public class IOpenPanelQteQte : IOpenQteConfig
	{
		// Token: 0x0600A701 RID: 42753 RVA: 0x0017C264 File Offset: 0x0017A464
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

		// Token: 0x0600A702 RID: 42754 RVA: 0x0017C29C File Offset: 0x0017A49C
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

		// Token: 0x0600A703 RID: 42755 RVA: 0x0017C2AF File Offset: 0x0017A4AF
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

		// Token: 0x0600A704 RID: 42756 RVA: 0x0017C2C2 File Offset: 0x0017A4C2
		public new IOpenPanelQteQte_SetValue ToSetValue()
		{
			return new IOpenPanelQteQte_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600A705 RID: 42757 RVA: 0x0017C2E1 File Offset: 0x0017A4E1
		// (set) Token: 0x0600A706 RID: 42758 RVA: 0x0017C30C File Offset: 0x0017A50C
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

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600A707 RID: 42759 RVA: 0x0017C31A File Offset: 0x0017A51A
		// (set) Token: 0x0600A708 RID: 42760 RVA: 0x0017C345 File Offset: 0x0017A545
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

		// Token: 0x0400649C RID: 25756
		[Nullable(2)]
		protected new IOpenPanelQteQte FbInstance;

		// Token: 0x0400649D RID: 25757
		[Nullable(2)]
		protected new IOpenPanelQteQte_SetValue PocoInterface;
	}
}
