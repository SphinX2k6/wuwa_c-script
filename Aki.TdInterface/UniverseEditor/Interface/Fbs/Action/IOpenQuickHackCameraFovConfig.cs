using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738B RID: 29579
	public struct IOpenQuickHackCameraFovConfig : IFlatbufferObject
	{
		// Token: 0x1700D900 RID: 55552
		// (get) Token: 0x06033A53 RID: 211539 RVA: 0x006F6347 File Offset: 0x006F4547
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A54 RID: 211540 RVA: 0x006F6354 File Offset: 0x006F4554
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A55 RID: 211541 RVA: 0x006F635C File Offset: 0x006F455C
		public static IOpenQuickHackCameraFovConfig GetRootAsIOpenQuickHackCameraFovConfig(ByteBuffer _bb)
		{
			return IOpenQuickHackCameraFovConfig.GetRootAsIOpenQuickHackCameraFovConfig(_bb, default(IOpenQuickHackCameraFovConfig));
		}

		// Token: 0x06033A56 RID: 211542 RVA: 0x006F6378 File Offset: 0x006F4578
		public static IOpenQuickHackCameraFovConfig GetRootAsIOpenQuickHackCameraFovConfig(ByteBuffer _bb, IOpenQuickHackCameraFovConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A57 RID: 211543 RVA: 0x006F6395 File Offset: 0x006F4595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A58 RID: 211544 RVA: 0x006F63A4 File Offset: 0x006F45A4
		public IOpenQuickHackCameraFovConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D901 RID: 55553
		// (get) Token: 0x06033A59 RID: 211545 RVA: 0x006F63B4 File Offset: 0x006F45B4
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

		// Token: 0x1700D902 RID: 55554
		// (get) Token: 0x06033A5A RID: 211546 RVA: 0x006F63F0 File Offset: 0x006F45F0
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

		// Token: 0x1700D903 RID: 55555
		// (get) Token: 0x06033A5B RID: 211547 RVA: 0x006F642C File Offset: 0x006F462C
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

		// Token: 0x06033A5C RID: 211548 RVA: 0x006F6468 File Offset: 0x006F4668
		public static Offset<IOpenQuickHackCameraFovConfig> CreateIOpenQuickHackCameraFovConfig(FlatBufferBuilder builder, int DefaultValue = 0, int Min = 0, int Max = 0)
		{
			builder.StartTable(3);
			IOpenQuickHackCameraFovConfig.AddMax(builder, Max);
			IOpenQuickHackCameraFovConfig.AddMin(builder, Min);
			IOpenQuickHackCameraFovConfig.AddDefaultValue(builder, DefaultValue);
			return IOpenQuickHackCameraFovConfig.EndIOpenQuickHackCameraFovConfig(builder);
		}

		// Token: 0x06033A5D RID: 211549 RVA: 0x006F648C File Offset: 0x006F468C
		public static void StartIOpenQuickHackCameraFovConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033A5E RID: 211550 RVA: 0x006F6495 File Offset: 0x006F4695
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x06033A5F RID: 211551 RVA: 0x006F64A0 File Offset: 0x006F46A0
		public static void AddMin(FlatBufferBuilder builder, int min)
		{
			builder.AddInt(1, min, 0);
		}

		// Token: 0x06033A60 RID: 211552 RVA: 0x006F64AB File Offset: 0x006F46AB
		public static void AddMax(FlatBufferBuilder builder, int max)
		{
			builder.AddInt(2, max, 0);
		}

		// Token: 0x06033A61 RID: 211553 RVA: 0x006F64B6 File Offset: 0x006F46B6
		public static Offset<IOpenQuickHackCameraFovConfig> EndIOpenQuickHackCameraFovConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQuickHackCameraFovConfig>(builder.EndTable());
		}

		// Token: 0x06033A62 RID: 211554 RVA: 0x006F64C4 File Offset: 0x006F46C4
		public IOpenQuickHackCameraFovConfigT UnPack()
		{
			IOpenQuickHackCameraFovConfigT openQuickHackCameraFovConfigT = new IOpenQuickHackCameraFovConfigT();
			this.UnPackTo(openQuickHackCameraFovConfigT);
			return openQuickHackCameraFovConfigT;
		}

		// Token: 0x06033A63 RID: 211555 RVA: 0x006F64DF File Offset: 0x006F46DF
		public void UnPackTo(IOpenQuickHackCameraFovConfigT _o)
		{
			_o.DefaultValue = this.DefaultValue;
			_o.Min = this.Min;
			_o.Max = this.Max;
		}

		// Token: 0x06033A64 RID: 211556 RVA: 0x006F6508 File Offset: 0x006F4708
		public static Offset<IOpenQuickHackCameraFovConfig> Pack(FlatBufferBuilder builder, IOpenQuickHackCameraFovConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQuickHackCameraFovConfig>);
			}
			return IOpenQuickHackCameraFovConfig.CreateIOpenQuickHackCameraFovConfig(builder, _o.DefaultValue, _o.Min, _o.Max);
		}

		// Token: 0x04012485 RID: 74885
		private Table __p;
	}
}
