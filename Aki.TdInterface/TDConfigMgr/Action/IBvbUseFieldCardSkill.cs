using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C1 RID: 6593
	public class IBvbUseFieldCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x06008C27 RID: 35879 RVA: 0x0014C008 File Offset: 0x0014A208
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

		// Token: 0x06008C28 RID: 35880 RVA: 0x0014C040 File Offset: 0x0014A240
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

		// Token: 0x06008C29 RID: 35881 RVA: 0x0014C053 File Offset: 0x0014A253
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

		// Token: 0x06008C2A RID: 35882 RVA: 0x0014C066 File Offset: 0x0014A266
		public new IBvbUseFieldCardSkill_SetValue ToSetValue()
		{
			return new IBvbUseFieldCardSkill_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06008C2B RID: 35883 RVA: 0x0014C079 File Offset: 0x0014A279
		// (set) Token: 0x06008C2C RID: 35884 RVA: 0x0014C0A4 File Offset: 0x0014A2A4
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

		// Token: 0x0400585D RID: 22621
		[Nullable(2)]
		protected new IBvbUseFieldCardSkill FbInstance;

		// Token: 0x0400585E RID: 22622
		[Nullable(2)]
		protected new IBvbUseFieldCardSkill_SetValue PocoInterface;
	}
}
