using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200186A RID: 6250
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeElementalBoxStateTargetBoxId : IChangeElementalBoxStateTarget
	{
		// Token: 0x06008645 RID: 34373 RVA: 0x0013F098 File Offset: 0x0013D298
		private IChangeElementalBoxStateTargetBoxId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeElementalBoxStateTargetBoxId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeElementalBoxStateTargetBoxId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeElementalBoxStateTargetBoxId_SetValue());
			}
			return result;
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x0013F0D0 File Offset: 0x0013D2D0
		public static IChangeElementalBoxStateTargetBoxId Create([Nullable(2)] IChangeElementalBoxStateTargetBoxId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTargetBoxId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x0013F0E3 File Offset: 0x0013D2E3
		public static IChangeElementalBoxStateTargetBoxId CreateFromSetValue([Nullable(2)] IChangeElementalBoxStateTargetBoxId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTargetBoxId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x0013F0F6 File Offset: 0x0013D2F6
		public new IChangeElementalBoxStateTargetBoxId_SetValue ToSetValue()
		{
			return new IChangeElementalBoxStateTargetBoxId_SetValue
			{
				Type = this.Type,
				TargetBoxId = this.TargetBoxId
			};
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06008649 RID: 34377 RVA: 0x0013F115 File Offset: 0x0013D315
		// (set) Token: 0x0600864A RID: 34378 RVA: 0x0013F140 File Offset: 0x0013D340
		public override EChangeElementalBoxStateTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600864B RID: 34379 RVA: 0x0013F14E File Offset: 0x0013D34E
		// (set) Token: 0x0600864C RID: 34380 RVA: 0x0013F179 File Offset: 0x0013D379
		public virtual int TargetBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetBoxId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetBoxId;
			}
			set
			{
				this.GetOrCreatePoco().TargetBoxId = value;
			}
		}

		// Token: 0x040054B7 RID: 21687
		[Nullable(2)]
		protected new IChangeElementalBoxStateTargetBoxId FbInstance;

		// Token: 0x040054B8 RID: 21688
		[Nullable(2)]
		protected new IChangeElementalBoxStateTargetBoxId_SetValue PocoInterface;
	}
}
