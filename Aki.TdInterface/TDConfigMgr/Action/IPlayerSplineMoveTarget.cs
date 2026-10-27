using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D0E RID: 7438
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerSplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x06009F99 RID: 40857 RVA: 0x0016C7C8 File Offset: 0x0016A9C8
		private IPlayerSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x0016C800 File Offset: 0x0016AA00
		public static IPlayerSplineMoveTarget Create([Nullable(2)] IPlayerSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x0016C813 File Offset: 0x0016AA13
		public static IPlayerSplineMoveTarget CreateFromSetValue([Nullable(2)] IPlayerSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x0016C826 File Offset: 0x0016AA26
		public new IPlayerSplineMoveTarget_SetValue ToSetValue()
		{
			return new IPlayerSplineMoveTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x06009F9D RID: 40861 RVA: 0x0016C839 File Offset: 0x0016AA39
		// (set) Token: 0x06009F9E RID: 40862 RVA: 0x0016C864 File Offset: 0x0016AA64
		public override ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400604D RID: 24653
		[Nullable(2)]
		protected new IPlayerSplineMoveTarget FbInstance;

		// Token: 0x0400604E RID: 24654
		[Nullable(2)]
		protected new IPlayerSplineMoveTarget_SetValue PocoInterface;
	}
}
