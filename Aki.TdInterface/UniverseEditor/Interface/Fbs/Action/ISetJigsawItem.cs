using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007010 RID: 28688
	public struct ISetJigsawItem : IFlatbufferObject
	{
		// Token: 0x1700D50B RID: 54539
		// (get) Token: 0x06032BDF RID: 207839 RVA: 0x006D89B2 File Offset: 0x006D6BB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BE0 RID: 207840 RVA: 0x006D89BF File Offset: 0x006D6BBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BE1 RID: 207841 RVA: 0x006D89C8 File Offset: 0x006D6BC8
		public static ISetJigsawItem GetRootAsISetJigsawItem(ByteBuffer _bb)
		{
			return ISetJigsawItem.GetRootAsISetJigsawItem(_bb, default(ISetJigsawItem));
		}

		// Token: 0x06032BE2 RID: 207842 RVA: 0x006D89E4 File Offset: 0x006D6BE4
		public static ISetJigsawItem GetRootAsISetJigsawItem(ByteBuffer _bb, ISetJigsawItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BE3 RID: 207843 RVA: 0x006D8A01 File Offset: 0x006D6C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BE4 RID: 207844 RVA: 0x006D8A10 File Offset: 0x006D6C10
		public ISetJigsawItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D50C RID: 54540
		// (get) Token: 0x06032BE5 RID: 207845 RVA: 0x006D8A20 File Offset: 0x006D6C20
		public IMoveJigsawItem? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMoveJigsawItem?(default(IMoveJigsawItem).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032BE6 RID: 207846 RVA: 0x006D8A7D File Offset: 0x006D6C7D
		public static Offset<ISetJigsawItem> CreateISetJigsawItem(FlatBufferBuilder builder, Offset<IMoveJigsawItem> ConfigOffset = default(Offset<IMoveJigsawItem>))
		{
			builder.StartTable(1);
			ISetJigsawItem.AddConfig(builder, ConfigOffset);
			return ISetJigsawItem.EndISetJigsawItem(builder);
		}

		// Token: 0x06032BE7 RID: 207847 RVA: 0x006D8A93 File Offset: 0x006D6C93
		public static void StartISetJigsawItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BE8 RID: 207848 RVA: 0x006D8A9C File Offset: 0x006D6C9C
		public static void AddConfig(FlatBufferBuilder builder, Offset<IMoveJigsawItem> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06032BE9 RID: 207849 RVA: 0x006D8AAC File Offset: 0x006D6CAC
		public static Offset<ISetJigsawItem> EndISetJigsawItem(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawItem>(builder.EndTable());
		}

		// Token: 0x06032BEA RID: 207850 RVA: 0x006D8ABC File Offset: 0x006D6CBC
		public ISetJigsawItemT UnPack()
		{
			ISetJigsawItemT setJigsawItemT = new ISetJigsawItemT();
			this.UnPackTo(setJigsawItemT);
			return setJigsawItemT;
		}

		// Token: 0x06032BEB RID: 207851 RVA: 0x006D8AD8 File Offset: 0x006D6CD8
		public void UnPackTo(ISetJigsawItemT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06032BEC RID: 207852 RVA: 0x006D8B14 File Offset: 0x006D6D14
		public static Offset<ISetJigsawItem> Pack(FlatBufferBuilder builder, ISetJigsawItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawItem>);
			}
			Offset<IMoveJigsawItem> configOffset = (_o.Config == null) ? default(Offset<IMoveJigsawItem>) : IMoveJigsawItem.Pack(builder, _o.Config);
			return ISetJigsawItem.CreateISetJigsawItem(builder, configOffset);
		}

		// Token: 0x04011A35 RID: 72245
		private Table __p;
	}
}
