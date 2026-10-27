using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DD RID: 26589
	public struct IFixTeleControllerPos : IFlatbufferObject
	{
		// Token: 0x1700C55C RID: 50524
		// (get) Token: 0x0602E4A0 RID: 189600 RVA: 0x006520AF File Offset: 0x006502AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4A1 RID: 189601 RVA: 0x006520BC File Offset: 0x006502BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4A2 RID: 189602 RVA: 0x006520C4 File Offset: 0x006502C4
		public static IFixTeleControllerPos GetRootAsIFixTeleControllerPos(ByteBuffer _bb)
		{
			return IFixTeleControllerPos.GetRootAsIFixTeleControllerPos(_bb, default(IFixTeleControllerPos));
		}

		// Token: 0x0602E4A3 RID: 189603 RVA: 0x006520E0 File Offset: 0x006502E0
		public static IFixTeleControllerPos GetRootAsIFixTeleControllerPos(ByteBuffer _bb, IFixTeleControllerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4A4 RID: 189604 RVA: 0x006520FD File Offset: 0x006502FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4A5 RID: 189605 RVA: 0x0065210C File Offset: 0x0065030C
		public IFixTeleControllerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E4A6 RID: 189606 RVA: 0x0065211C File Offset: 0x0065031C
		public static void StartIFixTeleControllerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E4A7 RID: 189607 RVA: 0x00652125 File Offset: 0x00650325
		public static Offset<IFixTeleControllerPos> EndIFixTeleControllerPos(FlatBufferBuilder builder)
		{
			return new Offset<IFixTeleControllerPos>(builder.EndTable());
		}

		// Token: 0x0602E4A8 RID: 189608 RVA: 0x00652134 File Offset: 0x00650334
		public IFixTeleControllerPosT UnPack()
		{
			IFixTeleControllerPosT fixTeleControllerPosT = new IFixTeleControllerPosT();
			this.UnPackTo(fixTeleControllerPosT);
			return fixTeleControllerPosT;
		}

		// Token: 0x0602E4A9 RID: 189609 RVA: 0x0065214F File Offset: 0x0065034F
		public void UnPackTo(IFixTeleControllerPosT _o)
		{
		}

		// Token: 0x0602E4AA RID: 189610 RVA: 0x00652154 File Offset: 0x00650354
		public static Offset<IFixTeleControllerPos> Pack(FlatBufferBuilder builder, IFixTeleControllerPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixTeleControllerPos>);
			}
			IFixTeleControllerPos.StartIFixTeleControllerPos(builder);
			return IFixTeleControllerPos.EndIFixTeleControllerPos(builder);
		}

		// Token: 0x04010EF8 RID: 69368
		private Table __p;
	}
}
