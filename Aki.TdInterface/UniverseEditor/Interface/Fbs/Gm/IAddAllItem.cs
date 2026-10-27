using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200462D RID: 17965
	public struct IAddAllItem : IFlatbufferObject
	{
		// Token: 0x17007F81 RID: 32641
		// (get) Token: 0x0601B351 RID: 111441 RVA: 0x003DFC06 File Offset: 0x003DDE06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B352 RID: 111442 RVA: 0x003DFC13 File Offset: 0x003DDE13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B353 RID: 111443 RVA: 0x003DFC1C File Offset: 0x003DDE1C
		public static IAddAllItem GetRootAsIAddAllItem(ByteBuffer _bb)
		{
			return IAddAllItem.GetRootAsIAddAllItem(_bb, default(IAddAllItem));
		}

		// Token: 0x0601B354 RID: 111444 RVA: 0x003DFC38 File Offset: 0x003DDE38
		public static IAddAllItem GetRootAsIAddAllItem(ByteBuffer _bb, IAddAllItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B355 RID: 111445 RVA: 0x003DFC55 File Offset: 0x003DDE55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B356 RID: 111446 RVA: 0x003DFC64 File Offset: 0x003DDE64
		public IAddAllItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F82 RID: 32642
		// (get) Token: 0x0601B357 RID: 111447 RVA: 0x003DFC74 File Offset: 0x003DDE74
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B358 RID: 111448 RVA: 0x003DFCB0 File Offset: 0x003DDEB0
		public static Offset<IAddAllItem> CreateIAddAllItem(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IAddAllItem.AddType(builder, Type);
			return IAddAllItem.EndIAddAllItem(builder);
		}

		// Token: 0x0601B359 RID: 111449 RVA: 0x003DFCC6 File Offset: 0x003DDEC6
		public static void StartIAddAllItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B35A RID: 111450 RVA: 0x003DFCCF File Offset: 0x003DDECF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B35B RID: 111451 RVA: 0x003DFCDA File Offset: 0x003DDEDA
		public static Offset<IAddAllItem> EndIAddAllItem(FlatBufferBuilder builder)
		{
			return new Offset<IAddAllItem>(builder.EndTable());
		}

		// Token: 0x0601B35C RID: 111452 RVA: 0x003DFCE8 File Offset: 0x003DDEE8
		public IAddAllItemT UnPack()
		{
			IAddAllItemT addAllItemT = new IAddAllItemT();
			this.UnPackTo(addAllItemT);
			return addAllItemT;
		}

		// Token: 0x0601B35D RID: 111453 RVA: 0x003DFD03 File Offset: 0x003DDF03
		public void UnPackTo(IAddAllItemT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B35E RID: 111454 RVA: 0x003DFD14 File Offset: 0x003DDF14
		public static Offset<IAddAllItem> Pack(FlatBufferBuilder builder, IAddAllItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddAllItem>);
			}
			return IAddAllItem.CreateIAddAllItem(builder, _o.Type);
		}

		// Token: 0x0400C7A6 RID: 51110
		private Table __p;
	}
}
