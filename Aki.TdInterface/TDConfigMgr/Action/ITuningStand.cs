using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224D RID: 8781
	[NullableContext(2)]
	[Nullable(0)]
	public class ITuningStand : IUiGame
	{
		// Token: 0x0600BF60 RID: 48992 RVA: 0x001B9A00 File Offset: 0x001B7C00
		[NullableContext(0)]
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

		// Token: 0x0600BF61 RID: 48993 RVA: 0x001B9A38 File Offset: 0x001B7C38
		[NullableContext(0)]
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

		// Token: 0x0600BF62 RID: 48994 RVA: 0x001B9A4B File Offset: 0x001B7C4B
		[NullableContext(0)]
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

		// Token: 0x0600BF63 RID: 48995 RVA: 0x001B9A60 File Offset: 0x001B7C60
		[NullableContext(0)]
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

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x001B9AD2 File Offset: 0x001B7CD2
		// (set) Token: 0x0600BF65 RID: 48997 RVA: 0x001B9AFD File Offset: 0x001B7CFD
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

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600BF66 RID: 48998 RVA: 0x001B9B0B File Offset: 0x001B7D0B
		// (set) Token: 0x0600BF67 RID: 48999 RVA: 0x001B9B36 File Offset: 0x001B7D36
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

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600BF68 RID: 49000 RVA: 0x001B9B44 File Offset: 0x001B7D44
		// (set) Token: 0x0600BF69 RID: 49001 RVA: 0x001B9BD7 File Offset: 0x001B7DD7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ITuningStandBubbleConfig> BubbleConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().BubbleConfig = value;
				this._BubbleConfigInited = false;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x001B9BEC File Offset: 0x001B7DEC
		// (set) Token: 0x0600BF6B RID: 49003 RVA: 0x001B9C13 File Offset: 0x001B7E13
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

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600BF6C RID: 49004 RVA: 0x001B9C21 File Offset: 0x001B7E21
		// (set) Token: 0x0600BF6D RID: 49005 RVA: 0x001B9C48 File Offset: 0x001B7E48
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

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600BF6E RID: 49006 RVA: 0x001B9C56 File Offset: 0x001B7E56
		// (set) Token: 0x0600BF6F RID: 49007 RVA: 0x001B9C7D File Offset: 0x001B7E7D
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

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600BF70 RID: 49008 RVA: 0x001B9C8B File Offset: 0x001B7E8B
		// (set) Token: 0x0600BF71 RID: 49009 RVA: 0x001B9CB2 File Offset: 0x001B7EB2
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

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600BF72 RID: 49010 RVA: 0x001B9CC0 File Offset: 0x001B7EC0
		// (set) Token: 0x0600BF73 RID: 49011 RVA: 0x001B9D21 File Offset: 0x001B7F21
		[Nullable(0)]
		public virtual ITuningStandGridBoard BoardConfig
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().BoardConfig = value;
				this._BoardConfigInited = false;
			}
		}

		// Token: 0x040072AB RID: 29355
		protected new ITuningStand FbInstance;

		// Token: 0x040072AC RID: 29356
		protected new ITuningStand_SetValue PocoInterface;

		// Token: 0x040072AD RID: 29357
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITuningStandBubbleConfig> _BubbleConfigCache;

		// Token: 0x040072AE RID: 29358
		private bool _BubbleConfigInited;

		// Token: 0x040072AF RID: 29359
		[Nullable(0)]
		private ITuningStandGridBoard _BoardConfigCache;

		// Token: 0x040072B0 RID: 29360
		private bool _BoardConfigInited;
	}
}
