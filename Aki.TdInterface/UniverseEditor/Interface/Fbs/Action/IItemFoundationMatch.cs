using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BA RID: 27066
	public struct IItemFoundationMatch : IFlatbufferObject
	{
		// Token: 0x1700C8C4 RID: 51396
		// (get) Token: 0x0602F4B1 RID: 193713 RVA: 0x00670F02 File Offset: 0x0066F102
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4B2 RID: 193714 RVA: 0x00670F0F File Offset: 0x0066F10F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4B3 RID: 193715 RVA: 0x00670F18 File Offset: 0x0066F118
		public static IItemFoundationMatch GetRootAsIItemFoundationMatch(ByteBuffer _bb)
		{
			return IItemFoundationMatch.GetRootAsIItemFoundationMatch(_bb, default(IItemFoundationMatch));
		}

		// Token: 0x0602F4B4 RID: 193716 RVA: 0x00670F34 File Offset: 0x0066F134
		public static IItemFoundationMatch GetRootAsIItemFoundationMatch(ByteBuffer _bb, IItemFoundationMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4B5 RID: 193717 RVA: 0x00670F51 File Offset: 0x0066F151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4B6 RID: 193718 RVA: 0x00670F60 File Offset: 0x0066F160
		public IItemFoundationMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8C5 RID: 51397
		// (get) Token: 0x0602F4B7 RID: 193719 RVA: 0x00670F70 File Offset: 0x0066F170
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

		// Token: 0x0602F4B8 RID: 193720 RVA: 0x00670FAC File Offset: 0x0066F1AC
		public static Offset<IItemFoundationMatch> CreateIItemFoundationMatch(FlatBufferBuilder builder, int MatchEntityId = 0)
		{
			builder.StartTable(1);
			IItemFoundationMatch.AddMatchEntityId(builder, MatchEntityId);
			return IItemFoundationMatch.EndIItemFoundationMatch(builder);
		}

		// Token: 0x0602F4B9 RID: 193721 RVA: 0x00670FC2 File Offset: 0x0066F1C2
		public static void StartIItemFoundationMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F4BA RID: 193722 RVA: 0x00670FCB File Offset: 0x0066F1CB
		public static void AddMatchEntityId(FlatBufferBuilder builder, int matchEntityId)
		{
			builder.AddInt(0, matchEntityId, 0);
		}

		// Token: 0x0602F4BB RID: 193723 RVA: 0x00670FD6 File Offset: 0x0066F1D6
		public static Offset<IItemFoundationMatch> EndIItemFoundationMatch(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundationMatch>(builder.EndTable());
		}

		// Token: 0x0602F4BC RID: 193724 RVA: 0x00670FE4 File Offset: 0x0066F1E4
		public IItemFoundationMatchT UnPack()
		{
			IItemFoundationMatchT itemFoundationMatchT = new IItemFoundationMatchT();
			this.UnPackTo(itemFoundationMatchT);
			return itemFoundationMatchT;
		}

		// Token: 0x0602F4BD RID: 193725 RVA: 0x00670FFF File Offset: 0x0066F1FF
		public void UnPackTo(IItemFoundationMatchT _o)
		{
			_o.MatchEntityId = this.MatchEntityId;
		}

		// Token: 0x0602F4BE RID: 193726 RVA: 0x00671010 File Offset: 0x0066F210
		public static Offset<IItemFoundationMatch> Pack(FlatBufferBuilder builder, IItemFoundationMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemFoundationMatch>);
			}
			return IItemFoundationMatch.CreateIItemFoundationMatch(builder, _o.MatchEntityId);
		}

		// Token: 0x04011168 RID: 69992
		private Table __p;
	}
}
