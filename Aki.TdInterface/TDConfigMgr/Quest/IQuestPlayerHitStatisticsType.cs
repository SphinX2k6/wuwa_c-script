using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001091 RID: 4241
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestPlayerHitStatisticsType
	{
		// Token: 0x06005FA6 RID: 24486 RVA: 0x000E7960 File Offset: 0x000E5B60
		private IQuestPlayerHitStatisticsType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestPlayerHitStatisticsType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestPlayerHitStatisticsType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestPlayerHitStatisticsType_SetValue());
			}
			return result;
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x000E7998 File Offset: 0x000E5B98
		public static IQuestPlayerHitStatisticsType Create([Nullable(2)] IQuestPlayerHitStatisticsType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerHitStatisticsType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x000E79AB File Offset: 0x000E5BAB
		public static IQuestPlayerHitStatisticsType CreateFromSetValue([Nullable(2)] IQuestPlayerHitStatisticsType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestPlayerHitStatisticsType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x000E79BE File Offset: 0x000E5BBE
		public IQuestPlayerHitStatisticsType_SetValue ToSetValue()
		{
			return new IQuestPlayerHitStatisticsType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x000E79D1 File Offset: 0x000E5BD1
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x000E79FC File Offset: 0x000E5BFC
		public virtual EPlayerHitStatisticsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerHitStatisticsType.HitCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040039B0 RID: 14768
		[Nullable(2)]
		protected IQuestPlayerHitStatisticsType FbInstance;

		// Token: 0x040039B1 RID: 14769
		[Nullable(2)]
		protected IQuestPlayerHitStatisticsType_SetValue PocoInterface;
	}
}
