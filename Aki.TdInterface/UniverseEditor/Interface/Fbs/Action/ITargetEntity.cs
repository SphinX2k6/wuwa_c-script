using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B36 RID: 31542
	public struct ITargetEntity : IFlatbufferObject
	{
		// Token: 0x1700EC46 RID: 60486
		// (get) Token: 0x06038CE3 RID: 232675 RVA: 0x007AEB4D File Offset: 0x007ACD4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038CE4 RID: 232676 RVA: 0x007AEB5A File Offset: 0x007ACD5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038CE5 RID: 232677 RVA: 0x007AEB64 File Offset: 0x007ACD64
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb)
		{
			return ITargetEntity.GetRootAsITargetEntity(_bb, default(ITargetEntity));
		}

		// Token: 0x06038CE6 RID: 232678 RVA: 0x007AEB80 File Offset: 0x007ACD80
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb, ITargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038CE7 RID: 232679 RVA: 0x007AEB9D File Offset: 0x007ACD9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038CE8 RID: 232680 RVA: 0x007AEBAC File Offset: 0x007ACDAC
		public ITargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC47 RID: 60487
		// (get) Token: 0x06038CE9 RID: 232681 RVA: 0x007AEBBC File Offset: 0x007ACDBC
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

		// Token: 0x1700EC48 RID: 60488
		// (get) Token: 0x06038CEA RID: 232682 RVA: 0x007AEBF8 File Offset: 0x007ACDF8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038CEB RID: 232683 RVA: 0x007AEC34 File Offset: 0x007ACE34
		public static Offset<ITargetEntity> CreateITargetEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, int EntityId = 0)
		{
			builder.StartTable(2);
			ITargetEntity.AddEntityId(builder, EntityId);
			ITargetEntity.AddType(builder, Type);
			return ITargetEntity.EndITargetEntity(builder);
		}

		// Token: 0x06038CEC RID: 232684 RVA: 0x007AEC51 File Offset: 0x007ACE51
		public static void StartITargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038CED RID: 232685 RVA: 0x007AEC5A File Offset: 0x007ACE5A
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038CEE RID: 232686 RVA: 0x007AEC65 File Offset: 0x007ACE65
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06038CEF RID: 232687 RVA: 0x007AEC70 File Offset: 0x007ACE70
		public static Offset<ITargetEntity> EndITargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntity>(builder.EndTable());
		}

		// Token: 0x06038CF0 RID: 232688 RVA: 0x007AEC80 File Offset: 0x007ACE80
		public ITargetEntityT UnPack()
		{
			ITargetEntityT targetEntityT = new ITargetEntityT();
			this.UnPackTo(targetEntityT);
			return targetEntityT;
		}

		// Token: 0x06038CF1 RID: 232689 RVA: 0x007AEC9B File Offset: 0x007ACE9B
		public void UnPackTo(ITargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06038CF2 RID: 232690 RVA: 0x007AECB8 File Offset: 0x007ACEB8
		public static Offset<ITargetEntity> Pack(FlatBufferBuilder builder, ITargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntity>);
			}
			return ITargetEntity.CreateITargetEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04013163 RID: 78179
		private Table __p;
	}
}
