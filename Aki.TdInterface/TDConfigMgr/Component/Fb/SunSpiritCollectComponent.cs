using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB8 RID: 3512
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritCollectComponent : IComponentBase
	{
		// Token: 0x06004FB9 RID: 20409 RVA: 0x000C552C File Offset: 0x000C372C
		[NullableContext(1)]
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

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x000C554C File Offset: 0x000C374C
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

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x000C5584 File Offset: 0x000C3784
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x000C559A File Offset: 0x000C379A
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x000C55A8 File Offset: 0x000C37A8
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

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x000C55DE File Offset: 0x000C37DE
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

		// Token: 0x04002DC1 RID: 11713
		private ISunSpiritCollectComponent Instance;

		// Token: 0x04002DC2 RID: 11714
		private ISunSpiritPlayerBattleConfig _PlayerBattleConfigCache;

		// Token: 0x04002DC3 RID: 11715
		private bool _PlayerBattleConfigInited;
	}
}
