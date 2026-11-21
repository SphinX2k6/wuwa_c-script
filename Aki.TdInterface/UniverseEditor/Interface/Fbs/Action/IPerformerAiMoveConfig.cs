using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E2 RID: 29666
	public struct IPerformerAiMoveConfig : IFlatbufferObject
	{
		// Token: 0x1700D9F1 RID: 55793
		// (get) Token: 0x06033E55 RID: 212565 RVA: 0x006FF676 File Offset: 0x006FD876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E56 RID: 212566 RVA: 0x006FF683 File Offset: 0x006FD883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E57 RID: 212567 RVA: 0x006FF68C File Offset: 0x006FD88C
		public static IPerformerAiMoveConfig GetRootAsIPerformerAiMoveConfig(ByteBuffer _bb)
		{
			return IPerformerAiMoveConfig.GetRootAsIPerformerAiMoveConfig(_bb, default(IPerformerAiMoveConfig));
		}

		// Token: 0x06033E58 RID: 212568 RVA: 0x006FF6A8 File Offset: 0x006FD8A8
		public static IPerformerAiMoveConfig GetRootAsIPerformerAiMoveConfig(ByteBuffer _bb, IPerformerAiMoveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E59 RID: 212569 RVA: 0x006FF6C5 File Offset: 0x006FD8C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E5A RID: 212570 RVA: 0x006FF6D4 File Offset: 0x006FD8D4
		public IPerformerAiMoveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9F2 RID: 55794
		// (get) Token: 0x06033E5B RID: 212571 RVA: 0x006FF6E4 File Offset: 0x006FD8E4
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033E5C RID: 212572 RVA: 0x006FF720 File Offset: 0x006FD920
		public static Offset<IPerformerAiMoveConfig> CreateIPerformerAiMoveConfig(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position)
		{
			builder.StartTable(1);
			IPerformerAiMoveConfig.AddType(builder, Type);
			return IPerformerAiMoveConfig.EndIPerformerAiMoveConfig(builder);
		}

		// Token: 0x06033E5D RID: 212573 RVA: 0x006FF736 File Offset: 0x006FD936
		public static void StartIPerformerAiMoveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033E5E RID: 212574 RVA: 0x006FF73F File Offset: 0x006FD93F
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E5F RID: 212575 RVA: 0x006FF74A File Offset: 0x006FD94A
		public static Offset<IPerformerAiMoveConfig> EndIPerformerAiMoveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveConfig>(builder.EndTable());
		}

		// Token: 0x06033E60 RID: 212576 RVA: 0x006FF758 File Offset: 0x006FD958
		public IPerformerAiMoveConfigT UnPack()
		{
			IPerformerAiMoveConfigT performerAiMoveConfigT = new IPerformerAiMoveConfigT();
			this.UnPackTo(performerAiMoveConfigT);
			return performerAiMoveConfigT;
		}

		// Token: 0x06033E61 RID: 212577 RVA: 0x006FF773 File Offset: 0x006FD973
		public void UnPackTo(IPerformerAiMoveConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033E62 RID: 212578 RVA: 0x006FF784 File Offset: 0x006FD984
		public static Offset<IPerformerAiMoveConfig> Pack(FlatBufferBuilder builder, IPerformerAiMoveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveConfig>);
			}
			return IPerformerAiMoveConfig.CreateIPerformerAiMoveConfig(builder, _o.Type);
		}

		// Token: 0x04012523 RID: 75043
		private Table __p;
	}
}
