using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007007 RID: 28679
	public struct ISetJigsawFoundation : IFlatbufferObject
	{
		// Token: 0x1700D503 RID: 54531
		// (get) Token: 0x06032BAF RID: 207791 RVA: 0x006D8541 File Offset: 0x006D6741
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BB0 RID: 207792 RVA: 0x006D854E File Offset: 0x006D674E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BB1 RID: 207793 RVA: 0x006D8558 File Offset: 0x006D6758
		public static ISetJigsawFoundation GetRootAsISetJigsawFoundation(ByteBuffer _bb)
		{
			return ISetJigsawFoundation.GetRootAsISetJigsawFoundation(_bb, default(ISetJigsawFoundation));
		}

		// Token: 0x06032BB2 RID: 207794 RVA: 0x006D8574 File Offset: 0x006D6774
		public static ISetJigsawFoundation GetRootAsISetJigsawFoundation(ByteBuffer _bb, ISetJigsawFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BB3 RID: 207795 RVA: 0x006D8591 File Offset: 0x006D6791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BB4 RID: 207796 RVA: 0x006D85A0 File Offset: 0x006D67A0
		public ISetJigsawFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D504 RID: 54532
		// (get) Token: 0x06032BB5 RID: 207797 RVA: 0x006D85B0 File Offset: 0x006D67B0
		public ISetPieceState? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISetPieceState?(default(ISetPieceState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032BB6 RID: 207798 RVA: 0x006D860D File Offset: 0x006D680D
		public static Offset<ISetJigsawFoundation> CreateISetJigsawFoundation(FlatBufferBuilder builder, Offset<ISetPieceState> ConfigOffset = default(Offset<ISetPieceState>))
		{
			builder.StartTable(1);
			ISetJigsawFoundation.AddConfig(builder, ConfigOffset);
			return ISetJigsawFoundation.EndISetJigsawFoundation(builder);
		}

		// Token: 0x06032BB7 RID: 207799 RVA: 0x006D8623 File Offset: 0x006D6823
		public static void StartISetJigsawFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BB8 RID: 207800 RVA: 0x006D862C File Offset: 0x006D682C
		public static void AddConfig(FlatBufferBuilder builder, Offset<ISetPieceState> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06032BB9 RID: 207801 RVA: 0x006D863C File Offset: 0x006D683C
		public static Offset<ISetJigsawFoundation> EndISetJigsawFoundation(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawFoundation>(builder.EndTable());
		}

		// Token: 0x06032BBA RID: 207802 RVA: 0x006D864C File Offset: 0x006D684C
		public ISetJigsawFoundationT UnPack()
		{
			ISetJigsawFoundationT setJigsawFoundationT = new ISetJigsawFoundationT();
			this.UnPackTo(setJigsawFoundationT);
			return setJigsawFoundationT;
		}

		// Token: 0x06032BBB RID: 207803 RVA: 0x006D8668 File Offset: 0x006D6868
		public void UnPackTo(ISetJigsawFoundationT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06032BBC RID: 207804 RVA: 0x006D86A4 File Offset: 0x006D68A4
		public static Offset<ISetJigsawFoundation> Pack(FlatBufferBuilder builder, ISetJigsawFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawFoundation>);
			}
			Offset<ISetPieceState> configOffset = (_o.Config == null) ? default(Offset<ISetPieceState>) : ISetPieceState.Pack(builder, _o.Config);
			return ISetJigsawFoundation.CreateISetJigsawFoundation(builder, configOffset);
		}

		// Token: 0x04011A2B RID: 72235
		private Table __p;
	}
}
