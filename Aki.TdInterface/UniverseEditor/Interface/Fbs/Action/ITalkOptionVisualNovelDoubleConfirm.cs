using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B30 RID: 31536
	public struct ITalkOptionVisualNovelDoubleConfirm : IFlatbufferObject
	{
		// Token: 0x1700EC3C RID: 60476
		// (get) Token: 0x06038CB3 RID: 232627 RVA: 0x007AE6E5 File Offset: 0x007AC8E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038CB4 RID: 232628 RVA: 0x007AE6F2 File Offset: 0x007AC8F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038CB5 RID: 232629 RVA: 0x007AE6FC File Offset: 0x007AC8FC
		public static ITalkOptionVisualNovelDoubleConfirm GetRootAsITalkOptionVisualNovelDoubleConfirm(ByteBuffer _bb)
		{
			return ITalkOptionVisualNovelDoubleConfirm.GetRootAsITalkOptionVisualNovelDoubleConfirm(_bb, default(ITalkOptionVisualNovelDoubleConfirm));
		}

		// Token: 0x06038CB6 RID: 232630 RVA: 0x007AE718 File Offset: 0x007AC918
		public static ITalkOptionVisualNovelDoubleConfirm GetRootAsITalkOptionVisualNovelDoubleConfirm(ByteBuffer _bb, ITalkOptionVisualNovelDoubleConfirm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038CB7 RID: 232631 RVA: 0x007AE735 File Offset: 0x007AC935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038CB8 RID: 232632 RVA: 0x007AE744 File Offset: 0x007AC944
		public ITalkOptionVisualNovelDoubleConfirm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC3D RID: 60477
		// (get) Token: 0x06038CB9 RID: 232633 RVA: 0x007AE754 File Offset: 0x007AC954
		public int ConfirmBoxId
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

		// Token: 0x06038CBA RID: 232634 RVA: 0x007AE790 File Offset: 0x007AC990
		public static Offset<ITalkOptionVisualNovelDoubleConfirm> CreateITalkOptionVisualNovelDoubleConfirm(FlatBufferBuilder builder, int ConfirmBoxId = 0)
		{
			builder.StartTable(1);
			ITalkOptionVisualNovelDoubleConfirm.AddConfirmBoxId(builder, ConfirmBoxId);
			return ITalkOptionVisualNovelDoubleConfirm.EndITalkOptionVisualNovelDoubleConfirm(builder);
		}

		// Token: 0x06038CBB RID: 232635 RVA: 0x007AE7A6 File Offset: 0x007AC9A6
		public static void StartITalkOptionVisualNovelDoubleConfirm(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038CBC RID: 232636 RVA: 0x007AE7AF File Offset: 0x007AC9AF
		public static void AddConfirmBoxId(FlatBufferBuilder builder, int confirmBoxId)
		{
			builder.AddInt(0, confirmBoxId, 0);
		}

		// Token: 0x06038CBD RID: 232637 RVA: 0x007AE7BA File Offset: 0x007AC9BA
		public static Offset<ITalkOptionVisualNovelDoubleConfirm> EndITalkOptionVisualNovelDoubleConfirm(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionVisualNovelDoubleConfirm>(builder.EndTable());
		}

		// Token: 0x06038CBE RID: 232638 RVA: 0x007AE7C8 File Offset: 0x007AC9C8
		public ITalkOptionVisualNovelDoubleConfirmT UnPack()
		{
			ITalkOptionVisualNovelDoubleConfirmT talkOptionVisualNovelDoubleConfirmT = new ITalkOptionVisualNovelDoubleConfirmT();
			this.UnPackTo(talkOptionVisualNovelDoubleConfirmT);
			return talkOptionVisualNovelDoubleConfirmT;
		}

		// Token: 0x06038CBF RID: 232639 RVA: 0x007AE7E3 File Offset: 0x007AC9E3
		public void UnPackTo(ITalkOptionVisualNovelDoubleConfirmT _o)
		{
			_o.ConfirmBoxId = this.ConfirmBoxId;
		}

		// Token: 0x06038CC0 RID: 232640 RVA: 0x007AE7F4 File Offset: 0x007AC9F4
		public static Offset<ITalkOptionVisualNovelDoubleConfirm> Pack(FlatBufferBuilder builder, ITalkOptionVisualNovelDoubleConfirmT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionVisualNovelDoubleConfirm>);
			}
			return ITalkOptionVisualNovelDoubleConfirm.CreateITalkOptionVisualNovelDoubleConfirm(builder, _o.ConfirmBoxId);
		}

		// Token: 0x0401315D RID: 78173
		private Table __p;
	}
}
