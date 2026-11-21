using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760C RID: 30220
	public struct IResetFocusConfig : IFlatbufferObject
	{
		// Token: 0x1700DE0B RID: 56843
		// (get) Token: 0x0603505B RID: 217179 RVA: 0x0071F6AD File Offset: 0x0071D8AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603505C RID: 217180 RVA: 0x0071F6BA File Offset: 0x0071D8BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603505D RID: 217181 RVA: 0x0071F6C4 File Offset: 0x0071D8C4
		public static IResetFocusConfig GetRootAsIResetFocusConfig(ByteBuffer _bb)
		{
			return IResetFocusConfig.GetRootAsIResetFocusConfig(_bb, default(IResetFocusConfig));
		}

		// Token: 0x0603505E RID: 217182 RVA: 0x0071F6E0 File Offset: 0x0071D8E0
		public static IResetFocusConfig GetRootAsIResetFocusConfig(ByteBuffer _bb, IResetFocusConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603505F RID: 217183 RVA: 0x0071F6FD File Offset: 0x0071D8FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035060 RID: 217184 RVA: 0x0071F70C File Offset: 0x0071D90C
		public IResetFocusConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE0C RID: 56844
		// (get) Token: 0x06035061 RID: 217185 RVA: 0x0071F71C File Offset: 0x0071D91C
		public float FadeInTime
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

		// Token: 0x1700DE0D RID: 56845
		// (get) Token: 0x06035062 RID: 217186 RVA: 0x0071F75C File Offset: 0x0071D95C
		public IBaseCurve? FadeInCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035063 RID: 217187 RVA: 0x0071F7B9 File Offset: 0x0071D9B9
		public static Offset<IResetFocusConfig> CreateIResetFocusConfig(FlatBufferBuilder builder, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>))
		{
			builder.StartTable(2);
			IResetFocusConfig.AddFadeInCurve(builder, FadeInCurveOffset);
			IResetFocusConfig.AddFadeInTime(builder, FadeInTime);
			return IResetFocusConfig.EndIResetFocusConfig(builder);
		}

		// Token: 0x06035064 RID: 217188 RVA: 0x0071F7D6 File Offset: 0x0071D9D6
		public static void StartIResetFocusConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035065 RID: 217189 RVA: 0x0071F7DF File Offset: 0x0071D9DF
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06035066 RID: 217190 RVA: 0x0071F7F2 File Offset: 0x0071D9F2
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(1, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x06035067 RID: 217191 RVA: 0x0071F802 File Offset: 0x0071DA02
		public static Offset<IResetFocusConfig> EndIResetFocusConfig(FlatBufferBuilder builder)
		{
			return new Offset<IResetFocusConfig>(builder.EndTable());
		}

		// Token: 0x06035068 RID: 217192 RVA: 0x0071F810 File Offset: 0x0071DA10
		public IResetFocusConfigT UnPack()
		{
			IResetFocusConfigT resetFocusConfigT = new IResetFocusConfigT();
			this.UnPackTo(resetFocusConfigT);
			return resetFocusConfigT;
		}

		// Token: 0x06035069 RID: 217193 RVA: 0x0071F82C File Offset: 0x0071DA2C
		public void UnPackTo(IResetFocusConfigT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.FadeInCurve = ((this.FadeInCurve != null) ? this.FadeInCurve.Value.UnPack() : null);
		}

		// Token: 0x0603506A RID: 217194 RVA: 0x0071F874 File Offset: 0x0071DA74
		public static Offset<IResetFocusConfig> Pack(FlatBufferBuilder builder, IResetFocusConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetFocusConfig>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			return IResetFocusConfig.CreateIResetFocusConfig(builder, _o.FadeInTime, fadeInCurveOffset);
		}

		// Token: 0x040127FA RID: 75770
		private Table __p;
	}
}
