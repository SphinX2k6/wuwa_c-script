using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007097 RID: 28823
	public struct ISetTimeScale : IFlatbufferObject
	{
		// Token: 0x1700D62B RID: 54827
		// (get) Token: 0x0603309C RID: 209052 RVA: 0x006E25D9 File Offset: 0x006E07D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603309D RID: 209053 RVA: 0x006E25E6 File Offset: 0x006E07E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603309E RID: 209054 RVA: 0x006E25F0 File Offset: 0x006E07F0
		public static ISetTimeScale GetRootAsISetTimeScale(ByteBuffer _bb)
		{
			return ISetTimeScale.GetRootAsISetTimeScale(_bb, default(ISetTimeScale));
		}

		// Token: 0x0603309F RID: 209055 RVA: 0x006E260C File Offset: 0x006E080C
		public static ISetTimeScale GetRootAsISetTimeScale(ByteBuffer _bb, ISetTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330A0 RID: 209056 RVA: 0x006E2629 File Offset: 0x006E0829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330A1 RID: 209057 RVA: 0x006E2638 File Offset: 0x006E0838
		public ISetTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D62C RID: 54828
		// (get) Token: 0x060330A2 RID: 209058 RVA: 0x006E2648 File Offset: 0x006E0848
		public ISetGlobalTimeScale? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISetGlobalTimeScale?(default(ISetGlobalTimeScale).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060330A3 RID: 209059 RVA: 0x006E26A5 File Offset: 0x006E08A5
		public static Offset<ISetTimeScale> CreateISetTimeScale(FlatBufferBuilder builder, Offset<ISetGlobalTimeScale> ConfigOffset = default(Offset<ISetGlobalTimeScale>))
		{
			builder.StartTable(1);
			ISetTimeScale.AddConfig(builder, ConfigOffset);
			return ISetTimeScale.EndISetTimeScale(builder);
		}

		// Token: 0x060330A4 RID: 209060 RVA: 0x006E26BB File Offset: 0x006E08BB
		public static void StartISetTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060330A5 RID: 209061 RVA: 0x006E26C4 File Offset: 0x006E08C4
		public static void AddConfig(FlatBufferBuilder builder, Offset<ISetGlobalTimeScale> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x060330A6 RID: 209062 RVA: 0x006E26D4 File Offset: 0x006E08D4
		public static Offset<ISetTimeScale> EndISetTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<ISetTimeScale>(builder.EndTable());
		}

		// Token: 0x060330A7 RID: 209063 RVA: 0x006E26E4 File Offset: 0x006E08E4
		public ISetTimeScaleT UnPack()
		{
			ISetTimeScaleT setTimeScaleT = new ISetTimeScaleT();
			this.UnPackTo(setTimeScaleT);
			return setTimeScaleT;
		}

		// Token: 0x060330A8 RID: 209064 RVA: 0x006E2700 File Offset: 0x006E0900
		public void UnPackTo(ISetTimeScaleT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x060330A9 RID: 209065 RVA: 0x006E273C File Offset: 0x006E093C
		public static Offset<ISetTimeScale> Pack(FlatBufferBuilder builder, ISetTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTimeScale>);
			}
			Offset<ISetGlobalTimeScale> configOffset = (_o.Config == null) ? default(Offset<ISetGlobalTimeScale>) : ISetGlobalTimeScale.Pack(builder, _o.Config);
			return ISetTimeScale.CreateISetTimeScale(builder, configOffset);
		}

		// Token: 0x04011B02 RID: 72450
		private Table __p;
	}
}
