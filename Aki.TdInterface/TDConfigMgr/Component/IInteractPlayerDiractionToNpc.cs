using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000485 RID: 1157
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPlayerDiractionToNpc : IInteractPlayerDiractionType
	{
		// Token: 0x0600174A RID: 5962 RVA: 0x00046C1C File Offset: 0x00044E1C
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

		// Token: 0x0600174B RID: 5963 RVA: 0x00046C54 File Offset: 0x00044E54
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

		// Token: 0x0600174C RID: 5964 RVA: 0x00046C67 File Offset: 0x00044E67
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

		// Token: 0x0600174D RID: 5965 RVA: 0x00046C7A File Offset: 0x00044E7A
		public new IInteractPlayerDiractionToNpc_SetValue ToSetValue()
		{
			return new IInteractPlayerDiractionToNpc_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00046C8D File Offset: 0x00044E8D
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x00046CB8 File Offset: 0x00044EB8
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

		// Token: 0x0400117F RID: 4479
		[Nullable(2)]
		protected new IInteractPlayerDiractionToNpc FbInstance;

		// Token: 0x04001180 RID: 4480
		[Nullable(2)]
		protected new IInteractPlayerDiractionToNpc_SetValue PocoInterface;
	}
}
