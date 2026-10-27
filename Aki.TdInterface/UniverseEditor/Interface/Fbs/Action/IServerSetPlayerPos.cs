using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8D RID: 28557
	public struct IServerSetPlayerPos : IFlatbufferObject
	{
		// Token: 0x1700D41A RID: 54298
		// (get) Token: 0x06032770 RID: 206704 RVA: 0x006CFE13 File Offset: 0x006CE013
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032771 RID: 206705 RVA: 0x006CFE20 File Offset: 0x006CE020
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032772 RID: 206706 RVA: 0x006CFE28 File Offset: 0x006CE028
		public static IServerSetPlayerPos GetRootAsIServerSetPlayerPos(ByteBuffer _bb)
		{
			return IServerSetPlayerPos.GetRootAsIServerSetPlayerPos(_bb, default(IServerSetPlayerPos));
		}

		// Token: 0x06032773 RID: 206707 RVA: 0x006CFE44 File Offset: 0x006CE044
		public static IServerSetPlayerPos GetRootAsIServerSetPlayerPos(ByteBuffer _bb, IServerSetPlayerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032774 RID: 206708 RVA: 0x006CFE61 File Offset: 0x006CE061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032775 RID: 206709 RVA: 0x006CFE70 File Offset: 0x006CE070
		public IServerSetPlayerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D41B RID: 54299
		// (get) Token: 0x06032776 RID: 206710 RVA: 0x006CFE80 File Offset: 0x006CE080
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

		// Token: 0x06032777 RID: 206711 RVA: 0x006CFEDD File Offset: 0x006CE0DD
		public static Offset<IServerSetPlayerPos> CreateIServerSetPlayerPos(FlatBufferBuilder builder, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(1);
			IServerSetPlayerPos.AddPos(builder, PosOffset);
			return IServerSetPlayerPos.EndIServerSetPlayerPos(builder);
		}

		// Token: 0x06032778 RID: 206712 RVA: 0x006CFEF3 File Offset: 0x006CE0F3
		public static void StartIServerSetPlayerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032779 RID: 206713 RVA: 0x006CFEFC File Offset: 0x006CE0FC
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0603277A RID: 206714 RVA: 0x006CFF0C File Offset: 0x006CE10C
		public static Offset<IServerSetPlayerPos> EndIServerSetPlayerPos(FlatBufferBuilder builder)
		{
			return new Offset<IServerSetPlayerPos>(builder.EndTable());
		}

		// Token: 0x0603277B RID: 206715 RVA: 0x006CFF1C File Offset: 0x006CE11C
		public IServerSetPlayerPosT UnPack()
		{
			IServerSetPlayerPosT serverSetPlayerPosT = new IServerSetPlayerPosT();
			this.UnPackTo(serverSetPlayerPosT);
			return serverSetPlayerPosT;
		}

		// Token: 0x0603277C RID: 206716 RVA: 0x006CFF38 File Offset: 0x006CE138
		public void UnPackTo(IServerSetPlayerPosT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0603277D RID: 206717 RVA: 0x006CFF74 File Offset: 0x006CE174
		public static Offset<IServerSetPlayerPos> Pack(FlatBufferBuilder builder, IServerSetPlayerPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IServerSetPlayerPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return IServerSetPlayerPos.CreateIServerSetPlayerPos(builder, posOffset);
		}

		// Token: 0x04011989 RID: 72073
		private Table __p;
	}
}
