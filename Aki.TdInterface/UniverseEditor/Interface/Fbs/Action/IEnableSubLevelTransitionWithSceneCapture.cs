using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006690 RID: 26256
	public struct IEnableSubLevelTransitionWithSceneCapture : IFlatbufferObject
	{
		// Token: 0x1700C31A RID: 49946
		// (get) Token: 0x0602DA11 RID: 186897 RVA: 0x0063ED42 File Offset: 0x0063CF42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA12 RID: 186898 RVA: 0x0063ED4F File Offset: 0x0063CF4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA13 RID: 186899 RVA: 0x0063ED58 File Offset: 0x0063CF58
		public static IEnableSubLevelTransitionWithSceneCapture GetRootAsIEnableSubLevelTransitionWithSceneCapture(ByteBuffer _bb)
		{
			return IEnableSubLevelTransitionWithSceneCapture.GetRootAsIEnableSubLevelTransitionWithSceneCapture(_bb, default(IEnableSubLevelTransitionWithSceneCapture));
		}

		// Token: 0x0602DA14 RID: 186900 RVA: 0x0063ED74 File Offset: 0x0063CF74
		public static IEnableSubLevelTransitionWithSceneCapture GetRootAsIEnableSubLevelTransitionWithSceneCapture(ByteBuffer _bb, IEnableSubLevelTransitionWithSceneCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA15 RID: 186901 RVA: 0x0063ED91 File Offset: 0x0063CF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA16 RID: 186902 RVA: 0x0063EDA0 File Offset: 0x0063CFA0
		public IEnableSubLevelTransitionWithSceneCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C31B RID: 49947
		// (get) Token: 0x0602DA17 RID: 186903 RVA: 0x0063EDB0 File Offset: 0x0063CFB0
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

		// Token: 0x1700C31C RID: 49948
		// (get) Token: 0x0602DA18 RID: 186904 RVA: 0x0063EDEC File Offset: 0x0063CFEC
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

		// Token: 0x0602DA19 RID: 186905 RVA: 0x0063EE23 File Offset: 0x0063D023
		public Span<byte> GetSceneCaptureEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DA1A RID: 186906 RVA: 0x0063EE32 File Offset: 0x0063D032
		public byte[] GetSceneCaptureEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C31D RID: 49949
		// (get) Token: 0x0602DA1B RID: 186907 RVA: 0x0063EE40 File Offset: 0x0063D040
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

		// Token: 0x0602DA1C RID: 186908 RVA: 0x0063EE77 File Offset: 0x0063D077
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602DA1D RID: 186909 RVA: 0x0063EE86 File Offset: 0x0063D086
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C31E RID: 49950
		// (get) Token: 0x0602DA1E RID: 186910 RVA: 0x0063EE94 File Offset: 0x0063D094
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

		// Token: 0x0602DA1F RID: 186911 RVA: 0x0063EECC File Offset: 0x0063D0CC
		public Span<byte> GetScreenEffectLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602DA20 RID: 186912 RVA: 0x0063EEDC File Offset: 0x0063D0DC
		public byte[] GetScreenEffectLoopArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C31F RID: 49951
		// (get) Token: 0x0602DA21 RID: 186913 RVA: 0x0063EEEC File Offset: 0x0063D0EC
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

		// Token: 0x1700C320 RID: 49952
		// (get) Token: 0x0602DA22 RID: 186914 RVA: 0x0063EF30 File Offset: 0x0063D130
		public bool IsAllowInput
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C321 RID: 49953
		// (get) Token: 0x0602DA23 RID: 186915 RVA: 0x0063EF70 File Offset: 0x0063D170
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

		// Token: 0x0602DA24 RID: 186916 RVA: 0x0063EFB0 File Offset: 0x0063D1B0
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

		// Token: 0x0602DA25 RID: 186917 RVA: 0x0063EFFF File Offset: 0x0063D1FF
		public static void StartIEnableSubLevelTransitionWithSceneCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DA26 RID: 186918 RVA: 0x0063F008 File Offset: 0x0063D208
		public static void AddType(FlatBufferBuilder builder, EEnableSubLevelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DA27 RID: 186919 RVA: 0x0063F013 File Offset: 0x0063D213
		public static void AddSceneCaptureEffect(FlatBufferBuilder builder, StringOffset sceneCaptureEffectOffset)
		{
			builder.AddOffset(1, sceneCaptureEffectOffset.Value, 0);
		}

		// Token: 0x0602DA28 RID: 186920 RVA: 0x0063F023 File Offset: 0x0063D223
		public static void AddScreenEffect(FlatBufferBuilder builder, StringOffset screenEffectOffset)
		{
			builder.AddOffset(2, screenEffectOffset.Value, 0);
		}

		// Token: 0x0602DA29 RID: 186921 RVA: 0x0063F033 File Offset: 0x0063D233
		public static void AddScreenEffectLoop(FlatBufferBuilder builder, StringOffset screenEffectLoopOffset)
		{
			builder.AddOffset(3, screenEffectLoopOffset.Value, 0);
		}

		// Token: 0x0602DA2A RID: 186922 RVA: 0x0063F043 File Offset: 0x0063D243
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x0602DA2B RID: 186923 RVA: 0x0063F056 File Offset: 0x0063D256
		public static void AddIsAllowInput(FlatBufferBuilder builder, bool isAllowInput)
		{
			builder.AddBool(5, isAllowInput, false);
		}

		// Token: 0x0602DA2C RID: 186924 RVA: 0x0063F061 File Offset: 0x0063D261
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602DA2D RID: 186925 RVA: 0x0063F06C File Offset: 0x0063D26C
		public static Offset<IEnableSubLevelTransitionWithSceneCapture> EndIEnableSubLevelTransitionWithSceneCapture(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSubLevelTransitionWithSceneCapture>(builder.EndTable());
		}

		// Token: 0x0602DA2E RID: 186926 RVA: 0x0063F07C File Offset: 0x0063D27C
		public IEnableSubLevelTransitionWithSceneCaptureT UnPack()
		{
			IEnableSubLevelTransitionWithSceneCaptureT enableSubLevelTransitionWithSceneCaptureT = new IEnableSubLevelTransitionWithSceneCaptureT();
			this.UnPackTo(enableSubLevelTransitionWithSceneCaptureT);
			return enableSubLevelTransitionWithSceneCaptureT;
		}

		// Token: 0x0602DA2F RID: 186927 RVA: 0x0063F098 File Offset: 0x0063D298
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

		// Token: 0x0602DA30 RID: 186928 RVA: 0x0063F0FC File Offset: 0x0063D2FC
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

		// Token: 0x04010D47 RID: 68935
		private Table __p;
	}
}
