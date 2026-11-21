using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE9 RID: 20457
	public struct ICheckPreloadCompleteObjectType : IFlatbufferObject
	{
		// Token: 0x1700925F RID: 37471
		// (get) Token: 0x0601FEB5 RID: 130741 RVA: 0x0046EAA6 File Offset: 0x0046CCA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FEB6 RID: 130742 RVA: 0x0046EAB3 File Offset: 0x0046CCB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FEB7 RID: 130743 RVA: 0x0046EABC File Offset: 0x0046CCBC
		public static ICheckPreloadCompleteObjectType GetRootAsICheckPreloadCompleteObjectType(ByteBuffer _bb)
		{
			return ICheckPreloadCompleteObjectType.GetRootAsICheckPreloadCompleteObjectType(_bb, default(ICheckPreloadCompleteObjectType));
		}

		// Token: 0x0601FEB8 RID: 130744 RVA: 0x0046EAD8 File Offset: 0x0046CCD8
		public static ICheckPreloadCompleteObjectType GetRootAsICheckPreloadCompleteObjectType(ByteBuffer _bb, ICheckPreloadCompleteObjectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FEB9 RID: 130745 RVA: 0x0046EAF5 File Offset: 0x0046CCF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FEBA RID: 130746 RVA: 0x0046EB04 File Offset: 0x0046CD04
		public ICheckPreloadCompleteObjectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009260 RID: 37472
		// (get) Token: 0x0601FEBB RID: 130747 RVA: 0x0046EB14 File Offset: 0x0046CD14
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

		// Token: 0x0601FEBC RID: 130748 RVA: 0x0046EB50 File Offset: 0x0046CD50
		public static Offset<ICheckPreloadCompleteObjectType> CreateICheckPreloadCompleteObjectType(FlatBufferBuilder builder, ECheckPreloadCompleteObjectType Type = ECheckPreloadCompleteObjectType.PreloadLinkResource)
		{
			builder.StartTable(1);
			ICheckPreloadCompleteObjectType.AddType(builder, Type);
			return ICheckPreloadCompleteObjectType.EndICheckPreloadCompleteObjectType(builder);
		}

		// Token: 0x0601FEBD RID: 130749 RVA: 0x0046EB66 File Offset: 0x0046CD66
		public static void StartICheckPreloadCompleteObjectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FEBE RID: 130750 RVA: 0x0046EB6F File Offset: 0x0046CD6F
		public static void AddType(FlatBufferBuilder builder, ECheckPreloadCompleteObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FEBF RID: 130751 RVA: 0x0046EB7A File Offset: 0x0046CD7A
		public static Offset<ICheckPreloadCompleteObjectType> EndICheckPreloadCompleteObjectType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPreloadCompleteObjectType>(builder.EndTable());
		}

		// Token: 0x0601FEC0 RID: 130752 RVA: 0x0046EB88 File Offset: 0x0046CD88
		public ICheckPreloadCompleteObjectTypeT UnPack()
		{
			ICheckPreloadCompleteObjectTypeT checkPreloadCompleteObjectTypeT = new ICheckPreloadCompleteObjectTypeT();
			this.UnPackTo(checkPreloadCompleteObjectTypeT);
			return checkPreloadCompleteObjectTypeT;
		}

		// Token: 0x0601FEC1 RID: 130753 RVA: 0x0046EBA3 File Offset: 0x0046CDA3
		public void UnPackTo(ICheckPreloadCompleteObjectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FEC2 RID: 130754 RVA: 0x0046EBB4 File Offset: 0x0046CDB4
		public static Offset<ICheckPreloadCompleteObjectType> Pack(FlatBufferBuilder builder, ICheckPreloadCompleteObjectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPreloadCompleteObjectType>);
			}
			return ICheckPreloadCompleteObjectType.CreateICheckPreloadCompleteObjectType(builder, _o.Type);
		}

		// Token: 0x0400DE99 RID: 56985
		private Table __p;
	}
}
