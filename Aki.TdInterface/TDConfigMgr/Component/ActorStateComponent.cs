using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000011 RID: 17
	public class ActorStateComponent : IComponentBase
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00014A4C File Offset: 0x00012C4C
		private ActorStateComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ActorStateComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ActorStateComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ActorStateComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00014A84 File Offset: 0x00012C84
		public static ActorStateComponent Create([Nullable(2)] ActorStateComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActorStateComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00014A97 File Offset: 0x00012C97
		public static ActorStateComponent CreateFromSetValue([Nullable(2)] ActorStateComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ActorStateComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00014AAA File Offset: 0x00012CAA
		public new ActorStateComponent_SetValue ToSetValue()
		{
			return new ActorStateComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InitState = this.InitState
			};
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00014AD8 File Offset: 0x00012CD8
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00014B12 File Offset: 0x00012D12
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ActorStateComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00014B20 File Offset: 0x00012D20
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00014B4A File Offset: 0x00012D4A
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00014B58 File Offset: 0x00012D58
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00014B83 File Offset: 0x00012D83
		public virtual string InitState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.InitState;
			}
			set
			{
				this.GetOrCreatePoco().InitState = value;
			}
		}

		// Token: 0x0400002F RID: 47
		[Nullable(2)]
		protected new ActorStateComponent FbInstance;

		// Token: 0x04000030 RID: 48
		[Nullable(2)]
		protected new ActorStateComponent_SetValue PocoInterface;
	}
}
