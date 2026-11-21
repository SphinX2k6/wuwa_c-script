using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C6E RID: 31854
	public struct ITriggeredEntity : IFlatbufferObject
	{
		// Token: 0x1700EE81 RID: 61057
		// (get) Token: 0x060396EF RID: 235247 RVA: 0x007C0FC7 File Offset: 0x007BF1C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060396F0 RID: 235248 RVA: 0x007C0FD4 File Offset: 0x007BF1D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060396F1 RID: 235249 RVA: 0x007C0FDC File Offset: 0x007BF1DC
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb)
		{
			return ITriggeredEntity.GetRootAsITriggeredEntity(_bb, default(ITriggeredEntity));
		}

		// Token: 0x060396F2 RID: 235250 RVA: 0x007C0FF8 File Offset: 0x007BF1F8
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb, ITriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060396F3 RID: 235251 RVA: 0x007C1015 File Offset: 0x007BF215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060396F4 RID: 235252 RVA: 0x007C1024 File Offset: 0x007BF224
		public ITriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE82 RID: 61058
		// (get) Token: 0x060396F5 RID: 235253 RVA: 0x007C1034 File Offset: 0x007BF234
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060396F6 RID: 235254 RVA: 0x007C1070 File Offset: 0x007BF270
		public static Offset<ITriggeredEntity> CreateITriggeredEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITriggeredEntity.AddType(builder, Type);
			return ITriggeredEntity.EndITriggeredEntity(builder);
		}

		// Token: 0x060396F7 RID: 235255 RVA: 0x007C1086 File Offset: 0x007BF286
		public static void StartITriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060396F8 RID: 235256 RVA: 0x007C108F File Offset: 0x007BF28F
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060396F9 RID: 235257 RVA: 0x007C109A File Offset: 0x007BF29A
		public static Offset<ITriggeredEntity> EndITriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredEntity>(builder.EndTable());
		}

		// Token: 0x060396FA RID: 235258 RVA: 0x007C10A8 File Offset: 0x007BF2A8
		public ITriggeredEntityT UnPack()
		{
			ITriggeredEntityT triggeredEntityT = new ITriggeredEntityT();
			this.UnPackTo(triggeredEntityT);
			return triggeredEntityT;
		}

		// Token: 0x060396FB RID: 235259 RVA: 0x007C10C3 File Offset: 0x007BF2C3
		public void UnPackTo(ITriggeredEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060396FC RID: 235260 RVA: 0x007C10D4 File Offset: 0x007BF2D4
		public static Offset<ITriggeredEntity> Pack(FlatBufferBuilder builder, ITriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredEntity>);
			}
			return ITriggeredEntity.CreateITriggeredEntity(builder, _o.Type);
		}

		// Token: 0x04013339 RID: 78649
		private Table __p;
	}
}
