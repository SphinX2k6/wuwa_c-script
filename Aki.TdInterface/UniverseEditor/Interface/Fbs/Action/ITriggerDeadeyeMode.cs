using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007475 RID: 29813
	public struct ITriggerDeadeyeMode : IFlatbufferObject
	{
		// Token: 0x1700E242 RID: 57922
		// (get) Token: 0x0603629A RID: 221850 RVA: 0x0075D1E8 File Offset: 0x0075B3E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603629B RID: 221851 RVA: 0x0075D1F5 File Offset: 0x0075B3F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603629C RID: 221852 RVA: 0x0075D1FC File Offset: 0x0075B3FC
		public static ITriggerDeadeyeMode GetRootAsITriggerDeadeyeMode(ByteBuffer _bb)
		{
			return ITriggerDeadeyeMode.GetRootAsITriggerDeadeyeMode(_bb, default(ITriggerDeadeyeMode));
		}

		// Token: 0x0603629D RID: 221853 RVA: 0x0075D218 File Offset: 0x0075B418
		public static ITriggerDeadeyeMode GetRootAsITriggerDeadeyeMode(ByteBuffer _bb, ITriggerDeadeyeMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603629E RID: 221854 RVA: 0x0075D235 File Offset: 0x0075B435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603629F RID: 221855 RVA: 0x0075D244 File Offset: 0x0075B444
		public ITriggerDeadeyeMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E243 RID: 57923
		// (get) Token: 0x060362A0 RID: 221856 RVA: 0x0075D254 File Offset: 0x0075B454
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

		// Token: 0x060362A1 RID: 221857 RVA: 0x0075D2B4 File Offset: 0x0075B4B4
		public int FocusOnTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E244 RID: 57924
		// (get) Token: 0x060362A2 RID: 221858 RVA: 0x0075D2F4 File Offset: 0x0075B4F4
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

		// Token: 0x060362A3 RID: 221859 RVA: 0x0075D31F File Offset: 0x0075B51F
		public Span<int> GetFocusOnTagsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060362A4 RID: 221860 RVA: 0x0075D32E File Offset: 0x0075B52E
		public int[] GetFocusOnTagsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700E245 RID: 57925
		// (get) Token: 0x060362A5 RID: 221861 RVA: 0x0075D33C File Offset: 0x0075B53C
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

		// Token: 0x1700E246 RID: 57926
		// (get) Token: 0x060362A6 RID: 221862 RVA: 0x0075D37C File Offset: 0x0075B57C
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

		// Token: 0x1700E247 RID: 57927
		// (get) Token: 0x060362A7 RID: 221863 RVA: 0x0075D3C0 File Offset: 0x0075B5C0
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

		// Token: 0x1700E248 RID: 57928
		// (get) Token: 0x060362A8 RID: 221864 RVA: 0x0075D404 File Offset: 0x0075B604
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

		// Token: 0x1700E249 RID: 57929
		// (get) Token: 0x060362A9 RID: 221865 RVA: 0x0075D464 File Offset: 0x0075B664
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

		// Token: 0x1700E24A RID: 57930
		// (get) Token: 0x060362AA RID: 221866 RVA: 0x0075D4C4 File Offset: 0x0075B6C4
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

		// Token: 0x1700E24B RID: 57931
		// (get) Token: 0x060362AB RID: 221867 RVA: 0x0075D524 File Offset: 0x0075B724
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

		// Token: 0x1700E24C RID: 57932
		// (get) Token: 0x060362AC RID: 221868 RVA: 0x0075D584 File Offset: 0x0075B784
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

		// Token: 0x060362AD RID: 221869 RVA: 0x0075D5BC File Offset: 0x0075B7BC
		public Span<byte> GetFinishSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060362AE RID: 221870 RVA: 0x0075D5CC File Offset: 0x0075B7CC
		public byte[] GetFinishSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700E24D RID: 57933
		// (get) Token: 0x060362AF RID: 221871 RVA: 0x0075D5DC File Offset: 0x0075B7DC
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

		// Token: 0x060362B0 RID: 221872 RVA: 0x0075D61C File Offset: 0x0075B81C
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

		// Token: 0x060362B1 RID: 221873 RVA: 0x0075D68C File Offset: 0x0075B88C
		public static void StartITriggerDeadeyeMode(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060362B2 RID: 221874 RVA: 0x0075D696 File Offset: 0x0075B896
		public static void AddFollowShooterConfig(FlatBufferBuilder builder, Offset<IDeadeyeFollowShooterConfig> followShooterConfigOffset)
		{
			builder.AddOffset(0, followShooterConfigOffset.Value, 0);
		}

		// Token: 0x060362B3 RID: 221875 RVA: 0x0075D6A6 File Offset: 0x0075B8A6
		public static void AddFocusOnTags(FlatBufferBuilder builder, VectorOffset focusOnTagsOffset)
		{
			builder.AddOffset(1, focusOnTagsOffset.Value, 0);
		}

		// Token: 0x060362B4 RID: 221876 RVA: 0x0075D6B8 File Offset: 0x0075B8B8
		public static VectorOffset CreateFocusOnTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060362B5 RID: 221877 RVA: 0x0075D6EF File Offset: 0x0075B8EF
		public static VectorOffset CreateFocusOnTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060362B6 RID: 221878 RVA: 0x0075D709 File Offset: 0x0075B909
		public static VectorOffset CreateFocusOnTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060362B7 RID: 221879 RVA: 0x0075D727 File Offset: 0x0075B927
		public static VectorOffset CreateFocusOnTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060362B8 RID: 221880 RVA: 0x0075D740 File Offset: 0x0075B940
		public static void StartFocusOnTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060362B9 RID: 221881 RVA: 0x0075D74B File Offset: 0x0075B94B
		public static void AddFocusRadius(FlatBufferBuilder builder, float focusRadius)
		{
			builder.AddFloat(2, focusRadius, 0.0);
		}

		// Token: 0x060362BA RID: 221882 RVA: 0x0075D75E File Offset: 0x0075B95E
		public static void AddTimeScale(FlatBufferBuilder builder, float timeScale)
		{
			builder.AddFloat(3, timeScale, 0.0);
		}

		// Token: 0x060362BB RID: 221883 RVA: 0x0075D771 File Offset: 0x0075B971
		public static void AddTimeScaleTransitionTime(FlatBufferBuilder builder, float timeScaleTransitionTime)
		{
			builder.AddFloat(4, timeScaleTransitionTime, 0.0);
		}

		// Token: 0x060362BC RID: 221884 RVA: 0x0075D784 File Offset: 0x0075B984
		public static void AddFadeOutConfig(FlatBufferBuilder builder, Offset<IDeadeyeFadeOutConfig> fadeOutConfigOffset)
		{
			builder.AddOffset(5, fadeOutConfigOffset.Value, 0);
		}

		// Token: 0x060362BD RID: 221885 RVA: 0x0075D794 File Offset: 0x0075B994
		public static void AddEnergyConfig(FlatBufferBuilder builder, Offset<IDeadeyeEnergyConfig> energyConfigOffset)
		{
			builder.AddOffset(6, energyConfigOffset.Value, 0);
		}

		// Token: 0x060362BE RID: 221886 RVA: 0x0075D7A4 File Offset: 0x0075B9A4
		public static void AddDefaultLookAt(FlatBufferBuilder builder, Offset<IDeadeyeCameraConfig> defaultLookAtOffset)
		{
			builder.AddOffset(7, defaultLookAtOffset.Value, 0);
		}

		// Token: 0x060362BF RID: 221887 RVA: 0x0075D7B4 File Offset: 0x0075B9B4
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IDeadEyeEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(8, effectConfigOffset.Value, 0);
		}

		// Token: 0x060362C0 RID: 221888 RVA: 0x0075D7C4 File Offset: 0x0075B9C4
		public static void AddFinishSendSelfEvent(FlatBufferBuilder builder, StringOffset finishSendSelfEventOffset)
		{
			builder.AddOffset(9, finishSendSelfEventOffset.Value, 0);
		}

		// Token: 0x060362C1 RID: 221889 RVA: 0x0075D7D5 File Offset: 0x0075B9D5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060362C2 RID: 221890 RVA: 0x0075D7E1 File Offset: 0x0075B9E1
		public static Offset<ITriggerDeadeyeMode> EndITriggerDeadeyeMode(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerDeadeyeMode>(builder.EndTable());
		}

		// Token: 0x060362C3 RID: 221891 RVA: 0x0075D7F0 File Offset: 0x0075B9F0
		public ITriggerDeadeyeModeT UnPack()
		{
			ITriggerDeadeyeModeT triggerDeadeyeModeT = new ITriggerDeadeyeModeT();
			this.UnPackTo(triggerDeadeyeModeT);
			return triggerDeadeyeModeT;
		}

		// Token: 0x060362C4 RID: 221892 RVA: 0x0075D80C File Offset: 0x0075BA0C
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

		// Token: 0x060362C5 RID: 221893 RVA: 0x0075D978 File Offset: 0x0075BB78
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

		// Token: 0x04012300 RID: 74496
		private Table __p;
	}
}
