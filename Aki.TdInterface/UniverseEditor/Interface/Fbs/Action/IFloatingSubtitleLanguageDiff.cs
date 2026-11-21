using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E66 RID: 28262
	public struct IFloatingSubtitleLanguageDiff : IFlatbufferObject
	{
		// Token: 0x1700CF1D RID: 53021
		// (get) Token: 0x06030D23 RID: 199971 RVA: 0x0069FD41 File Offset: 0x0069DF41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D24 RID: 199972 RVA: 0x0069FD4E File Offset: 0x0069DF4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D25 RID: 199973 RVA: 0x0069FD58 File Offset: 0x0069DF58
		public static IFloatingSubtitleLanguageDiff GetRootAsIFloatingSubtitleLanguageDiff(ByteBuffer _bb)
		{
			return IFloatingSubtitleLanguageDiff.GetRootAsIFloatingSubtitleLanguageDiff(_bb, default(IFloatingSubtitleLanguageDiff));
		}

		// Token: 0x06030D26 RID: 199974 RVA: 0x0069FD74 File Offset: 0x0069DF74
		public static IFloatingSubtitleLanguageDiff GetRootAsIFloatingSubtitleLanguageDiff(ByteBuffer _bb, IFloatingSubtitleLanguageDiff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D27 RID: 199975 RVA: 0x0069FD91 File Offset: 0x0069DF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D28 RID: 199976 RVA: 0x0069FDA0 File Offset: 0x0069DFA0
		public IFloatingSubtitleLanguageDiff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF1E RID: 53022
		// (get) Token: 0x06030D29 RID: 199977 RVA: 0x0069FDB0 File Offset: 0x0069DFB0
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

		// Token: 0x06030D2A RID: 199978 RVA: 0x0069FDEC File Offset: 0x0069DFEC
		public static Offset<IFloatingSubtitleLanguageDiff> CreateIFloatingSubtitleLanguageDiff(FlatBufferBuilder builder, EPreprocessOperation Type = EPreprocessOperation.FloatingSubtitleLanguageDiff)
		{
			builder.StartTable(1);
			IFloatingSubtitleLanguageDiff.AddType(builder, Type);
			return IFloatingSubtitleLanguageDiff.EndIFloatingSubtitleLanguageDiff(builder);
		}

		// Token: 0x06030D2B RID: 199979 RVA: 0x0069FE02 File Offset: 0x0069E002
		public static void StartIFloatingSubtitleLanguageDiff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030D2C RID: 199980 RVA: 0x0069FE0B File Offset: 0x0069E00B
		public static void AddType(FlatBufferBuilder builder, EPreprocessOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030D2D RID: 199981 RVA: 0x0069FE16 File Offset: 0x0069E016
		public static Offset<IFloatingSubtitleLanguageDiff> EndIFloatingSubtitleLanguageDiff(FlatBufferBuilder builder)
		{
			return new Offset<IFloatingSubtitleLanguageDiff>(builder.EndTable());
		}

		// Token: 0x06030D2E RID: 199982 RVA: 0x0069FE24 File Offset: 0x0069E024
		public IFloatingSubtitleLanguageDiffT UnPack()
		{
			IFloatingSubtitleLanguageDiffT floatingSubtitleLanguageDiffT = new IFloatingSubtitleLanguageDiffT();
			this.UnPackTo(floatingSubtitleLanguageDiffT);
			return floatingSubtitleLanguageDiffT;
		}

		// Token: 0x06030D2F RID: 199983 RVA: 0x0069FE3F File Offset: 0x0069E03F
		public void UnPackTo(IFloatingSubtitleLanguageDiffT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030D30 RID: 199984 RVA: 0x0069FE50 File Offset: 0x0069E050
		public static Offset<IFloatingSubtitleLanguageDiff> Pack(FlatBufferBuilder builder, IFloatingSubtitleLanguageDiffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFloatingSubtitleLanguageDiff>);
			}
			return IFloatingSubtitleLanguageDiff.CreateIFloatingSubtitleLanguageDiff(builder, _o.Type);
		}

		// Token: 0x04011D31 RID: 73009
		private Table __p;
	}
}
