using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E9 RID: 29929
	public struct IPostAkEvent : IFlatbufferObject
	{
		// Token: 0x1700DC3E RID: 56382
		// (get) Token: 0x06034788 RID: 214920 RVA: 0x00710767 File Offset: 0x0070E967
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034789 RID: 214921 RVA: 0x00710774 File Offset: 0x0070E974
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603478A RID: 214922 RVA: 0x0071077C File Offset: 0x0070E97C
		public static IPostAkEvent GetRootAsIPostAkEvent(ByteBuffer _bb)
		{
			return IPostAkEvent.GetRootAsIPostAkEvent(_bb, default(IPostAkEvent));
		}

		// Token: 0x0603478B RID: 214923 RVA: 0x00710798 File Offset: 0x0070E998
		public static IPostAkEvent GetRootAsIPostAkEvent(ByteBuffer _bb, IPostAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603478C RID: 214924 RVA: 0x007107B5 File Offset: 0x0070E9B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603478D RID: 214925 RVA: 0x007107C4 File Offset: 0x0070E9C4
		public IPostAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC3F RID: 56383
		// (get) Token: 0x0603478E RID: 214926 RVA: 0x007107D4 File Offset: 0x0070E9D4
		public TPostAkEvent EventConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPostAkEvent.NONE;
				}
				return (TPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603478F RID: 214927 RVA: 0x00710810 File Offset: 0x0070EA10
		public TTable? EventConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034790 RID: 214928 RVA: 0x00710854 File Offset: 0x0070EA54
		public IPostAkEventGlobal EventConfigAsIPostAkEventGlobal()
		{
			return this.EventConfig<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06034791 RID: 214929 RVA: 0x00710870 File Offset: 0x0070EA70
		public IPostAkEventMap EventConfigAsIPostAkEventMap()
		{
			return this.EventConfig<IPostAkEventMap>().Value;
		}

		// Token: 0x06034792 RID: 214930 RVA: 0x0071088C File Offset: 0x0070EA8C
		public IPostAkEventMusicSubtitle EventConfigAsIPostAkEventMusicSubtitle()
		{
			return this.EventConfig<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06034793 RID: 214931 RVA: 0x007108A8 File Offset: 0x0070EAA8
		public IPostAkEventTargeted EventConfigAsIPostAkEventTargeted()
		{
			return this.EventConfig<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DC40 RID: 56384
		// (get) Token: 0x06034794 RID: 214932 RVA: 0x007108C4 File Offset: 0x0070EAC4
		public bool PersistWhenExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC41 RID: 56385
		// (get) Token: 0x06034795 RID: 214933 RVA: 0x00710904 File Offset: 0x0070EB04
		public EMusicEventType MusicEventType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMusicEventType.HcMusicBattle;
				}
				return (EMusicEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC42 RID: 56386
		// (get) Token: 0x06034796 RID: 214934 RVA: 0x00710944 File Offset: 0x0070EB44
		public bool IsBanVehicleRadio
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC43 RID: 56387
		// (get) Token: 0x06034797 RID: 214935 RVA: 0x00710984 File Offset: 0x0070EB84
		public float FadeOutTimeWhenFlowEnd
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC44 RID: 56388
		// (get) Token: 0x06034798 RID: 214936 RVA: 0x007109C8 File Offset: 0x0070EBC8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC45 RID: 56389
		// (get) Token: 0x06034799 RID: 214937 RVA: 0x00710A0C File Offset: 0x0070EC0C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603479A RID: 214938 RVA: 0x00710A4C File Offset: 0x0070EC4C
		public static Offset<IPostAkEvent> CreateIPostAkEvent(FlatBufferBuilder builder, TPostAkEvent EventConfig_type = TPostAkEvent.NONE, int EventConfigOffset = 0, bool PersistWhenExitDungeon = false, EMusicEventType MusicEventType = EMusicEventType.HcMusicBattle, bool IsBanVehicleRadio = false, float FadeOutTimeWhenFlowEnd = 0f, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IPostAkEvent.AddDelayTime(builder, DelayTime);
			IPostAkEvent.AddFadeOutTimeWhenFlowEnd(builder, FadeOutTimeWhenFlowEnd);
			IPostAkEvent.AddEventConfig(builder, EventConfigOffset);
			IPostAkEvent.AddNullMask(builder, NullMask);
			IPostAkEvent.AddIsBanVehicleRadio(builder, IsBanVehicleRadio);
			IPostAkEvent.AddMusicEventType(builder, MusicEventType);
			IPostAkEvent.AddPersistWhenExitDungeon(builder, PersistWhenExitDungeon);
			IPostAkEvent.AddEventConfigType(builder, EventConfig_type);
			return IPostAkEvent.EndIPostAkEvent(builder);
		}

		// Token: 0x0603479B RID: 214939 RVA: 0x00710AA3 File Offset: 0x0070ECA3
		public static void StartIPostAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0603479C RID: 214940 RVA: 0x00710AAC File Offset: 0x0070ECAC
		public static void AddEventConfigType(FlatBufferBuilder builder, TPostAkEvent eventConfigType)
		{
			builder.AddByte(0, (byte)eventConfigType, 0);
		}

		// Token: 0x0603479D RID: 214941 RVA: 0x00710AB7 File Offset: 0x0070ECB7
		public static void AddEventConfig(FlatBufferBuilder builder, int eventConfigOffset)
		{
			builder.AddOffset(1, eventConfigOffset, 0);
		}

		// Token: 0x0603479E RID: 214942 RVA: 0x00710AC2 File Offset: 0x0070ECC2
		public static void AddPersistWhenExitDungeon(FlatBufferBuilder builder, bool persistWhenExitDungeon)
		{
			builder.AddBool(2, persistWhenExitDungeon, false);
		}

		// Token: 0x0603479F RID: 214943 RVA: 0x00710ACD File Offset: 0x0070ECCD
		public static void AddMusicEventType(FlatBufferBuilder builder, EMusicEventType musicEventType)
		{
			builder.AddByte(3, (byte)musicEventType, 0);
		}

		// Token: 0x060347A0 RID: 214944 RVA: 0x00710AD8 File Offset: 0x0070ECD8
		public static void AddIsBanVehicleRadio(FlatBufferBuilder builder, bool isBanVehicleRadio)
		{
			builder.AddBool(4, isBanVehicleRadio, false);
		}

		// Token: 0x060347A1 RID: 214945 RVA: 0x00710AE3 File Offset: 0x0070ECE3
		public static void AddFadeOutTimeWhenFlowEnd(FlatBufferBuilder builder, float fadeOutTimeWhenFlowEnd)
		{
			builder.AddFloat(5, fadeOutTimeWhenFlowEnd, 0.0);
		}

		// Token: 0x060347A2 RID: 214946 RVA: 0x00710AF6 File Offset: 0x0070ECF6
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(6, delayTime, 0.0);
		}

		// Token: 0x060347A3 RID: 214947 RVA: 0x00710B09 File Offset: 0x0070ED09
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060347A4 RID: 214948 RVA: 0x00710B14 File Offset: 0x0070ED14
		public static Offset<IPostAkEvent> EndIPostAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEvent>(builder.EndTable());
		}

		// Token: 0x060347A5 RID: 214949 RVA: 0x00710B24 File Offset: 0x0070ED24
		public IPostAkEventT UnPack()
		{
			IPostAkEventT postAkEventT = new IPostAkEventT();
			this.UnPackTo(postAkEventT);
			return postAkEventT;
		}

		// Token: 0x060347A6 RID: 214950 RVA: 0x00710B40 File Offset: 0x0070ED40
		public void UnPackTo(IPostAkEventT _o)
		{
			_o.EventConfig = new TPostAkEventUnion();
			_o.EventConfig.Type = this.EventConfigType;
			switch (this.EventConfigType)
			{
			case TPostAkEvent.IPostAkEventGlobal:
				_o.EventConfig.Value = ((this.EventConfig<IPostAkEventGlobal>() != null) ? this.EventConfig<IPostAkEventGlobal>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMap:
				_o.EventConfig.Value = ((this.EventConfig<IPostAkEventMap>() != null) ? this.EventConfig<IPostAkEventMap>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMusicSubtitle:
				_o.EventConfig.Value = ((this.EventConfig<IPostAkEventMusicSubtitle>() != null) ? this.EventConfig<IPostAkEventMusicSubtitle>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventTargeted:
				_o.EventConfig.Value = ((this.EventConfig<IPostAkEventTargeted>() != null) ? this.EventConfig<IPostAkEventTargeted>().Value.UnPack() : null);
				break;
			}
			_o.PersistWhenExitDungeon = this.PersistWhenExitDungeon;
			_o.MusicEventType = this.MusicEventType;
			_o.IsBanVehicleRadio = this.IsBanVehicleRadio;
			_o.FadeOutTimeWhenFlowEnd = this.FadeOutTimeWhenFlowEnd;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060347A7 RID: 214951 RVA: 0x00710CB8 File Offset: 0x0070EEB8
		public static Offset<IPostAkEvent> Pack(FlatBufferBuilder builder, IPostAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEvent>);
			}
			TPostAkEvent eventConfig_type = (_o.EventConfig == null) ? TPostAkEvent.NONE : _o.EventConfig.Type;
			int eventConfigOffset = (_o.EventConfig == null) ? 0 : TPostAkEventUnion.Pack(builder, _o.EventConfig);
			return IPostAkEvent.CreateIPostAkEvent(builder, eventConfig_type, eventConfigOffset, _o.PersistWhenExitDungeon, _o.MusicEventType, _o.IsBanVehicleRadio, _o.FadeOutTimeWhenFlowEnd, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x040126A8 RID: 75432
		private Table __p;
	}
}
