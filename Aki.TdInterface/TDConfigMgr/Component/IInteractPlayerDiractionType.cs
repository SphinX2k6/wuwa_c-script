using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000487 RID: 1159
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPlayerDiractionType
	{
		// Token: 0x06001752 RID: 5970 RVA: 0x00046CD8 File Offset: 0x00044ED8
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

		// Token: 0x06001753 RID: 5971 RVA: 0x00046D10 File Offset: 0x00044F10
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

		// Token: 0x06001754 RID: 5972 RVA: 0x00046D23 File Offset: 0x00044F23
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

		// Token: 0x06001755 RID: 5973 RVA: 0x00046D36 File Offset: 0x00044F36
		public IInteractPlayerDiractionType_SetValue ToSetValue()
		{
			return new IInteractPlayerDiractionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00046D49 File Offset: 0x00044F49
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x00046D74 File Offset: 0x00044F74
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

		// Token: 0x04001182 RID: 4482
		[Nullable(2)]
		protected IInteractPlayerDiractionType FbInstance;

		// Token: 0x04001183 RID: 4483
		[Nullable(2)]
		protected IInteractPlayerDiractionType_SetValue PocoInterface;
	}
}
