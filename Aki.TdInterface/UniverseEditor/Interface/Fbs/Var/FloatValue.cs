using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DE1 RID: 15841
	public struct FloatValue : IFlatbufferObject
	{
		// Token: 0x17006AFB RID: 27387
		// (get) Token: 0x06015425 RID: 87077 RVA: 0x00313501 File Offset: 0x00311701
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015426 RID: 87078 RVA: 0x0031350E File Offset: 0x0031170E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015427 RID: 87079 RVA: 0x00313518 File Offset: 0x00311718
		public static FloatValue GetRootAsFloatValue(ByteBuffer _bb)
		{
			return FloatValue.GetRootAsFloatValue(_bb, default(FloatValue));
		}

		// Token: 0x06015428 RID: 87080 RVA: 0x00313534 File Offset: 0x00311734
		public static FloatValue GetRootAsFloatValue(ByteBuffer _bb, FloatValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015429 RID: 87081 RVA: 0x00313551 File Offset: 0x00311751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601542A RID: 87082 RVA: 0x00313560 File Offset: 0x00311760
		public FloatValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AFC RID: 27388
		// (get) Token: 0x0601542B RID: 87083 RVA: 0x00313570 File Offset: 0x00311770
		public float Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601542C RID: 87084 RVA: 0x003135B0 File Offset: 0x003117B0
		public static Offset<FloatValue> CreateFloatValue(FlatBufferBuilder builder, float value = 0f)
		{
			builder.StartTable(1);
			FloatValue.AddValue(builder, value);
			return FloatValue.EndFloatValue(builder);
		}

		// Token: 0x0601542D RID: 87085 RVA: 0x003135C6 File Offset: 0x003117C6
		public static void StartFloatValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601542E RID: 87086 RVA: 0x003135CF File Offset: 0x003117CF
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(0, value, 0.0);
		}

		// Token: 0x0601542F RID: 87087 RVA: 0x003135E2 File Offset: 0x003117E2
		public static Offset<FloatValue> EndFloatValue(FlatBufferBuilder builder)
		{
			return new Offset<FloatValue>(builder.EndTable());
		}

		// Token: 0x06015430 RID: 87088 RVA: 0x003135F0 File Offset: 0x003117F0
		public FloatValueT UnPack()
		{
			FloatValueT floatValueT = new FloatValueT();
			this.UnPackTo(floatValueT);
			return floatValueT;
		}

		// Token: 0x06015431 RID: 87089 RVA: 0x0031360B File Offset: 0x0031180B
		public void UnPackTo(FloatValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06015432 RID: 87090 RVA: 0x0031361C File Offset: 0x0031181C
		public static Offset<FloatValue> Pack(FlatBufferBuilder builder, FloatValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<FloatValue>);
			}
			return FloatValue.CreateFloatValue(builder, _o.Value);
		}

		// Token: 0x0400B791 RID: 46993
		private Table __p;
	}
}
