using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E6 RID: 26598
	public struct IFloatingSubtitleLanguageDiff : IFlatbufferObject
	{
		// Token: 0x1700C567 RID: 50535
		// (get) Token: 0x0602E4DD RID: 189661 RVA: 0x006525FD File Offset: 0x006507FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4DE RID: 189662 RVA: 0x0065260A File Offset: 0x0065080A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4DF RID: 189663 RVA: 0x00652614 File Offset: 0x00650814
		public static IFloatingSubtitleLanguageDiff GetRootAsIFloatingSubtitleLanguageDiff(ByteBuffer _bb)
		{
			return IFloatingSubtitleLanguageDiff.GetRootAsIFloatingSubtitleLanguageDiff(_bb, default(IFloatingSubtitleLanguageDiff));
		}

		// Token: 0x0602E4E0 RID: 189664 RVA: 0x00652630 File Offset: 0x00650830
		public static IFloatingSubtitleLanguageDiff GetRootAsIFloatingSubtitleLanguageDiff(ByteBuffer _bb, IFloatingSubtitleLanguageDiff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4E1 RID: 189665 RVA: 0x0065264D File Offset: 0x0065084D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4E2 RID: 189666 RVA: 0x0065265C File Offset: 0x0065085C
		public IFloatingSubtitleLanguageDiff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C568 RID: 50536
		// (get) Token: 0x0602E4E3 RID: 189667 RVA: 0x0065266C File Offset: 0x0065086C
		public EPreprocessOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreprocessOperation.FloatingSubtitleLanguageDiff;
				}
				return (EPreprocessOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E4E4 RID: 189668 RVA: 0x006526A8 File Offset: 0x006508A8
		public static Offset<IFloatingSubtitleLanguageDiff> CreateIFloatingSubtitleLanguageDiff(FlatBufferBuilder builder, EPreprocessOperation Type = EPreprocessOperation.FloatingSubtitleLanguageDiff)
		{
			builder.StartTable(1);
			IFloatingSubtitleLanguageDiff.AddType(builder, Type);
			return IFloatingSubtitleLanguageDiff.EndIFloatingSubtitleLanguageDiff(builder);
		}

		// Token: 0x0602E4E5 RID: 189669 RVA: 0x006526BE File Offset: 0x006508BE
		public static void StartIFloatingSubtitleLanguageDiff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E4E6 RID: 189670 RVA: 0x006526C7 File Offset: 0x006508C7
		public static void AddType(FlatBufferBuilder builder, EPreprocessOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E4E7 RID: 189671 RVA: 0x006526D2 File Offset: 0x006508D2
		public static Offset<IFloatingSubtitleLanguageDiff> EndIFloatingSubtitleLanguageDiff(FlatBufferBuilder builder)
		{
			return new Offset<IFloatingSubtitleLanguageDiff>(builder.EndTable());
		}

		// Token: 0x0602E4E8 RID: 189672 RVA: 0x006526E0 File Offset: 0x006508E0
		public IFloatingSubtitleLanguageDiffT UnPack()
		{
			IFloatingSubtitleLanguageDiffT floatingSubtitleLanguageDiffT = new IFloatingSubtitleLanguageDiffT();
			this.UnPackTo(floatingSubtitleLanguageDiffT);
			return floatingSubtitleLanguageDiffT;
		}

		// Token: 0x0602E4E9 RID: 189673 RVA: 0x006526FB File Offset: 0x006508FB
		public void UnPackTo(IFloatingSubtitleLanguageDiffT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E4EA RID: 189674 RVA: 0x0065270C File Offset: 0x0065090C
		public static Offset<IFloatingSubtitleLanguageDiff> Pack(FlatBufferBuilder builder, IFloatingSubtitleLanguageDiffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFloatingSubtitleLanguageDiff>);
			}
			return IFloatingSubtitleLanguageDiff.CreateIFloatingSubtitleLanguageDiff(builder, _o.Type);
		}

		// Token: 0x04010EFF RID: 69375
		private Table __p;
	}
}
