using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE6 RID: 20454
	public struct ICheckPreloadCompleteLinkResource : IFlatbufferObject
	{
		// Token: 0x1700925A RID: 37466
		// (get) Token: 0x0601FE9F RID: 130719 RVA: 0x0046E8A8 File Offset: 0x0046CAA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FEA0 RID: 130720 RVA: 0x0046E8B5 File Offset: 0x0046CAB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FEA1 RID: 130721 RVA: 0x0046E8BC File Offset: 0x0046CABC
		public static ICheckPreloadCompleteLinkResource GetRootAsICheckPreloadCompleteLinkResource(ByteBuffer _bb)
		{
			return ICheckPreloadCompleteLinkResource.GetRootAsICheckPreloadCompleteLinkResource(_bb, default(ICheckPreloadCompleteLinkResource));
		}

		// Token: 0x0601FEA2 RID: 130722 RVA: 0x0046E8D8 File Offset: 0x0046CAD8
		public static ICheckPreloadCompleteLinkResource GetRootAsICheckPreloadCompleteLinkResource(ByteBuffer _bb, ICheckPreloadCompleteLinkResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FEA3 RID: 130723 RVA: 0x0046E8F5 File Offset: 0x0046CAF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FEA4 RID: 130724 RVA: 0x0046E904 File Offset: 0x0046CB04
		public ICheckPreloadCompleteLinkResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700925B RID: 37467
		// (get) Token: 0x0601FEA5 RID: 130725 RVA: 0x0046E914 File Offset: 0x0046CB14
		public ECheckPreloadCompleteObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckPreloadCompleteObjectType.PreloadLinkResource;
				}
				return (ECheckPreloadCompleteObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700925C RID: 37468
		// (get) Token: 0x0601FEA6 RID: 130726 RVA: 0x0046E950 File Offset: 0x0046CB50
		public int LinkResourceId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FEA7 RID: 130727 RVA: 0x0046E98C File Offset: 0x0046CB8C
		public static Offset<ICheckPreloadCompleteLinkResource> CreateICheckPreloadCompleteLinkResource(FlatBufferBuilder builder, ECheckPreloadCompleteObjectType Type = ECheckPreloadCompleteObjectType.PreloadLinkResource, int LinkResourceId = 0)
		{
			builder.StartTable(2);
			ICheckPreloadCompleteLinkResource.AddLinkResourceId(builder, LinkResourceId);
			ICheckPreloadCompleteLinkResource.AddType(builder, Type);
			return ICheckPreloadCompleteLinkResource.EndICheckPreloadCompleteLinkResource(builder);
		}

		// Token: 0x0601FEA8 RID: 130728 RVA: 0x0046E9A9 File Offset: 0x0046CBA9
		public static void StartICheckPreloadCompleteLinkResource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FEA9 RID: 130729 RVA: 0x0046E9B2 File Offset: 0x0046CBB2
		public static void AddType(FlatBufferBuilder builder, ECheckPreloadCompleteObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FEAA RID: 130730 RVA: 0x0046E9BD File Offset: 0x0046CBBD
		public static void AddLinkResourceId(FlatBufferBuilder builder, int linkResourceId)
		{
			builder.AddInt(1, linkResourceId, 0);
		}

		// Token: 0x0601FEAB RID: 130731 RVA: 0x0046E9C8 File Offset: 0x0046CBC8
		public static Offset<ICheckPreloadCompleteLinkResource> EndICheckPreloadCompleteLinkResource(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPreloadCompleteLinkResource>(builder.EndTable());
		}

		// Token: 0x0601FEAC RID: 130732 RVA: 0x0046E9D8 File Offset: 0x0046CBD8
		public ICheckPreloadCompleteLinkResourceT UnPack()
		{
			ICheckPreloadCompleteLinkResourceT checkPreloadCompleteLinkResourceT = new ICheckPreloadCompleteLinkResourceT();
			this.UnPackTo(checkPreloadCompleteLinkResourceT);
			return checkPreloadCompleteLinkResourceT;
		}

		// Token: 0x0601FEAD RID: 130733 RVA: 0x0046E9F3 File Offset: 0x0046CBF3
		public void UnPackTo(ICheckPreloadCompleteLinkResourceT _o)
		{
			_o.Type = this.Type;
			_o.LinkResourceId = this.LinkResourceId;
		}

		// Token: 0x0601FEAE RID: 130734 RVA: 0x0046EA10 File Offset: 0x0046CC10
		public static Offset<ICheckPreloadCompleteLinkResource> Pack(FlatBufferBuilder builder, ICheckPreloadCompleteLinkResourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPreloadCompleteLinkResource>);
			}
			return ICheckPreloadCompleteLinkResource.CreateICheckPreloadCompleteLinkResource(builder, _o.Type, _o.LinkResourceId);
		}

		// Token: 0x0400DE96 RID: 56982
		private Table __p;
	}
}
