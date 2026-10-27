using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F26 RID: 16166
	public struct IMechaTrackScoreMechanismState : IFlatbufferObject
	{
		// Token: 0x17007065 RID: 28773
		// (get) Token: 0x06016F40 RID: 94016 RVA: 0x0034FD7A File Offset: 0x0034DF7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F41 RID: 94017 RVA: 0x0034FD87 File Offset: 0x0034DF87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F42 RID: 94018 RVA: 0x0034FD90 File Offset: 0x0034DF90
		public static IMechaTrackScoreMechanismState GetRootAsIMechaTrackScoreMechanismState(ByteBuffer _bb)
		{
			return IMechaTrackScoreMechanismState.GetRootAsIMechaTrackScoreMechanismState(_bb, default(IMechaTrackScoreMechanismState));
		}

		// Token: 0x06016F43 RID: 94019 RVA: 0x0034FDAC File Offset: 0x0034DFAC
		public static IMechaTrackScoreMechanismState GetRootAsIMechaTrackScoreMechanismState(ByteBuffer _bb, IMechaTrackScoreMechanismState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F44 RID: 94020 RVA: 0x0034FDC9 File Offset: 0x0034DFC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F45 RID: 94021 RVA: 0x0034FDD8 File Offset: 0x0034DFD8
		public IMechaTrackScoreMechanismState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007066 RID: 28774
		// (get) Token: 0x06016F46 RID: 94022 RVA: 0x0034FDE8 File Offset: 0x0034DFE8
		public EMechaTrackScoreDetectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechaTrackScoreDetectionType.StuntAction;
				}
				return (EMechaTrackScoreDetectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016F47 RID: 94023 RVA: 0x0034FE24 File Offset: 0x0034E024
		public IMechaTrackScoreMechanismStateType? MechanismStateTypes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismStateType?(default(IMechaTrackScoreMechanismStateType).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007067 RID: 28775
		// (get) Token: 0x06016F48 RID: 94024 RVA: 0x0034FE84 File Offset: 0x0034E084
		public int MechanismStateTypesLength
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

		// Token: 0x06016F49 RID: 94025 RVA: 0x0034FEAF File Offset: 0x0034E0AF
		public static Offset<IMechaTrackScoreMechanismState> CreateIMechaTrackScoreMechanismState(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction, VectorOffset MechanismStateTypesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMechaTrackScoreMechanismState.AddMechanismStateTypes(builder, MechanismStateTypesOffset);
			IMechaTrackScoreMechanismState.AddType(builder, Type);
			return IMechaTrackScoreMechanismState.EndIMechaTrackScoreMechanismState(builder);
		}

		// Token: 0x06016F4A RID: 94026 RVA: 0x0034FECC File Offset: 0x0034E0CC
		public static void StartIMechaTrackScoreMechanismState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016F4B RID: 94027 RVA: 0x0034FED5 File Offset: 0x0034E0D5
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F4C RID: 94028 RVA: 0x0034FEE0 File Offset: 0x0034E0E0
		public static void AddMechanismStateTypes(FlatBufferBuilder builder, VectorOffset mechanismStateTypesOffset)
		{
			builder.AddOffset(1, mechanismStateTypesOffset.Value, 0);
		}

		// Token: 0x06016F4D RID: 94029 RVA: 0x0034FEF0 File Offset: 0x0034E0F0
		public static VectorOffset CreateMechanismStateTypesVector(FlatBufferBuilder builder, Offset<IMechaTrackScoreMechanismStateType>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F4E RID: 94030 RVA: 0x0034FF30 File Offset: 0x0034E130
		public static VectorOffset CreateMechanismStateTypesVectorBlock(FlatBufferBuilder builder, Offset<IMechaTrackScoreMechanismStateType>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMechaTrackScoreMechanismStateType>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F4F RID: 94031 RVA: 0x0034FF4A File Offset: 0x0034E14A
		public static VectorOffset CreateMechanismStateTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMechaTrackScoreMechanismStateType>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMechaTrackScoreMechanismStateType>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F50 RID: 94032 RVA: 0x0034FF68 File Offset: 0x0034E168
		public static VectorOffset CreateMechanismStateTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMechaTrackScoreMechanismStateType>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F51 RID: 94033 RVA: 0x0034FF81 File Offset: 0x0034E181
		public static void StartMechanismStateTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016F52 RID: 94034 RVA: 0x0034FF8C File Offset: 0x0034E18C
		public static Offset<IMechaTrackScoreMechanismState> EndIMechaTrackScoreMechanismState(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreMechanismState>(builder.EndTable());
		}

		// Token: 0x06016F53 RID: 94035 RVA: 0x0034FF9C File Offset: 0x0034E19C
		public IMechaTrackScoreMechanismStateT UnPack()
		{
			IMechaTrackScoreMechanismStateT mechaTrackScoreMechanismStateT = new IMechaTrackScoreMechanismStateT();
			this.UnPackTo(mechaTrackScoreMechanismStateT);
			return mechaTrackScoreMechanismStateT;
		}

		// Token: 0x06016F54 RID: 94036 RVA: 0x0034FFB8 File Offset: 0x0034E1B8
		public void UnPackTo(IMechaTrackScoreMechanismStateT _o)
		{
			_o.Type = this.Type;
			_o.MechanismStateTypes = new List<IMechaTrackScoreMechanismStateTypeT>();
			for (int i = 0; i < this.MechanismStateTypesLength; i++)
			{
				_o.MechanismStateTypes.Add((this.MechanismStateTypes(i) != null) ? this.MechanismStateTypes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016F55 RID: 94037 RVA: 0x00350024 File Offset: 0x0034E224
		public static Offset<IMechaTrackScoreMechanismState> Pack(FlatBufferBuilder builder, IMechaTrackScoreMechanismStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreMechanismState>);
			}
			VectorOffset mechanismStateTypesOffset = default(VectorOffset);
			if (_o.MechanismStateTypes != null)
			{
				Offset<IMechaTrackScoreMechanismStateType>[] array = new Offset<IMechaTrackScoreMechanismStateType>[_o.MechanismStateTypes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMechaTrackScoreMechanismStateType.Pack(builder, _o.MechanismStateTypes[i]);
				}
				mechanismStateTypesOffset = IMechaTrackScoreMechanismState.CreateMechanismStateTypesVector(builder, array);
			}
			return IMechaTrackScoreMechanismState.CreateIMechaTrackScoreMechanismState(builder, _o.Type, mechanismStateTypesOffset);
		}

		// Token: 0x0400B931 RID: 47409
		private Table __p;
	}
}
