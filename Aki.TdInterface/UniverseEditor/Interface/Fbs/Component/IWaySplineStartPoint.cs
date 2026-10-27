using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B65 RID: 23397
	public struct IWaySplineStartPoint : IFlatbufferObject
	{
		// Token: 0x1700B0C2 RID: 45250
		// (get) Token: 0x0602808D RID: 163981 RVA: 0x005811A0 File Offset: 0x0057F3A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602808E RID: 163982 RVA: 0x005811AD File Offset: 0x0057F3AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602808F RID: 163983 RVA: 0x005811B4 File Offset: 0x0057F3B4
		public static IWaySplineStartPoint GetRootAsIWaySplineStartPoint(ByteBuffer _bb)
		{
			return IWaySplineStartPoint.GetRootAsIWaySplineStartPoint(_bb, default(IWaySplineStartPoint));
		}

		// Token: 0x06028090 RID: 163984 RVA: 0x005811D0 File Offset: 0x0057F3D0
		public static IWaySplineStartPoint GetRootAsIWaySplineStartPoint(ByteBuffer _bb, IWaySplineStartPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028091 RID: 163985 RVA: 0x005811ED File Offset: 0x0057F3ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028092 RID: 163986 RVA: 0x005811FC File Offset: 0x0057F3FC
		public IWaySplineStartPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0C3 RID: 45251
		// (get) Token: 0x06028093 RID: 163987 RVA: 0x0058120C File Offset: 0x0057F40C
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

		// Token: 0x1700B0C4 RID: 45252
		// (get) Token: 0x06028094 RID: 163988 RVA: 0x00581248 File Offset: 0x0057F448
		public IVehicleGenerationConfig? GenerationConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVehicleGenerationConfig?(default(IVehicleGenerationConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028095 RID: 163989 RVA: 0x005812A5 File Offset: 0x0057F4A5
		public static Offset<IWaySplineStartPoint> CreateIWaySplineStartPoint(FlatBufferBuilder builder, EWaySplinePointType Type = EWaySplinePointType.Common, Offset<IVehicleGenerationConfig> GenerationConfigOffset = default(Offset<IVehicleGenerationConfig>))
		{
			builder.StartTable(2);
			IWaySplineStartPoint.AddGenerationConfig(builder, GenerationConfigOffset);
			IWaySplineStartPoint.AddType(builder, Type);
			return IWaySplineStartPoint.EndIWaySplineStartPoint(builder);
		}

		// Token: 0x06028096 RID: 163990 RVA: 0x005812C2 File Offset: 0x0057F4C2
		public static void StartIWaySplineStartPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028097 RID: 163991 RVA: 0x005812CB File Offset: 0x0057F4CB
		public static void AddType(FlatBufferBuilder builder, EWaySplinePointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028098 RID: 163992 RVA: 0x005812D6 File Offset: 0x0057F4D6
		public static void AddGenerationConfig(FlatBufferBuilder builder, Offset<IVehicleGenerationConfig> generationConfigOffset)
		{
			builder.AddOffset(1, generationConfigOffset.Value, 0);
		}

		// Token: 0x06028099 RID: 163993 RVA: 0x005812E6 File Offset: 0x0057F4E6
		public static Offset<IWaySplineStartPoint> EndIWaySplineStartPoint(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplineStartPoint>(builder.EndTable());
		}

		// Token: 0x0602809A RID: 163994 RVA: 0x005812F4 File Offset: 0x0057F4F4
		public IWaySplineStartPointT UnPack()
		{
			IWaySplineStartPointT waySplineStartPointT = new IWaySplineStartPointT();
			this.UnPackTo(waySplineStartPointT);
			return waySplineStartPointT;
		}

		// Token: 0x0602809B RID: 163995 RVA: 0x00581310 File Offset: 0x0057F510
		public void UnPackTo(IWaySplineStartPointT _o)
		{
			_o.Type = this.Type;
			_o.GenerationConfig = ((this.GenerationConfig != null) ? this.GenerationConfig.Value.UnPack() : null);
		}

		// Token: 0x0602809C RID: 163996 RVA: 0x00581358 File Offset: 0x0057F558
		public static Offset<IWaySplineStartPoint> Pack(FlatBufferBuilder builder, IWaySplineStartPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplineStartPoint>);
			}
			Offset<IVehicleGenerationConfig> generationConfigOffset = (_o.GenerationConfig == null) ? default(Offset<IVehicleGenerationConfig>) : IVehicleGenerationConfig.Pack(builder, _o.GenerationConfig);
			return IWaySplineStartPoint.CreateIWaySplineStartPoint(builder, _o.Type, generationConfigOffset);
		}

		// Token: 0x0400F2B3 RID: 62131
		private Table __p;
	}
}
