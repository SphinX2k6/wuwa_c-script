using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006278 RID: 25208
	public struct ICameraDepthOfField : IFlatbufferObject
	{
		// Token: 0x1700BBDA RID: 48090
		// (get) Token: 0x0602B823 RID: 178211 RVA: 0x005FD9CF File Offset: 0x005FBBCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B824 RID: 178212 RVA: 0x005FD9DC File Offset: 0x005FBBDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B825 RID: 178213 RVA: 0x005FD9E4 File Offset: 0x005FBBE4
		public static ICameraDepthOfField GetRootAsICameraDepthOfField(ByteBuffer _bb)
		{
			return ICameraDepthOfField.GetRootAsICameraDepthOfField(_bb, default(ICameraDepthOfField));
		}

		// Token: 0x0602B826 RID: 178214 RVA: 0x005FDA00 File Offset: 0x005FBC00
		public static ICameraDepthOfField GetRootAsICameraDepthOfField(ByteBuffer _bb, ICameraDepthOfField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B827 RID: 178215 RVA: 0x005FDA1D File Offset: 0x005FBC1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B828 RID: 178216 RVA: 0x005FDA2C File Offset: 0x005FBC2C
		public ICameraDepthOfField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBDB RID: 48091
		// (get) Token: 0x0602B829 RID: 178217 RVA: 0x005FDA3C File Offset: 0x005FBC3C
		public float Fstop
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

		// Token: 0x1700BBDC RID: 48092
		// (get) Token: 0x0602B82A RID: 178218 RVA: 0x005FDA7C File Offset: 0x005FBC7C
		public float Distance
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

		// Token: 0x1700BBDD RID: 48093
		// (get) Token: 0x0602B82B RID: 178219 RVA: 0x005FDABC File Offset: 0x005FBCBC
		public float BlurAmount
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

		// Token: 0x1700BBDE RID: 48094
		// (get) Token: 0x0602B82C RID: 178220 RVA: 0x005FDAFC File Offset: 0x005FBCFC
		public float BlurRadius
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

		// Token: 0x1700BBDF RID: 48095
		// (get) Token: 0x0602B82D RID: 178221 RVA: 0x005FDB40 File Offset: 0x005FBD40
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B82E RID: 178222 RVA: 0x005FDB7D File Offset: 0x005FBD7D
		public static Offset<ICameraDepthOfField> CreateICameraDepthOfField(FlatBufferBuilder builder, float Fstop = 0f, float Distance = 0f, float BlurAmount = 0f, float BlurRadius = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICameraDepthOfField.AddBlurRadius(builder, BlurRadius);
			ICameraDepthOfField.AddBlurAmount(builder, BlurAmount);
			ICameraDepthOfField.AddDistance(builder, Distance);
			ICameraDepthOfField.AddFstop(builder, Fstop);
			ICameraDepthOfField.AddNullMask(builder, NullMask);
			return ICameraDepthOfField.EndICameraDepthOfField(builder);
		}

		// Token: 0x0602B82F RID: 178223 RVA: 0x005FDBB1 File Offset: 0x005FBDB1
		public static void StartICameraDepthOfField(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B830 RID: 178224 RVA: 0x005FDBBA File Offset: 0x005FBDBA
		public static void AddFstop(FlatBufferBuilder builder, float fstop)
		{
			builder.AddFloat(0, fstop, 0.0);
		}

		// Token: 0x0602B831 RID: 178225 RVA: 0x005FDBCD File Offset: 0x005FBDCD
		public static void AddDistance(FlatBufferBuilder builder, float distance)
		{
			builder.AddFloat(1, distance, 0.0);
		}

		// Token: 0x0602B832 RID: 178226 RVA: 0x005FDBE0 File Offset: 0x005FBDE0
		public static void AddBlurAmount(FlatBufferBuilder builder, float blurAmount)
		{
			builder.AddFloat(2, blurAmount, 0.0);
		}

		// Token: 0x0602B833 RID: 178227 RVA: 0x005FDBF3 File Offset: 0x005FBDF3
		public static void AddBlurRadius(FlatBufferBuilder builder, float blurRadius)
		{
			builder.AddFloat(3, blurRadius, 0.0);
		}

		// Token: 0x0602B834 RID: 178228 RVA: 0x005FDC06 File Offset: 0x005FBE06
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602B835 RID: 178229 RVA: 0x005FDC11 File Offset: 0x005FBE11
		public static Offset<ICameraDepthOfField> EndICameraDepthOfField(FlatBufferBuilder builder)
		{
			return new Offset<ICameraDepthOfField>(builder.EndTable());
		}

		// Token: 0x0602B836 RID: 178230 RVA: 0x005FDC20 File Offset: 0x005FBE20
		public ICameraDepthOfFieldT UnPack()
		{
			ICameraDepthOfFieldT cameraDepthOfFieldT = new ICameraDepthOfFieldT();
			this.UnPackTo(cameraDepthOfFieldT);
			return cameraDepthOfFieldT;
		}

		// Token: 0x0602B837 RID: 178231 RVA: 0x005FDC3B File Offset: 0x005FBE3B
		public void UnPackTo(ICameraDepthOfFieldT _o)
		{
			_o.Fstop = this.Fstop;
			_o.Distance = this.Distance;
			_o.BlurAmount = this.BlurAmount;
			_o.BlurRadius = this.BlurRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B838 RID: 178232 RVA: 0x005FDC7C File Offset: 0x005FBE7C
		public static Offset<ICameraDepthOfField> Pack(FlatBufferBuilder builder, ICameraDepthOfFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraDepthOfField>);
			}
			return ICameraDepthOfField.CreateICameraDepthOfField(builder, _o.Fstop, _o.Distance, _o.BlurAmount, _o.BlurRadius, _o.NullMask);
		}

		// Token: 0x040107D5 RID: 67541
		private Table __p;
	}
}
