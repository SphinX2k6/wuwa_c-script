using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006543 RID: 25923
	public struct IDartMachineInteractType : IFlatbufferObject
	{
		// Token: 0x1700C0AC RID: 49324
		// (get) Token: 0x0602CF84 RID: 184196 RVA: 0x0062C852 File Offset: 0x0062AA52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF85 RID: 184197 RVA: 0x0062C85F File Offset: 0x0062AA5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF86 RID: 184198 RVA: 0x0062C868 File Offset: 0x0062AA68
		public static IDartMachineInteractType GetRootAsIDartMachineInteractType(ByteBuffer _bb)
		{
			return IDartMachineInteractType.GetRootAsIDartMachineInteractType(_bb, default(IDartMachineInteractType));
		}

		// Token: 0x0602CF87 RID: 184199 RVA: 0x0062C884 File Offset: 0x0062AA84
		public static IDartMachineInteractType GetRootAsIDartMachineInteractType(ByteBuffer _bb, IDartMachineInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF88 RID: 184200 RVA: 0x0062C8A1 File Offset: 0x0062AAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF89 RID: 184201 RVA: 0x0062C8B0 File Offset: 0x0062AAB0
		public IDartMachineInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0AD RID: 49325
		// (get) Token: 0x0602CF8A RID: 184202 RVA: 0x0062C8C0 File Offset: 0x0062AAC0
		public EDartInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartInteractType.Machine;
				}
				return (EDartInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CF8B RID: 184203 RVA: 0x0062C8FC File Offset: 0x0062AAFC
		public int CanInviteCompetitorIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C0AE RID: 49326
		// (get) Token: 0x0602CF8C RID: 184204 RVA: 0x0062C93C File Offset: 0x0062AB3C
		public int CanInviteCompetitorIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602CF8D RID: 184205 RVA: 0x0062C967 File Offset: 0x0062AB67
		public Span<int> GetCanInviteCompetitorIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602CF8E RID: 184206 RVA: 0x0062C976 File Offset: 0x0062AB76
		public int[] GetCanInviteCompetitorIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C0AF RID: 49327
		// (get) Token: 0x0602CF8F RID: 184207 RVA: 0x0062C984 File Offset: 0x0062AB84
		public int ChampionId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0B0 RID: 49328
		// (get) Token: 0x0602CF90 RID: 184208 RVA: 0x0062C9C0 File Offset: 0x0062ABC0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CF91 RID: 184209 RVA: 0x0062C9FD File Offset: 0x0062ABFD
		public static Offset<IDartMachineInteractType> CreateIDartMachineInteractType(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine, VectorOffset CanInviteCompetitorIdsOffset = default(VectorOffset), int ChampionId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDartMachineInteractType.AddChampionId(builder, ChampionId);
			IDartMachineInteractType.AddCanInviteCompetitorIds(builder, CanInviteCompetitorIdsOffset);
			IDartMachineInteractType.AddNullMask(builder, NullMask);
			IDartMachineInteractType.AddType(builder, Type);
			return IDartMachineInteractType.EndIDartMachineInteractType(builder);
		}

		// Token: 0x0602CF92 RID: 184210 RVA: 0x0062CA29 File Offset: 0x0062AC29
		public static void StartIDartMachineInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CF93 RID: 184211 RVA: 0x0062CA32 File Offset: 0x0062AC32
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF94 RID: 184212 RVA: 0x0062CA3D File Offset: 0x0062AC3D
		public static void AddCanInviteCompetitorIds(FlatBufferBuilder builder, VectorOffset canInviteCompetitorIdsOffset)
		{
			builder.AddOffset(1, canInviteCompetitorIdsOffset.Value, 0);
		}

		// Token: 0x0602CF95 RID: 184213 RVA: 0x0062CA50 File Offset: 0x0062AC50
		public static VectorOffset CreateCanInviteCompetitorIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CF96 RID: 184214 RVA: 0x0062CA87 File Offset: 0x0062AC87
		public static VectorOffset CreateCanInviteCompetitorIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CF97 RID: 184215 RVA: 0x0062CAA1 File Offset: 0x0062ACA1
		public static VectorOffset CreateCanInviteCompetitorIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CF98 RID: 184216 RVA: 0x0062CABF File Offset: 0x0062ACBF
		public static VectorOffset CreateCanInviteCompetitorIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CF99 RID: 184217 RVA: 0x0062CAD8 File Offset: 0x0062ACD8
		public static void StartCanInviteCompetitorIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CF9A RID: 184218 RVA: 0x0062CAE3 File Offset: 0x0062ACE3
		public static void AddChampionId(FlatBufferBuilder builder, int championId)
		{
			builder.AddInt(2, championId, 0);
		}

		// Token: 0x0602CF9B RID: 184219 RVA: 0x0062CAEE File Offset: 0x0062ACEE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CF9C RID: 184220 RVA: 0x0062CAF9 File Offset: 0x0062ACF9
		public static Offset<IDartMachineInteractType> EndIDartMachineInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IDartMachineInteractType>(builder.EndTable());
		}

		// Token: 0x0602CF9D RID: 184221 RVA: 0x0062CB08 File Offset: 0x0062AD08
		public IDartMachineInteractTypeT UnPack()
		{
			IDartMachineInteractTypeT dartMachineInteractTypeT = new IDartMachineInteractTypeT();
			this.UnPackTo(dartMachineInteractTypeT);
			return dartMachineInteractTypeT;
		}

		// Token: 0x0602CF9E RID: 184222 RVA: 0x0062CB24 File Offset: 0x0062AD24
		public void UnPackTo(IDartMachineInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.CanInviteCompetitorIds = new List<int>();
			for (int i = 0; i < this.CanInviteCompetitorIdsLength; i++)
			{
				_o.CanInviteCompetitorIds.Add(this.CanInviteCompetitorIds(i));
			}
			_o.ChampionId = this.ChampionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CF9F RID: 184223 RVA: 0x0062CB84 File Offset: 0x0062AD84
		public static Offset<IDartMachineInteractType> Pack(FlatBufferBuilder builder, IDartMachineInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartMachineInteractType>);
			}
			VectorOffset canInviteCompetitorIdsOffset = default(VectorOffset);
			if (_o.CanInviteCompetitorIds != null)
			{
				int[] data = _o.CanInviteCompetitorIds.ToArray();
				canInviteCompetitorIdsOffset = IDartMachineInteractType.CreateCanInviteCompetitorIdsVector(builder, data);
			}
			return IDartMachineInteractType.CreateIDartMachineInteractType(builder, _o.Type, canInviteCompetitorIdsOffset, _o.ChampionId, _o.NullMask);
		}

		// Token: 0x04010B8F RID: 68495
		private Table __p;
	}
}
