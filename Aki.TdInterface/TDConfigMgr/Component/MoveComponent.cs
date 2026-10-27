using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200083F RID: 2111
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveComponent : IComponentBase
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x00077B40 File Offset: 0x00075D40
		private MoveComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MoveComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MoveComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MoveComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00077B78 File Offset: 0x00075D78
		public static MoveComponent Create([Nullable(2)] MoveComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00077B8B File Offset: 0x00075D8B
		public static MoveComponent CreateFromSetValue([Nullable(2)] MoveComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MoveComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00077B9E File Offset: 0x00075D9E
		public new MoveComponent_SetValue ToSetValue()
		{
			return new MoveComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InitSpeed = this.InitSpeed
			};
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x00077BCC File Offset: 0x00075DCC
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00077C06 File Offset: 0x00075E06
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				MoveComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x00077C14 File Offset: 0x00075E14
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00077C3E File Offset: 0x00075E3E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00077C4C File Offset: 0x00075E4C
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00077C7B File Offset: 0x00075E7B
		public virtual float InitSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InitSpeed;
			}
			set
			{
				this.GetOrCreatePoco().InitSpeed = value;
			}
		}

		// Token: 0x04001E93 RID: 7827
		[Nullable(2)]
		protected new MoveComponent FbInstance;

		// Token: 0x04001E94 RID: 7828
		[Nullable(2)]
		protected new MoveComponent_SetValue PocoInterface;
	}
}
