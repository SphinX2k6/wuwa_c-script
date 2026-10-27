using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693C RID: 26940
	public struct IICenterTextFadeOut : IFlatbufferObject
	{
		// Token: 0x1700C7E0 RID: 51168
		// (get) Token: 0x0602F0A0 RID: 192672 RVA: 0x0066993E File Offset: 0x00667B3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0A1 RID: 192673 RVA: 0x0066994B File Offset: 0x00667B4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0A2 RID: 192674 RVA: 0x00669954 File Offset: 0x00667B54
		public static IICenterTextFadeOut GetRootAsIICenterTextFadeOut(ByteBuffer _bb)
		{
			return IICenterTextFadeOut.GetRootAsIICenterTextFadeOut(_bb, default(IICenterTextFadeOut));
		}

		// Token: 0x0602F0A3 RID: 192675 RVA: 0x00669970 File Offset: 0x00667B70
		public static IICenterTextFadeOut GetRootAsIICenterTextFadeOut(ByteBuffer _bb, IICenterTextFadeOut obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0A4 RID: 192676 RVA: 0x0066998D File Offset: 0x00667B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0A5 RID: 192677 RVA: 0x0066999C File Offset: 0x00667B9C
		public IICenterTextFadeOut __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7E1 RID: 51169
		// (get) Token: 0x0602F0A6 RID: 192678 RVA: 0x006699AC File Offset: 0x00667BAC
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

		// Token: 0x1700C7E2 RID: 51170
		// (get) Token: 0x0602F0A7 RID: 192679 RVA: 0x006699E8 File Offset: 0x00667BE8
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

		// Token: 0x1700C7E3 RID: 51171
		// (get) Token: 0x0602F0A8 RID: 192680 RVA: 0x00669A28 File Offset: 0x00667C28
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

		// Token: 0x0602F0A9 RID: 192681 RVA: 0x00669A68 File Offset: 0x00667C68
		public static Offset<IICenterTextFadeOut> CreateIICenterTextFadeOut(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll, float FadeInTime = 0f, float FadeOutTime = 0f)
		{
			builder.StartTable(3);
			IICenterTextFadeOut.AddFadeOutTime(builder, FadeOutTime);
			IICenterTextFadeOut.AddFadeInTime(builder, FadeInTime);
			IICenterTextFadeOut.AddType(builder, Type);
			return IICenterTextFadeOut.EndIICenterTextFadeOut(builder);
		}

		// Token: 0x0602F0AA RID: 192682 RVA: 0x00669A8C File Offset: 0x00667C8C
		public static void StartIICenterTextFadeOut(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F0AB RID: 192683 RVA: 0x00669A95 File Offset: 0x00667C95
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F0AC RID: 192684 RVA: 0x00669AA0 File Offset: 0x00667CA0
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(1, fadeInTime, 0.0);
		}

		// Token: 0x0602F0AD RID: 192685 RVA: 0x00669AB3 File Offset: 0x00667CB3
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602F0AE RID: 192686 RVA: 0x00669AC6 File Offset: 0x00667CC6
		public static Offset<IICenterTextFadeOut> EndIICenterTextFadeOut(FlatBufferBuilder builder)
		{
			return new Offset<IICenterTextFadeOut>(builder.EndTable());
		}

		// Token: 0x0602F0AF RID: 192687 RVA: 0x00669AD4 File Offset: 0x00667CD4
		public IICenterTextFadeOutT UnPack()
		{
			IICenterTextFadeOutT iicenterTextFadeOutT = new IICenterTextFadeOutT();
			this.UnPackTo(iicenterTextFadeOutT);
			return iicenterTextFadeOutT;
		}

		// Token: 0x0602F0B0 RID: 192688 RVA: 0x00669AEF File Offset: 0x00667CEF
		public void UnPackTo(IICenterTextFadeOutT _o)
		{
			_o.Type = this.Type;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
		}

		// Token: 0x0602F0B1 RID: 192689 RVA: 0x00669B18 File Offset: 0x00667D18
		public static Offset<IICenterTextFadeOut> Pack(FlatBufferBuilder builder, IICenterTextFadeOutT _o)
		{
			if (_o == null)
			{
				return default(Offset<IICenterTextFadeOut>);
			}
			return IICenterTextFadeOut.CreateIICenterTextFadeOut(builder, _o.Type, _o.FadeInTime, _o.FadeOutTime);
		}

		// Token: 0x040110BA RID: 69818
		private Table __p;
	}
}
