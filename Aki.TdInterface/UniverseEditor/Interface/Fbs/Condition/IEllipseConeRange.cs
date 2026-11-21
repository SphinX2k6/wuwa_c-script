using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050FD RID: 20733
	public struct IEllipseConeRange : IFlatbufferObject
	{
		// Token: 0x17009491 RID: 38033
		// (get) Token: 0x0602094D RID: 133453 RVA: 0x00484BC8 File Offset: 0x00482DC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602094E RID: 133454 RVA: 0x00484BD5 File Offset: 0x00482DD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602094F RID: 133455 RVA: 0x00484BDC File Offset: 0x00482DDC
		public static IEllipseConeRange GetRootAsIEllipseConeRange(ByteBuffer _bb)
		{
			return IEllipseConeRange.GetRootAsIEllipseConeRange(_bb, default(IEllipseConeRange));
		}

		// Token: 0x06020950 RID: 133456 RVA: 0x00484BF8 File Offset: 0x00482DF8
		public static IEllipseConeRange GetRootAsIEllipseConeRange(ByteBuffer _bb, IEllipseConeRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020951 RID: 133457 RVA: 0x00484C15 File Offset: 0x00482E15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020952 RID: 133458 RVA: 0x00484C24 File Offset: 0x00482E24
		public IEllipseConeRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009492 RID: 38034
		// (get) Token: 0x06020953 RID: 133459 RVA: 0x00484C34 File Offset: 0x00482E34
		public float HorizontalAngle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009493 RID: 38035
		// (get) Token: 0x06020954 RID: 133460 RVA: 0x00484C74 File Offset: 0x00482E74
		public float VerticalAngle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020955 RID: 133461 RVA: 0x00484CB4 File Offset: 0x00482EB4
		public static Offset<IEllipseConeRange> CreateIEllipseConeRange(FlatBufferBuilder builder, float HorizontalAngle = 0f, float VerticalAngle = 0f)
		{
			builder.StartTable(2);
			IEllipseConeRange.AddVerticalAngle(builder, VerticalAngle);
			IEllipseConeRange.AddHorizontalAngle(builder, HorizontalAngle);
			return IEllipseConeRange.EndIEllipseConeRange(builder);
		}

		// Token: 0x06020956 RID: 133462 RVA: 0x00484CD1 File Offset: 0x00482ED1
		public static void StartIEllipseConeRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020957 RID: 133463 RVA: 0x00484CDA File Offset: 0x00482EDA
		public static void AddHorizontalAngle(FlatBufferBuilder builder, float horizontalAngle)
		{
			builder.AddFloat(0, horizontalAngle, 0.0);
		}

		// Token: 0x06020958 RID: 133464 RVA: 0x00484CED File Offset: 0x00482EED
		public static void AddVerticalAngle(FlatBufferBuilder builder, float verticalAngle)
		{
			builder.AddFloat(1, verticalAngle, 0.0);
		}

		// Token: 0x06020959 RID: 133465 RVA: 0x00484D00 File Offset: 0x00482F00
		public static Offset<IEllipseConeRange> EndIEllipseConeRange(FlatBufferBuilder builder)
		{
			return new Offset<IEllipseConeRange>(builder.EndTable());
		}

		// Token: 0x0602095A RID: 133466 RVA: 0x00484D10 File Offset: 0x00482F10
		public IEllipseConeRangeT UnPack()
		{
			IEllipseConeRangeT ellipseConeRangeT = new IEllipseConeRangeT();
			this.UnPackTo(ellipseConeRangeT);
			return ellipseConeRangeT;
		}

		// Token: 0x0602095B RID: 133467 RVA: 0x00484D2B File Offset: 0x00482F2B
		public void UnPackTo(IEllipseConeRangeT _o)
		{
			_o.HorizontalAngle = this.HorizontalAngle;
			_o.VerticalAngle = this.VerticalAngle;
		}

		// Token: 0x0602095C RID: 133468 RVA: 0x00484D48 File Offset: 0x00482F48
		public static Offset<IEllipseConeRange> Pack(FlatBufferBuilder builder, IEllipseConeRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEllipseConeRange>);
			}
			return IEllipseConeRange.CreateIEllipseConeRange(builder, _o.HorizontalAngle, _o.VerticalAngle);
		}

		// Token: 0x0400E0BB RID: 57531
		private Table __p;
	}
}
