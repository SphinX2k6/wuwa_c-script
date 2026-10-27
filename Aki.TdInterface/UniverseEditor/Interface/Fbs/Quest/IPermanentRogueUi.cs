using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F77 RID: 16247
	public struct IPermanentRogueUi : IFlatbufferObject
	{
		// Token: 0x17007168 RID: 29032
		// (get) Token: 0x06017304 RID: 94980 RVA: 0x00358AA5 File Offset: 0x00356CA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017305 RID: 94981 RVA: 0x00358AB2 File Offset: 0x00356CB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017306 RID: 94982 RVA: 0x00358ABC File Offset: 0x00356CBC
		public static IPermanentRogueUi GetRootAsIPermanentRogueUi(ByteBuffer _bb)
		{
			return IPermanentRogueUi.GetRootAsIPermanentRogueUi(_bb, default(IPermanentRogueUi));
		}

		// Token: 0x06017307 RID: 94983 RVA: 0x00358AD8 File Offset: 0x00356CD8
		public static IPermanentRogueUi GetRootAsIPermanentRogueUi(ByteBuffer _bb, IPermanentRogueUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017308 RID: 94984 RVA: 0x00358AF5 File Offset: 0x00356CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017309 RID: 94985 RVA: 0x00358B04 File Offset: 0x00356D04
		public IPermanentRogueUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007169 RID: 29033
		// (get) Token: 0x0601730A RID: 94986 RVA: 0x00358B14 File Offset: 0x00356D14
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

		// Token: 0x1700716A RID: 29034
		// (get) Token: 0x0601730B RID: 94987 RVA: 0x00358B50 File Offset: 0x00356D50
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

		// Token: 0x1700716B RID: 29035
		// (get) Token: 0x0601730C RID: 94988 RVA: 0x00358B8C File Offset: 0x00356D8C
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

		// Token: 0x0601730D RID: 94989 RVA: 0x00358BC8 File Offset: 0x00356DC8
		public static Offset<IPermanentRogueUi> CreateIPermanentRogueUi(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, ERogueUiType UiType = ERogueUiType.None, int BindId = 0)
		{
			builder.StartTable(3);
			IPermanentRogueUi.AddBindId(builder, BindId);
			IPermanentRogueUi.AddUiType(builder, UiType);
			IPermanentRogueUi.AddType(builder, Type);
			return IPermanentRogueUi.EndIPermanentRogueUi(builder);
		}

		// Token: 0x0601730E RID: 94990 RVA: 0x00358BEC File Offset: 0x00356DEC
		public static void StartIPermanentRogueUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601730F RID: 94991 RVA: 0x00358BF5 File Offset: 0x00356DF5
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017310 RID: 94992 RVA: 0x00358C00 File Offset: 0x00356E00
		public static void AddUiType(FlatBufferBuilder builder, ERogueUiType uiType)
		{
			builder.AddByte(1, (byte)uiType, 0);
		}

		// Token: 0x06017311 RID: 94993 RVA: 0x00358C0B File Offset: 0x00356E0B
		public static void AddBindId(FlatBufferBuilder builder, int bindId)
		{
			builder.AddInt(2, bindId, 0);
		}

		// Token: 0x06017312 RID: 94994 RVA: 0x00358C16 File Offset: 0x00356E16
		public static Offset<IPermanentRogueUi> EndIPermanentRogueUi(FlatBufferBuilder builder)
		{
			return new Offset<IPermanentRogueUi>(builder.EndTable());
		}

		// Token: 0x06017313 RID: 94995 RVA: 0x00358C24 File Offset: 0x00356E24
		public IPermanentRogueUiT UnPack()
		{
			IPermanentRogueUiT permanentRogueUiT = new IPermanentRogueUiT();
			this.UnPackTo(permanentRogueUiT);
			return permanentRogueUiT;
		}

		// Token: 0x06017314 RID: 94996 RVA: 0x00358C3F File Offset: 0x00356E3F
		public void UnPackTo(IPermanentRogueUiT _o)
		{
			_o.Type = this.Type;
			_o.UiType = this.UiType;
			_o.BindId = this.BindId;
		}

		// Token: 0x06017315 RID: 94997 RVA: 0x00358C68 File Offset: 0x00356E68
		public static Offset<IPermanentRogueUi> Pack(FlatBufferBuilder builder, IPermanentRogueUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPermanentRogueUi>);
			}
			return IPermanentRogueUi.CreateIPermanentRogueUi(builder, _o.Type, _o.UiType, _o.BindId);
		}

		// Token: 0x0400B9C9 RID: 47561
		private Table __p;
	}
}
