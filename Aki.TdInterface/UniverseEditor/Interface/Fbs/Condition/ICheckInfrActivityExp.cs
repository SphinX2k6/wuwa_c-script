using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A75 RID: 19061
	public struct ICheckInfrActivityExp : IFlatbufferObject
	{
		// Token: 0x17008A0D RID: 35341
		// (get) Token: 0x0601DDF4 RID: 122356 RVA: 0x004323C8 File Offset: 0x004305C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DDF5 RID: 122357 RVA: 0x004323D5 File Offset: 0x004305D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DDF6 RID: 122358 RVA: 0x004323DC File Offset: 0x004305DC
		public static ICheckInfrActivityExp GetRootAsICheckInfrActivityExp(ByteBuffer _bb)
		{
			return ICheckInfrActivityExp.GetRootAsICheckInfrActivityExp(_bb, default(ICheckInfrActivityExp));
		}

		// Token: 0x0601DDF7 RID: 122359 RVA: 0x004323F8 File Offset: 0x004305F8
		public static ICheckInfrActivityExp GetRootAsICheckInfrActivityExp(ByteBuffer _bb, ICheckInfrActivityExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DDF8 RID: 122360 RVA: 0x00432415 File Offset: 0x00430615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DDF9 RID: 122361 RVA: 0x00432424 File Offset: 0x00430624
		public ICheckInfrActivityExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A0E RID: 35342
		// (get) Token: 0x0601DDFA RID: 122362 RVA: 0x00432434 File Offset: 0x00430634
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A0F RID: 35343
		// (get) Token: 0x0601DDFB RID: 122363 RVA: 0x00432470 File Offset: 0x00430670
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A10 RID: 35344
		// (get) Token: 0x0601DDFC RID: 122364 RVA: 0x004324AC File Offset: 0x004306AC
		public int Exp
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

		// Token: 0x0601DDFD RID: 122365 RVA: 0x004324E8 File Offset: 0x004306E8
		public static Offset<ICheckInfrActivityExp> CreateICheckInfrActivityExp(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, ECompare Compare = ECompare.Eq, int Exp = 0)
		{
			builder.StartTable(3);
			ICheckInfrActivityExp.AddExp(builder, Exp);
			ICheckInfrActivityExp.AddCompare(builder, Compare);
			ICheckInfrActivityExp.AddType(builder, Type);
			return ICheckInfrActivityExp.EndICheckInfrActivityExp(builder);
		}

		// Token: 0x0601DDFE RID: 122366 RVA: 0x0043250C File Offset: 0x0043070C
		public static void StartICheckInfrActivityExp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DDFF RID: 122367 RVA: 0x00432515 File Offset: 0x00430715
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DE00 RID: 122368 RVA: 0x00432520 File Offset: 0x00430720
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601DE01 RID: 122369 RVA: 0x0043252B File Offset: 0x0043072B
		public static void AddExp(FlatBufferBuilder builder, int exp)
		{
			builder.AddInt(2, exp, 0);
		}

		// Token: 0x0601DE02 RID: 122370 RVA: 0x00432536 File Offset: 0x00430736
		public static Offset<ICheckInfrActivityExp> EndICheckInfrActivityExp(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInfrActivityExp>(builder.EndTable());
		}

		// Token: 0x0601DE03 RID: 122371 RVA: 0x00432544 File Offset: 0x00430744
		public ICheckInfrActivityExpT UnPack()
		{
			ICheckInfrActivityExpT checkInfrActivityExpT = new ICheckInfrActivityExpT();
			this.UnPackTo(checkInfrActivityExpT);
			return checkInfrActivityExpT;
		}

		// Token: 0x0601DE04 RID: 122372 RVA: 0x0043255F File Offset: 0x0043075F
		public void UnPackTo(ICheckInfrActivityExpT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Exp = this.Exp;
		}

		// Token: 0x0601DE05 RID: 122373 RVA: 0x00432588 File Offset: 0x00430788
		public static Offset<ICheckInfrActivityExp> Pack(FlatBufferBuilder builder, ICheckInfrActivityExpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInfrActivityExp>);
			}
			return ICheckInfrActivityExp.CreateICheckInfrActivityExp(builder, _o.Type, _o.Compare, _o.Exp);
		}

		// Token: 0x0400D2DD RID: 53981
		private Table __p;
	}
}
