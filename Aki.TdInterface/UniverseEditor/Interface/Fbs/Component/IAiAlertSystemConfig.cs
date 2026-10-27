using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E74 RID: 20084
	public struct IAiAlertSystemConfig : IFlatbufferObject
	{
		// Token: 0x17008FD1 RID: 36817
		// (get) Token: 0x0601F8DA RID: 129242 RVA: 0x00464EAD File Offset: 0x004630AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F8DB RID: 129243 RVA: 0x00464EBA File Offset: 0x004630BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F8DC RID: 129244 RVA: 0x00464EC4 File Offset: 0x004630C4
		public static IAiAlertSystemConfig GetRootAsIAiAlertSystemConfig(ByteBuffer _bb)
		{
			return IAiAlertSystemConfig.GetRootAsIAiAlertSystemConfig(_bb, default(IAiAlertSystemConfig));
		}

		// Token: 0x0601F8DD RID: 129245 RVA: 0x00464EE0 File Offset: 0x004630E0
		public static IAiAlertSystemConfig GetRootAsIAiAlertSystemConfig(ByteBuffer _bb, IAiAlertSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F8DE RID: 129246 RVA: 0x00464EFD File Offset: 0x004630FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F8DF RID: 129247 RVA: 0x00464F0C File Offset: 0x0046310C
		public IAiAlertSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FD2 RID: 36818
		// (get) Token: 0x0601F8E0 RID: 129248 RVA: 0x00464F1C File Offset: 0x0046311C
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

		// Token: 0x17008FD3 RID: 36819
		// (get) Token: 0x0601F8E1 RID: 129249 RVA: 0x00464F58 File Offset: 0x00463158
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

		// Token: 0x17008FD4 RID: 36820
		// (get) Token: 0x0601F8E2 RID: 129250 RVA: 0x00464F98 File Offset: 0x00463198
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

		// Token: 0x0601F8E3 RID: 129251 RVA: 0x00464FD4 File Offset: 0x004631D4
		public static Offset<IAiAlertSystemConfig> CreateIAiAlertSystemConfig(FlatBufferBuilder builder, int AreaId = 0, float PlayerHatredDeltaValue = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IAiAlertSystemConfig.AddPlayerHatredDeltaValue(builder, PlayerHatredDeltaValue);
			IAiAlertSystemConfig.AddAreaId(builder, AreaId);
			IAiAlertSystemConfig.AddNullMask(builder, NullMask);
			return IAiAlertSystemConfig.EndIAiAlertSystemConfig(builder);
		}

		// Token: 0x0601F8E4 RID: 129252 RVA: 0x00464FF8 File Offset: 0x004631F8
		public static void StartIAiAlertSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F8E5 RID: 129253 RVA: 0x00465001 File Offset: 0x00463201
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(0, areaId, 0);
		}

		// Token: 0x0601F8E6 RID: 129254 RVA: 0x0046500C File Offset: 0x0046320C
		public static void AddPlayerHatredDeltaValue(FlatBufferBuilder builder, float playerHatredDeltaValue)
		{
			builder.AddFloat(1, playerHatredDeltaValue, 0.0);
		}

		// Token: 0x0601F8E7 RID: 129255 RVA: 0x0046501F File Offset: 0x0046321F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601F8E8 RID: 129256 RVA: 0x0046502A File Offset: 0x0046322A
		public static Offset<IAiAlertSystemConfig> EndIAiAlertSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAiAlertSystemConfig>(builder.EndTable());
		}

		// Token: 0x0601F8E9 RID: 129257 RVA: 0x00465038 File Offset: 0x00463238
		public IAiAlertSystemConfigT UnPack()
		{
			IAiAlertSystemConfigT aiAlertSystemConfigT = new IAiAlertSystemConfigT();
			this.UnPackTo(aiAlertSystemConfigT);
			return aiAlertSystemConfigT;
		}

		// Token: 0x0601F8EA RID: 129258 RVA: 0x00465053 File Offset: 0x00463253
		public void UnPackTo(IAiAlertSystemConfigT _o)
		{
			_o.AreaId = this.AreaId;
			_o.PlayerHatredDeltaValue = this.PlayerHatredDeltaValue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F8EB RID: 129259 RVA: 0x0046507C File Offset: 0x0046327C
		public static Offset<IAiAlertSystemConfig> Pack(FlatBufferBuilder builder, IAiAlertSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiAlertSystemConfig>);
			}
			return IAiAlertSystemConfig.CreateIAiAlertSystemConfig(builder, _o.AreaId, _o.PlayerHatredDeltaValue, _o.NullMask);
		}

		// Token: 0x0400DC24 RID: 56356
		private Table __p;
	}
}
