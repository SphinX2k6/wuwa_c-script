using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D2D RID: 7469
	public class ILiftMoveType
	{
		// Token: 0x06009EA7 RID: 40615 RVA: 0x0016CDB8 File Offset: 0x0016AFB8
		private ILiftMoveType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveType_SetValue());
			}
			return result;
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
		public static ILiftMoveType Create([Nullable(2)] ILiftMoveType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x0016CE03 File Offset: 0x0016B003
		public static ILiftMoveType CreateFromSetValue([Nullable(2)] ILiftMoveType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x0016CE16 File Offset: 0x0016B016
		public ILiftMoveType_SetValue ToSetValue()
		{
			return new ILiftMoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x06009EAB RID: 40619 RVA: 0x0016CE29 File Offset: 0x0016B029
		// (set) Token: 0x06009EAC RID: 40620 RVA: 0x0016CE54 File Offset: 0x0016B054
		public virtual ELiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiftMoveType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060BD RID: 24765
		[Nullable(2)]
		protected ILiftMoveType FbInstance;

		// Token: 0x040060BE RID: 24766
		[Nullable(2)]
		protected ILiftMoveType_SetValue PocoInterface;
	}
}
