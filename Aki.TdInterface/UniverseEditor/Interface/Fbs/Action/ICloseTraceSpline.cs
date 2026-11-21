using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB3 RID: 27315
	public struct ICloseTraceSpline : IFlatbufferObject
	{
		// Token: 0x1700C8A1 RID: 51361
		// (get) Token: 0x0602EE2F RID: 192047 RVA: 0x0066366E File Offset: 0x0066186E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE30 RID: 192048 RVA: 0x0066367B File Offset: 0x0066187B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE31 RID: 192049 RVA: 0x00663684 File Offset: 0x00661884
		public static ICloseTraceSpline GetRootAsICloseTraceSpline(ByteBuffer _bb)
		{
			return ICloseTraceSpline.GetRootAsICloseTraceSpline(_bb, default(ICloseTraceSpline));
		}

		// Token: 0x0602EE32 RID: 192050 RVA: 0x006636A0 File Offset: 0x006618A0
		public static ICloseTraceSpline GetRootAsICloseTraceSpline(ByteBuffer _bb, ICloseTraceSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE33 RID: 192051 RVA: 0x006636BD File Offset: 0x006618BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE34 RID: 192052 RVA: 0x006636CC File Offset: 0x006618CC
		public ICloseTraceSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8A2 RID: 51362
		// (get) Token: 0x0602EE35 RID: 192053 RVA: 0x006636DC File Offset: 0x006618DC
		public ETraceSplineOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETraceSplineOptionType.Open;
				}
				return (ETraceSplineOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C8A3 RID: 51363
		// (get) Token: 0x0602EE36 RID: 192054 RVA: 0x00663718 File Offset: 0x00661918
		public int SplineEntityId
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

		// Token: 0x0602EE37 RID: 192055 RVA: 0x00663754 File Offset: 0x00661954
		public static Offset<ICloseTraceSpline> CreateICloseTraceSpline(FlatBufferBuilder builder, ETraceSplineOptionType Type = ETraceSplineOptionType.Open, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			ICloseTraceSpline.AddSplineEntityId(builder, SplineEntityId);
			ICloseTraceSpline.AddType(builder, Type);
			return ICloseTraceSpline.EndICloseTraceSpline(builder);
		}

		// Token: 0x0602EE38 RID: 192056 RVA: 0x00663771 File Offset: 0x00661971
		public static void StartICloseTraceSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EE39 RID: 192057 RVA: 0x0066377A File Offset: 0x0066197A
		public static void AddType(FlatBufferBuilder builder, ETraceSplineOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EE3A RID: 192058 RVA: 0x00663785 File Offset: 0x00661985
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602EE3B RID: 192059 RVA: 0x00663790 File Offset: 0x00661990
		public static Offset<ICloseTraceSpline> EndICloseTraceSpline(FlatBufferBuilder builder)
		{
			return new Offset<ICloseTraceSpline>(builder.EndTable());
		}

		// Token: 0x0602EE3C RID: 192060 RVA: 0x006637A0 File Offset: 0x006619A0
		public ICloseTraceSplineT UnPack()
		{
			ICloseTraceSplineT closeTraceSplineT = new ICloseTraceSplineT();
			this.UnPackTo(closeTraceSplineT);
			return closeTraceSplineT;
		}

		// Token: 0x0602EE3D RID: 192061 RVA: 0x006637BB File Offset: 0x006619BB
		public void UnPackTo(ICloseTraceSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602EE3E RID: 192062 RVA: 0x006637D8 File Offset: 0x006619D8
		public static Offset<ICloseTraceSpline> Pack(FlatBufferBuilder builder, ICloseTraceSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseTraceSpline>);
			}
			return ICloseTraceSpline.CreateICloseTraceSpline(builder, _o.Type, _o.SplineEntityId);
		}

		// Token: 0x04011857 RID: 71767
		private Table __p;
	}
}
