using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B09 RID: 6921
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyLevelPlayGroup : IHideGroupType
	{
		// Token: 0x06009432 RID: 37938 RVA: 0x0015759C File Offset: 0x0015579C
		private IHideSpecifyLevelPlayGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideSpecifyLevelPlayGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideSpecifyLevelPlayGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideSpecifyLevelPlayGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x001575D4 File Offset: 0x001557D4
		public static IHideSpecifyLevelPlayGroup Create([Nullable(2)] IHideSpecifyLevelPlayGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyLevelPlayGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x001575E7 File Offset: 0x001557E7
		public static IHideSpecifyLevelPlayGroup CreateFromSetValue([Nullable(2)] IHideSpecifyLevelPlayGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideSpecifyLevelPlayGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x001575FA File Offset: 0x001557FA
		public new IHideSpecifyLevelPlayGroup_SetValue ToSetValue()
		{
			return new IHideSpecifyLevelPlayGroup_SetValue
			{
				Type = this.Type,
				LevelPlays = this.LevelPlays
			};
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x06009436 RID: 37942 RVA: 0x00157619 File Offset: 0x00155819
		// (set) Token: 0x06009437 RID: 37943 RVA: 0x00157644 File Offset: 0x00155844
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x00157652 File Offset: 0x00155852
		// (set) Token: 0x06009439 RID: 37945 RVA: 0x00157679 File Offset: 0x00155879
		public virtual List<int> LevelPlays
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelPlays;
				}
				IHideSpecifyLevelPlayGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LevelPlays;
			}
			set
			{
				this.GetOrCreatePoco().LevelPlays = value;
			}
		}

		// Token: 0x04005AE8 RID: 23272
		[Nullable(2)]
		protected new IHideSpecifyLevelPlayGroup FbInstance;

		// Token: 0x04005AE9 RID: 23273
		[Nullable(2)]
		protected new IHideSpecifyLevelPlayGroup_SetValue PocoInterface;
	}
}
