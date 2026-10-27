using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	public class AnimalComponent : IComponentBase
	{
		// Token: 0x060000BA RID: 186 RVA: 0x000153A8 File Offset: 0x000135A8
		private AnimalComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AnimalComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AnimalComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AnimalComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000153E0 File Offset: 0x000135E0
		public static AnimalComponent Create([Nullable(2)] AnimalComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AnimalComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000153F3 File Offset: 0x000135F3
		public static AnimalComponent CreateFromSetValue([Nullable(2)] AnimalComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AnimalComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00015408 File Offset: 0x00013608
		public new AnimalComponent_SetValue ToSetValue()
		{
			return new AnimalComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				IsStare = this.IsStare,
				AnimalAttackRange = this.AnimalAttackRange,
				MoveRange = this.MoveRange,
				UseRangeComponentAsMoveRange = this.UseRangeComponentAsMoveRange,
				CanKillSelf = this.CanKillSelf,
				PlayDeathAnimOnDestroy = this.PlayDeathAnimOnDestroy,
				SpecialAnimalConfig = this.SpecialAnimalConfig,
				EmotionBubbleMap = this.EmotionBubbleMap
			};
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00015494 File Offset: 0x00013694
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000154CE File Offset: 0x000136CE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000154DC File Offset: 0x000136DC
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00015506 File Offset: 0x00013706
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00015514 File Offset: 0x00013714
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0001553F File Offset: 0x0001373F
		public virtual bool IsStare
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsStare;
				}
				return this.PocoInterface != null && this.PocoInterface.IsStare;
			}
			set
			{
				this.GetOrCreatePoco().IsStare = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00015550 File Offset: 0x00013750
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0001558A File Offset: 0x0001378A
		public virtual int? AnimalAttackRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimalAttackRange;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AnimalAttackRange;
			}
			set
			{
				this.GetOrCreatePoco().AnimalAttackRange = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00015598 File Offset: 0x00013798
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000155D2 File Offset: 0x000137D2
		public virtual int? MoveRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveRange;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveRange;
			}
			set
			{
				this.GetOrCreatePoco().MoveRange = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000155E0 File Offset: 0x000137E0
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0001561A File Offset: 0x0001381A
		public virtual bool? UseRangeComponentAsMoveRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseRangeComponentAsMoveRange;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseRangeComponentAsMoveRange;
			}
			set
			{
				this.GetOrCreatePoco().UseRangeComponentAsMoveRange = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00015628 File Offset: 0x00013828
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00015662 File Offset: 0x00013862
		public virtual bool? CanKillSelf
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanKillSelf;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanKillSelf;
			}
			set
			{
				this.GetOrCreatePoco().CanKillSelf = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00015670 File Offset: 0x00013870
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000156AA File Offset: 0x000138AA
		public virtual bool? PlayDeathAnimOnDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayDeathAnimOnDestroy;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayDeathAnimOnDestroy;
			}
			set
			{
				this.GetOrCreatePoco().PlayDeathAnimOnDestroy = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000156B8 File Offset: 0x000138B8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00015719 File Offset: 0x00013919
		[Nullable(2)]
		public virtual ICollectAnimalConfig SpecialAnimalConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._SpecialAnimalConfigInited)
				{
					return this._SpecialAnimalConfigCache;
				}
				this._SpecialAnimalConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SpecialAnimalConfigCache = ICollectAnimalConfig.Create(this.FbInstance.SpecialAnimalConfig);
				}
				else
				{
					AnimalComponent_SetValue pocoInterface = this.PocoInterface;
					this._SpecialAnimalConfigCache = ((pocoInterface != null) ? pocoInterface.SpecialAnimalConfig : null);
				}
				return this._SpecialAnimalConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SpecialAnimalConfig = value;
				this._SpecialAnimalConfigInited = false;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00015730 File Offset: 0x00013930
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000157C3 File Offset: 0x000139C3
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
				if (this.FbInstance != null)
				{
					List<IAnimalEmotionBubbleEntry> emotionBubbleMap = this.FbInstance.EmotionBubbleMap;
					if (emotionBubbleMap != null)
					{
						this._EmotionBubbleMapCache = new List<IAnimalEmotionBubbleEntry>(emotionBubbleMap.Count);
						for (int i = 0; i < emotionBubbleMap.Count; i++)
						{
							this._EmotionBubbleMapCache.Add(IAnimalEmotionBubbleEntry.Create(emotionBubbleMap[i]));
						}
					}
				}
				else
				{
					AnimalComponent_SetValue pocoInterface = this.PocoInterface;
					this._EmotionBubbleMapCache = ((pocoInterface != null) ? pocoInterface.EmotionBubbleMap : null);
				}
				return this._EmotionBubbleMapCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().EmotionBubbleMap = value;
				this._EmotionBubbleMapInited = false;
			}
		}

		// Token: 0x04000075 RID: 117
		[Nullable(2)]
		protected new AnimalComponent FbInstance;

		// Token: 0x04000076 RID: 118
		[Nullable(2)]
		protected new AnimalComponent_SetValue PocoInterface;

		// Token: 0x04000077 RID: 119
		private ICollectAnimalConfig _SpecialAnimalConfigCache;

		// Token: 0x04000078 RID: 120
		private bool _SpecialAnimalConfigInited;

		// Token: 0x04000079 RID: 121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAnimalEmotionBubbleEntry> _EmotionBubbleMapCache;

		// Token: 0x0400007A RID: 122
		private bool _EmotionBubbleMapInited;
	}
}
