using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200604D RID: 24653
	public struct ITeleControlDestroyCondition : IFlatbufferObject
	{
		// Token: 0x1700B70C RID: 46860
		// (get) Token: 0x06029A1A RID: 170522 RVA: 0x005AF2AC File Offset: 0x005AD4AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A1B RID: 170523 RVA: 0x005AF2B9 File Offset: 0x005AD4B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A1C RID: 170524 RVA: 0x005AF2C0 File Offset: 0x005AD4C0
		public static ITeleControlDestroyCondition GetRootAsITeleControlDestroyCondition(ByteBuffer _bb)
		{
			return ITeleControlDestroyCondition.GetRootAsITeleControlDestroyCondition(_bb, default(ITeleControlDestroyCondition));
		}

		// Token: 0x06029A1D RID: 170525 RVA: 0x005AF2DC File Offset: 0x005AD4DC
		public static ITeleControlDestroyCondition GetRootAsITeleControlDestroyCondition(ByteBuffer _bb, ITeleControlDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A1E RID: 170526 RVA: 0x005AF2F9 File Offset: 0x005AD4F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A1F RID: 170527 RVA: 0x005AF308 File Offset: 0x005AD508
		public ITeleControlDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B70D RID: 46861
		// (get) Token: 0x06029A20 RID: 170528 RVA: 0x005AF318 File Offset: 0x005AD518
		public ETeleControlDestroyCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return (ETeleControlDestroyCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029A21 RID: 170529 RVA: 0x005AF354 File Offset: 0x005AD554
		public static Offset<ITeleControlDestroyCondition> CreateITeleControlDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo)
		{
			builder.StartTable(1);
			ITeleControlDestroyCondition.AddType(builder, Type);
			return ITeleControlDestroyCondition.EndITeleControlDestroyCondition(builder);
		}

		// Token: 0x06029A22 RID: 170530 RVA: 0x005AF36A File Offset: 0x005AD56A
		public static void StartITeleControlDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029A23 RID: 170531 RVA: 0x005AF373 File Offset: 0x005AD573
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029A24 RID: 170532 RVA: 0x005AF37E File Offset: 0x005AD57E
		public static Offset<ITeleControlDestroyCondition> EndITeleControlDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControlDestroyCondition>(builder.EndTable());
		}

		// Token: 0x06029A25 RID: 170533 RVA: 0x005AF38C File Offset: 0x005AD58C
		public ITeleControlDestroyConditionT UnPack()
		{
			ITeleControlDestroyConditionT teleControlDestroyConditionT = new ITeleControlDestroyConditionT();
			this.UnPackTo(teleControlDestroyConditionT);
			return teleControlDestroyConditionT;
		}

		// Token: 0x06029A26 RID: 170534 RVA: 0x005AF3A7 File Offset: 0x005AD5A7
		public void UnPackTo(ITeleControlDestroyConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029A27 RID: 170535 RVA: 0x005AF3B8 File Offset: 0x005AD5B8
		public static Offset<ITeleControlDestroyCondition> Pack(FlatBufferBuilder builder, ITeleControlDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControlDestroyCondition>);
			}
			return ITeleControlDestroyCondition.CreateITeleControlDestroyCondition(builder, _o.Type);
		}

		// Token: 0x0400FDB3 RID: 64947
		private Table __p;
	}
}
