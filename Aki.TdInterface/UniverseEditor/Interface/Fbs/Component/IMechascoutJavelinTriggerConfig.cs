using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABF RID: 23231
	public struct IMechascoutJavelinTriggerConfig : IFlatbufferObject
	{
		// Token: 0x1700A94B RID: 43339
		// (get) Token: 0x06026175 RID: 156021 RVA: 0x00537E19 File Offset: 0x00536019
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026176 RID: 156022 RVA: 0x00537E26 File Offset: 0x00536026
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026177 RID: 156023 RVA: 0x00537E30 File Offset: 0x00536030
		public static IMechascoutJavelinTriggerConfig GetRootAsIMechascoutJavelinTriggerConfig(ByteBuffer _bb)
		{
			return IMechascoutJavelinTriggerConfig.GetRootAsIMechascoutJavelinTriggerConfig(_bb, default(IMechascoutJavelinTriggerConfig));
		}

		// Token: 0x06026178 RID: 156024 RVA: 0x00537E4C File Offset: 0x0053604C
		public static IMechascoutJavelinTriggerConfig GetRootAsIMechascoutJavelinTriggerConfig(ByteBuffer _bb, IMechascoutJavelinTriggerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026179 RID: 156025 RVA: 0x00537E69 File Offset: 0x00536069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602617A RID: 156026 RVA: 0x00537E78 File Offset: 0x00536078
		public IMechascoutJavelinTriggerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A94C RID: 43340
		// (get) Token: 0x0602617B RID: 156027 RVA: 0x00537E88 File Offset: 0x00536088
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

		// Token: 0x0602617C RID: 156028 RVA: 0x00537EC4 File Offset: 0x005360C4
		public static Offset<IMechascoutJavelinTriggerConfig> CreateIMechascoutJavelinTriggerConfig(FlatBufferBuilder builder, ETeleCtrlTriggerType Type = ETeleCtrlTriggerType.MechascoutJavelin)
		{
			builder.StartTable(1);
			IMechascoutJavelinTriggerConfig.AddType(builder, Type);
			return IMechascoutJavelinTriggerConfig.EndIMechascoutJavelinTriggerConfig(builder);
		}

		// Token: 0x0602617D RID: 156029 RVA: 0x00537EDA File Offset: 0x005360DA
		public static void StartIMechascoutJavelinTriggerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602617E RID: 156030 RVA: 0x00537EE3 File Offset: 0x005360E3
		public static void AddType(FlatBufferBuilder builder, ETeleCtrlTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602617F RID: 156031 RVA: 0x00537EEE File Offset: 0x005360EE
		public static Offset<IMechascoutJavelinTriggerConfig> EndIMechascoutJavelinTriggerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutJavelinTriggerConfig>(builder.EndTable());
		}

		// Token: 0x06026180 RID: 156032 RVA: 0x00537EFC File Offset: 0x005360FC
		public IMechascoutJavelinTriggerConfigT UnPack()
		{
			IMechascoutJavelinTriggerConfigT mechascoutJavelinTriggerConfigT = new IMechascoutJavelinTriggerConfigT();
			this.UnPackTo(mechascoutJavelinTriggerConfigT);
			return mechascoutJavelinTriggerConfigT;
		}

		// Token: 0x06026181 RID: 156033 RVA: 0x00537F17 File Offset: 0x00536117
		public void UnPackTo(IMechascoutJavelinTriggerConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026182 RID: 156034 RVA: 0x00537F28 File Offset: 0x00536128
		public static Offset<IMechascoutJavelinTriggerConfig> Pack(FlatBufferBuilder builder, IMechascoutJavelinTriggerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutJavelinTriggerConfig>);
			}
			return IMechascoutJavelinTriggerConfig.CreateIMechascoutJavelinTriggerConfig(builder, _o.Type);
		}

		// Token: 0x0400F469 RID: 62569
		private Table __p;
	}
}
