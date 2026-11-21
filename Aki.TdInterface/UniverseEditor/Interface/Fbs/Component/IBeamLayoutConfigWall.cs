using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005439 RID: 21561
	public struct IBeamLayoutConfigWall : IFlatbufferObject
	{
		// Token: 0x17009925 RID: 39205
		// (get) Token: 0x06021D04 RID: 138500 RVA: 0x004A9651 File Offset: 0x004A7851
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D05 RID: 138501 RVA: 0x004A965E File Offset: 0x004A785E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D06 RID: 138502 RVA: 0x004A9668 File Offset: 0x004A7868
		public static IBeamLayoutConfigWall GetRootAsIBeamLayoutConfigWall(ByteBuffer _bb)
		{
			return IBeamLayoutConfigWall.GetRootAsIBeamLayoutConfigWall(_bb, default(IBeamLayoutConfigWall));
		}

		// Token: 0x06021D07 RID: 138503 RVA: 0x004A9684 File Offset: 0x004A7884
		public static IBeamLayoutConfigWall GetRootAsIBeamLayoutConfigWall(ByteBuffer _bb, IBeamLayoutConfigWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D08 RID: 138504 RVA: 0x004A96A1 File Offset: 0x004A78A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D09 RID: 138505 RVA: 0x004A96B0 File Offset: 0x004A78B0
		public IBeamLayoutConfigWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009926 RID: 39206
		// (get) Token: 0x06021D0A RID: 138506 RVA: 0x004A96C0 File Offset: 0x004A78C0
		public EBeamLayoutType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBeamLayoutType.BeamWall;
				}
				return (EBeamLayoutType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009927 RID: 39207
		// (get) Token: 0x06021D0B RID: 138507 RVA: 0x004A96FC File Offset: 0x004A78FC
		public int Count
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

		// Token: 0x17009928 RID: 39208
		// (get) Token: 0x06021D0C RID: 138508 RVA: 0x004A9738 File Offset: 0x004A7938
		public float Distance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021D0D RID: 138509 RVA: 0x004A9778 File Offset: 0x004A7978
		public static Offset<IBeamLayoutConfigWall> CreateIBeamLayoutConfigWall(FlatBufferBuilder builder, EBeamLayoutType Type = EBeamLayoutType.BeamWall, int Count = 0, float Distance = 0f)
		{
			builder.StartTable(3);
			IBeamLayoutConfigWall.AddDistance(builder, Distance);
			IBeamLayoutConfigWall.AddCount(builder, Count);
			IBeamLayoutConfigWall.AddType(builder, Type);
			return IBeamLayoutConfigWall.EndIBeamLayoutConfigWall(builder);
		}

		// Token: 0x06021D0E RID: 138510 RVA: 0x004A979C File Offset: 0x004A799C
		public static void StartIBeamLayoutConfigWall(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021D0F RID: 138511 RVA: 0x004A97A5 File Offset: 0x004A79A5
		public static void AddType(FlatBufferBuilder builder, EBeamLayoutType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021D10 RID: 138512 RVA: 0x004A97B0 File Offset: 0x004A79B0
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06021D11 RID: 138513 RVA: 0x004A97BB File Offset: 0x004A79BB
		public static void AddDistance(FlatBufferBuilder builder, float distance)
		{
			builder.AddFloat(2, distance, 0.0);
		}

		// Token: 0x06021D12 RID: 138514 RVA: 0x004A97CE File Offset: 0x004A79CE
		public static Offset<IBeamLayoutConfigWall> EndIBeamLayoutConfigWall(FlatBufferBuilder builder)
		{
			return new Offset<IBeamLayoutConfigWall>(builder.EndTable());
		}

		// Token: 0x06021D13 RID: 138515 RVA: 0x004A97DC File Offset: 0x004A79DC
		public IBeamLayoutConfigWallT UnPack()
		{
			IBeamLayoutConfigWallT beamLayoutConfigWallT = new IBeamLayoutConfigWallT();
			this.UnPackTo(beamLayoutConfigWallT);
			return beamLayoutConfigWallT;
		}

		// Token: 0x06021D14 RID: 138516 RVA: 0x004A97F7 File Offset: 0x004A79F7
		public void UnPackTo(IBeamLayoutConfigWallT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.Distance = this.Distance;
		}

		// Token: 0x06021D15 RID: 138517 RVA: 0x004A9820 File Offset: 0x004A7A20
		public static Offset<IBeamLayoutConfigWall> Pack(FlatBufferBuilder builder, IBeamLayoutConfigWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamLayoutConfigWall>);
			}
			return IBeamLayoutConfigWall.CreateIBeamLayoutConfigWall(builder, _o.Type, _o.Count, _o.Distance);
		}

		// Token: 0x0400E8F8 RID: 59640
		private Table __p;
	}
}
