using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3F RID: 7487
	public class ILimitPlayerMove : ILimitPlayerOption
	{
		// Token: 0x06009EFB RID: 40699 RVA: 0x0016D60C File Offset: 0x0016B80C
		private ILimitPlayerMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerMove_SetValue());
			}
			return result;
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x0016D644 File Offset: 0x0016B844
		public static ILimitPlayerMove Create([Nullable(2)] ILimitPlayerMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x0016D657 File Offset: 0x0016B857
		public static ILimitPlayerMove CreateFromSetValue([Nullable(2)] ILimitPlayerMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x0016D66A File Offset: 0x0016B86A
		public new ILimitPlayerMove_SetValue ToSetValue()
		{
			return new ILimitPlayerMove_SetValue
			{
				Type = this.Type,
				IsOnlyForward = this.IsOnlyForward
			};
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x0016D689 File Offset: 0x0016B889
		// (set) Token: 0x06009F00 RID: 40704 RVA: 0x0016D6B4 File Offset: 0x0016B8B4
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x0016D6C4 File Offset: 0x0016B8C4
		// (set) Token: 0x06009F02 RID: 40706 RVA: 0x0016D6FE File Offset: 0x0016B8FE
		public virtual bool? IsOnlyForward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOnlyForward;
				}
				ILimitPlayerMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOnlyForward;
			}
			set
			{
				this.GetOrCreatePoco().IsOnlyForward = value;
			}
		}

		// Token: 0x040060DE RID: 24798
		[Nullable(2)]
		protected new ILimitPlayerMove FbInstance;

		// Token: 0x040060DF RID: 24799
		[Nullable(2)]
		protected new ILimitPlayerMove_SetValue PocoInterface;
	}
}
