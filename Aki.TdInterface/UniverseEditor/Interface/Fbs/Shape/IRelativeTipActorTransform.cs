using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C31 RID: 15409
	public struct IRelativeTipActorTransform : IFlatbufferObject
	{
		// Token: 0x17006A13 RID: 27155
		// (get) Token: 0x06015449 RID: 87113 RVA: 0x003141C2 File Offset: 0x003123C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601544A RID: 87114 RVA: 0x003141CF File Offset: 0x003123CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601544B RID: 87115 RVA: 0x003141D8 File Offset: 0x003123D8
		public static IRelativeTipActorTransform GetRootAsIRelativeTipActorTransform(ByteBuffer _bb)
		{
			return IRelativeTipActorTransform.GetRootAsIRelativeTipActorTransform(_bb, default(IRelativeTipActorTransform));
		}

		// Token: 0x0601544C RID: 87116 RVA: 0x003141F4 File Offset: 0x003123F4
		public static IRelativeTipActorTransform GetRootAsIRelativeTipActorTransform(ByteBuffer _bb, IRelativeTipActorTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601544D RID: 87117 RVA: 0x00314211 File Offset: 0x00312411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601544E RID: 87118 RVA: 0x00314220 File Offset: 0x00312420
		public IRelativeTipActorTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A14 RID: 27156
		// (get) Token: 0x0601544F RID: 87119 RVA: 0x00314230 File Offset: 0x00312430
		public ETipsActorTransformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorTransformType.Absolute;
				}
				return (ETipsActorTransformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A15 RID: 27157
		// (get) Token: 0x06015450 RID: 87120 RVA: 0x0031426C File Offset: 0x0031246C
		public IVectorInfo? Pos
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

		// Token: 0x17006A16 RID: 27158
		// (get) Token: 0x06015451 RID: 87121 RVA: 0x003142CC File Offset: 0x003124CC
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006A17 RID: 27159
		// (get) Token: 0x06015452 RID: 87122 RVA: 0x0031432C File Offset: 0x0031252C
		public int RelativeEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015453 RID: 87123 RVA: 0x00314369 File Offset: 0x00312569
		public static Offset<IRelativeTipActorTransform> CreateIRelativeTipActorTransform(FlatBufferBuilder builder, ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), int RelativeEntityId = 0)
		{
			builder.StartTable(4);
			IRelativeTipActorTransform.AddRelativeEntityId(builder, RelativeEntityId);
			IRelativeTipActorTransform.AddRot(builder, RotOffset);
			IRelativeTipActorTransform.AddPos(builder, PosOffset);
			IRelativeTipActorTransform.AddType(builder, Type);
			return IRelativeTipActorTransform.EndIRelativeTipActorTransform(builder);
		}

		// Token: 0x06015454 RID: 87124 RVA: 0x00314395 File Offset: 0x00312595
		public static void StartIRelativeTipActorTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015455 RID: 87125 RVA: 0x0031439E File Offset: 0x0031259E
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015456 RID: 87126 RVA: 0x003143A9 File Offset: 0x003125A9
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06015457 RID: 87127 RVA: 0x003143B9 File Offset: 0x003125B9
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x06015458 RID: 87128 RVA: 0x003143C9 File Offset: 0x003125C9
		public static void AddRelativeEntityId(FlatBufferBuilder builder, int relativeEntityId)
		{
			builder.AddInt(3, relativeEntityId, 0);
		}

		// Token: 0x06015459 RID: 87129 RVA: 0x003143D4 File Offset: 0x003125D4
		public static Offset<IRelativeTipActorTransform> EndIRelativeTipActorTransform(FlatBufferBuilder builder)
		{
			return new Offset<IRelativeTipActorTransform>(builder.EndTable());
		}

		// Token: 0x0601545A RID: 87130 RVA: 0x003143E4 File Offset: 0x003125E4
		public IRelativeTipActorTransformT UnPack()
		{
			IRelativeTipActorTransformT relativeTipActorTransformT = new IRelativeTipActorTransformT();
			this.UnPackTo(relativeTipActorTransformT);
			return relativeTipActorTransformT;
		}

		// Token: 0x0601545B RID: 87131 RVA: 0x00314400 File Offset: 0x00312600
		public void UnPackTo(IRelativeTipActorTransformT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.RelativeEntityId = this.RelativeEntityId;
		}

		// Token: 0x0601545C RID: 87132 RVA: 0x00314484 File Offset: 0x00312684
		public static Offset<IRelativeTipActorTransform> Pack(FlatBufferBuilder builder, IRelativeTipActorTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRelativeTipActorTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IRelativeTipActorTransform.CreateIRelativeTipActorTransform(builder, _o.Type, posOffset, rotOffset, _o.RelativeEntityId);
		}

		// Token: 0x0400B22C RID: 45612
		private Table __p;
	}
}
