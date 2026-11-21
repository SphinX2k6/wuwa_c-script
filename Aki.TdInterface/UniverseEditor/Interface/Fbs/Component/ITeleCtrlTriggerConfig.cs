using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006053 RID: 24659
	public struct ITeleCtrlTriggerConfig : IFlatbufferObject
	{
		// Token: 0x1700B711 RID: 46865
		// (get) Token: 0x06029A3C RID: 170556 RVA: 0x005AF5AE File Offset: 0x005AD7AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A3D RID: 170557 RVA: 0x005AF5BB File Offset: 0x005AD7BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A3E RID: 170558 RVA: 0x005AF5C4 File Offset: 0x005AD7C4
		public static ITeleCtrlTriggerConfig GetRootAsITeleCtrlTriggerConfig(ByteBuffer _bb)
		{
			return ITeleCtrlTriggerConfig.GetRootAsITeleCtrlTriggerConfig(_bb, default(ITeleCtrlTriggerConfig));
		}

		// Token: 0x06029A3F RID: 170559 RVA: 0x005AF5E0 File Offset: 0x005AD7E0
		public static ITeleCtrlTriggerConfig GetRootAsITeleCtrlTriggerConfig(ByteBuffer _bb, ITeleCtrlTriggerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A40 RID: 170560 RVA: 0x005AF5FD File Offset: 0x005AD7FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A41 RID: 170561 RVA: 0x005AF60C File Offset: 0x005AD80C
		public ITeleCtrlTriggerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B712 RID: 46866
		// (get) Token: 0x06029A42 RID: 170562 RVA: 0x005AF61C File Offset: 0x005AD81C
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

		// Token: 0x06029A43 RID: 170563 RVA: 0x005AF658 File Offset: 0x005AD858
		public static Offset<ITeleCtrlTriggerConfig> CreateITeleCtrlTriggerConfig(FlatBufferBuilder builder, ETeleCtrlTriggerType Type = ETeleCtrlTriggerType.MechascoutJavelin)
		{
			builder.StartTable(1);
			ITeleCtrlTriggerConfig.AddType(builder, Type);
			return ITeleCtrlTriggerConfig.EndITeleCtrlTriggerConfig(builder);
		}

		// Token: 0x06029A44 RID: 170564 RVA: 0x005AF66E File Offset: 0x005AD86E
		public static void StartITeleCtrlTriggerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029A45 RID: 170565 RVA: 0x005AF677 File Offset: 0x005AD877
		public static void AddType(FlatBufferBuilder builder, ETeleCtrlTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029A46 RID: 170566 RVA: 0x005AF682 File Offset: 0x005AD882
		public static Offset<ITeleCtrlTriggerConfig> EndITeleCtrlTriggerConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeleCtrlTriggerConfig>(builder.EndTable());
		}

		// Token: 0x06029A47 RID: 170567 RVA: 0x005AF690 File Offset: 0x005AD890
		public ITeleCtrlTriggerConfigT UnPack()
		{
			ITeleCtrlTriggerConfigT teleCtrlTriggerConfigT = new ITeleCtrlTriggerConfigT();
			this.UnPackTo(teleCtrlTriggerConfigT);
			return teleCtrlTriggerConfigT;
		}

		// Token: 0x06029A48 RID: 170568 RVA: 0x005AF6AB File Offset: 0x005AD8AB
		public void UnPackTo(ITeleCtrlTriggerConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029A49 RID: 170569 RVA: 0x005AF6BC File Offset: 0x005AD8BC
		public static Offset<ITeleCtrlTriggerConfig> Pack(FlatBufferBuilder builder, ITeleCtrlTriggerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleCtrlTriggerConfig>);
			}
			return ITeleCtrlTriggerConfig.CreateITeleCtrlTriggerConfig(builder, _o.Type);
		}

		// Token: 0x0400FDBD RID: 64957
		private Table __p;
	}
}
