using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691E RID: 26910
	public struct IHonamiStoryCustomLoading : IFlatbufferObject
	{
		// Token: 0x1700C7A8 RID: 51112
		// (get) Token: 0x0602EF9D RID: 192413 RVA: 0x00667D26 File Offset: 0x00665F26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF9E RID: 192414 RVA: 0x00667D33 File Offset: 0x00665F33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF9F RID: 192415 RVA: 0x00667D3C File Offset: 0x00665F3C
		public static IHonamiStoryCustomLoading GetRootAsIHonamiStoryCustomLoading(ByteBuffer _bb)
		{
			return IHonamiStoryCustomLoading.GetRootAsIHonamiStoryCustomLoading(_bb, default(IHonamiStoryCustomLoading));
		}

		// Token: 0x0602EFA0 RID: 192416 RVA: 0x00667D58 File Offset: 0x00665F58
		public static IHonamiStoryCustomLoading GetRootAsIHonamiStoryCustomLoading(ByteBuffer _bb, IHonamiStoryCustomLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFA1 RID: 192417 RVA: 0x00667D75 File Offset: 0x00665F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFA2 RID: 192418 RVA: 0x00667D84 File Offset: 0x00665F84
		public IHonamiStoryCustomLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7A9 RID: 51113
		// (get) Token: 0x0602EFA3 RID: 192419 RVA: 0x00667D94 File Offset: 0x00665F94
		public ESpecialCustomLoadingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialCustomLoadingType.HonamiStory;
				}
				return (ESpecialCustomLoadingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7AA RID: 51114
		// (get) Token: 0x0602EFA4 RID: 192420 RVA: 0x00667DD0 File Offset: 0x00665FD0
		public int LoadingId
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

		// Token: 0x0602EFA5 RID: 192421 RVA: 0x00667E0C File Offset: 0x0066600C
		public static Offset<IHonamiStoryCustomLoading> CreateIHonamiStoryCustomLoading(FlatBufferBuilder builder, ESpecialCustomLoadingType Type = ESpecialCustomLoadingType.HonamiStory, int LoadingId = 0)
		{
			builder.StartTable(2);
			IHonamiStoryCustomLoading.AddLoadingId(builder, LoadingId);
			IHonamiStoryCustomLoading.AddType(builder, Type);
			return IHonamiStoryCustomLoading.EndIHonamiStoryCustomLoading(builder);
		}

		// Token: 0x0602EFA6 RID: 192422 RVA: 0x00667E29 File Offset: 0x00666029
		public static void StartIHonamiStoryCustomLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EFA7 RID: 192423 RVA: 0x00667E32 File Offset: 0x00666032
		public static void AddType(FlatBufferBuilder builder, ESpecialCustomLoadingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EFA8 RID: 192424 RVA: 0x00667E3D File Offset: 0x0066603D
		public static void AddLoadingId(FlatBufferBuilder builder, int loadingId)
		{
			builder.AddInt(1, loadingId, 0);
		}

		// Token: 0x0602EFA9 RID: 192425 RVA: 0x00667E48 File Offset: 0x00666048
		public static Offset<IHonamiStoryCustomLoading> EndIHonamiStoryCustomLoading(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryCustomLoading>(builder.EndTable());
		}

		// Token: 0x0602EFAA RID: 192426 RVA: 0x00667E58 File Offset: 0x00666058
		public IHonamiStoryCustomLoadingT UnPack()
		{
			IHonamiStoryCustomLoadingT honamiStoryCustomLoadingT = new IHonamiStoryCustomLoadingT();
			this.UnPackTo(honamiStoryCustomLoadingT);
			return honamiStoryCustomLoadingT;
		}

		// Token: 0x0602EFAB RID: 192427 RVA: 0x00667E73 File Offset: 0x00666073
		public void UnPackTo(IHonamiStoryCustomLoadingT _o)
		{
			_o.Type = this.Type;
			_o.LoadingId = this.LoadingId;
		}

		// Token: 0x0602EFAC RID: 192428 RVA: 0x00667E90 File Offset: 0x00666090
		public static Offset<IHonamiStoryCustomLoading> Pack(FlatBufferBuilder builder, IHonamiStoryCustomLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryCustomLoading>);
			}
			return IHonamiStoryCustomLoading.CreateIHonamiStoryCustomLoading(builder, _o.Type, _o.LoadingId);
		}

		// Token: 0x04011099 RID: 69785
		private Table __p;
	}
}
