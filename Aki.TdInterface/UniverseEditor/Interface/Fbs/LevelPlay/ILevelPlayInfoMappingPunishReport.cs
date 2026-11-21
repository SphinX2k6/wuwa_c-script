using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004962 RID: 18786
	public struct ILevelPlayInfoMappingPunishReport : IFlatbufferObject
	{
		// Token: 0x17008363 RID: 33635
		// (get) Token: 0x0601BFEC RID: 114668 RVA: 0x003F55BA File Offset: 0x003F37BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BFED RID: 114669 RVA: 0x003F55C7 File Offset: 0x003F37C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BFEE RID: 114670 RVA: 0x003F55D0 File Offset: 0x003F37D0
		public static ILevelPlayInfoMappingPunishReport GetRootAsILevelPlayInfoMappingPunishReport(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingPunishReport.GetRootAsILevelPlayInfoMappingPunishReport(_bb, default(ILevelPlayInfoMappingPunishReport));
		}

		// Token: 0x0601BFEF RID: 114671 RVA: 0x003F55EC File Offset: 0x003F37EC
		public static ILevelPlayInfoMappingPunishReport GetRootAsILevelPlayInfoMappingPunishReport(ByteBuffer _bb, ILevelPlayInfoMappingPunishReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BFF0 RID: 114672 RVA: 0x003F5609 File Offset: 0x003F3809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BFF1 RID: 114673 RVA: 0x003F5618 File Offset: 0x003F3818
		public ILevelPlayInfoMappingPunishReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008364 RID: 33636
		// (get) Token: 0x0601BFF2 RID: 114674 RVA: 0x003F5628 File Offset: 0x003F3828
		public ELevelPlayInfoMappingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayInfoMappingType.PunishReport;
				}
				return (ELevelPlayInfoMappingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008365 RID: 33637
		// (get) Token: 0x0601BFF3 RID: 114675 RVA: 0x003F5664 File Offset: 0x003F3864
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BFF4 RID: 114676 RVA: 0x003F56A0 File Offset: 0x003F38A0
		public string Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008366 RID: 33638
		// (get) Token: 0x0601BFF5 RID: 114677 RVA: 0x003F56DC File Offset: 0x003F38DC
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BFF6 RID: 114678 RVA: 0x003F5708 File Offset: 0x003F3908
		public int Chests(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008367 RID: 33639
		// (get) Token: 0x0601BFF7 RID: 114679 RVA: 0x003F5748 File Offset: 0x003F3948
		public int ChestsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BFF8 RID: 114680 RVA: 0x003F5774 File Offset: 0x003F3974
		public Span<int> GetChestsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601BFF9 RID: 114681 RVA: 0x003F5784 File Offset: 0x003F3984
		public int[] GetChestsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17008368 RID: 33640
		// (get) Token: 0x0601BFFA RID: 114682 RVA: 0x003F5794 File Offset: 0x003F3994
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BFFB RID: 114683 RVA: 0x003F57D1 File Offset: 0x003F39D1
		public static Offset<ILevelPlayInfoMappingPunishReport> CreateILevelPlayInfoMappingPunishReport(FlatBufferBuilder builder, ELevelPlayInfoMappingType Type = ELevelPlayInfoMappingType.PunishReport, int LevelPlayId = 0, VectorOffset VarsOffset = default(VectorOffset), VectorOffset ChestsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelPlayInfoMappingPunishReport.AddChests(builder, ChestsOffset);
			ILevelPlayInfoMappingPunishReport.AddVars(builder, VarsOffset);
			ILevelPlayInfoMappingPunishReport.AddLevelPlayId(builder, LevelPlayId);
			ILevelPlayInfoMappingPunishReport.AddNullMask(builder, NullMask);
			ILevelPlayInfoMappingPunishReport.AddType(builder, Type);
			return ILevelPlayInfoMappingPunishReport.EndILevelPlayInfoMappingPunishReport(builder);
		}

		// Token: 0x0601BFFC RID: 114684 RVA: 0x003F5805 File Offset: 0x003F3A05
		public static void StartILevelPlayInfoMappingPunishReport(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601BFFD RID: 114685 RVA: 0x003F580E File Offset: 0x003F3A0E
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BFFE RID: 114686 RVA: 0x003F5819 File Offset: 0x003F3A19
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601BFFF RID: 114687 RVA: 0x003F5824 File Offset: 0x003F3A24
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601C000 RID: 114688 RVA: 0x003F5834 File Offset: 0x003F3A34
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C001 RID: 114689 RVA: 0x003F5874 File Offset: 0x003F3A74
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C002 RID: 114690 RVA: 0x003F588E File Offset: 0x003F3A8E
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C003 RID: 114691 RVA: 0x003F58AC File Offset: 0x003F3AAC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C004 RID: 114692 RVA: 0x003F58C5 File Offset: 0x003F3AC5
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C005 RID: 114693 RVA: 0x003F58D0 File Offset: 0x003F3AD0
		public static void AddChests(FlatBufferBuilder builder, VectorOffset chestsOffset)
		{
			builder.AddOffset(3, chestsOffset.Value, 0);
		}

		// Token: 0x0601C006 RID: 114694 RVA: 0x003F58E0 File Offset: 0x003F3AE0
		public static VectorOffset CreateChestsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C007 RID: 114695 RVA: 0x003F5917 File Offset: 0x003F3B17
		public static VectorOffset CreateChestsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C008 RID: 114696 RVA: 0x003F5931 File Offset: 0x003F3B31
		public static VectorOffset CreateChestsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C009 RID: 114697 RVA: 0x003F594F File Offset: 0x003F3B4F
		public static VectorOffset CreateChestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C00A RID: 114698 RVA: 0x003F5968 File Offset: 0x003F3B68
		public static void StartChestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C00B RID: 114699 RVA: 0x003F5973 File Offset: 0x003F3B73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601C00C RID: 114700 RVA: 0x003F597E File Offset: 0x003F3B7E
		public static Offset<ILevelPlayInfoMappingPunishReport> EndILevelPlayInfoMappingPunishReport(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingPunishReport>(builder.EndTable());
		}

		// Token: 0x0601C00D RID: 114701 RVA: 0x003F598C File Offset: 0x003F3B8C
		public ILevelPlayInfoMappingPunishReportT UnPack()
		{
			ILevelPlayInfoMappingPunishReportT levelPlayInfoMappingPunishReportT = new ILevelPlayInfoMappingPunishReportT();
			this.UnPackTo(levelPlayInfoMappingPunishReportT);
			return levelPlayInfoMappingPunishReportT;
		}

		// Token: 0x0601C00E RID: 114702 RVA: 0x003F59A8 File Offset: 0x003F3BA8
		public void UnPackTo(ILevelPlayInfoMappingPunishReportT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.Vars = new List<string>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add(this.Vars(i));
			}
			_o.Chests = new List<int>();
			for (int j = 0; j < this.ChestsLength; j++)
			{
				_o.Chests.Add(this.Chests(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C00F RID: 114703 RVA: 0x003F5A38 File Offset: 0x003F3C38
		public static Offset<ILevelPlayInfoMappingPunishReport> Pack(FlatBufferBuilder builder, ILevelPlayInfoMappingPunishReportT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInfoMappingPunishReport>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				StringOffset[] array = new StringOffset[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Vars[i]);
				}
				varsOffset = ILevelPlayInfoMappingPunishReport.CreateVarsVector(builder, array);
			}
			VectorOffset chestsOffset = default(VectorOffset);
			if (_o.Chests != null)
			{
				int[] data = _o.Chests.ToArray();
				chestsOffset = ILevelPlayInfoMappingPunishReport.CreateChestsVector(builder, data);
			}
			return ILevelPlayInfoMappingPunishReport.CreateILevelPlayInfoMappingPunishReport(builder, _o.Type, _o.LevelPlayId, varsOffset, chestsOffset, _o.NullMask);
		}

		// Token: 0x0400CF8A RID: 53130
		private Table __p;
	}
}
