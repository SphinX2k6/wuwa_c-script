using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B07 RID: 6919
	public class IDelayRemoveAfterSkillFinish : IDelayRemoveType
	{
		// Token: 0x060092F1 RID: 37617 RVA: 0x00157F70 File Offset: 0x00156170
		private IDelayRemoveAfterSkillFinish_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDelayRemoveAfterSkillFinish 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDelayRemoveAfterSkillFinish_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDelayRemoveAfterSkillFinish_SetValue());
			}
			return result;
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x00157FA8 File Offset: 0x001561A8
		public static IDelayRemoveAfterSkillFinish Create([Nullable(2)] IDelayRemoveAfterSkillFinish instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDelayRemoveAfterSkillFinish
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00157FBB File Offset: 0x001561BB
		public static IDelayRemoveAfterSkillFinish CreateFromSetValue([Nullable(2)] IDelayRemoveAfterSkillFinish_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDelayRemoveAfterSkillFinish
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x00157FCE File Offset: 0x001561CE
		public new IDelayRemoveAfterSkillFinish_SetValue ToSetValue()
		{
			return new IDelayRemoveAfterSkillFinish_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x060092F5 RID: 37621 RVA: 0x00157FE1 File Offset: 0x001561E1
		// (set) Token: 0x060092F6 RID: 37622 RVA: 0x0015800C File Offset: 0x0015620C
		public override EDelayRemoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDelayRemoveType.DelayRemoveAfterSkillFinish;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B6F RID: 23407
		[Nullable(2)]
		protected new IDelayRemoveAfterSkillFinish FbInstance;

		// Token: 0x04005B70 RID: 23408
		[Nullable(2)]
		protected new IDelayRemoveAfterSkillFinish_SetValue PocoInterface;
	}
}
