using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F4 RID: 26356
	public struct IActivateResetPoint : IFlatbufferObject
	{
		// Token: 0x1700BF99 RID: 49049
		// (get) Token: 0x0602CA07 RID: 182791 RVA: 0x0061B7BE File Offset: 0x006199BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA08 RID: 182792 RVA: 0x0061B7CB File Offset: 0x006199CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA09 RID: 182793 RVA: 0x0061B7D4 File Offset: 0x006199D4
		public static IActivateResetPoint GetRootAsIActivateResetPoint(ByteBuffer _bb)
		{
			return IActivateResetPoint.GetRootAsIActivateResetPoint(_bb, default(IActivateResetPoint));
		}

		// Token: 0x0602CA0A RID: 182794 RVA: 0x0061B7F0 File Offset: 0x006199F0
		public static IActivateResetPoint GetRootAsIActivateResetPoint(ByteBuffer _bb, IActivateResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA0B RID: 182795 RVA: 0x0061B80D File Offset: 0x00619A0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA0C RID: 182796 RVA: 0x0061B81C File Offset: 0x00619A1C
		public IActivateResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CA0D RID: 182797 RVA: 0x0061B82C File Offset: 0x00619A2C
		public static void StartIActivateResetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CA0E RID: 182798 RVA: 0x0061B835 File Offset: 0x00619A35
		public static Offset<IActivateResetPoint> EndIActivateResetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IActivateResetPoint>(builder.EndTable());
		}

		// Token: 0x0602CA0F RID: 182799 RVA: 0x0061B844 File Offset: 0x00619A44
		public IActivateResetPointT UnPack()
		{
			IActivateResetPointT activateResetPointT = new IActivateResetPointT();
			this.UnPackTo(activateResetPointT);
			return activateResetPointT;
		}

		// Token: 0x0602CA10 RID: 182800 RVA: 0x0061B85F File Offset: 0x00619A5F
		public void UnPackTo(IActivateResetPointT _o)
		{
		}

		// Token: 0x0602CA11 RID: 182801 RVA: 0x0061B864 File Offset: 0x00619A64
		public static Offset<IActivateResetPoint> Pack(FlatBufferBuilder builder, IActivateResetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateResetPoint>);
			}
			IActivateResetPoint.StartIActivateResetPoint(builder);
			return IActivateResetPoint.EndIActivateResetPoint(builder);
		}

		// Token: 0x0401122D RID: 70189
		private Table __p;
	}
}
