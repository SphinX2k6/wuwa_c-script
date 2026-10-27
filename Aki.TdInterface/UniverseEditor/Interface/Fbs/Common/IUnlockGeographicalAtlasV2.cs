using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E60 RID: 24160
	public struct IUnlockGeographicalAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700B4A6 RID: 46246
		// (get) Token: 0x060295FF RID: 169471 RVA: 0x005ABF30 File Offset: 0x005AA130
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029600 RID: 169472 RVA: 0x005ABF3D File Offset: 0x005AA13D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029601 RID: 169473 RVA: 0x005ABF44 File Offset: 0x005AA144
		public static IUnlockGeographicalAtlasV2 GetRootAsIUnlockGeographicalAtlasV2(ByteBuffer _bb)
		{
			return IUnlockGeographicalAtlasV2.GetRootAsIUnlockGeographicalAtlasV2(_bb, default(IUnlockGeographicalAtlasV2));
		}

		// Token: 0x06029602 RID: 169474 RVA: 0x005ABF60 File Offset: 0x005AA160
		public static IUnlockGeographicalAtlasV2 GetRootAsIUnlockGeographicalAtlasV2(ByteBuffer _bb, IUnlockGeographicalAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029603 RID: 169475 RVA: 0x005ABF7D File Offset: 0x005AA17D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029604 RID: 169476 RVA: 0x005ABF8C File Offset: 0x005AA18C
		public IUnlockGeographicalAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4A7 RID: 46247
		// (get) Token: 0x06029605 RID: 169477 RVA: 0x005ABF9C File Offset: 0x005AA19C
		public EUnlockAtlasSystemTypeV2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockAtlasSystemTypeV2.GeographicalAtlas;
				}
				return (EUnlockAtlasSystemTypeV2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B4A8 RID: 46248
		// (get) Token: 0x06029606 RID: 169478 RVA: 0x005ABFD8 File Offset: 0x005AA1D8
		public int Id
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

		// Token: 0x06029607 RID: 169479 RVA: 0x005AC014 File Offset: 0x005AA214
		public static Offset<IUnlockGeographicalAtlasV2> CreateIUnlockGeographicalAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockGeographicalAtlasV2.AddId(builder, Id);
			IUnlockGeographicalAtlasV2.AddType(builder, Type);
			return IUnlockGeographicalAtlasV2.EndIUnlockGeographicalAtlasV2(builder);
		}

		// Token: 0x06029608 RID: 169480 RVA: 0x005AC031 File Offset: 0x005AA231
		public static void StartIUnlockGeographicalAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029609 RID: 169481 RVA: 0x005AC03A File Offset: 0x005AA23A
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602960A RID: 169482 RVA: 0x005AC045 File Offset: 0x005AA245
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602960B RID: 169483 RVA: 0x005AC050 File Offset: 0x005AA250
		public static Offset<IUnlockGeographicalAtlasV2> EndIUnlockGeographicalAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockGeographicalAtlasV2>(builder.EndTable());
		}

		// Token: 0x0602960C RID: 169484 RVA: 0x005AC060 File Offset: 0x005AA260
		public IUnlockGeographicalAtlasV2T UnPack()
		{
			IUnlockGeographicalAtlasV2T unlockGeographicalAtlasV2T = new IUnlockGeographicalAtlasV2T();
			this.UnPackTo(unlockGeographicalAtlasV2T);
			return unlockGeographicalAtlasV2T;
		}

		// Token: 0x0602960D RID: 169485 RVA: 0x005AC07B File Offset: 0x005AA27B
		public void UnPackTo(IUnlockGeographicalAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602960E RID: 169486 RVA: 0x005AC098 File Offset: 0x005AA298
		public static Offset<IUnlockGeographicalAtlasV2> Pack(FlatBufferBuilder builder, IUnlockGeographicalAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockGeographicalAtlasV2>);
			}
			return IUnlockGeographicalAtlasV2.CreateIUnlockGeographicalAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400F871 RID: 63601
		private Table __p;
	}
}
