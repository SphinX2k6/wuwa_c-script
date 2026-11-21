using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A9 RID: 29353
	public struct IMoveToPosA : IFlatbufferObject
	{
		// Token: 0x1700D726 RID: 55078
		// (get) Token: 0x0603327C RID: 209532 RVA: 0x006E705F File Offset: 0x006E525F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603327D RID: 209533 RVA: 0x006E706C File Offset: 0x006E526C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603327E RID: 209534 RVA: 0x006E7074 File Offset: 0x006E5274
		public static IMoveToPosA GetRootAsIMoveToPosA(ByteBuffer _bb)
		{
			return IMoveToPosA.GetRootAsIMoveToPosA(_bb, default(IMoveToPosA));
		}

		// Token: 0x0603327F RID: 209535 RVA: 0x006E7090 File Offset: 0x006E5290
		public static IMoveToPosA GetRootAsIMoveToPosA(ByteBuffer _bb, IMoveToPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033280 RID: 209536 RVA: 0x006E70AD File Offset: 0x006E52AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033281 RID: 209537 RVA: 0x006E70BC File Offset: 0x006E52BC
		public IMoveToPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D727 RID: 55079
		// (get) Token: 0x06033282 RID: 209538 RVA: 0x006E70CC File Offset: 0x006E52CC
		public float Timeout
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

		// Token: 0x1700D728 RID: 55080
		// (get) Token: 0x06033283 RID: 209539 RVA: 0x006E710C File Offset: 0x006E530C
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06033284 RID: 209540 RVA: 0x006E7169 File Offset: 0x006E5369
		public static Offset<IMoveToPosA> CreateIMoveToPosA(FlatBufferBuilder builder, float Timeout = 0f, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			IMoveToPosA.AddPos(builder, PosOffset);
			IMoveToPosA.AddTimeout(builder, Timeout);
			return IMoveToPosA.EndIMoveToPosA(builder);
		}

		// Token: 0x06033285 RID: 209541 RVA: 0x006E7186 File Offset: 0x006E5386
		public static void StartIMoveToPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033286 RID: 209542 RVA: 0x006E718F File Offset: 0x006E538F
		public static void AddTimeout(FlatBufferBuilder builder, float timeout)
		{
			builder.AddFloat(0, timeout, 0.0);
		}

		// Token: 0x06033287 RID: 209543 RVA: 0x006E71A2 File Offset: 0x006E53A2
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06033288 RID: 209544 RVA: 0x006E71B2 File Offset: 0x006E53B2
		public static Offset<IMoveToPosA> EndIMoveToPosA(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToPosA>(builder.EndTable());
		}

		// Token: 0x06033289 RID: 209545 RVA: 0x006E71C0 File Offset: 0x006E53C0
		public IMoveToPosAT UnPack()
		{
			IMoveToPosAT moveToPosAT = new IMoveToPosAT();
			this.UnPackTo(moveToPosAT);
			return moveToPosAT;
		}

		// Token: 0x0603328A RID: 209546 RVA: 0x006E71DC File Offset: 0x006E53DC
		public void UnPackTo(IMoveToPosAT _o)
		{
			_o.Timeout = this.Timeout;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0603328B RID: 209547 RVA: 0x006E7224 File Offset: 0x006E5424
		public static Offset<IMoveToPosA> Pack(FlatBufferBuilder builder, IMoveToPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveToPosA>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return IMoveToPosA.CreateIMoveToPosA(builder, _o.Timeout, posOffset);
		}

		// Token: 0x04012339 RID: 74553
		private Table __p;
	}
}
