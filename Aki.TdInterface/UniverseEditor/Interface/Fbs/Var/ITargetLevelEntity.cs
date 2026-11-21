using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE3 RID: 16099
	public struct ITargetLevelEntity : IFlatbufferObject
	{
		// Token: 0x17006D03 RID: 27907
		// (get) Token: 0x06015D36 RID: 89398 RVA: 0x00323E40 File Offset: 0x00322040
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D37 RID: 89399 RVA: 0x00323E4D File Offset: 0x0032204D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D38 RID: 89400 RVA: 0x00323E54 File Offset: 0x00322054
		public static ITargetLevelEntity GetRootAsITargetLevelEntity(ByteBuffer _bb)
		{
			return ITargetLevelEntity.GetRootAsITargetLevelEntity(_bb, default(ITargetLevelEntity));
		}

		// Token: 0x06015D39 RID: 89401 RVA: 0x00323E70 File Offset: 0x00322070
		public static ITargetLevelEntity GetRootAsITargetLevelEntity(ByteBuffer _bb, ITargetLevelEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D3A RID: 89402 RVA: 0x00323E8D File Offset: 0x0032208D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D3B RID: 89403 RVA: 0x00323E9C File Offset: 0x0032209C
		public ITargetLevelEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D04 RID: 27908
		// (get) Token: 0x06015D3C RID: 89404 RVA: 0x00323EAC File Offset: 0x003220AC
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D05 RID: 27909
		// (get) Token: 0x06015D3D RID: 89405 RVA: 0x00323EE8 File Offset: 0x003220E8
		public int Id
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

		// Token: 0x06015D3E RID: 89406 RVA: 0x00323F24 File Offset: 0x00322124
		public static Offset<ITargetLevelEntity> CreateITargetLevelEntity(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player, int Id = 0)
		{
			builder.StartTable(2);
			ITargetLevelEntity.AddId(builder, Id);
			ITargetLevelEntity.AddType(builder, Type);
			return ITargetLevelEntity.EndITargetLevelEntity(builder);
		}

		// Token: 0x06015D3F RID: 89407 RVA: 0x00323F41 File Offset: 0x00322141
		public static void StartITargetLevelEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015D40 RID: 89408 RVA: 0x00323F4A File Offset: 0x0032214A
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015D41 RID: 89409 RVA: 0x00323F55 File Offset: 0x00322155
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015D42 RID: 89410 RVA: 0x00323F60 File Offset: 0x00322160
		public static Offset<ITargetLevelEntity> EndITargetLevelEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITargetLevelEntity>(builder.EndTable());
		}

		// Token: 0x06015D43 RID: 89411 RVA: 0x00323F70 File Offset: 0x00322170
		public ITargetLevelEntityT UnPack()
		{
			ITargetLevelEntityT targetLevelEntityT = new ITargetLevelEntityT();
			this.UnPackTo(targetLevelEntityT);
			return targetLevelEntityT;
		}

		// Token: 0x06015D44 RID: 89412 RVA: 0x00323F8B File Offset: 0x0032218B
		public void UnPackTo(ITargetLevelEntityT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06015D45 RID: 89413 RVA: 0x00323FA8 File Offset: 0x003221A8
		public static Offset<ITargetLevelEntity> Pack(FlatBufferBuilder builder, ITargetLevelEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetLevelEntity>);
			}
			return ITargetLevelEntity.CreateITargetLevelEntity(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400B90F RID: 47375
		private Table __p;
	}
}
