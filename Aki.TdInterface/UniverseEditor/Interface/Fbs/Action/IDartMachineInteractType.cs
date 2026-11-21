using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB4 RID: 27572
	public struct IDartMachineInteractType : IFlatbufferObject
	{
		// Token: 0x1700CA43 RID: 51779
		// (get) Token: 0x0602F738 RID: 194360 RVA: 0x00678EFE File Offset: 0x006770FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F739 RID: 194361 RVA: 0x00678F0B File Offset: 0x0067710B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F73A RID: 194362 RVA: 0x00678F14 File Offset: 0x00677114
		public static IDartMachineInteractType GetRootAsIDartMachineInteractType(ByteBuffer _bb)
		{
			return IDartMachineInteractType.GetRootAsIDartMachineInteractType(_bb, default(IDartMachineInteractType));
		}

		// Token: 0x0602F73B RID: 194363 RVA: 0x00678F30 File Offset: 0x00677130
		public static IDartMachineInteractType GetRootAsIDartMachineInteractType(ByteBuffer _bb, IDartMachineInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F73C RID: 194364 RVA: 0x00678F4D File Offset: 0x0067714D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F73D RID: 194365 RVA: 0x00678F5C File Offset: 0x0067715C
		public IDartMachineInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA44 RID: 51780
		// (get) Token: 0x0602F73E RID: 194366 RVA: 0x00678F6C File Offset: 0x0067716C
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

		// Token: 0x0602F73F RID: 194367 RVA: 0x00678FA8 File Offset: 0x006771A8
		public int CanInviteCompetitorIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CA45 RID: 51781
		// (get) Token: 0x0602F740 RID: 194368 RVA: 0x00678FE8 File Offset: 0x006771E8
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

		// Token: 0x0602F741 RID: 194369 RVA: 0x00679013 File Offset: 0x00677213
		public Span<int> GetCanInviteCompetitorIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602F742 RID: 194370 RVA: 0x00679022 File Offset: 0x00677222
		public int[] GetCanInviteCompetitorIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700CA46 RID: 51782
		// (get) Token: 0x0602F743 RID: 194371 RVA: 0x00679030 File Offset: 0x00677230
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

		// Token: 0x1700CA47 RID: 51783
		// (get) Token: 0x0602F744 RID: 194372 RVA: 0x0067906C File Offset: 0x0067726C
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

		// Token: 0x0602F745 RID: 194373 RVA: 0x006790A9 File Offset: 0x006772A9
		public static Offset<IDartMachineInteractType> CreateIDartMachineInteractType(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine, VectorOffset CanInviteCompetitorIdsOffset = default(VectorOffset), int ChampionId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDartMachineInteractType.AddChampionId(builder, ChampionId);
			IDartMachineInteractType.AddCanInviteCompetitorIds(builder, CanInviteCompetitorIdsOffset);
			IDartMachineInteractType.AddNullMask(builder, NullMask);
			IDartMachineInteractType.AddType(builder, Type);
			return IDartMachineInteractType.EndIDartMachineInteractType(builder);
		}

		// Token: 0x0602F746 RID: 194374 RVA: 0x006790D5 File Offset: 0x006772D5
		public static void StartIDartMachineInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F747 RID: 194375 RVA: 0x006790DE File Offset: 0x006772DE
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F748 RID: 194376 RVA: 0x006790E9 File Offset: 0x006772E9
		public static void AddCanInviteCompetitorIds(FlatBufferBuilder builder, VectorOffset canInviteCompetitorIdsOffset)
		{
			builder.AddOffset(1, canInviteCompetitorIdsOffset.Value, 0);
		}

		// Token: 0x0602F749 RID: 194377 RVA: 0x006790FC File Offset: 0x006772FC
		public static VectorOffset CreateCanInviteCompetitorIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F74A RID: 194378 RVA: 0x00679133 File Offset: 0x00677333
		public static VectorOffset CreateCanInviteCompetitorIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F74B RID: 194379 RVA: 0x0067914D File Offset: 0x0067734D
		public static VectorOffset CreateCanInviteCompetitorIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F74C RID: 194380 RVA: 0x0067916B File Offset: 0x0067736B
		public static VectorOffset CreateCanInviteCompetitorIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F74D RID: 194381 RVA: 0x00679184 File Offset: 0x00677384
		public static void StartCanInviteCompetitorIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F74E RID: 194382 RVA: 0x0067918F File Offset: 0x0067738F
		public static void AddChampionId(FlatBufferBuilder builder, int championId)
		{
			builder.AddInt(2, championId, 0);
		}

		// Token: 0x0602F74F RID: 194383 RVA: 0x0067919A File Offset: 0x0067739A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F750 RID: 194384 RVA: 0x006791A5 File Offset: 0x006773A5
		public static Offset<IDartMachineInteractType> EndIDartMachineInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IDartMachineInteractType>(builder.EndTable());
		}

		// Token: 0x0602F751 RID: 194385 RVA: 0x006791B4 File Offset: 0x006773B4
		public IDartMachineInteractTypeT UnPack()
		{
			IDartMachineInteractTypeT dartMachineInteractTypeT = new IDartMachineInteractTypeT();
			this.UnPackTo(dartMachineInteractTypeT);
			return dartMachineInteractTypeT;
		}

		// Token: 0x0602F752 RID: 194386 RVA: 0x006791D0 File Offset: 0x006773D0
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

		// Token: 0x0602F753 RID: 194387 RVA: 0x00679230 File Offset: 0x00677430
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

		// Token: 0x040119AB RID: 72107
		private Table __p;
	}
}
