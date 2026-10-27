using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747B RID: 29819
	public struct ITriggeredEntity : IFlatbufferObject
	{
		// Token: 0x1700E264 RID: 57956
		// (get) Token: 0x06036306 RID: 221958 RVA: 0x0075E29B File Offset: 0x0075C49B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036307 RID: 221959 RVA: 0x0075E2A8 File Offset: 0x0075C4A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036308 RID: 221960 RVA: 0x0075E2B0 File Offset: 0x0075C4B0
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb)
		{
			return ITriggeredEntity.GetRootAsITriggeredEntity(_bb, default(ITriggeredEntity));
		}

		// Token: 0x06036309 RID: 221961 RVA: 0x0075E2CC File Offset: 0x0075C4CC
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb, ITriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603630A RID: 221962 RVA: 0x0075E2E9 File Offset: 0x0075C4E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603630B RID: 221963 RVA: 0x0075E2F8 File Offset: 0x0075C4F8
		public ITriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E265 RID: 57957
		// (get) Token: 0x0603630C RID: 221964 RVA: 0x0075E308 File Offset: 0x0075C508
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

		// Token: 0x0603630D RID: 221965 RVA: 0x0075E344 File Offset: 0x0075C544
		public static Offset<ITriggeredEntity> CreateITriggeredEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITriggeredEntity.AddType(builder, Type);
			return ITriggeredEntity.EndITriggeredEntity(builder);
		}

		// Token: 0x0603630E RID: 221966 RVA: 0x0075E35A File Offset: 0x0075C55A
		public static void StartITriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603630F RID: 221967 RVA: 0x0075E363 File Offset: 0x0075C563
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036310 RID: 221968 RVA: 0x0075E36E File Offset: 0x0075C56E
		public static Offset<ITriggeredEntity> EndITriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredEntity>(builder.EndTable());
		}

		// Token: 0x06036311 RID: 221969 RVA: 0x0075E37C File Offset: 0x0075C57C
		public ITriggeredEntityT UnPack()
		{
			ITriggeredEntityT triggeredEntityT = new ITriggeredEntityT();
			this.UnPackTo(triggeredEntityT);
			return triggeredEntityT;
		}

		// Token: 0x06036312 RID: 221970 RVA: 0x0075E397 File Offset: 0x0075C597
		public void UnPackTo(ITriggeredEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036313 RID: 221971 RVA: 0x0075E3A8 File Offset: 0x0075C5A8
		public static Offset<ITriggeredEntity> Pack(FlatBufferBuilder builder, ITriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredEntity>);
			}
			return ITriggeredEntity.CreateITriggeredEntity(builder, _o.Type);
		}

		// Token: 0x04012312 RID: 74514
		private Table __p;
	}
}
