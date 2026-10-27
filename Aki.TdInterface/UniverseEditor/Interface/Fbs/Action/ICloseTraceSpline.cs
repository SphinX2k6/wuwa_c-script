using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200643F RID: 25663
	public struct ICloseTraceSpline : IFlatbufferObject
	{
		// Token: 0x1700BF15 RID: 48917
		// (get) Token: 0x0602C6AA RID: 181930 RVA: 0x0061802A File Offset: 0x0061622A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C6AB RID: 181931 RVA: 0x00618037 File Offset: 0x00616237
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C6AC RID: 181932 RVA: 0x00618040 File Offset: 0x00616240
		public static ICloseTraceSpline GetRootAsICloseTraceSpline(ByteBuffer _bb)
		{
			return ICloseTraceSpline.GetRootAsICloseTraceSpline(_bb, default(ICloseTraceSpline));
		}

		// Token: 0x0602C6AD RID: 181933 RVA: 0x0061805C File Offset: 0x0061625C
		public static ICloseTraceSpline GetRootAsICloseTraceSpline(ByteBuffer _bb, ICloseTraceSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C6AE RID: 181934 RVA: 0x00618079 File Offset: 0x00616279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C6AF RID: 181935 RVA: 0x00618088 File Offset: 0x00616288
		public ICloseTraceSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF16 RID: 48918
		// (get) Token: 0x0602C6B0 RID: 181936 RVA: 0x00618098 File Offset: 0x00616298
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

		// Token: 0x1700BF17 RID: 48919
		// (get) Token: 0x0602C6B1 RID: 181937 RVA: 0x006180D4 File Offset: 0x006162D4
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

		// Token: 0x0602C6B2 RID: 181938 RVA: 0x00618110 File Offset: 0x00616310
		public static Offset<ICloseTraceSpline> CreateICloseTraceSpline(FlatBufferBuilder builder, ETraceSplineOptionType Type = ETraceSplineOptionType.Open, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			ICloseTraceSpline.AddSplineEntityId(builder, SplineEntityId);
			ICloseTraceSpline.AddType(builder, Type);
			return ICloseTraceSpline.EndICloseTraceSpline(builder);
		}

		// Token: 0x0602C6B3 RID: 181939 RVA: 0x0061812D File Offset: 0x0061632D
		public static void StartICloseTraceSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C6B4 RID: 181940 RVA: 0x00618136 File Offset: 0x00616336
		public static void AddType(FlatBufferBuilder builder, ETraceSplineOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C6B5 RID: 181941 RVA: 0x00618141 File Offset: 0x00616341
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602C6B6 RID: 181942 RVA: 0x0061814C File Offset: 0x0061634C
		public static Offset<ICloseTraceSpline> EndICloseTraceSpline(FlatBufferBuilder builder)
		{
			return new Offset<ICloseTraceSpline>(builder.EndTable());
		}

		// Token: 0x0602C6B7 RID: 181943 RVA: 0x0061815C File Offset: 0x0061635C
		public ICloseTraceSplineT UnPack()
		{
			ICloseTraceSplineT closeTraceSplineT = new ICloseTraceSplineT();
			this.UnPackTo(closeTraceSplineT);
			return closeTraceSplineT;
		}

		// Token: 0x0602C6B8 RID: 181944 RVA: 0x00618177 File Offset: 0x00616377
		public void UnPackTo(ICloseTraceSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602C6B9 RID: 181945 RVA: 0x00618194 File Offset: 0x00616394
		public static Offset<ICloseTraceSpline> Pack(FlatBufferBuilder builder, ICloseTraceSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseTraceSpline>);
			}
			return ICloseTraceSpline.CreateICloseTraceSpline(builder, _o.Type, _o.SplineEntityId);
		}

		// Token: 0x04010A3A RID: 68154
		private Table __p;
	}
}
