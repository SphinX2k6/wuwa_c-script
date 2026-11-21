using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C68 RID: 31848
	public struct ITriggerDeadeyeMode : IFlatbufferObject
	{
		// Token: 0x1700EE5F RID: 61023
		// (get) Token: 0x06039683 RID: 235139 RVA: 0x007BFF14 File Offset: 0x007BE114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039684 RID: 235140 RVA: 0x007BFF21 File Offset: 0x007BE121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039685 RID: 235141 RVA: 0x007BFF28 File Offset: 0x007BE128
		public static ITriggerDeadeyeMode GetRootAsITriggerDeadeyeMode(ByteBuffer _bb)
		{
			return ITriggerDeadeyeMode.GetRootAsITriggerDeadeyeMode(_bb, default(ITriggerDeadeyeMode));
		}

		// Token: 0x06039686 RID: 235142 RVA: 0x007BFF44 File Offset: 0x007BE144
		public static ITriggerDeadeyeMode GetRootAsITriggerDeadeyeMode(ByteBuffer _bb, ITriggerDeadeyeMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039687 RID: 235143 RVA: 0x007BFF61 File Offset: 0x007BE161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039688 RID: 235144 RVA: 0x007BFF70 File Offset: 0x007BE170
		public ITriggerDeadeyeMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE60 RID: 61024
		// (get) Token: 0x06039689 RID: 235145 RVA: 0x007BFF80 File Offset: 0x007BE180
		public IDeadeyeFollowShooterConfig? FollowShooterConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDeadeyeFollowShooterConfig?(default(IDeadeyeFollowShooterConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603968A RID: 235146 RVA: 0x007BFFE0 File Offset: 0x007BE1E0
		public int FocusOnTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EE61 RID: 61025
		// (get) Token: 0x0603968B RID: 235147 RVA: 0x007C0020 File Offset: 0x007BE220
		public int FocusOnTagsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603968C RID: 235148 RVA: 0x007C004B File Offset: 0x007BE24B
		public Span<int> GetFocusOnTagsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603968D RID: 235149 RVA: 0x007C005A File Offset: 0x007BE25A
		public int[] GetFocusOnTagsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700EE62 RID: 61026
		// (get) Token: 0x0603968E RID: 235150 RVA: 0x007C0068 File Offset: 0x007BE268
		public float FocusRadius
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

		// Token: 0x1700EE63 RID: 61027
		// (get) Token: 0x0603968F RID: 235151 RVA: 0x007C00A8 File Offset: 0x007BE2A8
		public float TimeScale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EE64 RID: 61028
		// (get) Token: 0x06039690 RID: 235152 RVA: 0x007C00EC File Offset: 0x007BE2EC
		public float TimeScaleTransitionTime
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

		// Token: 0x1700EE65 RID: 61029
		// (get) Token: 0x06039691 RID: 235153 RVA: 0x007C0130 File Offset: 0x007BE330
		public IDeadeyeFadeOutConfig? FadeOutConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IDeadeyeFadeOutConfig?(default(IDeadeyeFadeOutConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EE66 RID: 61030
		// (get) Token: 0x06039692 RID: 235154 RVA: 0x007C0190 File Offset: 0x007BE390
		public IDeadeyeEnergyConfig? EnergyConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IDeadeyeEnergyConfig?(default(IDeadeyeEnergyConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EE67 RID: 61031
		// (get) Token: 0x06039693 RID: 235155 RVA: 0x007C01F0 File Offset: 0x007BE3F0
		public IDeadeyeCameraConfig? DefaultLookAt
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IDeadeyeCameraConfig?(default(IDeadeyeCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EE68 RID: 61032
		// (get) Token: 0x06039694 RID: 235156 RVA: 0x007C0250 File Offset: 0x007BE450
		public IDeadEyeEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IDeadEyeEffectConfig?(default(IDeadEyeEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EE69 RID: 61033
		// (get) Token: 0x06039695 RID: 235157 RVA: 0x007C02B0 File Offset: 0x007BE4B0
		public string FinishSendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039696 RID: 235158 RVA: 0x007C02E8 File Offset: 0x007BE4E8
		public Span<byte> GetFinishSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06039697 RID: 235159 RVA: 0x007C02F8 File Offset: 0x007BE4F8
		public byte[] GetFinishSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700EE6A RID: 61034
		// (get) Token: 0x06039698 RID: 235160 RVA: 0x007C0308 File Offset: 0x007BE508
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039699 RID: 235161 RVA: 0x007C0348 File Offset: 0x007BE548
		public static Offset<ITriggerDeadeyeMode> CreateITriggerDeadeyeMode(FlatBufferBuilder builder, Offset<IDeadeyeFollowShooterConfig> FollowShooterConfigOffset = default(Offset<IDeadeyeFollowShooterConfig>), VectorOffset FocusOnTagsOffset = default(VectorOffset), float FocusRadius = 0f, float TimeScale = 0f, float TimeScaleTransitionTime = 0f, Offset<IDeadeyeFadeOutConfig> FadeOutConfigOffset = default(Offset<IDeadeyeFadeOutConfig>), Offset<IDeadeyeEnergyConfig> EnergyConfigOffset = default(Offset<IDeadeyeEnergyConfig>), Offset<IDeadeyeCameraConfig> DefaultLookAtOffset = default(Offset<IDeadeyeCameraConfig>), Offset<IDeadEyeEffectConfig> EffectConfigOffset = default(Offset<IDeadEyeEffectConfig>), StringOffset FinishSendSelfEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			ITriggerDeadeyeMode.AddFinishSendSelfEvent(builder, FinishSendSelfEventOffset);
			ITriggerDeadeyeMode.AddEffectConfig(builder, EffectConfigOffset);
			ITriggerDeadeyeMode.AddDefaultLookAt(builder, DefaultLookAtOffset);
			ITriggerDeadeyeMode.AddEnergyConfig(builder, EnergyConfigOffset);
			ITriggerDeadeyeMode.AddFadeOutConfig(builder, FadeOutConfigOffset);
			ITriggerDeadeyeMode.AddTimeScaleTransitionTime(builder, TimeScaleTransitionTime);
			ITriggerDeadeyeMode.AddTimeScale(builder, TimeScale);
			ITriggerDeadeyeMode.AddFocusRadius(builder, FocusRadius);
			ITriggerDeadeyeMode.AddFocusOnTags(builder, FocusOnTagsOffset);
			ITriggerDeadeyeMode.AddFollowShooterConfig(builder, FollowShooterConfigOffset);
			ITriggerDeadeyeMode.AddNullMask(builder, NullMask);
			return ITriggerDeadeyeMode.EndITriggerDeadeyeMode(builder);
		}

		// Token: 0x0603969A RID: 235162 RVA: 0x007C03B8 File Offset: 0x007BE5B8
		public static void StartITriggerDeadeyeMode(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0603969B RID: 235163 RVA: 0x007C03C2 File Offset: 0x007BE5C2
		public static void AddFollowShooterConfig(FlatBufferBuilder builder, Offset<IDeadeyeFollowShooterConfig> followShooterConfigOffset)
		{
			builder.AddOffset(0, followShooterConfigOffset.Value, 0);
		}

		// Token: 0x0603969C RID: 235164 RVA: 0x007C03D2 File Offset: 0x007BE5D2
		public static void AddFocusOnTags(FlatBufferBuilder builder, VectorOffset focusOnTagsOffset)
		{
			builder.AddOffset(1, focusOnTagsOffset.Value, 0);
		}

		// Token: 0x0603969D RID: 235165 RVA: 0x007C03E4 File Offset: 0x007BE5E4
		public static VectorOffset CreateFocusOnTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603969E RID: 235166 RVA: 0x007C041B File Offset: 0x007BE61B
		public static VectorOffset CreateFocusOnTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603969F RID: 235167 RVA: 0x007C0435 File Offset: 0x007BE635
		public static VectorOffset CreateFocusOnTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060396A0 RID: 235168 RVA: 0x007C0453 File Offset: 0x007BE653
		public static VectorOffset CreateFocusOnTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060396A1 RID: 235169 RVA: 0x007C046C File Offset: 0x007BE66C
		public static void StartFocusOnTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060396A2 RID: 235170 RVA: 0x007C0477 File Offset: 0x007BE677
		public static void AddFocusRadius(FlatBufferBuilder builder, float focusRadius)
		{
			builder.AddFloat(2, focusRadius, 0.0);
		}

		// Token: 0x060396A3 RID: 235171 RVA: 0x007C048A File Offset: 0x007BE68A
		public static void AddTimeScale(FlatBufferBuilder builder, float timeScale)
		{
			builder.AddFloat(3, timeScale, 0.0);
		}

		// Token: 0x060396A4 RID: 235172 RVA: 0x007C049D File Offset: 0x007BE69D
		public static void AddTimeScaleTransitionTime(FlatBufferBuilder builder, float timeScaleTransitionTime)
		{
			builder.AddFloat(4, timeScaleTransitionTime, 0.0);
		}

		// Token: 0x060396A5 RID: 235173 RVA: 0x007C04B0 File Offset: 0x007BE6B0
		public static void AddFadeOutConfig(FlatBufferBuilder builder, Offset<IDeadeyeFadeOutConfig> fadeOutConfigOffset)
		{
			builder.AddOffset(5, fadeOutConfigOffset.Value, 0);
		}

		// Token: 0x060396A6 RID: 235174 RVA: 0x007C04C0 File Offset: 0x007BE6C0
		public static void AddEnergyConfig(FlatBufferBuilder builder, Offset<IDeadeyeEnergyConfig> energyConfigOffset)
		{
			builder.AddOffset(6, energyConfigOffset.Value, 0);
		}

		// Token: 0x060396A7 RID: 235175 RVA: 0x007C04D0 File Offset: 0x007BE6D0
		public static void AddDefaultLookAt(FlatBufferBuilder builder, Offset<IDeadeyeCameraConfig> defaultLookAtOffset)
		{
			builder.AddOffset(7, defaultLookAtOffset.Value, 0);
		}

		// Token: 0x060396A8 RID: 235176 RVA: 0x007C04E0 File Offset: 0x007BE6E0
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IDeadEyeEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(8, effectConfigOffset.Value, 0);
		}

		// Token: 0x060396A9 RID: 235177 RVA: 0x007C04F0 File Offset: 0x007BE6F0
		public static void AddFinishSendSelfEvent(FlatBufferBuilder builder, StringOffset finishSendSelfEventOffset)
		{
			builder.AddOffset(9, finishSendSelfEventOffset.Value, 0);
		}

		// Token: 0x060396AA RID: 235178 RVA: 0x007C0501 File Offset: 0x007BE701
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060396AB RID: 235179 RVA: 0x007C050D File Offset: 0x007BE70D
		public static Offset<ITriggerDeadeyeMode> EndITriggerDeadeyeMode(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerDeadeyeMode>(builder.EndTable());
		}

		// Token: 0x060396AC RID: 235180 RVA: 0x007C051C File Offset: 0x007BE71C
		public ITriggerDeadeyeModeT UnPack()
		{
			ITriggerDeadeyeModeT triggerDeadeyeModeT = new ITriggerDeadeyeModeT();
			this.UnPackTo(triggerDeadeyeModeT);
			return triggerDeadeyeModeT;
		}

		// Token: 0x060396AD RID: 235181 RVA: 0x007C0538 File Offset: 0x007BE738
		public void UnPackTo(ITriggerDeadeyeModeT _o)
		{
			_o.FollowShooterConfig = ((this.FollowShooterConfig != null) ? this.FollowShooterConfig.Value.UnPack() : null);
			_o.FocusOnTags = new List<int>();
			for (int i = 0; i < this.FocusOnTagsLength; i++)
			{
				_o.FocusOnTags.Add(this.FocusOnTags(i));
			}
			_o.FocusRadius = this.FocusRadius;
			_o.TimeScale = this.TimeScale;
			_o.TimeScaleTransitionTime = this.TimeScaleTransitionTime;
			_o.FadeOutConfig = ((this.FadeOutConfig != null) ? this.FadeOutConfig.Value.UnPack() : null);
			_o.EnergyConfig = ((this.EnergyConfig != null) ? this.EnergyConfig.Value.UnPack() : null);
			_o.DefaultLookAt = ((this.DefaultLookAt != null) ? this.DefaultLookAt.Value.UnPack() : null);
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.FinishSendSelfEvent = this.FinishSendSelfEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060396AE RID: 235182 RVA: 0x007C06A4 File Offset: 0x007BE8A4
		public static Offset<ITriggerDeadeyeMode> Pack(FlatBufferBuilder builder, ITriggerDeadeyeModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerDeadeyeMode>);
			}
			Offset<IDeadeyeFollowShooterConfig> followShooterConfigOffset = (_o.FollowShooterConfig == null) ? default(Offset<IDeadeyeFollowShooterConfig>) : IDeadeyeFollowShooterConfig.Pack(builder, _o.FollowShooterConfig);
			VectorOffset focusOnTagsOffset = default(VectorOffset);
			if (_o.FocusOnTags != null)
			{
				int[] data = _o.FocusOnTags.ToArray();
				focusOnTagsOffset = ITriggerDeadeyeMode.CreateFocusOnTagsVector(builder, data);
			}
			Offset<IDeadeyeFadeOutConfig> fadeOutConfigOffset = (_o.FadeOutConfig == null) ? default(Offset<IDeadeyeFadeOutConfig>) : IDeadeyeFadeOutConfig.Pack(builder, _o.FadeOutConfig);
			Offset<IDeadeyeEnergyConfig> energyConfigOffset = (_o.EnergyConfig == null) ? default(Offset<IDeadeyeEnergyConfig>) : IDeadeyeEnergyConfig.Pack(builder, _o.EnergyConfig);
			Offset<IDeadeyeCameraConfig> defaultLookAtOffset = (_o.DefaultLookAt == null) ? default(Offset<IDeadeyeCameraConfig>) : IDeadeyeCameraConfig.Pack(builder, _o.DefaultLookAt);
			Offset<IDeadEyeEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IDeadEyeEffectConfig>) : IDeadEyeEffectConfig.Pack(builder, _o.EffectConfig);
			StringOffset finishSendSelfEventOffset = (_o.FinishSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.FinishSendSelfEvent);
			return ITriggerDeadeyeMode.CreateITriggerDeadeyeMode(builder, followShooterConfigOffset, focusOnTagsOffset, _o.FocusRadius, _o.TimeScale, _o.TimeScaleTransitionTime, fadeOutConfigOffset, energyConfigOffset, defaultLookAtOffset, effectConfigOffset, finishSendSelfEventOffset, _o.NullMask);
		}

		// Token: 0x04013327 RID: 78631
		private Table __p;
	}
}
