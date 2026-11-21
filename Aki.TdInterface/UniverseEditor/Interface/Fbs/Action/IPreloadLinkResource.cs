using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007510 RID: 29968
	public struct IPreloadLinkResource : IFlatbufferObject
	{
		// Token: 0x1700DC89 RID: 56457
		// (get) Token: 0x060348D7 RID: 215255 RVA: 0x00712D78 File Offset: 0x00710F78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060348D8 RID: 215256 RVA: 0x00712D85 File Offset: 0x00710F85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060348D9 RID: 215257 RVA: 0x00712D8C File Offset: 0x00710F8C
		public static IPreloadLinkResource GetRootAsIPreloadLinkResource(ByteBuffer _bb)
		{
			return IPreloadLinkResource.GetRootAsIPreloadLinkResource(_bb, default(IPreloadLinkResource));
		}

		// Token: 0x060348DA RID: 215258 RVA: 0x00712DA8 File Offset: 0x00710FA8
		public static IPreloadLinkResource GetRootAsIPreloadLinkResource(ByteBuffer _bb, IPreloadLinkResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060348DB RID: 215259 RVA: 0x00712DC5 File Offset: 0x00710FC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060348DC RID: 215260 RVA: 0x00712DD4 File Offset: 0x00710FD4
		public IPreloadLinkResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC8A RID: 56458
		// (get) Token: 0x060348DD RID: 215261 RVA: 0x00712DE4 File Offset: 0x00710FE4
		public EPreloadObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return (EPreloadObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC8B RID: 56459
		// (get) Token: 0x060348DE RID: 215262 RVA: 0x00712E20 File Offset: 0x00711020
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

		// Token: 0x060348DF RID: 215263 RVA: 0x00712E5C File Offset: 0x0071105C
		public static Offset<IPreloadLinkResource> CreateIPreloadLinkResource(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, int LinkResourceId = 0)
		{
			builder.StartTable(2);
			IPreloadLinkResource.AddLinkResourceId(builder, LinkResourceId);
			IPreloadLinkResource.AddType(builder, Type);
			return IPreloadLinkResource.EndIPreloadLinkResource(builder);
		}

		// Token: 0x060348E0 RID: 215264 RVA: 0x00712E79 File Offset: 0x00711079
		public static void StartIPreloadLinkResource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060348E1 RID: 215265 RVA: 0x00712E82 File Offset: 0x00711082
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060348E2 RID: 215266 RVA: 0x00712E8D File Offset: 0x0071108D
		public static void AddLinkResourceId(FlatBufferBuilder builder, int linkResourceId)
		{
			builder.AddInt(1, linkResourceId, 0);
		}

		// Token: 0x060348E3 RID: 215267 RVA: 0x00712E98 File Offset: 0x00711098
		public static Offset<IPreloadLinkResource> EndIPreloadLinkResource(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadLinkResource>(builder.EndTable());
		}

		// Token: 0x060348E4 RID: 215268 RVA: 0x00712EA8 File Offset: 0x007110A8
		public IPreloadLinkResourceT UnPack()
		{
			IPreloadLinkResourceT preloadLinkResourceT = new IPreloadLinkResourceT();
			this.UnPackTo(preloadLinkResourceT);
			return preloadLinkResourceT;
		}

		// Token: 0x060348E5 RID: 215269 RVA: 0x00712EC3 File Offset: 0x007110C3
		public void UnPackTo(IPreloadLinkResourceT _o)
		{
			_o.Type = this.Type;
			_o.LinkResourceId = this.LinkResourceId;
		}

		// Token: 0x060348E6 RID: 215270 RVA: 0x00712EE0 File Offset: 0x007110E0
		public static Offset<IPreloadLinkResource> Pack(FlatBufferBuilder builder, IPreloadLinkResourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadLinkResource>);
			}
			return IPreloadLinkResource.CreateIPreloadLinkResource(builder, _o.Type, _o.LinkResourceId);
		}

		// Token: 0x040126E4 RID: 75492
		private Table __p;
	}
}
