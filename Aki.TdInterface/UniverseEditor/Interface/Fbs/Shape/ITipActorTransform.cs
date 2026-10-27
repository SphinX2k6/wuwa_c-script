using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C58 RID: 15448
	public struct ITipActorTransform : IFlatbufferObject
	{
		// Token: 0x17006A8E RID: 27278
		// (get) Token: 0x060155E1 RID: 87521 RVA: 0x00317298 File Offset: 0x00315498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155E2 RID: 87522 RVA: 0x003172A5 File Offset: 0x003154A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155E3 RID: 87523 RVA: 0x003172AC File Offset: 0x003154AC
		public static ITipActorTransform GetRootAsITipActorTransform(ByteBuffer _bb)
		{
			return ITipActorTransform.GetRootAsITipActorTransform(_bb, default(ITipActorTransform));
		}

		// Token: 0x060155E4 RID: 87524 RVA: 0x003172C8 File Offset: 0x003154C8
		public static ITipActorTransform GetRootAsITipActorTransform(ByteBuffer _bb, ITipActorTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060155E5 RID: 87525 RVA: 0x003172E5 File Offset: 0x003154E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060155E6 RID: 87526 RVA: 0x003172F4 File Offset: 0x003154F4
		public ITipActorTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A8F RID: 27279
		// (get) Token: 0x060155E7 RID: 87527 RVA: 0x00317304 File Offset: 0x00315504
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

		// Token: 0x17006A90 RID: 27280
		// (get) Token: 0x060155E8 RID: 87528 RVA: 0x00317340 File Offset: 0x00315540
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

		// Token: 0x17006A91 RID: 27281
		// (get) Token: 0x060155E9 RID: 87529 RVA: 0x003173A0 File Offset: 0x003155A0
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

		// Token: 0x060155EA RID: 87530 RVA: 0x003173FD File Offset: 0x003155FD
		public static Offset<ITipActorTransform> CreateITipActorTransform(FlatBufferBuilder builder, ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ITipActorTransform.AddRot(builder, RotOffset);
			ITipActorTransform.AddPos(builder, PosOffset);
			ITipActorTransform.AddType(builder, Type);
			return ITipActorTransform.EndITipActorTransform(builder);
		}

		// Token: 0x060155EB RID: 87531 RVA: 0x00317421 File Offset: 0x00315621
		public static void StartITipActorTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060155EC RID: 87532 RVA: 0x0031742A File Offset: 0x0031562A
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155ED RID: 87533 RVA: 0x00317435 File Offset: 0x00315635
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060155EE RID: 87534 RVA: 0x00317445 File Offset: 0x00315645
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x060155EF RID: 87535 RVA: 0x00317455 File Offset: 0x00315655
		public static Offset<ITipActorTransform> EndITipActorTransform(FlatBufferBuilder builder)
		{
			return new Offset<ITipActorTransform>(builder.EndTable());
		}

		// Token: 0x060155F0 RID: 87536 RVA: 0x00317464 File Offset: 0x00315664
		public ITipActorTransformT UnPack()
		{
			ITipActorTransformT tipActorTransformT = new ITipActorTransformT();
			this.UnPackTo(tipActorTransformT);
			return tipActorTransformT;
		}

		// Token: 0x060155F1 RID: 87537 RVA: 0x00317480 File Offset: 0x00315680
		public void UnPackTo(ITipActorTransformT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x060155F2 RID: 87538 RVA: 0x003174F8 File Offset: 0x003156F8
		public static Offset<ITipActorTransform> Pack(FlatBufferBuilder builder, ITipActorTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITipActorTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return ITipActorTransform.CreateITipActorTransform(builder, _o.Type, posOffset, rotOffset);
		}

		// Token: 0x0400B270 RID: 45680
		private Table __p;
	}
}
