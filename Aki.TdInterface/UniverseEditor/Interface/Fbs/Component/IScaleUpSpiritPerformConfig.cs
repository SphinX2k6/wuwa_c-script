using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA4 RID: 24228
	public struct IScaleUpSpiritPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700B2E9 RID: 45801
		// (get) Token: 0x06028920 RID: 166176 RVA: 0x0058BE46 File Offset: 0x0058A046
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028921 RID: 166177 RVA: 0x0058BE53 File Offset: 0x0058A053
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028922 RID: 166178 RVA: 0x0058BE5C File Offset: 0x0058A05C
		public static IScaleUpSpiritPerformConfig GetRootAsIScaleUpSpiritPerformConfig(ByteBuffer _bb)
		{
			return IScaleUpSpiritPerformConfig.GetRootAsIScaleUpSpiritPerformConfig(_bb, default(IScaleUpSpiritPerformConfig));
		}

		// Token: 0x06028923 RID: 166179 RVA: 0x0058BE78 File Offset: 0x0058A078
		public static IScaleUpSpiritPerformConfig GetRootAsIScaleUpSpiritPerformConfig(ByteBuffer _bb, IScaleUpSpiritPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028924 RID: 166180 RVA: 0x0058BE95 File Offset: 0x0058A095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028925 RID: 166181 RVA: 0x0058BEA4 File Offset: 0x0058A0A4
		public IScaleUpSpiritPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2EA RID: 45802
		// (get) Token: 0x06028926 RID: 166182 RVA: 0x0058BEB4 File Offset: 0x0058A0B4
		public bool IsInitHide
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2EB RID: 45803
		// (get) Token: 0x06028927 RID: 166183 RVA: 0x0058BEF4 File Offset: 0x0058A0F4
		public string AppearEffectDa
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

		// Token: 0x06028928 RID: 166184 RVA: 0x0058BF2B File Offset: 0x0058A12B
		public Span<byte> GetAppearEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028929 RID: 166185 RVA: 0x0058BF3A File Offset: 0x0058A13A
		public byte[] GetAppearEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B2EC RID: 45804
		// (get) Token: 0x0602892A RID: 166186 RVA: 0x0058BF48 File Offset: 0x0058A148
		public string ScaleUpEffectDa
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

		// Token: 0x0602892B RID: 166187 RVA: 0x0058BF7F File Offset: 0x0058A17F
		public Span<byte> GetScaleUpEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602892C RID: 166188 RVA: 0x0058BF8E File Offset: 0x0058A18E
		public byte[] GetScaleUpEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B2ED RID: 45805
		// (get) Token: 0x0602892D RID: 166189 RVA: 0x0058BF9C File Offset: 0x0058A19C
		public int ScaleUpPerformTag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B2EE RID: 45806
		// (get) Token: 0x0602892E RID: 166190 RVA: 0x0058BFDC File Offset: 0x0058A1DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602892F RID: 166191 RVA: 0x0058C019 File Offset: 0x0058A219
		public static Offset<IScaleUpSpiritPerformConfig> CreateIScaleUpSpiritPerformConfig(FlatBufferBuilder builder, bool IsInitHide = false, StringOffset AppearEffectDaOffset = default(StringOffset), StringOffset ScaleUpEffectDaOffset = default(StringOffset), int ScaleUpPerformTag = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IScaleUpSpiritPerformConfig.AddScaleUpPerformTag(builder, ScaleUpPerformTag);
			IScaleUpSpiritPerformConfig.AddScaleUpEffectDa(builder, ScaleUpEffectDaOffset);
			IScaleUpSpiritPerformConfig.AddAppearEffectDa(builder, AppearEffectDaOffset);
			IScaleUpSpiritPerformConfig.AddNullMask(builder, NullMask);
			IScaleUpSpiritPerformConfig.AddIsInitHide(builder, IsInitHide);
			return IScaleUpSpiritPerformConfig.EndIScaleUpSpiritPerformConfig(builder);
		}

		// Token: 0x06028930 RID: 166192 RVA: 0x0058C04D File Offset: 0x0058A24D
		public static void StartIScaleUpSpiritPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028931 RID: 166193 RVA: 0x0058C056 File Offset: 0x0058A256
		public static void AddIsInitHide(FlatBufferBuilder builder, bool isInitHide)
		{
			builder.AddBool(0, isInitHide, false);
		}

		// Token: 0x06028932 RID: 166194 RVA: 0x0058C061 File Offset: 0x0058A261
		public static void AddAppearEffectDa(FlatBufferBuilder builder, StringOffset appearEffectDaOffset)
		{
			builder.AddOffset(1, appearEffectDaOffset.Value, 0);
		}

		// Token: 0x06028933 RID: 166195 RVA: 0x0058C071 File Offset: 0x0058A271
		public static void AddScaleUpEffectDa(FlatBufferBuilder builder, StringOffset scaleUpEffectDaOffset)
		{
			builder.AddOffset(2, scaleUpEffectDaOffset.Value, 0);
		}

		// Token: 0x06028934 RID: 166196 RVA: 0x0058C081 File Offset: 0x0058A281
		public static void AddScaleUpPerformTag(FlatBufferBuilder builder, int scaleUpPerformTag)
		{
			builder.AddInt(3, scaleUpPerformTag, 0);
		}

		// Token: 0x06028935 RID: 166197 RVA: 0x0058C08C File Offset: 0x0058A28C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06028936 RID: 166198 RVA: 0x0058C097 File Offset: 0x0058A297
		public static Offset<IScaleUpSpiritPerformConfig> EndIScaleUpSpiritPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IScaleUpSpiritPerformConfig>(builder.EndTable());
		}

		// Token: 0x06028937 RID: 166199 RVA: 0x0058C0A4 File Offset: 0x0058A2A4
		public IScaleUpSpiritPerformConfigT UnPack()
		{
			IScaleUpSpiritPerformConfigT scaleUpSpiritPerformConfigT = new IScaleUpSpiritPerformConfigT();
			this.UnPackTo(scaleUpSpiritPerformConfigT);
			return scaleUpSpiritPerformConfigT;
		}

		// Token: 0x06028938 RID: 166200 RVA: 0x0058C0BF File Offset: 0x0058A2BF
		public void UnPackTo(IScaleUpSpiritPerformConfigT _o)
		{
			_o.IsInitHide = this.IsInitHide;
			_o.AppearEffectDa = this.AppearEffectDa;
			_o.ScaleUpEffectDa = this.ScaleUpEffectDa;
			_o.ScaleUpPerformTag = this.ScaleUpPerformTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028939 RID: 166201 RVA: 0x0058C100 File Offset: 0x0058A300
		public static Offset<IScaleUpSpiritPerformConfig> Pack(FlatBufferBuilder builder, IScaleUpSpiritPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScaleUpSpiritPerformConfig>);
			}
			StringOffset appearEffectDaOffset = (_o.AppearEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.AppearEffectDa);
			StringOffset scaleUpEffectDaOffset = (_o.ScaleUpEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.ScaleUpEffectDa);
			return IScaleUpSpiritPerformConfig.CreateIScaleUpSpiritPerformConfig(builder, _o.IsInitHide, appearEffectDaOffset, scaleUpEffectDaOffset, _o.ScaleUpPerformTag, _o.NullMask);
		}

		// Token: 0x0400FAE7 RID: 64231
		private Table __p;
	}
}
