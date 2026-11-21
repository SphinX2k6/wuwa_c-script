using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005202 RID: 20994
	public struct ITriggeredEntity : IFlatbufferObject
	{
		// Token: 0x17009644 RID: 38468
		// (get) Token: 0x06021105 RID: 135429 RVA: 0x0049194E File Offset: 0x0048FB4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021106 RID: 135430 RVA: 0x0049195B File Offset: 0x0048FB5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021107 RID: 135431 RVA: 0x00491964 File Offset: 0x0048FB64
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb)
		{
			return ITriggeredEntity.GetRootAsITriggeredEntity(_bb, default(ITriggeredEntity));
		}

		// Token: 0x06021108 RID: 135432 RVA: 0x00491980 File Offset: 0x0048FB80
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb, ITriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021109 RID: 135433 RVA: 0x0049199D File Offset: 0x0048FB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602110A RID: 135434 RVA: 0x004919AC File Offset: 0x0048FBAC
		public ITriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009645 RID: 38469
		// (get) Token: 0x0602110B RID: 135435 RVA: 0x004919BC File Offset: 0x0048FBBC
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

		// Token: 0x0602110C RID: 135436 RVA: 0x004919F8 File Offset: 0x0048FBF8
		public static Offset<ITriggeredEntity> CreateITriggeredEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITriggeredEntity.AddType(builder, Type);
			return ITriggeredEntity.EndITriggeredEntity(builder);
		}

		// Token: 0x0602110D RID: 135437 RVA: 0x00491A0E File Offset: 0x0048FC0E
		public static void StartITriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602110E RID: 135438 RVA: 0x00491A17 File Offset: 0x0048FC17
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602110F RID: 135439 RVA: 0x00491A22 File Offset: 0x0048FC22
		public static Offset<ITriggeredEntity> EndITriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredEntity>(builder.EndTable());
		}

		// Token: 0x06021110 RID: 135440 RVA: 0x00491A30 File Offset: 0x0048FC30
		public ITriggeredEntityT UnPack()
		{
			ITriggeredEntityT triggeredEntityT = new ITriggeredEntityT();
			this.UnPackTo(triggeredEntityT);
			return triggeredEntityT;
		}

		// Token: 0x06021111 RID: 135441 RVA: 0x00491A4B File Offset: 0x0048FC4B
		public void UnPackTo(ITriggeredEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021112 RID: 135442 RVA: 0x00491A5C File Offset: 0x0048FC5C
		public static Offset<ITriggeredEntity> Pack(FlatBufferBuilder builder, ITriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredEntity>);
			}
			return ITriggeredEntity.CreateITriggeredEntity(builder, _o.Type);
		}

		// Token: 0x0400E211 RID: 57873
		private Table __p;
	}
}
