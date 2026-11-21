using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001143 RID: 4419
	public class IMonsterMergedHpBarSettings
	{
		// Token: 0x060061D0 RID: 25040 RVA: 0x000EBB9C File Offset: 0x000E9D9C
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

		// Token: 0x060061D1 RID: 25041 RVA: 0x000EBBD4 File Offset: 0x000E9DD4
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

		// Token: 0x060061D2 RID: 25042 RVA: 0x000EBBE7 File Offset: 0x000E9DE7
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

		// Token: 0x060061D3 RID: 25043 RVA: 0x000EBBFA File Offset: 0x000E9DFA
		public IMonsterMergedHpBarSettings_SetValue ToSetValue()
		{
			return new IMonsterMergedHpBarSettings_SetValue
			{
				DisplayBuffIds = this.DisplayBuffIds
			};
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x000EBC0D File Offset: 0x000E9E0D
		// (set) Token: 0x060061D5 RID: 25045 RVA: 0x000EBC34 File Offset: 0x000E9E34
		[Nullable(2)]
		public virtual List<long> DisplayBuffIds
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DisplayBuffIds = value;
			}
		}

		// Token: 0x04003A94 RID: 14996
		[Nullable(2)]
		protected IMonsterMergedHpBarSettings FbInstance;

		// Token: 0x04003A95 RID: 14997
		[Nullable(2)]
		protected IMonsterMergedHpBarSettings_SetValue PocoInterface;
	}
}
