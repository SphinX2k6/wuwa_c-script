using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006847 RID: 26695
	public struct IAxisLockScreenConfig : IFlatbufferObject
	{
		// Token: 0x1700C446 RID: 50246
		// (get) Token: 0x0602DA08 RID: 186888 RVA: 0x0063E14C File Offset: 0x0063C34C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA09 RID: 186889 RVA: 0x0063E159 File Offset: 0x0063C359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA0A RID: 186890 RVA: 0x0063E160 File Offset: 0x0063C360
		public static IAxisLockScreenConfig GetRootAsIAxisLockScreenConfig(ByteBuffer _bb)
		{
			return IAxisLockScreenConfig.GetRootAsIAxisLockScreenConfig(_bb, default(IAxisLockScreenConfig));
		}

		// Token: 0x0602DA0B RID: 186891 RVA: 0x0063E17C File Offset: 0x0063C37C
		public static IAxisLockScreenConfig GetRootAsIAxisLockScreenConfig(ByteBuffer _bb, IAxisLockScreenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA0C RID: 186892 RVA: 0x0063E199 File Offset: 0x0063C399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA0D RID: 186893 RVA: 0x0063E1A8 File Offset: 0x0063C3A8
		public IAxisLockScreenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C447 RID: 50247
		// (get) Token: 0x0602DA0E RID: 186894 RVA: 0x0063E1B8 File Offset: 0x0063C3B8
		public float TriggerAngle
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

		// Token: 0x1700C448 RID: 50248
		// (get) Token: 0x0602DA0F RID: 186895 RVA: 0x0063E1F8 File Offset: 0x0063C3F8
		public float FadeInTime
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

		// Token: 0x1700C449 RID: 50249
		// (get) Token: 0x0602DA10 RID: 186896 RVA: 0x0063E238 File Offset: 0x0063C438
		public float FadeOutTime
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

		// Token: 0x0602DA11 RID: 186897 RVA: 0x0063E278 File Offset: 0x0063C478
		public static Offset<IAxisLockScreenConfig> CreateIAxisLockScreenConfig(FlatBufferBuilder builder, float TriggerAngle = 0f, float FadeInTime = 0f, float FadeOutTime = 0f)
		{
			builder.StartTable(3);
			IAxisLockScreenConfig.AddFadeOutTime(builder, FadeOutTime);
			IAxisLockScreenConfig.AddFadeInTime(builder, FadeInTime);
			IAxisLockScreenConfig.AddTriggerAngle(builder, TriggerAngle);
			return IAxisLockScreenConfig.EndIAxisLockScreenConfig(builder);
		}

		// Token: 0x0602DA12 RID: 186898 RVA: 0x0063E29C File Offset: 0x0063C49C
		public static void StartIAxisLockScreenConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DA13 RID: 186899 RVA: 0x0063E2A5 File Offset: 0x0063C4A5
		public static void AddTriggerAngle(FlatBufferBuilder builder, float triggerAngle)
		{
			builder.AddFloat(0, triggerAngle, 0.0);
		}

		// Token: 0x0602DA14 RID: 186900 RVA: 0x0063E2B8 File Offset: 0x0063C4B8
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(1, fadeInTime, 0.0);
		}

		// Token: 0x0602DA15 RID: 186901 RVA: 0x0063E2CB File Offset: 0x0063C4CB
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602DA16 RID: 186902 RVA: 0x0063E2DE File Offset: 0x0063C4DE
		public static Offset<IAxisLockScreenConfig> EndIAxisLockScreenConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAxisLockScreenConfig>(builder.EndTable());
		}

		// Token: 0x0602DA17 RID: 186903 RVA: 0x0063E2EC File Offset: 0x0063C4EC
		public IAxisLockScreenConfigT UnPack()
		{
			IAxisLockScreenConfigT axisLockScreenConfigT = new IAxisLockScreenConfigT();
			this.UnPackTo(axisLockScreenConfigT);
			return axisLockScreenConfigT;
		}

		// Token: 0x0602DA18 RID: 186904 RVA: 0x0063E307 File Offset: 0x0063C507
		public void UnPackTo(IAxisLockScreenConfigT _o)
		{
			_o.TriggerAngle = this.TriggerAngle;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
		}

		// Token: 0x0602DA19 RID: 186905 RVA: 0x0063E330 File Offset: 0x0063C530
		public static Offset<IAxisLockScreenConfig> Pack(FlatBufferBuilder builder, IAxisLockScreenConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAxisLockScreenConfig>);
			}
			return IAxisLockScreenConfig.CreateIAxisLockScreenConfig(builder, _o.TriggerAngle, _o.FadeInTime, _o.FadeOutTime);
		}

		// Token: 0x04011516 RID: 70934
		private Table __p;
	}
}
