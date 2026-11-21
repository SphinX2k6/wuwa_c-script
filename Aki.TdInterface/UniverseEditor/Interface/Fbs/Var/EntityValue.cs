using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DCE RID: 15822
	public struct EntityValue : IFlatbufferObject
	{
		// Token: 0x17006AF8 RID: 27384
		// (get) Token: 0x06015413 RID: 87059 RVA: 0x00313389 File Offset: 0x00311589
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015414 RID: 87060 RVA: 0x00313396 File Offset: 0x00311596
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015415 RID: 87061 RVA: 0x003133A0 File Offset: 0x003115A0
		public static EntityValue GetRootAsEntityValue(ByteBuffer _bb)
		{
			return EntityValue.GetRootAsEntityValue(_bb, default(EntityValue));
		}

		// Token: 0x06015416 RID: 87062 RVA: 0x003133BC File Offset: 0x003115BC
		public static EntityValue GetRootAsEntityValue(ByteBuffer _bb, EntityValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015417 RID: 87063 RVA: 0x003133D9 File Offset: 0x003115D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015418 RID: 87064 RVA: 0x003133E8 File Offset: 0x003115E8
		public EntityValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AF9 RID: 27385
		// (get) Token: 0x06015419 RID: 87065 RVA: 0x003133F8 File Offset: 0x003115F8
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

		// Token: 0x0601541A RID: 87066 RVA: 0x00313434 File Offset: 0x00311634
		public static Offset<EntityValue> CreateEntityValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			EntityValue.AddValue(builder, value);
			return EntityValue.EndEntityValue(builder);
		}

		// Token: 0x0601541B RID: 87067 RVA: 0x0031344A File Offset: 0x0031164A
		public static void StartEntityValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601541C RID: 87068 RVA: 0x00313453 File Offset: 0x00311653
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x0601541D RID: 87069 RVA: 0x0031345E File Offset: 0x0031165E
		public static Offset<EntityValue> EndEntityValue(FlatBufferBuilder builder)
		{
			return new Offset<EntityValue>(builder.EndTable());
		}

		// Token: 0x0601541E RID: 87070 RVA: 0x0031346C File Offset: 0x0031166C
		public EntityValueT UnPack()
		{
			EntityValueT entityValueT = new EntityValueT();
			this.UnPackTo(entityValueT);
			return entityValueT;
		}

		// Token: 0x0601541F RID: 87071 RVA: 0x00313487 File Offset: 0x00311687
		public void UnPackTo(EntityValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06015420 RID: 87072 RVA: 0x00313498 File Offset: 0x00311698
		public static Offset<EntityValue> Pack(FlatBufferBuilder builder, EntityValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<EntityValue>);
			}
			return EntityValue.CreateEntityValue(builder, _o.Value);
		}

		// Token: 0x0400B71D RID: 46877
		private Table __p;
	}
}
