using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0A RID: 27914
	public struct IEnableSubLevelTransitionWithSceneCapture : IFlatbufferObject
	{
		// Token: 0x1700CCCB RID: 52427
		// (get) Token: 0x0603022E RID: 197166 RVA: 0x0068BFF6 File Offset: 0x0068A1F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603022F RID: 197167 RVA: 0x0068C003 File Offset: 0x0068A203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030230 RID: 197168 RVA: 0x0068C00C File Offset: 0x0068A20C
		public static IEnableSubLevelTransitionWithSceneCapture GetRootAsIEnableSubLevelTransitionWithSceneCapture(ByteBuffer _bb)
		{
			return IEnableSubLevelTransitionWithSceneCapture.GetRootAsIEnableSubLevelTransitionWithSceneCapture(_bb, default(IEnableSubLevelTransitionWithSceneCapture));
		}

		// Token: 0x06030231 RID: 197169 RVA: 0x0068C028 File Offset: 0x0068A228
		public static IEnableSubLevelTransitionWithSceneCapture GetRootAsIEnableSubLevelTransitionWithSceneCapture(ByteBuffer _bb, IEnableSubLevelTransitionWithSceneCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030232 RID: 197170 RVA: 0x0068C045 File Offset: 0x0068A245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030233 RID: 197171 RVA: 0x0068C054 File Offset: 0x0068A254
		public IEnableSubLevelTransitionWithSceneCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCCC RID: 52428
		// (get) Token: 0x06030234 RID: 197172 RVA: 0x0068C064 File Offset: 0x0068A264
		public EEnableSubLevelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSubLevelTransitionType.SceneCapture;
				}
				return (EEnableSubLevelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCCD RID: 52429
		// (get) Token: 0x06030235 RID: 197173 RVA: 0x0068C0A0 File Offset: 0x0068A2A0
		public string SceneCaptureEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030236 RID: 197174 RVA: 0x0068C0D7 File Offset: 0x0068A2D7
		public Span<byte> GetSceneCaptureEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030237 RID: 197175 RVA: 0x0068C0E6 File Offset: 0x0068A2E6
		public byte[] GetSceneCaptureEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CCCE RID: 52430
		// (get) Token: 0x06030238 RID: 197176 RVA: 0x0068C0F4 File Offset: 0x0068A2F4
		public string ScreenEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030239 RID: 197177 RVA: 0x0068C12B File Offset: 0x0068A32B
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603023A RID: 197178 RVA: 0x0068C13A File Offset: 0x0068A33A
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CCCF RID: 52431
		// (get) Token: 0x0603023B RID: 197179 RVA: 0x0068C148 File Offset: 0x0068A348
		public string ScreenEffectLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603023C RID: 197180 RVA: 0x0068C180 File Offset: 0x0068A380
		public Span<byte> GetScreenEffectLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603023D RID: 197181 RVA: 0x0068C190 File Offset: 0x0068A390
		public byte[] GetScreenEffectLoopArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700CCD0 RID: 52432
		// (get) Token: 0x0603023E RID: 197182 RVA: 0x0068C1A0 File Offset: 0x0068A3A0
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCD1 RID: 52433
		// (get) Token: 0x0603023F RID: 197183 RVA: 0x0068C1E4 File Offset: 0x0068A3E4
		public bool IsAllowInput
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCD2 RID: 52434
		// (get) Token: 0x06030240 RID: 197184 RVA: 0x0068C224 File Offset: 0x0068A424
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030241 RID: 197185 RVA: 0x0068C264 File Offset: 0x0068A464
		public static Offset<IEnableSubLevelTransitionWithSceneCapture> CreateIEnableSubLevelTransitionWithSceneCapture(FlatBufferBuilder builder, EEnableSubLevelTransitionType Type = EEnableSubLevelTransitionType.SceneCapture, StringOffset SceneCaptureEffectOffset = default(StringOffset), StringOffset ScreenEffectOffset = default(StringOffset), StringOffset ScreenEffectLoopOffset = default(StringOffset), float DelayTime = 0f, bool IsAllowInput = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IEnableSubLevelTransitionWithSceneCapture.AddDelayTime(builder, DelayTime);
			IEnableSubLevelTransitionWithSceneCapture.AddScreenEffectLoop(builder, ScreenEffectLoopOffset);
			IEnableSubLevelTransitionWithSceneCapture.AddScreenEffect(builder, ScreenEffectOffset);
			IEnableSubLevelTransitionWithSceneCapture.AddSceneCaptureEffect(builder, SceneCaptureEffectOffset);
			IEnableSubLevelTransitionWithSceneCapture.AddNullMask(builder, NullMask);
			IEnableSubLevelTransitionWithSceneCapture.AddIsAllowInput(builder, IsAllowInput);
			IEnableSubLevelTransitionWithSceneCapture.AddType(builder, Type);
			return IEnableSubLevelTransitionWithSceneCapture.EndIEnableSubLevelTransitionWithSceneCapture(builder);
		}

		// Token: 0x06030242 RID: 197186 RVA: 0x0068C2B3 File Offset: 0x0068A4B3
		public static void StartIEnableSubLevelTransitionWithSceneCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06030243 RID: 197187 RVA: 0x0068C2BC File Offset: 0x0068A4BC
		public static void AddType(FlatBufferBuilder builder, EEnableSubLevelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030244 RID: 197188 RVA: 0x0068C2C7 File Offset: 0x0068A4C7
		public static void AddSceneCaptureEffect(FlatBufferBuilder builder, StringOffset sceneCaptureEffectOffset)
		{
			builder.AddOffset(1, sceneCaptureEffectOffset.Value, 0);
		}

		// Token: 0x06030245 RID: 197189 RVA: 0x0068C2D7 File Offset: 0x0068A4D7
		public static void AddScreenEffect(FlatBufferBuilder builder, StringOffset screenEffectOffset)
		{
			builder.AddOffset(2, screenEffectOffset.Value, 0);
		}

		// Token: 0x06030246 RID: 197190 RVA: 0x0068C2E7 File Offset: 0x0068A4E7
		public static void AddScreenEffectLoop(FlatBufferBuilder builder, StringOffset screenEffectLoopOffset)
		{
			builder.AddOffset(3, screenEffectLoopOffset.Value, 0);
		}

		// Token: 0x06030247 RID: 197191 RVA: 0x0068C2F7 File Offset: 0x0068A4F7
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x06030248 RID: 197192 RVA: 0x0068C30A File Offset: 0x0068A50A
		public static void AddIsAllowInput(FlatBufferBuilder builder, bool isAllowInput)
		{
			builder.AddBool(5, isAllowInput, false);
		}

		// Token: 0x06030249 RID: 197193 RVA: 0x0068C315 File Offset: 0x0068A515
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603024A RID: 197194 RVA: 0x0068C320 File Offset: 0x0068A520
		public static Offset<IEnableSubLevelTransitionWithSceneCapture> EndIEnableSubLevelTransitionWithSceneCapture(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSubLevelTransitionWithSceneCapture>(builder.EndTable());
		}

		// Token: 0x0603024B RID: 197195 RVA: 0x0068C330 File Offset: 0x0068A530
		public IEnableSubLevelTransitionWithSceneCaptureT UnPack()
		{
			IEnableSubLevelTransitionWithSceneCaptureT enableSubLevelTransitionWithSceneCaptureT = new IEnableSubLevelTransitionWithSceneCaptureT();
			this.UnPackTo(enableSubLevelTransitionWithSceneCaptureT);
			return enableSubLevelTransitionWithSceneCaptureT;
		}

		// Token: 0x0603024C RID: 197196 RVA: 0x0068C34C File Offset: 0x0068A54C
		public void UnPackTo(IEnableSubLevelTransitionWithSceneCaptureT _o)
		{
			_o.Type = this.Type;
			_o.SceneCaptureEffect = this.SceneCaptureEffect;
			_o.ScreenEffect = this.ScreenEffect;
			_o.ScreenEffectLoop = this.ScreenEffectLoop;
			_o.DelayTime = this.DelayTime;
			_o.IsAllowInput = this.IsAllowInput;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603024D RID: 197197 RVA: 0x0068C3B0 File Offset: 0x0068A5B0
		public static Offset<IEnableSubLevelTransitionWithSceneCapture> Pack(FlatBufferBuilder builder, IEnableSubLevelTransitionWithSceneCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSubLevelTransitionWithSceneCapture>);
			}
			StringOffset sceneCaptureEffectOffset = (_o.SceneCaptureEffect == null) ? default(StringOffset) : builder.CreateString(_o.SceneCaptureEffect);
			StringOffset screenEffectOffset = (_o.ScreenEffect == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffect);
			StringOffset screenEffectLoopOffset = (_o.ScreenEffectLoop == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffectLoop);
			return IEnableSubLevelTransitionWithSceneCapture.CreateIEnableSubLevelTransitionWithSceneCapture(builder, _o.Type, sceneCaptureEffectOffset, screenEffectOffset, screenEffectLoopOffset, _o.DelayTime, _o.IsAllowInput, _o.NullMask);
		}

		// Token: 0x04011B6D RID: 72557
		private Table __p;
	}
}
