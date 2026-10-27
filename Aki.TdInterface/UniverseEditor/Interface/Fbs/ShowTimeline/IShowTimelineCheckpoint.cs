using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB3 RID: 15283
	public struct IShowTimelineCheckpoint : IFlatbufferObject
	{
		// Token: 0x170068BE RID: 26814
		// (get) Token: 0x06014F43 RID: 85827 RVA: 0x00309CDA File Offset: 0x00307EDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014F44 RID: 85828 RVA: 0x00309CE7 File Offset: 0x00307EE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014F45 RID: 85829 RVA: 0x00309CF0 File Offset: 0x00307EF0
		public static IShowTimelineCheckpoint GetRootAsIShowTimelineCheckpoint(ByteBuffer _bb)
		{
			return IShowTimelineCheckpoint.GetRootAsIShowTimelineCheckpoint(_bb, default(IShowTimelineCheckpoint));
		}

		// Token: 0x06014F46 RID: 85830 RVA: 0x00309D0C File Offset: 0x00307F0C
		public static IShowTimelineCheckpoint GetRootAsIShowTimelineCheckpoint(ByteBuffer _bb, IShowTimelineCheckpoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014F47 RID: 85831 RVA: 0x00309D29 File Offset: 0x00307F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014F48 RID: 85832 RVA: 0x00309D38 File Offset: 0x00307F38
		public IShowTimelineCheckpoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068BF RID: 26815
		// (get) Token: 0x06014F49 RID: 85833 RVA: 0x00309D48 File Offset: 0x00307F48
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170068C0 RID: 26816
		// (get) Token: 0x06014F4A RID: 85834 RVA: 0x00309D84 File Offset: 0x00307F84
		public bool IsEnabled
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170068C1 RID: 26817
		// (get) Token: 0x06014F4B RID: 85835 RVA: 0x00309DC4 File Offset: 0x00307FC4
		public int CheckpointId
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

		// Token: 0x170068C2 RID: 26818
		// (get) Token: 0x06014F4C RID: 85836 RVA: 0x00309E00 File Offset: 0x00308000
		public int ActiveRoleId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014F4D RID: 85837 RVA: 0x00309E40 File Offset: 0x00308040
		public IShowTimelineRoleState? RoleStates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineRoleState?(default(IShowTimelineRoleState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170068C3 RID: 26819
		// (get) Token: 0x06014F4E RID: 85838 RVA: 0x00309EA4 File Offset: 0x003080A4
		public int RoleStatesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06014F4F RID: 85839 RVA: 0x00309ED0 File Offset: 0x003080D0
		public IShowTimelineMonsterState? MonsterStates(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineMonsterState?(default(IShowTimelineMonsterState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170068C4 RID: 26820
		// (get) Token: 0x06014F50 RID: 85840 RVA: 0x00309F34 File Offset: 0x00308134
		public int MonsterStatesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170068C5 RID: 26821
		// (get) Token: 0x06014F51 RID: 85841 RVA: 0x00309F60 File Offset: 0x00308160
		public ICheckpointDisplay_Union DisplayConfigType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ICheckpointDisplay_Union.NONE;
				}
				return (ICheckpointDisplay_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014F52 RID: 85842 RVA: 0x00309FA0 File Offset: 0x003081A0
		public TTable? DisplayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014F53 RID: 85843 RVA: 0x00309FE8 File Offset: 0x003081E8
		public ICheckpointDisplay DisplayConfigAsICheckpointDisplay()
		{
			return this.DisplayConfig<ICheckpointDisplay>().Value;
		}

		// Token: 0x06014F54 RID: 85844 RVA: 0x0030A004 File Offset: 0x00308204
		public ICheckpointDisplayRole DisplayConfigAsICheckpointDisplayRole()
		{
			return this.DisplayConfig<ICheckpointDisplayRole>().Value;
		}

		// Token: 0x170068C6 RID: 26822
		// (get) Token: 0x06014F55 RID: 85845 RVA: 0x0030A020 File Offset: 0x00308220
		public string CustomName
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014F56 RID: 85846 RVA: 0x0030A058 File Offset: 0x00308258
		public Span<byte> GetCustomNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06014F57 RID: 85847 RVA: 0x0030A068 File Offset: 0x00308268
		public byte[] GetCustomNameArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x170068C7 RID: 26823
		// (get) Token: 0x06014F58 RID: 85848 RVA: 0x0030A078 File Offset: 0x00308278
		public IPosA? PlayerPosition
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170068C8 RID: 26824
		// (get) Token: 0x06014F59 RID: 85849 RVA: 0x0030A0D8 File Offset: 0x003082D8
		public IPosA? MonsterPosition
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06014F5A RID: 85850 RVA: 0x0030A138 File Offset: 0x00308338
		public static Offset<IShowTimelineCheckpoint> CreateIShowTimelineCheckpoint(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, bool IsEnabled = false, int CheckpointId = 0, int ActiveRoleId = 0, VectorOffset RoleStatesOffset = default(VectorOffset), VectorOffset MonsterStatesOffset = default(VectorOffset), ICheckpointDisplay_Union DisplayConfig_type = ICheckpointDisplay_Union.NONE, int DisplayConfigOffset = 0, StringOffset CustomNameOffset = default(StringOffset), Offset<IPosA> PlayerPositionOffset = default(Offset<IPosA>), Offset<IPosA> MonsterPositionOffset = default(Offset<IPosA>))
		{
			builder.StartTable(11);
			IShowTimelineCheckpoint.AddMonsterPosition(builder, MonsterPositionOffset);
			IShowTimelineCheckpoint.AddPlayerPosition(builder, PlayerPositionOffset);
			IShowTimelineCheckpoint.AddCustomName(builder, CustomNameOffset);
			IShowTimelineCheckpoint.AddDisplayConfig(builder, DisplayConfigOffset);
			IShowTimelineCheckpoint.AddMonsterStates(builder, MonsterStatesOffset);
			IShowTimelineCheckpoint.AddRoleStates(builder, RoleStatesOffset);
			IShowTimelineCheckpoint.AddActiveRoleId(builder, ActiveRoleId);
			IShowTimelineCheckpoint.AddCheckpointId(builder, CheckpointId);
			IShowTimelineCheckpoint.AddDisplayConfigType(builder, DisplayConfig_type);
			IShowTimelineCheckpoint.AddIsEnabled(builder, IsEnabled);
			IShowTimelineCheckpoint.AddType(builder, Type);
			return IShowTimelineCheckpoint.EndIShowTimelineCheckpoint(builder);
		}

		// Token: 0x06014F5B RID: 85851 RVA: 0x0030A1A8 File Offset: 0x003083A8
		public static void StartIShowTimelineCheckpoint(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06014F5C RID: 85852 RVA: 0x0030A1B2 File Offset: 0x003083B2
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014F5D RID: 85853 RVA: 0x0030A1BD File Offset: 0x003083BD
		public static void AddIsEnabled(FlatBufferBuilder builder, bool isEnabled)
		{
			builder.AddBool(1, isEnabled, false);
		}

		// Token: 0x06014F5E RID: 85854 RVA: 0x0030A1C8 File Offset: 0x003083C8
		public static void AddCheckpointId(FlatBufferBuilder builder, int checkpointId)
		{
			builder.AddInt(2, checkpointId, 0);
		}

		// Token: 0x06014F5F RID: 85855 RVA: 0x0030A1D3 File Offset: 0x003083D3
		public static void AddActiveRoleId(FlatBufferBuilder builder, int activeRoleId)
		{
			builder.AddInt(3, activeRoleId, 0);
		}

		// Token: 0x06014F60 RID: 85856 RVA: 0x0030A1DE File Offset: 0x003083DE
		public static void AddRoleStates(FlatBufferBuilder builder, VectorOffset roleStatesOffset)
		{
			builder.AddOffset(4, roleStatesOffset.Value, 0);
		}

		// Token: 0x06014F61 RID: 85857 RVA: 0x0030A1F0 File Offset: 0x003083F0
		public static VectorOffset CreateRoleStatesVector(FlatBufferBuilder builder, Offset<IShowTimelineRoleState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014F62 RID: 85858 RVA: 0x0030A230 File Offset: 0x00308430
		public static VectorOffset CreateRoleStatesVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineRoleState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineRoleState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014F63 RID: 85859 RVA: 0x0030A24A File Offset: 0x0030844A
		public static VectorOffset CreateRoleStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineRoleState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineRoleState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014F64 RID: 85860 RVA: 0x0030A268 File Offset: 0x00308468
		public static VectorOffset CreateRoleStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineRoleState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014F65 RID: 85861 RVA: 0x0030A281 File Offset: 0x00308481
		public static void StartRoleStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014F66 RID: 85862 RVA: 0x0030A28C File Offset: 0x0030848C
		public static void AddMonsterStates(FlatBufferBuilder builder, VectorOffset monsterStatesOffset)
		{
			builder.AddOffset(5, monsterStatesOffset.Value, 0);
		}

		// Token: 0x06014F67 RID: 85863 RVA: 0x0030A29C File Offset: 0x0030849C
		public static VectorOffset CreateMonsterStatesVector(FlatBufferBuilder builder, Offset<IShowTimelineMonsterState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014F68 RID: 85864 RVA: 0x0030A2DC File Offset: 0x003084DC
		public static VectorOffset CreateMonsterStatesVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineMonsterState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineMonsterState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014F69 RID: 85865 RVA: 0x0030A2F6 File Offset: 0x003084F6
		public static VectorOffset CreateMonsterStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineMonsterState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineMonsterState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014F6A RID: 85866 RVA: 0x0030A314 File Offset: 0x00308514
		public static VectorOffset CreateMonsterStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineMonsterState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014F6B RID: 85867 RVA: 0x0030A32D File Offset: 0x0030852D
		public static void StartMonsterStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014F6C RID: 85868 RVA: 0x0030A338 File Offset: 0x00308538
		public static void AddDisplayConfigType(FlatBufferBuilder builder, ICheckpointDisplay_Union displayConfigType)
		{
			builder.AddByte(6, (byte)displayConfigType, 0);
		}

		// Token: 0x06014F6D RID: 85869 RVA: 0x0030A343 File Offset: 0x00308543
		public static void AddDisplayConfig(FlatBufferBuilder builder, int displayConfigOffset)
		{
			builder.AddOffset(7, displayConfigOffset, 0);
		}

		// Token: 0x06014F6E RID: 85870 RVA: 0x0030A34E File Offset: 0x0030854E
		public static void AddCustomName(FlatBufferBuilder builder, StringOffset customNameOffset)
		{
			builder.AddOffset(8, customNameOffset.Value, 0);
		}

		// Token: 0x06014F6F RID: 85871 RVA: 0x0030A35E File Offset: 0x0030855E
		public static void AddPlayerPosition(FlatBufferBuilder builder, Offset<IPosA> playerPositionOffset)
		{
			builder.AddOffset(9, playerPositionOffset.Value, 0);
		}

		// Token: 0x06014F70 RID: 85872 RVA: 0x0030A36F File Offset: 0x0030856F
		public static void AddMonsterPosition(FlatBufferBuilder builder, Offset<IPosA> monsterPositionOffset)
		{
			builder.AddOffset(10, monsterPositionOffset.Value, 0);
		}

		// Token: 0x06014F71 RID: 85873 RVA: 0x0030A380 File Offset: 0x00308580
		public static Offset<IShowTimelineCheckpoint> EndIShowTimelineCheckpoint(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineCheckpoint>(builder.EndTable());
		}

		// Token: 0x06014F72 RID: 85874 RVA: 0x0030A390 File Offset: 0x00308590
		public IShowTimelineCheckpointT UnPack()
		{
			IShowTimelineCheckpointT showTimelineCheckpointT = new IShowTimelineCheckpointT();
			this.UnPackTo(showTimelineCheckpointT);
			return showTimelineCheckpointT;
		}

		// Token: 0x06014F73 RID: 85875 RVA: 0x0030A3AC File Offset: 0x003085AC
		public void UnPackTo(IShowTimelineCheckpointT _o)
		{
			_o.Type = this.Type;
			_o.IsEnabled = this.IsEnabled;
			_o.CheckpointId = this.CheckpointId;
			_o.ActiveRoleId = this.ActiveRoleId;
			_o.RoleStates = new List<IShowTimelineRoleStateT>();
			for (int i = 0; i < this.RoleStatesLength; i++)
			{
				_o.RoleStates.Add((this.RoleStates(i) != null) ? this.RoleStates(i).Value.UnPack() : null);
			}
			_o.MonsterStates = new List<IShowTimelineMonsterStateT>();
			for (int j = 0; j < this.MonsterStatesLength; j++)
			{
				_o.MonsterStates.Add((this.MonsterStates(j) != null) ? this.MonsterStates(j).Value.UnPack() : null);
			}
			_o.DisplayConfig = new ICheckpointDisplay_UnionUnion();
			_o.DisplayConfig.Type = this.DisplayConfigType;
			ICheckpointDisplay_Union displayConfigType = this.DisplayConfigType;
			if (displayConfigType != ICheckpointDisplay_Union.ICheckpointDisplay)
			{
				if (displayConfigType == ICheckpointDisplay_Union.ICheckpointDisplayRole)
				{
					_o.DisplayConfig.Value = ((this.DisplayConfig<ICheckpointDisplayRole>() != null) ? this.DisplayConfig<ICheckpointDisplayRole>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DisplayConfig.Value = ((this.DisplayConfig<ICheckpointDisplay>() != null) ? this.DisplayConfig<ICheckpointDisplay>().Value.UnPack() : null);
			}
			_o.CustomName = this.CustomName;
			_o.PlayerPosition = ((this.PlayerPosition != null) ? this.PlayerPosition.Value.UnPack() : null);
			_o.MonsterPosition = ((this.MonsterPosition != null) ? this.MonsterPosition.Value.UnPack() : null);
		}

		// Token: 0x06014F74 RID: 85876 RVA: 0x0030A5A0 File Offset: 0x003087A0
		public static Offset<IShowTimelineCheckpoint> Pack(FlatBufferBuilder builder, IShowTimelineCheckpointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineCheckpoint>);
			}
			VectorOffset roleStatesOffset = default(VectorOffset);
			if (_o.RoleStates != null)
			{
				Offset<IShowTimelineRoleState>[] array = new Offset<IShowTimelineRoleState>[_o.RoleStates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IShowTimelineRoleState.Pack(builder, _o.RoleStates[i]);
				}
				roleStatesOffset = IShowTimelineCheckpoint.CreateRoleStatesVector(builder, array);
			}
			VectorOffset monsterStatesOffset = default(VectorOffset);
			if (_o.MonsterStates != null)
			{
				Offset<IShowTimelineMonsterState>[] array2 = new Offset<IShowTimelineMonsterState>[_o.MonsterStates.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IShowTimelineMonsterState.Pack(builder, _o.MonsterStates[j]);
				}
				monsterStatesOffset = IShowTimelineCheckpoint.CreateMonsterStatesVector(builder, array2);
			}
			ICheckpointDisplay_Union displayConfig_type = (_o.DisplayConfig == null) ? ICheckpointDisplay_Union.NONE : _o.DisplayConfig.Type;
			int displayConfigOffset = (_o.DisplayConfig == null) ? 0 : ICheckpointDisplay_UnionUnion.Pack(builder, _o.DisplayConfig);
			StringOffset customNameOffset = (_o.CustomName == null) ? default(StringOffset) : builder.CreateString(_o.CustomName);
			Offset<IPosA> playerPositionOffset = (_o.PlayerPosition == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.PlayerPosition);
			Offset<IPosA> monsterPositionOffset = (_o.MonsterPosition == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.MonsterPosition);
			return IShowTimelineCheckpoint.CreateIShowTimelineCheckpoint(builder, _o.Type, _o.IsEnabled, _o.CheckpointId, _o.ActiveRoleId, roleStatesOffset, monsterStatesOffset, displayConfig_type, displayConfigOffset, customNameOffset, playerPositionOffset, monsterPositionOffset);
		}

		// Token: 0x0400B130 RID: 45360
		private Table __p;
	}
}
