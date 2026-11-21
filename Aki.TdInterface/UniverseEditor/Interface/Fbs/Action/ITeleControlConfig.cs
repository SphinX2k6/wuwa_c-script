using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B57 RID: 31575
	public struct ITeleControlConfig : IFlatbufferObject
	{
		// Token: 0x1700EC69 RID: 60521
		// (get) Token: 0x06038DB9 RID: 232889 RVA: 0x007AFEBE File Offset: 0x007AE0BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038DBA RID: 232890 RVA: 0x007AFECB File Offset: 0x007AE0CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038DBB RID: 232891 RVA: 0x007AFED4 File Offset: 0x007AE0D4
		public static ITeleControlConfig GetRootAsITeleControlConfig(ByteBuffer _bb)
		{
			return ITeleControlConfig.GetRootAsITeleControlConfig(_bb, default(ITeleControlConfig));
		}

		// Token: 0x06038DBC RID: 232892 RVA: 0x007AFEF0 File Offset: 0x007AE0F0
		public static ITeleControlConfig GetRootAsITeleControlConfig(ByteBuffer _bb, ITeleControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038DBD RID: 232893 RVA: 0x007AFF0D File Offset: 0x007AE10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038DBE RID: 232894 RVA: 0x007AFF1C File Offset: 0x007AE11C
		public ITeleControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC6A RID: 60522
		// (get) Token: 0x06038DBF RID: 232895 RVA: 0x007AFF2C File Offset: 0x007AE12C
		public EExploreStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreStateType.TeleControl;
				}
				return (EExploreStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC6B RID: 60523
		// (get) Token: 0x06038DC0 RID: 232896 RVA: 0x007AFF68 File Offset: 0x007AE168
		public ETeleControlType TeleControlType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETeleControlType.BigWorld;
				}
				return (ETeleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038DC1 RID: 232897 RVA: 0x007AFFA4 File Offset: 0x007AE1A4
		public static Offset<ITeleControlConfig> CreateITeleControlConfig(FlatBufferBuilder builder, EExploreStateType Type = EExploreStateType.TeleControl, ETeleControlType TeleControlType = ETeleControlType.BigWorld)
		{
			builder.StartTable(2);
			ITeleControlConfig.AddTeleControlType(builder, TeleControlType);
			ITeleControlConfig.AddType(builder, Type);
			return ITeleControlConfig.EndITeleControlConfig(builder);
		}

		// Token: 0x06038DC2 RID: 232898 RVA: 0x007AFFC1 File Offset: 0x007AE1C1
		public static void StartITeleControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038DC3 RID: 232899 RVA: 0x007AFFCA File Offset: 0x007AE1CA
		public static void AddType(FlatBufferBuilder builder, EExploreStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038DC4 RID: 232900 RVA: 0x007AFFD5 File Offset: 0x007AE1D5
		public static void AddTeleControlType(FlatBufferBuilder builder, ETeleControlType teleControlType)
		{
			builder.AddByte(1, (byte)teleControlType, 0);
		}

		// Token: 0x06038DC5 RID: 232901 RVA: 0x007AFFE0 File Offset: 0x007AE1E0
		public static Offset<ITeleControlConfig> EndITeleControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControlConfig>(builder.EndTable());
		}

		// Token: 0x06038DC6 RID: 232902 RVA: 0x007AFFF0 File Offset: 0x007AE1F0
		public ITeleControlConfigT UnPack()
		{
			ITeleControlConfigT teleControlConfigT = new ITeleControlConfigT();
			this.UnPackTo(teleControlConfigT);
			return teleControlConfigT;
		}

		// Token: 0x06038DC7 RID: 232903 RVA: 0x007B000B File Offset: 0x007AE20B
		public void UnPackTo(ITeleControlConfigT _o)
		{
			_o.Type = this.Type;
			_o.TeleControlType = this.TeleControlType;
		}

		// Token: 0x06038DC8 RID: 232904 RVA: 0x007B0028 File Offset: 0x007AE228
		public static Offset<ITeleControlConfig> Pack(FlatBufferBuilder builder, ITeleControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControlConfig>);
			}
			return ITeleControlConfig.CreateITeleControlConfig(builder, _o.Type, _o.TeleControlType);
		}

		// Token: 0x04013198 RID: 78232
		private Table __p;
	}
}
