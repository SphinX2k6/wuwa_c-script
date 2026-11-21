using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200616F RID: 24943
	public struct IWaySplineCommonPoint : IFlatbufferObject
	{
		// Token: 0x1700B9F5 RID: 47605
		// (get) Token: 0x0602A5F5 RID: 173557 RVA: 0x005C802E File Offset: 0x005C622E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A5F6 RID: 173558 RVA: 0x005C803B File Offset: 0x005C623B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A5F7 RID: 173559 RVA: 0x005C8044 File Offset: 0x005C6244
		public static IWaySplineCommonPoint GetRootAsIWaySplineCommonPoint(ByteBuffer _bb)
		{
			return IWaySplineCommonPoint.GetRootAsIWaySplineCommonPoint(_bb, default(IWaySplineCommonPoint));
		}

		// Token: 0x0602A5F8 RID: 173560 RVA: 0x005C8060 File Offset: 0x005C6260
		public static IWaySplineCommonPoint GetRootAsIWaySplineCommonPoint(ByteBuffer _bb, IWaySplineCommonPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A5F9 RID: 173561 RVA: 0x005C807D File Offset: 0x005C627D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A5FA RID: 173562 RVA: 0x005C808C File Offset: 0x005C628C
		public IWaySplineCommonPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9F6 RID: 47606
		// (get) Token: 0x0602A5FB RID: 173563 RVA: 0x005C809C File Offset: 0x005C629C
		public EWaySplinePointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWaySplinePointType.Common;
				}
				return (EWaySplinePointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A5FC RID: 173564 RVA: 0x005C80D8 File Offset: 0x005C62D8
		public static Offset<IWaySplineCommonPoint> CreateIWaySplineCommonPoint(FlatBufferBuilder builder, EWaySplinePointType Type = EWaySplinePointType.Common)
		{
			builder.StartTable(1);
			IWaySplineCommonPoint.AddType(builder, Type);
			return IWaySplineCommonPoint.EndIWaySplineCommonPoint(builder);
		}

		// Token: 0x0602A5FD RID: 173565 RVA: 0x005C80EE File Offset: 0x005C62EE
		public static void StartIWaySplineCommonPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A5FE RID: 173566 RVA: 0x005C80F7 File Offset: 0x005C62F7
		public static void AddType(FlatBufferBuilder builder, EWaySplinePointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A5FF RID: 173567 RVA: 0x005C8102 File Offset: 0x005C6302
		public static Offset<IWaySplineCommonPoint> EndIWaySplineCommonPoint(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplineCommonPoint>(builder.EndTable());
		}

		// Token: 0x0602A600 RID: 173568 RVA: 0x005C8110 File Offset: 0x005C6310
		public IWaySplineCommonPointT UnPack()
		{
			IWaySplineCommonPointT waySplineCommonPointT = new IWaySplineCommonPointT();
			this.UnPackTo(waySplineCommonPointT);
			return waySplineCommonPointT;
		}

		// Token: 0x0602A601 RID: 173569 RVA: 0x005C812B File Offset: 0x005C632B
		public void UnPackTo(IWaySplineCommonPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A602 RID: 173570 RVA: 0x005C813C File Offset: 0x005C633C
		public static Offset<IWaySplineCommonPoint> Pack(FlatBufferBuilder builder, IWaySplineCommonPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplineCommonPoint>);
			}
			return IWaySplineCommonPoint.CreateIWaySplineCommonPoint(builder, _o.Type);
		}

		// Token: 0x0400FFA7 RID: 65447
		private Table __p;
	}
}
