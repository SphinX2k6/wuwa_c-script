using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200472D RID: 18221
	public struct ICameraParam : IFlatbufferObject
	{
		// Token: 0x17008295 RID: 33429
		// (get) Token: 0x0601BFF3 RID: 114675 RVA: 0x003F7AC7 File Offset: 0x003F5CC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BFF4 RID: 114676 RVA: 0x003F7AD4 File Offset: 0x003F5CD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BFF5 RID: 114677 RVA: 0x003F7ADC File Offset: 0x003F5CDC
		public static ICameraParam GetRootAsICameraParam(ByteBuffer _bb)
		{
			return ICameraParam.GetRootAsICameraParam(_bb, default(ICameraParam));
		}

		// Token: 0x0601BFF6 RID: 114678 RVA: 0x003F7AF8 File Offset: 0x003F5CF8
		public static ICameraParam GetRootAsICameraParam(ByteBuffer _bb, ICameraParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BFF7 RID: 114679 RVA: 0x003F7B15 File Offset: 0x003F5D15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BFF8 RID: 114680 RVA: 0x003F7B24 File Offset: 0x003F5D24
		public ICameraParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008296 RID: 33430
		// (get) Token: 0x0601BFF9 RID: 114681 RVA: 0x003F7B34 File Offset: 0x003F5D34
		public int CameraId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008297 RID: 33431
		// (get) Token: 0x0601BFFA RID: 114682 RVA: 0x003F7B70 File Offset: 0x003F5D70
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BFFB RID: 114683 RVA: 0x003F7BA7 File Offset: 0x003F5DA7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BFFC RID: 114684 RVA: 0x003F7BB6 File Offset: 0x003F5DB6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008298 RID: 33432
		// (get) Token: 0x0601BFFD RID: 114685 RVA: 0x003F7BC4 File Offset: 0x003F5DC4
		public IVectorInfo? Pos
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

		// Token: 0x17008299 RID: 33433
		// (get) Token: 0x0601BFFE RID: 114686 RVA: 0x003F7C24 File Offset: 0x003F5E24
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700829A RID: 33434
		// (get) Token: 0x0601BFFF RID: 114687 RVA: 0x003F7C84 File Offset: 0x003F5E84
		public int Fov
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700829B RID: 33435
		// (get) Token: 0x0601C000 RID: 114688 RVA: 0x003F7CC4 File Offset: 0x003F5EC4
		public int Aperture
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700829C RID: 33436
		// (get) Token: 0x0601C001 RID: 114689 RVA: 0x003F7D04 File Offset: 0x003F5F04
		public int FocalLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700829D RID: 33437
		// (get) Token: 0x0601C002 RID: 114690 RVA: 0x003F7D44 File Offset: 0x003F5F44
		public int FocusDistance
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700829E RID: 33438
		// (get) Token: 0x0601C003 RID: 114691 RVA: 0x003F7D84 File Offset: 0x003F5F84
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C004 RID: 114692 RVA: 0x003F7DC4 File Offset: 0x003F5FC4
		public static Offset<ICameraParam> CreateICameraParam(FlatBufferBuilder builder, int CameraId = 0, StringOffset NameOffset = default(StringOffset), Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), int Fov = 0, int Aperture = 0, int FocalLength = 0, int FocusDistance = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ICameraParam.AddFocusDistance(builder, FocusDistance);
			ICameraParam.AddFocalLength(builder, FocalLength);
			ICameraParam.AddAperture(builder, Aperture);
			ICameraParam.AddFov(builder, Fov);
			ICameraParam.AddRot(builder, RotOffset);
			ICameraParam.AddPos(builder, PosOffset);
			ICameraParam.AddName(builder, NameOffset);
			ICameraParam.AddCameraId(builder, CameraId);
			ICameraParam.AddNullMask(builder, NullMask);
			return ICameraParam.EndICameraParam(builder);
		}

		// Token: 0x0601C005 RID: 114693 RVA: 0x003F7E24 File Offset: 0x003F6024
		public static void StartICameraParam(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601C006 RID: 114694 RVA: 0x003F7E2E File Offset: 0x003F602E
		public static void AddCameraId(FlatBufferBuilder builder, int cameraId)
		{
			builder.AddInt(0, cameraId, 0);
		}

		// Token: 0x0601C007 RID: 114695 RVA: 0x003F7E39 File Offset: 0x003F6039
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601C008 RID: 114696 RVA: 0x003F7E49 File Offset: 0x003F6049
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0601C009 RID: 114697 RVA: 0x003F7E59 File Offset: 0x003F6059
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(3, rotOffset.Value, 0);
		}

		// Token: 0x0601C00A RID: 114698 RVA: 0x003F7E69 File Offset: 0x003F6069
		public static void AddFov(FlatBufferBuilder builder, int fov)
		{
			builder.AddInt(4, fov, 0);
		}

		// Token: 0x0601C00B RID: 114699 RVA: 0x003F7E74 File Offset: 0x003F6074
		public static void AddAperture(FlatBufferBuilder builder, int aperture)
		{
			builder.AddInt(5, aperture, 0);
		}

		// Token: 0x0601C00C RID: 114700 RVA: 0x003F7E7F File Offset: 0x003F607F
		public static void AddFocalLength(FlatBufferBuilder builder, int focalLength)
		{
			builder.AddInt(6, focalLength, 0);
		}

		// Token: 0x0601C00D RID: 114701 RVA: 0x003F7E8A File Offset: 0x003F608A
		public static void AddFocusDistance(FlatBufferBuilder builder, int focusDistance)
		{
			builder.AddInt(7, focusDistance, 0);
		}

		// Token: 0x0601C00E RID: 114702 RVA: 0x003F7E95 File Offset: 0x003F6095
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601C00F RID: 114703 RVA: 0x003F7EA0 File Offset: 0x003F60A0
		public static Offset<ICameraParam> EndICameraParam(FlatBufferBuilder builder)
		{
			return new Offset<ICameraParam>(builder.EndTable());
		}

		// Token: 0x0601C010 RID: 114704 RVA: 0x003F7EB0 File Offset: 0x003F60B0
		public ICameraParamT UnPack()
		{
			ICameraParamT cameraParamT = new ICameraParamT();
			this.UnPackTo(cameraParamT);
			return cameraParamT;
		}

		// Token: 0x0601C011 RID: 114705 RVA: 0x003F7ECC File Offset: 0x003F60CC
		public void UnPackTo(ICameraParamT _o)
		{
			_o.CameraId = this.CameraId;
			_o.Name = this.Name;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Fov = this.Fov;
			_o.Aperture = this.Aperture;
			_o.FocalLength = this.FocalLength;
			_o.FocusDistance = this.FocusDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C012 RID: 114706 RVA: 0x003F7F8C File Offset: 0x003F618C
		public static Offset<ICameraParam> Pack(FlatBufferBuilder builder, ICameraParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraParam>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return ICameraParam.CreateICameraParam(builder, _o.CameraId, nameOffset, posOffset, rotOffset, _o.Fov, _o.Aperture, _o.FocalLength, _o.FocusDistance, _o.NullMask);
		}

		// Token: 0x0400CA05 RID: 51717
		private Table __p;
	}
}
