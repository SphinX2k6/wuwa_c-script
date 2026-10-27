using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D4 RID: 22228
	public struct IPasserbyNpcSpawnBase : IFlatbufferObject
	{
		// Token: 0x1700A567 RID: 42343
		// (get) Token: 0x06025210 RID: 152080 RVA: 0x00520162 File Offset: 0x0051E362
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025211 RID: 152081 RVA: 0x0052016F File Offset: 0x0051E36F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025212 RID: 152082 RVA: 0x00520178 File Offset: 0x0051E378
		public static IPasserbyNpcSpawnBase GetRootAsIPasserbyNpcSpawnBase(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnBase.GetRootAsIPasserbyNpcSpawnBase(_bb, default(IPasserbyNpcSpawnBase));
		}

		// Token: 0x06025213 RID: 152083 RVA: 0x00520194 File Offset: 0x0051E394
		public static IPasserbyNpcSpawnBase GetRootAsIPasserbyNpcSpawnBase(ByteBuffer _bb, IPasserbyNpcSpawnBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025214 RID: 152084 RVA: 0x005201B1 File Offset: 0x0051E3B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025215 RID: 152085 RVA: 0x005201C0 File Offset: 0x0051E3C0
		public IPasserbyNpcSpawnBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A568 RID: 42344
		// (get) Token: 0x06025216 RID: 152086 RVA: 0x005201D0 File Offset: 0x0051E3D0
		public EPasserbyNpcSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcSpawnType.FixInterval;
				}
				return (EPasserbyNpcSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A569 RID: 42345
		// (get) Token: 0x06025217 RID: 152087 RVA: 0x0052020C File Offset: 0x0051E40C
		public int MaxSpawnCount
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

		// Token: 0x1700A56A RID: 42346
		// (get) Token: 0x06025218 RID: 152088 RVA: 0x00520248 File Offset: 0x0051E448
		public int MinDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A56B RID: 42347
		// (get) Token: 0x06025219 RID: 152089 RVA: 0x00520284 File Offset: 0x0051E484
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602521A RID: 152090 RVA: 0x005202C1 File Offset: 0x0051E4C1
		public static Offset<IPasserbyNpcSpawnBase> CreateIPasserbyNpcSpawnBase(FlatBufferBuilder builder, EPasserbyNpcSpawnType Type = EPasserbyNpcSpawnType.FixInterval, int MaxSpawnCount = 0, int MinDistance = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPasserbyNpcSpawnBase.AddMinDistance(builder, MinDistance);
			IPasserbyNpcSpawnBase.AddMaxSpawnCount(builder, MaxSpawnCount);
			IPasserbyNpcSpawnBase.AddNullMask(builder, NullMask);
			IPasserbyNpcSpawnBase.AddType(builder, Type);
			return IPasserbyNpcSpawnBase.EndIPasserbyNpcSpawnBase(builder);
		}

		// Token: 0x0602521B RID: 152091 RVA: 0x005202ED File Offset: 0x0051E4ED
		public static void StartIPasserbyNpcSpawnBase(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602521C RID: 152092 RVA: 0x005202F6 File Offset: 0x0051E4F6
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602521D RID: 152093 RVA: 0x00520301 File Offset: 0x0051E501
		public static void AddMaxSpawnCount(FlatBufferBuilder builder, int maxSpawnCount)
		{
			builder.AddInt(1, maxSpawnCount, 0);
		}

		// Token: 0x0602521E RID: 152094 RVA: 0x0052030C File Offset: 0x0051E50C
		public static void AddMinDistance(FlatBufferBuilder builder, int minDistance)
		{
			builder.AddInt(2, minDistance, 0);
		}

		// Token: 0x0602521F RID: 152095 RVA: 0x00520317 File Offset: 0x0051E517
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025220 RID: 152096 RVA: 0x00520322 File Offset: 0x0051E522
		public static Offset<IPasserbyNpcSpawnBase> EndIPasserbyNpcSpawnBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnBase>(builder.EndTable());
		}

		// Token: 0x06025221 RID: 152097 RVA: 0x00520330 File Offset: 0x0051E530
		public IPasserbyNpcSpawnBaseT UnPack()
		{
			IPasserbyNpcSpawnBaseT passerbyNpcSpawnBaseT = new IPasserbyNpcSpawnBaseT();
			this.UnPackTo(passerbyNpcSpawnBaseT);
			return passerbyNpcSpawnBaseT;
		}

		// Token: 0x06025222 RID: 152098 RVA: 0x0052034B File Offset: 0x0051E54B
		public void UnPackTo(IPasserbyNpcSpawnBaseT _o)
		{
			_o.Type = this.Type;
			_o.MaxSpawnCount = this.MaxSpawnCount;
			_o.MinDistance = this.MinDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025223 RID: 152099 RVA: 0x00520380 File Offset: 0x0051E580
		public static Offset<IPasserbyNpcSpawnBase> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnBase>);
			}
			return IPasserbyNpcSpawnBase.CreateIPasserbyNpcSpawnBase(builder, _o.Type, _o.MaxSpawnCount, _o.MinDistance, _o.NullMask);
		}

		// Token: 0x0400EB14 RID: 60180
		private Table __p;
	}
}
