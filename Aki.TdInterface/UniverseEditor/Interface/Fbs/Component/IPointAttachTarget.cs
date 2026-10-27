using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574E RID: 22350
	public struct IPointAttachTarget : IFlatbufferObject
	{
		// Token: 0x1700A6C2 RID: 42690
		// (get) Token: 0x06025743 RID: 153411 RVA: 0x0052B096 File Offset: 0x00529296
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025744 RID: 153412 RVA: 0x0052B0A3 File Offset: 0x005292A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025745 RID: 153413 RVA: 0x0052B0AC File Offset: 0x005292AC
		public static IPointAttachTarget GetRootAsIPointAttachTarget(ByteBuffer _bb)
		{
			return IPointAttachTarget.GetRootAsIPointAttachTarget(_bb, default(IPointAttachTarget));
		}

		// Token: 0x06025746 RID: 153414 RVA: 0x0052B0C8 File Offset: 0x005292C8
		public static IPointAttachTarget GetRootAsIPointAttachTarget(ByteBuffer _bb, IPointAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025747 RID: 153415 RVA: 0x0052B0E5 File Offset: 0x005292E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025748 RID: 153416 RVA: 0x0052B0F4 File Offset: 0x005292F4
		public IPointAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6C3 RID: 42691
		// (get) Token: 0x06025749 RID: 153417 RVA: 0x0052B104 File Offset: 0x00529304
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6C4 RID: 42692
		// (get) Token: 0x0602574A RID: 153418 RVA: 0x0052B140 File Offset: 0x00529340
		public IVectorInfo? RelativePoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602574B RID: 153419 RVA: 0x0052B19D File Offset: 0x0052939D
		public static Offset<IPointAttachTarget> CreateIPointAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor, Offset<IVectorInfo> RelativePointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPointAttachTarget.AddRelativePoint(builder, RelativePointOffset);
			IPointAttachTarget.AddType(builder, Type);
			return IPointAttachTarget.EndIPointAttachTarget(builder);
		}

		// Token: 0x0602574C RID: 153420 RVA: 0x0052B1BA File Offset: 0x005293BA
		public static void StartIPointAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602574D RID: 153421 RVA: 0x0052B1C3 File Offset: 0x005293C3
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602574E RID: 153422 RVA: 0x0052B1CE File Offset: 0x005293CE
		public static void AddRelativePoint(FlatBufferBuilder builder, Offset<IVectorInfo> relativePointOffset)
		{
			builder.AddOffset(1, relativePointOffset.Value, 0);
		}

		// Token: 0x0602574F RID: 153423 RVA: 0x0052B1DE File Offset: 0x005293DE
		public static Offset<IPointAttachTarget> EndIPointAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPointAttachTarget>(builder.EndTable());
		}

		// Token: 0x06025750 RID: 153424 RVA: 0x0052B1EC File Offset: 0x005293EC
		public IPointAttachTargetT UnPack()
		{
			IPointAttachTargetT pointAttachTargetT = new IPointAttachTargetT();
			this.UnPackTo(pointAttachTargetT);
			return pointAttachTargetT;
		}

		// Token: 0x06025751 RID: 153425 RVA: 0x0052B208 File Offset: 0x00529408
		public void UnPackTo(IPointAttachTargetT _o)
		{
			_o.Type = this.Type;
			_o.RelativePoint = ((this.RelativePoint != null) ? this.RelativePoint.Value.UnPack() : null);
		}

		// Token: 0x06025752 RID: 153426 RVA: 0x0052B250 File Offset: 0x00529450
		public static Offset<IPointAttachTarget> Pack(FlatBufferBuilder builder, IPointAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointAttachTarget>);
			}
			Offset<IVectorInfo> relativePointOffset = (_o.RelativePoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativePoint);
			return IPointAttachTarget.CreateIPointAttachTarget(builder, _o.Type, relativePointOffset);
		}

		// Token: 0x0400EBED RID: 60397
		private Table __p;
	}
}
