using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078F RID: 1935
	public class ISpawnMonsterPreDependOnPreceding : ISpawnMonsterPreConditonType
	{
		// Token: 0x06002958 RID: 10584 RVA: 0x0006D764 File Offset: 0x0006B964
		private ISpawnMonsterPreDependOnPreceding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterPreDependOnPreceding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterPreDependOnPreceding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterPreDependOnPreceding_SetValue());
			}
			return result;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x0006D79C File Offset: 0x0006B99C
		public static ISpawnMonsterPreDependOnPreceding Create([Nullable(2)] ISpawnMonsterPreDependOnPreceding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPreDependOnPreceding
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0006D7AF File Offset: 0x0006B9AF
		public static ISpawnMonsterPreDependOnPreceding CreateFromSetValue([Nullable(2)] ISpawnMonsterPreDependOnPreceding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterPreDependOnPreceding
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0006D7C2 File Offset: 0x0006B9C2
		public new ISpawnMonsterPreDependOnPreceding_SetValue ToSetValue()
		{
			return new ISpawnMonsterPreDependOnPreceding_SetValue
			{
				Type = this.Type,
				Ids = this.Ids
			};
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x0006D7E1 File Offset: 0x0006B9E1
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x0006D80C File Offset: 0x0006BA0C
		public override ESpawnMonsterPreCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterPreCondition.DependOnPreceding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x0006D81A File Offset: 0x0006BA1A
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x0006D841 File Offset: 0x0006BA41
		public virtual List<int> Ids
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Ids;
				}
				ISpawnMonsterPreDependOnPreceding_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Ids;
			}
			set
			{
				this.GetOrCreatePoco().Ids = value;
			}
		}

		// Token: 0x04001BF9 RID: 7161
		[Nullable(2)]
		protected new ISpawnMonsterPreDependOnPreceding FbInstance;

		// Token: 0x04001BFA RID: 7162
		[Nullable(2)]
		protected new ISpawnMonsterPreDependOnPreceding_SetValue PocoInterface;
	}
}
