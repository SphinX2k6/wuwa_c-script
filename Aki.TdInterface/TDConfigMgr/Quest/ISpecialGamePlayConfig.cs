using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001272 RID: 4722
	public class ISpecialGamePlayConfig
	{
		// Token: 0x06006A55 RID: 27221 RVA: 0x000FE65C File Offset: 0x000FC85C
		private ISpecialGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x000FE694 File Offset: 0x000FC894
		public static ISpecialGamePlayConfig Create([Nullable(2)] ISpecialGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x000FE6A7 File Offset: 0x000FC8A7
		public static ISpecialGamePlayConfig CreateFromSetValue([Nullable(2)] ISpecialGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x000FE6BA File Offset: 0x000FC8BA
		public ISpecialGamePlayConfig_SetValue ToSetValue()
		{
			return new ISpecialGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x000FE6CD File Offset: 0x000FC8CD
		// (set) Token: 0x06006A5A RID: 27226 RVA: 0x000FE6F8 File Offset: 0x000FC8F8
		public virtual ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003F9B RID: 16283
		[Nullable(2)]
		protected ISpecialGamePlayConfig FbInstance;

		// Token: 0x04003F9C RID: 16284
		[Nullable(2)]
		protected ISpecialGamePlayConfig_SetValue PocoInterface;
	}
}
