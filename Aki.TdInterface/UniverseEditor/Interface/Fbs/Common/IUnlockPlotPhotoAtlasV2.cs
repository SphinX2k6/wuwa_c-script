using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E69 RID: 24169
	public struct IUnlockPlotPhotoAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700B4B5 RID: 46261
		// (get) Token: 0x06029641 RID: 169537 RVA: 0x005AC52E File Offset: 0x005AA72E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029642 RID: 169538 RVA: 0x005AC53B File Offset: 0x005AA73B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029643 RID: 169539 RVA: 0x005AC544 File Offset: 0x005AA744
		public static IUnlockPlotPhotoAtlasV2 GetRootAsIUnlockPlotPhotoAtlasV2(ByteBuffer _bb)
		{
			return IUnlockPlotPhotoAtlasV2.GetRootAsIUnlockPlotPhotoAtlasV2(_bb, default(IUnlockPlotPhotoAtlasV2));
		}

		// Token: 0x06029644 RID: 169540 RVA: 0x005AC560 File Offset: 0x005AA760
		public static IUnlockPlotPhotoAtlasV2 GetRootAsIUnlockPlotPhotoAtlasV2(ByteBuffer _bb, IUnlockPlotPhotoAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029645 RID: 169541 RVA: 0x005AC57D File Offset: 0x005AA77D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029646 RID: 169542 RVA: 0x005AC58C File Offset: 0x005AA78C
		public IUnlockPlotPhotoAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4B6 RID: 46262
		// (get) Token: 0x06029647 RID: 169543 RVA: 0x005AC59C File Offset: 0x005AA79C
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

		// Token: 0x1700B4B7 RID: 46263
		// (get) Token: 0x06029648 RID: 169544 RVA: 0x005AC5D8 File Offset: 0x005AA7D8
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

		// Token: 0x06029649 RID: 169545 RVA: 0x005AC614 File Offset: 0x005AA814
		public static Offset<IUnlockPlotPhotoAtlasV2> CreateIUnlockPlotPhotoAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockPlotPhotoAtlasV2.AddId(builder, Id);
			IUnlockPlotPhotoAtlasV2.AddType(builder, Type);
			return IUnlockPlotPhotoAtlasV2.EndIUnlockPlotPhotoAtlasV2(builder);
		}

		// Token: 0x0602964A RID: 169546 RVA: 0x005AC631 File Offset: 0x005AA831
		public static void StartIUnlockPlotPhotoAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602964B RID: 169547 RVA: 0x005AC63A File Offset: 0x005AA83A
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602964C RID: 169548 RVA: 0x005AC645 File Offset: 0x005AA845
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602964D RID: 169549 RVA: 0x005AC650 File Offset: 0x005AA850
		public static Offset<IUnlockPlotPhotoAtlasV2> EndIUnlockPlotPhotoAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockPlotPhotoAtlasV2>(builder.EndTable());
		}

		// Token: 0x0602964E RID: 169550 RVA: 0x005AC660 File Offset: 0x005AA860
		public IUnlockPlotPhotoAtlasV2T UnPack()
		{
			IUnlockPlotPhotoAtlasV2T unlockPlotPhotoAtlasV2T = new IUnlockPlotPhotoAtlasV2T();
			this.UnPackTo(unlockPlotPhotoAtlasV2T);
			return unlockPlotPhotoAtlasV2T;
		}

		// Token: 0x0602964F RID: 169551 RVA: 0x005AC67B File Offset: 0x005AA87B
		public void UnPackTo(IUnlockPlotPhotoAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06029650 RID: 169552 RVA: 0x005AC698 File Offset: 0x005AA898
		public static Offset<IUnlockPlotPhotoAtlasV2> Pack(FlatBufferBuilder builder, IUnlockPlotPhotoAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockPlotPhotoAtlasV2>);
			}
			return IUnlockPlotPhotoAtlasV2.CreateIUnlockPlotPhotoAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400F87A RID: 63610
		private Table __p;
	}
}
