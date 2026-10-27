using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E58 RID: 28248
	public struct IRemovePreloadLinkResource : IFlatbufferObject
	{
		// Token: 0x1700D26E RID: 53870
		// (get) Token: 0x06031EA4 RID: 204452 RVA: 0x006C0E94 File Offset: 0x006BF094
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031EA5 RID: 204453 RVA: 0x006C0EA1 File Offset: 0x006BF0A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031EA6 RID: 204454 RVA: 0x006C0EA8 File Offset: 0x006BF0A8
		public static IRemovePreloadLinkResource GetRootAsIRemovePreloadLinkResource(ByteBuffer _bb)
		{
			return IRemovePreloadLinkResource.GetRootAsIRemovePreloadLinkResource(_bb, default(IRemovePreloadLinkResource));
		}

		// Token: 0x06031EA7 RID: 204455 RVA: 0x006C0EC4 File Offset: 0x006BF0C4
		public static IRemovePreloadLinkResource GetRootAsIRemovePreloadLinkResource(ByteBuffer _bb, IRemovePreloadLinkResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031EA8 RID: 204456 RVA: 0x006C0EE1 File Offset: 0x006BF0E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031EA9 RID: 204457 RVA: 0x006C0EF0 File Offset: 0x006BF0F0
		public IRemovePreloadLinkResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D26F RID: 53871
		// (get) Token: 0x06031EAA RID: 204458 RVA: 0x006C0F00 File Offset: 0x006BF100
		public ERemovePreloadResourceObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return (ERemovePreloadResourceObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D270 RID: 53872
		// (get) Token: 0x06031EAB RID: 204459 RVA: 0x006C0F3C File Offset: 0x006BF13C
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

		// Token: 0x06031EAC RID: 204460 RVA: 0x006C0F78 File Offset: 0x006BF178
		public static Offset<IRemovePreloadLinkResource> CreateIRemovePreloadLinkResource(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, int LinkResourceId = 0)
		{
			builder.StartTable(2);
			IRemovePreloadLinkResource.AddLinkResourceId(builder, LinkResourceId);
			IRemovePreloadLinkResource.AddType(builder, Type);
			return IRemovePreloadLinkResource.EndIRemovePreloadLinkResource(builder);
		}

		// Token: 0x06031EAD RID: 204461 RVA: 0x006C0F95 File Offset: 0x006BF195
		public static void StartIRemovePreloadLinkResource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031EAE RID: 204462 RVA: 0x006C0F9E File Offset: 0x006BF19E
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031EAF RID: 204463 RVA: 0x006C0FA9 File Offset: 0x006BF1A9
		public static void AddLinkResourceId(FlatBufferBuilder builder, int linkResourceId)
		{
			builder.AddInt(1, linkResourceId, 0);
		}

		// Token: 0x06031EB0 RID: 204464 RVA: 0x006C0FB4 File Offset: 0x006BF1B4
		public static Offset<IRemovePreloadLinkResource> EndIRemovePreloadLinkResource(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadLinkResource>(builder.EndTable());
		}

		// Token: 0x06031EB1 RID: 204465 RVA: 0x006C0FC4 File Offset: 0x006BF1C4
		public IRemovePreloadLinkResourceT UnPack()
		{
			IRemovePreloadLinkResourceT removePreloadLinkResourceT = new IRemovePreloadLinkResourceT();
			this.UnPackTo(removePreloadLinkResourceT);
			return removePreloadLinkResourceT;
		}

		// Token: 0x06031EB2 RID: 204466 RVA: 0x006C0FDF File Offset: 0x006BF1DF
		public void UnPackTo(IRemovePreloadLinkResourceT _o)
		{
			_o.Type = this.Type;
			_o.LinkResourceId = this.LinkResourceId;
		}

		// Token: 0x06031EB3 RID: 204467 RVA: 0x006C0FFC File Offset: 0x006BF1FC
		public static Offset<IRemovePreloadLinkResource> Pack(FlatBufferBuilder builder, IRemovePreloadLinkResourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadLinkResource>);
			}
			return IRemovePreloadLinkResource.CreateIRemovePreloadLinkResource(builder, _o.Type, _o.LinkResourceId);
		}

		// Token: 0x0401183D RID: 71741
		private Table __p;
	}
}
