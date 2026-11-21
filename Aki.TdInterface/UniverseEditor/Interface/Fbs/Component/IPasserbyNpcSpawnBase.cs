using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBA RID: 23738
	public struct IPasserbyNpcSpawnBase : IFlatbufferObject
	{
		// Token: 0x1700AE5C RID: 44636
		// (get) Token: 0x06027631 RID: 161329 RVA: 0x0056422E File Offset: 0x0056242E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027632 RID: 161330 RVA: 0x0056423B File Offset: 0x0056243B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027633 RID: 161331 RVA: 0x00564244 File Offset: 0x00562444
		public static IPasserbyNpcSpawnBase GetRootAsIPasserbyNpcSpawnBase(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnBase.GetRootAsIPasserbyNpcSpawnBase(_bb, default(IPasserbyNpcSpawnBase));
		}

		// Token: 0x06027634 RID: 161332 RVA: 0x00564260 File Offset: 0x00562460
		public static IPasserbyNpcSpawnBase GetRootAsIPasserbyNpcSpawnBase(ByteBuffer _bb, IPasserbyNpcSpawnBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027635 RID: 161333 RVA: 0x0056427D File Offset: 0x0056247D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027636 RID: 161334 RVA: 0x0056428C File Offset: 0x0056248C
		public IPasserbyNpcSpawnBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE5D RID: 44637
		// (get) Token: 0x06027637 RID: 161335 RVA: 0x0056429C File Offset: 0x0056249C
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

		// Token: 0x1700AE5E RID: 44638
		// (get) Token: 0x06027638 RID: 161336 RVA: 0x005642D8 File Offset: 0x005624D8
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

		// Token: 0x1700AE5F RID: 44639
		// (get) Token: 0x06027639 RID: 161337 RVA: 0x00564314 File Offset: 0x00562514
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

		// Token: 0x1700AE60 RID: 44640
		// (get) Token: 0x0602763A RID: 161338 RVA: 0x00564350 File Offset: 0x00562550
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

		// Token: 0x0602763B RID: 161339 RVA: 0x0056438D File Offset: 0x0056258D
		public static Offset<IPasserbyNpcSpawnBase> CreateIPasserbyNpcSpawnBase(FlatBufferBuilder builder, EPasserbyNpcSpawnType Type = EPasserbyNpcSpawnType.FixInterval, int MaxSpawnCount = 0, int MinDistance = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPasserbyNpcSpawnBase.AddMinDistance(builder, MinDistance);
			IPasserbyNpcSpawnBase.AddMaxSpawnCount(builder, MaxSpawnCount);
			IPasserbyNpcSpawnBase.AddNullMask(builder, NullMask);
			IPasserbyNpcSpawnBase.AddType(builder, Type);
			return IPasserbyNpcSpawnBase.EndIPasserbyNpcSpawnBase(builder);
		}

		// Token: 0x0602763C RID: 161340 RVA: 0x005643B9 File Offset: 0x005625B9
		public static void StartIPasserbyNpcSpawnBase(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602763D RID: 161341 RVA: 0x005643C2 File Offset: 0x005625C2
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602763E RID: 161342 RVA: 0x005643CD File Offset: 0x005625CD
		public static void AddMaxSpawnCount(FlatBufferBuilder builder, int maxSpawnCount)
		{
			builder.AddInt(1, maxSpawnCount, 0);
		}

		// Token: 0x0602763F RID: 161343 RVA: 0x005643D8 File Offset: 0x005625D8
		public static void AddMinDistance(FlatBufferBuilder builder, int minDistance)
		{
			builder.AddInt(2, minDistance, 0);
		}

		// Token: 0x06027640 RID: 161344 RVA: 0x005643E3 File Offset: 0x005625E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027641 RID: 161345 RVA: 0x005643EE File Offset: 0x005625EE
		public static Offset<IPasserbyNpcSpawnBase> EndIPasserbyNpcSpawnBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnBase>(builder.EndTable());
		}

		// Token: 0x06027642 RID: 161346 RVA: 0x005643FC File Offset: 0x005625FC
		public IPasserbyNpcSpawnBaseT UnPack()
		{
			IPasserbyNpcSpawnBaseT passerbyNpcSpawnBaseT = new IPasserbyNpcSpawnBaseT();
			this.UnPackTo(passerbyNpcSpawnBaseT);
			return passerbyNpcSpawnBaseT;
		}

		// Token: 0x06027643 RID: 161347 RVA: 0x00564417 File Offset: 0x00562617
		public void UnPackTo(IPasserbyNpcSpawnBaseT _o)
		{
			_o.Type = this.Type;
			_o.MaxSpawnCount = this.MaxSpawnCount;
			_o.MinDistance = this.MinDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027644 RID: 161348 RVA: 0x0056444C File Offset: 0x0056264C
		public static Offset<IPasserbyNpcSpawnBase> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnBase>);
			}
			return IPasserbyNpcSpawnBase.CreateIPasserbyNpcSpawnBase(builder, _o.Type, _o.MaxSpawnCount, _o.MinDistance, _o.NullMask);
		}

		// Token: 0x0400F7D3 RID: 63443
		private Table __p;
	}
}
