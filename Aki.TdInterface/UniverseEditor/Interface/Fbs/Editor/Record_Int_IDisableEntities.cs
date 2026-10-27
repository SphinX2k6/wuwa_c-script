using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048CE RID: 18638
	public struct Record_Int_IDisableEntities : IFlatbufferObject
	{
		// Token: 0x17008750 RID: 34640
		// (get) Token: 0x0601D250 RID: 119376 RVA: 0x0041D568 File Offset: 0x0041B768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D251 RID: 119377 RVA: 0x0041D575 File Offset: 0x0041B775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D252 RID: 119378 RVA: 0x0041D57C File Offset: 0x0041B77C
		public static Record_Int_IDisableEntities GetRootAsRecord_Int_IDisableEntities(ByteBuffer _bb)
		{
			return Record_Int_IDisableEntities.GetRootAsRecord_Int_IDisableEntities(_bb, default(Record_Int_IDisableEntities));
		}

		// Token: 0x0601D253 RID: 119379 RVA: 0x0041D598 File Offset: 0x0041B798
		public static Record_Int_IDisableEntities GetRootAsRecord_Int_IDisableEntities(ByteBuffer _bb, Record_Int_IDisableEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D254 RID: 119380 RVA: 0x0041D5B5 File Offset: 0x0041B7B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D255 RID: 119381 RVA: 0x0041D5C4 File Offset: 0x0041B7C4
		public Record_Int_IDisableEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008751 RID: 34641
		// (get) Token: 0x0601D256 RID: 119382 RVA: 0x0041D5D4 File Offset: 0x0041B7D4
		public int Key
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

		// Token: 0x17008752 RID: 34642
		// (get) Token: 0x0601D257 RID: 119383 RVA: 0x0041D610 File Offset: 0x0041B810
		public IDisableEntities? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDisableEntities?(default(IDisableEntities).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D258 RID: 119384 RVA: 0x0041D66D File Offset: 0x0041B86D
		public static Offset<Record_Int_IDisableEntities> CreateRecord_Int_IDisableEntities(FlatBufferBuilder builder, int Key = 0, Offset<IDisableEntities> ValueOffset = default(Offset<IDisableEntities>))
		{
			builder.StartTable(2);
			Record_Int_IDisableEntities.AddValue(builder, ValueOffset);
			Record_Int_IDisableEntities.AddKey(builder, Key);
			return Record_Int_IDisableEntities.EndRecord_Int_IDisableEntities(builder);
		}

		// Token: 0x0601D259 RID: 119385 RVA: 0x0041D68A File Offset: 0x0041B88A
		public static void StartRecord_Int_IDisableEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D25A RID: 119386 RVA: 0x0041D693 File Offset: 0x0041B893
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D25B RID: 119387 RVA: 0x0041D69E File Offset: 0x0041B89E
		public static void AddValue(FlatBufferBuilder builder, Offset<IDisableEntities> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601D25C RID: 119388 RVA: 0x0041D6AE File Offset: 0x0041B8AE
		public static Offset<Record_Int_IDisableEntities> EndRecord_Int_IDisableEntities(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IDisableEntities>(builder.EndTable());
		}

		// Token: 0x0601D25D RID: 119389 RVA: 0x0041D6BC File Offset: 0x0041B8BC
		public Record_Int_IDisableEntitiesT UnPack()
		{
			Record_Int_IDisableEntitiesT record_Int_IDisableEntitiesT = new Record_Int_IDisableEntitiesT();
			this.UnPackTo(record_Int_IDisableEntitiesT);
			return record_Int_IDisableEntitiesT;
		}

		// Token: 0x0601D25E RID: 119390 RVA: 0x0041D6D8 File Offset: 0x0041B8D8
		public void UnPackTo(Record_Int_IDisableEntitiesT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601D25F RID: 119391 RVA: 0x0041D720 File Offset: 0x0041B920
		public static Offset<Record_Int_IDisableEntities> Pack(FlatBufferBuilder builder, Record_Int_IDisableEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IDisableEntities>);
			}
			Offset<IDisableEntities> valueOffset = (_o.Value == null) ? default(Offset<IDisableEntities>) : IDisableEntities.Pack(builder, _o.Value);
			return Record_Int_IDisableEntities.CreateRecord_Int_IDisableEntities(builder, _o.Key, valueOffset);
		}

		// Token: 0x0400CED8 RID: 52952
		private Table __p;
	}
}
