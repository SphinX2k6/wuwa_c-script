using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005403 RID: 21507
	public struct IAudioFade : IFlatbufferObject
	{
		// Token: 0x1700984B RID: 38987
		// (get) Token: 0x06021A1B RID: 137755 RVA: 0x004A2F84 File Offset: 0x004A1184
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A1C RID: 137756 RVA: 0x004A2F91 File Offset: 0x004A1191
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A1D RID: 137757 RVA: 0x004A2F98 File Offset: 0x004A1198
		public static IAudioFade GetRootAsIAudioFade(ByteBuffer _bb)
		{
			return IAudioFade.GetRootAsIAudioFade(_bb, default(IAudioFade));
		}

		// Token: 0x06021A1E RID: 137758 RVA: 0x004A2FB4 File Offset: 0x004A11B4
		public static IAudioFade GetRootAsIAudioFade(ByteBuffer _bb, IAudioFade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A1F RID: 137759 RVA: 0x004A2FD1 File Offset: 0x004A11D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A20 RID: 137760 RVA: 0x004A2FE0 File Offset: 0x004A11E0
		public IAudioFade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700984C RID: 38988
		// (get) Token: 0x06021A21 RID: 137761 RVA: 0x004A2FF0 File Offset: 0x004A11F0
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

		// Token: 0x1700984D RID: 38989
		// (get) Token: 0x06021A22 RID: 137762 RVA: 0x004A302C File Offset: 0x004A122C
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

		// Token: 0x06021A23 RID: 137763 RVA: 0x004A3068 File Offset: 0x004A1268
		public static Offset<IAudioFade> CreateIAudioFade(FlatBufferBuilder builder, EAudioFadeCurveType FadeCurve = EAudioFadeCurveType.Log3, int FadeDuration = 0)
		{
			builder.StartTable(2);
			IAudioFade.AddFadeDuration(builder, FadeDuration);
			IAudioFade.AddFadeCurve(builder, FadeCurve);
			return IAudioFade.EndIAudioFade(builder);
		}

		// Token: 0x06021A24 RID: 137764 RVA: 0x004A3085 File Offset: 0x004A1285
		public static void StartIAudioFade(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021A25 RID: 137765 RVA: 0x004A308E File Offset: 0x004A128E
		public static void AddFadeCurve(FlatBufferBuilder builder, EAudioFadeCurveType fadeCurve)
		{
			builder.AddByte(0, (byte)fadeCurve, 0);
		}

		// Token: 0x06021A26 RID: 137766 RVA: 0x004A3099 File Offset: 0x004A1299
		public static void AddFadeDuration(FlatBufferBuilder builder, int fadeDuration)
		{
			builder.AddInt(1, fadeDuration, 0);
		}

		// Token: 0x06021A27 RID: 137767 RVA: 0x004A30A4 File Offset: 0x004A12A4
		public static Offset<IAudioFade> EndIAudioFade(FlatBufferBuilder builder)
		{
			return new Offset<IAudioFade>(builder.EndTable());
		}

		// Token: 0x06021A28 RID: 137768 RVA: 0x004A30B4 File Offset: 0x004A12B4
		public IAudioFadeT UnPack()
		{
			IAudioFadeT audioFadeT = new IAudioFadeT();
			this.UnPackTo(audioFadeT);
			return audioFadeT;
		}

		// Token: 0x06021A29 RID: 137769 RVA: 0x004A30CF File Offset: 0x004A12CF
		public void UnPackTo(IAudioFadeT _o)
		{
			_o.FadeCurve = this.FadeCurve;
			_o.FadeDuration = this.FadeDuration;
		}

		// Token: 0x06021A2A RID: 137770 RVA: 0x004A30EC File Offset: 0x004A12EC
		public static Offset<IAudioFade> Pack(FlatBufferBuilder builder, IAudioFadeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioFade>);
			}
			return IAudioFade.CreateIAudioFade(builder, _o.FadeCurve, _o.FadeDuration);
		}

		// Token: 0x0400E882 RID: 59522
		private Table __p;
	}
}
