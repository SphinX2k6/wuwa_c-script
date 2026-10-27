using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BDD RID: 15325
	public struct IAbsoluteTipActorTransform : IFlatbufferObject
	{
		// Token: 0x1700691B RID: 26907
		// (get) Token: 0x060150F9 RID: 86265 RVA: 0x0030D7C4 File Offset: 0x0030B9C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060150FA RID: 86266 RVA: 0x0030D7D1 File Offset: 0x0030B9D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060150FB RID: 86267 RVA: 0x0030D7D8 File Offset: 0x0030B9D8
		public static IAbsoluteTipActorTransform GetRootAsIAbsoluteTipActorTransform(ByteBuffer _bb)
		{
			return IAbsoluteTipActorTransform.GetRootAsIAbsoluteTipActorTransform(_bb, default(IAbsoluteTipActorTransform));
		}

		// Token: 0x060150FC RID: 86268 RVA: 0x0030D7F4 File Offset: 0x0030B9F4
		public static IAbsoluteTipActorTransform GetRootAsIAbsoluteTipActorTransform(ByteBuffer _bb, IAbsoluteTipActorTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060150FD RID: 86269 RVA: 0x0030D811 File Offset: 0x0030BA11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060150FE RID: 86270 RVA: 0x0030D820 File Offset: 0x0030BA20
		public IAbsoluteTipActorTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700691C RID: 26908
		// (get) Token: 0x060150FF RID: 86271 RVA: 0x0030D830 File Offset: 0x0030BA30
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

		// Token: 0x1700691D RID: 26909
		// (get) Token: 0x06015100 RID: 86272 RVA: 0x0030D86C File Offset: 0x0030BA6C
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

		// Token: 0x1700691E RID: 26910
		// (get) Token: 0x06015101 RID: 86273 RVA: 0x0030D8CC File Offset: 0x0030BACC
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

		// Token: 0x06015102 RID: 86274 RVA: 0x0030D929 File Offset: 0x0030BB29
		public static Offset<IAbsoluteTipActorTransform> CreateIAbsoluteTipActorTransform(FlatBufferBuilder builder, ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IAbsoluteTipActorTransform.AddRot(builder, RotOffset);
			IAbsoluteTipActorTransform.AddPos(builder, PosOffset);
			IAbsoluteTipActorTransform.AddType(builder, Type);
			return IAbsoluteTipActorTransform.EndIAbsoluteTipActorTransform(builder);
		}

		// Token: 0x06015103 RID: 86275 RVA: 0x0030D94D File Offset: 0x0030BB4D
		public static void StartIAbsoluteTipActorTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015104 RID: 86276 RVA: 0x0030D956 File Offset: 0x0030BB56
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015105 RID: 86277 RVA: 0x0030D961 File Offset: 0x0030BB61
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06015106 RID: 86278 RVA: 0x0030D971 File Offset: 0x0030BB71
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x06015107 RID: 86279 RVA: 0x0030D981 File Offset: 0x0030BB81
		public static Offset<IAbsoluteTipActorTransform> EndIAbsoluteTipActorTransform(FlatBufferBuilder builder)
		{
			return new Offset<IAbsoluteTipActorTransform>(builder.EndTable());
		}

		// Token: 0x06015108 RID: 86280 RVA: 0x0030D990 File Offset: 0x0030BB90
		public IAbsoluteTipActorTransformT UnPack()
		{
			IAbsoluteTipActorTransformT absoluteTipActorTransformT = new IAbsoluteTipActorTransformT();
			this.UnPackTo(absoluteTipActorTransformT);
			return absoluteTipActorTransformT;
		}

		// Token: 0x06015109 RID: 86281 RVA: 0x0030D9AC File Offset: 0x0030BBAC
		public void UnPackTo(IAbsoluteTipActorTransformT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x0601510A RID: 86282 RVA: 0x0030DA24 File Offset: 0x0030BC24
		public static Offset<IAbsoluteTipActorTransform> Pack(FlatBufferBuilder builder, IAbsoluteTipActorTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAbsoluteTipActorTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IAbsoluteTipActorTransform.CreateIAbsoluteTipActorTransform(builder, _o.Type, posOffset, rotOffset);
		}

		// Token: 0x0400B19C RID: 45468
		private Table __p;
	}
}
