using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B2 RID: 16562
	public struct IRogueRandomEvent : IFlatbufferObject
	{
		// Token: 0x170074E4 RID: 29924
		// (get) Token: 0x060181FF RID: 98815 RVA: 0x0037A500 File Offset: 0x00378700
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018200 RID: 98816 RVA: 0x0037A50D File Offset: 0x0037870D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018201 RID: 98817 RVA: 0x0037A514 File Offset: 0x00378714
		public static IRogueRandomEvent GetRootAsIRogueRandomEvent(ByteBuffer _bb)
		{
			return IRogueRandomEvent.GetRootAsIRogueRandomEvent(_bb, default(IRogueRandomEvent));
		}

		// Token: 0x06018202 RID: 98818 RVA: 0x0037A530 File Offset: 0x00378730
		public static IRogueRandomEvent GetRootAsIRogueRandomEvent(ByteBuffer _bb, IRogueRandomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018203 RID: 98819 RVA: 0x0037A54D File Offset: 0x0037874D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018204 RID: 98820 RVA: 0x0037A55C File Offset: 0x0037875C
		public IRogueRandomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074E5 RID: 29925
		// (get) Token: 0x06018205 RID: 98821 RVA: 0x0037A56C File Offset: 0x0037876C
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018206 RID: 98822 RVA: 0x0037A5A8 File Offset: 0x003787A8
		public static Offset<IRogueRandomEvent> CreateIRogueRandomEvent(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IRogueRandomEvent.AddType(builder, Type);
			return IRogueRandomEvent.EndIRogueRandomEvent(builder);
		}

		// Token: 0x06018207 RID: 98823 RVA: 0x0037A5BE File Offset: 0x003787BE
		public static void StartIRogueRandomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018208 RID: 98824 RVA: 0x0037A5C7 File Offset: 0x003787C7
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018209 RID: 98825 RVA: 0x0037A5D2 File Offset: 0x003787D2
		public static Offset<IRogueRandomEvent> EndIRogueRandomEvent(FlatBufferBuilder builder)
		{
			return new Offset<IRogueRandomEvent>(builder.EndTable());
		}

		// Token: 0x0601820A RID: 98826 RVA: 0x0037A5E0 File Offset: 0x003787E0
		public IRogueRandomEventT UnPack()
		{
			IRogueRandomEventT rogueRandomEventT = new IRogueRandomEventT();
			this.UnPackTo(rogueRandomEventT);
			return rogueRandomEventT;
		}

		// Token: 0x0601820B RID: 98827 RVA: 0x0037A5FB File Offset: 0x003787FB
		public void UnPackTo(IRogueRandomEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601820C RID: 98828 RVA: 0x0037A60C File Offset: 0x0037880C
		public static Offset<IRogueRandomEvent> Pack(FlatBufferBuilder builder, IRogueRandomEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueRandomEvent>);
			}
			return IRogueRandomEvent.CreateIRogueRandomEvent(builder, _o.Type);
		}

		// Token: 0x0400BC4A RID: 48202
		private Table __p;
	}
}
