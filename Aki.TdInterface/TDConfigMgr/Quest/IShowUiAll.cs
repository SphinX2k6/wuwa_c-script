using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001264 RID: 4708
	public class IShowUiAll : IShowUi
	{
		// Token: 0x06006A07 RID: 27143 RVA: 0x000FDE20 File Offset: 0x000FC020
		private IShowUiAll_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiAll 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiAll_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiAll_SetValue());
			}
			return result;
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x000FDE58 File Offset: 0x000FC058
		public static IShowUiAll Create([Nullable(2)] IShowUiAll instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiAll
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x000FDE6B File Offset: 0x000FC06B
		public static IShowUiAll CreateFromSetValue([Nullable(2)] IShowUiAll_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiAll
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x000FDE7E File Offset: 0x000FC07E
		public new IShowUiAll_SetValue ToSetValue()
		{
			return new IShowUiAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06006A0B RID: 27147 RVA: 0x000FDE91 File Offset: 0x000FC091
		// (set) Token: 0x06006A0C RID: 27148 RVA: 0x000FDEBC File Offset: 0x000FC0BC
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003F79 RID: 16249
		[Nullable(2)]
		protected new IShowUiAll FbInstance;

		// Token: 0x04003F7A RID: 16250
		[Nullable(2)]
		protected new IShowUiAll_SetValue PocoInterface;
	}
}
