using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004DE RID: 1246
	public class IInteractPlayerDiractionToNpc : IInteractPlayerDiractionType
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x0004A964 File Offset: 0x00048B64
		private IInteractPlayerDiractionToNpc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPlayerDiractionToNpc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPlayerDiractionToNpc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPlayerDiractionToNpc_SetValue());
			}
			return result;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0004A99C File Offset: 0x00048B9C
		public static IInteractPlayerDiractionToNpc Create([Nullable(2)] IInteractPlayerDiractionToNpc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToNpc
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0004A9AF File Offset: 0x00048BAF
		public static IInteractPlayerDiractionToNpc CreateFromSetValue([Nullable(2)] IInteractPlayerDiractionToNpc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToNpc
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0004A9C2 File Offset: 0x00048BC2
		public new IInteractPlayerDiractionToNpc_SetValue ToSetValue()
		{
			return new IInteractPlayerDiractionToNpc_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0004A9D5 File Offset: 0x00048BD5
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x0004AA00 File Offset: 0x00048C00
		public override EInteractPlayerDiractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractPlayerDiractionType.Npc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012A1 RID: 4769
		[Nullable(2)]
		protected new IInteractPlayerDiractionToNpc FbInstance;

		// Token: 0x040012A2 RID: 4770
		[Nullable(2)]
		protected new IInteractPlayerDiractionToNpc_SetValue PocoInterface;
	}
}
