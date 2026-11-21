using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF7 RID: 23543
	public struct INpcSpecialMarkTriggerBlueprintFootprintEvent : IFlatbufferObject
	{
		// Token: 0x1700AC3C RID: 44092
		// (get) Token: 0x06026E0A RID: 159242 RVA: 0x005526B1 File Offset: 0x005508B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E0B RID: 159243 RVA: 0x005526BE File Offset: 0x005508BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E0C RID: 159244 RVA: 0x005526C8 File Offset: 0x005508C8
		public static INpcSpecialMarkTriggerBlueprintFootprintEvent GetRootAsINpcSpecialMarkTriggerBlueprintFootprintEvent(ByteBuffer _bb)
		{
			return INpcSpecialMarkTriggerBlueprintFootprintEvent.GetRootAsINpcSpecialMarkTriggerBlueprintFootprintEvent(_bb, default(INpcSpecialMarkTriggerBlueprintFootprintEvent));
		}

		// Token: 0x06026E0D RID: 159245 RVA: 0x005526E4 File Offset: 0x005508E4
		public static INpcSpecialMarkTriggerBlueprintFootprintEvent GetRootAsINpcSpecialMarkTriggerBlueprintFootprintEvent(ByteBuffer _bb, INpcSpecialMarkTriggerBlueprintFootprintEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E0E RID: 159246 RVA: 0x00552701 File Offset: 0x00550901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E0F RID: 159247 RVA: 0x00552710 File Offset: 0x00550910
		public INpcSpecialMarkTriggerBlueprintFootprintEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC3D RID: 44093
		// (get) Token: 0x06026E10 RID: 159248 RVA: 0x00552720 File Offset: 0x00550920
		public ESpecialNpcMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcMarkType.TrafficLight;
				}
				return (ESpecialNpcMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC3E RID: 44094
		// (get) Token: 0x06026E11 RID: 159249 RVA: 0x0055275C File Offset: 0x0055095C
		public string ConfigDa
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

		// Token: 0x06026E12 RID: 159250 RVA: 0x00552793 File Offset: 0x00550993
		public Span<byte> GetConfigDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026E13 RID: 159251 RVA: 0x005527A2 File Offset: 0x005509A2
		public byte[] GetConfigDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026E14 RID: 159252 RVA: 0x005527B0 File Offset: 0x005509B0
		public static Offset<INpcSpecialMarkTriggerBlueprintFootprintEvent> CreateINpcSpecialMarkTriggerBlueprintFootprintEvent(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight, StringOffset ConfigDaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcSpecialMarkTriggerBlueprintFootprintEvent.AddConfigDa(builder, ConfigDaOffset);
			INpcSpecialMarkTriggerBlueprintFootprintEvent.AddType(builder, Type);
			return INpcSpecialMarkTriggerBlueprintFootprintEvent.EndINpcSpecialMarkTriggerBlueprintFootprintEvent(builder);
		}

		// Token: 0x06026E15 RID: 159253 RVA: 0x005527CD File Offset: 0x005509CD
		public static void StartINpcSpecialMarkTriggerBlueprintFootprintEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026E16 RID: 159254 RVA: 0x005527D6 File Offset: 0x005509D6
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026E17 RID: 159255 RVA: 0x005527E1 File Offset: 0x005509E1
		public static void AddConfigDa(FlatBufferBuilder builder, StringOffset configDaOffset)
		{
			builder.AddOffset(1, configDaOffset.Value, 0);
		}

		// Token: 0x06026E18 RID: 159256 RVA: 0x005527F1 File Offset: 0x005509F1
		public static Offset<INpcSpecialMarkTriggerBlueprintFootprintEvent> EndINpcSpecialMarkTriggerBlueprintFootprintEvent(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkTriggerBlueprintFootprintEvent>(builder.EndTable());
		}

		// Token: 0x06026E19 RID: 159257 RVA: 0x00552800 File Offset: 0x00550A00
		public INpcSpecialMarkTriggerBlueprintFootprintEventT UnPack()
		{
			INpcSpecialMarkTriggerBlueprintFootprintEventT npcSpecialMarkTriggerBlueprintFootprintEventT = new INpcSpecialMarkTriggerBlueprintFootprintEventT();
			this.UnPackTo(npcSpecialMarkTriggerBlueprintFootprintEventT);
			return npcSpecialMarkTriggerBlueprintFootprintEventT;
		}

		// Token: 0x06026E1A RID: 159258 RVA: 0x0055281B File Offset: 0x00550A1B
		public void UnPackTo(INpcSpecialMarkTriggerBlueprintFootprintEventT _o)
		{
			_o.Type = this.Type;
			_o.ConfigDa = this.ConfigDa;
		}

		// Token: 0x06026E1B RID: 159259 RVA: 0x00552838 File Offset: 0x00550A38
		public static Offset<INpcSpecialMarkTriggerBlueprintFootprintEvent> Pack(FlatBufferBuilder builder, INpcSpecialMarkTriggerBlueprintFootprintEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkTriggerBlueprintFootprintEvent>);
			}
			StringOffset configDaOffset = (_o.ConfigDa == null) ? default(StringOffset) : builder.CreateString(_o.ConfigDa);
			return INpcSpecialMarkTriggerBlueprintFootprintEvent.CreateINpcSpecialMarkTriggerBlueprintFootprintEvent(builder, _o.Type, configDaOffset);
		}

		// Token: 0x0400F66D RID: 63085
		private Table __p;
	}
}
