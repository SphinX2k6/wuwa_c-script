using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001868 RID: 6248
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeElementalBoxStateTarget
	{
		// Token: 0x0600863D RID: 34365 RVA: 0x0013EFDC File Offset: 0x0013D1DC
		private IChangeElementalBoxStateTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeElementalBoxStateTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeElementalBoxStateTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeElementalBoxStateTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600863E RID: 34366 RVA: 0x0013F014 File Offset: 0x0013D214
		public static IChangeElementalBoxStateTarget Create([Nullable(2)] IChangeElementalBoxStateTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600863F RID: 34367 RVA: 0x0013F027 File Offset: 0x0013D227
		public static IChangeElementalBoxStateTarget CreateFromSetValue([Nullable(2)] IChangeElementalBoxStateTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x0013F03A File Offset: 0x0013D23A
		public IChangeElementalBoxStateTarget_SetValue ToSetValue()
		{
			return new IChangeElementalBoxStateTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06008641 RID: 34369 RVA: 0x0013F04D File Offset: 0x0013D24D
		// (set) Token: 0x06008642 RID: 34370 RVA: 0x0013F078 File Offset: 0x0013D278
		public virtual EChangeElementalBoxStateTargetType Type
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

		// Token: 0x040054B4 RID: 21684
		[Nullable(2)]
		protected IChangeElementalBoxStateTarget FbInstance;

		// Token: 0x040054B5 RID: 21685
		[Nullable(2)]
		protected IChangeElementalBoxStateTarget_SetValue PocoInterface;
	}
}
