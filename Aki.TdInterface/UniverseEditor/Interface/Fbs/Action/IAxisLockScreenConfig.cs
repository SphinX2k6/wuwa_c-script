using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D9 RID: 25049
	public struct IAxisLockScreenConfig : IFlatbufferObject
	{
		// Token: 0x1700BAC3 RID: 47811
		// (get) Token: 0x0602B2C1 RID: 176833 RVA: 0x005F36D8 File Offset: 0x005F18D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B2C2 RID: 176834 RVA: 0x005F36E5 File Offset: 0x005F18E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B2C3 RID: 176835 RVA: 0x005F36EC File Offset: 0x005F18EC
		public static IAxisLockScreenConfig GetRootAsIAxisLockScreenConfig(ByteBuffer _bb)
		{
			return IAxisLockScreenConfig.GetRootAsIAxisLockScreenConfig(_bb, default(IAxisLockScreenConfig));
		}

		// Token: 0x0602B2C4 RID: 176836 RVA: 0x005F3708 File Offset: 0x005F1908
		public static IAxisLockScreenConfig GetRootAsIAxisLockScreenConfig(ByteBuffer _bb, IAxisLockScreenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B2C5 RID: 176837 RVA: 0x005F3725 File Offset: 0x005F1925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B2C6 RID: 176838 RVA: 0x005F3734 File Offset: 0x005F1934
		public IAxisLockScreenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAC4 RID: 47812
		// (get) Token: 0x0602B2C7 RID: 176839 RVA: 0x005F3744 File Offset: 0x005F1944
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

		// Token: 0x1700BAC5 RID: 47813
		// (get) Token: 0x0602B2C8 RID: 176840 RVA: 0x005F3784 File Offset: 0x005F1984
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

		// Token: 0x1700BAC6 RID: 47814
		// (get) Token: 0x0602B2C9 RID: 176841 RVA: 0x005F37C4 File Offset: 0x005F19C4
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

		// Token: 0x0602B2CA RID: 176842 RVA: 0x005F3804 File Offset: 0x005F1A04
		public static Offset<IAxisLockScreenConfig> CreateIAxisLockScreenConfig(FlatBufferBuilder builder, float TriggerAngle = 0f, float FadeInTime = 0f, float FadeOutTime = 0f)
		{
			builder.StartTable(3);
			IAxisLockScreenConfig.AddFadeOutTime(builder, FadeOutTime);
			IAxisLockScreenConfig.AddFadeInTime(builder, FadeInTime);
			IAxisLockScreenConfig.AddTriggerAngle(builder, TriggerAngle);
			return IAxisLockScreenConfig.EndIAxisLockScreenConfig(builder);
		}

		// Token: 0x0602B2CB RID: 176843 RVA: 0x005F3828 File Offset: 0x005F1A28
		public static void StartIAxisLockScreenConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B2CC RID: 176844 RVA: 0x005F3831 File Offset: 0x005F1A31
		public static void AddTriggerAngle(FlatBufferBuilder builder, float triggerAngle)
		{
			builder.AddFloat(0, triggerAngle, 0.0);
		}

		// Token: 0x0602B2CD RID: 176845 RVA: 0x005F3844 File Offset: 0x005F1A44
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(1, fadeInTime, 0.0);
		}

		// Token: 0x0602B2CE RID: 176846 RVA: 0x005F3857 File Offset: 0x005F1A57
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602B2CF RID: 176847 RVA: 0x005F386A File Offset: 0x005F1A6A
		public static Offset<IAxisLockScreenConfig> EndIAxisLockScreenConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAxisLockScreenConfig>(builder.EndTable());
		}

		// Token: 0x0602B2D0 RID: 176848 RVA: 0x005F3878 File Offset: 0x005F1A78
		public IAxisLockScreenConfigT UnPack()
		{
			IAxisLockScreenConfigT axisLockScreenConfigT = new IAxisLockScreenConfigT();
			this.UnPackTo(axisLockScreenConfigT);
			return axisLockScreenConfigT;
		}

		// Token: 0x0602B2D1 RID: 176849 RVA: 0x005F3893 File Offset: 0x005F1A93
		public void UnPackTo(IAxisLockScreenConfigT _o)
		{
			_o.TriggerAngle = this.TriggerAngle;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
		}

		// Token: 0x0602B2D2 RID: 176850 RVA: 0x005F38BC File Offset: 0x005F1ABC
		public static Offset<IAxisLockScreenConfig> Pack(FlatBufferBuilder builder, IAxisLockScreenConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAxisLockScreenConfig>);
			}
			return IAxisLockScreenConfig.CreateIAxisLockScreenConfig(builder, _o.TriggerAngle, _o.FadeInTime, _o.FadeOutTime);
		}

		// Token: 0x04010704 RID: 67332
		private Table __p;
	}
}
