using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D41 RID: 7489
	public class ILimitPlayerMoveNew : ILimitPlayerOption
	{
		// Token: 0x06009F05 RID: 40709 RVA: 0x0016D71C File Offset: 0x0016B91C
		private ILimitPlayerMoveNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerMoveNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerMoveNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerMoveNew_SetValue());
			}
			return result;
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x0016D754 File Offset: 0x0016B954
		public static ILimitPlayerMoveNew Create([Nullable(2)] ILimitPlayerMoveNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMoveNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x0016D767 File Offset: 0x0016B967
		public static ILimitPlayerMoveNew CreateFromSetValue([Nullable(2)] ILimitPlayerMoveNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerMoveNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x0016D77C File Offset: 0x0016B97C
		public new ILimitPlayerMoveNew_SetValue ToSetValue()
		{
			return new ILimitPlayerMoveNew_SetValue
			{
				Type = this.Type,
				Forward = this.Forward,
				Back = this.Back,
				Left = this.Left,
				Right = this.Right
			};
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x06009F09 RID: 40713 RVA: 0x0016D7CA File Offset: 0x0016B9CA
		// (set) Token: 0x06009F0A RID: 40714 RVA: 0x0016D7F5 File Offset: 0x0016B9F5
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

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x0016D803 File Offset: 0x0016BA03
		// (set) Token: 0x06009F0C RID: 40716 RVA: 0x0016D82E File Offset: 0x0016BA2E
		public virtual bool Forward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Forward;
				}
				return this.PocoInterface != null && this.PocoInterface.Forward;
			}
			set
			{
				this.GetOrCreatePoco().Forward = value;
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x06009F0D RID: 40717 RVA: 0x0016D83C File Offset: 0x0016BA3C
		// (set) Token: 0x06009F0E RID: 40718 RVA: 0x0016D867 File Offset: 0x0016BA67
		public virtual bool Back
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Back;
				}
				return this.PocoInterface != null && this.PocoInterface.Back;
			}
			set
			{
				this.GetOrCreatePoco().Back = value;
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x06009F0F RID: 40719 RVA: 0x0016D875 File Offset: 0x0016BA75
		// (set) Token: 0x06009F10 RID: 40720 RVA: 0x0016D8A0 File Offset: 0x0016BAA0
		public virtual bool Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				return this.PocoInterface != null && this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x06009F11 RID: 40721 RVA: 0x0016D8AE File Offset: 0x0016BAAE
		// (set) Token: 0x06009F12 RID: 40722 RVA: 0x0016D8D9 File Offset: 0x0016BAD9
		public virtual bool Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				return this.PocoInterface != null && this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x040060E2 RID: 24802
		[Nullable(2)]
		protected new ILimitPlayerMoveNew FbInstance;

		// Token: 0x040060E3 RID: 24803
		[Nullable(2)]
		protected new ILimitPlayerMoveNew_SetValue PocoInterface;
	}
}
