using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A83 RID: 23171
	public struct ILiftComponent : IFlatbufferObject
	{
		// Token: 0x1700A8C7 RID: 43207
		// (get) Token: 0x06025F61 RID: 155489 RVA: 0x005342BA File Offset: 0x005324BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F62 RID: 155490 RVA: 0x005342C7 File Offset: 0x005324C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F63 RID: 155491 RVA: 0x005342D0 File Offset: 0x005324D0
		public static ILiftComponent GetRootAsILiftComponent(ByteBuffer _bb)
		{
			return ILiftComponent.GetRootAsILiftComponent(_bb, default(ILiftComponent));
		}

		// Token: 0x06025F64 RID: 155492 RVA: 0x005342EC File Offset: 0x005324EC
		public static ILiftComponent GetRootAsILiftComponent(ByteBuffer _bb, ILiftComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F65 RID: 155493 RVA: 0x00534309 File Offset: 0x00532509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F66 RID: 155494 RVA: 0x00534318 File Offset: 0x00532518
		public ILiftComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8C8 RID: 43208
		// (get) Token: 0x06025F67 RID: 155495 RVA: 0x00534328 File Offset: 0x00532528
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8C9 RID: 43209
		// (get) Token: 0x06025F68 RID: 155496 RVA: 0x00534368 File Offset: 0x00532568
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

		// Token: 0x1700A8CA RID: 43210
		// (get) Token: 0x06025F69 RID: 155497 RVA: 0x005343A4 File Offset: 0x005325A4
		public bool UseFloorSeqMarkMapping
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8CB RID: 43211
		// (get) Token: 0x06025F6A RID: 155498 RVA: 0x005343E4 File Offset: 0x005325E4
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

		// Token: 0x06025F6B RID: 155499 RVA: 0x00534424 File Offset: 0x00532624
		public IVectorInfo? StayPositions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A8CC RID: 43212
		// (get) Token: 0x06025F6C RID: 155500 RVA: 0x00534488 File Offset: 0x00532688
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

		// Token: 0x1700A8CD RID: 43213
		// (get) Token: 0x06025F6D RID: 155501 RVA: 0x005344B4 File Offset: 0x005326B4
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

		// Token: 0x1700A8CE RID: 43214
		// (get) Token: 0x06025F6E RID: 155502 RVA: 0x00534514 File Offset: 0x00532714
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

		// Token: 0x1700A8CF RID: 43215
		// (get) Token: 0x06025F6F RID: 155503 RVA: 0x00534554 File Offset: 0x00532754
		public bool UniformMovement
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8D0 RID: 43216
		// (get) Token: 0x06025F70 RID: 155504 RVA: 0x00534594 File Offset: 0x00532794
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

		// Token: 0x1700A8D1 RID: 43217
		// (get) Token: 0x06025F71 RID: 155505 RVA: 0x005345D8 File Offset: 0x005327D8
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

		// Token: 0x1700A8D2 RID: 43218
		// (get) Token: 0x06025F72 RID: 155506 RVA: 0x00534638 File Offset: 0x00532838
		public bool IsAffectedByTimeDilation
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8D3 RID: 43219
		// (get) Token: 0x06025F73 RID: 155507 RVA: 0x00534678 File Offset: 0x00532878
		public bool IsSendEventOnArrive
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8D4 RID: 43220
		// (get) Token: 0x06025F74 RID: 155508 RVA: 0x005346B8 File Offset: 0x005328B8
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

		// Token: 0x06025F75 RID: 155509 RVA: 0x005346F8 File Offset: 0x005328F8
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

		// Token: 0x06025F76 RID: 155510 RVA: 0x00534778 File Offset: 0x00532978
		public static void StartILiftComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06025F77 RID: 155511 RVA: 0x00534782 File Offset: 0x00532982
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025F78 RID: 155512 RVA: 0x0053478D File Offset: 0x0053298D
		public static void AddInitialFloor(FlatBufferBuilder builder, int initialFloor)
		{
			builder.AddInt(1, initialFloor, 0);
		}

		// Token: 0x06025F79 RID: 155513 RVA: 0x00534798 File Offset: 0x00532998
		public static void AddUseFloorSeqMarkMapping(FlatBufferBuilder builder, bool useFloorSeqMarkMapping)
		{
			builder.AddBool(2, useFloorSeqMarkMapping, false);
		}

		// Token: 0x06025F7A RID: 155514 RVA: 0x005347A3 File Offset: 0x005329A3
		public static void AddCustomLiftBuffType(FlatBufferBuilder builder, ELiftBuffType customLiftBuffType)
		{
			builder.AddByte(3, (byte)customLiftBuffType, 0);
		}

		// Token: 0x06025F7B RID: 155515 RVA: 0x005347AE File Offset: 0x005329AE
		public static void AddStayPositions(FlatBufferBuilder builder, VectorOffset stayPositionsOffset)
		{
			builder.AddOffset(4, stayPositionsOffset.Value, 0);
		}

		// Token: 0x06025F7C RID: 155516 RVA: 0x005347C0 File Offset: 0x005329C0
		public static VectorOffset CreateStayPositionsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025F7D RID: 155517 RVA: 0x00534800 File Offset: 0x00532A00
		public static VectorOffset CreateStayPositionsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F7E RID: 155518 RVA: 0x0053481A File Offset: 0x00532A1A
		public static VectorOffset CreateStayPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F7F RID: 155519 RVA: 0x00534838 File Offset: 0x00532A38
		public static VectorOffset CreateStayPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025F80 RID: 155520 RVA: 0x00534851 File Offset: 0x00532A51
		public static void StartStayPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025F81 RID: 155521 RVA: 0x0053485C File Offset: 0x00532A5C
		public static void AddAutoConfig(FlatBufferBuilder builder, Offset<IAutoConfig> autoConfigOffset)
		{
			builder.AddOffset(5, autoConfigOffset.Value, 0);
		}

		// Token: 0x06025F82 RID: 155522 RVA: 0x0053486C File Offset: 0x00532A6C
		public static void AddMaxSpeed(FlatBufferBuilder builder, int maxSpeed)
		{
			builder.AddInt(6, maxSpeed, 0);
		}

		// Token: 0x06025F83 RID: 155523 RVA: 0x00534877 File Offset: 0x00532A77
		public static void AddUniformMovement(FlatBufferBuilder builder, bool uniformMovement)
		{
			builder.AddBool(7, uniformMovement, false);
		}

		// Token: 0x06025F84 RID: 155524 RVA: 0x00534882 File Offset: 0x00532A82
		public static void AddTurnTime(FlatBufferBuilder builder, float turnTime)
		{
			builder.AddFloat(8, turnTime, 0.0);
		}

		// Token: 0x06025F85 RID: 155525 RVA: 0x00534895 File Offset: 0x00532A95
		public static void AddSafePoint(FlatBufferBuilder builder, Offset<IVectorInfo> safePointOffset)
		{
			builder.AddOffset(9, safePointOffset.Value, 0);
		}

		// Token: 0x06025F86 RID: 155526 RVA: 0x005348A6 File Offset: 0x00532AA6
		public static void AddIsAffectedByTimeDilation(FlatBufferBuilder builder, bool isAffectedByTimeDilation)
		{
			builder.AddBool(10, isAffectedByTimeDilation, false);
		}

		// Token: 0x06025F87 RID: 155527 RVA: 0x005348B2 File Offset: 0x00532AB2
		public static void AddIsSendEventOnArrive(FlatBufferBuilder builder, bool isSendEventOnArrive)
		{
			builder.AddBool(11, isSendEventOnArrive, false);
		}

		// Token: 0x06025F88 RID: 155528 RVA: 0x005348BE File Offset: 0x00532ABE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06025F89 RID: 155529 RVA: 0x005348CA File Offset: 0x00532ACA
		public static Offset<ILiftComponent> EndILiftComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILiftComponent>(builder.EndTable());
		}

		// Token: 0x06025F8A RID: 155530 RVA: 0x005348D8 File Offset: 0x00532AD8
		public ILiftComponentT UnPack()
		{
			ILiftComponentT liftComponentT = new ILiftComponentT();
			this.UnPackTo(liftComponentT);
			return liftComponentT;
		}

		// Token: 0x06025F8B RID: 155531 RVA: 0x005348F4 File Offset: 0x00532AF4
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

		// Token: 0x06025F8C RID: 155532 RVA: 0x00534A2C File Offset: 0x00532C2C
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

		// Token: 0x0400F412 RID: 62482
		private Table __p;
	}
}
