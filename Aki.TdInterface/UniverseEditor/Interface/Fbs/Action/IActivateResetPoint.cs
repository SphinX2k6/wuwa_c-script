using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006092 RID: 24722
	public struct IActivateResetPoint : IFlatbufferObject
	{
		// Token: 0x1700B62E RID: 46638
		// (get) Token: 0x0602A326 RID: 172838 RVA: 0x005D1816 File Offset: 0x005CFA16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A327 RID: 172839 RVA: 0x005D1823 File Offset: 0x005CFA23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A328 RID: 172840 RVA: 0x005D182C File Offset: 0x005CFA2C
		public static IActivateResetPoint GetRootAsIActivateResetPoint(ByteBuffer _bb)
		{
			return IActivateResetPoint.GetRootAsIActivateResetPoint(_bb, default(IActivateResetPoint));
		}

		// Token: 0x0602A329 RID: 172841 RVA: 0x005D1848 File Offset: 0x005CFA48
		public static IActivateResetPoint GetRootAsIActivateResetPoint(ByteBuffer _bb, IActivateResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A32A RID: 172842 RVA: 0x005D1865 File Offset: 0x005CFA65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A32B RID: 172843 RVA: 0x005D1874 File Offset: 0x005CFA74
		public IActivateResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A32C RID: 172844 RVA: 0x005D1884 File Offset: 0x005CFA84
		public static void StartIActivateResetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602A32D RID: 172845 RVA: 0x005D188D File Offset: 0x005CFA8D
		public static Offset<IActivateResetPoint> EndIActivateResetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IActivateResetPoint>(builder.EndTable());
		}

		// Token: 0x0602A32E RID: 172846 RVA: 0x005D189C File Offset: 0x005CFA9C
		public IActivateResetPointT UnPack()
		{
			IActivateResetPointT activateResetPointT = new IActivateResetPointT();
			this.UnPackTo(activateResetPointT);
			return activateResetPointT;
		}

		// Token: 0x0602A32F RID: 172847 RVA: 0x005D18B7 File Offset: 0x005CFAB7
		public void UnPackTo(IActivateResetPointT _o)
		{
		}

		// Token: 0x0602A330 RID: 172848 RVA: 0x005D18BC File Offset: 0x005CFABC
		public static Offset<IActivateResetPoint> Pack(FlatBufferBuilder builder, IActivateResetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateResetPoint>);
			}
			IActivateResetPoint.StartIActivateResetPoint(builder);
			return IActivateResetPoint.EndIActivateResetPoint(builder);
		}

		// Token: 0x04010429 RID: 66601
		private Table __p;
	}
}
