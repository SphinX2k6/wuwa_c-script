using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200640D RID: 25613
	public struct IGiantStableValue : IFlatbufferObject
	{
		// Token: 0x1700BD30 RID: 48432
		// (get) Token: 0x0602B83A RID: 178234 RVA: 0x005ED244 File Offset: 0x005EB444
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B83B RID: 178235 RVA: 0x005ED251 File Offset: 0x005EB451
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B83C RID: 178236 RVA: 0x005ED258 File Offset: 0x005EB458
		public static IGiantStableValue GetRootAsIGiantStableValue(ByteBuffer _bb)
		{
			return IGiantStableValue.GetRootAsIGiantStableValue(_bb, default(IGiantStableValue));
		}

		// Token: 0x0602B83D RID: 178237 RVA: 0x005ED274 File Offset: 0x005EB474
		public static IGiantStableValue GetRootAsIGiantStableValue(ByteBuffer _bb, IGiantStableValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B83E RID: 178238 RVA: 0x005ED291 File Offset: 0x005EB491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B83F RID: 178239 RVA: 0x005ED2A0 File Offset: 0x005EB4A0
		public IGiantStableValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD31 RID: 48433
		// (get) Token: 0x0602B840 RID: 178240 RVA: 0x005ED2B0 File Offset: 0x005EB4B0
		public EGiantStableValueBoundary Boundary
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueBoundary.Open;
				}
				return (EGiantStableValueBoundary)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD32 RID: 48434
		// (get) Token: 0x0602B841 RID: 178241 RVA: 0x005ED2EC File Offset: 0x005EB4EC
		public int Value
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

		// Token: 0x0602B842 RID: 178242 RVA: 0x005ED328 File Offset: 0x005EB528
		public static Offset<IGiantStableValue> CreateIGiantStableValue(FlatBufferBuilder builder, EGiantStableValueBoundary Boundary = EGiantStableValueBoundary.Open, int Value = 0)
		{
			builder.StartTable(2);
			IGiantStableValue.AddValue(builder, Value);
			IGiantStableValue.AddBoundary(builder, Boundary);
			return IGiantStableValue.EndIGiantStableValue(builder);
		}

		// Token: 0x0602B843 RID: 178243 RVA: 0x005ED345 File Offset: 0x005EB545
		public static void StartIGiantStableValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B844 RID: 178244 RVA: 0x005ED34E File Offset: 0x005EB54E
		public static void AddBoundary(FlatBufferBuilder builder, EGiantStableValueBoundary boundary)
		{
			builder.AddByte(0, (byte)boundary, 0);
		}

		// Token: 0x0602B845 RID: 178245 RVA: 0x005ED359 File Offset: 0x005EB559
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x0602B846 RID: 178246 RVA: 0x005ED364 File Offset: 0x005EB564
		public static Offset<IGiantStableValue> EndIGiantStableValue(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValue>(builder.EndTable());
		}

		// Token: 0x0602B847 RID: 178247 RVA: 0x005ED374 File Offset: 0x005EB574
		public IGiantStableValueT UnPack()
		{
			IGiantStableValueT giantStableValueT = new IGiantStableValueT();
			this.UnPackTo(giantStableValueT);
			return giantStableValueT;
		}

		// Token: 0x0602B848 RID: 178248 RVA: 0x005ED38F File Offset: 0x005EB58F
		public void UnPackTo(IGiantStableValueT _o)
		{
			_o.Boundary = this.Boundary;
			_o.Value = this.Value;
		}

		// Token: 0x0602B849 RID: 178249 RVA: 0x005ED3AC File Offset: 0x005EB5AC
		public static Offset<IGiantStableValue> Pack(FlatBufferBuilder builder, IGiantStableValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValue>);
			}
			return IGiantStableValue.CreateIGiantStableValue(builder, _o.Boundary, _o.Value);
		}

		// Token: 0x04010511 RID: 66833
		private Table __p;
	}
}
