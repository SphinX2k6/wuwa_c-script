using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFA RID: 3322
	[NullableContext(2)]
	[Nullable(0)]
	public class AnimalComponent : IComponentBase
	{
		// Token: 0x06004BB0 RID: 19376 RVA: 0x000BD99E File Offset: 0x000BBB9E
		[NullableContext(0)]
		public static AnimalComponent Create(IAnimalComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AnimalComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x000BD9C0 File Offset: 0x000BBBC0
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

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06004BB2 RID: 19378 RVA: 0x000BD9F8 File Offset: 0x000BBBF8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x000BDA0E File Offset: 0x000BBC0E
		public virtual bool IsStare
		{
			get
			{
				return this.Instance.IsStare;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x000BDA1C File Offset: 0x000BBC1C
		public virtual int? AnimalAttackRange
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AnimalAttackRange);
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x000BDA54 File Offset: 0x000BBC54
		public virtual int? MoveRange
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MoveRange);
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x000BDA8C File Offset: 0x000BBC8C
		public virtual bool? UseRangeComponentAsMoveRange
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseRangeComponentAsMoveRange);
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x000BDAC4 File Offset: 0x000BBCC4
		public virtual bool? CanKillSelf
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanKillSelf);
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x000BDAFC File Offset: 0x000BBCFC
		public virtual bool? PlayDeathAnimOnDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PlayDeathAnimOnDestroy);
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x000BDB33 File Offset: 0x000BBD33
		public virtual ICollectAnimalConfig SpecialAnimalConfig
		{
			get
			{
				if (this._SpecialAnimalConfigInited)
				{
					return this._SpecialAnimalConfigCache;
				}
				this._SpecialAnimalConfigInited = true;
				this._SpecialAnimalConfigCache = ICollectAnimalConfig.Create(this.Instance.SpecialAnimalConfig);
				return this._SpecialAnimalConfigCache;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x000BDB68 File Offset: 0x000BBD68
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IAnimalEmotionBubbleEntry> EmotionBubbleMap
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._EmotionBubbleMapInited)
				{
					return this._EmotionBubbleMapCache;
				}
				this._EmotionBubbleMapInited = true;
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				int emotionBubbleMapLength = this.Instance.EmotionBubbleMapLength;
				this._EmotionBubbleMapCache = new List<IAnimalEmotionBubbleEntry>(emotionBubbleMapLength);
				for (int i = 0; i < emotionBubbleMapLength; i++)
				{
					this._EmotionBubbleMapCache.Add(IAnimalEmotionBubbleEntry.Create(this.Instance.EmotionBubbleMap(i)));
				}
				return this._EmotionBubbleMapCache;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06004BBB RID: 19387 RVA: 0x000BDBE4 File Offset: 0x000BBDE4
		public virtual List<EExtraMovementAbility> ExtraMovementAbilities
		{
			get
			{
				if (this._ExtraMovementAbilitiesInited)
				{
					return this._ExtraMovementAbilitiesCache;
				}
				this._ExtraMovementAbilitiesInited = true;
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				int extraMovementAbilitiesLength = this.Instance.ExtraMovementAbilitiesLength;
				this._ExtraMovementAbilitiesCache = new List<EExtraMovementAbility>(extraMovementAbilitiesLength);
				for (int i = 0; i < extraMovementAbilitiesLength; i++)
				{
					this._ExtraMovementAbilitiesCache.Add((EExtraMovementAbility)this.Instance.ExtraMovementAbilities(i));
				}
				return this._ExtraMovementAbilitiesCache;
			}
		}

		// Token: 0x04002AC5 RID: 10949
		private IAnimalComponent Instance;

		// Token: 0x04002AC6 RID: 10950
		private ICollectAnimalConfig _SpecialAnimalConfigCache;

		// Token: 0x04002AC7 RID: 10951
		private bool _SpecialAnimalConfigInited;

		// Token: 0x04002AC8 RID: 10952
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAnimalEmotionBubbleEntry> _EmotionBubbleMapCache;

		// Token: 0x04002AC9 RID: 10953
		private bool _EmotionBubbleMapInited;

		// Token: 0x04002ACA RID: 10954
		private List<EExtraMovementAbility> _ExtraMovementAbilitiesCache;

		// Token: 0x04002ACB RID: 10955
		private bool _ExtraMovementAbilitiesInited;
	}
}
