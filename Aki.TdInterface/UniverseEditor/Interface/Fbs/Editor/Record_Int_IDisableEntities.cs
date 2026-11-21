using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D33 RID: 19763
	public struct Record_Int_IDisableEntities : IFlatbufferObject
	{
		// Token: 0x17008D98 RID: 36248
		// (get) Token: 0x0601EA3D RID: 125501 RVA: 0x00449D04 File Offset: 0x00447F04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA3E RID: 125502 RVA: 0x00449D11 File Offset: 0x00447F11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA3F RID: 125503 RVA: 0x00449D18 File Offset: 0x00447F18
		public static Record_Int_IDisableEntities GetRootAsRecord_Int_IDisableEntities(ByteBuffer _bb)
		{
			return Record_Int_IDisableEntities.GetRootAsRecord_Int_IDisableEntities(_bb, default(Record_Int_IDisableEntities));
		}

		// Token: 0x0601EA40 RID: 125504 RVA: 0x00449D34 File Offset: 0x00447F34
		public static Record_Int_IDisableEntities GetRootAsRecord_Int_IDisableEntities(ByteBuffer _bb, Record_Int_IDisableEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA41 RID: 125505 RVA: 0x00449D51 File Offset: 0x00447F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA42 RID: 125506 RVA: 0x00449D60 File Offset: 0x00447F60
		public Record_Int_IDisableEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D99 RID: 36249
		// (get) Token: 0x0601EA43 RID: 125507 RVA: 0x00449D70 File Offset: 0x00447F70
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

		// Token: 0x17008D9A RID: 36250
		// (get) Token: 0x0601EA44 RID: 125508 RVA: 0x00449DAC File Offset: 0x00447FAC
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

		// Token: 0x0601EA45 RID: 125509 RVA: 0x00449E09 File Offset: 0x00448009
		public static Offset<Record_Int_IDisableEntities> CreateRecord_Int_IDisableEntities(FlatBufferBuilder builder, int Key = 0, Offset<IDisableEntities> ValueOffset = default(Offset<IDisableEntities>))
		{
			builder.StartTable(2);
			Record_Int_IDisableEntities.AddValue(builder, ValueOffset);
			Record_Int_IDisableEntities.AddKey(builder, Key);
			return Record_Int_IDisableEntities.EndRecord_Int_IDisableEntities(builder);
		}

		// Token: 0x0601EA46 RID: 125510 RVA: 0x00449E26 File Offset: 0x00448026
		public static void StartRecord_Int_IDisableEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EA47 RID: 125511 RVA: 0x00449E2F File Offset: 0x0044802F
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601EA48 RID: 125512 RVA: 0x00449E3A File Offset: 0x0044803A
		public static void AddValue(FlatBufferBuilder builder, Offset<IDisableEntities> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601EA49 RID: 125513 RVA: 0x00449E4A File Offset: 0x0044804A
		public static Offset<Record_Int_IDisableEntities> EndRecord_Int_IDisableEntities(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IDisableEntities>(builder.EndTable());
		}

		// Token: 0x0601EA4A RID: 125514 RVA: 0x00449E58 File Offset: 0x00448058
		public Record_Int_IDisableEntitiesT UnPack()
		{
			Record_Int_IDisableEntitiesT record_Int_IDisableEntitiesT = new Record_Int_IDisableEntitiesT();
			this.UnPackTo(record_Int_IDisableEntitiesT);
			return record_Int_IDisableEntitiesT;
		}

		// Token: 0x0601EA4B RID: 125515 RVA: 0x00449E74 File Offset: 0x00448074
		public void UnPackTo(Record_Int_IDisableEntitiesT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601EA4C RID: 125516 RVA: 0x00449EBC File Offset: 0x004480BC
		public static Offset<Record_Int_IDisableEntities> Pack(FlatBufferBuilder builder, Record_Int_IDisableEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IDisableEntities>);
			}
			Offset<IDisableEntities> valueOffset = (_o.Value == null) ? default(Offset<IDisableEntities>) : IDisableEntities.Pack(builder, _o.Value);
			return Record_Int_IDisableEntities.CreateRecord_Int_IDisableEntities(builder, _o.Key, valueOffset);
		}

		// Token: 0x0400D911 RID: 55569
		private Table __p;
	}
}
