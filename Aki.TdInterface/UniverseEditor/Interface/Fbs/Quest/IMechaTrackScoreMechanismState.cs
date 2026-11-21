using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004364 RID: 17252
	public struct IMechaTrackScoreMechanismState : IFlatbufferObject
	{
		// Token: 0x17007654 RID: 30292
		// (get) Token: 0x06018598 RID: 99736 RVA: 0x00378FA2 File Offset: 0x003771A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018599 RID: 99737 RVA: 0x00378FAF File Offset: 0x003771AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601859A RID: 99738 RVA: 0x00378FB8 File Offset: 0x003771B8
		public static IMechaTrackScoreMechanismState GetRootAsIMechaTrackScoreMechanismState(ByteBuffer _bb)
		{
			return IMechaTrackScoreMechanismState.GetRootAsIMechaTrackScoreMechanismState(_bb, default(IMechaTrackScoreMechanismState));
		}

		// Token: 0x0601859B RID: 99739 RVA: 0x00378FD4 File Offset: 0x003771D4
		public static IMechaTrackScoreMechanismState GetRootAsIMechaTrackScoreMechanismState(ByteBuffer _bb, IMechaTrackScoreMechanismState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601859C RID: 99740 RVA: 0x00378FF1 File Offset: 0x003771F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601859D RID: 99741 RVA: 0x00379000 File Offset: 0x00377200
		public IMechaTrackScoreMechanismState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007655 RID: 30293
		// (get) Token: 0x0601859E RID: 99742 RVA: 0x00379010 File Offset: 0x00377210
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

		// Token: 0x0601859F RID: 99743 RVA: 0x0037904C File Offset: 0x0037724C
		public IMechaTrackScoreMechanismStateType? MechanismStateTypes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismStateType?(default(IMechaTrackScoreMechanismStateType).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007656 RID: 30294
		// (get) Token: 0x060185A0 RID: 99744 RVA: 0x003790AC File Offset: 0x003772AC
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

		// Token: 0x060185A1 RID: 99745 RVA: 0x003790D7 File Offset: 0x003772D7
		public static Offset<IMechaTrackScoreMechanismState> CreateIMechaTrackScoreMechanismState(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction, VectorOffset MechanismStateTypesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMechaTrackScoreMechanismState.AddMechanismStateTypes(builder, MechanismStateTypesOffset);
			IMechaTrackScoreMechanismState.AddType(builder, Type);
			return IMechaTrackScoreMechanismState.EndIMechaTrackScoreMechanismState(builder);
		}

		// Token: 0x060185A2 RID: 99746 RVA: 0x003790F4 File Offset: 0x003772F4
		public static void StartIMechaTrackScoreMechanismState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060185A3 RID: 99747 RVA: 0x003790FD File Offset: 0x003772FD
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060185A4 RID: 99748 RVA: 0x00379108 File Offset: 0x00377308
		public static void AddMechanismStateTypes(FlatBufferBuilder builder, VectorOffset mechanismStateTypesOffset)
		{
			builder.AddOffset(1, mechanismStateTypesOffset.Value, 0);
		}

		// Token: 0x060185A5 RID: 99749 RVA: 0x00379118 File Offset: 0x00377318
		public static VectorOffset CreateMechanismStateTypesVector(FlatBufferBuilder builder, Offset<IMechaTrackScoreMechanismStateType>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060185A6 RID: 99750 RVA: 0x00379158 File Offset: 0x00377358
		public static VectorOffset CreateMechanismStateTypesVectorBlock(FlatBufferBuilder builder, Offset<IMechaTrackScoreMechanismStateType>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMechaTrackScoreMechanismStateType>>(data);
			return builder.EndVector();
		}

		// Token: 0x060185A7 RID: 99751 RVA: 0x00379172 File Offset: 0x00377372
		public static VectorOffset CreateMechanismStateTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMechaTrackScoreMechanismStateType>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMechaTrackScoreMechanismStateType>>(data);
			return builder.EndVector();
		}

		// Token: 0x060185A8 RID: 99752 RVA: 0x00379190 File Offset: 0x00377390
		public static VectorOffset CreateMechanismStateTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMechaTrackScoreMechanismStateType>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060185A9 RID: 99753 RVA: 0x003791A9 File Offset: 0x003773A9
		public static void StartMechanismStateTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060185AA RID: 99754 RVA: 0x003791B4 File Offset: 0x003773B4
		public static Offset<IMechaTrackScoreMechanismState> EndIMechaTrackScoreMechanismState(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreMechanismState>(builder.EndTable());
		}

		// Token: 0x060185AB RID: 99755 RVA: 0x003791C4 File Offset: 0x003773C4
		public IMechaTrackScoreMechanismStateT UnPack()
		{
			IMechaTrackScoreMechanismStateT mechaTrackScoreMechanismStateT = new IMechaTrackScoreMechanismStateT();
			this.UnPackTo(mechaTrackScoreMechanismStateT);
			return mechaTrackScoreMechanismStateT;
		}

		// Token: 0x060185AC RID: 99756 RVA: 0x003791E0 File Offset: 0x003773E0
		public void UnPackTo(IMechaTrackScoreMechanismStateT _o)
		{
			_o.Type = this.Type;
			_o.MechanismStateTypes = new List<IMechaTrackScoreMechanismStateTypeT>();
			for (int i = 0; i < this.MechanismStateTypesLength; i++)
			{
				_o.MechanismStateTypes.Add((this.MechanismStateTypes(i) != null) ? this.MechanismStateTypes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060185AD RID: 99757 RVA: 0x0037924C File Offset: 0x0037744C
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

		// Token: 0x0400C30E RID: 49934
		private Table __p;
	}
}
