using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005060 RID: 20576
	public struct ICustomViewDistance : IFlatbufferObject
	{
		// Token: 0x17009548 RID: 38216
		// (get) Token: 0x06020F9B RID: 135067 RVA: 0x004952F1 File Offset: 0x004934F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F9C RID: 135068 RVA: 0x004952FE File Offset: 0x004934FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F9D RID: 135069 RVA: 0x00495308 File Offset: 0x00493508
		public static ICustomViewDistance GetRootAsICustomViewDistance(ByteBuffer _bb)
		{
			return ICustomViewDistance.GetRootAsICustomViewDistance(_bb, default(ICustomViewDistance));
		}

		// Token: 0x06020F9E RID: 135070 RVA: 0x00495324 File Offset: 0x00493524
		public static ICustomViewDistance GetRootAsICustomViewDistance(ByteBuffer _bb, ICustomViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F9F RID: 135071 RVA: 0x00495341 File Offset: 0x00493541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FA0 RID: 135072 RVA: 0x00495350 File Offset: 0x00493550
		public ICustomViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009549 RID: 38217
		// (get) Token: 0x06020FA1 RID: 135073 RVA: 0x00495360 File Offset: 0x00493560
		public EViewDistanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewDistanceType.Low;
				}
				return (EViewDistanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700954A RID: 38218
		// (get) Token: 0x06020FA2 RID: 135074 RVA: 0x0049539C File Offset: 0x0049359C
		public int Distance
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

		// Token: 0x06020FA3 RID: 135075 RVA: 0x004953D8 File Offset: 0x004935D8
		public static Offset<ICustomViewDistance> CreateICustomViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low, int Distance = 0)
		{
			builder.StartTable(2);
			ICustomViewDistance.AddDistance(builder, Distance);
			ICustomViewDistance.AddType(builder, Type);
			return ICustomViewDistance.EndICustomViewDistance(builder);
		}

		// Token: 0x06020FA4 RID: 135076 RVA: 0x004953F5 File Offset: 0x004935F5
		public static void StartICustomViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020FA5 RID: 135077 RVA: 0x004953FE File Offset: 0x004935FE
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020FA6 RID: 135078 RVA: 0x00495409 File Offset: 0x00493609
		public static void AddDistance(FlatBufferBuilder builder, int distance)
		{
			builder.AddInt(1, distance, 0);
		}

		// Token: 0x06020FA7 RID: 135079 RVA: 0x00495414 File Offset: 0x00493614
		public static Offset<ICustomViewDistance> EndICustomViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<ICustomViewDistance>(builder.EndTable());
		}

		// Token: 0x06020FA8 RID: 135080 RVA: 0x00495424 File Offset: 0x00493624
		public ICustomViewDistanceT UnPack()
		{
			ICustomViewDistanceT customViewDistanceT = new ICustomViewDistanceT();
			this.UnPackTo(customViewDistanceT);
			return customViewDistanceT;
		}

		// Token: 0x06020FA9 RID: 135081 RVA: 0x0049543F File Offset: 0x0049363F
		public void UnPackTo(ICustomViewDistanceT _o)
		{
			_o.Type = this.Type;
			_o.Distance = this.Distance;
		}

		// Token: 0x06020FAA RID: 135082 RVA: 0x0049545C File Offset: 0x0049365C
		public static Offset<ICustomViewDistance> Pack(FlatBufferBuilder builder, ICustomViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomViewDistance>);
			}
			return ICustomViewDistance.CreateICustomViewDistance(builder, _o.Type, _o.Distance);
		}

		// Token: 0x0400E05C RID: 57436
		private Table __p;
	}
}
