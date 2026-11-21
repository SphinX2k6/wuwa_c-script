using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E02 RID: 15874
	public struct IBvbCardFilterBase : IFlatbufferObject
	{
		// Token: 0x17006B39 RID: 27449
		// (get) Token: 0x0601553F RID: 87359 RVA: 0x003150B1 File Offset: 0x003132B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015540 RID: 87360 RVA: 0x003150BE File Offset: 0x003132BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015541 RID: 87361 RVA: 0x003150C8 File Offset: 0x003132C8
		public static IBvbCardFilterBase GetRootAsIBvbCardFilterBase(ByteBuffer _bb)
		{
			return IBvbCardFilterBase.GetRootAsIBvbCardFilterBase(_bb, default(IBvbCardFilterBase));
		}

		// Token: 0x06015542 RID: 87362 RVA: 0x003150E4 File Offset: 0x003132E4
		public static IBvbCardFilterBase GetRootAsIBvbCardFilterBase(ByteBuffer _bb, IBvbCardFilterBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015543 RID: 87363 RVA: 0x00315101 File Offset: 0x00313301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015544 RID: 87364 RVA: 0x00315110 File Offset: 0x00313310
		public IBvbCardFilterBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B3A RID: 27450
		// (get) Token: 0x06015545 RID: 87365 RVA: 0x00315120 File Offset: 0x00313320
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x0031515C File Offset: 0x0031335C
		public static Offset<IBvbCardFilterBase> CreateIBvbCardFilterBase(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost)
		{
			builder.StartTable(1);
			IBvbCardFilterBase.AddType(builder, Type);
			return IBvbCardFilterBase.EndIBvbCardFilterBase(builder);
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x00315172 File Offset: 0x00313372
		public static void StartIBvbCardFilterBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015548 RID: 87368 RVA: 0x0031517B File Offset: 0x0031337B
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015549 RID: 87369 RVA: 0x00315186 File Offset: 0x00313386
		public static Offset<IBvbCardFilterBase> EndIBvbCardFilterBase(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterBase>(builder.EndTable());
		}

		// Token: 0x0601554A RID: 87370 RVA: 0x00315194 File Offset: 0x00313394
		public IBvbCardFilterBaseT UnPack()
		{
			IBvbCardFilterBaseT bvbCardFilterBaseT = new IBvbCardFilterBaseT();
			this.UnPackTo(bvbCardFilterBaseT);
			return bvbCardFilterBaseT;
		}

		// Token: 0x0601554B RID: 87371 RVA: 0x003151AF File Offset: 0x003133AF
		public void UnPackTo(IBvbCardFilterBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601554C RID: 87372 RVA: 0x003151C0 File Offset: 0x003133C0
		public static Offset<IBvbCardFilterBase> Pack(FlatBufferBuilder builder, IBvbCardFilterBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterBase>);
			}
			return IBvbCardFilterBase.CreateIBvbCardFilterBase(builder, _o.Type);
		}

		// Token: 0x0400B7C0 RID: 47040
		private Table __p;
	}
}
