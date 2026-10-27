using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C24 RID: 27684
	public struct IOpenQuickHackCameraFovConfig : IFlatbufferObject
	{
		// Token: 0x1700CDE5 RID: 52709
		// (get) Token: 0x06030AFF RID: 199423 RVA: 0x0069C04B File Offset: 0x0069A24B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B00 RID: 199424 RVA: 0x0069C058 File Offset: 0x0069A258
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B01 RID: 199425 RVA: 0x0069C060 File Offset: 0x0069A260
		public static IOpenQuickHackCameraFovConfig GetRootAsIOpenQuickHackCameraFovConfig(ByteBuffer _bb)
		{
			return IOpenQuickHackCameraFovConfig.GetRootAsIOpenQuickHackCameraFovConfig(_bb, default(IOpenQuickHackCameraFovConfig));
		}

		// Token: 0x06030B02 RID: 199426 RVA: 0x0069C07C File Offset: 0x0069A27C
		public static IOpenQuickHackCameraFovConfig GetRootAsIOpenQuickHackCameraFovConfig(ByteBuffer _bb, IOpenQuickHackCameraFovConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B03 RID: 199427 RVA: 0x0069C099 File Offset: 0x0069A299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B04 RID: 199428 RVA: 0x0069C0A8 File Offset: 0x0069A2A8
		public IOpenQuickHackCameraFovConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDE6 RID: 52710
		// (get) Token: 0x06030B05 RID: 199429 RVA: 0x0069C0B8 File Offset: 0x0069A2B8
		public int DefaultValue
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDE7 RID: 52711
		// (get) Token: 0x06030B06 RID: 199430 RVA: 0x0069C0F4 File Offset: 0x0069A2F4
		public int Min
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

		// Token: 0x1700CDE8 RID: 52712
		// (get) Token: 0x06030B07 RID: 199431 RVA: 0x0069C130 File Offset: 0x0069A330
		public int Max
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

		// Token: 0x06030B08 RID: 199432 RVA: 0x0069C16C File Offset: 0x0069A36C
		public static Offset<IOpenQuickHackCameraFovConfig> CreateIOpenQuickHackCameraFovConfig(FlatBufferBuilder builder, int DefaultValue = 0, int Min = 0, int Max = 0)
		{
			builder.StartTable(3);
			IOpenQuickHackCameraFovConfig.AddMax(builder, Max);
			IOpenQuickHackCameraFovConfig.AddMin(builder, Min);
			IOpenQuickHackCameraFovConfig.AddDefaultValue(builder, DefaultValue);
			return IOpenQuickHackCameraFovConfig.EndIOpenQuickHackCameraFovConfig(builder);
		}

		// Token: 0x06030B09 RID: 199433 RVA: 0x0069C190 File Offset: 0x0069A390
		public static void StartIOpenQuickHackCameraFovConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030B0A RID: 199434 RVA: 0x0069C199 File Offset: 0x0069A399
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x06030B0B RID: 199435 RVA: 0x0069C1A4 File Offset: 0x0069A3A4
		public static void AddMin(FlatBufferBuilder builder, int min)
		{
			builder.AddInt(1, min, 0);
		}

		// Token: 0x06030B0C RID: 199436 RVA: 0x0069C1AF File Offset: 0x0069A3AF
		public static void AddMax(FlatBufferBuilder builder, int max)
		{
			builder.AddInt(2, max, 0);
		}

		// Token: 0x06030B0D RID: 199437 RVA: 0x0069C1BA File Offset: 0x0069A3BA
		public static Offset<IOpenQuickHackCameraFovConfig> EndIOpenQuickHackCameraFovConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQuickHackCameraFovConfig>(builder.EndTable());
		}

		// Token: 0x06030B0E RID: 199438 RVA: 0x0069C1C8 File Offset: 0x0069A3C8
		public IOpenQuickHackCameraFovConfigT UnPack()
		{
			IOpenQuickHackCameraFovConfigT openQuickHackCameraFovConfigT = new IOpenQuickHackCameraFovConfigT();
			this.UnPackTo(openQuickHackCameraFovConfigT);
			return openQuickHackCameraFovConfigT;
		}

		// Token: 0x06030B0F RID: 199439 RVA: 0x0069C1E3 File Offset: 0x0069A3E3
		public void UnPackTo(IOpenQuickHackCameraFovConfigT _o)
		{
			_o.DefaultValue = this.DefaultValue;
			_o.Min = this.Min;
			_o.Max = this.Max;
		}

		// Token: 0x06030B10 RID: 199440 RVA: 0x0069C20C File Offset: 0x0069A40C
		public static Offset<IOpenQuickHackCameraFovConfig> Pack(FlatBufferBuilder builder, IOpenQuickHackCameraFovConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQuickHackCameraFovConfig>);
			}
			return IOpenQuickHackCameraFovConfig.CreateIOpenQuickHackCameraFovConfig(builder, _o.DefaultValue, _o.Min, _o.Max);
		}

		// Token: 0x0401152E RID: 70958
		private Table __p;
	}
}
