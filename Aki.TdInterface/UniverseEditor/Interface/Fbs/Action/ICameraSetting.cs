using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200629F RID: 25247
	public struct ICameraSetting : IFlatbufferObject
	{
		// Token: 0x1700BC71 RID: 48241
		// (get) Token: 0x0602B9E9 RID: 178665 RVA: 0x006013FB File Offset: 0x005FF5FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9EA RID: 178666 RVA: 0x00601408 File Offset: 0x005FF608
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B9EB RID: 178667 RVA: 0x00601410 File Offset: 0x005FF610
		public static ICameraSetting GetRootAsICameraSetting(ByteBuffer _bb)
		{
			return ICameraSetting.GetRootAsICameraSetting(_bb, default(ICameraSetting));
		}

		// Token: 0x0602B9EC RID: 178668 RVA: 0x0060142C File Offset: 0x005FF62C
		public static ICameraSetting GetRootAsICameraSetting(ByteBuffer _bb, ICameraSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B9ED RID: 178669 RVA: 0x00601449 File Offset: 0x005FF649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B9EE RID: 178670 RVA: 0x00601458 File Offset: 0x005FF658
		public ICameraSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC72 RID: 48242
		// (get) Token: 0x0602B9EF RID: 178671 RVA: 0x00601468 File Offset: 0x005FF668
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

		// Token: 0x1700BC73 RID: 48243
		// (get) Token: 0x0602B9F0 RID: 178672 RVA: 0x006014A8 File Offset: 0x005FF6A8
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

		// Token: 0x1700BC74 RID: 48244
		// (get) Token: 0x0602B9F1 RID: 178673 RVA: 0x006014E8 File Offset: 0x005FF6E8
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

		// Token: 0x1700BC75 RID: 48245
		// (get) Token: 0x0602B9F2 RID: 178674 RVA: 0x00601528 File Offset: 0x005FF728
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

		// Token: 0x1700BC76 RID: 48246
		// (get) Token: 0x0602B9F3 RID: 178675 RVA: 0x0060156C File Offset: 0x005FF76C
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

		// Token: 0x1700BC77 RID: 48247
		// (get) Token: 0x0602B9F4 RID: 178676 RVA: 0x006015B0 File Offset: 0x005FF7B0
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

		// Token: 0x0602B9F5 RID: 178677 RVA: 0x006015ED File Offset: 0x005FF7ED
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

		// Token: 0x0602B9F6 RID: 178678 RVA: 0x00601629 File Offset: 0x005FF829
		public static void StartICameraSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602B9F7 RID: 178679 RVA: 0x00601632 File Offset: 0x005FF832
		public static void AddAperture(FlatBufferBuilder builder, float aperture)
		{
			builder.AddFloat(0, aperture, 0.0);
		}

		// Token: 0x0602B9F8 RID: 178680 RVA: 0x00601645 File Offset: 0x005FF845
		public static void AddFocalLength(FlatBufferBuilder builder, float focalLength)
		{
			builder.AddFloat(1, focalLength, 0.0);
		}

		// Token: 0x0602B9F9 RID: 178681 RVA: 0x00601658 File Offset: 0x005FF858
		public static void AddFocusDistance(FlatBufferBuilder builder, float focusDistance)
		{
			builder.AddFloat(2, focusDistance, 0.0);
		}

		// Token: 0x0602B9FA RID: 178682 RVA: 0x0060166B File Offset: 0x005FF86B
		public static void AddFocalRegion(FlatBufferBuilder builder, float focalRegion)
		{
			builder.AddFloat(3, focalRegion, 0.0);
		}

		// Token: 0x0602B9FB RID: 178683 RVA: 0x0060167E File Offset: 0x005FF87E
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(4, fov, 0.0);
		}

		// Token: 0x0602B9FC RID: 178684 RVA: 0x00601691 File Offset: 0x005FF891
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602B9FD RID: 178685 RVA: 0x0060169C File Offset: 0x005FF89C
		public static Offset<ICameraSetting> EndICameraSetting(FlatBufferBuilder builder)
		{
			return new Offset<ICameraSetting>(builder.EndTable());
		}

		// Token: 0x0602B9FE RID: 178686 RVA: 0x006016AC File Offset: 0x005FF8AC
		public ICameraSettingT UnPack()
		{
			ICameraSettingT cameraSettingT = new ICameraSettingT();
			this.UnPackTo(cameraSettingT);
			return cameraSettingT;
		}

		// Token: 0x0602B9FF RID: 178687 RVA: 0x006016C8 File Offset: 0x005FF8C8
		public void UnPackTo(ICameraSettingT _o)
		{
			_o.Aperture = this.Aperture;
			_o.FocalLength = this.FocalLength;
			_o.FocusDistance = this.FocusDistance;
			_o.FocalRegion = this.FocalRegion;
			_o.Fov = this.Fov;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BA00 RID: 178688 RVA: 0x00601720 File Offset: 0x005FF920
		public static Offset<ICameraSetting> Pack(FlatBufferBuilder builder, ICameraSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraSetting>);
			}
			return ICameraSetting.CreateICameraSetting(builder, _o.Aperture, _o.FocalLength, _o.FocusDistance, _o.FocalRegion, _o.Fov, _o.NullMask);
		}

		// Token: 0x04010832 RID: 67634
		private Table __p;
	}
}
