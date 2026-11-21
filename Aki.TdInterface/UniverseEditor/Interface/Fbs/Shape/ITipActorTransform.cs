using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004067 RID: 16487
	public struct ITipActorTransform : IFlatbufferObject
	{
		// Token: 0x1700703F RID: 28735
		// (get) Token: 0x06016AF5 RID: 92917 RVA: 0x0033E138 File Offset: 0x0033C338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016AF6 RID: 92918 RVA: 0x0033E145 File Offset: 0x0033C345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016AF7 RID: 92919 RVA: 0x0033E14C File Offset: 0x0033C34C
		public static ITipActorTransform GetRootAsITipActorTransform(ByteBuffer _bb)
		{
			return ITipActorTransform.GetRootAsITipActorTransform(_bb, default(ITipActorTransform));
		}

		// Token: 0x06016AF8 RID: 92920 RVA: 0x0033E168 File Offset: 0x0033C368
		public static ITipActorTransform GetRootAsITipActorTransform(ByteBuffer _bb, ITipActorTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016AF9 RID: 92921 RVA: 0x0033E185 File Offset: 0x0033C385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016AFA RID: 92922 RVA: 0x0033E194 File Offset: 0x0033C394
		public ITipActorTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007040 RID: 28736
		// (get) Token: 0x06016AFB RID: 92923 RVA: 0x0033E1A4 File Offset: 0x0033C3A4
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

		// Token: 0x17007041 RID: 28737
		// (get) Token: 0x06016AFC RID: 92924 RVA: 0x0033E1E0 File Offset: 0x0033C3E0
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

		// Token: 0x17007042 RID: 28738
		// (get) Token: 0x06016AFD RID: 92925 RVA: 0x0033E240 File Offset: 0x0033C440
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

		// Token: 0x06016AFE RID: 92926 RVA: 0x0033E29D File Offset: 0x0033C49D
		public static Offset<ITipActorTransform> CreateITipActorTransform(FlatBufferBuilder builder, ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ITipActorTransform.AddRot(builder, RotOffset);
			ITipActorTransform.AddPos(builder, PosOffset);
			ITipActorTransform.AddType(builder, Type);
			return ITipActorTransform.EndITipActorTransform(builder);
		}

		// Token: 0x06016AFF RID: 92927 RVA: 0x0033E2C1 File Offset: 0x0033C4C1
		public static void StartITipActorTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016B00 RID: 92928 RVA: 0x0033E2CA File Offset: 0x0033C4CA
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B01 RID: 92929 RVA: 0x0033E2D5 File Offset: 0x0033C4D5
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06016B02 RID: 92930 RVA: 0x0033E2E5 File Offset: 0x0033C4E5
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x06016B03 RID: 92931 RVA: 0x0033E2F5 File Offset: 0x0033C4F5
		public static Offset<ITipActorTransform> EndITipActorTransform(FlatBufferBuilder builder)
		{
			return new Offset<ITipActorTransform>(builder.EndTable());
		}

		// Token: 0x06016B04 RID: 92932 RVA: 0x0033E304 File Offset: 0x0033C504
		public ITipActorTransformT UnPack()
		{
			ITipActorTransformT tipActorTransformT = new ITipActorTransformT();
			this.UnPackTo(tipActorTransformT);
			return tipActorTransformT;
		}

		// Token: 0x06016B05 RID: 92933 RVA: 0x0033E320 File Offset: 0x0033C520
		public void UnPackTo(ITipActorTransformT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06016B06 RID: 92934 RVA: 0x0033E398 File Offset: 0x0033C598
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

		// Token: 0x0400BC00 RID: 48128
		private Table __p;
	}
}
