using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C3D RID: 15421
	public struct IShapeTransform : IFlatbufferObject
	{
		// Token: 0x17006A3B RID: 27195
		// (get) Token: 0x060154CD RID: 87245 RVA: 0x00315288 File Offset: 0x00313488
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154CE RID: 87246 RVA: 0x00315295 File Offset: 0x00313495
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154CF RID: 87247 RVA: 0x0031529C File Offset: 0x0031349C
		public static IShapeTransform GetRootAsIShapeTransform(ByteBuffer _bb)
		{
			return IShapeTransform.GetRootAsIShapeTransform(_bb, default(IShapeTransform));
		}

		// Token: 0x060154D0 RID: 87248 RVA: 0x003152B8 File Offset: 0x003134B8
		public static IShapeTransform GetRootAsIShapeTransform(ByteBuffer _bb, IShapeTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154D1 RID: 87249 RVA: 0x003152D5 File Offset: 0x003134D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154D2 RID: 87250 RVA: 0x003152E4 File Offset: 0x003134E4
		public IShapeTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A3C RID: 27196
		// (get) Token: 0x060154D3 RID: 87251 RVA: 0x003152F4 File Offset: 0x003134F4
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006A3D RID: 27197
		// (get) Token: 0x060154D4 RID: 87252 RVA: 0x00315354 File Offset: 0x00313554
		public IVectorInfo? Rot
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

		// Token: 0x17006A3E RID: 27198
		// (get) Token: 0x060154D5 RID: 87253 RVA: 0x003153B4 File Offset: 0x003135B4
		public IVectorInfo? Scale
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

		// Token: 0x060154D6 RID: 87254 RVA: 0x00315411 File Offset: 0x00313611
		public static Offset<IShapeTransform> CreateIShapeTransform(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ScaleOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IShapeTransform.AddScale(builder, ScaleOffset);
			IShapeTransform.AddRot(builder, RotOffset);
			IShapeTransform.AddPos(builder, PosOffset);
			return IShapeTransform.EndIShapeTransform(builder);
		}

		// Token: 0x060154D7 RID: 87255 RVA: 0x00315435 File Offset: 0x00313635
		public static void StartIShapeTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060154D8 RID: 87256 RVA: 0x0031543E File Offset: 0x0031363E
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060154D9 RID: 87257 RVA: 0x0031544E File Offset: 0x0031364E
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x060154DA RID: 87258 RVA: 0x0031545E File Offset: 0x0031365E
		public static void AddScale(FlatBufferBuilder builder, Offset<IVectorInfo> scaleOffset)
		{
			builder.AddOffset(2, scaleOffset.Value, 0);
		}

		// Token: 0x060154DB RID: 87259 RVA: 0x0031546E File Offset: 0x0031366E
		public static Offset<IShapeTransform> EndIShapeTransform(FlatBufferBuilder builder)
		{
			return new Offset<IShapeTransform>(builder.EndTable());
		}

		// Token: 0x060154DC RID: 87260 RVA: 0x0031547C File Offset: 0x0031367C
		public IShapeTransformT UnPack()
		{
			IShapeTransformT shapeTransformT = new IShapeTransformT();
			this.UnPackTo(shapeTransformT);
			return shapeTransformT;
		}

		// Token: 0x060154DD RID: 87261 RVA: 0x00315498 File Offset: 0x00313698
		public void UnPackTo(IShapeTransformT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
		}

		// Token: 0x060154DE RID: 87262 RVA: 0x00315534 File Offset: 0x00313734
		public static Offset<IShapeTransform> Pack(FlatBufferBuilder builder, IShapeTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShapeTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			Offset<IVectorInfo> scaleOffset = (_o.Scale == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Scale);
			return IShapeTransform.CreateIShapeTransform(builder, posOffset, rotOffset, scaleOffset);
		}

		// Token: 0x0400B242 RID: 45634
		private Table __p;
	}
}
