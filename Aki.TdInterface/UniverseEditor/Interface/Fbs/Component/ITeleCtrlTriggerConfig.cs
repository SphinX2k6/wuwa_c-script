using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A46 RID: 23110
	public struct ITeleCtrlTriggerConfig : IFlatbufferObject
	{
		// Token: 0x1700ADD9 RID: 44505
		// (get) Token: 0x060274C4 RID: 160964 RVA: 0x005685A2 File Offset: 0x005667A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274C5 RID: 160965 RVA: 0x005685AF File Offset: 0x005667AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274C6 RID: 160966 RVA: 0x005685B8 File Offset: 0x005667B8
		public static ITeleCtrlTriggerConfig GetRootAsITeleCtrlTriggerConfig(ByteBuffer _bb)
		{
			return ITeleCtrlTriggerConfig.GetRootAsITeleCtrlTriggerConfig(_bb, default(ITeleCtrlTriggerConfig));
		}

		// Token: 0x060274C7 RID: 160967 RVA: 0x005685D4 File Offset: 0x005667D4
		public static ITeleCtrlTriggerConfig GetRootAsITeleCtrlTriggerConfig(ByteBuffer _bb, ITeleCtrlTriggerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274C8 RID: 160968 RVA: 0x005685F1 File Offset: 0x005667F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274C9 RID: 160969 RVA: 0x00568600 File Offset: 0x00566800
		public ITeleCtrlTriggerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADDA RID: 44506
		// (get) Token: 0x060274CA RID: 160970 RVA: 0x00568610 File Offset: 0x00566810
		public ETeleCtrlTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleCtrlTriggerType.MechascoutJavelin;
				}
				return (ETeleCtrlTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060274CB RID: 160971 RVA: 0x0056864C File Offset: 0x0056684C
		public static Offset<ITeleCtrlTriggerConfig> CreateITeleCtrlTriggerConfig(FlatBufferBuilder builder, ETeleCtrlTriggerType Type = ETeleCtrlTriggerType.MechascoutJavelin)
		{
			builder.StartTable(1);
			ITeleCtrlTriggerConfig.AddType(builder, Type);
			return ITeleCtrlTriggerConfig.EndITeleCtrlTriggerConfig(builder);
		}

		// Token: 0x060274CC RID: 160972 RVA: 0x00568662 File Offset: 0x00566862
		public static void StartITeleCtrlTriggerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060274CD RID: 160973 RVA: 0x0056866B File Offset: 0x0056686B
		public static void AddType(FlatBufferBuilder builder, ETeleCtrlTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060274CE RID: 160974 RVA: 0x00568676 File Offset: 0x00566876
		public static Offset<ITeleCtrlTriggerConfig> EndITeleCtrlTriggerConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeleCtrlTriggerConfig>(builder.EndTable());
		}

		// Token: 0x060274CF RID: 160975 RVA: 0x00568684 File Offset: 0x00566884
		public ITeleCtrlTriggerConfigT UnPack()
		{
			ITeleCtrlTriggerConfigT teleCtrlTriggerConfigT = new ITeleCtrlTriggerConfigT();
			this.UnPackTo(teleCtrlTriggerConfigT);
			return teleCtrlTriggerConfigT;
		}

		// Token: 0x060274D0 RID: 160976 RVA: 0x0056869F File Offset: 0x0056689F
		public void UnPackTo(ITeleCtrlTriggerConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060274D1 RID: 160977 RVA: 0x005686B0 File Offset: 0x005668B0
		public static Offset<ITeleCtrlTriggerConfig> Pack(FlatBufferBuilder builder, ITeleCtrlTriggerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleCtrlTriggerConfig>);
			}
			return ITeleCtrlTriggerConfig.CreateITeleCtrlTriggerConfig(builder, _o.Type);
		}

		// Token: 0x0400F0C6 RID: 61638
		private Table __p;
	}
}
