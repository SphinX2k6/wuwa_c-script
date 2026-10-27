using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044FA RID: 17658
	public struct ILevelPlayInfoMappingPunishReport : IFlatbufferObject
	{
		// Token: 0x17007D22 RID: 32034
		// (get) Token: 0x0601A817 RID: 108567 RVA: 0x003C931E File Offset: 0x003C751E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A818 RID: 108568 RVA: 0x003C932B File Offset: 0x003C752B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A819 RID: 108569 RVA: 0x003C9334 File Offset: 0x003C7534
		public static ILevelPlayInfoMappingPunishReport GetRootAsILevelPlayInfoMappingPunishReport(ByteBuffer _bb)
		{
			return ILevelPlayInfoMappingPunishReport.GetRootAsILevelPlayInfoMappingPunishReport(_bb, default(ILevelPlayInfoMappingPunishReport));
		}

		// Token: 0x0601A81A RID: 108570 RVA: 0x003C9350 File Offset: 0x003C7550
		public static ILevelPlayInfoMappingPunishReport GetRootAsILevelPlayInfoMappingPunishReport(ByteBuffer _bb, ILevelPlayInfoMappingPunishReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A81B RID: 108571 RVA: 0x003C936D File Offset: 0x003C756D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A81C RID: 108572 RVA: 0x003C937C File Offset: 0x003C757C
		public ILevelPlayInfoMappingPunishReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D23 RID: 32035
		// (get) Token: 0x0601A81D RID: 108573 RVA: 0x003C938C File Offset: 0x003C758C
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

		// Token: 0x17007D24 RID: 32036
		// (get) Token: 0x0601A81E RID: 108574 RVA: 0x003C93C8 File Offset: 0x003C75C8
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

		// Token: 0x0601A81F RID: 108575 RVA: 0x003C9404 File Offset: 0x003C7604
		public string Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007D25 RID: 32037
		// (get) Token: 0x0601A820 RID: 108576 RVA: 0x003C9440 File Offset: 0x003C7640
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

		// Token: 0x0601A821 RID: 108577 RVA: 0x003C946C File Offset: 0x003C766C
		public int Chests(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007D26 RID: 32038
		// (get) Token: 0x0601A822 RID: 108578 RVA: 0x003C94AC File Offset: 0x003C76AC
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

		// Token: 0x0601A823 RID: 108579 RVA: 0x003C94D8 File Offset: 0x003C76D8
		public Span<int> GetChestsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601A824 RID: 108580 RVA: 0x003C94E8 File Offset: 0x003C76E8
		public int[] GetChestsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17007D27 RID: 32039
		// (get) Token: 0x0601A825 RID: 108581 RVA: 0x003C94F8 File Offset: 0x003C76F8
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

		// Token: 0x0601A826 RID: 108582 RVA: 0x003C9535 File Offset: 0x003C7735
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

		// Token: 0x0601A827 RID: 108583 RVA: 0x003C9569 File Offset: 0x003C7769
		public static void StartILevelPlayInfoMappingPunishReport(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A828 RID: 108584 RVA: 0x003C9572 File Offset: 0x003C7772
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInfoMappingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A829 RID: 108585 RVA: 0x003C957D File Offset: 0x003C777D
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601A82A RID: 108586 RVA: 0x003C9588 File Offset: 0x003C7788
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601A82B RID: 108587 RVA: 0x003C9598 File Offset: 0x003C7798
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A82C RID: 108588 RVA: 0x003C95D8 File Offset: 0x003C77D8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A82D RID: 108589 RVA: 0x003C95F2 File Offset: 0x003C77F2
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A82E RID: 108590 RVA: 0x003C9610 File Offset: 0x003C7810
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A82F RID: 108591 RVA: 0x003C9629 File Offset: 0x003C7829
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A830 RID: 108592 RVA: 0x003C9634 File Offset: 0x003C7834
		public static void AddChests(FlatBufferBuilder builder, VectorOffset chestsOffset)
		{
			builder.AddOffset(3, chestsOffset.Value, 0);
		}

		// Token: 0x0601A831 RID: 108593 RVA: 0x003C9644 File Offset: 0x003C7844
		public static VectorOffset CreateChestsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A832 RID: 108594 RVA: 0x003C967B File Offset: 0x003C787B
		public static VectorOffset CreateChestsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A833 RID: 108595 RVA: 0x003C9695 File Offset: 0x003C7895
		public static VectorOffset CreateChestsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A834 RID: 108596 RVA: 0x003C96B3 File Offset: 0x003C78B3
		public static VectorOffset CreateChestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A835 RID: 108597 RVA: 0x003C96CC File Offset: 0x003C78CC
		public static void StartChestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A836 RID: 108598 RVA: 0x003C96D7 File Offset: 0x003C78D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601A837 RID: 108599 RVA: 0x003C96E2 File Offset: 0x003C78E2
		public static Offset<ILevelPlayInfoMappingPunishReport> EndILevelPlayInfoMappingPunishReport(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInfoMappingPunishReport>(builder.EndTable());
		}

		// Token: 0x0601A838 RID: 108600 RVA: 0x003C96F0 File Offset: 0x003C78F0
		public ILevelPlayInfoMappingPunishReportT UnPack()
		{
			ILevelPlayInfoMappingPunishReportT levelPlayInfoMappingPunishReportT = new ILevelPlayInfoMappingPunishReportT();
			this.UnPackTo(levelPlayInfoMappingPunishReportT);
			return levelPlayInfoMappingPunishReportT;
		}

		// Token: 0x0601A839 RID: 108601 RVA: 0x003C970C File Offset: 0x003C790C
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

		// Token: 0x0601A83A RID: 108602 RVA: 0x003C979C File Offset: 0x003C799C
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

		// Token: 0x0400C55B RID: 50523
		private Table __p;
	}
}
