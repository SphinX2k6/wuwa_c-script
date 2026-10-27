using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006361 RID: 25441
	public struct ICheckFlowLookAtEntity : IFlatbufferObject
	{
		// Token: 0x1700BDD1 RID: 48593
		// (get) Token: 0x0602C037 RID: 180279 RVA: 0x0060C5E5 File Offset: 0x0060A7E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C038 RID: 180280 RVA: 0x0060C5F2 File Offset: 0x0060A7F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C039 RID: 180281 RVA: 0x0060C5FC File Offset: 0x0060A7FC
		public static ICheckFlowLookAtEntity GetRootAsICheckFlowLookAtEntity(ByteBuffer _bb)
		{
			return ICheckFlowLookAtEntity.GetRootAsICheckFlowLookAtEntity(_bb, default(ICheckFlowLookAtEntity));
		}

		// Token: 0x0602C03A RID: 180282 RVA: 0x0060C618 File Offset: 0x0060A818
		public static ICheckFlowLookAtEntity GetRootAsICheckFlowLookAtEntity(ByteBuffer _bb, ICheckFlowLookAtEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C03B RID: 180283 RVA: 0x0060C635 File Offset: 0x0060A835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C03C RID: 180284 RVA: 0x0060C644 File Offset: 0x0060A844
		public ICheckFlowLookAtEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDD2 RID: 48594
		// (get) Token: 0x0602C03D RID: 180285 RVA: 0x0060C654 File Offset: 0x0060A854
		public ECheckFlowLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return (ECheckFlowLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BDD3 RID: 48595
		// (get) Token: 0x0602C03E RID: 180286 RVA: 0x0060C690 File Offset: 0x0060A890
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

		// Token: 0x0602C03F RID: 180287 RVA: 0x0060C6CC File Offset: 0x0060A8CC
		public static Offset<ICheckFlowLookAtEntity> CreateICheckFlowLookAtEntity(FlatBufferBuilder builder, ECheckFlowLookAtTargetType Type = ECheckFlowLookAtTargetType.Entity, int EntityId = 0)
		{
			builder.StartTable(2);
			ICheckFlowLookAtEntity.AddEntityId(builder, EntityId);
			ICheckFlowLookAtEntity.AddType(builder, Type);
			return ICheckFlowLookAtEntity.EndICheckFlowLookAtEntity(builder);
		}

		// Token: 0x0602C040 RID: 180288 RVA: 0x0060C6E9 File Offset: 0x0060A8E9
		public static void StartICheckFlowLookAtEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C041 RID: 180289 RVA: 0x0060C6F2 File Offset: 0x0060A8F2
		public static void AddType(FlatBufferBuilder builder, ECheckFlowLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C042 RID: 180290 RVA: 0x0060C6FD File Offset: 0x0060A8FD
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602C043 RID: 180291 RVA: 0x0060C708 File Offset: 0x0060A908
		public static Offset<ICheckFlowLookAtEntity> EndICheckFlowLookAtEntity(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtEntity>(builder.EndTable());
		}

		// Token: 0x0602C044 RID: 180292 RVA: 0x0060C718 File Offset: 0x0060A918
		public ICheckFlowLookAtEntityT UnPack()
		{
			ICheckFlowLookAtEntityT checkFlowLookAtEntityT = new ICheckFlowLookAtEntityT();
			this.UnPackTo(checkFlowLookAtEntityT);
			return checkFlowLookAtEntityT;
		}

		// Token: 0x0602C045 RID: 180293 RVA: 0x0060C733 File Offset: 0x0060A933
		public void UnPackTo(ICheckFlowLookAtEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602C046 RID: 180294 RVA: 0x0060C750 File Offset: 0x0060A950
		public static Offset<ICheckFlowLookAtEntity> Pack(FlatBufferBuilder builder, ICheckFlowLookAtEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtEntity>);
			}
			return ICheckFlowLookAtEntity.CreateICheckFlowLookAtEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0401092F RID: 67887
		private Table __p;
	}
}
