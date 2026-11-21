using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA1 RID: 8097
	public class IReigns : IUiGame
	{
		// Token: 0x0600AC27 RID: 44071 RVA: 0x001855DC File Offset: 0x001837DC
		private IReigns_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IReigns 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IReigns_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IReigns_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC28 RID: 44072 RVA: 0x00185614 File Offset: 0x00183814
		public static IReigns Create([Nullable(2)] IReigns instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReigns
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x00185627 File Offset: 0x00183827
		public static IReigns CreateFromSetValue([Nullable(2)] IReigns_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IReigns
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x0018563A File Offset: 0x0018383A
		public new IReigns_SetValue ToSetValue()
		{
			return new IReigns_SetValue
			{
				Type = this.Type,
				ReignsId = this.ReignsId
			};
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600AC2B RID: 44075 RVA: 0x00185659 File Offset: 0x00183859
		// (set) Token: 0x0600AC2C RID: 44076 RVA: 0x00185684 File Offset: 0x00183884
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x00185692 File Offset: 0x00183892
		// (set) Token: 0x0600AC2E RID: 44078 RVA: 0x001856BD File Offset: 0x001838BD
		public virtual int ReignsId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReignsId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ReignsId;
			}
			set
			{
				this.GetOrCreatePoco().ReignsId = value;
			}
		}

		// Token: 0x040066F5 RID: 26357
		[Nullable(2)]
		protected new IReigns FbInstance;

		// Token: 0x040066F6 RID: 26358
		[Nullable(2)]
		protected new IReigns_SetValue PocoInterface;
	}
}
