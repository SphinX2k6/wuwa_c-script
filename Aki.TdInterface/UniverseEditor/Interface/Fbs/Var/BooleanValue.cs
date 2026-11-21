using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DC4 RID: 15812
	public struct BooleanValue : IFlatbufferObject
	{
		// Token: 0x17006AF5 RID: 27381
		// (get) Token: 0x06015401 RID: 87041 RVA: 0x0031320E File Offset: 0x0031140E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015402 RID: 87042 RVA: 0x0031321B File Offset: 0x0031141B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015403 RID: 87043 RVA: 0x00313224 File Offset: 0x00311424
		public static BooleanValue GetRootAsBooleanValue(ByteBuffer _bb)
		{
			return BooleanValue.GetRootAsBooleanValue(_bb, default(BooleanValue));
		}

		// Token: 0x06015404 RID: 87044 RVA: 0x00313240 File Offset: 0x00311440
		public static BooleanValue GetRootAsBooleanValue(ByteBuffer _bb, BooleanValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015405 RID: 87045 RVA: 0x0031325D File Offset: 0x0031145D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015406 RID: 87046 RVA: 0x0031326C File Offset: 0x0031146C
		public BooleanValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AF6 RID: 27382
		// (get) Token: 0x06015407 RID: 87047 RVA: 0x0031327C File Offset: 0x0031147C
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06015408 RID: 87048 RVA: 0x003132BB File Offset: 0x003114BB
		public static Offset<BooleanValue> CreateBooleanValue(FlatBufferBuilder builder, bool value = false)
		{
			builder.StartTable(1);
			BooleanValue.AddValue(builder, value);
			return BooleanValue.EndBooleanValue(builder);
		}

		// Token: 0x06015409 RID: 87049 RVA: 0x003132D1 File Offset: 0x003114D1
		public static void StartBooleanValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601540A RID: 87050 RVA: 0x003132DA File Offset: 0x003114DA
		public static void AddValue(FlatBufferBuilder builder, bool value)
		{
			builder.AddBool(0, value, false);
		}

		// Token: 0x0601540B RID: 87051 RVA: 0x003132E5 File Offset: 0x003114E5
		public static Offset<BooleanValue> EndBooleanValue(FlatBufferBuilder builder)
		{
			return new Offset<BooleanValue>(builder.EndTable());
		}

		// Token: 0x0601540C RID: 87052 RVA: 0x003132F4 File Offset: 0x003114F4
		public BooleanValueT UnPack()
		{
			BooleanValueT booleanValueT = new BooleanValueT();
			this.UnPackTo(booleanValueT);
			return booleanValueT;
		}

		// Token: 0x0601540D RID: 87053 RVA: 0x0031330F File Offset: 0x0031150F
		public void UnPackTo(BooleanValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x0601540E RID: 87054 RVA: 0x00313320 File Offset: 0x00311520
		public static Offset<BooleanValue> Pack(FlatBufferBuilder builder, BooleanValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<BooleanValue>);
			}
			return BooleanValue.CreateBooleanValue(builder, _o.Value);
		}

		// Token: 0x0400B6F5 RID: 46837
		private Table __p;
	}
}
