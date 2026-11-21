using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC6 RID: 24518
	public struct IStateRepPerfMontagePath : IFlatbufferObject
	{
		// Token: 0x1700B58E RID: 46478
		// (get) Token: 0x06029411 RID: 168977 RVA: 0x005A17B4 File Offset: 0x0059F9B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029412 RID: 168978 RVA: 0x005A17C1 File Offset: 0x0059F9C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029413 RID: 168979 RVA: 0x005A17C8 File Offset: 0x0059F9C8
		public static IStateRepPerfMontagePath GetRootAsIStateRepPerfMontagePath(ByteBuffer _bb)
		{
			return IStateRepPerfMontagePath.GetRootAsIStateRepPerfMontagePath(_bb, default(IStateRepPerfMontagePath));
		}

		// Token: 0x06029414 RID: 168980 RVA: 0x005A17E4 File Offset: 0x0059F9E4
		public static IStateRepPerfMontagePath GetRootAsIStateRepPerfMontagePath(ByteBuffer _bb, IStateRepPerfMontagePath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029415 RID: 168981 RVA: 0x005A1801 File Offset: 0x0059FA01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029416 RID: 168982 RVA: 0x005A1810 File Offset: 0x0059FA10
		public IStateRepPerfMontagePath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B58F RID: 46479
		// (get) Token: 0x06029417 RID: 168983 RVA: 0x005A1820 File Offset: 0x0059FA20
		public EStateRepPerfType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStateRepPerfType.SkillId;
				}
				return (EStateRepPerfType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B590 RID: 46480
		// (get) Token: 0x06029418 RID: 168984 RVA: 0x005A185C File Offset: 0x0059FA5C
		public string MontagePath
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

		// Token: 0x06029419 RID: 168985 RVA: 0x005A1893 File Offset: 0x0059FA93
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602941A RID: 168986 RVA: 0x005A18A2 File Offset: 0x0059FAA2
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B591 RID: 46481
		// (get) Token: 0x0602941B RID: 168987 RVA: 0x005A18B0 File Offset: 0x0059FAB0
		public string MontageName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602941C RID: 168988 RVA: 0x005A18E7 File Offset: 0x0059FAE7
		public Span<byte> GetMontageNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602941D RID: 168989 RVA: 0x005A18F6 File Offset: 0x0059FAF6
		public byte[] GetMontageNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602941E RID: 168990 RVA: 0x005A1904 File Offset: 0x0059FB04
		public static Offset<IStateRepPerfMontagePath> CreateIStateRepPerfMontagePath(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId, StringOffset MontagePathOffset = default(StringOffset), StringOffset MontageNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IStateRepPerfMontagePath.AddMontageName(builder, MontageNameOffset);
			IStateRepPerfMontagePath.AddMontagePath(builder, MontagePathOffset);
			IStateRepPerfMontagePath.AddType(builder, Type);
			return IStateRepPerfMontagePath.EndIStateRepPerfMontagePath(builder);
		}

		// Token: 0x0602941F RID: 168991 RVA: 0x005A1928 File Offset: 0x0059FB28
		public static void StartIStateRepPerfMontagePath(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029420 RID: 168992 RVA: 0x005A1931 File Offset: 0x0059FB31
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029421 RID: 168993 RVA: 0x005A193C File Offset: 0x0059FB3C
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(1, montagePathOffset.Value, 0);
		}

		// Token: 0x06029422 RID: 168994 RVA: 0x005A194C File Offset: 0x0059FB4C
		public static void AddMontageName(FlatBufferBuilder builder, StringOffset montageNameOffset)
		{
			builder.AddOffset(2, montageNameOffset.Value, 0);
		}

		// Token: 0x06029423 RID: 168995 RVA: 0x005A195C File Offset: 0x0059FB5C
		public static Offset<IStateRepPerfMontagePath> EndIStateRepPerfMontagePath(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfMontagePath>(builder.EndTable());
		}

		// Token: 0x06029424 RID: 168996 RVA: 0x005A196C File Offset: 0x0059FB6C
		public IStateRepPerfMontagePathT UnPack()
		{
			IStateRepPerfMontagePathT stateRepPerfMontagePathT = new IStateRepPerfMontagePathT();
			this.UnPackTo(stateRepPerfMontagePathT);
			return stateRepPerfMontagePathT;
		}

		// Token: 0x06029425 RID: 168997 RVA: 0x005A1987 File Offset: 0x0059FB87
		public void UnPackTo(IStateRepPerfMontagePathT _o)
		{
			_o.Type = this.Type;
			_o.MontagePath = this.MontagePath;
			_o.MontageName = this.MontageName;
		}

		// Token: 0x06029426 RID: 168998 RVA: 0x005A19B0 File Offset: 0x0059FBB0
		public static Offset<IStateRepPerfMontagePath> Pack(FlatBufferBuilder builder, IStateRepPerfMontagePathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfMontagePath>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			StringOffset montageNameOffset = (_o.MontageName == null) ? default(StringOffset) : builder.CreateString(_o.MontageName);
			return IStateRepPerfMontagePath.CreateIStateRepPerfMontagePath(builder, _o.Type, montagePathOffset, montageNameOffset);
		}

		// Token: 0x0400FCC1 RID: 64705
		private Table __p;
	}
}
