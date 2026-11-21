using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004DC RID: 1244
	public class IInteractPlayerDiractionToLeisure : IInteractPlayerDiractionType
	{
		// Token: 0x060018D8 RID: 6360 RVA: 0x0004A820 File Offset: 0x00048A20
		private IInteractPlayerDiractionToLeisure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPlayerDiractionToLeisure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPlayerDiractionToLeisure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPlayerDiractionToLeisure_SetValue());
			}
			return result;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0004A858 File Offset: 0x00048A58
		public static IInteractPlayerDiractionToLeisure Create([Nullable(2)] IInteractPlayerDiractionToLeisure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToLeisure
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0004A86B File Offset: 0x00048A6B
		public static IInteractPlayerDiractionToLeisure CreateFromSetValue([Nullable(2)] IInteractPlayerDiractionToLeisure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToLeisure
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0004A87E File Offset: 0x00048A7E
		public new IInteractPlayerDiractionToLeisure_SetValue ToSetValue()
		{
			return new IInteractPlayerDiractionToLeisure_SetValue
			{
				Type = this.Type,
				Begin = this.Begin,
				End = this.End
			};
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0004A8A9 File Offset: 0x00048AA9
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x0004A8D4 File Offset: 0x00048AD4
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x0004A8E2 File Offset: 0x00048AE2
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x0004A90D File Offset: 0x00048B0D
		public virtual int Begin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Begin;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Begin;
			}
			set
			{
				this.GetOrCreatePoco().Begin = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x0004A91B File Offset: 0x00048B1B
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x0004A946 File Offset: 0x00048B46
		public virtual int End
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.End;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.End;
			}
			set
			{
				this.GetOrCreatePoco().End = value;
			}
		}

		// Token: 0x0400129C RID: 4764
		[Nullable(2)]
		protected new IInteractPlayerDiractionToLeisure FbInstance;

		// Token: 0x0400129D RID: 4765
		[Nullable(2)]
		protected new IInteractPlayerDiractionToLeisure_SetValue PocoInterface;
	}
}
