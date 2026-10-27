using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F07 RID: 20231
	public struct IBeamLayoutConfigWall : IFlatbufferObject
	{
		// Token: 0x170091A3 RID: 37283
		// (get) Token: 0x0601FF94 RID: 130964 RVA: 0x004732BD File Offset: 0x004714BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF95 RID: 130965 RVA: 0x004732CA File Offset: 0x004714CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF96 RID: 130966 RVA: 0x004732D4 File Offset: 0x004714D4
		public static IBeamLayoutConfigWall GetRootAsIBeamLayoutConfigWall(ByteBuffer _bb)
		{
			return IBeamLayoutConfigWall.GetRootAsIBeamLayoutConfigWall(_bb, default(IBeamLayoutConfigWall));
		}

		// Token: 0x0601FF97 RID: 130967 RVA: 0x004732F0 File Offset: 0x004714F0
		public static IBeamLayoutConfigWall GetRootAsIBeamLayoutConfigWall(ByteBuffer _bb, IBeamLayoutConfigWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF98 RID: 130968 RVA: 0x0047330D File Offset: 0x0047150D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF99 RID: 130969 RVA: 0x0047331C File Offset: 0x0047151C
		public IBeamLayoutConfigWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091A4 RID: 37284
		// (get) Token: 0x0601FF9A RID: 130970 RVA: 0x0047332C File Offset: 0x0047152C
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

		// Token: 0x170091A5 RID: 37285
		// (get) Token: 0x0601FF9B RID: 130971 RVA: 0x00473368 File Offset: 0x00471568
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

		// Token: 0x170091A6 RID: 37286
		// (get) Token: 0x0601FF9C RID: 130972 RVA: 0x004733A4 File Offset: 0x004715A4
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

		// Token: 0x0601FF9D RID: 130973 RVA: 0x004733E4 File Offset: 0x004715E4
		public static Offset<IBeamLayoutConfigWall> CreateIBeamLayoutConfigWall(FlatBufferBuilder builder, EBeamLayoutType Type = EBeamLayoutType.BeamWall, int Count = 0, float Distance = 0f)
		{
			builder.StartTable(3);
			IBeamLayoutConfigWall.AddDistance(builder, Distance);
			IBeamLayoutConfigWall.AddCount(builder, Count);
			IBeamLayoutConfigWall.AddType(builder, Type);
			return IBeamLayoutConfigWall.EndIBeamLayoutConfigWall(builder);
		}

		// Token: 0x0601FF9E RID: 130974 RVA: 0x00473408 File Offset: 0x00471608
		public static void StartIBeamLayoutConfigWall(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FF9F RID: 130975 RVA: 0x00473411 File Offset: 0x00471611
		public static void AddType(FlatBufferBuilder builder, EBeamLayoutType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FFA0 RID: 130976 RVA: 0x0047341C File Offset: 0x0047161C
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0601FFA1 RID: 130977 RVA: 0x00473427 File Offset: 0x00471627
		public static void AddDistance(FlatBufferBuilder builder, float distance)
		{
			builder.AddFloat(2, distance, 0.0);
		}

		// Token: 0x0601FFA2 RID: 130978 RVA: 0x0047343A File Offset: 0x0047163A
		public static Offset<IBeamLayoutConfigWall> EndIBeamLayoutConfigWall(FlatBufferBuilder builder)
		{
			return new Offset<IBeamLayoutConfigWall>(builder.EndTable());
		}

		// Token: 0x0601FFA3 RID: 130979 RVA: 0x00473448 File Offset: 0x00471648
		public IBeamLayoutConfigWallT UnPack()
		{
			IBeamLayoutConfigWallT beamLayoutConfigWallT = new IBeamLayoutConfigWallT();
			this.UnPackTo(beamLayoutConfigWallT);
			return beamLayoutConfigWallT;
		}

		// Token: 0x0601FFA4 RID: 130980 RVA: 0x00473463 File Offset: 0x00471663
		public void UnPackTo(IBeamLayoutConfigWallT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.Distance = this.Distance;
		}

		// Token: 0x0601FFA5 RID: 130981 RVA: 0x0047348C File Offset: 0x0047168C
		public static Offset<IBeamLayoutConfigWall> Pack(FlatBufferBuilder builder, IBeamLayoutConfigWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamLayoutConfigWall>);
			}
			return IBeamLayoutConfigWall.CreateIBeamLayoutConfigWall(builder, _o.Type, _o.Count, _o.Distance);
		}

		// Token: 0x0400DD49 RID: 56649
		private Table __p;
	}
}
