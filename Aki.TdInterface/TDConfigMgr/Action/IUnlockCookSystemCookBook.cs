using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002021 RID: 8225
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnlockCookSystemCookBook : IUnlockCookSystemType
	{
		// Token: 0x0600B4D6 RID: 46294 RVA: 0x001A44C4 File Offset: 0x001A26C4
		private IUnlockCookSystemCookBook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockCookSystemCookBook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockCookSystemCookBook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockCookSystemCookBook_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x001A44FC File Offset: 0x001A26FC
		public static IUnlockCookSystemCookBook Create([Nullable(2)] IUnlockCookSystemCookBook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemCookBook
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x001A450F File Offset: 0x001A270F
		public static IUnlockCookSystemCookBook CreateFromSetValue([Nullable(2)] IUnlockCookSystemCookBook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockCookSystemCookBook
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x001A4522 File Offset: 0x001A2722
		public new IUnlockCookSystemCookBook_SetValue ToSetValue()
		{
			return new IUnlockCookSystemCookBook_SetValue
			{
				Type = this.Type,
				CookBookId = this.CookBookId
			};
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600B4DA RID: 46298 RVA: 0x001A4541 File Offset: 0x001A2741
		// (set) Token: 0x0600B4DB RID: 46299 RVA: 0x001A456C File Offset: 0x001A276C
		public override EUnlockCookSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockCookSystemType.UnlockCookBook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600B4DC RID: 46300 RVA: 0x001A457A File Offset: 0x001A277A
		// (set) Token: 0x0600B4DD RID: 46301 RVA: 0x001A45A5 File Offset: 0x001A27A5
		public virtual int CookBookId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CookBookId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CookBookId;
			}
			set
			{
				this.GetOrCreatePoco().CookBookId = value;
			}
		}

		// Token: 0x04006CEB RID: 27883
		[Nullable(2)]
		protected new IUnlockCookSystemCookBook FbInstance;

		// Token: 0x04006CEC RID: 27884
		[Nullable(2)]
		protected new IUnlockCookSystemCookBook_SetValue PocoInterface;
	}
}
