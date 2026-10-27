using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735B RID: 29531
	public struct ITargetEntity : IFlatbufferObject
	{
		// Token: 0x1700E045 RID: 57413
		// (get) Token: 0x0603599A RID: 219546 RVA: 0x0074CD79 File Offset: 0x0074AF79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603599B RID: 219547 RVA: 0x0074CD86 File Offset: 0x0074AF86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603599C RID: 219548 RVA: 0x0074CD90 File Offset: 0x0074AF90
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb)
		{
			return ITargetEntity.GetRootAsITargetEntity(_bb, default(ITargetEntity));
		}

		// Token: 0x0603599D RID: 219549 RVA: 0x0074CDAC File Offset: 0x0074AFAC
		public static ITargetEntity GetRootAsITargetEntity(ByteBuffer _bb, ITargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603599E RID: 219550 RVA: 0x0074CDC9 File Offset: 0x0074AFC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603599F RID: 219551 RVA: 0x0074CDD8 File Offset: 0x0074AFD8
		public ITargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E046 RID: 57414
		// (get) Token: 0x060359A0 RID: 219552 RVA: 0x0074CDE8 File Offset: 0x0074AFE8
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

		// Token: 0x1700E047 RID: 57415
		// (get) Token: 0x060359A1 RID: 219553 RVA: 0x0074CE24 File Offset: 0x0074B024
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

		// Token: 0x060359A2 RID: 219554 RVA: 0x0074CE60 File Offset: 0x0074B060
		public static Offset<ITargetEntity> CreateITargetEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, int EntityId = 0)
		{
			builder.StartTable(2);
			ITargetEntity.AddEntityId(builder, EntityId);
			ITargetEntity.AddType(builder, Type);
			return ITargetEntity.EndITargetEntity(builder);
		}

		// Token: 0x060359A3 RID: 219555 RVA: 0x0074CE7D File Offset: 0x0074B07D
		public static void StartITargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060359A4 RID: 219556 RVA: 0x0074CE86 File Offset: 0x0074B086
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060359A5 RID: 219557 RVA: 0x0074CE91 File Offset: 0x0074B091
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060359A6 RID: 219558 RVA: 0x0074CE9C File Offset: 0x0074B09C
		public static Offset<ITargetEntity> EndITargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntity>(builder.EndTable());
		}

		// Token: 0x060359A7 RID: 219559 RVA: 0x0074CEAC File Offset: 0x0074B0AC
		public ITargetEntityT UnPack()
		{
			ITargetEntityT targetEntityT = new ITargetEntityT();
			this.UnPackTo(targetEntityT);
			return targetEntityT;
		}

		// Token: 0x060359A8 RID: 219560 RVA: 0x0074CEC7 File Offset: 0x0074B0C7
		public void UnPackTo(ITargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060359A9 RID: 219561 RVA: 0x0074CEE4 File Offset: 0x0074B0E4
		public static Offset<ITargetEntity> Pack(FlatBufferBuilder builder, ITargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntity>);
			}
			return ITargetEntity.CreateITargetEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0401215A RID: 74074
		private Table __p;
	}
}
