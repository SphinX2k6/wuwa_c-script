using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D95 RID: 28053
	public struct IPreloadLinkResource : IFlatbufferObject
	{
		// Token: 0x1700D141 RID: 53569
		// (get) Token: 0x060318DB RID: 202971 RVA: 0x006B7690 File Offset: 0x006B5890
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060318DC RID: 202972 RVA: 0x006B769D File Offset: 0x006B589D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060318DD RID: 202973 RVA: 0x006B76A4 File Offset: 0x006B58A4
		public static IPreloadLinkResource GetRootAsIPreloadLinkResource(ByteBuffer _bb)
		{
			return IPreloadLinkResource.GetRootAsIPreloadLinkResource(_bb, default(IPreloadLinkResource));
		}

		// Token: 0x060318DE RID: 202974 RVA: 0x006B76C0 File Offset: 0x006B58C0
		public static IPreloadLinkResource GetRootAsIPreloadLinkResource(ByteBuffer _bb, IPreloadLinkResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060318DF RID: 202975 RVA: 0x006B76DD File Offset: 0x006B58DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060318E0 RID: 202976 RVA: 0x006B76EC File Offset: 0x006B58EC
		public IPreloadLinkResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D142 RID: 53570
		// (get) Token: 0x060318E1 RID: 202977 RVA: 0x006B76FC File Offset: 0x006B58FC
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

		// Token: 0x1700D143 RID: 53571
		// (get) Token: 0x060318E2 RID: 202978 RVA: 0x006B7738 File Offset: 0x006B5938
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

		// Token: 0x060318E3 RID: 202979 RVA: 0x006B7774 File Offset: 0x006B5974
		public static Offset<IPreloadLinkResource> CreateIPreloadLinkResource(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, int LinkResourceId = 0)
		{
			builder.StartTable(2);
			IPreloadLinkResource.AddLinkResourceId(builder, LinkResourceId);
			IPreloadLinkResource.AddType(builder, Type);
			return IPreloadLinkResource.EndIPreloadLinkResource(builder);
		}

		// Token: 0x060318E4 RID: 202980 RVA: 0x006B7791 File Offset: 0x006B5991
		public static void StartIPreloadLinkResource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060318E5 RID: 202981 RVA: 0x006B779A File Offset: 0x006B599A
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060318E6 RID: 202982 RVA: 0x006B77A5 File Offset: 0x006B59A5
		public static void AddLinkResourceId(FlatBufferBuilder builder, int linkResourceId)
		{
			builder.AddInt(1, linkResourceId, 0);
		}

		// Token: 0x060318E7 RID: 202983 RVA: 0x006B77B0 File Offset: 0x006B59B0
		public static Offset<IPreloadLinkResource> EndIPreloadLinkResource(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadLinkResource>(builder.EndTable());
		}

		// Token: 0x060318E8 RID: 202984 RVA: 0x006B77C0 File Offset: 0x006B59C0
		public IPreloadLinkResourceT UnPack()
		{
			IPreloadLinkResourceT preloadLinkResourceT = new IPreloadLinkResourceT();
			this.UnPackTo(preloadLinkResourceT);
			return preloadLinkResourceT;
		}

		// Token: 0x060318E9 RID: 202985 RVA: 0x006B77DB File Offset: 0x006B59DB
		public void UnPackTo(IPreloadLinkResourceT _o)
		{
			_o.Type = this.Type;
			_o.LinkResourceId = this.LinkResourceId;
		}

		// Token: 0x060318EA RID: 202986 RVA: 0x006B77F8 File Offset: 0x006B59F8
		public static Offset<IPreloadLinkResource> Pack(FlatBufferBuilder builder, IPreloadLinkResourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadLinkResource>);
			}
			return IPreloadLinkResource.CreateIPreloadLinkResource(builder, _o.Type, _o.LinkResourceId);
		}

		// Token: 0x04011768 RID: 71528
		private Table __p;
	}
}
