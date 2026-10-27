using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002006 RID: 8198
	[NullableContext(2)]
	[Nullable(0)]
	public class ITuningStand : IUiGame
	{
		// Token: 0x0600B448 RID: 46152 RVA: 0x001A343C File Offset: 0x001A163C
		[NullableContext(1)]
		private ITuningStand_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITuningStand 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITuningStand_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITuningStand_SetValue());
			}
			return result;
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x001A3474 File Offset: 0x001A1674
		[NullableContext(1)]
		public static ITuningStand Create([Nullable(2)] ITuningStand instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStand
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x001A3487 File Offset: 0x001A1687
		[NullableContext(1)]
		public static ITuningStand CreateFromSetValue([Nullable(2)] ITuningStand_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITuningStand
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x001A349C File Offset: 0x001A169C
		[NullableContext(1)]
		public new ITuningStand_SetValue ToSetValue()
		{
			return new ITuningStand_SetValue
			{
				Type = this.Type,
				VisualType = this.VisualType,
				BubbleConfig = this.BubbleConfig,
				GuidancePath = this.GuidancePath,
				MusicScorePath = this.MusicScorePath,
				NoteSequence = this.NoteSequence,
				CompleteMusic = this.CompleteMusic,
				BoardConfig = this.BoardConfig
			};
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600B44C RID: 46156 RVA: 0x001A350E File Offset: 0x001A170E
		// (set) Token: 0x0600B44D RID: 46157 RVA: 0x001A3539 File Offset: 0x001A1739
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600B44E RID: 46158 RVA: 0x001A3547 File Offset: 0x001A1747
		// (set) Token: 0x0600B44F RID: 46159 RVA: 0x001A3572 File Offset: 0x001A1772
		public virtual ETuningStandVisualType VisualType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualType;
				}
				if (this.PocoInterface == null)
				{
					return ETuningStandVisualType.Tuning;
				}
				return this.PocoInterface.VisualType;
			}
			set
			{
				this.GetOrCreatePoco().VisualType = value;
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600B450 RID: 46160 RVA: 0x001A3580 File Offset: 0x001A1780
		// (set) Token: 0x0600B451 RID: 46161 RVA: 0x001A3613 File Offset: 0x001A1813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITuningStandBubbleConfig> BubbleConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._BubbleConfigInited)
				{
					return this._BubbleConfigCache;
				}
				this._BubbleConfigInited = true;
				if (this.FbInstance != null)
				{
					List<ITuningStandBubbleConfig> bubbleConfig = this.FbInstance.BubbleConfig;
					if (bubbleConfig != null)
					{
						this._BubbleConfigCache = new List<ITuningStandBubbleConfig>(bubbleConfig.Count);
						for (int i = 0; i < bubbleConfig.Count; i++)
						{
							this._BubbleConfigCache.Add(ITuningStandBubbleConfig.Create(bubbleConfig[i]));
						}
					}
				}
				else
				{
					ITuningStand_SetValue pocoInterface = this.PocoInterface;
					this._BubbleConfigCache = ((pocoInterface != null) ? pocoInterface.BubbleConfig : null);
				}
				return this._BubbleConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().BubbleConfig = value;
				this._BubbleConfigInited = false;
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x001A3628 File Offset: 0x001A1828
		// (set) Token: 0x0600B453 RID: 46163 RVA: 0x001A364F File Offset: 0x001A184F
		public virtual string GuidancePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GuidancePath;
				}
				ITuningStand_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GuidancePath;
			}
			set
			{
				this.GetOrCreatePoco().GuidancePath = value;
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x001A365D File Offset: 0x001A185D
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x001A3684 File Offset: 0x001A1884
		public virtual string MusicScorePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MusicScorePath;
				}
				ITuningStand_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MusicScorePath;
			}
			set
			{
				this.GetOrCreatePoco().MusicScorePath = value;
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x001A3692 File Offset: 0x001A1892
		// (set) Token: 0x0600B457 RID: 46167 RVA: 0x001A36B9 File Offset: 0x001A18B9
		public virtual string NoteSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NoteSequence;
				}
				ITuningStand_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NoteSequence;
			}
			set
			{
				this.GetOrCreatePoco().NoteSequence = value;
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x001A36C7 File Offset: 0x001A18C7
		// (set) Token: 0x0600B459 RID: 46169 RVA: 0x001A36EE File Offset: 0x001A18EE
		public virtual string CompleteMusic
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteMusic;
				}
				ITuningStand_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CompleteMusic;
			}
			set
			{
				this.GetOrCreatePoco().CompleteMusic = value;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600B45A RID: 46170 RVA: 0x001A36FC File Offset: 0x001A18FC
		// (set) Token: 0x0600B45B RID: 46171 RVA: 0x001A375D File Offset: 0x001A195D
		[Nullable(1)]
		public virtual ITuningStandGridBoard BoardConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._BoardConfigInited)
				{
					return this._BoardConfigCache;
				}
				this._BoardConfigInited = true;
				if (this.FbInstance != null)
				{
					this._BoardConfigCache = ITuningStandGridBoard.Create(this.FbInstance.BoardConfig);
				}
				else
				{
					ITuningStand_SetValue pocoInterface = this.PocoInterface;
					this._BoardConfigCache = ((pocoInterface != null) ? pocoInterface.BoardConfig : null);
				}
				return this._BoardConfigCache;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().BoardConfig = value;
				this._BoardConfigInited = false;
			}
		}

		// Token: 0x04006CA8 RID: 27816
		protected new ITuningStand FbInstance;

		// Token: 0x04006CA9 RID: 27817
		protected new ITuningStand_SetValue PocoInterface;

		// Token: 0x04006CAA RID: 27818
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITuningStandBubbleConfig> _BubbleConfigCache;

		// Token: 0x04006CAB RID: 27819
		private bool _BubbleConfigInited;

		// Token: 0x04006CAC RID: 27820
		[Nullable(1)]
		private ITuningStandGridBoard _BoardConfigCache;

		// Token: 0x04006CAD RID: 27821
		private bool _BoardConfigInited;
	}
}
