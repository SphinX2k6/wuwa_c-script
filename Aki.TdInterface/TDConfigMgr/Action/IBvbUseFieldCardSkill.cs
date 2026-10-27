using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001836 RID: 6198
	[NullableContext(1)]
	[Nullable(0)]
	public class IBvbUseFieldCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x06008501 RID: 34049 RVA: 0x0013C814 File Offset: 0x0013AA14
		private IBvbUseFieldCardSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbUseFieldCardSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbUseFieldCardSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbUseFieldCardSkill_SetValue());
			}
			return result;
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x0013C84C File Offset: 0x0013AA4C
		public static IBvbUseFieldCardSkill Create([Nullable(2)] IBvbUseFieldCardSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbUseFieldCardSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x0013C85F File Offset: 0x0013AA5F
		public static IBvbUseFieldCardSkill CreateFromSetValue([Nullable(2)] IBvbUseFieldCardSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbUseFieldCardSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x0013C872 File Offset: 0x0013AA72
		public new IBvbUseFieldCardSkill_SetValue ToSetValue()
		{
			return new IBvbUseFieldCardSkill_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x0013C885 File Offset: 0x0013AA85
		// (set) Token: 0x06008506 RID: 34054 RVA: 0x0013C8B0 File Offset: 0x0013AAB0
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005411 RID: 21521
		[Nullable(2)]
		protected new IBvbUseFieldCardSkill FbInstance;

		// Token: 0x04005412 RID: 21522
		[Nullable(2)]
		protected new IBvbUseFieldCardSkill_SetValue PocoInterface;
	}
}
