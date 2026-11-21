using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004388 RID: 17288
	public struct IMotorRacingSystemConfig : IFlatbufferObject
	{
		// Token: 0x1700769C RID: 30364
		// (get) Token: 0x060186EC RID: 100076 RVA: 0x0037B9AC File Offset: 0x00379BAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060186ED RID: 100077 RVA: 0x0037B9B9 File Offset: 0x00379BB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060186EE RID: 100078 RVA: 0x0037B9C0 File Offset: 0x00379BC0
		public static IMotorRacingSystemConfig GetRootAsIMotorRacingSystemConfig(ByteBuffer _bb)
		{
			return IMotorRacingSystemConfig.GetRootAsIMotorRacingSystemConfig(_bb, default(IMotorRacingSystemConfig));
		}

		// Token: 0x060186EF RID: 100079 RVA: 0x0037B9DC File Offset: 0x00379BDC
		public static IMotorRacingSystemConfig GetRootAsIMotorRacingSystemConfig(ByteBuffer _bb, IMotorRacingSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060186F0 RID: 100080 RVA: 0x0037B9F9 File Offset: 0x00379BF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060186F1 RID: 100081 RVA: 0x0037BA08 File Offset: 0x00379C08
		public IMotorRacingSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700769D RID: 30365
		// (get) Token: 0x060186F2 RID: 100082 RVA: 0x0037BA18 File Offset: 0x00379C18
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

		// Token: 0x1700769E RID: 30366
		// (get) Token: 0x060186F3 RID: 100083 RVA: 0x0037BA54 File Offset: 0x00379C54
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

		// Token: 0x060186F4 RID: 100084 RVA: 0x0037BA90 File Offset: 0x00379C90
		public IMotorParkourSystemVar? SystemVars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMotorParkourSystemVar?(default(IMotorParkourSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700769F RID: 30367
		// (get) Token: 0x060186F5 RID: 100085 RVA: 0x0037BAF0 File Offset: 0x00379CF0
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

		// Token: 0x060186F6 RID: 100086 RVA: 0x0037BB1B File Offset: 0x00379D1B
		public static Offset<IMotorRacingSystemConfig> CreateIMotorRacingSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int MotorParkourId = 0, VectorOffset SystemVarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IMotorRacingSystemConfig.AddSystemVars(builder, SystemVarsOffset);
			IMotorRacingSystemConfig.AddMotorParkourId(builder, MotorParkourId);
			IMotorRacingSystemConfig.AddType(builder, Type);
			return IMotorRacingSystemConfig.EndIMotorRacingSystemConfig(builder);
		}

		// Token: 0x060186F7 RID: 100087 RVA: 0x0037BB3F File Offset: 0x00379D3F
		public static void StartIMotorRacingSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060186F8 RID: 100088 RVA: 0x0037BB48 File Offset: 0x00379D48
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060186F9 RID: 100089 RVA: 0x0037BB53 File Offset: 0x00379D53
		public static void AddMotorParkourId(FlatBufferBuilder builder, int motorParkourId)
		{
			builder.AddInt(1, motorParkourId, 0);
		}

		// Token: 0x060186FA RID: 100090 RVA: 0x0037BB5E File Offset: 0x00379D5E
		public static void AddSystemVars(FlatBufferBuilder builder, VectorOffset systemVarsOffset)
		{
			builder.AddOffset(2, systemVarsOffset.Value, 0);
		}

		// Token: 0x060186FB RID: 100091 RVA: 0x0037BB70 File Offset: 0x00379D70
		public static VectorOffset CreateSystemVarsVector(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060186FC RID: 100092 RVA: 0x0037BBB0 File Offset: 0x00379DB0
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060186FD RID: 100093 RVA: 0x0037BBCA File Offset: 0x00379DCA
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorParkourSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060186FE RID: 100094 RVA: 0x0037BBE8 File Offset: 0x00379DE8
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorParkourSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060186FF RID: 100095 RVA: 0x0037BC01 File Offset: 0x00379E01
		public static void StartSystemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018700 RID: 100096 RVA: 0x0037BC0C File Offset: 0x00379E0C
		public static Offset<IMotorRacingSystemConfig> EndIMotorRacingSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRacingSystemConfig>(builder.EndTable());
		}

		// Token: 0x06018701 RID: 100097 RVA: 0x0037BC1C File Offset: 0x00379E1C
		public IMotorRacingSystemConfigT UnPack()
		{
			IMotorRacingSystemConfigT motorRacingSystemConfigT = new IMotorRacingSystemConfigT();
			this.UnPackTo(motorRacingSystemConfigT);
			return motorRacingSystemConfigT;
		}

		// Token: 0x06018702 RID: 100098 RVA: 0x0037BC38 File Offset: 0x00379E38
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

		// Token: 0x06018703 RID: 100099 RVA: 0x0037BCB0 File Offset: 0x00379EB0
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

		// Token: 0x0400C338 RID: 49976
		private Table __p;
	}
}
