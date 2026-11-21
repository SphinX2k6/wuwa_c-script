using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007364 RID: 29540
	public struct IOpenGlobalTimeScale : IFlatbufferObject
	{
		// Token: 0x1700D8A6 RID: 55462
		// (get) Token: 0x060338CC RID: 211148 RVA: 0x006F2AF0 File Offset: 0x006F0CF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060338CD RID: 211149 RVA: 0x006F2AFD File Offset: 0x006F0CFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060338CE RID: 211150 RVA: 0x006F2B04 File Offset: 0x006F0D04
		public static IOpenGlobalTimeScale GetRootAsIOpenGlobalTimeScale(ByteBuffer _bb)
		{
			return IOpenGlobalTimeScale.GetRootAsIOpenGlobalTimeScale(_bb, default(IOpenGlobalTimeScale));
		}

		// Token: 0x060338CF RID: 211151 RVA: 0x006F2B20 File Offset: 0x006F0D20
		public static IOpenGlobalTimeScale GetRootAsIOpenGlobalTimeScale(ByteBuffer _bb, IOpenGlobalTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060338D0 RID: 211152 RVA: 0x006F2B3D File Offset: 0x006F0D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060338D1 RID: 211153 RVA: 0x006F2B4C File Offset: 0x006F0D4C
		public IOpenGlobalTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8A7 RID: 55463
		// (get) Token: 0x060338D2 RID: 211154 RVA: 0x006F2B5C File Offset: 0x006F0D5C
		public ESetTimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTimeScaleType.Open;
				}
				return (ESetTimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D8A8 RID: 55464
		// (get) Token: 0x060338D3 RID: 211155 RVA: 0x006F2B98 File Offset: 0x006F0D98
		public float TimeScale
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

		// Token: 0x1700D8A9 RID: 55465
		// (get) Token: 0x060338D4 RID: 211156 RVA: 0x006F2BD8 File Offset: 0x006F0DD8
		public float Duration
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

		// Token: 0x060338D5 RID: 211157 RVA: 0x006F2C18 File Offset: 0x006F0E18
		public static Offset<IOpenGlobalTimeScale> CreateIOpenGlobalTimeScale(FlatBufferBuilder builder, ESetTimeScaleType Type = ESetTimeScaleType.Open, float TimeScale = 0f, float Duration = 0f)
		{
			builder.StartTable(3);
			IOpenGlobalTimeScale.AddDuration(builder, Duration);
			IOpenGlobalTimeScale.AddTimeScale(builder, TimeScale);
			IOpenGlobalTimeScale.AddType(builder, Type);
			return IOpenGlobalTimeScale.EndIOpenGlobalTimeScale(builder);
		}

		// Token: 0x060338D6 RID: 211158 RVA: 0x006F2C3C File Offset: 0x006F0E3C
		public static void StartIOpenGlobalTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060338D7 RID: 211159 RVA: 0x006F2C45 File Offset: 0x006F0E45
		public static void AddType(FlatBufferBuilder builder, ESetTimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060338D8 RID: 211160 RVA: 0x006F2C50 File Offset: 0x006F0E50
		public static void AddTimeScale(FlatBufferBuilder builder, float timeScale)
		{
			builder.AddFloat(1, timeScale, 0.0);
		}

		// Token: 0x060338D9 RID: 211161 RVA: 0x006F2C63 File Offset: 0x006F0E63
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x060338DA RID: 211162 RVA: 0x006F2C76 File Offset: 0x006F0E76
		public static Offset<IOpenGlobalTimeScale> EndIOpenGlobalTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGlobalTimeScale>(builder.EndTable());
		}

		// Token: 0x060338DB RID: 211163 RVA: 0x006F2C84 File Offset: 0x006F0E84
		public IOpenGlobalTimeScaleT UnPack()
		{
			IOpenGlobalTimeScaleT openGlobalTimeScaleT = new IOpenGlobalTimeScaleT();
			this.UnPackTo(openGlobalTimeScaleT);
			return openGlobalTimeScaleT;
		}

		// Token: 0x060338DC RID: 211164 RVA: 0x006F2C9F File Offset: 0x006F0E9F
		public void UnPackTo(IOpenGlobalTimeScaleT _o)
		{
			_o.Type = this.Type;
			_o.TimeScale = this.TimeScale;
			_o.Duration = this.Duration;
		}

		// Token: 0x060338DD RID: 211165 RVA: 0x006F2CC8 File Offset: 0x006F0EC8
		public static Offset<IOpenGlobalTimeScale> Pack(FlatBufferBuilder builder, IOpenGlobalTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenGlobalTimeScale>);
			}
			return IOpenGlobalTimeScale.CreateIOpenGlobalTimeScale(builder, _o.Type, _o.TimeScale, _o.Duration);
		}

		// Token: 0x0401244C RID: 74828
		private Table __p;
	}
}
