using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200197C RID: 6524
	[NullableContext(1)]
	[Nullable(0)]
	public class IDelayRemoveAfterSkillFinish : IDelayRemoveType
	{
		// Token: 0x06008BB9 RID: 35769 RVA: 0x001484E0 File Offset: 0x001466E0
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

		// Token: 0x06008BBA RID: 35770 RVA: 0x00148518 File Offset: 0x00146718
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

		// Token: 0x06008BBB RID: 35771 RVA: 0x0014852B File Offset: 0x0014672B
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

		// Token: 0x06008BBC RID: 35772 RVA: 0x0014853E File Offset: 0x0014673E
		public new IDelayRemoveAfterSkillFinish_SetValue ToSetValue()
		{
			return new IDelayRemoveAfterSkillFinish_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x06008BBD RID: 35773 RVA: 0x00148551 File Offset: 0x00146751
		// (set) Token: 0x06008BBE RID: 35774 RVA: 0x0014857C File Offset: 0x0014677C
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

		// Token: 0x0400571A RID: 22298
		[Nullable(2)]
		protected new IDelayRemoveAfterSkillFinish FbInstance;

		// Token: 0x0400571B RID: 22299
		[Nullable(2)]
		protected new IDelayRemoveAfterSkillFinish_SetValue PocoInterface;
	}
}
