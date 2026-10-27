using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB4 RID: 24244
	public struct ICommonBtDecoratorBase : IFlatbufferObject
	{
		// Token: 0x1700B529 RID: 46377
		// (get) Token: 0x06029927 RID: 170279 RVA: 0x005B3F62 File Offset: 0x005B2162
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029928 RID: 170280 RVA: 0x005B3F6F File Offset: 0x005B216F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029929 RID: 170281 RVA: 0x005B3F78 File Offset: 0x005B2178
		public static ICommonBtDecoratorBase GetRootAsICommonBtDecoratorBase(ByteBuffer _bb)
		{
			return ICommonBtDecoratorBase.GetRootAsICommonBtDecoratorBase(_bb, default(ICommonBtDecoratorBase));
		}

		// Token: 0x0602992A RID: 170282 RVA: 0x005B3F94 File Offset: 0x005B2194
		public static ICommonBtDecoratorBase GetRootAsICommonBtDecoratorBase(ByteBuffer _bb, ICommonBtDecoratorBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602992B RID: 170283 RVA: 0x005B3FB1 File Offset: 0x005B21B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602992C RID: 170284 RVA: 0x005B3FC0 File Offset: 0x005B21C0
		public ICommonBtDecoratorBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B52A RID: 46378
		// (get) Token: 0x0602992D RID: 170285 RVA: 0x005B3FD0 File Offset: 0x005B21D0
		public ECommonBtDecoratorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtDecoratorType.Condition;
				}
				return (ECommonBtDecoratorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602992E RID: 170286 RVA: 0x005B400C File Offset: 0x005B220C
		public static Offset<ICommonBtDecoratorBase> CreateICommonBtDecoratorBase(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtDecoratorBase.AddType(builder, Type);
			return ICommonBtDecoratorBase.EndICommonBtDecoratorBase(builder);
		}

		// Token: 0x0602992F RID: 170287 RVA: 0x005B4022 File Offset: 0x005B2222
		public static void StartICommonBtDecoratorBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029930 RID: 170288 RVA: 0x005B402B File Offset: 0x005B222B
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029931 RID: 170289 RVA: 0x005B4036 File Offset: 0x005B2236
		public static Offset<ICommonBtDecoratorBase> EndICommonBtDecoratorBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtDecoratorBase>(builder.EndTable());
		}

		// Token: 0x06029932 RID: 170290 RVA: 0x005B4044 File Offset: 0x005B2244
		public ICommonBtDecoratorBaseT UnPack()
		{
			ICommonBtDecoratorBaseT commonBtDecoratorBaseT = new ICommonBtDecoratorBaseT();
			this.UnPackTo(commonBtDecoratorBaseT);
			return commonBtDecoratorBaseT;
		}

		// Token: 0x06029933 RID: 170291 RVA: 0x005B405F File Offset: 0x005B225F
		public void UnPackTo(ICommonBtDecoratorBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029934 RID: 170292 RVA: 0x005B4070 File Offset: 0x005B2270
		public static Offset<ICommonBtDecoratorBase> Pack(FlatBufferBuilder builder, ICommonBtDecoratorBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtDecoratorBase>);
			}
			return ICommonBtDecoratorBase.CreateICommonBtDecoratorBase(builder, _o.Type);
		}

		// Token: 0x0400F925 RID: 63781
		private Table __p;
	}
}
