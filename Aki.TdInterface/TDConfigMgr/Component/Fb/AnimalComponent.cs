using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C27 RID: 3111
	[NullableContext(2)]
	[Nullable(0)]
	public class AnimalComponent : IComponentBase
	{
		// Token: 0x06004741 RID: 18241 RVA: 0x000B3666 File Offset: 0x000B1866
		[NullableContext(1)]
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

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x000B3688 File Offset: 0x000B1888
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

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x000B36C0 File Offset: 0x000B18C0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x000B36D6 File Offset: 0x000B18D6
		public virtual bool IsStare
		{
			get
			{
				return this.Instance.IsStare;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x000B36E4 File Offset: 0x000B18E4
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

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x000B371C File Offset: 0x000B191C
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

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x000B3754 File Offset: 0x000B1954
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

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x000B378C File Offset: 0x000B198C
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

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x000B37C4 File Offset: 0x000B19C4
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

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600474A RID: 18250 RVA: 0x000B37FB File Offset: 0x000B19FB
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

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x000B3830 File Offset: 0x000B1A30
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IAnimalEmotionBubbleEntry> EmotionBubbleMap
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002872 RID: 10354
		private IAnimalComponent Instance;

		// Token: 0x04002873 RID: 10355
		private ICollectAnimalConfig _SpecialAnimalConfigCache;

		// Token: 0x04002874 RID: 10356
		private bool _SpecialAnimalConfigInited;

		// Token: 0x04002875 RID: 10357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAnimalEmotionBubbleEntry> _EmotionBubbleMapCache;

		// Token: 0x04002876 RID: 10358
		private bool _EmotionBubbleMapInited;
	}
}
