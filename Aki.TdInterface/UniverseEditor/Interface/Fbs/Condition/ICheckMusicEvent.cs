using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F9E RID: 20382
	public struct ICheckMusicEvent : IFlatbufferObject
	{
		// Token: 0x170091C5 RID: 37317
		// (get) Token: 0x0601FC0F RID: 130063 RVA: 0x0046987C File Offset: 0x00467A7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC10 RID: 130064 RVA: 0x00469889 File Offset: 0x00467A89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC11 RID: 130065 RVA: 0x00469890 File Offset: 0x00467A90
		public static ICheckMusicEvent GetRootAsICheckMusicEvent(ByteBuffer _bb)
		{
			return ICheckMusicEvent.GetRootAsICheckMusicEvent(_bb, default(ICheckMusicEvent));
		}

		// Token: 0x0601FC12 RID: 130066 RVA: 0x004698AC File Offset: 0x00467AAC
		public static ICheckMusicEvent GetRootAsICheckMusicEvent(ByteBuffer _bb, ICheckMusicEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC13 RID: 130067 RVA: 0x004698C9 File Offset: 0x00467AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC14 RID: 130068 RVA: 0x004698D8 File Offset: 0x00467AD8
		public ICheckMusicEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091C6 RID: 37318
		// (get) Token: 0x0601FC15 RID: 130069 RVA: 0x004698E8 File Offset: 0x00467AE8
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

		// Token: 0x170091C7 RID: 37319
		// (get) Token: 0x0601FC16 RID: 130070 RVA: 0x00469924 File Offset: 0x00467B24
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

		// Token: 0x0601FC17 RID: 130071 RVA: 0x00469960 File Offset: 0x00467B60
		public TTable? MusicEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FC18 RID: 130072 RVA: 0x004699A4 File Offset: 0x00467BA4
		public ICheckFlForestMusicBeats MusicEventAsICheckFlForestMusicBeats()
		{
			return this.MusicEvent<ICheckFlForestMusicBeats>().Value;
		}

		// Token: 0x0601FC19 RID: 130073 RVA: 0x004699C0 File Offset: 0x00467BC0
		public ICheckHcMusicBeats MusicEventAsICheckHcMusicBeats()
		{
			return this.MusicEvent<ICheckHcMusicBeats>().Value;
		}

		// Token: 0x0601FC1A RID: 130074 RVA: 0x004699DB File Offset: 0x00467BDB
		public static Offset<ICheckMusicEvent> CreateICheckMusicEvent(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TMusicCondition MusicEvent_type = TMusicCondition.NONE, int MusicEventOffset = 0)
		{
			builder.StartTable(3);
			ICheckMusicEvent.AddMusicEvent(builder, MusicEventOffset);
			ICheckMusicEvent.AddMusicEventType(builder, MusicEvent_type);
			ICheckMusicEvent.AddType(builder, Type);
			return ICheckMusicEvent.EndICheckMusicEvent(builder);
		}

		// Token: 0x0601FC1B RID: 130075 RVA: 0x004699FF File Offset: 0x00467BFF
		public static void StartICheckMusicEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FC1C RID: 130076 RVA: 0x00469A08 File Offset: 0x00467C08
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC1D RID: 130077 RVA: 0x00469A13 File Offset: 0x00467C13
		public static void AddMusicEventType(FlatBufferBuilder builder, TMusicCondition musicEventType)
		{
			builder.AddByte(1, (byte)musicEventType, 0);
		}

		// Token: 0x0601FC1E RID: 130078 RVA: 0x00469A1E File Offset: 0x00467C1E
		public static void AddMusicEvent(FlatBufferBuilder builder, int musicEventOffset)
		{
			builder.AddOffset(2, musicEventOffset, 0);
		}

		// Token: 0x0601FC1F RID: 130079 RVA: 0x00469A29 File Offset: 0x00467C29
		public static Offset<ICheckMusicEvent> EndICheckMusicEvent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMusicEvent>(builder.EndTable());
		}

		// Token: 0x0601FC20 RID: 130080 RVA: 0x00469A38 File Offset: 0x00467C38
		public ICheckMusicEventT UnPack()
		{
			ICheckMusicEventT checkMusicEventT = new ICheckMusicEventT();
			this.UnPackTo(checkMusicEventT);
			return checkMusicEventT;
		}

		// Token: 0x0601FC21 RID: 130081 RVA: 0x00469A54 File Offset: 0x00467C54
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

		// Token: 0x0601FC22 RID: 130082 RVA: 0x00469B04 File Offset: 0x00467D04
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

		// Token: 0x0400DE3C RID: 56892
		private Table __p;
	}
}
