using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200201D RID: 8221
	public class IScreenType
	{
		// Token: 0x0600AE93 RID: 44691 RVA: 0x001899B8 File Offset: 0x00187BB8
		private IScreenType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IScreenType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IScreenType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IScreenType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE94 RID: 44692 RVA: 0x001899F0 File Offset: 0x00187BF0
		public static IScreenType Create([Nullable(2)] IScreenType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScreenType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE95 RID: 44693 RVA: 0x00189A03 File Offset: 0x00187C03
		public static IScreenType CreateFromSetValue([Nullable(2)] IScreenType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IScreenType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE96 RID: 44694 RVA: 0x00189A16 File Offset: 0x00187C16
		public IScreenType_SetValue ToSetValue()
		{
			return new IScreenType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x00189A29 File Offset: 0x00187C29
		// (set) Token: 0x0600AE98 RID: 44696 RVA: 0x00189A54 File Offset: 0x00187C54
		public virtual EScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EScreenType.Main;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400680F RID: 26639
		[Nullable(2)]
		protected IScreenType FbInstance;

		// Token: 0x04006810 RID: 26640
		[Nullable(2)]
		protected IScreenType_SetValue PocoInterface;
	}
}
