using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E9 RID: 26857
	public struct ICameraDepthOfField : IFlatbufferObject
	{
		// Token: 0x1700C562 RID: 50530
		// (get) Token: 0x0602DF84 RID: 188292 RVA: 0x006487D7 File Offset: 0x006469D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF85 RID: 188293 RVA: 0x006487E4 File Offset: 0x006469E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF86 RID: 188294 RVA: 0x006487EC File Offset: 0x006469EC
		public static ICameraDepthOfField GetRootAsICameraDepthOfField(ByteBuffer _bb)
		{
			return ICameraDepthOfField.GetRootAsICameraDepthOfField(_bb, default(ICameraDepthOfField));
		}

		// Token: 0x0602DF87 RID: 188295 RVA: 0x00648808 File Offset: 0x00646A08
		public static ICameraDepthOfField GetRootAsICameraDepthOfField(ByteBuffer _bb, ICameraDepthOfField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF88 RID: 188296 RVA: 0x00648825 File Offset: 0x00646A25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF89 RID: 188297 RVA: 0x00648834 File Offset: 0x00646A34
		public ICameraDepthOfField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C563 RID: 50531
		// (get) Token: 0x0602DF8A RID: 188298 RVA: 0x00648844 File Offset: 0x00646A44
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

		// Token: 0x1700C564 RID: 50532
		// (get) Token: 0x0602DF8B RID: 188299 RVA: 0x00648884 File Offset: 0x00646A84
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

		// Token: 0x1700C565 RID: 50533
		// (get) Token: 0x0602DF8C RID: 188300 RVA: 0x006488C4 File Offset: 0x00646AC4
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

		// Token: 0x1700C566 RID: 50534
		// (get) Token: 0x0602DF8D RID: 188301 RVA: 0x00648904 File Offset: 0x00646B04
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

		// Token: 0x1700C567 RID: 50535
		// (get) Token: 0x0602DF8E RID: 188302 RVA: 0x00648948 File Offset: 0x00646B48
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

		// Token: 0x0602DF8F RID: 188303 RVA: 0x00648985 File Offset: 0x00646B85
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

		// Token: 0x0602DF90 RID: 188304 RVA: 0x006489B9 File Offset: 0x00646BB9
		public static void StartICameraDepthOfField(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DF91 RID: 188305 RVA: 0x006489C2 File Offset: 0x00646BC2
		public static void AddFstop(FlatBufferBuilder builder, float fstop)
		{
			builder.AddFloat(0, fstop, 0.0);
		}

		// Token: 0x0602DF92 RID: 188306 RVA: 0x006489D5 File Offset: 0x00646BD5
		public static void AddDistance(FlatBufferBuilder builder, float distance)
		{
			builder.AddFloat(1, distance, 0.0);
		}

		// Token: 0x0602DF93 RID: 188307 RVA: 0x006489E8 File Offset: 0x00646BE8
		public static void AddBlurAmount(FlatBufferBuilder builder, float blurAmount)
		{
			builder.AddFloat(2, blurAmount, 0.0);
		}

		// Token: 0x0602DF94 RID: 188308 RVA: 0x006489FB File Offset: 0x00646BFB
		public static void AddBlurRadius(FlatBufferBuilder builder, float blurRadius)
		{
			builder.AddFloat(3, blurRadius, 0.0);
		}

		// Token: 0x0602DF95 RID: 188309 RVA: 0x00648A0E File Offset: 0x00646C0E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DF96 RID: 188310 RVA: 0x00648A19 File Offset: 0x00646C19
		public static Offset<ICameraDepthOfField> EndICameraDepthOfField(FlatBufferBuilder builder)
		{
			return new Offset<ICameraDepthOfField>(builder.EndTable());
		}

		// Token: 0x0602DF97 RID: 188311 RVA: 0x00648A28 File Offset: 0x00646C28
		public ICameraDepthOfFieldT UnPack()
		{
			ICameraDepthOfFieldT cameraDepthOfFieldT = new ICameraDepthOfFieldT();
			this.UnPackTo(cameraDepthOfFieldT);
			return cameraDepthOfFieldT;
		}

		// Token: 0x0602DF98 RID: 188312 RVA: 0x00648A43 File Offset: 0x00646C43
		public void UnPackTo(ICameraDepthOfFieldT _o)
		{
			_o.Fstop = this.Fstop;
			_o.Distance = this.Distance;
			_o.BlurAmount = this.BlurAmount;
			_o.BlurRadius = this.BlurRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DF99 RID: 188313 RVA: 0x00648A84 File Offset: 0x00646C84
		public static Offset<ICameraDepthOfField> Pack(FlatBufferBuilder builder, ICameraDepthOfFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraDepthOfField>);
			}
			return ICameraDepthOfField.CreateICameraDepthOfField(builder, _o.Fstop, _o.Distance, _o.BlurAmount, _o.BlurRadius, _o.NullMask);
		}

		// Token: 0x040115EA RID: 71146
		private Table __p;
	}
}
