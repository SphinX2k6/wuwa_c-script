using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A22 RID: 23074
	public struct ISystemModuleDataSyncMotorRacing : IFlatbufferObject
	{
		// Token: 0x1700AD70 RID: 44400
		// (get) Token: 0x060272F9 RID: 160505 RVA: 0x00563E06 File Offset: 0x00562006
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060272FA RID: 160506 RVA: 0x00563E13 File Offset: 0x00562013
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060272FB RID: 160507 RVA: 0x00563E1C File Offset: 0x0056201C
		public static ISystemModuleDataSyncMotorRacing GetRootAsISystemModuleDataSyncMotorRacing(ByteBuffer _bb)
		{
			return ISystemModuleDataSyncMotorRacing.GetRootAsISystemModuleDataSyncMotorRacing(_bb, default(ISystemModuleDataSyncMotorRacing));
		}

		// Token: 0x060272FC RID: 160508 RVA: 0x00563E38 File Offset: 0x00562038
		public static ISystemModuleDataSyncMotorRacing GetRootAsISystemModuleDataSyncMotorRacing(ByteBuffer _bb, ISystemModuleDataSyncMotorRacing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060272FD RID: 160509 RVA: 0x00563E55 File Offset: 0x00562055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272FE RID: 160510 RVA: 0x00563E64 File Offset: 0x00562064
		public ISystemModuleDataSyncMotorRacing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD71 RID: 44401
		// (get) Token: 0x060272FF RID: 160511 RVA: 0x00563E74 File Offset: 0x00562074
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

		// Token: 0x1700AD72 RID: 44402
		// (get) Token: 0x06027300 RID: 160512 RVA: 0x00563EB0 File Offset: 0x005620B0
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

		// Token: 0x06027301 RID: 160513 RVA: 0x00563EEC File Offset: 0x005620EC
		public IMotorParkourSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMotorParkourSystemVar?(default(IMotorParkourSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD73 RID: 44403
		// (get) Token: 0x06027302 RID: 160514 RVA: 0x00563F4C File Offset: 0x0056214C
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

		// Token: 0x06027303 RID: 160515 RVA: 0x00563F77 File Offset: 0x00562177
		public static Offset<ISystemModuleDataSyncMotorRacing> CreateISystemModuleDataSyncMotorRacing(FlatBufferBuilder builder, ESyncDataSystemType Type = ESyncDataSystemType.MotorRacing, int MotorParkourId = 0, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISystemModuleDataSyncMotorRacing.AddVars(builder, VarsOffset);
			ISystemModuleDataSyncMotorRacing.AddMotorParkourId(builder, MotorParkourId);
			ISystemModuleDataSyncMotorRacing.AddType(builder, Type);
			return ISystemModuleDataSyncMotorRacing.EndISystemModuleDataSyncMotorRacing(builder);
		}

		// Token: 0x06027304 RID: 160516 RVA: 0x00563F9B File Offset: 0x0056219B
		public static void StartISystemModuleDataSyncMotorRacing(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027305 RID: 160517 RVA: 0x00563FA4 File Offset: 0x005621A4
		public static void AddType(FlatBufferBuilder builder, ESyncDataSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027306 RID: 160518 RVA: 0x00563FAF File Offset: 0x005621AF
		public static void AddMotorParkourId(FlatBufferBuilder builder, int motorParkourId)
		{
			builder.AddInt(1, motorParkourId, 0);
		}

		// Token: 0x06027307 RID: 160519 RVA: 0x00563FBA File Offset: 0x005621BA
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x06027308 RID: 160520 RVA: 0x00563FCC File Offset: 0x005621CC
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027309 RID: 160521 RVA: 0x0056400C File Offset: 0x0056220C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IMotorParkourSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602730A RID: 160522 RVA: 0x00564026 File Offset: 0x00562226
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorParkourSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorParkourSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602730B RID: 160523 RVA: 0x00564044 File Offset: 0x00562244
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorParkourSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602730C RID: 160524 RVA: 0x0056405D File Offset: 0x0056225D
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602730D RID: 160525 RVA: 0x00564068 File Offset: 0x00562268
		public static Offset<ISystemModuleDataSyncMotorRacing> EndISystemModuleDataSyncMotorRacing(FlatBufferBuilder builder)
		{
			return new Offset<ISystemModuleDataSyncMotorRacing>(builder.EndTable());
		}

		// Token: 0x0602730E RID: 160526 RVA: 0x00564078 File Offset: 0x00562278
		public ISystemModuleDataSyncMotorRacingT UnPack()
		{
			ISystemModuleDataSyncMotorRacingT systemModuleDataSyncMotorRacingT = new ISystemModuleDataSyncMotorRacingT();
			this.UnPackTo(systemModuleDataSyncMotorRacingT);
			return systemModuleDataSyncMotorRacingT;
		}

		// Token: 0x0602730F RID: 160527 RVA: 0x00564094 File Offset: 0x00562294
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

		// Token: 0x06027310 RID: 160528 RVA: 0x0056410C File Offset: 0x0056230C
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

		// Token: 0x0400F078 RID: 61560
		private Table __p;
	}
}
