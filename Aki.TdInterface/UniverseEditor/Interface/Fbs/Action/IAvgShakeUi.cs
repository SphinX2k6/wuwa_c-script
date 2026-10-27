using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061CA RID: 25034
	public struct IAvgShakeUi : IFlatbufferObject
	{
		// Token: 0x1700BAAB RID: 47787
		// (get) Token: 0x0602B24A RID: 176714 RVA: 0x005F2908 File Offset: 0x005F0B08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B24B RID: 176715 RVA: 0x005F2915 File Offset: 0x005F0B15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B24C RID: 176716 RVA: 0x005F291C File Offset: 0x005F0B1C
		public static IAvgShakeUi GetRootAsIAvgShakeUi(ByteBuffer _bb)
		{
			return IAvgShakeUi.GetRootAsIAvgShakeUi(_bb, default(IAvgShakeUi));
		}

		// Token: 0x0602B24D RID: 176717 RVA: 0x005F2938 File Offset: 0x005F0B38
		public static IAvgShakeUi GetRootAsIAvgShakeUi(ByteBuffer _bb, IAvgShakeUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B24E RID: 176718 RVA: 0x005F2955 File Offset: 0x005F0B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B24F RID: 176719 RVA: 0x005F2964 File Offset: 0x005F0B64
		public IAvgShakeUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAAC RID: 47788
		// (get) Token: 0x0602B250 RID: 176720 RVA: 0x005F2974 File Offset: 0x005F0B74
		public EAvgShakeUiIntensity Intensity
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAvgShakeUiIntensity.Weak;
				}
				return (EAvgShakeUiIntensity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BAAD RID: 47789
		// (get) Token: 0x0602B251 RID: 176721 RVA: 0x005F29B0 File Offset: 0x005F0BB0
		public int RepeatCount
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

		// Token: 0x0602B252 RID: 176722 RVA: 0x005F29EC File Offset: 0x005F0BEC
		public static Offset<IAvgShakeUi> CreateIAvgShakeUi(FlatBufferBuilder builder, EAvgShakeUiIntensity Intensity = EAvgShakeUiIntensity.Weak, int RepeatCount = 0)
		{
			builder.StartTable(2);
			IAvgShakeUi.AddRepeatCount(builder, RepeatCount);
			IAvgShakeUi.AddIntensity(builder, Intensity);
			return IAvgShakeUi.EndIAvgShakeUi(builder);
		}

		// Token: 0x0602B253 RID: 176723 RVA: 0x005F2A09 File Offset: 0x005F0C09
		public static void StartIAvgShakeUi(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B254 RID: 176724 RVA: 0x005F2A12 File Offset: 0x005F0C12
		public static void AddIntensity(FlatBufferBuilder builder, EAvgShakeUiIntensity intensity)
		{
			builder.AddByte(0, (byte)intensity, 0);
		}

		// Token: 0x0602B255 RID: 176725 RVA: 0x005F2A1D File Offset: 0x005F0C1D
		public static void AddRepeatCount(FlatBufferBuilder builder, int repeatCount)
		{
			builder.AddInt(1, repeatCount, 0);
		}

		// Token: 0x0602B256 RID: 176726 RVA: 0x005F2A28 File Offset: 0x005F0C28
		public static Offset<IAvgShakeUi> EndIAvgShakeUi(FlatBufferBuilder builder)
		{
			return new Offset<IAvgShakeUi>(builder.EndTable());
		}

		// Token: 0x0602B257 RID: 176727 RVA: 0x005F2A38 File Offset: 0x005F0C38
		public IAvgShakeUiT UnPack()
		{
			IAvgShakeUiT avgShakeUiT = new IAvgShakeUiT();
			this.UnPackTo(avgShakeUiT);
			return avgShakeUiT;
		}

		// Token: 0x0602B258 RID: 176728 RVA: 0x005F2A53 File Offset: 0x005F0C53
		public void UnPackTo(IAvgShakeUiT _o)
		{
			_o.Intensity = this.Intensity;
			_o.RepeatCount = this.RepeatCount;
		}

		// Token: 0x0602B259 RID: 176729 RVA: 0x005F2A70 File Offset: 0x005F0C70
		public static Offset<IAvgShakeUi> Pack(FlatBufferBuilder builder, IAvgShakeUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgShakeUi>);
			}
			return IAvgShakeUi.CreateIAvgShakeUi(builder, _o.Intensity, _o.RepeatCount);
		}

		// Token: 0x040106F1 RID: 67313
		private Table __p;
	}
}
