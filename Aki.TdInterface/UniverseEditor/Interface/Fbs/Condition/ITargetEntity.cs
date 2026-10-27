using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CEB RID: 19691
	public struct ITargetEntity : IFlatbufferObject
	{
		// Token: 0x17008EE4 RID: 36580
		// (get) Token: 0x0601F400 RID: 128000 RVA: 0x0045C712 File Offset: 0x0045A912
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F401 RID: 128001 RVA: 0x0045C71F File Offset: 0x0045A91F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F402 RID: 128002 RVA: 0x0045C728 File Offset: 0x0045A928
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb)
		{
			return ITargetEntity.GetRootAsITargetEntity(_bb, default(ITargetEntity));
		}

		// Token: 0x0601F403 RID: 128003 RVA: 0x0045C744 File Offset: 0x0045A944
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb, ITargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F404 RID: 128004 RVA: 0x0045C761 File Offset: 0x0045A961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F405 RID: 128005 RVA: 0x0045C770 File Offset: 0x0045A970
		public ITargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EE5 RID: 36581
		// (get) Token: 0x0601F406 RID: 128006 RVA: 0x0045C780 File Offset: 0x0045A980
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

		// Token: 0x17008EE6 RID: 36582
		// (get) Token: 0x0601F407 RID: 128007 RVA: 0x0045C7BC File Offset: 0x0045A9BC
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

		// Token: 0x0601F408 RID: 128008 RVA: 0x0045C7F8 File Offset: 0x0045A9F8
		public static Offset<ITargetEntity> CreateITargetEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, int EntityId = 0)
		{
			builder.StartTable(2);
			ITargetEntity.AddEntityId(builder, EntityId);
			ITargetEntity.AddType(builder, Type);
			return ITargetEntity.EndITargetEntity(builder);
		}

		// Token: 0x0601F409 RID: 128009 RVA: 0x0045C815 File Offset: 0x0045AA15
		public static void StartITargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F40A RID: 128010 RVA: 0x0045C81E File Offset: 0x0045AA1E
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F40B RID: 128011 RVA: 0x0045C829 File Offset: 0x0045AA29
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F40C RID: 128012 RVA: 0x0045C834 File Offset: 0x0045AA34
		public static Offset<ITargetEntity> EndITargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntity>(builder.EndTable());
		}

		// Token: 0x0601F40D RID: 128013 RVA: 0x0045C844 File Offset: 0x0045AA44
		public ITargetEntityT UnPack()
		{
			ITargetEntityT targetEntityT = new ITargetEntityT();
			this.UnPackTo(targetEntityT);
			return targetEntityT;
		}

		// Token: 0x0601F40E RID: 128014 RVA: 0x0045C85F File Offset: 0x0045AA5F
		public void UnPackTo(ITargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601F40F RID: 128015 RVA: 0x0045C87C File Offset: 0x0045AA7C
		public static Offset<ITargetEntity> Pack(FlatBufferBuilder builder, ITargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntity>);
			}
			return ITargetEntity.CreateITargetEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400D6C0 RID: 54976
		private Table __p;
	}
}
