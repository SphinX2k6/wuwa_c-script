using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ACC RID: 19148
	public struct ICheckMusicEvent : IFlatbufferObject
	{
		// Token: 0x17008AD3 RID: 35539
		// (get) Token: 0x0601E110 RID: 123152 RVA: 0x00437DD0 File Offset: 0x00435FD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E111 RID: 123153 RVA: 0x00437DDD File Offset: 0x00435FDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E112 RID: 123154 RVA: 0x00437DE4 File Offset: 0x00435FE4
		public static ICheckMusicEvent GetRootAsICheckMusicEvent(ByteBuffer _bb)
		{
			return ICheckMusicEvent.GetRootAsICheckMusicEvent(_bb, default(ICheckMusicEvent));
		}

		// Token: 0x0601E113 RID: 123155 RVA: 0x00437E00 File Offset: 0x00436000
		public static ICheckMusicEvent GetRootAsICheckMusicEvent(ByteBuffer _bb, ICheckMusicEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E114 RID: 123156 RVA: 0x00437E1D File Offset: 0x0043601D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E115 RID: 123157 RVA: 0x00437E2C File Offset: 0x0043602C
		public ICheckMusicEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AD4 RID: 35540
		// (get) Token: 0x0601E116 RID: 123158 RVA: 0x00437E3C File Offset: 0x0043603C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AD5 RID: 35541
		// (get) Token: 0x0601E117 RID: 123159 RVA: 0x00437E78 File Offset: 0x00436078
		public TMusicCondition MusicEventType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TMusicCondition.NONE;
				}
				return (TMusicCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E118 RID: 123160 RVA: 0x00437EB4 File Offset: 0x004360B4
		public TTable? MusicEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E119 RID: 123161 RVA: 0x00437EF8 File Offset: 0x004360F8
		public ICheckFlForestMusicBeats MusicEventAsICheckFlForestMusicBeats()
		{
			return this.MusicEvent<ICheckFlForestMusicBeats>().Value;
		}

		// Token: 0x0601E11A RID: 123162 RVA: 0x00437F14 File Offset: 0x00436114
		public ICheckHcMusicBeats MusicEventAsICheckHcMusicBeats()
		{
			return this.MusicEvent<ICheckHcMusicBeats>().Value;
		}

		// Token: 0x0601E11B RID: 123163 RVA: 0x00437F2F File Offset: 0x0043612F
		public static Offset<ICheckMusicEvent> CreateICheckMusicEvent(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TMusicCondition MusicEvent_type = TMusicCondition.NONE, int MusicEventOffset = 0)
		{
			builder.StartTable(3);
			ICheckMusicEvent.AddMusicEvent(builder, MusicEventOffset);
			ICheckMusicEvent.AddMusicEventType(builder, MusicEvent_type);
			ICheckMusicEvent.AddType(builder, Type);
			return ICheckMusicEvent.EndICheckMusicEvent(builder);
		}

		// Token: 0x0601E11C RID: 123164 RVA: 0x00437F53 File Offset: 0x00436153
		public static void StartICheckMusicEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E11D RID: 123165 RVA: 0x00437F5C File Offset: 0x0043615C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E11E RID: 123166 RVA: 0x00437F67 File Offset: 0x00436167
		public static void AddMusicEventType(FlatBufferBuilder builder, TMusicCondition musicEventType)
		{
			builder.AddByte(1, (byte)musicEventType, 0);
		}

		// Token: 0x0601E11F RID: 123167 RVA: 0x00437F72 File Offset: 0x00436172
		public static void AddMusicEvent(FlatBufferBuilder builder, int musicEventOffset)
		{
			builder.AddOffset(2, musicEventOffset, 0);
		}

		// Token: 0x0601E120 RID: 123168 RVA: 0x00437F7D File Offset: 0x0043617D
		public static Offset<ICheckMusicEvent> EndICheckMusicEvent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMusicEvent>(builder.EndTable());
		}

		// Token: 0x0601E121 RID: 123169 RVA: 0x00437F8C File Offset: 0x0043618C
		public ICheckMusicEventT UnPack()
		{
			ICheckMusicEventT checkMusicEventT = new ICheckMusicEventT();
			this.UnPackTo(checkMusicEventT);
			return checkMusicEventT;
		}

		// Token: 0x0601E122 RID: 123170 RVA: 0x00437FA8 File Offset: 0x004361A8
		public void UnPackTo(ICheckMusicEventT _o)
		{
			_o.Type = this.Type;
			_o.MusicEvent = new TMusicConditionUnion();
			_o.MusicEvent.Type = this.MusicEventType;
			TMusicCondition musicEventType = this.MusicEventType;
			if (musicEventType == TMusicCondition.ICheckFlForestMusicBeats)
			{
				_o.MusicEvent.Value = ((this.MusicEvent<ICheckFlForestMusicBeats>() != null) ? this.MusicEvent<ICheckFlForestMusicBeats>().Value.UnPack() : null);
				return;
			}
			if (musicEventType != TMusicCondition.ICheckHcMusicBeats)
			{
				return;
			}
			_o.MusicEvent.Value = ((this.MusicEvent<ICheckHcMusicBeats>() != null) ? this.MusicEvent<ICheckHcMusicBeats>().Value.UnPack() : null);
		}

		// Token: 0x0601E123 RID: 123171 RVA: 0x00438058 File Offset: 0x00436258
		public static Offset<ICheckMusicEvent> Pack(FlatBufferBuilder builder, ICheckMusicEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckMusicEvent>);
			}
			TMusicCondition musicEvent_type = (_o.MusicEvent == null) ? TMusicCondition.NONE : _o.MusicEvent.Type;
			int musicEventOffset = (_o.MusicEvent == null) ? 0 : TMusicConditionUnion.Pack(builder, _o.MusicEvent);
			return ICheckMusicEvent.CreateICheckMusicEvent(builder, _o.Type, musicEvent_type, musicEventOffset);
		}

		// Token: 0x0400D354 RID: 54100
		private Table __p;
	}
}
