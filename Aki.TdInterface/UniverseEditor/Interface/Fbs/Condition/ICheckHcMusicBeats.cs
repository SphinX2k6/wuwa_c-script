using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F0E RID: 20238
	public struct ICheckHcMusicBeats : IFlatbufferObject
	{
		// Token: 0x17009087 RID: 36999
		// (get) Token: 0x0601F713 RID: 128787 RVA: 0x00460DEC File Offset: 0x0045EFEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F714 RID: 128788 RVA: 0x00460DF9 File Offset: 0x0045EFF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F715 RID: 128789 RVA: 0x00460E00 File Offset: 0x0045F000
		public static ICheckHcMusicBeats GetRootAsICheckHcMusicBeats(ByteBuffer _bb)
		{
			return ICheckHcMusicBeats.GetRootAsICheckHcMusicBeats(_bb, default(ICheckHcMusicBeats));
		}

		// Token: 0x0601F716 RID: 128790 RVA: 0x00460E1C File Offset: 0x0045F01C
		public static ICheckHcMusicBeats GetRootAsICheckHcMusicBeats(ByteBuffer _bb, ICheckHcMusicBeats obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F717 RID: 128791 RVA: 0x00460E39 File Offset: 0x0045F039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F718 RID: 128792 RVA: 0x00460E48 File Offset: 0x0045F048
		public ICheckHcMusicBeats __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009088 RID: 37000
		// (get) Token: 0x0601F719 RID: 128793 RVA: 0x00460E58 File Offset: 0x0045F058
		public EMusicEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMusicEventType.HcMusicBattle;
				}
				return (EMusicEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009089 RID: 37001
		// (get) Token: 0x0601F71A RID: 128794 RVA: 0x00460E94 File Offset: 0x0045F094
		public string BeatType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F71B RID: 128795 RVA: 0x00460ECB File Offset: 0x0045F0CB
		public Span<byte> GetBeatTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601F71C RID: 128796 RVA: 0x00460EDA File Offset: 0x0045F0DA
		public byte[] GetBeatTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601F71D RID: 128797 RVA: 0x00460EE8 File Offset: 0x0045F0E8
		public static Offset<ICheckHcMusicBeats> CreateICheckHcMusicBeats(FlatBufferBuilder builder, EMusicEventType Type = EMusicEventType.HcMusicBattle, StringOffset BeatTypeOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICheckHcMusicBeats.AddBeatType(builder, BeatTypeOffset);
			ICheckHcMusicBeats.AddType(builder, Type);
			return ICheckHcMusicBeats.EndICheckHcMusicBeats(builder);
		}

		// Token: 0x0601F71E RID: 128798 RVA: 0x00460F05 File Offset: 0x0045F105
		public static void StartICheckHcMusicBeats(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F71F RID: 128799 RVA: 0x00460F0E File Offset: 0x0045F10E
		public static void AddType(FlatBufferBuilder builder, EMusicEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F720 RID: 128800 RVA: 0x00460F19 File Offset: 0x0045F119
		public static void AddBeatType(FlatBufferBuilder builder, StringOffset beatTypeOffset)
		{
			builder.AddOffset(1, beatTypeOffset.Value, 0);
		}

		// Token: 0x0601F721 RID: 128801 RVA: 0x00460F29 File Offset: 0x0045F129
		public static Offset<ICheckHcMusicBeats> EndICheckHcMusicBeats(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHcMusicBeats>(builder.EndTable());
		}

		// Token: 0x0601F722 RID: 128802 RVA: 0x00460F38 File Offset: 0x0045F138
		public ICheckHcMusicBeatsT UnPack()
		{
			ICheckHcMusicBeatsT checkHcMusicBeatsT = new ICheckHcMusicBeatsT();
			this.UnPackTo(checkHcMusicBeatsT);
			return checkHcMusicBeatsT;
		}

		// Token: 0x0601F723 RID: 128803 RVA: 0x00460F53 File Offset: 0x0045F153
		public void UnPackTo(ICheckHcMusicBeatsT _o)
		{
			_o.Type = this.Type;
			_o.BeatType = this.BeatType;
		}

		// Token: 0x0601F724 RID: 128804 RVA: 0x00460F70 File Offset: 0x0045F170
		public static Offset<ICheckHcMusicBeats> Pack(FlatBufferBuilder builder, ICheckHcMusicBeatsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHcMusicBeats>);
			}
			StringOffset beatTypeOffset = (_o.BeatType == null) ? default(StringOffset) : builder.CreateString(_o.BeatType);
			return ICheckHcMusicBeats.CreateICheckHcMusicBeats(builder, _o.Type, beatTypeOffset);
		}

		// Token: 0x0400DD7A RID: 56698
		private Table __p;
	}
}
