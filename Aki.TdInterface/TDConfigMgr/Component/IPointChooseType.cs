using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200060A RID: 1546
	[NullableContext(1)]
	[Nullable(0)]
	public class IPointChooseType
	{
		// Token: 0x06002102 RID: 8450 RVA: 0x0005BA20 File Offset: 0x00059C20
		private IPointChooseType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointChooseType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointChooseType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointChooseType_SetValue());
			}
			return result;
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0005BA58 File Offset: 0x00059C58
		public static IPointChooseType Create([Nullable(2)] IPointChooseType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointChooseType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0005BA6B File Offset: 0x00059C6B
		public static IPointChooseType CreateFromSetValue([Nullable(2)] IPointChooseType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointChooseType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0005BA7E File Offset: 0x00059C7E
		public IPointChooseType_SetValue ToSetValue()
		{
			return new IPointChooseType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0005BA91 File Offset: 0x00059C91
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0005BABC File Offset: 0x00059CBC
		public virtual EPointChooseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPointChooseType.SpawnMonsterPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001719 RID: 5913
		[Nullable(2)]
		protected IPointChooseType FbInstance;

		// Token: 0x0400171A RID: 5914
		[Nullable(2)]
		protected IPointChooseType_SetValue PocoInterface;
	}
}
