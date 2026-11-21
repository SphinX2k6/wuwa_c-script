using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679F RID: 26527
	public struct IAddTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700C0F8 RID: 49400
		// (get) Token: 0x0602CFFF RID: 184319 RVA: 0x006268B0 File Offset: 0x00624AB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D000 RID: 184320 RVA: 0x006268BD File Offset: 0x00624ABD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D001 RID: 184321 RVA: 0x006268C4 File Offset: 0x00624AC4
		public static IAddTrialCharacter GetRootAsIAddTrialCharacter(ByteBuffer _bb)
		{
			return IAddTrialCharacter.GetRootAsIAddTrialCharacter(_bb, default(IAddTrialCharacter));
		}

		// Token: 0x0602D002 RID: 184322 RVA: 0x006268E0 File Offset: 0x00624AE0
		public static IAddTrialCharacter GetRootAsIAddTrialCharacter(ByteBuffer _bb, IAddTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D003 RID: 184323 RVA: 0x006268FD File Offset: 0x00624AFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D004 RID: 184324 RVA: 0x0062690C File Offset: 0x00624B0C
		public IAddTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0F9 RID: 49401
		// (get) Token: 0x0602D005 RID: 184325 RVA: 0x0062691C File Offset: 0x00624B1C
		public bool UseUpdateTrialCharacterLogic
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0FA RID: 49402
		// (get) Token: 0x0602D006 RID: 184326 RVA: 0x0062695C File Offset: 0x00624B5C
		public int CharacterId
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

		// Token: 0x0602D007 RID: 184327 RVA: 0x00626998 File Offset: 0x00624B98
		public int CharacterGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C0FB RID: 49403
		// (get) Token: 0x0602D008 RID: 184328 RVA: 0x006269D8 File Offset: 0x00624BD8
		public int CharacterGroupLength
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

		// Token: 0x0602D009 RID: 184329 RVA: 0x00626A03 File Offset: 0x00624C03
		public Span<int> GetCharacterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602D00A RID: 184330 RVA: 0x00626A12 File Offset: 0x00624C12
		public int[] GetCharacterGroupArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602D00B RID: 184331 RVA: 0x00626A20 File Offset: 0x00624C20
		public ICharacterGroupNew? CharacterGroupNew(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICharacterGroupNew?(default(ICharacterGroupNew).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C0FC RID: 49404
		// (get) Token: 0x0602D00C RID: 184332 RVA: 0x00626A84 File Offset: 0x00624C84
		public int CharacterGroupNewLength
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

		// Token: 0x1700C0FD RID: 49405
		// (get) Token: 0x0602D00D RID: 184333 RVA: 0x00626AB0 File Offset: 0x00624CB0
		public bool AutoChange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0FE RID: 49406
		// (get) Token: 0x0602D00E RID: 184334 RVA: 0x00626AF0 File Offset: 0x00624CF0
		public bool CreateTempTeam
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0FF RID: 49407
		// (get) Token: 0x0602D00F RID: 184335 RVA: 0x00626B30 File Offset: 0x00624D30
		public bool CreateAiCharacter
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C100 RID: 49408
		// (get) Token: 0x0602D010 RID: 184336 RVA: 0x00626B70 File Offset: 0x00624D70
		public IActiveRange? ActiveRange
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IActiveRange?(default(IActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602D011 RID: 184337 RVA: 0x00626BD0 File Offset: 0x00624DD0
		public int EnterRangeEntities(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C101 RID: 49409
		// (get) Token: 0x0602D012 RID: 184338 RVA: 0x00626C10 File Offset: 0x00624E10
		public int EnterRangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602D013 RID: 184339 RVA: 0x00626C3C File Offset: 0x00624E3C
		public Span<int> GetEnterRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0602D014 RID: 184340 RVA: 0x00626C4C File Offset: 0x00624E4C
		public int[] GetEnterRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x1700C102 RID: 49410
		// (get) Token: 0x0602D015 RID: 184341 RVA: 0x00626C5C File Offset: 0x00624E5C
		public bool EnableMapAndTeleport
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D016 RID: 184342 RVA: 0x00626C9C File Offset: 0x00624E9C
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C103 RID: 49411
		// (get) Token: 0x0602D017 RID: 184343 RVA: 0x00626CDC File Offset: 0x00624EDC
		public int DungeonListLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602D018 RID: 184344 RVA: 0x00626D08 File Offset: 0x00624F08
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0602D019 RID: 184345 RVA: 0x00626D18 File Offset: 0x00624F18
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(24);
		}

		// Token: 0x1700C104 RID: 49412
		// (get) Token: 0x0602D01A RID: 184346 RVA: 0x00626D28 File Offset: 0x00624F28
		public bool IsRemoveTips
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C105 RID: 49413
		// (get) Token: 0x0602D01B RID: 184347 RVA: 0x00626D68 File Offset: 0x00624F68
		public TVarRef IsDisableRollBackRestoreCharacterType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D01C RID: 184348 RVA: 0x00626DA8 File Offset: 0x00624FA8
		public TTable? IsDisableRollBackRestoreCharacter<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D01D RID: 184349 RVA: 0x00626DF0 File Offset: 0x00624FF0
		public IConstVarRef IsDisableRollBackRestoreCharacterAsIConstVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IConstVarRef>().Value;
		}

		// Token: 0x0602D01E RID: 184350 RVA: 0x00626E0C File Offset: 0x0062500C
		public IGlobalVarRef IsDisableRollBackRestoreCharacterAsIGlobalVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>().Value;
		}

		// Token: 0x0602D01F RID: 184351 RVA: 0x00626E28 File Offset: 0x00625028
		public IOtherVarRef IsDisableRollBackRestoreCharacterAsIOtherVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IOtherVarRef>().Value;
		}

		// Token: 0x0602D020 RID: 184352 RVA: 0x00626E44 File Offset: 0x00625044
		public ISelfVarRef IsDisableRollBackRestoreCharacterAsISelfVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISelfVarRef>().Value;
		}

		// Token: 0x0602D021 RID: 184353 RVA: 0x00626E60 File Offset: 0x00625060
		public ISystemVarRef IsDisableRollBackRestoreCharacterAsISystemVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISystemVarRef>().Value;
		}

		// Token: 0x1700C106 RID: 49414
		// (get) Token: 0x0602D022 RID: 184354 RVA: 0x00626E7C File Offset: 0x0062507C
		public bool EnableSeamlessTeamSwitch
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C107 RID: 49415
		// (get) Token: 0x0602D023 RID: 184355 RVA: 0x00626EBC File Offset: 0x006250BC
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C108 RID: 49416
		// (get) Token: 0x0602D024 RID: 184356 RVA: 0x00626EFC File Offset: 0x006250FC
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D025 RID: 184357 RVA: 0x00626F3C File Offset: 0x0062513C
		public static Offset<IAddTrialCharacter> CreateIAddTrialCharacter(FlatBufferBuilder builder, bool UseUpdateTrialCharacterLogic = false, int CharacterId = 0, VectorOffset CharacterGroupOffset = default(VectorOffset), VectorOffset CharacterGroupNewOffset = default(VectorOffset), bool AutoChange = false, bool CreateTempTeam = false, bool CreateAiCharacter = false, Offset<IActiveRange> ActiveRangeOffset = default(Offset<IActiveRange>), VectorOffset EnterRangeEntitiesOffset = default(VectorOffset), bool EnableMapAndTeleport = false, VectorOffset DungeonListOffset = default(VectorOffset), bool IsRemoveTips = false, TVarRef IsDisableRollBackRestoreCharacter_type = TVarRef.NONE, int IsDisableRollBackRestoreCharacterOffset = 0, bool EnableSeamlessTeamSwitch = false, bool OnlyLowMemoryDeviceExecute = false, ushort NullMask = 0)
		{
			builder.StartTable(17);
			IAddTrialCharacter.AddIsDisableRollBackRestoreCharacter(builder, IsDisableRollBackRestoreCharacterOffset);
			IAddTrialCharacter.AddDungeonList(builder, DungeonListOffset);
			IAddTrialCharacter.AddEnterRangeEntities(builder, EnterRangeEntitiesOffset);
			IAddTrialCharacter.AddActiveRange(builder, ActiveRangeOffset);
			IAddTrialCharacter.AddCharacterGroupNew(builder, CharacterGroupNewOffset);
			IAddTrialCharacter.AddCharacterGroup(builder, CharacterGroupOffset);
			IAddTrialCharacter.AddCharacterId(builder, CharacterId);
			IAddTrialCharacter.AddNullMask(builder, NullMask);
			IAddTrialCharacter.AddOnlyLowMemoryDeviceExecute(builder, OnlyLowMemoryDeviceExecute);
			IAddTrialCharacter.AddEnableSeamlessTeamSwitch(builder, EnableSeamlessTeamSwitch);
			IAddTrialCharacter.AddIsDisableRollBackRestoreCharacterType(builder, IsDisableRollBackRestoreCharacter_type);
			IAddTrialCharacter.AddIsRemoveTips(builder, IsRemoveTips);
			IAddTrialCharacter.AddEnableMapAndTeleport(builder, EnableMapAndTeleport);
			IAddTrialCharacter.AddCreateAiCharacter(builder, CreateAiCharacter);
			IAddTrialCharacter.AddCreateTempTeam(builder, CreateTempTeam);
			IAddTrialCharacter.AddAutoChange(builder, AutoChange);
			IAddTrialCharacter.AddUseUpdateTrialCharacterLogic(builder, UseUpdateTrialCharacterLogic);
			return IAddTrialCharacter.EndIAddTrialCharacter(builder);
		}

		// Token: 0x0602D026 RID: 184358 RVA: 0x00626FDC File Offset: 0x006251DC
		public static void StartIAddTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602D027 RID: 184359 RVA: 0x00626FE6 File Offset: 0x006251E6
		public static void AddUseUpdateTrialCharacterLogic(FlatBufferBuilder builder, bool useUpdateTrialCharacterLogic)
		{
			builder.AddBool(0, useUpdateTrialCharacterLogic, false);
		}

		// Token: 0x0602D028 RID: 184360 RVA: 0x00626FF1 File Offset: 0x006251F1
		public static void AddCharacterId(FlatBufferBuilder builder, int characterId)
		{
			builder.AddInt(1, characterId, 0);
		}

		// Token: 0x0602D029 RID: 184361 RVA: 0x00626FFC File Offset: 0x006251FC
		public static void AddCharacterGroup(FlatBufferBuilder builder, VectorOffset characterGroupOffset)
		{
			builder.AddOffset(2, characterGroupOffset.Value, 0);
		}

		// Token: 0x0602D02A RID: 184362 RVA: 0x0062700C File Offset: 0x0062520C
		public static VectorOffset CreateCharacterGroupVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D02B RID: 184363 RVA: 0x00627043 File Offset: 0x00625243
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D02C RID: 184364 RVA: 0x0062705D File Offset: 0x0062525D
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D02D RID: 184365 RVA: 0x0062707B File Offset: 0x0062527B
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D02E RID: 184366 RVA: 0x00627094 File Offset: 0x00625294
		public static void StartCharacterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D02F RID: 184367 RVA: 0x0062709F File Offset: 0x0062529F
		public static void AddCharacterGroupNew(FlatBufferBuilder builder, VectorOffset characterGroupNewOffset)
		{
			builder.AddOffset(3, characterGroupNewOffset.Value, 0);
		}

		// Token: 0x0602D030 RID: 184368 RVA: 0x006270B0 File Offset: 0x006252B0
		public static VectorOffset CreateCharacterGroupNewVector(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D031 RID: 184369 RVA: 0x006270F0 File Offset: 0x006252F0
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D032 RID: 184370 RVA: 0x0062710A File Offset: 0x0062530A
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICharacterGroupNew>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D033 RID: 184371 RVA: 0x00627128 File Offset: 0x00625328
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICharacterGroupNew>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D034 RID: 184372 RVA: 0x00627141 File Offset: 0x00625341
		public static void StartCharacterGroupNewVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D035 RID: 184373 RVA: 0x0062714C File Offset: 0x0062534C
		public static void AddAutoChange(FlatBufferBuilder builder, bool autoChange)
		{
			builder.AddBool(4, autoChange, false);
		}

		// Token: 0x0602D036 RID: 184374 RVA: 0x00627157 File Offset: 0x00625357
		public static void AddCreateTempTeam(FlatBufferBuilder builder, bool createTempTeam)
		{
			builder.AddBool(5, createTempTeam, false);
		}

		// Token: 0x0602D037 RID: 184375 RVA: 0x00627162 File Offset: 0x00625362
		public static void AddCreateAiCharacter(FlatBufferBuilder builder, bool createAiCharacter)
		{
			builder.AddBool(6, createAiCharacter, false);
		}

		// Token: 0x0602D038 RID: 184376 RVA: 0x0062716D File Offset: 0x0062536D
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(7, activeRangeOffset.Value, 0);
		}

		// Token: 0x0602D039 RID: 184377 RVA: 0x0062717D File Offset: 0x0062537D
		public static void AddEnterRangeEntities(FlatBufferBuilder builder, VectorOffset enterRangeEntitiesOffset)
		{
			builder.AddOffset(8, enterRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602D03A RID: 184378 RVA: 0x00627190 File Offset: 0x00625390
		public static VectorOffset CreateEnterRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D03B RID: 184379 RVA: 0x006271C7 File Offset: 0x006253C7
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D03C RID: 184380 RVA: 0x006271E1 File Offset: 0x006253E1
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D03D RID: 184381 RVA: 0x006271FF File Offset: 0x006253FF
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D03E RID: 184382 RVA: 0x00627218 File Offset: 0x00625418
		public static void StartEnterRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D03F RID: 184383 RVA: 0x00627223 File Offset: 0x00625423
		public static void AddEnableMapAndTeleport(FlatBufferBuilder builder, bool enableMapAndTeleport)
		{
			builder.AddBool(9, enableMapAndTeleport, false);
		}

		// Token: 0x0602D040 RID: 184384 RVA: 0x0062722F File Offset: 0x0062542F
		public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset)
		{
			builder.AddOffset(10, dungeonListOffset.Value, 0);
		}

		// Token: 0x0602D041 RID: 184385 RVA: 0x00627240 File Offset: 0x00625440
		public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D042 RID: 184386 RVA: 0x00627277 File Offset: 0x00625477
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D043 RID: 184387 RVA: 0x00627291 File Offset: 0x00625491
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D044 RID: 184388 RVA: 0x006272AF File Offset: 0x006254AF
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D045 RID: 184389 RVA: 0x006272C8 File Offset: 0x006254C8
		public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D046 RID: 184390 RVA: 0x006272D3 File Offset: 0x006254D3
		public static void AddIsRemoveTips(FlatBufferBuilder builder, bool isRemoveTips)
		{
			builder.AddBool(11, isRemoveTips, false);
		}

		// Token: 0x0602D047 RID: 184391 RVA: 0x006272DF File Offset: 0x006254DF
		public static void AddIsDisableRollBackRestoreCharacterType(FlatBufferBuilder builder, TVarRef isDisableRollBackRestoreCharacterType)
		{
			builder.AddByte(12, (byte)isDisableRollBackRestoreCharacterType, 0);
		}

		// Token: 0x0602D048 RID: 184392 RVA: 0x006272EB File Offset: 0x006254EB
		public static void AddIsDisableRollBackRestoreCharacter(FlatBufferBuilder builder, int isDisableRollBackRestoreCharacterOffset)
		{
			builder.AddOffset(13, isDisableRollBackRestoreCharacterOffset, 0);
		}

		// Token: 0x0602D049 RID: 184393 RVA: 0x006272F7 File Offset: 0x006254F7
		public static void AddEnableSeamlessTeamSwitch(FlatBufferBuilder builder, bool enableSeamlessTeamSwitch)
		{
			builder.AddBool(14, enableSeamlessTeamSwitch, false);
		}

		// Token: 0x0602D04A RID: 184394 RVA: 0x00627303 File Offset: 0x00625503
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(15, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x0602D04B RID: 184395 RVA: 0x0062730F File Offset: 0x0062550F
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x0602D04C RID: 184396 RVA: 0x0062731B File Offset: 0x0062551B
		public static Offset<IAddTrialCharacter> EndIAddTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IAddTrialCharacter>(builder.EndTable());
		}

		// Token: 0x0602D04D RID: 184397 RVA: 0x00627328 File Offset: 0x00625528
		public IAddTrialCharacterT UnPack()
		{
			IAddTrialCharacterT addTrialCharacterT = new IAddTrialCharacterT();
			this.UnPackTo(addTrialCharacterT);
			return addTrialCharacterT;
		}

		// Token: 0x0602D04E RID: 184398 RVA: 0x00627344 File Offset: 0x00625544
		public void UnPackTo(IAddTrialCharacterT _o)
		{
			_o.UseUpdateTrialCharacterLogic = this.UseUpdateTrialCharacterLogic;
			_o.CharacterId = this.CharacterId;
			_o.CharacterGroup = new List<int>();
			for (int i = 0; i < this.CharacterGroupLength; i++)
			{
				_o.CharacterGroup.Add(this.CharacterGroup(i));
			}
			_o.CharacterGroupNew = new List<ICharacterGroupNewT>();
			for (int j = 0; j < this.CharacterGroupNewLength; j++)
			{
				_o.CharacterGroupNew.Add((this.CharacterGroupNew(j) != null) ? this.CharacterGroupNew(j).Value.UnPack() : null);
			}
			_o.AutoChange = this.AutoChange;
			_o.CreateTempTeam = this.CreateTempTeam;
			_o.CreateAiCharacter = this.CreateAiCharacter;
			_o.ActiveRange = ((this.ActiveRange != null) ? this.ActiveRange.Value.UnPack() : null);
			_o.EnterRangeEntities = new List<int>();
			for (int k = 0; k < this.EnterRangeEntitiesLength; k++)
			{
				_o.EnterRangeEntities.Add(this.EnterRangeEntities(k));
			}
			_o.EnableMapAndTeleport = this.EnableMapAndTeleport;
			_o.DungeonList = new List<int>();
			for (int l = 0; l < this.DungeonListLength; l++)
			{
				_o.DungeonList.Add(this.DungeonList(l));
			}
			_o.IsRemoveTips = this.IsRemoveTips;
			_o.IsDisableRollBackRestoreCharacter = new TVarRefUnion();
			_o.IsDisableRollBackRestoreCharacter.Type = this.IsDisableRollBackRestoreCharacterType;
			switch (this.IsDisableRollBackRestoreCharacterType)
			{
			case TVarRef.IConstVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<IConstVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<IOtherVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<ISelfVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<ISystemVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.EnableSeamlessTeamSwitch = this.EnableSeamlessTeamSwitch;
			_o.OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D04F RID: 184399 RVA: 0x00627648 File Offset: 0x00625848
		public static Offset<IAddTrialCharacter> Pack(FlatBufferBuilder builder, IAddTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTrialCharacter>);
			}
			VectorOffset characterGroupOffset = default(VectorOffset);
			if (_o.CharacterGroup != null)
			{
				int[] data = _o.CharacterGroup.ToArray();
				characterGroupOffset = IAddTrialCharacter.CreateCharacterGroupVector(builder, data);
			}
			VectorOffset characterGroupNewOffset = default(VectorOffset);
			if (_o.CharacterGroupNew != null)
			{
				Offset<ICharacterGroupNew>[] array = new Offset<ICharacterGroupNew>[_o.CharacterGroupNew.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICharacterGroupNew.Pack(builder, _o.CharacterGroupNew[i]);
				}
				characterGroupNewOffset = IAddTrialCharacter.CreateCharacterGroupNewVector(builder, array);
			}
			Offset<IActiveRange> activeRangeOffset = (_o.ActiveRange == null) ? default(Offset<IActiveRange>) : IActiveRange.Pack(builder, _o.ActiveRange);
			VectorOffset enterRangeEntitiesOffset = default(VectorOffset);
			if (_o.EnterRangeEntities != null)
			{
				int[] data2 = _o.EnterRangeEntities.ToArray();
				enterRangeEntitiesOffset = IAddTrialCharacter.CreateEnterRangeEntitiesVector(builder, data2);
			}
			VectorOffset dungeonListOffset = default(VectorOffset);
			if (_o.DungeonList != null)
			{
				int[] data3 = _o.DungeonList.ToArray();
				dungeonListOffset = IAddTrialCharacter.CreateDungeonListVector(builder, data3);
			}
			TVarRef isDisableRollBackRestoreCharacter_type = (_o.IsDisableRollBackRestoreCharacter == null) ? TVarRef.NONE : _o.IsDisableRollBackRestoreCharacter.Type;
			int isDisableRollBackRestoreCharacterOffset = (_o.IsDisableRollBackRestoreCharacter == null) ? 0 : TVarRefUnion.Pack(builder, _o.IsDisableRollBackRestoreCharacter);
			return IAddTrialCharacter.CreateIAddTrialCharacter(builder, _o.UseUpdateTrialCharacterLogic, _o.CharacterId, characterGroupOffset, characterGroupNewOffset, _o.AutoChange, _o.CreateTempTeam, _o.CreateAiCharacter, activeRangeOffset, enterRangeEntitiesOffset, _o.EnableMapAndTeleport, dungeonListOffset, _o.IsRemoveTips, isDisableRollBackRestoreCharacter_type, isDisableRollBackRestoreCharacterOffset, _o.EnableSeamlessTeamSwitch, _o.OnlyLowMemoryDeviceExecute, _o.NullMask);
		}

		// Token: 0x04011322 RID: 70434
		private Table __p;
	}
}
