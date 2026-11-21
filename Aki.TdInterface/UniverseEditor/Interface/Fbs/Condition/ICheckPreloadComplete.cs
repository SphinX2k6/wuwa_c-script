using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE3 RID: 20451
	public struct ICheckPreloadComplete : IFlatbufferObject
	{
		// Token: 0x17009255 RID: 37461
		// (get) Token: 0x0601FE89 RID: 130697 RVA: 0x0046E61B File Offset: 0x0046C81B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE8A RID: 130698 RVA: 0x0046E628 File Offset: 0x0046C828
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE8B RID: 130699 RVA: 0x0046E630 File Offset: 0x0046C830
		public static ICheckPreloadComplete GetRootAsICheckPreloadComplete(ByteBuffer _bb)
		{
			return ICheckPreloadComplete.GetRootAsICheckPreloadComplete(_bb, default(ICheckPreloadComplete));
		}

		// Token: 0x0601FE8C RID: 130700 RVA: 0x0046E64C File Offset: 0x0046C84C
		public static ICheckPreloadComplete GetRootAsICheckPreloadComplete(ByteBuffer _bb, ICheckPreloadComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE8D RID: 130701 RVA: 0x0046E669 File Offset: 0x0046C869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE8E RID: 130702 RVA: 0x0046E678 File Offset: 0x0046C878
		public ICheckPreloadComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009256 RID: 37462
		// (get) Token: 0x0601FE8F RID: 130703 RVA: 0x0046E688 File Offset: 0x0046C888
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009257 RID: 37463
		// (get) Token: 0x0601FE90 RID: 130704 RVA: 0x0046E6C4 File Offset: 0x0046C8C4
		public ICheckPreloadCompleteLinkResource? PreloadObjectType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICheckPreloadCompleteLinkResource?(default(ICheckPreloadCompleteLinkResource).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FE91 RID: 130705 RVA: 0x0046E721 File Offset: 0x0046C921
		public static Offset<ICheckPreloadComplete> CreateICheckPreloadComplete(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICheckPreloadCompleteLinkResource> PreloadObjectTypeOffset = default(Offset<ICheckPreloadCompleteLinkResource>))
		{
			builder.StartTable(2);
			ICheckPreloadComplete.AddPreloadObjectType(builder, PreloadObjectTypeOffset);
			ICheckPreloadComplete.AddType(builder, Type);
			return ICheckPreloadComplete.EndICheckPreloadComplete(builder);
		}

		// Token: 0x0601FE92 RID: 130706 RVA: 0x0046E73E File Offset: 0x0046C93E
		public static void StartICheckPreloadComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FE93 RID: 130707 RVA: 0x0046E747 File Offset: 0x0046C947
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE94 RID: 130708 RVA: 0x0046E752 File Offset: 0x0046C952
		public static void AddPreloadObjectType(FlatBufferBuilder builder, Offset<ICheckPreloadCompleteLinkResource> preloadObjectTypeOffset)
		{
			builder.AddOffset(1, preloadObjectTypeOffset.Value, 0);
		}

		// Token: 0x0601FE95 RID: 130709 RVA: 0x0046E762 File Offset: 0x0046C962
		public static Offset<ICheckPreloadComplete> EndICheckPreloadComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPreloadComplete>(builder.EndTable());
		}

		// Token: 0x0601FE96 RID: 130710 RVA: 0x0046E770 File Offset: 0x0046C970
		public ICheckPreloadCompleteT UnPack()
		{
			ICheckPreloadCompleteT checkPreloadCompleteT = new ICheckPreloadCompleteT();
			this.UnPackTo(checkPreloadCompleteT);
			return checkPreloadCompleteT;
		}

		// Token: 0x0601FE97 RID: 130711 RVA: 0x0046E78C File Offset: 0x0046C98C
		public void UnPackTo(ICheckPreloadCompleteT _o)
		{
			_o.Type = this.Type;
			_o.PreloadObjectType = ((this.PreloadObjectType != null) ? this.PreloadObjectType.Value.UnPack() : null);
		}

		// Token: 0x0601FE98 RID: 130712 RVA: 0x0046E7D4 File Offset: 0x0046C9D4
		public static Offset<ICheckPreloadComplete> Pack(FlatBufferBuilder builder, ICheckPreloadCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPreloadComplete>);
			}
			Offset<ICheckPreloadCompleteLinkResource> preloadObjectTypeOffset = (_o.PreloadObjectType == null) ? default(Offset<ICheckPreloadCompleteLinkResource>) : ICheckPreloadCompleteLinkResource.Pack(builder, _o.PreloadObjectType);
			return ICheckPreloadComplete.CreateICheckPreloadComplete(builder, _o.Type, preloadObjectTypeOffset);
		}

		// Token: 0x0400DE93 RID: 56979
		private Table __p;
	}
}
