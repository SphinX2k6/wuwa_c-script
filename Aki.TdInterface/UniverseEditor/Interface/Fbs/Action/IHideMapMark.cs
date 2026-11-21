using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA4 RID: 28580
	public struct IHideMapMark : IFlatbufferObject
	{
		// Token: 0x1700D157 RID: 53591
		// (get) Token: 0x060317AD RID: 202669 RVA: 0x006B512C File Offset: 0x006B332C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060317AE RID: 202670 RVA: 0x006B5139 File Offset: 0x006B3339
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060317AF RID: 202671 RVA: 0x006B5140 File Offset: 0x006B3340
		public static IHideMapMark GetRootAsIHideMapMark(ByteBuffer _bb)
		{
			return IHideMapMark.GetRootAsIHideMapMark(_bb, default(IHideMapMark));
		}

		// Token: 0x060317B0 RID: 202672 RVA: 0x006B515C File Offset: 0x006B335C
		public static IHideMapMark GetRootAsIHideMapMark(ByteBuffer _bb, IHideMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060317B1 RID: 202673 RVA: 0x006B5179 File Offset: 0x006B3379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060317B2 RID: 202674 RVA: 0x006B5188 File Offset: 0x006B3388
		public IHideMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D158 RID: 53592
		// (get) Token: 0x060317B3 RID: 202675 RVA: 0x006B5198 File Offset: 0x006B3398
		public EMapMarkState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkState.Show;
				}
				return (EMapMarkState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D159 RID: 53593
		// (get) Token: 0x060317B4 RID: 202676 RVA: 0x006B51D4 File Offset: 0x006B33D4
		public int MarkId
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

		// Token: 0x060317B5 RID: 202677 RVA: 0x006B5210 File Offset: 0x006B3410
		public static Offset<IHideMapMark> CreateIHideMapMark(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show, int MarkId = 0)
		{
			builder.StartTable(2);
			IHideMapMark.AddMarkId(builder, MarkId);
			IHideMapMark.AddType(builder, Type);
			return IHideMapMark.EndIHideMapMark(builder);
		}

		// Token: 0x060317B6 RID: 202678 RVA: 0x006B522D File Offset: 0x006B342D
		public static void StartIHideMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060317B7 RID: 202679 RVA: 0x006B5236 File Offset: 0x006B3436
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060317B8 RID: 202680 RVA: 0x006B5241 File Offset: 0x006B3441
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x060317B9 RID: 202681 RVA: 0x006B524C File Offset: 0x006B344C
		public static Offset<IHideMapMark> EndIHideMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IHideMapMark>(builder.EndTable());
		}

		// Token: 0x060317BA RID: 202682 RVA: 0x006B525C File Offset: 0x006B345C
		public IHideMapMarkT UnPack()
		{
			IHideMapMarkT hideMapMarkT = new IHideMapMarkT();
			this.UnPackTo(hideMapMarkT);
			return hideMapMarkT;
		}

		// Token: 0x060317BB RID: 202683 RVA: 0x006B5277 File Offset: 0x006B3477
		public void UnPackTo(IHideMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
		}

		// Token: 0x060317BC RID: 202684 RVA: 0x006B5294 File Offset: 0x006B3494
		public static Offset<IHideMapMark> Pack(FlatBufferBuilder builder, IHideMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideMapMark>);
			}
			return IHideMapMark.CreateIHideMapMark(builder, _o.Type, _o.MarkId);
		}

		// Token: 0x04011ECD RID: 73421
		private Table __p;
	}
}
