using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000021 RID: 33
	[NullableContext(2)]
	[Nullable(0)]
	public class AnimalComponent : IComponentBase
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[NullableContext(0)]
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

		// Token: 0x060000BD RID: 189 RVA: 0x00015D10 File Offset: 0x00013F10
		[NullableContext(0)]
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

		// Token: 0x060000BE RID: 190 RVA: 0x00015D23 File Offset: 0x00013F23
		[NullableContext(0)]
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

		// Token: 0x060000BF RID: 191 RVA: 0x00015D38 File Offset: 0x00013F38
		[NullableContext(0)]
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
				EmotionBubbleMap = this.EmotionBubbleMap,
				ExtraMovementAbilities = this.ExtraMovementAbilities
			};
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00015DD0 File Offset: 0x00013FD0
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00015E0A File Offset: 0x0001400A
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00015E18 File Offset: 0x00014018
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00015E42 File Offset: 0x00014042
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00015E50 File Offset: 0x00014050
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00015E7B File Offset: 0x0001407B
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00015E8C File Offset: 0x0001408C
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00015EC6 File Offset: 0x000140C6
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00015ED4 File Offset: 0x000140D4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00015F0E File Offset: 0x0001410E
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00015F1C File Offset: 0x0001411C
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00015F56 File Offset: 0x00014156
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00015F64 File Offset: 0x00014164
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00015F9E File Offset: 0x0001419E
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00015FAC File Offset: 0x000141AC
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00015FE6 File Offset: 0x000141E6
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00015FF4 File Offset: 0x000141F4
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00016055 File Offset: 0x00014255
		public virtual ICollectAnimalConfig SpecialAnimalConfig
		{
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
			set
			{
				this.GetOrCreatePoco().SpecialAnimalConfig = value;
				this._SpecialAnimalConfigInited = false;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0001606C File Offset: 0x0001426C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000160FF File Offset: 0x000142FF
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().EmotionBubbleMap = value;
				this._EmotionBubbleMapInited = false;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00016114 File Offset: 0x00014314
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0001613B File Offset: 0x0001433B
		public virtual List<EExtraMovementAbility> ExtraMovementAbilities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExtraMovementAbilities;
				}
				AnimalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExtraMovementAbilities;
			}
			set
			{
				this.GetOrCreatePoco().ExtraMovementAbilities = value;
			}
		}

		// Token: 0x04000079 RID: 121
		protected new AnimalComponent FbInstance;

		// Token: 0x0400007A RID: 122
		protected new AnimalComponent_SetValue PocoInterface;

		// Token: 0x0400007B RID: 123
		[Nullable(0)]
		private ICollectAnimalConfig _SpecialAnimalConfigCache;

		// Token: 0x0400007C RID: 124
		private bool _SpecialAnimalConfigInited;

		// Token: 0x0400007D RID: 125
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAnimalEmotionBubbleEntry> _EmotionBubbleMapCache;

		// Token: 0x0400007E RID: 126
		private bool _EmotionBubbleMapInited;
	}
}
