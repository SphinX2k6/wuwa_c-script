using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706A RID: 28778
	public struct IItemFoundationMatch : IFlatbufferObject
	{
		// Token: 0x1700D2C4 RID: 53956
		// (get) Token: 0x06031E71 RID: 204401 RVA: 0x006C125A File Offset: 0x006BF45A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E72 RID: 204402 RVA: 0x006C1267 File Offset: 0x006BF467
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E73 RID: 204403 RVA: 0x006C1270 File Offset: 0x006BF470
		public static IItemFoundationMatch GetRootAsIItemFoundationMatch(ByteBuffer _bb)
		{
			return IItemFoundationMatch.GetRootAsIItemFoundationMatch(_bb, default(IItemFoundationMatch));
		}

		// Token: 0x06031E74 RID: 204404 RVA: 0x006C128C File Offset: 0x006BF48C
		public static IItemFoundationMatch GetRootAsIItemFoundationMatch(ByteBuffer _bb, IItemFoundationMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E75 RID: 204405 RVA: 0x006C12A9 File Offset: 0x006BF4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E76 RID: 204406 RVA: 0x006C12B8 File Offset: 0x006BF4B8
		public IItemFoundationMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2C5 RID: 53957
		// (get) Token: 0x06031E77 RID: 204407 RVA: 0x006C12C8 File Offset: 0x006BF4C8
		public int MatchEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031E78 RID: 204408 RVA: 0x006C1304 File Offset: 0x006BF504
		public static Offset<IItemFoundationMatch> CreateIItemFoundationMatch(FlatBufferBuilder builder, int MatchEntityId = 0)
		{
			builder.StartTable(1);
			IItemFoundationMatch.AddMatchEntityId(builder, MatchEntityId);
			return IItemFoundationMatch.EndIItemFoundationMatch(builder);
		}

		// Token: 0x06031E79 RID: 204409 RVA: 0x006C131A File Offset: 0x006BF51A
		public static void StartIItemFoundationMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031E7A RID: 204410 RVA: 0x006C1323 File Offset: 0x006BF523
		public static void AddMatchEntityId(FlatBufferBuilder builder, int matchEntityId)
		{
			builder.AddInt(0, matchEntityId, 0);
		}

		// Token: 0x06031E7B RID: 204411 RVA: 0x006C132E File Offset: 0x006BF52E
		public static Offset<IItemFoundationMatch> EndIItemFoundationMatch(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundationMatch>(builder.EndTable());
		}

		// Token: 0x06031E7C RID: 204412 RVA: 0x006C133C File Offset: 0x006BF53C
		public IItemFoundationMatchT UnPack()
		{
			IItemFoundationMatchT itemFoundationMatchT = new IItemFoundationMatchT();
			this.UnPackTo(itemFoundationMatchT);
			return itemFoundationMatchT;
		}

		// Token: 0x06031E7D RID: 204413 RVA: 0x006C1357 File Offset: 0x006BF557
		public void UnPackTo(IItemFoundationMatchT _o)
		{
			_o.MatchEntityId = this.MatchEntityId;
		}

		// Token: 0x06031E7E RID: 204414 RVA: 0x006C1368 File Offset: 0x006BF568
		public static Offset<IItemFoundationMatch> Pack(FlatBufferBuilder builder, IItemFoundationMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemFoundationMatch>);
			}
			return IItemFoundationMatch.CreateIItemFoundationMatch(builder, _o.MatchEntityId);
		}

		// Token: 0x04011FD2 RID: 73682
		private Table __p;
	}
}
