using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED4 RID: 20180
	public struct IAudioFade : IFlatbufferObject
	{
		// Token: 0x170090D8 RID: 37080
		// (get) Token: 0x0601FCD7 RID: 130263 RVA: 0x0046D1B4 File Offset: 0x0046B3B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCD8 RID: 130264 RVA: 0x0046D1C1 File Offset: 0x0046B3C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCD9 RID: 130265 RVA: 0x0046D1C8 File Offset: 0x0046B3C8
		public static IAudioFade GetRootAsIAudioFade(ByteBuffer _bb)
		{
			return IAudioFade.GetRootAsIAudioFade(_bb, default(IAudioFade));
		}

		// Token: 0x0601FCDA RID: 130266 RVA: 0x0046D1E4 File Offset: 0x0046B3E4
		public static IAudioFade GetRootAsIAudioFade(ByteBuffer _bb, IAudioFade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCDB RID: 130267 RVA: 0x0046D201 File Offset: 0x0046B401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCDC RID: 130268 RVA: 0x0046D210 File Offset: 0x0046B410
		public IAudioFade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090D9 RID: 37081
		// (get) Token: 0x0601FCDD RID: 130269 RVA: 0x0046D220 File Offset: 0x0046B420
		public EAudioFadeCurveType FadeCurve
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioFadeCurveType.Log3;
				}
				return (EAudioFadeCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090DA RID: 37082
		// (get) Token: 0x0601FCDE RID: 130270 RVA: 0x0046D25C File Offset: 0x0046B45C
		public int FadeDuration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FCDF RID: 130271 RVA: 0x0046D298 File Offset: 0x0046B498
		public static Offset<IAudioFade> CreateIAudioFade(FlatBufferBuilder builder, EAudioFadeCurveType FadeCurve = EAudioFadeCurveType.Log3, int FadeDuration = 0)
		{
			builder.StartTable(2);
			IAudioFade.AddFadeDuration(builder, FadeDuration);
			IAudioFade.AddFadeCurve(builder, FadeCurve);
			return IAudioFade.EndIAudioFade(builder);
		}

		// Token: 0x0601FCE0 RID: 130272 RVA: 0x0046D2B5 File Offset: 0x0046B4B5
		public static void StartIAudioFade(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FCE1 RID: 130273 RVA: 0x0046D2BE File Offset: 0x0046B4BE
		public static void AddFadeCurve(FlatBufferBuilder builder, EAudioFadeCurveType fadeCurve)
		{
			builder.AddByte(0, (byte)fadeCurve, 0);
		}

		// Token: 0x0601FCE2 RID: 130274 RVA: 0x0046D2C9 File Offset: 0x0046B4C9
		public static void AddFadeDuration(FlatBufferBuilder builder, int fadeDuration)
		{
			builder.AddInt(1, fadeDuration, 0);
		}

		// Token: 0x0601FCE3 RID: 130275 RVA: 0x0046D2D4 File Offset: 0x0046B4D4
		public static Offset<IAudioFade> EndIAudioFade(FlatBufferBuilder builder)
		{
			return new Offset<IAudioFade>(builder.EndTable());
		}

		// Token: 0x0601FCE4 RID: 130276 RVA: 0x0046D2E4 File Offset: 0x0046B4E4
		public IAudioFadeT UnPack()
		{
			IAudioFadeT audioFadeT = new IAudioFadeT();
			this.UnPackTo(audioFadeT);
			return audioFadeT;
		}

		// Token: 0x0601FCE5 RID: 130277 RVA: 0x0046D2FF File Offset: 0x0046B4FF
		public void UnPackTo(IAudioFadeT _o)
		{
			_o.FadeCurve = this.FadeCurve;
			_o.FadeDuration = this.FadeDuration;
		}

		// Token: 0x0601FCE6 RID: 130278 RVA: 0x0046D31C File Offset: 0x0046B51C
		public static Offset<IAudioFade> Pack(FlatBufferBuilder builder, IAudioFadeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioFade>);
			}
			return IAudioFade.CreateIAudioFade(builder, _o.FadeCurve, _o.FadeDuration);
		}

		// Token: 0x0400DCDB RID: 56539
		private Table __p;
	}
}
