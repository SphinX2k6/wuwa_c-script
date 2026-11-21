using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006973 RID: 26995
	public struct IChangeInteractOptionText : IFlatbufferObject
	{
		// Token: 0x1700C6BD RID: 50877
		// (get) Token: 0x0602E4A0 RID: 189600 RVA: 0x00652093 File Offset: 0x00650293
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4A1 RID: 189601 RVA: 0x006520A0 File Offset: 0x006502A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4A2 RID: 189602 RVA: 0x006520A8 File Offset: 0x006502A8
		public static IChangeInteractOptionText GetRootAsIChangeInteractOptionText(ByteBuffer _bb)
		{
			return IChangeInteractOptionText.GetRootAsIChangeInteractOptionText(_bb, default(IChangeInteractOptionText));
		}

		// Token: 0x0602E4A3 RID: 189603 RVA: 0x006520C4 File Offset: 0x006502C4
		public static IChangeInteractOptionText GetRootAsIChangeInteractOptionText(ByteBuffer _bb, IChangeInteractOptionText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4A4 RID: 189604 RVA: 0x006520E1 File Offset: 0x006502E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4A5 RID: 189605 RVA: 0x006520F0 File Offset: 0x006502F0
		public IChangeInteractOptionText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6BE RID: 50878
		// (get) Token: 0x0602E4A6 RID: 189606 RVA: 0x00652100 File Offset: 0x00650300
		public string TidContent
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E4A7 RID: 189607 RVA: 0x00652137 File Offset: 0x00650337
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E4A8 RID: 189608 RVA: 0x00652146 File Offset: 0x00650346
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E4A9 RID: 189609 RVA: 0x00652154 File Offset: 0x00650354
		public static Offset<IChangeInteractOptionText> CreateIChangeInteractOptionText(FlatBufferBuilder builder, StringOffset TidContentOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IChangeInteractOptionText.AddTidContent(builder, TidContentOffset);
			return IChangeInteractOptionText.EndIChangeInteractOptionText(builder);
		}

		// Token: 0x0602E4AA RID: 189610 RVA: 0x0065216A File Offset: 0x0065036A
		public static void StartIChangeInteractOptionText(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E4AB RID: 189611 RVA: 0x00652173 File Offset: 0x00650373
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(0, tidContentOffset.Value, 0);
		}

		// Token: 0x0602E4AC RID: 189612 RVA: 0x00652183 File Offset: 0x00650383
		public static Offset<IChangeInteractOptionText> EndIChangeInteractOptionText(FlatBufferBuilder builder)
		{
			return new Offset<IChangeInteractOptionText>(builder.EndTable());
		}

		// Token: 0x0602E4AD RID: 189613 RVA: 0x00652190 File Offset: 0x00650390
		public IChangeInteractOptionTextT UnPack()
		{
			IChangeInteractOptionTextT changeInteractOptionTextT = new IChangeInteractOptionTextT();
			this.UnPackTo(changeInteractOptionTextT);
			return changeInteractOptionTextT;
		}

		// Token: 0x0602E4AE RID: 189614 RVA: 0x006521AB File Offset: 0x006503AB
		public void UnPackTo(IChangeInteractOptionTextT _o)
		{
			_o.TidContent = this.TidContent;
		}

		// Token: 0x0602E4AF RID: 189615 RVA: 0x006521BC File Offset: 0x006503BC
		public static Offset<IChangeInteractOptionText> Pack(FlatBufferBuilder builder, IChangeInteractOptionTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeInteractOptionText>);
			}
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			return IChangeInteractOptionText.CreateIChangeInteractOptionText(builder, tidContentOffset);
		}

		// Token: 0x040116D7 RID: 71383
		private Table __p;
	}
}
