using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001017 RID: 4119
	[NullableContext(2)]
	[Nullable(0)]
	public class IMonsterMergedHpBarSettings
	{
		// Token: 0x06005BEE RID: 23534 RVA: 0x000DEEA4 File Offset: 0x000DD0A4
		[NullableContext(1)]
		private IMonsterMergedHpBarSettings_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterMergedHpBarSettings 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterMergedHpBarSettings_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterMergedHpBarSettings_SetValue());
			}
			return result;
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x000DEEDC File Offset: 0x000DD0DC
		[NullableContext(1)]
		public static IMonsterMergedHpBarSettings Create([Nullable(2)] IMonsterMergedHpBarSettings instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterMergedHpBarSettings
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x000DEEEF File Offset: 0x000DD0EF
		[NullableContext(1)]
		public static IMonsterMergedHpBarSettings CreateFromSetValue([Nullable(2)] IMonsterMergedHpBarSettings_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterMergedHpBarSettings
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x000DEF02 File Offset: 0x000DD102
		[NullableContext(1)]
		public IMonsterMergedHpBarSettings_SetValue ToSetValue()
		{
			return new IMonsterMergedHpBarSettings_SetValue
			{
				DisplayBuffIds = this.DisplayBuffIds
			};
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06005BF2 RID: 23538 RVA: 0x000DEF15 File Offset: 0x000DD115
		// (set) Token: 0x06005BF3 RID: 23539 RVA: 0x000DEF3C File Offset: 0x000DD13C
		public virtual List<long> DisplayBuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayBuffIds;
				}
				IMonsterMergedHpBarSettings_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayBuffIds;
			}
			set
			{
				this.GetOrCreatePoco().DisplayBuffIds = value;
			}
		}

		// Token: 0x04003759 RID: 14169
		protected IMonsterMergedHpBarSettings FbInstance;

		// Token: 0x0400375A RID: 14170
		protected IMonsterMergedHpBarSettings_SetValue PocoInterface;
	}
}
