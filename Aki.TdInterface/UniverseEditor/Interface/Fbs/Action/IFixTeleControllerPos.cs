using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5D RID: 28253
	public struct IFixTeleControllerPos : IFlatbufferObject
	{
		// Token: 0x1700CF12 RID: 53010
		// (get) Token: 0x06030CE6 RID: 199910 RVA: 0x0069F7F3 File Offset: 0x0069D9F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CE7 RID: 199911 RVA: 0x0069F800 File Offset: 0x0069DA00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CE8 RID: 199912 RVA: 0x0069F808 File Offset: 0x0069DA08
		public static IFixTeleControllerPos GetRootAsIFixTeleControllerPos(ByteBuffer _bb)
		{
			return IFixTeleControllerPos.GetRootAsIFixTeleControllerPos(_bb, default(IFixTeleControllerPos));
		}

		// Token: 0x06030CE9 RID: 199913 RVA: 0x0069F824 File Offset: 0x0069DA24
		public static IFixTeleControllerPos GetRootAsIFixTeleControllerPos(ByteBuffer _bb, IFixTeleControllerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CEA RID: 199914 RVA: 0x0069F841 File Offset: 0x0069DA41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CEB RID: 199915 RVA: 0x0069F850 File Offset: 0x0069DA50
		public IFixTeleControllerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030CEC RID: 199916 RVA: 0x0069F860 File Offset: 0x0069DA60
		public static void StartIFixTeleControllerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030CED RID: 199917 RVA: 0x0069F869 File Offset: 0x0069DA69
		public static Offset<IFixTeleControllerPos> EndIFixTeleControllerPos(FlatBufferBuilder builder)
		{
			return new Offset<IFixTeleControllerPos>(builder.EndTable());
		}

		// Token: 0x06030CEE RID: 199918 RVA: 0x0069F878 File Offset: 0x0069DA78
		public IFixTeleControllerPosT UnPack()
		{
			IFixTeleControllerPosT fixTeleControllerPosT = new IFixTeleControllerPosT();
			this.UnPackTo(fixTeleControllerPosT);
			return fixTeleControllerPosT;
		}

		// Token: 0x06030CEF RID: 199919 RVA: 0x0069F893 File Offset: 0x0069DA93
		public void UnPackTo(IFixTeleControllerPosT _o)
		{
		}

		// Token: 0x06030CF0 RID: 199920 RVA: 0x0069F898 File Offset: 0x0069DA98
		public static Offset<IFixTeleControllerPos> Pack(FlatBufferBuilder builder, IFixTeleControllerPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixTeleControllerPos>);
			}
			IFixTeleControllerPos.StartIFixTeleControllerPos(builder);
			return IFixTeleControllerPos.EndIFixTeleControllerPos(builder);
		}

		// Token: 0x04011D2A RID: 73002
		private Table __p;
	}
}
