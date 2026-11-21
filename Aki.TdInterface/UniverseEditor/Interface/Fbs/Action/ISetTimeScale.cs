using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007863 RID: 30819
	public struct ISetTimeScale : IFlatbufferObject
	{
		// Token: 0x1700E20E RID: 57870
		// (get) Token: 0x0603633E RID: 222014 RVA: 0x00742BE5 File Offset: 0x00740DE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603633F RID: 222015 RVA: 0x00742BF2 File Offset: 0x00740DF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036340 RID: 222016 RVA: 0x00742BFC File Offset: 0x00740DFC
		public static ISetTimeScale GetRootAsISetTimeScale(ByteBuffer _bb)
		{
			return ISetTimeScale.GetRootAsISetTimeScale(_bb, default(ISetTimeScale));
		}

		// Token: 0x06036341 RID: 222017 RVA: 0x00742C18 File Offset: 0x00740E18
		public static ISetTimeScale GetRootAsISetTimeScale(ByteBuffer _bb, ISetTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036342 RID: 222018 RVA: 0x00742C35 File Offset: 0x00740E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036343 RID: 222019 RVA: 0x00742C44 File Offset: 0x00740E44
		public ISetTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E20F RID: 57871
		// (get) Token: 0x06036344 RID: 222020 RVA: 0x00742C54 File Offset: 0x00740E54
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

		// Token: 0x06036345 RID: 222021 RVA: 0x00742CB1 File Offset: 0x00740EB1
		public static Offset<ISetTimeScale> CreateISetTimeScale(FlatBufferBuilder builder, Offset<ISetGlobalTimeScale> ConfigOffset = default(Offset<ISetGlobalTimeScale>))
		{
			builder.StartTable(1);
			ISetTimeScale.AddConfig(builder, ConfigOffset);
			return ISetTimeScale.EndISetTimeScale(builder);
		}

		// Token: 0x06036346 RID: 222022 RVA: 0x00742CC7 File Offset: 0x00740EC7
		public static void StartISetTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036347 RID: 222023 RVA: 0x00742CD0 File Offset: 0x00740ED0
		public static void AddConfig(FlatBufferBuilder builder, Offset<ISetGlobalTimeScale> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06036348 RID: 222024 RVA: 0x00742CE0 File Offset: 0x00740EE0
		public static Offset<ISetTimeScale> EndISetTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<ISetTimeScale>(builder.EndTable());
		}

		// Token: 0x06036349 RID: 222025 RVA: 0x00742CF0 File Offset: 0x00740EF0
		public ISetTimeScaleT UnPack()
		{
			ISetTimeScaleT setTimeScaleT = new ISetTimeScaleT();
			this.UnPackTo(setTimeScaleT);
			return setTimeScaleT;
		}

		// Token: 0x0603634A RID: 222026 RVA: 0x00742D0C File Offset: 0x00740F0C
		public void UnPackTo(ISetTimeScaleT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0603634B RID: 222027 RVA: 0x00742D48 File Offset: 0x00740F48
		public static Offset<ISetTimeScale> Pack(FlatBufferBuilder builder, ISetTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTimeScale>);
			}
			Offset<ISetGlobalTimeScale> configOffset = (_o.Config == null) ? default(Offset<ISetGlobalTimeScale>) : ISetGlobalTimeScale.Pack(builder, _o.Config);
			return ISetTimeScale.CreateISetTimeScale(builder, configOffset);
		}

		// Token: 0x04012AF0 RID: 76528
		private Table __p;
	}
}
