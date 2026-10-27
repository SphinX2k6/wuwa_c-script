using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705B RID: 28763
	public struct ISetPosA : IFlatbufferObject
	{
		// Token: 0x1700D5D2 RID: 54738
		// (get) Token: 0x06032EE4 RID: 208612 RVA: 0x006DF25D File Offset: 0x006DD45D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032EE5 RID: 208613 RVA: 0x006DF26A File Offset: 0x006DD46A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032EE6 RID: 208614 RVA: 0x006DF274 File Offset: 0x006DD474
		public static ISetPosA GetRootAsISetPosA(ByteBuffer _bb)
		{
			return ISetPosA.GetRootAsISetPosA(_bb, default(ISetPosA));
		}

		// Token: 0x06032EE7 RID: 208615 RVA: 0x006DF290 File Offset: 0x006DD490
		public static ISetPosA GetRootAsISetPosA(ByteBuffer _bb, ISetPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032EE8 RID: 208616 RVA: 0x006DF2AD File Offset: 0x006DD4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032EE9 RID: 208617 RVA: 0x006DF2BC File Offset: 0x006DD4BC
		public ISetPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5D3 RID: 54739
		// (get) Token: 0x06032EEA RID: 208618 RVA: 0x006DF2CC File Offset: 0x006DD4CC
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032EEB RID: 208619 RVA: 0x006DF329 File Offset: 0x006DD529
		public static Offset<ISetPosA> CreateISetPosA(FlatBufferBuilder builder, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(1);
			ISetPosA.AddPos(builder, PosOffset);
			return ISetPosA.EndISetPosA(builder);
		}

		// Token: 0x06032EEC RID: 208620 RVA: 0x006DF33F File Offset: 0x006DD53F
		public static void StartISetPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032EED RID: 208621 RVA: 0x006DF348 File Offset: 0x006DD548
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x06032EEE RID: 208622 RVA: 0x006DF358 File Offset: 0x006DD558
		public static Offset<ISetPosA> EndISetPosA(FlatBufferBuilder builder)
		{
			return new Offset<ISetPosA>(builder.EndTable());
		}

		// Token: 0x06032EEF RID: 208623 RVA: 0x006DF368 File Offset: 0x006DD568
		public ISetPosAT UnPack()
		{
			ISetPosAT setPosAT = new ISetPosAT();
			this.UnPackTo(setPosAT);
			return setPosAT;
		}

		// Token: 0x06032EF0 RID: 208624 RVA: 0x006DF384 File Offset: 0x006DD584
		public void UnPackTo(ISetPosAT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x06032EF1 RID: 208625 RVA: 0x006DF3C0 File Offset: 0x006DD5C0
		public static Offset<ISetPosA> Pack(FlatBufferBuilder builder, ISetPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPosA>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ISetPosA.CreateISetPosA(builder, posOffset);
		}

		// Token: 0x04011ABD RID: 72381
		private Table __p;
	}
}
