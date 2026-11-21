using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006838 RID: 26680
	public struct IAvgShakeUi : IFlatbufferObject
	{
		// Token: 0x1700C42E RID: 50222
		// (get) Token: 0x0602D991 RID: 186769 RVA: 0x0063D37C File Offset: 0x0063B57C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D992 RID: 186770 RVA: 0x0063D389 File Offset: 0x0063B589
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D993 RID: 186771 RVA: 0x0063D390 File Offset: 0x0063B590
		public static IAvgShakeUi GetRootAsIAvgShakeUi(ByteBuffer _bb)
		{
			return IAvgShakeUi.GetRootAsIAvgShakeUi(_bb, default(IAvgShakeUi));
		}

		// Token: 0x0602D994 RID: 186772 RVA: 0x0063D3AC File Offset: 0x0063B5AC
		public static IAvgShakeUi GetRootAsIAvgShakeUi(ByteBuffer _bb, IAvgShakeUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D995 RID: 186773 RVA: 0x0063D3C9 File Offset: 0x0063B5C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D996 RID: 186774 RVA: 0x0063D3D8 File Offset: 0x0063B5D8
		public IAvgShakeUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C42F RID: 50223
		// (get) Token: 0x0602D997 RID: 186775 RVA: 0x0063D3E8 File Offset: 0x0063B5E8
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

		// Token: 0x1700C430 RID: 50224
		// (get) Token: 0x0602D998 RID: 186776 RVA: 0x0063D424 File Offset: 0x0063B624
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

		// Token: 0x0602D999 RID: 186777 RVA: 0x0063D460 File Offset: 0x0063B660
		public static Offset<IAvgShakeUi> CreateIAvgShakeUi(FlatBufferBuilder builder, EAvgShakeUiIntensity Intensity = EAvgShakeUiIntensity.Weak, int RepeatCount = 0)
		{
			builder.StartTable(2);
			IAvgShakeUi.AddRepeatCount(builder, RepeatCount);
			IAvgShakeUi.AddIntensity(builder, Intensity);
			return IAvgShakeUi.EndIAvgShakeUi(builder);
		}

		// Token: 0x0602D99A RID: 186778 RVA: 0x0063D47D File Offset: 0x0063B67D
		public static void StartIAvgShakeUi(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D99B RID: 186779 RVA: 0x0063D486 File Offset: 0x0063B686
		public static void AddIntensity(FlatBufferBuilder builder, EAvgShakeUiIntensity intensity)
		{
			builder.AddByte(0, (byte)intensity, 0);
		}

		// Token: 0x0602D99C RID: 186780 RVA: 0x0063D491 File Offset: 0x0063B691
		public static void AddRepeatCount(FlatBufferBuilder builder, int repeatCount)
		{
			builder.AddInt(1, repeatCount, 0);
		}

		// Token: 0x0602D99D RID: 186781 RVA: 0x0063D49C File Offset: 0x0063B69C
		public static Offset<IAvgShakeUi> EndIAvgShakeUi(FlatBufferBuilder builder)
		{
			return new Offset<IAvgShakeUi>(builder.EndTable());
		}

		// Token: 0x0602D99E RID: 186782 RVA: 0x0063D4AC File Offset: 0x0063B6AC
		public IAvgShakeUiT UnPack()
		{
			IAvgShakeUiT avgShakeUiT = new IAvgShakeUiT();
			this.UnPackTo(avgShakeUiT);
			return avgShakeUiT;
		}

		// Token: 0x0602D99F RID: 186783 RVA: 0x0063D4C7 File Offset: 0x0063B6C7
		public void UnPackTo(IAvgShakeUiT _o)
		{
			_o.Intensity = this.Intensity;
			_o.RepeatCount = this.RepeatCount;
		}

		// Token: 0x0602D9A0 RID: 186784 RVA: 0x0063D4E4 File Offset: 0x0063B6E4
		public static Offset<IAvgShakeUi> Pack(FlatBufferBuilder builder, IAvgShakeUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgShakeUi>);
			}
			return IAvgShakeUi.CreateIAvgShakeUi(builder, _o.Intensity, _o.RepeatCount);
		}

		// Token: 0x04011503 RID: 70915
		private Table __p;
	}
}
