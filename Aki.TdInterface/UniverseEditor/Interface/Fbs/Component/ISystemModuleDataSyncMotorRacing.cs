using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200602F RID: 24623
	public struct ISystemModuleDataSyncMotorRacing : IFlatbufferObject
	{
		// Token: 0x1700B6A8 RID: 46760
		// (get) Token: 0x06029871 RID: 170097 RVA: 0x005AADCA File Offset: 0x005A8FCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029872 RID: 170098 RVA: 0x005AADD7 File Offset: 0x005A8FD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029873 RID: 170099 RVA: 0x005AADE0 File Offset: 0x005A8FE0
		public static ISystemModuleDataSyncMotorRacing GetRootAsISystemModuleDataSyncMotorRacing(ByteBuffer _bb)
		{
			return ISystemModuleDataSyncMotorRacing.GetRootAsISystemModuleDataSyncMotorRacing(_bb, default(ISystemModuleDataSyncMotorRacing));
		}

		// Token: 0x06029874 RID: 170100 RVA: 0x005AADFC File Offset: 0x005A8FFC
		public static ISystemModuleDataSyncMotorRacing GetRootAsISystemModuleDataSyncMotorRacing(ByteBuffer _bb, ISystemModuleDataSyncMotorRacing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029875 RID: 170101 RVA: 0x005AAE19 File Offset: 0x005A9019
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029876 RID: 170102 RVA: 0x005AAE28 File Offset: 0x005A9028
		public ISystemModuleDataSyncMotorRacing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6A9 RID: 46761
		// (get) Token: 0x06029877 RID: 170103 RVA: 0x005AAE38 File Offset: 0x005A9038
		public ESyncDataSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESyncDataSystemType.MotorRacing;
				}
				return (ESyncDataSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B6AA RID: 46762
		// (get) Token: 0x06029878 RID: 170104 RVA: 0x005AAE74 File Offset: 0x005A9074
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

		// Token: 0x06029879 RID: 170105 RVA: 0x005AAEB0 File Offset: 0x005A90B0
		public IMotorParkourSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMotorParkourSystemVar?(default(IMotorParkourSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B6AB RID: 46763
		// (get) Token: 0x0602987A RID: 170106 RVA: 0x005AAF10 File Offset: 0x005A9110
		public int VarsLength
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

		// Token: 0x0602987B RID: 170107 RVA: 0x005AAF3B File Offset: 0x005A913B
		public static Offset<ISystemModuleDataSyncMotorRacing> CreateISystemModuleDataSyncMotorRacing(FlatBufferBuilder builder, ESyncDataSystemType Type = ESyncDataSystemType.MotorRacing, int MotorParkourId = 0, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISystemModuleDataSyncMotorRacing.AddVars(builder, VarsOffset);
			ISystemModuleDataSyncMotorRacing.AddMotorParkourId(builder, MotorParkourId);
			ISystemModuleDataSyncMotorRacing.AddType(builder, Type);
			return ISystemModuleDataSyncMotorRacing.EndISystemModuleDataSyncMotorRacing(builder);
		}

		// Token: 0x0602987C RID: 170108 RVA: 0x005AAF5F File Offset: 0x005A915F
		public static void StartISystemModuleDataSyncMotorRacing(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602987D RID: 170109 RVA: 0x005AAF68 File Offset: 0x005A9168
		public static void AddType(FlatBufferBuilder builder, ESyncDataSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602987E RID: 170110 RVA: 0x005AAF73 File Offset: 0x005A9173
		public static void AddMotorParkourId(FlatBufferBuilder builder, int motorParkourId)
		{
			builder.AddInt(1, motorParkourId, 0);
		}

		// Token: 0x0602987F RID: 170111 RVA: 0x005AAF7E File Offset: 0x005A917E
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x06029880 RID: 170112 RVA: 0x005AAF90 File Offset: 0x005A9190
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029881 RID: 170113 RVA: 0x005AAFD0 File Offset: 0x005A91D0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029882 RID: 170114 RVA: 0x005AAFEA File Offset: 0x005A91EA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorParkourSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029883 RID: 170115 RVA: 0x005AB008 File Offset: 0x005A9208
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorParkourSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029884 RID: 170116 RVA: 0x005AB021 File Offset: 0x005A9221
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029885 RID: 170117 RVA: 0x005AB02C File Offset: 0x005A922C
		public static Offset<ISystemModuleDataSyncMotorRacing> EndISystemModuleDataSyncMotorRacing(FlatBufferBuilder builder)
		{
			return new Offset<ISystemModuleDataSyncMotorRacing>(builder.EndTable());
		}

		// Token: 0x06029886 RID: 170118 RVA: 0x005AB03C File Offset: 0x005A923C
		public ISystemModuleDataSyncMotorRacingT UnPack()
		{
			ISystemModuleDataSyncMotorRacingT systemModuleDataSyncMotorRacingT = new ISystemModuleDataSyncMotorRacingT();
			this.UnPackTo(systemModuleDataSyncMotorRacingT);
			return systemModuleDataSyncMotorRacingT;
		}

		// Token: 0x06029887 RID: 170119 RVA: 0x005AB058 File Offset: 0x005A9258
		public void UnPackTo(ISystemModuleDataSyncMotorRacingT _o)
		{
			_o.Type = this.Type;
			_o.MotorParkourId = this.MotorParkourId;
			_o.Vars = new List<IMotorParkourSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029888 RID: 170120 RVA: 0x005AB0D0 File Offset: 0x005A92D0
		public static Offset<ISystemModuleDataSyncMotorRacing> Pack(FlatBufferBuilder builder, ISystemModuleDataSyncMotorRacingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemModuleDataSyncMotorRacing>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IMotorParkourSystemVar>[] array = new Offset<IMotorParkourSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMotorParkourSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = ISystemModuleDataSyncMotorRacing.CreateVarsVector(builder, array);
			}
			return ISystemModuleDataSyncMotorRacing.CreateISystemModuleDataSyncMotorRacing(builder, _o.Type, _o.MotorParkourId, varsOffset);
		}

		// Token: 0x0400FD6F RID: 64879
		private Table __p;
	}
}
