using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC0 RID: 15040
	public struct IRushWarningEffectParams : IFlatbufferObject
	{
		// Token: 0x1700672D RID: 26413
		// (get) Token: 0x0601473A RID: 83770 RVA: 0x002FAF76 File Offset: 0x002F9176
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601473B RID: 83771 RVA: 0x002FAF83 File Offset: 0x002F9183
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601473C RID: 83772 RVA: 0x002FAF8C File Offset: 0x002F918C
		public static IRushWarningEffectParams GetRootAsIRushWarningEffectParams(ByteBuffer _bb)
		{
			return IRushWarningEffectParams.GetRootAsIRushWarningEffectParams(_bb, default(IRushWarningEffectParams));
		}

		// Token: 0x0601473D RID: 83773 RVA: 0x002FAFA8 File Offset: 0x002F91A8
		public static IRushWarningEffectParams GetRootAsIRushWarningEffectParams(ByteBuffer _bb, IRushWarningEffectParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601473E RID: 83774 RVA: 0x002FAFC5 File Offset: 0x002F91C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601473F RID: 83775 RVA: 0x002FAFD4 File Offset: 0x002F91D4
		public IRushWarningEffectParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700672E RID: 26414
		// (get) Token: 0x06014740 RID: 83776 RVA: 0x002FAFE4 File Offset: 0x002F91E4
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700672F RID: 26415
		// (get) Token: 0x06014741 RID: 83777 RVA: 0x002FB020 File Offset: 0x002F9220
		public int Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006730 RID: 26416
		// (get) Token: 0x06014742 RID: 83778 RVA: 0x002FB05C File Offset: 0x002F925C
		public int Width
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006731 RID: 26417
		// (get) Token: 0x06014743 RID: 83779 RVA: 0x002FB098 File Offset: 0x002F9298
		public float Time
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

		// Token: 0x06014744 RID: 83780 RVA: 0x002FB0D9 File Offset: 0x002F92D9
		public static Offset<IRushWarningEffectParams> CreateIRushWarningEffectParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, int Length = 0, int Width = 0, float Time = 0f)
		{
			builder.StartTable(4);
			IRushWarningEffectParams.AddTime(builder, Time);
			IRushWarningEffectParams.AddWidth(builder, Width);
			IRushWarningEffectParams.AddLength(builder, Length);
			IRushWarningEffectParams.AddType(builder, Type);
			return IRushWarningEffectParams.EndIRushWarningEffectParams(builder);
		}

		// Token: 0x06014745 RID: 83781 RVA: 0x002FB105 File Offset: 0x002F9305
		public static void StartIRushWarningEffectParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06014746 RID: 83782 RVA: 0x002FB10E File Offset: 0x002F930E
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014747 RID: 83783 RVA: 0x002FB119 File Offset: 0x002F9319
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(1, length, 0);
		}

		// Token: 0x06014748 RID: 83784 RVA: 0x002FB124 File Offset: 0x002F9324
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(2, width, 0);
		}

		// Token: 0x06014749 RID: 83785 RVA: 0x002FB12F File Offset: 0x002F932F
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(3, time, 0.0);
		}

		// Token: 0x0601474A RID: 83786 RVA: 0x002FB142 File Offset: 0x002F9342
		public static Offset<IRushWarningEffectParams> EndIRushWarningEffectParams(FlatBufferBuilder builder)
		{
			return new Offset<IRushWarningEffectParams>(builder.EndTable());
		}

		// Token: 0x0601474B RID: 83787 RVA: 0x002FB150 File Offset: 0x002F9350
		public IRushWarningEffectParamsT UnPack()
		{
			IRushWarningEffectParamsT rushWarningEffectParamsT = new IRushWarningEffectParamsT();
			this.UnPackTo(rushWarningEffectParamsT);
			return rushWarningEffectParamsT;
		}

		// Token: 0x0601474C RID: 83788 RVA: 0x002FB16B File Offset: 0x002F936B
		public void UnPackTo(IRushWarningEffectParamsT _o)
		{
			_o.Type = this.Type;
			_o.Length = this.Length;
			_o.Width = this.Width;
			_o.Time = this.Time;
		}

		// Token: 0x0601474D RID: 83789 RVA: 0x002FB1A0 File Offset: 0x002F93A0
		public static Offset<IRushWarningEffectParams> Pack(FlatBufferBuilder builder, IRushWarningEffectParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRushWarningEffectParams>);
			}
			return IRushWarningEffectParams.CreateIRushWarningEffectParams(builder, _o.Type, _o.Length, _o.Width, _o.Time);
		}

		// Token: 0x0400AF5E RID: 44894
		private Table __p;
	}
}
