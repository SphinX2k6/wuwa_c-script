using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B95 RID: 19349
	public struct ICameraParam : IFlatbufferObject
	{
		// Token: 0x170088D6 RID: 35030
		// (get) Token: 0x0601D7C8 RID: 120776 RVA: 0x00423D63 File Offset: 0x00421F63
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7C9 RID: 120777 RVA: 0x00423D70 File Offset: 0x00421F70
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7CA RID: 120778 RVA: 0x00423D78 File Offset: 0x00421F78
		public static ICameraParam GetRootAsICameraParam(ByteBuffer _bb)
		{
			return ICameraParam.GetRootAsICameraParam(_bb, default(ICameraParam));
		}

		// Token: 0x0601D7CB RID: 120779 RVA: 0x00423D94 File Offset: 0x00421F94
		public static ICameraParam GetRootAsICameraParam(ByteBuffer _bb, ICameraParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D7CC RID: 120780 RVA: 0x00423DB1 File Offset: 0x00421FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D7CD RID: 120781 RVA: 0x00423DC0 File Offset: 0x00421FC0
		public ICameraParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088D7 RID: 35031
		// (get) Token: 0x0601D7CE RID: 120782 RVA: 0x00423DD0 File Offset: 0x00421FD0
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

		// Token: 0x170088D8 RID: 35032
		// (get) Token: 0x0601D7CF RID: 120783 RVA: 0x00423E0C File Offset: 0x0042200C
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

		// Token: 0x0601D7D0 RID: 120784 RVA: 0x00423E43 File Offset: 0x00422043
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D7D1 RID: 120785 RVA: 0x00423E52 File Offset: 0x00422052
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170088D9 RID: 35033
		// (get) Token: 0x0601D7D2 RID: 120786 RVA: 0x00423E60 File Offset: 0x00422060
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

		// Token: 0x170088DA RID: 35034
		// (get) Token: 0x0601D7D3 RID: 120787 RVA: 0x00423EC0 File Offset: 0x004220C0
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

		// Token: 0x170088DB RID: 35035
		// (get) Token: 0x0601D7D4 RID: 120788 RVA: 0x00423F20 File Offset: 0x00422120
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

		// Token: 0x170088DC RID: 35036
		// (get) Token: 0x0601D7D5 RID: 120789 RVA: 0x00423F60 File Offset: 0x00422160
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

		// Token: 0x170088DD RID: 35037
		// (get) Token: 0x0601D7D6 RID: 120790 RVA: 0x00423FA0 File Offset: 0x004221A0
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

		// Token: 0x170088DE RID: 35038
		// (get) Token: 0x0601D7D7 RID: 120791 RVA: 0x00423FE0 File Offset: 0x004221E0
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

		// Token: 0x170088DF RID: 35039
		// (get) Token: 0x0601D7D8 RID: 120792 RVA: 0x00424020 File Offset: 0x00422220
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

		// Token: 0x0601D7D9 RID: 120793 RVA: 0x00424060 File Offset: 0x00422260
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

		// Token: 0x0601D7DA RID: 120794 RVA: 0x004240C0 File Offset: 0x004222C0
		public static void StartICameraParam(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601D7DB RID: 120795 RVA: 0x004240CA File Offset: 0x004222CA
		public static void AddCameraId(FlatBufferBuilder builder, int cameraId)
		{
			builder.AddInt(0, cameraId, 0);
		}

		// Token: 0x0601D7DC RID: 120796 RVA: 0x004240D5 File Offset: 0x004222D5
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601D7DD RID: 120797 RVA: 0x004240E5 File Offset: 0x004222E5
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0601D7DE RID: 120798 RVA: 0x004240F5 File Offset: 0x004222F5
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(3, rotOffset.Value, 0);
		}

		// Token: 0x0601D7DF RID: 120799 RVA: 0x00424105 File Offset: 0x00422305
		public static void AddFov(FlatBufferBuilder builder, int fov)
		{
			builder.AddInt(4, fov, 0);
		}

		// Token: 0x0601D7E0 RID: 120800 RVA: 0x00424110 File Offset: 0x00422310
		public static void AddAperture(FlatBufferBuilder builder, int aperture)
		{
			builder.AddInt(5, aperture, 0);
		}

		// Token: 0x0601D7E1 RID: 120801 RVA: 0x0042411B File Offset: 0x0042231B
		public static void AddFocalLength(FlatBufferBuilder builder, int focalLength)
		{
			builder.AddInt(6, focalLength, 0);
		}

		// Token: 0x0601D7E2 RID: 120802 RVA: 0x00424126 File Offset: 0x00422326
		public static void AddFocusDistance(FlatBufferBuilder builder, int focusDistance)
		{
			builder.AddInt(7, focusDistance, 0);
		}

		// Token: 0x0601D7E3 RID: 120803 RVA: 0x00424131 File Offset: 0x00422331
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601D7E4 RID: 120804 RVA: 0x0042413C File Offset: 0x0042233C
		public static Offset<ICameraParam> EndICameraParam(FlatBufferBuilder builder)
		{
			return new Offset<ICameraParam>(builder.EndTable());
		}

		// Token: 0x0601D7E5 RID: 120805 RVA: 0x0042414C File Offset: 0x0042234C
		public ICameraParamT UnPack()
		{
			ICameraParamT cameraParamT = new ICameraParamT();
			this.UnPackTo(cameraParamT);
			return cameraParamT;
		}

		// Token: 0x0601D7E6 RID: 120806 RVA: 0x00424168 File Offset: 0x00422368
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

		// Token: 0x0601D7E7 RID: 120807 RVA: 0x00424228 File Offset: 0x00422428
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

		// Token: 0x0400D434 RID: 54324
		private Table __p;
	}
}
