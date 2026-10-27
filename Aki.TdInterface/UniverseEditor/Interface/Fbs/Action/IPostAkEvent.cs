using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6E RID: 28014
	public struct IPostAkEvent : IFlatbufferObject
	{
		// Token: 0x1700D0F6 RID: 53494
		// (get) Token: 0x0603178C RID: 202636 RVA: 0x006B507F File Offset: 0x006B327F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603178D RID: 202637 RVA: 0x006B508C File Offset: 0x006B328C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603178E RID: 202638 RVA: 0x006B5094 File Offset: 0x006B3294
		public static IPostAkEvent GetRootAsIPostAkEvent(ByteBuffer _bb)
		{
			return IPostAkEvent.GetRootAsIPostAkEvent(_bb, default(IPostAkEvent));
		}

		// Token: 0x0603178F RID: 202639 RVA: 0x006B50B0 File Offset: 0x006B32B0
		public static IPostAkEvent GetRootAsIPostAkEvent(ByteBuffer _bb, IPostAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031790 RID: 202640 RVA: 0x006B50CD File Offset: 0x006B32CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031791 RID: 202641 RVA: 0x006B50DC File Offset: 0x006B32DC
		public IPostAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0F7 RID: 53495
		// (get) Token: 0x06031792 RID: 202642 RVA: 0x006B50EC File Offset: 0x006B32EC
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

		// Token: 0x06031793 RID: 202643 RVA: 0x006B5128 File Offset: 0x006B3328
		public TTable? EventConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031794 RID: 202644 RVA: 0x006B516C File Offset: 0x006B336C
		public IPostAkEventGlobal EventConfigAsIPostAkEventGlobal()
		{
			return this.EventConfig<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06031795 RID: 202645 RVA: 0x006B5188 File Offset: 0x006B3388
		public IPostAkEventMap EventConfigAsIPostAkEventMap()
		{
			return this.EventConfig<IPostAkEventMap>().Value;
		}

		// Token: 0x06031796 RID: 202646 RVA: 0x006B51A4 File Offset: 0x006B33A4
		public IPostAkEventMusicSubtitle EventConfigAsIPostAkEventMusicSubtitle()
		{
			return this.EventConfig<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06031797 RID: 202647 RVA: 0x006B51C0 File Offset: 0x006B33C0
		public IPostAkEventTargeted EventConfigAsIPostAkEventTargeted()
		{
			return this.EventConfig<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700D0F8 RID: 53496
		// (get) Token: 0x06031798 RID: 202648 RVA: 0x006B51DC File Offset: 0x006B33DC
		public bool PersistWhenExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D0F9 RID: 53497
		// (get) Token: 0x06031799 RID: 202649 RVA: 0x006B521C File Offset: 0x006B341C
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

		// Token: 0x1700D0FA RID: 53498
		// (get) Token: 0x0603179A RID: 202650 RVA: 0x006B525C File Offset: 0x006B345C
		public bool IsBanVehicleRadio
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D0FB RID: 53499
		// (get) Token: 0x0603179B RID: 202651 RVA: 0x006B529C File Offset: 0x006B349C
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

		// Token: 0x1700D0FC RID: 53500
		// (get) Token: 0x0603179C RID: 202652 RVA: 0x006B52E0 File Offset: 0x006B34E0
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

		// Token: 0x1700D0FD RID: 53501
		// (get) Token: 0x0603179D RID: 202653 RVA: 0x006B5324 File Offset: 0x006B3524
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

		// Token: 0x0603179E RID: 202654 RVA: 0x006B5364 File Offset: 0x006B3564
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

		// Token: 0x0603179F RID: 202655 RVA: 0x006B53BB File Offset: 0x006B35BB
		public static void StartIPostAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060317A0 RID: 202656 RVA: 0x006B53C4 File Offset: 0x006B35C4
		public static void AddEventConfigType(FlatBufferBuilder builder, TPostAkEvent eventConfigType)
		{
			builder.AddByte(0, (byte)eventConfigType, 0);
		}

		// Token: 0x060317A1 RID: 202657 RVA: 0x006B53CF File Offset: 0x006B35CF
		public static void AddEventConfig(FlatBufferBuilder builder, int eventConfigOffset)
		{
			builder.AddOffset(1, eventConfigOffset, 0);
		}

		// Token: 0x060317A2 RID: 202658 RVA: 0x006B53DA File Offset: 0x006B35DA
		public static void AddPersistWhenExitDungeon(FlatBufferBuilder builder, bool persistWhenExitDungeon)
		{
			builder.AddBool(2, persistWhenExitDungeon, false);
		}

		// Token: 0x060317A3 RID: 202659 RVA: 0x006B53E5 File Offset: 0x006B35E5
		public static void AddMusicEventType(FlatBufferBuilder builder, EMusicEventType musicEventType)
		{
			builder.AddByte(3, (byte)musicEventType, 0);
		}

		// Token: 0x060317A4 RID: 202660 RVA: 0x006B53F0 File Offset: 0x006B35F0
		public static void AddIsBanVehicleRadio(FlatBufferBuilder builder, bool isBanVehicleRadio)
		{
			builder.AddBool(4, isBanVehicleRadio, false);
		}

		// Token: 0x060317A5 RID: 202661 RVA: 0x006B53FB File Offset: 0x006B35FB
		public static void AddFadeOutTimeWhenFlowEnd(FlatBufferBuilder builder, float fadeOutTimeWhenFlowEnd)
		{
			builder.AddFloat(5, fadeOutTimeWhenFlowEnd, 0.0);
		}

		// Token: 0x060317A6 RID: 202662 RVA: 0x006B540E File Offset: 0x006B360E
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(6, delayTime, 0.0);
		}

		// Token: 0x060317A7 RID: 202663 RVA: 0x006B5421 File Offset: 0x006B3621
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060317A8 RID: 202664 RVA: 0x006B542C File Offset: 0x006B362C
		public static Offset<IPostAkEvent> EndIPostAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEvent>(builder.EndTable());
		}

		// Token: 0x060317A9 RID: 202665 RVA: 0x006B543C File Offset: 0x006B363C
		public IPostAkEventT UnPack()
		{
			IPostAkEventT postAkEventT = new IPostAkEventT();
			this.UnPackTo(postAkEventT);
			return postAkEventT;
		}

		// Token: 0x060317AA RID: 202666 RVA: 0x006B5458 File Offset: 0x006B3658
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

		// Token: 0x060317AB RID: 202667 RVA: 0x006B55D0 File Offset: 0x006B37D0
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

		// Token: 0x0401172C RID: 71468
		private Table __p;
	}
}
