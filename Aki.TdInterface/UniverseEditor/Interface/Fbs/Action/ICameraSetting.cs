using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006910 RID: 26896
	public struct ICameraSetting : IFlatbufferObject
	{
		// Token: 0x1700C5F9 RID: 50681
		// (get) Token: 0x0602E14A RID: 188746 RVA: 0x0064C203 File Offset: 0x0064A403
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E14B RID: 188747 RVA: 0x0064C210 File Offset: 0x0064A410
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E14C RID: 188748 RVA: 0x0064C218 File Offset: 0x0064A418
		public static ICameraSetting GetRootAsICameraSetting(ByteBuffer _bb)
		{
			return ICameraSetting.GetRootAsICameraSetting(_bb, default(ICameraSetting));
		}

		// Token: 0x0602E14D RID: 188749 RVA: 0x0064C234 File Offset: 0x0064A434
		public static ICameraSetting GetRootAsICameraSetting(ByteBuffer _bb, ICameraSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E14E RID: 188750 RVA: 0x0064C251 File Offset: 0x0064A451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E14F RID: 188751 RVA: 0x0064C260 File Offset: 0x0064A460
		public ICameraSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5FA RID: 50682
		// (get) Token: 0x0602E150 RID: 188752 RVA: 0x0064C270 File Offset: 0x0064A470
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

		// Token: 0x1700C5FB RID: 50683
		// (get) Token: 0x0602E151 RID: 188753 RVA: 0x0064C2B0 File Offset: 0x0064A4B0
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

		// Token: 0x1700C5FC RID: 50684
		// (get) Token: 0x0602E152 RID: 188754 RVA: 0x0064C2F0 File Offset: 0x0064A4F0
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

		// Token: 0x1700C5FD RID: 50685
		// (get) Token: 0x0602E153 RID: 188755 RVA: 0x0064C330 File Offset: 0x0064A530
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

		// Token: 0x1700C5FE RID: 50686
		// (get) Token: 0x0602E154 RID: 188756 RVA: 0x0064C374 File Offset: 0x0064A574
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

		// Token: 0x1700C5FF RID: 50687
		// (get) Token: 0x0602E155 RID: 188757 RVA: 0x0064C3B8 File Offset: 0x0064A5B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E156 RID: 188758 RVA: 0x0064C3F5 File Offset: 0x0064A5F5
		public static Offset<ICameraSetting> CreateICameraSetting(FlatBufferBuilder builder, float Aperture = 0f, float FocalLength = 0f, float FocusDistance = 0f, float FocalRegion = 0f, float Fov = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICameraSetting.AddFov(builder, Fov);
			ICameraSetting.AddFocalRegion(builder, FocalRegion);
			ICameraSetting.AddFocusDistance(builder, FocusDistance);
			ICameraSetting.AddFocalLength(builder, FocalLength);
			ICameraSetting.AddAperture(builder, Aperture);
			ICameraSetting.AddNullMask(builder, NullMask);
			return ICameraSetting.EndICameraSetting(builder);
		}

		// Token: 0x0602E157 RID: 188759 RVA: 0x0064C431 File Offset: 0x0064A631
		public static void StartICameraSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E158 RID: 188760 RVA: 0x0064C43A File Offset: 0x0064A63A
		public static void AddAperture(FlatBufferBuilder builder, float aperture)
		{
			builder.AddFloat(0, aperture, 0.0);
		}

		// Token: 0x0602E159 RID: 188761 RVA: 0x0064C44D File Offset: 0x0064A64D
		public static void AddFocalLength(FlatBufferBuilder builder, float focalLength)
		{
			builder.AddFloat(1, focalLength, 0.0);
		}

		// Token: 0x0602E15A RID: 188762 RVA: 0x0064C460 File Offset: 0x0064A660
		public static void AddFocusDistance(FlatBufferBuilder builder, float focusDistance)
		{
			builder.AddFloat(2, focusDistance, 0.0);
		}

		// Token: 0x0602E15B RID: 188763 RVA: 0x0064C473 File Offset: 0x0064A673
		public static void AddFocalRegion(FlatBufferBuilder builder, float focalRegion)
		{
			builder.AddFloat(3, focalRegion, 0.0);
		}

		// Token: 0x0602E15C RID: 188764 RVA: 0x0064C486 File Offset: 0x0064A686
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(4, fov, 0.0);
		}

		// Token: 0x0602E15D RID: 188765 RVA: 0x0064C499 File Offset: 0x0064A699
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602E15E RID: 188766 RVA: 0x0064C4A4 File Offset: 0x0064A6A4
		public static Offset<ICameraSetting> EndICameraSetting(FlatBufferBuilder builder)
		{
			return new Offset<ICameraSetting>(builder.EndTable());
		}

		// Token: 0x0602E15F RID: 188767 RVA: 0x0064C4B4 File Offset: 0x0064A6B4
		public ICameraSettingT UnPack()
		{
			ICameraSettingT cameraSettingT = new ICameraSettingT();
			this.UnPackTo(cameraSettingT);
			return cameraSettingT;
		}

		// Token: 0x0602E160 RID: 188768 RVA: 0x0064C4D0 File Offset: 0x0064A6D0
		public void UnPackTo(ICameraSettingT _o)
		{
			_o.Aperture = this.Aperture;
			_o.FocalLength = this.FocalLength;
			_o.FocusDistance = this.FocusDistance;
			_o.FocalRegion = this.FocalRegion;
			_o.Fov = this.Fov;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E161 RID: 188769 RVA: 0x0064C528 File Offset: 0x0064A728
		public static Offset<ICameraSetting> Pack(FlatBufferBuilder builder, ICameraSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraSetting>);
			}
			return ICameraSetting.CreateICameraSetting(builder, _o.Aperture, _o.FocalLength, _o.FocusDistance, _o.FocalRegion, _o.Fov, _o.NullMask);
		}

		// Token: 0x04011647 RID: 71239
		private Table __p;
	}
}
