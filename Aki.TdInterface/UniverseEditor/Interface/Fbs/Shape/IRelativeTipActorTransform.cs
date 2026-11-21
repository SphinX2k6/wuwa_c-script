using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004040 RID: 16448
	public struct IRelativeTipActorTransform : IFlatbufferObject
	{
		// Token: 0x17006FC4 RID: 28612
		// (get) Token: 0x0601695D RID: 92509 RVA: 0x0033B062 File Offset: 0x00339262
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601695E RID: 92510 RVA: 0x0033B06F File Offset: 0x0033926F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601695F RID: 92511 RVA: 0x0033B078 File Offset: 0x00339278
		public static IRelativeTipActorTransform GetRootAsIRelativeTipActorTransform(ByteBuffer _bb)
		{
			return IRelativeTipActorTransform.GetRootAsIRelativeTipActorTransform(_bb, default(IRelativeTipActorTransform));
		}

		// Token: 0x06016960 RID: 92512 RVA: 0x0033B094 File Offset: 0x00339294
		public static IRelativeTipActorTransform GetRootAsIRelativeTipActorTransform(ByteBuffer _bb, IRelativeTipActorTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016961 RID: 92513 RVA: 0x0033B0B1 File Offset: 0x003392B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016962 RID: 92514 RVA: 0x0033B0C0 File Offset: 0x003392C0
		public IRelativeTipActorTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FC5 RID: 28613
		// (get) Token: 0x06016963 RID: 92515 RVA: 0x0033B0D0 File Offset: 0x003392D0
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

		// Token: 0x17006FC6 RID: 28614
		// (get) Token: 0x06016964 RID: 92516 RVA: 0x0033B10C File Offset: 0x0033930C
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

		// Token: 0x17006FC7 RID: 28615
		// (get) Token: 0x06016965 RID: 92517 RVA: 0x0033B16C File Offset: 0x0033936C
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

		// Token: 0x17006FC8 RID: 28616
		// (get) Token: 0x06016966 RID: 92518 RVA: 0x0033B1CC File Offset: 0x003393CC
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

		// Token: 0x06016967 RID: 92519 RVA: 0x0033B209 File Offset: 0x00339409
		public static Offset<IRelativeTipActorTransform> CreateIRelativeTipActorTransform(FlatBufferBuilder builder, ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), int RelativeEntityId = 0)
		{
			builder.StartTable(4);
			IRelativeTipActorTransform.AddRelativeEntityId(builder, RelativeEntityId);
			IRelativeTipActorTransform.AddRot(builder, RotOffset);
			IRelativeTipActorTransform.AddPos(builder, PosOffset);
			IRelativeTipActorTransform.AddType(builder, Type);
			return IRelativeTipActorTransform.EndIRelativeTipActorTransform(builder);
		}

		// Token: 0x06016968 RID: 92520 RVA: 0x0033B235 File Offset: 0x00339435
		public static void StartIRelativeTipActorTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016969 RID: 92521 RVA: 0x0033B23E File Offset: 0x0033943E
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601696A RID: 92522 RVA: 0x0033B249 File Offset: 0x00339449
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601696B RID: 92523 RVA: 0x0033B259 File Offset: 0x00339459
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x0601696C RID: 92524 RVA: 0x0033B269 File Offset: 0x00339469
		public static void AddRelativeEntityId(FlatBufferBuilder builder, int relativeEntityId)
		{
			builder.AddInt(3, relativeEntityId, 0);
		}

		// Token: 0x0601696D RID: 92525 RVA: 0x0033B274 File Offset: 0x00339474
		public static Offset<IRelativeTipActorTransform> EndIRelativeTipActorTransform(FlatBufferBuilder builder)
		{
			return new Offset<IRelativeTipActorTransform>(builder.EndTable());
		}

		// Token: 0x0601696E RID: 92526 RVA: 0x0033B284 File Offset: 0x00339484
		public IRelativeTipActorTransformT UnPack()
		{
			IRelativeTipActorTransformT relativeTipActorTransformT = new IRelativeTipActorTransformT();
			this.UnPackTo(relativeTipActorTransformT);
			return relativeTipActorTransformT;
		}

		// Token: 0x0601696F RID: 92527 RVA: 0x0033B2A0 File Offset: 0x003394A0
		public void UnPackTo(IRelativeTipActorTransformT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.RelativeEntityId = this.RelativeEntityId;
		}

		// Token: 0x06016970 RID: 92528 RVA: 0x0033B324 File Offset: 0x00339524
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

		// Token: 0x0400BBBC RID: 48060
		private Table __p;
	}
}
