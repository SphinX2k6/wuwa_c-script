using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB8 RID: 7352
	public class IHideSpecifyLevelPlayGroup : IHideGroupType
	{
		// Token: 0x06009C1C RID: 39964 RVA: 0x00168278 File Offset: 0x00166478
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

		// Token: 0x06009C1D RID: 39965 RVA: 0x001682B0 File Offset: 0x001664B0
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

		// Token: 0x06009C1E RID: 39966 RVA: 0x001682C3 File Offset: 0x001664C3
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

		// Token: 0x06009C1F RID: 39967 RVA: 0x001682D6 File Offset: 0x001664D6
		public new IHideSpecifyLevelPlayGroup_SetValue ToSetValue()
		{
			return new IHideSpecifyLevelPlayGroup_SetValue
			{
				Type = this.Type,
				LevelPlays = this.LevelPlays
			};
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06009C20 RID: 39968 RVA: 0x001682F5 File Offset: 0x001664F5
		// (set) Token: 0x06009C21 RID: 39969 RVA: 0x00168320 File Offset: 0x00166520
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

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06009C22 RID: 39970 RVA: 0x0016832E File Offset: 0x0016652E
		// (set) Token: 0x06009C23 RID: 39971 RVA: 0x00168355 File Offset: 0x00166555
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

		// Token: 0x04005F86 RID: 24454
		[Nullable(2)]
		protected new IHideSpecifyLevelPlayGroup FbInstance;

		// Token: 0x04005F87 RID: 24455
		[Nullable(2)]
		protected new IHideSpecifyLevelPlayGroup_SetValue PocoInterface;
	}
}
