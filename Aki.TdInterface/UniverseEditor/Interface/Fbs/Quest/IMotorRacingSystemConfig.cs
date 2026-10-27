using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F4A RID: 16202
	public struct IMotorRacingSystemConfig : IFlatbufferObject
	{
		// Token: 0x170070AB RID: 28843
		// (get) Token: 0x0601708A RID: 94346 RVA: 0x00352538 File Offset: 0x00350738
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601708B RID: 94347 RVA: 0x00352545 File Offset: 0x00350745
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601708C RID: 94348 RVA: 0x0035254C File Offset: 0x0035074C
		public static IMotorRacingSystemConfig GetRootAsIMotorRacingSystemConfig(ByteBuffer _bb)
		{
			return IMotorRacingSystemConfig.GetRootAsIMotorRacingSystemConfig(_bb, default(IMotorRacingSystemConfig));
		}

		// Token: 0x0601708D RID: 94349 RVA: 0x00352568 File Offset: 0x00350768
		public static IMotorRacingSystemConfig GetRootAsIMotorRacingSystemConfig(ByteBuffer _bb, IMotorRacingSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601708E RID: 94350 RVA: 0x00352585 File Offset: 0x00350785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601708F RID: 94351 RVA: 0x00352594 File Offset: 0x00350794
		public IMotorRacingSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070AC RID: 28844
		// (get) Token: 0x06017090 RID: 94352 RVA: 0x003525A4 File Offset: 0x003507A4
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070AD RID: 28845
		// (get) Token: 0x06017091 RID: 94353 RVA: 0x003525E0 File Offset: 0x003507E0
		public int MotorParkourId
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

		// Token: 0x06017092 RID: 94354 RVA: 0x0035261C File Offset: 0x0035081C
		public IMotorParkourSystemVar? SystemVars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMotorParkourSystemVar?(default(IMotorParkourSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170070AE RID: 28846
		// (get) Token: 0x06017093 RID: 94355 RVA: 0x0035267C File Offset: 0x0035087C
		public int SystemVarsLength
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

		// Token: 0x06017094 RID: 94356 RVA: 0x003526A7 File Offset: 0x003508A7
		public static Offset<IMotorRacingSystemConfig> CreateIMotorRacingSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int MotorParkourId = 0, VectorOffset SystemVarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IMotorRacingSystemConfig.AddSystemVars(builder, SystemVarsOffset);
			IMotorRacingSystemConfig.AddMotorParkourId(builder, MotorParkourId);
			IMotorRacingSystemConfig.AddType(builder, Type);
			return IMotorRacingSystemConfig.EndIMotorRacingSystemConfig(builder);
		}

		// Token: 0x06017095 RID: 94357 RVA: 0x003526CB File Offset: 0x003508CB
		public static void StartIMotorRacingSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017096 RID: 94358 RVA: 0x003526D4 File Offset: 0x003508D4
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017097 RID: 94359 RVA: 0x003526DF File Offset: 0x003508DF
		public static void AddMotorParkourId(FlatBufferBuilder builder, int motorParkourId)
		{
			builder.AddInt(1, motorParkourId, 0);
		}

		// Token: 0x06017098 RID: 94360 RVA: 0x003526EA File Offset: 0x003508EA
		public static void AddSystemVars(FlatBufferBuilder builder, VectorOffset systemVarsOffset)
		{
			builder.AddOffset(2, systemVarsOffset.Value, 0);
		}

		// Token: 0x06017099 RID: 94361 RVA: 0x003526FC File Offset: 0x003508FC
		public static VectorOffset CreateSystemVarsVector(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601709A RID: 94362 RVA: 0x0035273C File Offset: 0x0035093C
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601709B RID: 94363 RVA: 0x00352756 File Offset: 0x00350956
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorParkourSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601709C RID: 94364 RVA: 0x00352774 File Offset: 0x00350974
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorParkourSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601709D RID: 94365 RVA: 0x0035278D File Offset: 0x0035098D
		public static void StartSystemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x00352798 File Offset: 0x00350998
		public static Offset<IMotorRacingSystemConfig> EndIMotorRacingSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRacingSystemConfig>(builder.EndTable());
		}

		// Token: 0x0601709F RID: 94367 RVA: 0x003527A8 File Offset: 0x003509A8
		public IMotorRacingSystemConfigT UnPack()
		{
			IMotorRacingSystemConfigT motorRacingSystemConfigT = new IMotorRacingSystemConfigT();
			this.UnPackTo(motorRacingSystemConfigT);
			return motorRacingSystemConfigT;
		}

		// Token: 0x060170A0 RID: 94368 RVA: 0x003527C4 File Offset: 0x003509C4
		public void UnPackTo(IMotorRacingSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.MotorParkourId = this.MotorParkourId;
			_o.SystemVars = new List<IMotorParkourSystemVarT>();
			for (int i = 0; i < this.SystemVarsLength; i++)
			{
				_o.SystemVars.Add((this.SystemVars(i) != null) ? this.SystemVars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060170A1 RID: 94369 RVA: 0x0035283C File Offset: 0x00350A3C
		public static Offset<IMotorRacingSystemConfig> Pack(FlatBufferBuilder builder, IMotorRacingSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRacingSystemConfig>);
			}
			VectorOffset systemVarsOffset = default(VectorOffset);
			if (_o.SystemVars != null)
			{
				Offset<IMotorParkourSystemVar>[] array = new Offset<IMotorParkourSystemVar>[_o.SystemVars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMotorParkourSystemVar.Pack(builder, _o.SystemVars[i]);
				}
				systemVarsOffset = IMotorRacingSystemConfig.CreateSystemVarsVector(builder, array);
			}
			return IMotorRacingSystemConfig.CreateIMotorRacingSystemConfig(builder, _o.Type, _o.MotorParkourId, systemVarsOffset);
		}

		// Token: 0x0400B95A RID: 47450
		private Table __p;
	}
}
