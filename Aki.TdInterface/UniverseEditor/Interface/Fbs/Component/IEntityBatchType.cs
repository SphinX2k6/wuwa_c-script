using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C7 RID: 22215
	public struct IEntityBatchType : IFlatbufferObject
	{
		// Token: 0x17009FE7 RID: 40935
		// (get) Token: 0x06023990 RID: 145808 RVA: 0x004E52B6 File Offset: 0x004E34B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023991 RID: 145809 RVA: 0x004E52C3 File Offset: 0x004E34C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023992 RID: 145810 RVA: 0x004E52CC File Offset: 0x004E34CC
		public static IEntityBatchType GetRootAsIEntityBatchType(ByteBuffer _bb)
		{
			return IEntityBatchType.GetRootAsIEntityBatchType(_bb, default(IEntityBatchType));
		}

		// Token: 0x06023993 RID: 145811 RVA: 0x004E52E8 File Offset: 0x004E34E8
		public static IEntityBatchType GetRootAsIEntityBatchType(ByteBuffer _bb, IEntityBatchType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023994 RID: 145812 RVA: 0x004E5305 File Offset: 0x004E3505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023995 RID: 145813 RVA: 0x004E5314 File Offset: 0x004E3514
		public IEntityBatchType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FE8 RID: 40936
		// (get) Token: 0x06023996 RID: 145814 RVA: 0x004E5324 File Offset: 0x004E3524
		public EEntityBatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityBatchType.EntityList;
				}
				return (EEntityBatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023997 RID: 145815 RVA: 0x004E5360 File Offset: 0x004E3560
		public static Offset<IEntityBatchType> CreateIEntityBatchType(FlatBufferBuilder builder, EEntityBatchType Type = EEntityBatchType.EntityList)
		{
			builder.StartTable(1);
			IEntityBatchType.AddType(builder, Type);
			return IEntityBatchType.EndIEntityBatchType(builder);
		}

		// Token: 0x06023998 RID: 145816 RVA: 0x004E5376 File Offset: 0x004E3576
		public static void StartIEntityBatchType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023999 RID: 145817 RVA: 0x004E537F File Offset: 0x004E357F
		public static void AddType(FlatBufferBuilder builder, EEntityBatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602399A RID: 145818 RVA: 0x004E538A File Offset: 0x004E358A
		public static Offset<IEntityBatchType> EndIEntityBatchType(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBatchType>(builder.EndTable());
		}

		// Token: 0x0602399B RID: 145819 RVA: 0x004E5398 File Offset: 0x004E3598
		public IEntityBatchTypeT UnPack()
		{
			IEntityBatchTypeT entityBatchTypeT = new IEntityBatchTypeT();
			this.UnPackTo(entityBatchTypeT);
			return entityBatchTypeT;
		}

		// Token: 0x0602399C RID: 145820 RVA: 0x004E53B3 File Offset: 0x004E35B3
		public void UnPackTo(IEntityBatchTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602399D RID: 145821 RVA: 0x004E53C4 File Offset: 0x004E35C4
		public static Offset<IEntityBatchType> Pack(FlatBufferBuilder builder, IEntityBatchTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBatchType>);
			}
			return IEntityBatchType.CreateIEntityBatchType(builder, _o.Type);
		}

		// Token: 0x0400EE07 RID: 60935
		private Table __p;
	}
}
