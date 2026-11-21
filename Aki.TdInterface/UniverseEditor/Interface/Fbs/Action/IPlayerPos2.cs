using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007486 RID: 29830
	public struct IPlayerPos2 : IFlatbufferObject
	{
		// Token: 0x1700DB23 RID: 56099
		// (get) Token: 0x0603438A RID: 213898 RVA: 0x00708ACD File Offset: 0x00706CCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603438B RID: 213899 RVA: 0x00708ADA File Offset: 0x00706CDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603438C RID: 213900 RVA: 0x00708AE4 File Offset: 0x00706CE4
		public static IPlayerPos2 GetRootAsIPlayerPos2(ByteBuffer _bb)
		{
			return IPlayerPos2.GetRootAsIPlayerPos2(_bb, default(IPlayerPos2));
		}

		// Token: 0x0603438D RID: 213901 RVA: 0x00708B00 File Offset: 0x00706D00
		public static IPlayerPos2 GetRootAsIPlayerPos2(ByteBuffer _bb, IPlayerPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603438E RID: 213902 RVA: 0x00708B1D File Offset: 0x00706D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603438F RID: 213903 RVA: 0x00708B2C File Offset: 0x00706D2C
		public IPlayerPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB24 RID: 56100
		// (get) Token: 0x06034390 RID: 213904 RVA: 0x00708B3C File Offset: 0x00706D3C
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB25 RID: 56101
		// (get) Token: 0x06034391 RID: 213905 RVA: 0x00708B78 File Offset: 0x00706D78
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06034392 RID: 213906 RVA: 0x00708BD5 File Offset: 0x00706DD5
		public static Offset<IPlayerPos2> CreateIPlayerPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPlayerPos2.AddOffset(builder, OffsetOffset);
			IPlayerPos2.AddType(builder, Type);
			return IPlayerPos2.EndIPlayerPos2(builder);
		}

		// Token: 0x06034393 RID: 213907 RVA: 0x00708BF2 File Offset: 0x00706DF2
		public static void StartIPlayerPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034394 RID: 213908 RVA: 0x00708BFB File Offset: 0x00706DFB
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034395 RID: 213909 RVA: 0x00708C06 File Offset: 0x00706E06
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x06034396 RID: 213910 RVA: 0x00708C16 File Offset: 0x00706E16
		public static Offset<IPlayerPos2> EndIPlayerPos2(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerPos2>(builder.EndTable());
		}

		// Token: 0x06034397 RID: 213911 RVA: 0x00708C24 File Offset: 0x00706E24
		public IPlayerPos2T UnPack()
		{
			IPlayerPos2T playerPos2T = new IPlayerPos2T();
			this.UnPackTo(playerPos2T);
			return playerPos2T;
		}

		// Token: 0x06034398 RID: 213912 RVA: 0x00708C40 File Offset: 0x00706E40
		public void UnPackTo(IPlayerPos2T _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x06034399 RID: 213913 RVA: 0x00708C88 File Offset: 0x00706E88
		public static Offset<IPlayerPos2> Pack(FlatBufferBuilder builder, IPlayerPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IPlayerPos2.CreateIPlayerPos2(builder, _o.Type, offsetOffset);
		}

		// Token: 0x04012601 RID: 75265
		private Table __p;
	}
}
