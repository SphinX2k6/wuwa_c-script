using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005338 RID: 21304
	public struct IGroupAiModeDefault : IFlatbufferObject
	{
		// Token: 0x17009C80 RID: 40064
		// (get) Token: 0x06022D60 RID: 142688 RVA: 0x004D39C9 File Offset: 0x004D1BC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D61 RID: 142689 RVA: 0x004D39D6 File Offset: 0x004D1BD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D62 RID: 142690 RVA: 0x004D39E0 File Offset: 0x004D1BE0
		public static IGroupAiModeDefault GetRootAsIGroupAiModeDefault(ByteBuffer _bb)
		{
			return IGroupAiModeDefault.GetRootAsIGroupAiModeDefault(_bb, default(IGroupAiModeDefault));
		}

		// Token: 0x06022D63 RID: 142691 RVA: 0x004D39FC File Offset: 0x004D1BFC
		public static IGroupAiModeDefault GetRootAsIGroupAiModeDefault(ByteBuffer _bb, IGroupAiModeDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D64 RID: 142692 RVA: 0x004D3A19 File Offset: 0x004D1C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D65 RID: 142693 RVA: 0x004D3A28 File Offset: 0x004D1C28
		public IGroupAiModeDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C81 RID: 40065
		// (get) Token: 0x06022D66 RID: 142694 RVA: 0x004D3A38 File Offset: 0x004D1C38
		public EGroupAiMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiMode.Default;
				}
				return (EGroupAiMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022D67 RID: 142695 RVA: 0x004D3A74 File Offset: 0x004D1C74
		public static Offset<IGroupAiModeDefault> CreateIGroupAiModeDefault(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default)
		{
			builder.StartTable(1);
			IGroupAiModeDefault.AddType(builder, Type);
			return IGroupAiModeDefault.EndIGroupAiModeDefault(builder);
		}

		// Token: 0x06022D68 RID: 142696 RVA: 0x004D3A8A File Offset: 0x004D1C8A
		public static void StartIGroupAiModeDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022D69 RID: 142697 RVA: 0x004D3A93 File Offset: 0x004D1C93
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022D6A RID: 142698 RVA: 0x004D3A9E File Offset: 0x004D1C9E
		public static Offset<IGroupAiModeDefault> EndIGroupAiModeDefault(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiModeDefault>(builder.EndTable());
		}

		// Token: 0x06022D6B RID: 142699 RVA: 0x004D3AAC File Offset: 0x004D1CAC
		public IGroupAiModeDefaultT UnPack()
		{
			IGroupAiModeDefaultT groupAiModeDefaultT = new IGroupAiModeDefaultT();
			this.UnPackTo(groupAiModeDefaultT);
			return groupAiModeDefaultT;
		}

		// Token: 0x06022D6C RID: 142700 RVA: 0x004D3AC7 File Offset: 0x004D1CC7
		public void UnPackTo(IGroupAiModeDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022D6D RID: 142701 RVA: 0x004D3AD8 File Offset: 0x004D1CD8
		public static Offset<IGroupAiModeDefault> Pack(FlatBufferBuilder builder, IGroupAiModeDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiModeDefault>);
			}
			return IGroupAiModeDefault.CreateIGroupAiModeDefault(builder, _o.Type);
		}

		// Token: 0x0400E4FE RID: 58622
		private Table __p;
	}
}
