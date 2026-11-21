using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F7 RID: 26359
	public struct IActiveAntiGravitySafePoint : IFlatbufferObject
	{
		// Token: 0x1700BF9A RID: 49050
		// (get) Token: 0x0602CA14 RID: 182804 RVA: 0x0061B8A6 File Offset: 0x00619AA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA15 RID: 182805 RVA: 0x0061B8B3 File Offset: 0x00619AB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA16 RID: 182806 RVA: 0x0061B8BC File Offset: 0x00619ABC
		public static IActiveAntiGravitySafePoint GetRootAsIActiveAntiGravitySafePoint(ByteBuffer _bb)
		{
			return IActiveAntiGravitySafePoint.GetRootAsIActiveAntiGravitySafePoint(_bb, default(IActiveAntiGravitySafePoint));
		}

		// Token: 0x0602CA17 RID: 182807 RVA: 0x0061B8D8 File Offset: 0x00619AD8
		public static IActiveAntiGravitySafePoint GetRootAsIActiveAntiGravitySafePoint(ByteBuffer _bb, IActiveAntiGravitySafePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA18 RID: 182808 RVA: 0x0061B8F5 File Offset: 0x00619AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA19 RID: 182809 RVA: 0x0061B904 File Offset: 0x00619B04
		public IActiveAntiGravitySafePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CA1A RID: 182810 RVA: 0x0061B914 File Offset: 0x00619B14
		public static void StartIActiveAntiGravitySafePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CA1B RID: 182811 RVA: 0x0061B91D File Offset: 0x00619B1D
		public static Offset<IActiveAntiGravitySafePoint> EndIActiveAntiGravitySafePoint(FlatBufferBuilder builder)
		{
			return new Offset<IActiveAntiGravitySafePoint>(builder.EndTable());
		}

		// Token: 0x0602CA1C RID: 182812 RVA: 0x0061B92C File Offset: 0x00619B2C
		public IActiveAntiGravitySafePointT UnPack()
		{
			IActiveAntiGravitySafePointT activeAntiGravitySafePointT = new IActiveAntiGravitySafePointT();
			this.UnPackTo(activeAntiGravitySafePointT);
			return activeAntiGravitySafePointT;
		}

		// Token: 0x0602CA1D RID: 182813 RVA: 0x0061B947 File Offset: 0x00619B47
		public void UnPackTo(IActiveAntiGravitySafePointT _o)
		{
		}

		// Token: 0x0602CA1E RID: 182814 RVA: 0x0061B94C File Offset: 0x00619B4C
		public static Offset<IActiveAntiGravitySafePoint> Pack(FlatBufferBuilder builder, IActiveAntiGravitySafePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActiveAntiGravitySafePoint>);
			}
			IActiveAntiGravitySafePoint.StartIActiveAntiGravitySafePoint(builder);
			return IActiveAntiGravitySafePoint.EndIActiveAntiGravitySafePoint(builder);
		}

		// Token: 0x0401122E RID: 70190
		private Table __p;
	}
}
