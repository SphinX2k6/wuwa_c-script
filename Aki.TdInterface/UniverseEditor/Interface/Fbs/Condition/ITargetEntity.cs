using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E7 RID: 20967
	public struct ITargetEntity : IFlatbufferObject
	{
		// Token: 0x1700961D RID: 38429
		// (get) Token: 0x06021045 RID: 135237 RVA: 0x00490662 File Offset: 0x0048E862
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021046 RID: 135238 RVA: 0x0049066F File Offset: 0x0048E86F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021047 RID: 135239 RVA: 0x00490678 File Offset: 0x0048E878
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb)
		{
			return ITargetEntity.GetRootAsITargetEntity(_bb, default(ITargetEntity));
		}

		// Token: 0x06021048 RID: 135240 RVA: 0x00490694 File Offset: 0x0048E894
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb, ITargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021049 RID: 135241 RVA: 0x004906B1 File Offset: 0x0048E8B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602104A RID: 135242 RVA: 0x004906C0 File Offset: 0x0048E8C0
		public ITargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700961E RID: 38430
		// (get) Token: 0x0602104B RID: 135243 RVA: 0x004906D0 File Offset: 0x0048E8D0
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

		// Token: 0x1700961F RID: 38431
		// (get) Token: 0x0602104C RID: 135244 RVA: 0x0049070C File Offset: 0x0048E90C
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

		// Token: 0x0602104D RID: 135245 RVA: 0x00490748 File Offset: 0x0048E948
		public static Offset<ITargetEntity> CreateITargetEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, int EntityId = 0)
		{
			builder.StartTable(2);
			ITargetEntity.AddEntityId(builder, EntityId);
			ITargetEntity.AddType(builder, Type);
			return ITargetEntity.EndITargetEntity(builder);
		}

		// Token: 0x0602104E RID: 135246 RVA: 0x00490765 File Offset: 0x0048E965
		public static void StartITargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602104F RID: 135247 RVA: 0x0049076E File Offset: 0x0048E96E
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021050 RID: 135248 RVA: 0x00490779 File Offset: 0x0048E979
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06021051 RID: 135249 RVA: 0x00490784 File Offset: 0x0048E984
		public static Offset<ITargetEntity> EndITargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntity>(builder.EndTable());
		}

		// Token: 0x06021052 RID: 135250 RVA: 0x00490794 File Offset: 0x0048E994
		public ITargetEntityT UnPack()
		{
			ITargetEntityT targetEntityT = new ITargetEntityT();
			this.UnPackTo(targetEntityT);
			return targetEntityT;
		}

		// Token: 0x06021053 RID: 135251 RVA: 0x004907AF File Offset: 0x0048E9AF
		public void UnPackTo(ITargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06021054 RID: 135252 RVA: 0x004907CC File Offset: 0x0048E9CC
		public static Offset<ITargetEntity> Pack(FlatBufferBuilder builder, ITargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntity>);
			}
			return ITargetEntity.CreateITargetEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400E1ED RID: 57837
		private Table __p;
	}
}
