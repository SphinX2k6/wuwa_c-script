using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D06 RID: 7430
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x06009F77 RID: 40823 RVA: 0x0016C454 File Offset: 0x0016A654
		private IPlayerNewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerNewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerNewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerNewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x0016C48C File Offset: 0x0016A68C
		public static IPlayerNewSplineMoveTarget Create([Nullable(2)] IPlayerNewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x0016C49F File Offset: 0x0016A69F
		public static IPlayerNewSplineMoveTarget CreateFromSetValue([Nullable(2)] IPlayerNewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerNewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x0016C4B2 File Offset: 0x0016A6B2
		public new IPlayerNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new IPlayerNewSplineMoveTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x06009F7B RID: 40827 RVA: 0x0016C4C5 File Offset: 0x0016A6C5
		// (set) Token: 0x06009F7C RID: 40828 RVA: 0x0016C4F0 File Offset: 0x0016A6F0
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400603E RID: 24638
		[Nullable(2)]
		protected new IPlayerNewSplineMoveTarget FbInstance;

		// Token: 0x0400603F RID: 24639
		[Nullable(2)]
		protected new IPlayerNewSplineMoveTarget_SetValue PocoInterface;
	}
}
