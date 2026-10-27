using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017FA RID: 6138
	[NullableContext(1)]
	[Nullable(0)]
	public class IBasePos2
	{
		// Token: 0x060083D3 RID: 33747 RVA: 0x0013A80C File Offset: 0x00138A0C
		private IBasePos2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBasePos2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBasePos2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBasePos2_SetValue());
			}
			return result;
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x0013A844 File Offset: 0x00138A44
		public static IBasePos2 Create([Nullable(2)] IBasePos2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBasePos2
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x0013A857 File Offset: 0x00138A57
		public static IBasePos2 CreateFromSetValue([Nullable(2)] IBasePos2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBasePos2
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0013A86A File Offset: 0x00138A6A
		public IBasePos2_SetValue ToSetValue()
		{
			return new IBasePos2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x060083D7 RID: 33751 RVA: 0x0013A87D File Offset: 0x00138A7D
		// (set) Token: 0x060083D8 RID: 33752 RVA: 0x0013A8A8 File Offset: 0x00138AA8
		public virtual EPos2 Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPos2.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005390 RID: 21392
		[Nullable(2)]
		protected IBasePos2 FbInstance;

		// Token: 0x04005391 RID: 21393
		[Nullable(2)]
		protected IBasePos2_SetValue PocoInterface;
	}
}
