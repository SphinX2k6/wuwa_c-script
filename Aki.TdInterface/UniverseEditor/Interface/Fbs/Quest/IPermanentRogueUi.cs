using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B8 RID: 17336
	public struct IPermanentRogueUi : IFlatbufferObject
	{
		// Token: 0x17007766 RID: 30566
		// (get) Token: 0x06018993 RID: 100755 RVA: 0x003826BD File Offset: 0x003808BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018994 RID: 100756 RVA: 0x003826CA File Offset: 0x003808CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018995 RID: 100757 RVA: 0x003826D4 File Offset: 0x003808D4
		public static IPermanentRogueUi GetRootAsIPermanentRogueUi(ByteBuffer _bb)
		{
			return IPermanentRogueUi.GetRootAsIPermanentRogueUi(_bb, default(IPermanentRogueUi));
		}

		// Token: 0x06018996 RID: 100758 RVA: 0x003826F0 File Offset: 0x003808F0
		public static IPermanentRogueUi GetRootAsIPermanentRogueUi(ByteBuffer _bb, IPermanentRogueUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018997 RID: 100759 RVA: 0x0038270D File Offset: 0x0038090D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018998 RID: 100760 RVA: 0x0038271C File Offset: 0x0038091C
		public IPermanentRogueUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007767 RID: 30567
		// (get) Token: 0x06018999 RID: 100761 RVA: 0x0038272C File Offset: 0x0038092C
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

		// Token: 0x17007768 RID: 30568
		// (get) Token: 0x0601899A RID: 100762 RVA: 0x00382768 File Offset: 0x00380968
		public ERogueUiType UiType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERogueUiType.None;
				}
				return (ERogueUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007769 RID: 30569
		// (get) Token: 0x0601899B RID: 100763 RVA: 0x003827A4 File Offset: 0x003809A4
		public int BindId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601899C RID: 100764 RVA: 0x003827E0 File Offset: 0x003809E0
		public static Offset<IPermanentRogueUi> CreateIPermanentRogueUi(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, ERogueUiType UiType = ERogueUiType.None, int BindId = 0)
		{
			builder.StartTable(3);
			IPermanentRogueUi.AddBindId(builder, BindId);
			IPermanentRogueUi.AddUiType(builder, UiType);
			IPermanentRogueUi.AddType(builder, Type);
			return IPermanentRogueUi.EndIPermanentRogueUi(builder);
		}

		// Token: 0x0601899D RID: 100765 RVA: 0x00382804 File Offset: 0x00380A04
		public static void StartIPermanentRogueUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601899E RID: 100766 RVA: 0x0038280D File Offset: 0x00380A0D
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601899F RID: 100767 RVA: 0x00382818 File Offset: 0x00380A18
		public static void AddUiType(FlatBufferBuilder builder, ERogueUiType uiType)
		{
			builder.AddByte(1, (byte)uiType, 0);
		}

		// Token: 0x060189A0 RID: 100768 RVA: 0x00382823 File Offset: 0x00380A23
		public static void AddBindId(FlatBufferBuilder builder, int bindId)
		{
			builder.AddInt(2, bindId, 0);
		}

		// Token: 0x060189A1 RID: 100769 RVA: 0x0038282E File Offset: 0x00380A2E
		public static Offset<IPermanentRogueUi> EndIPermanentRogueUi(FlatBufferBuilder builder)
		{
			return new Offset<IPermanentRogueUi>(builder.EndTable());
		}

		// Token: 0x060189A2 RID: 100770 RVA: 0x0038283C File Offset: 0x00380A3C
		public IPermanentRogueUiT UnPack()
		{
			IPermanentRogueUiT permanentRogueUiT = new IPermanentRogueUiT();
			this.UnPackTo(permanentRogueUiT);
			return permanentRogueUiT;
		}

		// Token: 0x060189A3 RID: 100771 RVA: 0x00382857 File Offset: 0x00380A57
		public void UnPackTo(IPermanentRogueUiT _o)
		{
			_o.Type = this.Type;
			_o.UiType = this.UiType;
			_o.BindId = this.BindId;
		}

		// Token: 0x060189A4 RID: 100772 RVA: 0x00382880 File Offset: 0x00380A80
		public static Offset<IPermanentRogueUi> Pack(FlatBufferBuilder builder, IPermanentRogueUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPermanentRogueUi>);
			}
			return IPermanentRogueUi.CreateIPermanentRogueUi(builder, _o.Type, _o.UiType, _o.BindId);
		}

		// Token: 0x0400C3AE RID: 50094
		private Table __p;
	}
}
