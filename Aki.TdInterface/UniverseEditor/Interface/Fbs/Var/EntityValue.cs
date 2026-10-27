using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x020039F3 RID: 14835
	public struct EntityValue : IFlatbufferObject
	{
		// Token: 0x170065C8 RID: 26056
		// (get) Token: 0x060140F7 RID: 82167 RVA: 0x002F019D File Offset: 0x002EE39D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060140F8 RID: 82168 RVA: 0x002F01AA File Offset: 0x002EE3AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060140F9 RID: 82169 RVA: 0x002F01B4 File Offset: 0x002EE3B4
		public static EntityValue GetRootAsEntityValue(ByteBuffer _bb)
		{
			return EntityValue.GetRootAsEntityValue(_bb, default(EntityValue));
		}

		// Token: 0x060140FA RID: 82170 RVA: 0x002F01D0 File Offset: 0x002EE3D0
		public static EntityValue GetRootAsEntityValue(ByteBuffer _bb, EntityValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060140FB RID: 82171 RVA: 0x002F01ED File Offset: 0x002EE3ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060140FC RID: 82172 RVA: 0x002F01FC File Offset: 0x002EE3FC
		public EntityValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065C9 RID: 26057
		// (get) Token: 0x060140FD RID: 82173 RVA: 0x002F020C File Offset: 0x002EE40C
		public int Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060140FE RID: 82174 RVA: 0x002F0248 File Offset: 0x002EE448
		public static Offset<EntityValue> CreateEntityValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			EntityValue.AddValue(builder, value);
			return EntityValue.EndEntityValue(builder);
		}

		// Token: 0x060140FF RID: 82175 RVA: 0x002F025E File Offset: 0x002EE45E
		public static void StartEntityValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014100 RID: 82176 RVA: 0x002F0267 File Offset: 0x002EE467
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x06014101 RID: 82177 RVA: 0x002F0272 File Offset: 0x002EE472
		public static Offset<EntityValue> EndEntityValue(FlatBufferBuilder builder)
		{
			return new Offset<EntityValue>(builder.EndTable());
		}

		// Token: 0x06014102 RID: 82178 RVA: 0x002F0280 File Offset: 0x002EE480
		public EntityValueT UnPack()
		{
			EntityValueT entityValueT = new EntityValueT();
			this.UnPackTo(entityValueT);
			return entityValueT;
		}

		// Token: 0x06014103 RID: 82179 RVA: 0x002F029B File Offset: 0x002EE49B
		public void UnPackTo(EntityValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014104 RID: 82180 RVA: 0x002F02AC File Offset: 0x002EE4AC
		public static Offset<EntityValue> Pack(FlatBufferBuilder builder, EntityValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<EntityValue>);
			}
			return EntityValue.CreateEntityValue(builder, _o.Value);
		}

		// Token: 0x0400ADFE RID: 44542
		private Table __p;
	}
}
