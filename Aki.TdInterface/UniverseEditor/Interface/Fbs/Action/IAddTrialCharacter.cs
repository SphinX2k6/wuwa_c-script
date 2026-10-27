using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200613A RID: 24890
	public struct IAddTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700B788 RID: 46984
		// (get) Token: 0x0602A906 RID: 174342 RVA: 0x005DC6D4 File Offset: 0x005DA8D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A907 RID: 174343 RVA: 0x005DC6E1 File Offset: 0x005DA8E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A908 RID: 174344 RVA: 0x005DC6E8 File Offset: 0x005DA8E8
		public static IAddTrialCharacter GetRootAsIAddTrialCharacter(ByteBuffer _bb)
		{
			return IAddTrialCharacter.GetRootAsIAddTrialCharacter(_bb, default(IAddTrialCharacter));
		}

		// Token: 0x0602A909 RID: 174345 RVA: 0x005DC704 File Offset: 0x005DA904
		public static IAddTrialCharacter GetRootAsIAddTrialCharacter(ByteBuffer _bb, IAddTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A90A RID: 174346 RVA: 0x005DC721 File Offset: 0x005DA921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A90B RID: 174347 RVA: 0x005DC730 File Offset: 0x005DA930
		public IAddTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B789 RID: 46985
		// (get) Token: 0x0602A90C RID: 174348 RVA: 0x005DC740 File Offset: 0x005DA940
		public bool UseUpdateTrialCharacterLogic
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B78A RID: 46986
		// (get) Token: 0x0602A90D RID: 174349 RVA: 0x005DC780 File Offset: 0x005DA980
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

		// Token: 0x0602A90E RID: 174350 RVA: 0x005DC7BC File Offset: 0x005DA9BC
		public int CharacterGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B78B RID: 46987
		// (get) Token: 0x0602A90F RID: 174351 RVA: 0x005DC7FC File Offset: 0x005DA9FC
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

		// Token: 0x0602A910 RID: 174352 RVA: 0x005DC827 File Offset: 0x005DAA27
		public Span<int> GetCharacterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602A911 RID: 174353 RVA: 0x005DC836 File Offset: 0x005DAA36
		public int[] GetCharacterGroupArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602A912 RID: 174354 RVA: 0x005DC844 File Offset: 0x005DAA44
		public ICharacterGroupNew? CharacterGroupNew(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICharacterGroupNew?(default(ICharacterGroupNew).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B78C RID: 46988
		// (get) Token: 0x0602A913 RID: 174355 RVA: 0x005DC8A8 File Offset: 0x005DAAA8
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

		// Token: 0x1700B78D RID: 46989
		// (get) Token: 0x0602A914 RID: 174356 RVA: 0x005DC8D4 File Offset: 0x005DAAD4
		public bool AutoChange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B78E RID: 46990
		// (get) Token: 0x0602A915 RID: 174357 RVA: 0x005DC914 File Offset: 0x005DAB14
		public bool CreateTempTeam
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B78F RID: 46991
		// (get) Token: 0x0602A916 RID: 174358 RVA: 0x005DC954 File Offset: 0x005DAB54
		public bool CreateAiCharacter
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B790 RID: 46992
		// (get) Token: 0x0602A917 RID: 174359 RVA: 0x005DC994 File Offset: 0x005DAB94
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

		// Token: 0x0602A918 RID: 174360 RVA: 0x005DC9F4 File Offset: 0x005DABF4
		public int EnterRangeEntities(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B791 RID: 46993
		// (get) Token: 0x0602A919 RID: 174361 RVA: 0x005DCA34 File Offset: 0x005DAC34
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

		// Token: 0x0602A91A RID: 174362 RVA: 0x005DCA60 File Offset: 0x005DAC60
		public Span<int> GetEnterRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0602A91B RID: 174363 RVA: 0x005DCA70 File Offset: 0x005DAC70
		public int[] GetEnterRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x1700B792 RID: 46994
		// (get) Token: 0x0602A91C RID: 174364 RVA: 0x005DCA80 File Offset: 0x005DAC80
		public bool EnableMapAndTeleport
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602A91D RID: 174365 RVA: 0x005DCAC0 File Offset: 0x005DACC0
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B793 RID: 46995
		// (get) Token: 0x0602A91E RID: 174366 RVA: 0x005DCB00 File Offset: 0x005DAD00
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

		// Token: 0x0602A91F RID: 174367 RVA: 0x005DCB2C File Offset: 0x005DAD2C
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0602A920 RID: 174368 RVA: 0x005DCB3C File Offset: 0x005DAD3C
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(24);
		}

		// Token: 0x1700B794 RID: 46996
		// (get) Token: 0x0602A921 RID: 174369 RVA: 0x005DCB4C File Offset: 0x005DAD4C
		public bool IsRemoveTips
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B795 RID: 46997
		// (get) Token: 0x0602A922 RID: 174370 RVA: 0x005DCB8C File Offset: 0x005DAD8C
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

		// Token: 0x0602A923 RID: 174371 RVA: 0x005DCBCC File Offset: 0x005DADCC
		public TTable? IsDisableRollBackRestoreCharacter<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A924 RID: 174372 RVA: 0x005DCC14 File Offset: 0x005DAE14
		public IConstVarRef IsDisableRollBackRestoreCharacterAsIConstVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IConstVarRef>().Value;
		}

		// Token: 0x0602A925 RID: 174373 RVA: 0x005DCC30 File Offset: 0x005DAE30
		public IGlobalVarRef IsDisableRollBackRestoreCharacterAsIGlobalVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>().Value;
		}

		// Token: 0x0602A926 RID: 174374 RVA: 0x005DCC4C File Offset: 0x005DAE4C
		public IOtherVarRef IsDisableRollBackRestoreCharacterAsIOtherVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IOtherVarRef>().Value;
		}

		// Token: 0x0602A927 RID: 174375 RVA: 0x005DCC68 File Offset: 0x005DAE68
		public ISelfVarRef IsDisableRollBackRestoreCharacterAsISelfVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISelfVarRef>().Value;
		}

		// Token: 0x0602A928 RID: 174376 RVA: 0x005DCC84 File Offset: 0x005DAE84
		public ISystemVarRef IsDisableRollBackRestoreCharacterAsISystemVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISystemVarRef>().Value;
		}

		// Token: 0x1700B796 RID: 46998
		// (get) Token: 0x0602A929 RID: 174377 RVA: 0x005DCCA0 File Offset: 0x005DAEA0
		public bool EnableSeamlessTeamSwitch
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B797 RID: 46999
		// (get) Token: 0x0602A92A RID: 174378 RVA: 0x005DCCE0 File Offset: 0x005DAEE0
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B798 RID: 47000
		// (get) Token: 0x0602A92B RID: 174379 RVA: 0x005DCD20 File Offset: 0x005DAF20
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

		// Token: 0x0602A92C RID: 174380 RVA: 0x005DCD60 File Offset: 0x005DAF60
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

		// Token: 0x0602A92D RID: 174381 RVA: 0x005DCE00 File Offset: 0x005DB000
		public static void StartIAddTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602A92E RID: 174382 RVA: 0x005DCE0A File Offset: 0x005DB00A
		public static void AddUseUpdateTrialCharacterLogic(FlatBufferBuilder builder, bool useUpdateTrialCharacterLogic)
		{
			builder.AddBool(0, useUpdateTrialCharacterLogic, false);
		}

		// Token: 0x0602A92F RID: 174383 RVA: 0x005DCE15 File Offset: 0x005DB015
		public static void AddCharacterId(FlatBufferBuilder builder, int characterId)
		{
			builder.AddInt(1, characterId, 0);
		}

		// Token: 0x0602A930 RID: 174384 RVA: 0x005DCE20 File Offset: 0x005DB020
		public static void AddCharacterGroup(FlatBufferBuilder builder, VectorOffset characterGroupOffset)
		{
			builder.AddOffset(2, characterGroupOffset.Value, 0);
		}

		// Token: 0x0602A931 RID: 174385 RVA: 0x005DCE30 File Offset: 0x005DB030
		public static VectorOffset CreateCharacterGroupVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A932 RID: 174386 RVA: 0x005DCE67 File Offset: 0x005DB067
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A933 RID: 174387 RVA: 0x005DCE81 File Offset: 0x005DB081
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A934 RID: 174388 RVA: 0x005DCE9F File Offset: 0x005DB09F
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A935 RID: 174389 RVA: 0x005DCEB8 File Offset: 0x005DB0B8
		public static void StartCharacterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A936 RID: 174390 RVA: 0x005DCEC3 File Offset: 0x005DB0C3
		public static void AddCharacterGroupNew(FlatBufferBuilder builder, VectorOffset characterGroupNewOffset)
		{
			builder.AddOffset(3, characterGroupNewOffset.Value, 0);
		}

		// Token: 0x0602A937 RID: 174391 RVA: 0x005DCED4 File Offset: 0x005DB0D4
		public static VectorOffset CreateCharacterGroupNewVector(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A938 RID: 174392 RVA: 0x005DCF14 File Offset: 0x005DB114
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A939 RID: 174393 RVA: 0x005DCF2E File Offset: 0x005DB12E
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICharacterGroupNew>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A93A RID: 174394 RVA: 0x005DCF4C File Offset: 0x005DB14C
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICharacterGroupNew>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A93B RID: 174395 RVA: 0x005DCF65 File Offset: 0x005DB165
		public static void StartCharacterGroupNewVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A93C RID: 174396 RVA: 0x005DCF70 File Offset: 0x005DB170
		public static void AddAutoChange(FlatBufferBuilder builder, bool autoChange)
		{
			builder.AddBool(4, autoChange, false);
		}

		// Token: 0x0602A93D RID: 174397 RVA: 0x005DCF7B File Offset: 0x005DB17B
		public static void AddCreateTempTeam(FlatBufferBuilder builder, bool createTempTeam)
		{
			builder.AddBool(5, createTempTeam, false);
		}

		// Token: 0x0602A93E RID: 174398 RVA: 0x005DCF86 File Offset: 0x005DB186
		public static void AddCreateAiCharacter(FlatBufferBuilder builder, bool createAiCharacter)
		{
			builder.AddBool(6, createAiCharacter, false);
		}

		// Token: 0x0602A93F RID: 174399 RVA: 0x005DCF91 File Offset: 0x005DB191
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(7, activeRangeOffset.Value, 0);
		}

		// Token: 0x0602A940 RID: 174400 RVA: 0x005DCFA1 File Offset: 0x005DB1A1
		public static void AddEnterRangeEntities(FlatBufferBuilder builder, VectorOffset enterRangeEntitiesOffset)
		{
			builder.AddOffset(8, enterRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602A941 RID: 174401 RVA: 0x005DCFB4 File Offset: 0x005DB1B4
		public static VectorOffset CreateEnterRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A942 RID: 174402 RVA: 0x005DCFEB File Offset: 0x005DB1EB
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A943 RID: 174403 RVA: 0x005DD005 File Offset: 0x005DB205
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A944 RID: 174404 RVA: 0x005DD023 File Offset: 0x005DB223
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A945 RID: 174405 RVA: 0x005DD03C File Offset: 0x005DB23C
		public static void StartEnterRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A946 RID: 174406 RVA: 0x005DD047 File Offset: 0x005DB247
		public static void AddEnableMapAndTeleport(FlatBufferBuilder builder, bool enableMapAndTeleport)
		{
			builder.AddBool(9, enableMapAndTeleport, false);
		}

		// Token: 0x0602A947 RID: 174407 RVA: 0x005DD053 File Offset: 0x005DB253
		public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset)
		{
			builder.AddOffset(10, dungeonListOffset.Value, 0);
		}

		// Token: 0x0602A948 RID: 174408 RVA: 0x005DD064 File Offset: 0x005DB264
		public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A949 RID: 174409 RVA: 0x005DD09B File Offset: 0x005DB29B
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A94A RID: 174410 RVA: 0x005DD0B5 File Offset: 0x005DB2B5
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A94B RID: 174411 RVA: 0x005DD0D3 File Offset: 0x005DB2D3
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A94C RID: 174412 RVA: 0x005DD0EC File Offset: 0x005DB2EC
		public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A94D RID: 174413 RVA: 0x005DD0F7 File Offset: 0x005DB2F7
		public static void AddIsRemoveTips(FlatBufferBuilder builder, bool isRemoveTips)
		{
			builder.AddBool(11, isRemoveTips, false);
		}

		// Token: 0x0602A94E RID: 174414 RVA: 0x005DD103 File Offset: 0x005DB303
		public static void AddIsDisableRollBackRestoreCharacterType(FlatBufferBuilder builder, TVarRef isDisableRollBackRestoreCharacterType)
		{
			builder.AddByte(12, (byte)isDisableRollBackRestoreCharacterType, 0);
		}

		// Token: 0x0602A94F RID: 174415 RVA: 0x005DD10F File Offset: 0x005DB30F
		public static void AddIsDisableRollBackRestoreCharacter(FlatBufferBuilder builder, int isDisableRollBackRestoreCharacterOffset)
		{
			builder.AddOffset(13, isDisableRollBackRestoreCharacterOffset, 0);
		}

		// Token: 0x0602A950 RID: 174416 RVA: 0x005DD11B File Offset: 0x005DB31B
		public static void AddEnableSeamlessTeamSwitch(FlatBufferBuilder builder, bool enableSeamlessTeamSwitch)
		{
			builder.AddBool(14, enableSeamlessTeamSwitch, false);
		}

		// Token: 0x0602A951 RID: 174417 RVA: 0x005DD127 File Offset: 0x005DB327
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(15, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x0602A952 RID: 174418 RVA: 0x005DD133 File Offset: 0x005DB333
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x0602A953 RID: 174419 RVA: 0x005DD13F File Offset: 0x005DB33F
		public static Offset<IAddTrialCharacter> EndIAddTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IAddTrialCharacter>(builder.EndTable());
		}

		// Token: 0x0602A954 RID: 174420 RVA: 0x005DD14C File Offset: 0x005DB34C
		public IAddTrialCharacterT UnPack()
		{
			IAddTrialCharacterT addTrialCharacterT = new IAddTrialCharacterT();
			this.UnPackTo(addTrialCharacterT);
			return addTrialCharacterT;
		}

		// Token: 0x0602A955 RID: 174421 RVA: 0x005DD168 File Offset: 0x005DB368
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

		// Token: 0x0602A956 RID: 174422 RVA: 0x005DD46C File Offset: 0x005DB66C
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

		// Token: 0x0401051B RID: 66843
		private Table __p;
	}
}
