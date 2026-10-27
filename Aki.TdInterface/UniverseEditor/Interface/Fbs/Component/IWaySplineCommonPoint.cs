using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B59 RID: 23385
	public struct IWaySplineCommonPoint : IFlatbufferObject
	{
		// Token: 0x1700B0AD RID: 45229
		// (get) Token: 0x06028031 RID: 163889 RVA: 0x0058059E File Offset: 0x0057E79E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028032 RID: 163890 RVA: 0x005805AB File Offset: 0x0057E7AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028033 RID: 163891 RVA: 0x005805B4 File Offset: 0x0057E7B4
		public static IWaySplineCommonPoint GetRootAsIWaySplineCommonPoint(ByteBuffer _bb)
		{
			return IWaySplineCommonPoint.GetRootAsIWaySplineCommonPoint(_bb, default(IWaySplineCommonPoint));
		}

		// Token: 0x06028034 RID: 163892 RVA: 0x005805D0 File Offset: 0x0057E7D0
		public static IWaySplineCommonPoint GetRootAsIWaySplineCommonPoint(ByteBuffer _bb, IWaySplineCommonPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028035 RID: 163893 RVA: 0x005805ED File Offset: 0x0057E7ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028036 RID: 163894 RVA: 0x005805FC File Offset: 0x0057E7FC
		public IWaySplineCommonPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0AE RID: 45230
		// (get) Token: 0x06028037 RID: 163895 RVA: 0x0058060C File Offset: 0x0057E80C
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

		// Token: 0x06028038 RID: 163896 RVA: 0x00580648 File Offset: 0x0057E848
		public static Offset<IWaySplineCommonPoint> CreateIWaySplineCommonPoint(FlatBufferBuilder builder, EWaySplinePointType Type = EWaySplinePointType.Common)
		{
			builder.StartTable(1);
			IWaySplineCommonPoint.AddType(builder, Type);
			return IWaySplineCommonPoint.EndIWaySplineCommonPoint(builder);
		}

		// Token: 0x06028039 RID: 163897 RVA: 0x0058065E File Offset: 0x0057E85E
		public static void StartIWaySplineCommonPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602803A RID: 163898 RVA: 0x00580667 File Offset: 0x0057E867
		public static void AddType(FlatBufferBuilder builder, EWaySplinePointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602803B RID: 163899 RVA: 0x00580672 File Offset: 0x0057E872
		public static Offset<IWaySplineCommonPoint> EndIWaySplineCommonPoint(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplineCommonPoint>(builder.EndTable());
		}

		// Token: 0x0602803C RID: 163900 RVA: 0x00580680 File Offset: 0x0057E880
		public IWaySplineCommonPointT UnPack()
		{
			IWaySplineCommonPointT waySplineCommonPointT = new IWaySplineCommonPointT();
			this.UnPackTo(waySplineCommonPointT);
			return waySplineCommonPointT;
		}

		// Token: 0x0602803D RID: 163901 RVA: 0x0058069B File Offset: 0x0057E89B
		public void UnPackTo(IWaySplineCommonPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602803E RID: 163902 RVA: 0x005806AC File Offset: 0x0057E8AC
		public static Offset<IWaySplineCommonPoint> Pack(FlatBufferBuilder builder, IWaySplineCommonPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplineCommonPoint>);
			}
			return IWaySplineCommonPoint.CreateIWaySplineCommonPoint(builder, _o.Type);
		}

		// Token: 0x0400F2A1 RID: 62113
		private Table __p;
	}
}
