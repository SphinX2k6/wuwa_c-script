using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB4 RID: 3764
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritCollectComponent : IComponentBase
	{
		// Token: 0x060054DE RID: 21726 RVA: 0x000D0D7C File Offset: 0x000CEF7C
		[NullableContext(0)]
		public static SunSpiritCollectComponent Create(ISunSpiritCollectComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritCollectComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x000D0D9C File Offset: 0x000CEF9C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x000D0DD4 File Offset: 0x000CEFD4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x000D0DEA File Offset: 0x000CEFEA
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x000D0DF8 File Offset: 0x000CEFF8
		public virtual float? SunSpiritScale
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.SunSpiritScale);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x000D0E2E File Offset: 0x000CF02E
		public virtual ISunSpiritPlayerBattleConfig PlayerBattleConfig
		{
			get
			{
				if (this._PlayerBattleConfigInited)
				{
					return this._PlayerBattleConfigCache;
				}
				this._PlayerBattleConfigInited = true;
				this._PlayerBattleConfigCache = ISunSpiritPlayerBattleConfig.Create(this.Instance.PlayerBattleConfig);
				return this._PlayerBattleConfigCache;
			}
		}

		// Token: 0x04003087 RID: 12423
		private ISunSpiritCollectComponent Instance;

		// Token: 0x04003088 RID: 12424
		private ISunSpiritPlayerBattleConfig _PlayerBattleConfigCache;

		// Token: 0x04003089 RID: 12425
		private bool _PlayerBattleConfigInited;
	}
}
