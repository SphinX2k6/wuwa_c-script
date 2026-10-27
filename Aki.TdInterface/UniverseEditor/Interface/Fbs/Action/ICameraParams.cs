using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006299 RID: 25241
	public struct ICameraParams : IFlatbufferObject
	{
		// Token: 0x1700BC5B RID: 48219
		// (get) Token: 0x0602B9A5 RID: 178597 RVA: 0x00600A2A File Offset: 0x005FEC2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9A6 RID: 178598 RVA: 0x00600A37 File Offset: 0x005FEC37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B9A7 RID: 178599 RVA: 0x00600A40 File Offset: 0x005FEC40
		public static ICameraParams GetRootAsICameraParams(ByteBuffer _bb)
		{
			return ICameraParams.GetRootAsICameraParams(_bb, default(ICameraParams));
		}

		// Token: 0x0602B9A8 RID: 178600 RVA: 0x00600A5C File Offset: 0x005FEC5C
		public static ICameraParams GetRootAsICameraParams(ByteBuffer _bb, ICameraParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B9A9 RID: 178601 RVA: 0x00600A79 File Offset: 0x005FEC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B9AA RID: 178602 RVA: 0x00600A88 File Offset: 0x005FEC88
		public ICameraParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC5C RID: 48220
		// (get) Token: 0x0602B9AB RID: 178603 RVA: 0x00600A98 File Offset: 0x005FEC98
		public float Aperture
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC5D RID: 48221
		// (get) Token: 0x0602B9AC RID: 178604 RVA: 0x00600AD8 File Offset: 0x005FECD8
		public float FocalLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC5E RID: 48222
		// (get) Token: 0x0602B9AD RID: 178605 RVA: 0x00600B18 File Offset: 0x005FED18
		public float FocusDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC5F RID: 48223
		// (get) Token: 0x0602B9AE RID: 178606 RVA: 0x00600B58 File Offset: 0x005FED58
		public float FocalRegion
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC60 RID: 48224
		// (get) Token: 0x0602B9AF RID: 178607 RVA: 0x00600B9C File Offset: 0x005FED9C
		public float Fov
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC61 RID: 48225
		// (get) Token: 0x0602B9B0 RID: 178608 RVA: 0x00600BE0 File Offset: 0x005FEDE0
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BC62 RID: 48226
		// (get) Token: 0x0602B9B1 RID: 178609 RVA: 0x00600C40 File Offset: 0x005FEE40
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BC63 RID: 48227
		// (get) Token: 0x0602B9B2 RID: 178610 RVA: 0x00600CA0 File Offset: 0x005FEEA0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B9B3 RID: 178611 RVA: 0x00600CE0 File Offset: 0x005FEEE0
		public static Offset<ICameraParams> CreateICameraParams(FlatBufferBuilder builder, float Aperture = 0f, float FocalLength = 0f, float FocusDistance = 0f, float FocalRegion = 0f, float Fov = 0f, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(8);
			ICameraParams.AddRot(builder, RotOffset);
			ICameraParams.AddPos(builder, PosOffset);
			ICameraParams.AddFov(builder, Fov);
			ICameraParams.AddFocalRegion(builder, FocalRegion);
			ICameraParams.AddFocusDistance(builder, FocusDistance);
			ICameraParams.AddFocalLength(builder, FocalLength);
			ICameraParams.AddAperture(builder, Aperture);
			ICameraParams.AddNullMask(builder, NullMask);
			return ICameraParams.EndICameraParams(builder);
		}

		// Token: 0x0602B9B4 RID: 178612 RVA: 0x00600D37 File Offset: 0x005FEF37
		public static void StartICameraParams(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602B9B5 RID: 178613 RVA: 0x00600D40 File Offset: 0x005FEF40
		public static void AddAperture(FlatBufferBuilder builder, float aperture)
		{
			builder.AddFloat(0, aperture, 0.0);
		}

		// Token: 0x0602B9B6 RID: 178614 RVA: 0x00600D53 File Offset: 0x005FEF53
		public static void AddFocalLength(FlatBufferBuilder builder, float focalLength)
		{
			builder.AddFloat(1, focalLength, 0.0);
		}

		// Token: 0x0602B9B7 RID: 178615 RVA: 0x00600D66 File Offset: 0x005FEF66
		public static void AddFocusDistance(FlatBufferBuilder builder, float focusDistance)
		{
			builder.AddFloat(2, focusDistance, 0.0);
		}

		// Token: 0x0602B9B8 RID: 178616 RVA: 0x00600D79 File Offset: 0x005FEF79
		public static void AddFocalRegion(FlatBufferBuilder builder, float focalRegion)
		{
			builder.AddFloat(3, focalRegion, 0.0);
		}

		// Token: 0x0602B9B9 RID: 178617 RVA: 0x00600D8C File Offset: 0x005FEF8C
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(4, fov, 0.0);
		}

		// Token: 0x0602B9BA RID: 178618 RVA: 0x00600D9F File Offset: 0x005FEF9F
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(5, posOffset.Value, 0);
		}

		// Token: 0x0602B9BB RID: 178619 RVA: 0x00600DAF File Offset: 0x005FEFAF
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(6, rotOffset.Value, 0);
		}

		// Token: 0x0602B9BC RID: 178620 RVA: 0x00600DBF File Offset: 0x005FEFBF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602B9BD RID: 178621 RVA: 0x00600DCA File Offset: 0x005FEFCA
		public static Offset<ICameraParams> EndICameraParams(FlatBufferBuilder builder)
		{
			return new Offset<ICameraParams>(builder.EndTable());
		}

		// Token: 0x0602B9BE RID: 178622 RVA: 0x00600DD8 File Offset: 0x005FEFD8
		public ICameraParamsT UnPack()
		{
			ICameraParamsT cameraParamsT = new ICameraParamsT();
			this.UnPackTo(cameraParamsT);
			return cameraParamsT;
		}

		// Token: 0x0602B9BF RID: 178623 RVA: 0x00600DF4 File Offset: 0x005FEFF4
		public void UnPackTo(ICameraParamsT _o)
		{
			_o.Aperture = this.Aperture;
			_o.FocalLength = this.FocalLength;
			_o.FocusDistance = this.FocusDistance;
			_o.FocalRegion = this.FocalRegion;
			_o.Fov = this.Fov;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B9C0 RID: 178624 RVA: 0x00600EA8 File Offset: 0x005FF0A8
		public static Offset<ICameraParams> Pack(FlatBufferBuilder builder, ICameraParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraParams>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return ICameraParams.CreateICameraParams(builder, _o.Aperture, _o.FocalLength, _o.FocusDistance, _o.FocalRegion, _o.Fov, posOffset, rotOffset, _o.NullMask);
		}

		// Token: 0x04010826 RID: 67622
		private Table __p;
	}
}
