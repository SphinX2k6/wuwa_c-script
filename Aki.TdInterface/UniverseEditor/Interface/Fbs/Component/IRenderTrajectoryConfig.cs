using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005855 RID: 22613
	public struct IRenderTrajectoryConfig : IFlatbufferObject
	{
		// Token: 0x1700A8FB RID: 43259
		// (get) Token: 0x060260F1 RID: 155889 RVA: 0x0053F4D4 File Offset: 0x0053D6D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060260F2 RID: 155890 RVA: 0x0053F4E1 File Offset: 0x0053D6E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060260F3 RID: 155891 RVA: 0x0053F4E8 File Offset: 0x0053D6E8
		public static IRenderTrajectoryConfig GetRootAsIRenderTrajectoryConfig(ByteBuffer _bb)
		{
			return IRenderTrajectoryConfig.GetRootAsIRenderTrajectoryConfig(_bb, default(IRenderTrajectoryConfig));
		}

		// Token: 0x060260F4 RID: 155892 RVA: 0x0053F504 File Offset: 0x0053D704
		public static IRenderTrajectoryConfig GetRootAsIRenderTrajectoryConfig(ByteBuffer _bb, IRenderTrajectoryConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060260F5 RID: 155893 RVA: 0x0053F521 File Offset: 0x0053D721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060260F6 RID: 155894 RVA: 0x0053F530 File Offset: 0x0053D730
		public IRenderTrajectoryConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8FC RID: 43260
		// (get) Token: 0x060260F7 RID: 155895 RVA: 0x0053F540 File Offset: 0x0053D740
		public float Time
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

		// Token: 0x1700A8FD RID: 43261
		// (get) Token: 0x060260F8 RID: 155896 RVA: 0x0053F580 File Offset: 0x0053D780
		public string Effect
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

		// Token: 0x060260F9 RID: 155897 RVA: 0x0053F5B7 File Offset: 0x0053D7B7
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060260FA RID: 155898 RVA: 0x0053F5C6 File Offset: 0x0053D7C6
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060260FB RID: 155899 RVA: 0x0053F5D4 File Offset: 0x0053D7D4
		public static Offset<IRenderTrajectoryConfig> CreateIRenderTrajectoryConfig(FlatBufferBuilder builder, float Time = 0f, StringOffset EffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRenderTrajectoryConfig.AddEffect(builder, EffectOffset);
			IRenderTrajectoryConfig.AddTime(builder, Time);
			return IRenderTrajectoryConfig.EndIRenderTrajectoryConfig(builder);
		}

		// Token: 0x060260FC RID: 155900 RVA: 0x0053F5F1 File Offset: 0x0053D7F1
		public static void StartIRenderTrajectoryConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060260FD RID: 155901 RVA: 0x0053F5FA File Offset: 0x0053D7FA
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(0, time, 0.0);
		}

		// Token: 0x060260FE RID: 155902 RVA: 0x0053F60D File Offset: 0x0053D80D
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x060260FF RID: 155903 RVA: 0x0053F61D File Offset: 0x0053D81D
		public static Offset<IRenderTrajectoryConfig> EndIRenderTrajectoryConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRenderTrajectoryConfig>(builder.EndTable());
		}

		// Token: 0x06026100 RID: 155904 RVA: 0x0053F62C File Offset: 0x0053D82C
		public IRenderTrajectoryConfigT UnPack()
		{
			IRenderTrajectoryConfigT renderTrajectoryConfigT = new IRenderTrajectoryConfigT();
			this.UnPackTo(renderTrajectoryConfigT);
			return renderTrajectoryConfigT;
		}

		// Token: 0x06026101 RID: 155905 RVA: 0x0053F647 File Offset: 0x0053D847
		public void UnPackTo(IRenderTrajectoryConfigT _o)
		{
			_o.Time = this.Time;
			_o.Effect = this.Effect;
		}

		// Token: 0x06026102 RID: 155906 RVA: 0x0053F664 File Offset: 0x0053D864
		public static Offset<IRenderTrajectoryConfig> Pack(FlatBufferBuilder builder, IRenderTrajectoryConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderTrajectoryConfig>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IRenderTrajectoryConfig.CreateIRenderTrajectoryConfig(builder, _o.Time, effectOffset);
		}

		// Token: 0x0400ED81 RID: 60801
		private Table __p;
	}
}
