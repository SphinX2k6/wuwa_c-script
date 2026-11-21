using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D9 RID: 9177
	public class RotatorEntity : ActionParams
	{
		// Token: 0x0600C7EA RID: 51178 RVA: 0x001C96FC File Offset: 0x001C78FC
		private RotatorEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RotatorEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RotatorEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RotatorEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7EB RID: 51179 RVA: 0x001C9734 File Offset: 0x001C7934
		public static RotatorEntity Create([Nullable(2)] RotatorEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RotatorEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7EC RID: 51180 RVA: 0x001C9747 File Offset: 0x001C7947
		public static RotatorEntity CreateFromSetValue([Nullable(2)] RotatorEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RotatorEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7ED RID: 51181 RVA: 0x001C975A File Offset: 0x001C795A
		public RotatorEntity_SetValue ToSetValue()
		{
			return new RotatorEntity_SetValue
			{
				Entity = this.Entity
			};
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0600C7EE RID: 51182 RVA: 0x001C976D File Offset: 0x001C796D
		// (set) Token: 0x0600C7EF RID: 51183 RVA: 0x001C9794 File Offset: 0x001C7994
		public virtual ITargetEntityType Entity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entity;
				}
				RotatorEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entity;
			}
			set
			{
				this.GetOrCreatePoco().Entity = value;
			}
		}

		// Token: 0x040076B7 RID: 30391
		[Nullable(2)]
		protected new RotatorEntity FbInstance;

		// Token: 0x040076B8 RID: 30392
		[Nullable(2)]
		protected RotatorEntity_SetValue PocoInterface;
	}
}
