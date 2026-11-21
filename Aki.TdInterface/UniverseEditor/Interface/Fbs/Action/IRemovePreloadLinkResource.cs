using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D9 RID: 30169
	public struct IRemovePreloadLinkResource : IFlatbufferObject
	{
		// Token: 0x1700DDC0 RID: 56768
		// (get) Token: 0x06034ECC RID: 216780 RVA: 0x0071C994 File Offset: 0x0071AB94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034ECD RID: 216781 RVA: 0x0071C9A1 File Offset: 0x0071ABA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034ECE RID: 216782 RVA: 0x0071C9A8 File Offset: 0x0071ABA8
		public static IRemovePreloadLinkResource GetRootAsIRemovePreloadLinkResource(ByteBuffer _bb)
		{
			return IRemovePreloadLinkResource.GetRootAsIRemovePreloadLinkResource(_bb, default(IRemovePreloadLinkResource));
		}

		// Token: 0x06034ECF RID: 216783 RVA: 0x0071C9C4 File Offset: 0x0071ABC4
		public static IRemovePreloadLinkResource GetRootAsIRemovePreloadLinkResource(ByteBuffer _bb, IRemovePreloadLinkResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034ED0 RID: 216784 RVA: 0x0071C9E1 File Offset: 0x0071ABE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034ED1 RID: 216785 RVA: 0x0071C9F0 File Offset: 0x0071ABF0
		public IRemovePreloadLinkResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDC1 RID: 56769
		// (get) Token: 0x06034ED2 RID: 216786 RVA: 0x0071CA00 File Offset: 0x0071AC00
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

		// Token: 0x1700DDC2 RID: 56770
		// (get) Token: 0x06034ED3 RID: 216787 RVA: 0x0071CA3C File Offset: 0x0071AC3C
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

		// Token: 0x06034ED4 RID: 216788 RVA: 0x0071CA78 File Offset: 0x0071AC78
		public static Offset<IRemovePreloadLinkResource> CreateIRemovePreloadLinkResource(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, int LinkResourceId = 0)
		{
			builder.StartTable(2);
			IRemovePreloadLinkResource.AddLinkResourceId(builder, LinkResourceId);
			IRemovePreloadLinkResource.AddType(builder, Type);
			return IRemovePreloadLinkResource.EndIRemovePreloadLinkResource(builder);
		}

		// Token: 0x06034ED5 RID: 216789 RVA: 0x0071CA95 File Offset: 0x0071AC95
		public static void StartIRemovePreloadLinkResource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034ED6 RID: 216790 RVA: 0x0071CA9E File Offset: 0x0071AC9E
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034ED7 RID: 216791 RVA: 0x0071CAA9 File Offset: 0x0071ACA9
		public static void AddLinkResourceId(FlatBufferBuilder builder, int linkResourceId)
		{
			builder.AddInt(1, linkResourceId, 0);
		}

		// Token: 0x06034ED8 RID: 216792 RVA: 0x0071CAB4 File Offset: 0x0071ACB4
		public static Offset<IRemovePreloadLinkResource> EndIRemovePreloadLinkResource(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadLinkResource>(builder.EndTable());
		}

		// Token: 0x06034ED9 RID: 216793 RVA: 0x0071CAC4 File Offset: 0x0071ACC4
		public IRemovePreloadLinkResourceT UnPack()
		{
			IRemovePreloadLinkResourceT removePreloadLinkResourceT = new IRemovePreloadLinkResourceT();
			this.UnPackTo(removePreloadLinkResourceT);
			return removePreloadLinkResourceT;
		}

		// Token: 0x06034EDA RID: 216794 RVA: 0x0071CADF File Offset: 0x0071ACDF
		public void UnPackTo(IRemovePreloadLinkResourceT _o)
		{
			_o.Type = this.Type;
			_o.LinkResourceId = this.LinkResourceId;
		}

		// Token: 0x06034EDB RID: 216795 RVA: 0x0071CAFC File Offset: 0x0071ACFC
		public static Offset<IRemovePreloadLinkResource> Pack(FlatBufferBuilder builder, IRemovePreloadLinkResourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadLinkResource>);
			}
			return IRemovePreloadLinkResource.CreateIRemovePreloadLinkResource(builder, _o.Type, _o.LinkResourceId);
		}

		// Token: 0x040127BF RID: 75711
		private Table __p;
	}
}
