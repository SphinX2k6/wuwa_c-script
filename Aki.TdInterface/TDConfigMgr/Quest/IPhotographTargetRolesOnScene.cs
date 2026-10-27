using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200104B RID: 4171
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographTargetRolesOnScene : IPhotographTarget
	{
		// Token: 0x06005D72 RID: 23922 RVA: 0x000E23E8 File Offset: 0x000E05E8
		private IPhotographTargetRolesOnScene_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographTargetRolesOnScene 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographTargetRolesOnScene_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographTargetRolesOnScene_SetValue());
			}
			return result;
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x000E2420 File Offset: 0x000E0620
		public static IPhotographTargetRolesOnScene Create([Nullable(2)] IPhotographTargetRolesOnScene instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographTargetRolesOnScene
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x000E2433 File Offset: 0x000E0633
		public static IPhotographTargetRolesOnScene CreateFromSetValue([Nullable(2)] IPhotographTargetRolesOnScene_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographTargetRolesOnScene
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x000E2446 File Offset: 0x000E0646
		public new IPhotographTargetRolesOnScene_SetValue ToSetValue()
		{
			return new IPhotographTargetRolesOnScene_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06005D76 RID: 23926 RVA: 0x000E2459 File Offset: 0x000E0659
		// (set) Token: 0x06005D77 RID: 23927 RVA: 0x000E2484 File Offset: 0x000E0684
		public override EPhotographTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhotographTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003845 RID: 14405
		[Nullable(2)]
		protected new IPhotographTargetRolesOnScene FbInstance;

		// Token: 0x04003846 RID: 14406
		[Nullable(2)]
		protected new IPhotographTargetRolesOnScene_SetValue PocoInterface;
	}
}
