using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD1 RID: 28625
	public struct IHonamiStoryCustomLoading : IFlatbufferObject
	{
		// Token: 0x1700D1AB RID: 53675
		// (get) Token: 0x0603196D RID: 203117 RVA: 0x006B820E File Offset: 0x006B640E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603196E RID: 203118 RVA: 0x006B821B File Offset: 0x006B641B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603196F RID: 203119 RVA: 0x006B8224 File Offset: 0x006B6424
		public static IHonamiStoryCustomLoading GetRootAsIHonamiStoryCustomLoading(ByteBuffer _bb)
		{
			return IHonamiStoryCustomLoading.GetRootAsIHonamiStoryCustomLoading(_bb, default(IHonamiStoryCustomLoading));
		}

		// Token: 0x06031970 RID: 203120 RVA: 0x006B8240 File Offset: 0x006B6440
		public static IHonamiStoryCustomLoading GetRootAsIHonamiStoryCustomLoading(ByteBuffer _bb, IHonamiStoryCustomLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031971 RID: 203121 RVA: 0x006B825D File Offset: 0x006B645D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031972 RID: 203122 RVA: 0x006B826C File Offset: 0x006B646C
		public IHonamiStoryCustomLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1AC RID: 53676
		// (get) Token: 0x06031973 RID: 203123 RVA: 0x006B827C File Offset: 0x006B647C
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

		// Token: 0x1700D1AD RID: 53677
		// (get) Token: 0x06031974 RID: 203124 RVA: 0x006B82B8 File Offset: 0x006B64B8
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

		// Token: 0x06031975 RID: 203125 RVA: 0x006B82F4 File Offset: 0x006B64F4
		public static Offset<IHonamiStoryCustomLoading> CreateIHonamiStoryCustomLoading(FlatBufferBuilder builder, ESpecialCustomLoadingType Type = ESpecialCustomLoadingType.HonamiStory, int LoadingId = 0)
		{
			builder.StartTable(2);
			IHonamiStoryCustomLoading.AddLoadingId(builder, LoadingId);
			IHonamiStoryCustomLoading.AddType(builder, Type);
			return IHonamiStoryCustomLoading.EndIHonamiStoryCustomLoading(builder);
		}

		// Token: 0x06031976 RID: 203126 RVA: 0x006B8311 File Offset: 0x006B6511
		public static void StartIHonamiStoryCustomLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031977 RID: 203127 RVA: 0x006B831A File Offset: 0x006B651A
		public static void AddType(FlatBufferBuilder builder, ESpecialCustomLoadingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031978 RID: 203128 RVA: 0x006B8325 File Offset: 0x006B6525
		public static void AddLoadingId(FlatBufferBuilder builder, int loadingId)
		{
			builder.AddInt(1, loadingId, 0);
		}

		// Token: 0x06031979 RID: 203129 RVA: 0x006B8330 File Offset: 0x006B6530
		public static Offset<IHonamiStoryCustomLoading> EndIHonamiStoryCustomLoading(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryCustomLoading>(builder.EndTable());
		}

		// Token: 0x0603197A RID: 203130 RVA: 0x006B8340 File Offset: 0x006B6540
		public IHonamiStoryCustomLoadingT UnPack()
		{
			IHonamiStoryCustomLoadingT honamiStoryCustomLoadingT = new IHonamiStoryCustomLoadingT();
			this.UnPackTo(honamiStoryCustomLoadingT);
			return honamiStoryCustomLoadingT;
		}

		// Token: 0x0603197B RID: 203131 RVA: 0x006B835B File Offset: 0x006B655B
		public void UnPackTo(IHonamiStoryCustomLoadingT _o)
		{
			_o.Type = this.Type;
			_o.LoadingId = this.LoadingId;
		}

		// Token: 0x0603197C RID: 203132 RVA: 0x006B8378 File Offset: 0x006B6578
		public static Offset<IHonamiStoryCustomLoading> Pack(FlatBufferBuilder builder, IHonamiStoryCustomLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryCustomLoading>);
			}
			return IHonamiStoryCustomLoading.CreateIHonamiStoryCustomLoading(builder, _o.Type, _o.LoadingId);
		}

		// Token: 0x04011F05 RID: 73477
		private Table __p;
	}
}
