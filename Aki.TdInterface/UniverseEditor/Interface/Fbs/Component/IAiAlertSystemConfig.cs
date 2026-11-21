using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005385 RID: 21381
	public struct IAiAlertSystemConfig : IFlatbufferObject
	{
		// Token: 0x1700970A RID: 38666
		// (get) Token: 0x06021525 RID: 136485 RVA: 0x00498EC5 File Offset: 0x004970C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021526 RID: 136486 RVA: 0x00498ED2 File Offset: 0x004970D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021527 RID: 136487 RVA: 0x00498EDC File Offset: 0x004970DC
		public static IAiAlertSystemConfig GetRootAsIAiAlertSystemConfig(ByteBuffer _bb)
		{
			return IAiAlertSystemConfig.GetRootAsIAiAlertSystemConfig(_bb, default(IAiAlertSystemConfig));
		}

		// Token: 0x06021528 RID: 136488 RVA: 0x00498EF8 File Offset: 0x004970F8
		public static IAiAlertSystemConfig GetRootAsIAiAlertSystemConfig(ByteBuffer _bb, IAiAlertSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021529 RID: 136489 RVA: 0x00498F15 File Offset: 0x00497115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602152A RID: 136490 RVA: 0x00498F24 File Offset: 0x00497124
		public IAiAlertSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700970B RID: 38667
		// (get) Token: 0x0602152B RID: 136491 RVA: 0x00498F34 File Offset: 0x00497134
		public int AreaId
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

		// Token: 0x1700970C RID: 38668
		// (get) Token: 0x0602152C RID: 136492 RVA: 0x00498F70 File Offset: 0x00497170
		public float PlayerHatredDeltaValue
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

		// Token: 0x1700970D RID: 38669
		// (get) Token: 0x0602152D RID: 136493 RVA: 0x00498FB0 File Offset: 0x004971B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602152E RID: 136494 RVA: 0x00498FEC File Offset: 0x004971EC
		public static Offset<IAiAlertSystemConfig> CreateIAiAlertSystemConfig(FlatBufferBuilder builder, int AreaId = 0, float PlayerHatredDeltaValue = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IAiAlertSystemConfig.AddPlayerHatredDeltaValue(builder, PlayerHatredDeltaValue);
			IAiAlertSystemConfig.AddAreaId(builder, AreaId);
			IAiAlertSystemConfig.AddNullMask(builder, NullMask);
			return IAiAlertSystemConfig.EndIAiAlertSystemConfig(builder);
		}

		// Token: 0x0602152F RID: 136495 RVA: 0x00499010 File Offset: 0x00497210
		public static void StartIAiAlertSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021530 RID: 136496 RVA: 0x00499019 File Offset: 0x00497219
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(0, areaId, 0);
		}

		// Token: 0x06021531 RID: 136497 RVA: 0x00499024 File Offset: 0x00497224
		public static void AddPlayerHatredDeltaValue(FlatBufferBuilder builder, float playerHatredDeltaValue)
		{
			builder.AddFloat(1, playerHatredDeltaValue, 0.0);
		}

		// Token: 0x06021532 RID: 136498 RVA: 0x00499037 File Offset: 0x00497237
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021533 RID: 136499 RVA: 0x00499042 File Offset: 0x00497242
		public static Offset<IAiAlertSystemConfig> EndIAiAlertSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAiAlertSystemConfig>(builder.EndTable());
		}

		// Token: 0x06021534 RID: 136500 RVA: 0x00499050 File Offset: 0x00497250
		public IAiAlertSystemConfigT UnPack()
		{
			IAiAlertSystemConfigT aiAlertSystemConfigT = new IAiAlertSystemConfigT();
			this.UnPackTo(aiAlertSystemConfigT);
			return aiAlertSystemConfigT;
		}

		// Token: 0x06021535 RID: 136501 RVA: 0x0049906B File Offset: 0x0049726B
		public void UnPackTo(IAiAlertSystemConfigT _o)
		{
			_o.AreaId = this.AreaId;
			_o.PlayerHatredDeltaValue = this.PlayerHatredDeltaValue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021536 RID: 136502 RVA: 0x00499094 File Offset: 0x00497294
		public static Offset<IAiAlertSystemConfig> Pack(FlatBufferBuilder builder, IAiAlertSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiAlertSystemConfig>);
			}
			return IAiAlertSystemConfig.CreateIAiAlertSystemConfig(builder, _o.AreaId, _o.PlayerHatredDeltaValue, _o.NullMask);
		}

		// Token: 0x0400E79E RID: 59294
		private Table __p;
	}
}
