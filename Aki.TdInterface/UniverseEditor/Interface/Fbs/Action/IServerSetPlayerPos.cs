using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007753 RID: 30547
	public struct IServerSetPlayerPos : IFlatbufferObject
	{
		// Token: 0x1700DFE9 RID: 57321
		// (get) Token: 0x060359C0 RID: 219584 RVA: 0x0072F7CB File Offset: 0x0072D9CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060359C1 RID: 219585 RVA: 0x0072F7D8 File Offset: 0x0072D9D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060359C2 RID: 219586 RVA: 0x0072F7E0 File Offset: 0x0072D9E0
		public static IServerSetPlayerPos GetRootAsIServerSetPlayerPos(ByteBuffer _bb)
		{
			return IServerSetPlayerPos.GetRootAsIServerSetPlayerPos(_bb, default(IServerSetPlayerPos));
		}

		// Token: 0x060359C3 RID: 219587 RVA: 0x0072F7FC File Offset: 0x0072D9FC
		public static IServerSetPlayerPos GetRootAsIServerSetPlayerPos(ByteBuffer _bb, IServerSetPlayerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060359C4 RID: 219588 RVA: 0x0072F819 File Offset: 0x0072DA19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060359C5 RID: 219589 RVA: 0x0072F828 File Offset: 0x0072DA28
		public IServerSetPlayerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFEA RID: 57322
		// (get) Token: 0x060359C6 RID: 219590 RVA: 0x0072F838 File Offset: 0x0072DA38
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

		// Token: 0x060359C7 RID: 219591 RVA: 0x0072F895 File Offset: 0x0072DA95
		public static Offset<IServerSetPlayerPos> CreateIServerSetPlayerPos(FlatBufferBuilder builder, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(1);
			IServerSetPlayerPos.AddPos(builder, PosOffset);
			return IServerSetPlayerPos.EndIServerSetPlayerPos(builder);
		}

		// Token: 0x060359C8 RID: 219592 RVA: 0x0072F8AB File Offset: 0x0072DAAB
		public static void StartIServerSetPlayerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060359C9 RID: 219593 RVA: 0x0072F8B4 File Offset: 0x0072DAB4
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060359CA RID: 219594 RVA: 0x0072F8C4 File Offset: 0x0072DAC4
		public static Offset<IServerSetPlayerPos> EndIServerSetPlayerPos(FlatBufferBuilder builder)
		{
			return new Offset<IServerSetPlayerPos>(builder.EndTable());
		}

		// Token: 0x060359CB RID: 219595 RVA: 0x0072F8D4 File Offset: 0x0072DAD4
		public IServerSetPlayerPosT UnPack()
		{
			IServerSetPlayerPosT serverSetPlayerPosT = new IServerSetPlayerPosT();
			this.UnPackTo(serverSetPlayerPosT);
			return serverSetPlayerPosT;
		}

		// Token: 0x060359CC RID: 219596 RVA: 0x0072F8F0 File Offset: 0x0072DAF0
		public void UnPackTo(IServerSetPlayerPosT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x060359CD RID: 219597 RVA: 0x0072F92C File Offset: 0x0072DB2C
		public static Offset<IServerSetPlayerPos> Pack(FlatBufferBuilder builder, IServerSetPlayerPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IServerSetPlayerPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return IServerSetPlayerPos.CreateIServerSetPlayerPos(builder, posOffset);
		}

		// Token: 0x0401296B RID: 76139
		private Table __p;
	}
}
