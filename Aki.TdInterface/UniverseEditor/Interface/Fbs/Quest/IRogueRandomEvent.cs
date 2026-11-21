using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F3 RID: 17651
	public struct IRogueRandomEvent : IFlatbufferObject
	{
		// Token: 0x17007AEA RID: 31466
		// (get) Token: 0x060198A0 RID: 104608 RVA: 0x003A4450 File Offset: 0x003A2650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198A1 RID: 104609 RVA: 0x003A445D File Offset: 0x003A265D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198A2 RID: 104610 RVA: 0x003A4464 File Offset: 0x003A2664
		public static IRogueRandomEvent GetRootAsIRogueRandomEvent(ByteBuffer _bb)
		{
			return IRogueRandomEvent.GetRootAsIRogueRandomEvent(_bb, default(IRogueRandomEvent));
		}

		// Token: 0x060198A3 RID: 104611 RVA: 0x003A4480 File Offset: 0x003A2680
		public static IRogueRandomEvent GetRootAsIRogueRandomEvent(ByteBuffer _bb, IRogueRandomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198A4 RID: 104612 RVA: 0x003A449D File Offset: 0x003A269D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198A5 RID: 104613 RVA: 0x003A44AC File Offset: 0x003A26AC
		public IRogueRandomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AEB RID: 31467
		// (get) Token: 0x060198A6 RID: 104614 RVA: 0x003A44BC File Offset: 0x003A26BC
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

		// Token: 0x060198A7 RID: 104615 RVA: 0x003A44F8 File Offset: 0x003A26F8
		public static Offset<IRogueRandomEvent> CreateIRogueRandomEvent(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IRogueRandomEvent.AddType(builder, Type);
			return IRogueRandomEvent.EndIRogueRandomEvent(builder);
		}

		// Token: 0x060198A8 RID: 104616 RVA: 0x003A450E File Offset: 0x003A270E
		public static void StartIRogueRandomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060198A9 RID: 104617 RVA: 0x003A4517 File Offset: 0x003A2717
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060198AA RID: 104618 RVA: 0x003A4522 File Offset: 0x003A2722
		public static Offset<IRogueRandomEvent> EndIRogueRandomEvent(FlatBufferBuilder builder)
		{
			return new Offset<IRogueRandomEvent>(builder.EndTable());
		}

		// Token: 0x060198AB RID: 104619 RVA: 0x003A4530 File Offset: 0x003A2730
		public IRogueRandomEventT UnPack()
		{
			IRogueRandomEventT rogueRandomEventT = new IRogueRandomEventT();
			this.UnPackTo(rogueRandomEventT);
			return rogueRandomEventT;
		}

		// Token: 0x060198AC RID: 104620 RVA: 0x003A454B File Offset: 0x003A274B
		public void UnPackTo(IRogueRandomEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060198AD RID: 104621 RVA: 0x003A455C File Offset: 0x003A275C
		public static Offset<IRogueRandomEvent> Pack(FlatBufferBuilder builder, IRogueRandomEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueRandomEvent>);
			}
			return IRogueRandomEvent.CreateIRogueRandomEvent(builder, _o.Type);
		}

		// Token: 0x0400C633 RID: 50739
		private Table __p;
	}
}
