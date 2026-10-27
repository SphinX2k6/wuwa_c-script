using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005551 RID: 21841
	public struct IMidViewDistance : IFlatbufferObject
	{
		// Token: 0x1700A14E RID: 41294
		// (get) Token: 0x060241BF RID: 147903 RVA: 0x004FD0A9 File Offset: 0x004FB2A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060241C0 RID: 147904 RVA: 0x004FD0B6 File Offset: 0x004FB2B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060241C1 RID: 147905 RVA: 0x004FD0C0 File Offset: 0x004FB2C0
		public static IMidViewDistance GetRootAsIMidViewDistance(ByteBuffer _bb)
		{
			return IMidViewDistance.GetRootAsIMidViewDistance(_bb, default(IMidViewDistance));
		}

		// Token: 0x060241C2 RID: 147906 RVA: 0x004FD0DC File Offset: 0x004FB2DC
		public static IMidViewDistance GetRootAsIMidViewDistance(ByteBuffer _bb, IMidViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241C3 RID: 147907 RVA: 0x004FD0F9 File Offset: 0x004FB2F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241C4 RID: 147908 RVA: 0x004FD108 File Offset: 0x004FB308
		public IMidViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A14F RID: 41295
		// (get) Token: 0x060241C5 RID: 147909 RVA: 0x004FD118 File Offset: 0x004FB318
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

		// Token: 0x060241C6 RID: 147910 RVA: 0x004FD154 File Offset: 0x004FB354
		public static Offset<IMidViewDistance> CreateIMidViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			IMidViewDistance.AddType(builder, Type);
			return IMidViewDistance.EndIMidViewDistance(builder);
		}

		// Token: 0x060241C7 RID: 147911 RVA: 0x004FD16A File Offset: 0x004FB36A
		public static void StartIMidViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060241C8 RID: 147912 RVA: 0x004FD173 File Offset: 0x004FB373
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060241C9 RID: 147913 RVA: 0x004FD17E File Offset: 0x004FB37E
		public static Offset<IMidViewDistance> EndIMidViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<IMidViewDistance>(builder.EndTable());
		}

		// Token: 0x060241CA RID: 147914 RVA: 0x004FD18C File Offset: 0x004FB38C
		public IMidViewDistanceT UnPack()
		{
			IMidViewDistanceT midViewDistanceT = new IMidViewDistanceT();
			this.UnPackTo(midViewDistanceT);
			return midViewDistanceT;
		}

		// Token: 0x060241CB RID: 147915 RVA: 0x004FD1A7 File Offset: 0x004FB3A7
		public void UnPackTo(IMidViewDistanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060241CC RID: 147916 RVA: 0x004FD1B8 File Offset: 0x004FB3B8
		public static Offset<IMidViewDistance> Pack(FlatBufferBuilder builder, IMidViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMidViewDistance>);
			}
			return IMidViewDistance.CreateIMidViewDistance(builder, _o.Type);
		}

		// Token: 0x0400E860 RID: 59488
		private Table __p;
	}
}
