using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FBB RID: 16315
	public struct IShowTimelineCheckpoint : IFlatbufferObject
	{
		// Token: 0x17006E61 RID: 28257
		// (get) Token: 0x0601641B RID: 91163 RVA: 0x00330536 File Offset: 0x0032E736
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601641C RID: 91164 RVA: 0x00330543 File Offset: 0x0032E743
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601641D RID: 91165 RVA: 0x0033054C File Offset: 0x0032E74C
		public static IShowTimelineCheckpoint GetRootAsIShowTimelineCheckpoint(ByteBuffer _bb)
		{
			return IShowTimelineCheckpoint.GetRootAsIShowTimelineCheckpoint(_bb, default(IShowTimelineCheckpoint));
		}

		// Token: 0x0601641E RID: 91166 RVA: 0x00330568 File Offset: 0x0032E768
		public static IShowTimelineCheckpoint GetRootAsIShowTimelineCheckpoint(ByteBuffer _bb, IShowTimelineCheckpoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601641F RID: 91167 RVA: 0x00330585 File Offset: 0x0032E785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016420 RID: 91168 RVA: 0x00330594 File Offset: 0x0032E794
		public IShowTimelineCheckpoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E62 RID: 28258
		// (get) Token: 0x06016421 RID: 91169 RVA: 0x003305A4 File Offset: 0x0032E7A4
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

		// Token: 0x17006E63 RID: 28259
		// (get) Token: 0x06016422 RID: 91170 RVA: 0x003305E0 File Offset: 0x0032E7E0
		public bool IsEnabled
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006E64 RID: 28260
		// (get) Token: 0x06016423 RID: 91171 RVA: 0x00330620 File Offset: 0x0032E820
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

		// Token: 0x17006E65 RID: 28261
		// (get) Token: 0x06016424 RID: 91172 RVA: 0x0033065C File Offset: 0x0032E85C
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

		// Token: 0x06016425 RID: 91173 RVA: 0x0033069C File Offset: 0x0032E89C
		public IShowTimelineRoleState? RoleStates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineRoleState?(default(IShowTimelineRoleState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E66 RID: 28262
		// (get) Token: 0x06016426 RID: 91174 RVA: 0x00330700 File Offset: 0x0032E900
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

		// Token: 0x06016427 RID: 91175 RVA: 0x0033072C File Offset: 0x0032E92C
		public IShowTimelineMonsterState? MonsterStates(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineMonsterState?(default(IShowTimelineMonsterState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E67 RID: 28263
		// (get) Token: 0x06016428 RID: 91176 RVA: 0x00330790 File Offset: 0x0032E990
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

		// Token: 0x17006E68 RID: 28264
		// (get) Token: 0x06016429 RID: 91177 RVA: 0x003307BC File Offset: 0x0032E9BC
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

		// Token: 0x0601642A RID: 91178 RVA: 0x003307FC File Offset: 0x0032E9FC
		public TTable? DisplayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601642B RID: 91179 RVA: 0x00330844 File Offset: 0x0032EA44
		public ICheckpointDisplay DisplayConfigAsICheckpointDisplay()
		{
			return this.DisplayConfig<ICheckpointDisplay>().Value;
		}

		// Token: 0x0601642C RID: 91180 RVA: 0x00330860 File Offset: 0x0032EA60
		public ICheckpointDisplayRole DisplayConfigAsICheckpointDisplayRole()
		{
			return this.DisplayConfig<ICheckpointDisplayRole>().Value;
		}

		// Token: 0x17006E69 RID: 28265
		// (get) Token: 0x0601642D RID: 91181 RVA: 0x0033087C File Offset: 0x0032EA7C
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

		// Token: 0x0601642E RID: 91182 RVA: 0x003308B4 File Offset: 0x0032EAB4
		public Span<byte> GetCustomNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601642F RID: 91183 RVA: 0x003308C4 File Offset: 0x0032EAC4
		public byte[] GetCustomNameArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17006E6A RID: 28266
		// (get) Token: 0x06016430 RID: 91184 RVA: 0x003308D4 File Offset: 0x0032EAD4
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

		// Token: 0x17006E6B RID: 28267
		// (get) Token: 0x06016431 RID: 91185 RVA: 0x00330934 File Offset: 0x0032EB34
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

		// Token: 0x06016432 RID: 91186 RVA: 0x00330994 File Offset: 0x0032EB94
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

		// Token: 0x06016433 RID: 91187 RVA: 0x00330A04 File Offset: 0x0032EC04
		public static void StartIShowTimelineCheckpoint(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06016434 RID: 91188 RVA: 0x00330A0E File Offset: 0x0032EC0E
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016435 RID: 91189 RVA: 0x00330A19 File Offset: 0x0032EC19
		public static void AddIsEnabled(FlatBufferBuilder builder, bool isEnabled)
		{
			builder.AddBool(1, isEnabled, false);
		}

		// Token: 0x06016436 RID: 91190 RVA: 0x00330A24 File Offset: 0x0032EC24
		public static void AddCheckpointId(FlatBufferBuilder builder, int checkpointId)
		{
			builder.AddInt(2, checkpointId, 0);
		}

		// Token: 0x06016437 RID: 91191 RVA: 0x00330A2F File Offset: 0x0032EC2F
		public static void AddActiveRoleId(FlatBufferBuilder builder, int activeRoleId)
		{
			builder.AddInt(3, activeRoleId, 0);
		}

		// Token: 0x06016438 RID: 91192 RVA: 0x00330A3A File Offset: 0x0032EC3A
		public static void AddRoleStates(FlatBufferBuilder builder, VectorOffset roleStatesOffset)
		{
			builder.AddOffset(4, roleStatesOffset.Value, 0);
		}

		// Token: 0x06016439 RID: 91193 RVA: 0x00330A4C File Offset: 0x0032EC4C
		public static VectorOffset CreateRoleStatesVector(FlatBufferBuilder builder, Offset<IShowTimelineRoleState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601643A RID: 91194 RVA: 0x00330A8C File Offset: 0x0032EC8C
		public static VectorOffset CreateRoleStatesVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineRoleState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineRoleState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601643B RID: 91195 RVA: 0x00330AA6 File Offset: 0x0032ECA6
		public static VectorOffset CreateRoleStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineRoleState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineRoleState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601643C RID: 91196 RVA: 0x00330AC4 File Offset: 0x0032ECC4
		public static VectorOffset CreateRoleStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineRoleState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601643D RID: 91197 RVA: 0x00330ADD File Offset: 0x0032ECDD
		public static void StartRoleStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601643E RID: 91198 RVA: 0x00330AE8 File Offset: 0x0032ECE8
		public static void AddMonsterStates(FlatBufferBuilder builder, VectorOffset monsterStatesOffset)
		{
			builder.AddOffset(5, monsterStatesOffset.Value, 0);
		}

		// Token: 0x0601643F RID: 91199 RVA: 0x00330AF8 File Offset: 0x0032ECF8
		public static VectorOffset CreateMonsterStatesVector(FlatBufferBuilder builder, Offset<IShowTimelineMonsterState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016440 RID: 91200 RVA: 0x00330B38 File Offset: 0x0032ED38
		public static VectorOffset CreateMonsterStatesVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineMonsterState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineMonsterState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016441 RID: 91201 RVA: 0x00330B52 File Offset: 0x0032ED52
		public static VectorOffset CreateMonsterStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineMonsterState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineMonsterState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016442 RID: 91202 RVA: 0x00330B70 File Offset: 0x0032ED70
		public static VectorOffset CreateMonsterStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineMonsterState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016443 RID: 91203 RVA: 0x00330B89 File Offset: 0x0032ED89
		public static void StartMonsterStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016444 RID: 91204 RVA: 0x00330B94 File Offset: 0x0032ED94
		public static void AddDisplayConfigType(FlatBufferBuilder builder, ICheckpointDisplay_Union displayConfigType)
		{
			builder.AddByte(6, (byte)displayConfigType, 0);
		}

		// Token: 0x06016445 RID: 91205 RVA: 0x00330B9F File Offset: 0x0032ED9F
		public static void AddDisplayConfig(FlatBufferBuilder builder, int displayConfigOffset)
		{
			builder.AddOffset(7, displayConfigOffset, 0);
		}

		// Token: 0x06016446 RID: 91206 RVA: 0x00330BAA File Offset: 0x0032EDAA
		public static void AddCustomName(FlatBufferBuilder builder, StringOffset customNameOffset)
		{
			builder.AddOffset(8, customNameOffset.Value, 0);
		}

		// Token: 0x06016447 RID: 91207 RVA: 0x00330BBA File Offset: 0x0032EDBA
		public static void AddPlayerPosition(FlatBufferBuilder builder, Offset<IPosA> playerPositionOffset)
		{
			builder.AddOffset(9, playerPositionOffset.Value, 0);
		}

		// Token: 0x06016448 RID: 91208 RVA: 0x00330BCB File Offset: 0x0032EDCB
		public static void AddMonsterPosition(FlatBufferBuilder builder, Offset<IPosA> monsterPositionOffset)
		{
			builder.AddOffset(10, monsterPositionOffset.Value, 0);
		}

		// Token: 0x06016449 RID: 91209 RVA: 0x00330BDC File Offset: 0x0032EDDC
		public static Offset<IShowTimelineCheckpoint> EndIShowTimelineCheckpoint(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineCheckpoint>(builder.EndTable());
		}

		// Token: 0x0601644A RID: 91210 RVA: 0x00330BEC File Offset: 0x0032EDEC
		public IShowTimelineCheckpointT UnPack()
		{
			IShowTimelineCheckpointT showTimelineCheckpointT = new IShowTimelineCheckpointT();
			this.UnPackTo(showTimelineCheckpointT);
			return showTimelineCheckpointT;
		}

		// Token: 0x0601644B RID: 91211 RVA: 0x00330C08 File Offset: 0x0032EE08
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

		// Token: 0x0601644C RID: 91212 RVA: 0x00330DFC File Offset: 0x0032EFFC
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

		// Token: 0x0400BAAF RID: 47791
		private Table __p;
	}
}
