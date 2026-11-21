using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E21 RID: 20001
	public struct IAngleRange : IFlatbufferObject
	{
		// Token: 0x17008E81 RID: 36481
		// (get) Token: 0x0601EEC7 RID: 126663 RVA: 0x00452165 File Offset: 0x00450365
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EEC8 RID: 126664 RVA: 0x00452172 File Offset: 0x00450372
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EEC9 RID: 126665 RVA: 0x0045217C File Offset: 0x0045037C
		public static IAngleRange GetRootAsIAngleRange(ByteBuffer _bb)
		{
			return IAngleRange.GetRootAsIAngleRange(_bb, default(IAngleRange));
		}

		// Token: 0x0601EECA RID: 126666 RVA: 0x00452198 File Offset: 0x00450398
		public static IAngleRange GetRootAsIAngleRange(ByteBuffer _bb, IAngleRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EECB RID: 126667 RVA: 0x004521B5 File Offset: 0x004503B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EECC RID: 126668 RVA: 0x004521C4 File Offset: 0x004503C4
		public IAngleRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E82 RID: 36482
		// (get) Token: 0x0601EECD RID: 126669 RVA: 0x004521D4 File Offset: 0x004503D4
		public float Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E83 RID: 36483
		// (get) Token: 0x0601EECE RID: 126670 RVA: 0x00452214 File Offset: 0x00450414
		public float Max
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EECF RID: 126671 RVA: 0x00452254 File Offset: 0x00450454
		public static Offset<IAngleRange> CreateIAngleRange(FlatBufferBuilder builder, float Min = 0f, float Max = 0f)
		{
			builder.StartTable(2);
			IAngleRange.AddMax(builder, Max);
			IAngleRange.AddMin(builder, Min);
			return IAngleRange.EndIAngleRange(builder);
		}

		// Token: 0x0601EED0 RID: 126672 RVA: 0x00452271 File Offset: 0x00450471
		public static void StartIAngleRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EED1 RID: 126673 RVA: 0x0045227A File Offset: 0x0045047A
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(0, min, 0.0);
		}

		// Token: 0x0601EED2 RID: 126674 RVA: 0x0045228D File Offset: 0x0045048D
		public static void AddMax(FlatBufferBuilder builder, float max)
		{
			builder.AddFloat(1, max, 0.0);
		}

		// Token: 0x0601EED3 RID: 126675 RVA: 0x004522A0 File Offset: 0x004504A0
		public static Offset<IAngleRange> EndIAngleRange(FlatBufferBuilder builder)
		{
			return new Offset<IAngleRange>(builder.EndTable());
		}

		// Token: 0x0601EED4 RID: 126676 RVA: 0x004522B0 File Offset: 0x004504B0
		public IAngleRangeT UnPack()
		{
			IAngleRangeT angleRangeT = new IAngleRangeT();
			this.UnPackTo(angleRangeT);
			return angleRangeT;
		}

		// Token: 0x0601EED5 RID: 126677 RVA: 0x004522CB File Offset: 0x004504CB
		public void UnPackTo(IAngleRangeT _o)
		{
			_o.Min = this.Min;
			_o.Max = this.Max;
		}

		// Token: 0x0601EED6 RID: 126678 RVA: 0x004522E8 File Offset: 0x004504E8
		public static Offset<IAngleRange> Pack(FlatBufferBuilder builder, IAngleRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAngleRange>);
			}
			return IAngleRange.CreateIAngleRange(builder, _o.Min, _o.Max);
		}

		// Token: 0x0400DC2A RID: 56362
		private Table __p;
	}
}
