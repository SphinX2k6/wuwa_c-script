using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690A RID: 26890
	public struct ICameraParams : IFlatbufferObject
	{
		// Token: 0x1700C5E3 RID: 50659
		// (get) Token: 0x0602E106 RID: 188678 RVA: 0x0064B832 File Offset: 0x00649A32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E107 RID: 188679 RVA: 0x0064B83F File Offset: 0x00649A3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E108 RID: 188680 RVA: 0x0064B848 File Offset: 0x00649A48
		public static ICameraParams GetRootAsICameraParams(ByteBuffer _bb)
		{
			return ICameraParams.GetRootAsICameraParams(_bb, default(ICameraParams));
		}

		// Token: 0x0602E109 RID: 188681 RVA: 0x0064B864 File Offset: 0x00649A64
		public static ICameraParams GetRootAsICameraParams(ByteBuffer _bb, ICameraParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E10A RID: 188682 RVA: 0x0064B881 File Offset: 0x00649A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E10B RID: 188683 RVA: 0x0064B890 File Offset: 0x00649A90
		public ICameraParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5E4 RID: 50660
		// (get) Token: 0x0602E10C RID: 188684 RVA: 0x0064B8A0 File Offset: 0x00649AA0
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

		// Token: 0x1700C5E5 RID: 50661
		// (get) Token: 0x0602E10D RID: 188685 RVA: 0x0064B8E0 File Offset: 0x00649AE0
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

		// Token: 0x1700C5E6 RID: 50662
		// (get) Token: 0x0602E10E RID: 188686 RVA: 0x0064B920 File Offset: 0x00649B20
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

		// Token: 0x1700C5E7 RID: 50663
		// (get) Token: 0x0602E10F RID: 188687 RVA: 0x0064B960 File Offset: 0x00649B60
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

		// Token: 0x1700C5E8 RID: 50664
		// (get) Token: 0x0602E110 RID: 188688 RVA: 0x0064B9A4 File Offset: 0x00649BA4
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

		// Token: 0x1700C5E9 RID: 50665
		// (get) Token: 0x0602E111 RID: 188689 RVA: 0x0064B9E8 File Offset: 0x00649BE8
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

		// Token: 0x1700C5EA RID: 50666
		// (get) Token: 0x0602E112 RID: 188690 RVA: 0x0064BA48 File Offset: 0x00649C48
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

		// Token: 0x1700C5EB RID: 50667
		// (get) Token: 0x0602E113 RID: 188691 RVA: 0x0064BAA8 File Offset: 0x00649CA8
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

		// Token: 0x0602E114 RID: 188692 RVA: 0x0064BAE8 File Offset: 0x00649CE8
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

		// Token: 0x0602E115 RID: 188693 RVA: 0x0064BB3F File Offset: 0x00649D3F
		public static void StartICameraParams(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602E116 RID: 188694 RVA: 0x0064BB48 File Offset: 0x00649D48
		public static void AddAperture(FlatBufferBuilder builder, float aperture)
		{
			builder.AddFloat(0, aperture, 0.0);
		}

		// Token: 0x0602E117 RID: 188695 RVA: 0x0064BB5B File Offset: 0x00649D5B
		public static void AddFocalLength(FlatBufferBuilder builder, float focalLength)
		{
			builder.AddFloat(1, focalLength, 0.0);
		}

		// Token: 0x0602E118 RID: 188696 RVA: 0x0064BB6E File Offset: 0x00649D6E
		public static void AddFocusDistance(FlatBufferBuilder builder, float focusDistance)
		{
			builder.AddFloat(2, focusDistance, 0.0);
		}

		// Token: 0x0602E119 RID: 188697 RVA: 0x0064BB81 File Offset: 0x00649D81
		public static void AddFocalRegion(FlatBufferBuilder builder, float focalRegion)
		{
			builder.AddFloat(3, focalRegion, 0.0);
		}

		// Token: 0x0602E11A RID: 188698 RVA: 0x0064BB94 File Offset: 0x00649D94
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(4, fov, 0.0);
		}

		// Token: 0x0602E11B RID: 188699 RVA: 0x0064BBA7 File Offset: 0x00649DA7
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(5, posOffset.Value, 0);
		}

		// Token: 0x0602E11C RID: 188700 RVA: 0x0064BBB7 File Offset: 0x00649DB7
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(6, rotOffset.Value, 0);
		}

		// Token: 0x0602E11D RID: 188701 RVA: 0x0064BBC7 File Offset: 0x00649DC7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602E11E RID: 188702 RVA: 0x0064BBD2 File Offset: 0x00649DD2
		public static Offset<ICameraParams> EndICameraParams(FlatBufferBuilder builder)
		{
			return new Offset<ICameraParams>(builder.EndTable());
		}

		// Token: 0x0602E11F RID: 188703 RVA: 0x0064BBE0 File Offset: 0x00649DE0
		public ICameraParamsT UnPack()
		{
			ICameraParamsT cameraParamsT = new ICameraParamsT();
			this.UnPackTo(cameraParamsT);
			return cameraParamsT;
		}

		// Token: 0x0602E120 RID: 188704 RVA: 0x0064BBFC File Offset: 0x00649DFC
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

		// Token: 0x0602E121 RID: 188705 RVA: 0x0064BCB0 File Offset: 0x00649EB0
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

		// Token: 0x0401163B RID: 71227
		private Table __p;
	}
}
