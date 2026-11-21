using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D9 RID: 30681
	public struct ISetJigsawItem : IFlatbufferObject
	{
		// Token: 0x1700E0DF RID: 57567
		// (get) Token: 0x06035E45 RID: 220741 RVA: 0x007385F6 File Offset: 0x007367F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E46 RID: 220742 RVA: 0x00738603 File Offset: 0x00736803
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E47 RID: 220743 RVA: 0x0073860C File Offset: 0x0073680C
		public static ISetJigsawItem GetRootAsISetJigsawItem(ByteBuffer _bb)
		{
			return ISetJigsawItem.GetRootAsISetJigsawItem(_bb, default(ISetJigsawItem));
		}

		// Token: 0x06035E48 RID: 220744 RVA: 0x00738628 File Offset: 0x00736828
		public static ISetJigsawItem GetRootAsISetJigsawItem(ByteBuffer _bb, ISetJigsawItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E49 RID: 220745 RVA: 0x00738645 File Offset: 0x00736845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E4A RID: 220746 RVA: 0x00738654 File Offset: 0x00736854
		public ISetJigsawItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0E0 RID: 57568
		// (get) Token: 0x06035E4B RID: 220747 RVA: 0x00738664 File Offset: 0x00736864
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

		// Token: 0x06035E4C RID: 220748 RVA: 0x007386C1 File Offset: 0x007368C1
		public static Offset<ISetJigsawItem> CreateISetJigsawItem(FlatBufferBuilder builder, Offset<IMoveJigsawItem> ConfigOffset = default(Offset<IMoveJigsawItem>))
		{
			builder.StartTable(1);
			ISetJigsawItem.AddConfig(builder, ConfigOffset);
			return ISetJigsawItem.EndISetJigsawItem(builder);
		}

		// Token: 0x06035E4D RID: 220749 RVA: 0x007386D7 File Offset: 0x007368D7
		public static void StartISetJigsawItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E4E RID: 220750 RVA: 0x007386E0 File Offset: 0x007368E0
		public static void AddConfig(FlatBufferBuilder builder, Offset<IMoveJigsawItem> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06035E4F RID: 220751 RVA: 0x007386F0 File Offset: 0x007368F0
		public static Offset<ISetJigsawItem> EndISetJigsawItem(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawItem>(builder.EndTable());
		}

		// Token: 0x06035E50 RID: 220752 RVA: 0x00738700 File Offset: 0x00736900
		public ISetJigsawItemT UnPack()
		{
			ISetJigsawItemT setJigsawItemT = new ISetJigsawItemT();
			this.UnPackTo(setJigsawItemT);
			return setJigsawItemT;
		}

		// Token: 0x06035E51 RID: 220753 RVA: 0x0073871C File Offset: 0x0073691C
		public void UnPackTo(ISetJigsawItemT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06035E52 RID: 220754 RVA: 0x00738758 File Offset: 0x00736958
		public static Offset<ISetJigsawItem> Pack(FlatBufferBuilder builder, ISetJigsawItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawItem>);
			}
			Offset<IMoveJigsawItem> configOffset = (_o.Config == null) ? default(Offset<IMoveJigsawItem>) : IMoveJigsawItem.Pack(builder, _o.Config);
			return ISetJigsawItem.CreateISetJigsawItem(builder, configOffset);
		}

		// Token: 0x04012A1A RID: 76314
		private Table __p;
	}
}
