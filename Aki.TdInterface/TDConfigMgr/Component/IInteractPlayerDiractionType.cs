using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E0 RID: 1248
	public class IInteractPlayerDiractionType
	{
		// Token: 0x060018EC RID: 6380 RVA: 0x0004AA20 File Offset: 0x00048C20
		private IInteractPlayerDiractionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPlayerDiractionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPlayerDiractionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPlayerDiractionType_SetValue());
			}
			return result;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0004AA58 File Offset: 0x00048C58
		public static IInteractPlayerDiractionType Create([Nullable(2)] IInteractPlayerDiractionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0004AA6B File Offset: 0x00048C6B
		public static IInteractPlayerDiractionType CreateFromSetValue([Nullable(2)] IInteractPlayerDiractionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0004AA7E File Offset: 0x00048C7E
		public IInteractPlayerDiractionType_SetValue ToSetValue()
		{
			return new IInteractPlayerDiractionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0004AA91 File Offset: 0x00048C91
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0004AABC File Offset: 0x00048CBC
		public virtual EInteractPlayerDiractionType Type
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

		// Token: 0x040012A4 RID: 4772
		[Nullable(2)]
		protected IInteractPlayerDiractionType FbInstance;

		// Token: 0x040012A5 RID: 4773
		[Nullable(2)]
		protected IInteractPlayerDiractionType_SetValue PocoInterface;
	}
}
