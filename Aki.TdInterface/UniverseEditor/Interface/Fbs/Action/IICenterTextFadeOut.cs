using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEF RID: 28655
	public struct IICenterTextFadeOut : IFlatbufferObject
	{
		// Token: 0x1700D1E3 RID: 53731
		// (get) Token: 0x06031A70 RID: 203376 RVA: 0x006B9E26 File Offset: 0x006B8026
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A71 RID: 203377 RVA: 0x006B9E33 File Offset: 0x006B8033
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A72 RID: 203378 RVA: 0x006B9E3C File Offset: 0x006B803C
		public static IICenterTextFadeOut GetRootAsIICenterTextFadeOut(ByteBuffer _bb)
		{
			return IICenterTextFadeOut.GetRootAsIICenterTextFadeOut(_bb, default(IICenterTextFadeOut));
		}

		// Token: 0x06031A73 RID: 203379 RVA: 0x006B9E58 File Offset: 0x006B8058
		public static IICenterTextFadeOut GetRootAsIICenterTextFadeOut(ByteBuffer _bb, IICenterTextFadeOut obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A74 RID: 203380 RVA: 0x006B9E75 File Offset: 0x006B8075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A75 RID: 203381 RVA: 0x006B9E84 File Offset: 0x006B8084
		public IICenterTextFadeOut __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1E4 RID: 53732
		// (get) Token: 0x06031A76 RID: 203382 RVA: 0x006B9E94 File Offset: 0x006B8094
		public ECenterTextShowAnim Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return (ECenterTextShowAnim)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1E5 RID: 53733
		// (get) Token: 0x06031A77 RID: 203383 RVA: 0x006B9ED0 File Offset: 0x006B80D0
		public float FadeInTime
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

		// Token: 0x1700D1E6 RID: 53734
		// (get) Token: 0x06031A78 RID: 203384 RVA: 0x006B9F10 File Offset: 0x006B8110
		public float FadeOutTime
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

		// Token: 0x06031A79 RID: 203385 RVA: 0x006B9F50 File Offset: 0x006B8150
		public static Offset<IICenterTextFadeOut> CreateIICenterTextFadeOut(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll, float FadeInTime = 0f, float FadeOutTime = 0f)
		{
			builder.StartTable(3);
			IICenterTextFadeOut.AddFadeOutTime(builder, FadeOutTime);
			IICenterTextFadeOut.AddFadeInTime(builder, FadeInTime);
			IICenterTextFadeOut.AddType(builder, Type);
			return IICenterTextFadeOut.EndIICenterTextFadeOut(builder);
		}

		// Token: 0x06031A7A RID: 203386 RVA: 0x006B9F74 File Offset: 0x006B8174
		public static void StartIICenterTextFadeOut(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031A7B RID: 203387 RVA: 0x006B9F7D File Offset: 0x006B817D
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A7C RID: 203388 RVA: 0x006B9F88 File Offset: 0x006B8188
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(1, fadeInTime, 0.0);
		}

		// Token: 0x06031A7D RID: 203389 RVA: 0x006B9F9B File Offset: 0x006B819B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x06031A7E RID: 203390 RVA: 0x006B9FAE File Offset: 0x006B81AE
		public static Offset<IICenterTextFadeOut> EndIICenterTextFadeOut(FlatBufferBuilder builder)
		{
			return new Offset<IICenterTextFadeOut>(builder.EndTable());
		}

		// Token: 0x06031A7F RID: 203391 RVA: 0x006B9FBC File Offset: 0x006B81BC
		public IICenterTextFadeOutT UnPack()
		{
			IICenterTextFadeOutT iicenterTextFadeOutT = new IICenterTextFadeOutT();
			this.UnPackTo(iicenterTextFadeOutT);
			return iicenterTextFadeOutT;
		}

		// Token: 0x06031A80 RID: 203392 RVA: 0x006B9FD7 File Offset: 0x006B81D7
		public void UnPackTo(IICenterTextFadeOutT _o)
		{
			_o.Type = this.Type;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
		}

		// Token: 0x06031A81 RID: 203393 RVA: 0x006BA000 File Offset: 0x006B8200
		public static Offset<IICenterTextFadeOut> Pack(FlatBufferBuilder builder, IICenterTextFadeOutT _o)
		{
			if (_o == null)
			{
				return default(Offset<IICenterTextFadeOut>);
			}
			return IICenterTextFadeOut.CreateIICenterTextFadeOut(builder, _o.Type, _o.FadeInTime, _o.FadeOutTime);
		}

		// Token: 0x04011F26 RID: 73510
		private Table __p;
	}
}
