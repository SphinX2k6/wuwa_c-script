using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B53 RID: 15187
	public struct TransformValue : IFlatbufferObject
	{
		// Token: 0x17006821 RID: 26657
		// (get) Token: 0x06014C3B RID: 85051 RVA: 0x0030479C File Offset: 0x0030299C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014C3C RID: 85052 RVA: 0x003047A9 File Offset: 0x003029A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014C3D RID: 85053 RVA: 0x003047B0 File Offset: 0x003029B0
		public static TransformValue GetRootAsTransformValue(ByteBuffer _bb)
		{
			return TransformValue.GetRootAsTransformValue(_bb, default(TransformValue));
		}

		// Token: 0x06014C3E RID: 85054 RVA: 0x003047CC File Offset: 0x003029CC
		public static TransformValue GetRootAsTransformValue(ByteBuffer _bb, TransformValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014C3F RID: 85055 RVA: 0x003047E9 File Offset: 0x003029E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014C40 RID: 85056 RVA: 0x003047F8 File Offset: 0x003029F8
		public TransformValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006822 RID: 26658
		// (get) Token: 0x06014C41 RID: 85057 RVA: 0x00304808 File Offset: 0x00302A08
		public IPosAndRot? Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06014C42 RID: 85058 RVA: 0x00304865 File Offset: 0x00302A65
		public static Offset<TransformValue> CreateTransformValue(FlatBufferBuilder builder, Offset<IPosAndRot> valueOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(1);
			TransformValue.AddValue(builder, valueOffset);
			return TransformValue.EndTransformValue(builder);
		}

		// Token: 0x06014C43 RID: 85059 RVA: 0x0030487B File Offset: 0x00302A7B
		public static void StartTransformValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014C44 RID: 85060 RVA: 0x00304884 File Offset: 0x00302A84
		public static void AddValue(FlatBufferBuilder builder, Offset<IPosAndRot> valueOffset)
		{
			builder.AddOffset(0, valueOffset.Value, 0);
		}

		// Token: 0x06014C45 RID: 85061 RVA: 0x00304894 File Offset: 0x00302A94
		public static Offset<TransformValue> EndTransformValue(FlatBufferBuilder builder)
		{
			return new Offset<TransformValue>(builder.EndTable());
		}

		// Token: 0x06014C46 RID: 85062 RVA: 0x003048A4 File Offset: 0x00302AA4
		public TransformValueT UnPack()
		{
			TransformValueT transformValueT = new TransformValueT();
			this.UnPackTo(transformValueT);
			return transformValueT;
		}

		// Token: 0x06014C47 RID: 85063 RVA: 0x003048C0 File Offset: 0x00302AC0
		public void UnPackTo(TransformValueT _o)
		{
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x06014C48 RID: 85064 RVA: 0x003048FC File Offset: 0x00302AFC
		public static Offset<TransformValue> Pack(FlatBufferBuilder builder, TransformValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<TransformValue>);
			}
			Offset<IPosAndRot> valueOffset = (_o.Value == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.Value);
			return TransformValue.CreateTransformValue(builder, valueOffset);
		}

		// Token: 0x0400B04B RID: 45131
		private Table __p;
	}
}
