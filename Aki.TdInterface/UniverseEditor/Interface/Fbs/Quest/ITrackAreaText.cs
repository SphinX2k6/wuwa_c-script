using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004640 RID: 17984
	public struct ITrackAreaText : IFlatbufferObject
	{
		// Token: 0x17007DDC RID: 32220
		// (get) Token: 0x0601A550 RID: 107856 RVA: 0x003BF780 File Offset: 0x003BD980
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A551 RID: 107857 RVA: 0x003BF78D File Offset: 0x003BD98D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A552 RID: 107858 RVA: 0x003BF794 File Offset: 0x003BD994
		public static ITrackAreaText GetRootAsITrackAreaText(ByteBuffer _bb)
		{
			return ITrackAreaText.GetRootAsITrackAreaText(_bb, default(ITrackAreaText));
		}

		// Token: 0x0601A553 RID: 107859 RVA: 0x003BF7B0 File Offset: 0x003BD9B0
		public static ITrackAreaText GetRootAsITrackAreaText(ByteBuffer _bb, ITrackAreaText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A554 RID: 107860 RVA: 0x003BF7CD File Offset: 0x003BD9CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A555 RID: 107861 RVA: 0x003BF7DC File Offset: 0x003BD9DC
		public ITrackAreaText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DDD RID: 32221
		// (get) Token: 0x0601A556 RID: 107862 RVA: 0x003BF7EC File Offset: 0x003BD9EC
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007DDE RID: 32222
		// (get) Token: 0x0601A557 RID: 107863 RVA: 0x003BF82C File Offset: 0x003BDA2C
		public string Tid
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A558 RID: 107864 RVA: 0x003BF863 File Offset: 0x003BDA63
		public Span<byte> GetTidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A559 RID: 107865 RVA: 0x003BF872 File Offset: 0x003BDA72
		public byte[] GetTidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601A55A RID: 107866 RVA: 0x003BF880 File Offset: 0x003BDA80
		public static Offset<ITrackAreaText> CreateITrackAreaText(FlatBufferBuilder builder, bool Show = false, StringOffset TidOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITrackAreaText.AddTid(builder, TidOffset);
			ITrackAreaText.AddShow(builder, Show);
			return ITrackAreaText.EndITrackAreaText(builder);
		}

		// Token: 0x0601A55B RID: 107867 RVA: 0x003BF89D File Offset: 0x003BDA9D
		public static void StartITrackAreaText(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A55C RID: 107868 RVA: 0x003BF8A6 File Offset: 0x003BDAA6
		public static void AddShow(FlatBufferBuilder builder, bool show)
		{
			builder.AddBool(0, show, false);
		}

		// Token: 0x0601A55D RID: 107869 RVA: 0x003BF8B1 File Offset: 0x003BDAB1
		public static void AddTid(FlatBufferBuilder builder, StringOffset tidOffset)
		{
			builder.AddOffset(1, tidOffset.Value, 0);
		}

		// Token: 0x0601A55E RID: 107870 RVA: 0x003BF8C1 File Offset: 0x003BDAC1
		public static Offset<ITrackAreaText> EndITrackAreaText(FlatBufferBuilder builder)
		{
			return new Offset<ITrackAreaText>(builder.EndTable());
		}

		// Token: 0x0601A55F RID: 107871 RVA: 0x003BF8D0 File Offset: 0x003BDAD0
		public ITrackAreaTextT UnPack()
		{
			ITrackAreaTextT trackAreaTextT = new ITrackAreaTextT();
			this.UnPackTo(trackAreaTextT);
			return trackAreaTextT;
		}

		// Token: 0x0601A560 RID: 107872 RVA: 0x003BF8EB File Offset: 0x003BDAEB
		public void UnPackTo(ITrackAreaTextT _o)
		{
			_o.Show = this.Show;
			_o.Tid = this.Tid;
		}

		// Token: 0x0601A561 RID: 107873 RVA: 0x003BF908 File Offset: 0x003BDB08
		public static Offset<ITrackAreaText> Pack(FlatBufferBuilder builder, ITrackAreaTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackAreaText>);
			}
			StringOffset tidOffset = (_o.Tid == null) ? default(StringOffset) : builder.CreateString(_o.Tid);
			return ITrackAreaText.CreateITrackAreaText(builder, _o.Show, tidOffset);
		}

		// Token: 0x0400C846 RID: 51270
		private Table __p;
	}
}
