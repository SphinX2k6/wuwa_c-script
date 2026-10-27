using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FD RID: 21757
	public struct ILiftComponent : IFlatbufferObject
	{
		// Token: 0x1700A08D RID: 41101
		// (get) Token: 0x06023EA7 RID: 147111 RVA: 0x004F7196 File Offset: 0x004F5396
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023EA8 RID: 147112 RVA: 0x004F71A3 File Offset: 0x004F53A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023EA9 RID: 147113 RVA: 0x004F71AC File Offset: 0x004F53AC
		public static ILiftComponent GetRootAsILiftComponent(ByteBuffer _bb)
		{
			return ILiftComponent.GetRootAsILiftComponent(_bb, default(ILiftComponent));
		}

		// Token: 0x06023EAA RID: 147114 RVA: 0x004F71C8 File Offset: 0x004F53C8
		public static ILiftComponent GetRootAsILiftComponent(ByteBuffer _bb, ILiftComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023EAB RID: 147115 RVA: 0x004F71E5 File Offset: 0x004F53E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023EAC RID: 147116 RVA: 0x004F71F4 File Offset: 0x004F53F4
		public ILiftComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A08E RID: 41102
		// (get) Token: 0x06023EAD RID: 147117 RVA: 0x004F7204 File Offset: 0x004F5404
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A08F RID: 41103
		// (get) Token: 0x06023EAE RID: 147118 RVA: 0x004F7244 File Offset: 0x004F5444
		public int InitialFloor
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

		// Token: 0x1700A090 RID: 41104
		// (get) Token: 0x06023EAF RID: 147119 RVA: 0x004F7280 File Offset: 0x004F5480
		public bool UseFloorSeqMarkMapping
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A091 RID: 41105
		// (get) Token: 0x06023EB0 RID: 147120 RVA: 0x004F72C0 File Offset: 0x004F54C0
		public ELiftBuffType CustomLiftBuffType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ELiftBuffType.DefaultLiftBuff;
				}
				return (ELiftBuffType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023EB1 RID: 147121 RVA: 0x004F7300 File Offset: 0x004F5500
		public IVectorInfo? StayPositions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A092 RID: 41106
		// (get) Token: 0x06023EB2 RID: 147122 RVA: 0x004F7364 File Offset: 0x004F5564
		public int StayPositionsLength
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

		// Token: 0x1700A093 RID: 41107
		// (get) Token: 0x06023EB3 RID: 147123 RVA: 0x004F7390 File Offset: 0x004F5590
		public IAutoConfig? AutoConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IAutoConfig?(default(IAutoConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A094 RID: 41108
		// (get) Token: 0x06023EB4 RID: 147124 RVA: 0x004F73F0 File Offset: 0x004F55F0
		public int MaxSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A095 RID: 41109
		// (get) Token: 0x06023EB5 RID: 147125 RVA: 0x004F7430 File Offset: 0x004F5630
		public bool UniformMovement
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A096 RID: 41110
		// (get) Token: 0x06023EB6 RID: 147126 RVA: 0x004F7470 File Offset: 0x004F5670
		public float TurnTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A097 RID: 41111
		// (get) Token: 0x06023EB7 RID: 147127 RVA: 0x004F74B4 File Offset: 0x004F56B4
		public IVectorInfo? SafePoint
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A098 RID: 41112
		// (get) Token: 0x06023EB8 RID: 147128 RVA: 0x004F7514 File Offset: 0x004F5714
		public bool IsAffectedByTimeDilation
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A099 RID: 41113
		// (get) Token: 0x06023EB9 RID: 147129 RVA: 0x004F7554 File Offset: 0x004F5754
		public bool IsSendEventOnArrive
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A09A RID: 41114
		// (get) Token: 0x06023EBA RID: 147130 RVA: 0x004F7594 File Offset: 0x004F5794
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023EBB RID: 147131 RVA: 0x004F75D4 File Offset: 0x004F57D4
		public static Offset<ILiftComponent> CreateILiftComponent(FlatBufferBuilder builder, bool Disabled = false, int InitialFloor = 0, bool UseFloorSeqMarkMapping = false, ELiftBuffType CustomLiftBuffType = ELiftBuffType.DefaultLiftBuff, VectorOffset StayPositionsOffset = default(VectorOffset), Offset<IAutoConfig> AutoConfigOffset = default(Offset<IAutoConfig>), int MaxSpeed = 0, bool UniformMovement = false, float TurnTime = 0f, Offset<IVectorInfo> SafePointOffset = default(Offset<IVectorInfo>), bool IsAffectedByTimeDilation = false, bool IsSendEventOnArrive = false, byte NullMask = 0)
		{
			builder.StartTable(13);
			ILiftComponent.AddSafePoint(builder, SafePointOffset);
			ILiftComponent.AddTurnTime(builder, TurnTime);
			ILiftComponent.AddMaxSpeed(builder, MaxSpeed);
			ILiftComponent.AddAutoConfig(builder, AutoConfigOffset);
			ILiftComponent.AddStayPositions(builder, StayPositionsOffset);
			ILiftComponent.AddInitialFloor(builder, InitialFloor);
			ILiftComponent.AddNullMask(builder, NullMask);
			ILiftComponent.AddIsSendEventOnArrive(builder, IsSendEventOnArrive);
			ILiftComponent.AddIsAffectedByTimeDilation(builder, IsAffectedByTimeDilation);
			ILiftComponent.AddUniformMovement(builder, UniformMovement);
			ILiftComponent.AddCustomLiftBuffType(builder, CustomLiftBuffType);
			ILiftComponent.AddUseFloorSeqMarkMapping(builder, UseFloorSeqMarkMapping);
			ILiftComponent.AddDisabled(builder, Disabled);
			return ILiftComponent.EndILiftComponent(builder);
		}

		// Token: 0x06023EBC RID: 147132 RVA: 0x004F7654 File Offset: 0x004F5854
		public static void StartILiftComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06023EBD RID: 147133 RVA: 0x004F765E File Offset: 0x004F585E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023EBE RID: 147134 RVA: 0x004F7669 File Offset: 0x004F5869
		public static void AddInitialFloor(FlatBufferBuilder builder, int initialFloor)
		{
			builder.AddInt(1, initialFloor, 0);
		}

		// Token: 0x06023EBF RID: 147135 RVA: 0x004F7674 File Offset: 0x004F5874
		public static void AddUseFloorSeqMarkMapping(FlatBufferBuilder builder, bool useFloorSeqMarkMapping)
		{
			builder.AddBool(2, useFloorSeqMarkMapping, false);
		}

		// Token: 0x06023EC0 RID: 147136 RVA: 0x004F767F File Offset: 0x004F587F
		public static void AddCustomLiftBuffType(FlatBufferBuilder builder, ELiftBuffType customLiftBuffType)
		{
			builder.AddByte(3, (byte)customLiftBuffType, 0);
		}

		// Token: 0x06023EC1 RID: 147137 RVA: 0x004F768A File Offset: 0x004F588A
		public static void AddStayPositions(FlatBufferBuilder builder, VectorOffset stayPositionsOffset)
		{
			builder.AddOffset(4, stayPositionsOffset.Value, 0);
		}

		// Token: 0x06023EC2 RID: 147138 RVA: 0x004F769C File Offset: 0x004F589C
		public static VectorOffset CreateStayPositionsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023EC3 RID: 147139 RVA: 0x004F76DC File Offset: 0x004F58DC
		public static VectorOffset CreateStayPositionsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023EC4 RID: 147140 RVA: 0x004F76F6 File Offset: 0x004F58F6
		public static VectorOffset CreateStayPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023EC5 RID: 147141 RVA: 0x004F7714 File Offset: 0x004F5914
		public static VectorOffset CreateStayPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023EC6 RID: 147142 RVA: 0x004F772D File Offset: 0x004F592D
		public static void StartStayPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023EC7 RID: 147143 RVA: 0x004F7738 File Offset: 0x004F5938
		public static void AddAutoConfig(FlatBufferBuilder builder, Offset<IAutoConfig> autoConfigOffset)
		{
			builder.AddOffset(5, autoConfigOffset.Value, 0);
		}

		// Token: 0x06023EC8 RID: 147144 RVA: 0x004F7748 File Offset: 0x004F5948
		public static void AddMaxSpeed(FlatBufferBuilder builder, int maxSpeed)
		{
			builder.AddInt(6, maxSpeed, 0);
		}

		// Token: 0x06023EC9 RID: 147145 RVA: 0x004F7753 File Offset: 0x004F5953
		public static void AddUniformMovement(FlatBufferBuilder builder, bool uniformMovement)
		{
			builder.AddBool(7, uniformMovement, false);
		}

		// Token: 0x06023ECA RID: 147146 RVA: 0x004F775E File Offset: 0x004F595E
		public static void AddTurnTime(FlatBufferBuilder builder, float turnTime)
		{
			builder.AddFloat(8, turnTime, 0.0);
		}

		// Token: 0x06023ECB RID: 147147 RVA: 0x004F7771 File Offset: 0x004F5971
		public static void AddSafePoint(FlatBufferBuilder builder, Offset<IVectorInfo> safePointOffset)
		{
			builder.AddOffset(9, safePointOffset.Value, 0);
		}

		// Token: 0x06023ECC RID: 147148 RVA: 0x004F7782 File Offset: 0x004F5982
		public static void AddIsAffectedByTimeDilation(FlatBufferBuilder builder, bool isAffectedByTimeDilation)
		{
			builder.AddBool(10, isAffectedByTimeDilation, false);
		}

		// Token: 0x06023ECD RID: 147149 RVA: 0x004F778E File Offset: 0x004F598E
		public static void AddIsSendEventOnArrive(FlatBufferBuilder builder, bool isSendEventOnArrive)
		{
			builder.AddBool(11, isSendEventOnArrive, false);
		}

		// Token: 0x06023ECE RID: 147150 RVA: 0x004F779A File Offset: 0x004F599A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06023ECF RID: 147151 RVA: 0x004F77A6 File Offset: 0x004F59A6
		public static Offset<ILiftComponent> EndILiftComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILiftComponent>(builder.EndTable());
		}

		// Token: 0x06023ED0 RID: 147152 RVA: 0x004F77B4 File Offset: 0x004F59B4
		public ILiftComponentT UnPack()
		{
			ILiftComponentT liftComponentT = new ILiftComponentT();
			this.UnPackTo(liftComponentT);
			return liftComponentT;
		}

		// Token: 0x06023ED1 RID: 147153 RVA: 0x004F77D0 File Offset: 0x004F59D0
		public void UnPackTo(ILiftComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitialFloor = this.InitialFloor;
			_o.UseFloorSeqMarkMapping = this.UseFloorSeqMarkMapping;
			_o.CustomLiftBuffType = this.CustomLiftBuffType;
			_o.StayPositions = new List<IVectorInfoT>();
			for (int i = 0; i < this.StayPositionsLength; i++)
			{
				_o.StayPositions.Add((this.StayPositions(i) != null) ? this.StayPositions(i).Value.UnPack() : null);
			}
			_o.AutoConfig = ((this.AutoConfig != null) ? this.AutoConfig.Value.UnPack() : null);
			_o.MaxSpeed = this.MaxSpeed;
			_o.UniformMovement = this.UniformMovement;
			_o.TurnTime = this.TurnTime;
			_o.SafePoint = ((this.SafePoint != null) ? this.SafePoint.Value.UnPack() : null);
			_o.IsAffectedByTimeDilation = this.IsAffectedByTimeDilation;
			_o.IsSendEventOnArrive = this.IsSendEventOnArrive;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023ED2 RID: 147154 RVA: 0x004F7908 File Offset: 0x004F5B08
		public static Offset<ILiftComponent> Pack(FlatBufferBuilder builder, ILiftComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftComponent>);
			}
			VectorOffset stayPositionsOffset = default(VectorOffset);
			if (_o.StayPositions != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.StayPositions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.StayPositions[i]);
				}
				stayPositionsOffset = ILiftComponent.CreateStayPositionsVector(builder, array);
			}
			Offset<IAutoConfig> autoConfigOffset = (_o.AutoConfig == null) ? default(Offset<IAutoConfig>) : IAutoConfig.Pack(builder, _o.AutoConfig);
			Offset<IVectorInfo> safePointOffset = (_o.SafePoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SafePoint);
			return ILiftComponent.CreateILiftComponent(builder, _o.Disabled, _o.InitialFloor, _o.UseFloorSeqMarkMapping, _o.CustomLiftBuffType, stayPositionsOffset, autoConfigOffset, _o.MaxSpeed, _o.UniformMovement, _o.TurnTime, safePointOffset, _o.IsAffectedByTimeDilation, _o.IsSendEventOnArrive, _o.NullMask);
		}

		// Token: 0x0400E7E1 RID: 59361
		private Table __p;
	}
}
