using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ABC RID: 19132
	public struct IGetAllGraduatedPhantom : IFlatbufferObject
	{
		// Token: 0x1700860D RID: 34317
		// (get) Token: 0x0601CC60 RID: 117856 RVA: 0x0040DD74 File Offset: 0x0040BF74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC61 RID: 117857 RVA: 0x0040DD81 File Offset: 0x0040BF81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC62 RID: 117858 RVA: 0x0040DD88 File Offset: 0x0040BF88
		public static IGetAllGraduatedPhantom GetRootAsIGetAllGraduatedPhantom(ByteBuffer _bb)
		{
			return IGetAllGraduatedPhantom.GetRootAsIGetAllGraduatedPhantom(_bb, default(IGetAllGraduatedPhantom));
		}

		// Token: 0x0601CC63 RID: 117859 RVA: 0x0040DDA4 File Offset: 0x0040BFA4
		public static IGetAllGraduatedPhantom GetRootAsIGetAllGraduatedPhantom(ByteBuffer _bb, IGetAllGraduatedPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC64 RID: 117860 RVA: 0x0040DDC1 File Offset: 0x0040BFC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC65 RID: 117861 RVA: 0x0040DDD0 File Offset: 0x0040BFD0
		public IGetAllGraduatedPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700860E RID: 34318
		// (get) Token: 0x0601CC66 RID: 117862 RVA: 0x0040DDE0 File Offset: 0x0040BFE0
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

		// Token: 0x0601CC67 RID: 117863 RVA: 0x0040DE1C File Offset: 0x0040C01C
		public static Offset<IGetAllGraduatedPhantom> CreateIGetAllGraduatedPhantom(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IGetAllGraduatedPhantom.AddType(builder, Type);
			return IGetAllGraduatedPhantom.EndIGetAllGraduatedPhantom(builder);
		}

		// Token: 0x0601CC68 RID: 117864 RVA: 0x0040DE32 File Offset: 0x0040C032
		public static void StartIGetAllGraduatedPhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CC69 RID: 117865 RVA: 0x0040DE3B File Offset: 0x0040C03B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CC6A RID: 117866 RVA: 0x0040DE46 File Offset: 0x0040C046
		public static Offset<IGetAllGraduatedPhantom> EndIGetAllGraduatedPhantom(FlatBufferBuilder builder)
		{
			return new Offset<IGetAllGraduatedPhantom>(builder.EndTable());
		}

		// Token: 0x0601CC6B RID: 117867 RVA: 0x0040DE54 File Offset: 0x0040C054
		public IGetAllGraduatedPhantomT UnPack()
		{
			IGetAllGraduatedPhantomT getAllGraduatedPhantomT = new IGetAllGraduatedPhantomT();
			this.UnPackTo(getAllGraduatedPhantomT);
			return getAllGraduatedPhantomT;
		}

		// Token: 0x0601CC6C RID: 117868 RVA: 0x0040DE6F File Offset: 0x0040C06F
		public void UnPackTo(IGetAllGraduatedPhantomT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CC6D RID: 117869 RVA: 0x0040DE80 File Offset: 0x0040C080
		public static Offset<IGetAllGraduatedPhantom> Pack(FlatBufferBuilder builder, IGetAllGraduatedPhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetAllGraduatedPhantom>);
			}
			return IGetAllGraduatedPhantom.CreateIGetAllGraduatedPhantom(builder, _o.Type);
		}

		// Token: 0x0400D201 RID: 53761
		private Table __p;
	}
}
