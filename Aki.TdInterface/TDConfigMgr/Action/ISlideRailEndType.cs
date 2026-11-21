using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020BC RID: 8380
	public class ISlideRailEndType
	{
		// Token: 0x0600B1EE RID: 45550 RVA: 0x0018FD9C File Offset: 0x0018DF9C
		private ISlideRailEndType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideRailEndType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideRailEndType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideRailEndType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x0018FDD4 File Offset: 0x0018DFD4
		public static ISlideRailEndType Create([Nullable(2)] ISlideRailEndType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailEndType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x0018FDE7 File Offset: 0x0018DFE7
		public static ISlideRailEndType CreateFromSetValue([Nullable(2)] ISlideRailEndType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideRailEndType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x0018FDFA File Offset: 0x0018DFFA
		public ISlideRailEndType_SetValue ToSetValue()
		{
			return new ISlideRailEndType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600B1F2 RID: 45554 RVA: 0x0018FE0D File Offset: 0x0018E00D
		// (set) Token: 0x0600B1F3 RID: 45555 RVA: 0x0018FE38 File Offset: 0x0018E038
		public virtual ESlideRailEndType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlideRailEndType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040069AB RID: 27051
		[Nullable(2)]
		protected ISlideRailEndType FbInstance;

		// Token: 0x040069AC RID: 27052
		[Nullable(2)]
		protected ISlideRailEndType_SetValue PocoInterface;
	}
}
