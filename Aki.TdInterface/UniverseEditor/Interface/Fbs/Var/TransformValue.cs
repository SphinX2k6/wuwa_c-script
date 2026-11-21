using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F5B RID: 16219
	public struct TransformValue : IFlatbufferObject
	{
		// Token: 0x17006DC0 RID: 28096
		// (get) Token: 0x06016105 RID: 90373 RVA: 0x0032AD34 File Offset: 0x00328F34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016106 RID: 90374 RVA: 0x0032AD41 File Offset: 0x00328F41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016107 RID: 90375 RVA: 0x0032AD48 File Offset: 0x00328F48
		public static TransformValue GetRootAsTransformValue(ByteBuffer _bb)
		{
			return TransformValue.GetRootAsTransformValue(_bb, default(TransformValue));
		}

		// Token: 0x06016108 RID: 90376 RVA: 0x0032AD64 File Offset: 0x00328F64
		public static TransformValue GetRootAsTransformValue(ByteBuffer _bb, TransformValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016109 RID: 90377 RVA: 0x0032AD81 File Offset: 0x00328F81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601610A RID: 90378 RVA: 0x0032AD90 File Offset: 0x00328F90
		public TransformValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DC1 RID: 28097
		// (get) Token: 0x0601610B RID: 90379 RVA: 0x0032ADA0 File Offset: 0x00328FA0
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

		// Token: 0x0601610C RID: 90380 RVA: 0x0032ADFD File Offset: 0x00328FFD
		public static Offset<TransformValue> CreateTransformValue(FlatBufferBuilder builder, Offset<IPosAndRot> valueOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(1);
			TransformValue.AddValue(builder, valueOffset);
			return TransformValue.EndTransformValue(builder);
		}

		// Token: 0x0601610D RID: 90381 RVA: 0x0032AE13 File Offset: 0x00329013
		public static void StartTransformValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601610E RID: 90382 RVA: 0x0032AE1C File Offset: 0x0032901C
		public static void AddValue(FlatBufferBuilder builder, Offset<IPosAndRot> valueOffset)
		{
			builder.AddOffset(0, valueOffset.Value, 0);
		}

		// Token: 0x0601610F RID: 90383 RVA: 0x0032AE2C File Offset: 0x0032902C
		public static Offset<TransformValue> EndTransformValue(FlatBufferBuilder builder)
		{
			return new Offset<TransformValue>(builder.EndTable());
		}

		// Token: 0x06016110 RID: 90384 RVA: 0x0032AE3C File Offset: 0x0032903C
		public TransformValueT UnPack()
		{
			TransformValueT transformValueT = new TransformValueT();
			this.UnPackTo(transformValueT);
			return transformValueT;
		}

		// Token: 0x06016111 RID: 90385 RVA: 0x0032AE58 File Offset: 0x00329058
		public void UnPackTo(TransformValueT _o)
		{
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x06016112 RID: 90386 RVA: 0x0032AE94 File Offset: 0x00329094
		public static Offset<TransformValue> Pack(FlatBufferBuilder builder, TransformValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<TransformValue>);
			}
			Offset<IPosAndRot> valueOffset = (_o.Value == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.Value);
			return TransformValue.CreateTransformValue(builder, valueOffset);
		}

		// Token: 0x0400B9C8 RID: 47560
		private Table __p;
	}
}
