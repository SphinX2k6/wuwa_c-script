using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200617B RID: 24955
	public struct IWaySplineStartPoint : IFlatbufferObject
	{
		// Token: 0x1700BA0A RID: 47626
		// (get) Token: 0x0602A651 RID: 173649 RVA: 0x005C8C30 File Offset: 0x005C6E30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A652 RID: 173650 RVA: 0x005C8C3D File Offset: 0x005C6E3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A653 RID: 173651 RVA: 0x005C8C44 File Offset: 0x005C6E44
		public static IWaySplineStartPoint GetRootAsIWaySplineStartPoint(ByteBuffer _bb)
		{
			return IWaySplineStartPoint.GetRootAsIWaySplineStartPoint(_bb, default(IWaySplineStartPoint));
		}

		// Token: 0x0602A654 RID: 173652 RVA: 0x005C8C60 File Offset: 0x005C6E60
		public static IWaySplineStartPoint GetRootAsIWaySplineStartPoint(ByteBuffer _bb, IWaySplineStartPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A655 RID: 173653 RVA: 0x005C8C7D File Offset: 0x005C6E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A656 RID: 173654 RVA: 0x005C8C8C File Offset: 0x005C6E8C
		public IWaySplineStartPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA0B RID: 47627
		// (get) Token: 0x0602A657 RID: 173655 RVA: 0x005C8C9C File Offset: 0x005C6E9C
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

		// Token: 0x1700BA0C RID: 47628
		// (get) Token: 0x0602A658 RID: 173656 RVA: 0x005C8CD8 File Offset: 0x005C6ED8
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

		// Token: 0x0602A659 RID: 173657 RVA: 0x005C8D35 File Offset: 0x005C6F35
		public static Offset<IWaySplineStartPoint> CreateIWaySplineStartPoint(FlatBufferBuilder builder, EWaySplinePointType Type = EWaySplinePointType.Common, Offset<IVehicleGenerationConfig> GenerationConfigOffset = default(Offset<IVehicleGenerationConfig>))
		{
			builder.StartTable(2);
			IWaySplineStartPoint.AddGenerationConfig(builder, GenerationConfigOffset);
			IWaySplineStartPoint.AddType(builder, Type);
			return IWaySplineStartPoint.EndIWaySplineStartPoint(builder);
		}

		// Token: 0x0602A65A RID: 173658 RVA: 0x005C8D52 File Offset: 0x005C6F52
		public static void StartIWaySplineStartPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A65B RID: 173659 RVA: 0x005C8D5B File Offset: 0x005C6F5B
		public static void AddType(FlatBufferBuilder builder, EWaySplinePointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A65C RID: 173660 RVA: 0x005C8D66 File Offset: 0x005C6F66
		public static void AddGenerationConfig(FlatBufferBuilder builder, Offset<IVehicleGenerationConfig> generationConfigOffset)
		{
			builder.AddOffset(1, generationConfigOffset.Value, 0);
		}

		// Token: 0x0602A65D RID: 173661 RVA: 0x005C8D76 File Offset: 0x005C6F76
		public static Offset<IWaySplineStartPoint> EndIWaySplineStartPoint(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplineStartPoint>(builder.EndTable());
		}

		// Token: 0x0602A65E RID: 173662 RVA: 0x005C8D84 File Offset: 0x005C6F84
		public IWaySplineStartPointT UnPack()
		{
			IWaySplineStartPointT waySplineStartPointT = new IWaySplineStartPointT();
			this.UnPackTo(waySplineStartPointT);
			return waySplineStartPointT;
		}

		// Token: 0x0602A65F RID: 173663 RVA: 0x005C8DA0 File Offset: 0x005C6FA0
		public void UnPackTo(IWaySplineStartPointT _o)
		{
			_o.Type = this.Type;
			_o.GenerationConfig = ((this.GenerationConfig != null) ? this.GenerationConfig.Value.UnPack() : null);
		}

		// Token: 0x0602A660 RID: 173664 RVA: 0x005C8DE8 File Offset: 0x005C6FE8
		public static Offset<IWaySplineStartPoint> Pack(FlatBufferBuilder builder, IWaySplineStartPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplineStartPoint>);
			}
			Offset<IVehicleGenerationConfig> generationConfigOffset = (_o.GenerationConfig == null) ? default(Offset<IVehicleGenerationConfig>) : IVehicleGenerationConfig.Pack(builder, _o.GenerationConfig);
			return IWaySplineStartPoint.CreateIWaySplineStartPoint(builder, _o.Type, generationConfigOffset);
		}

		// Token: 0x0400FFB9 RID: 65465
		private Table __p;
	}
}
