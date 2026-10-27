using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FBE RID: 20414
	public struct IColorStrategyOfSplineEffectType : IFlatbufferObject
	{
		// Token: 0x170093DD RID: 37853
		// (get) Token: 0x060207FF RID: 133119 RVA: 0x00485548 File Offset: 0x00483748
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020800 RID: 133120 RVA: 0x00485555 File Offset: 0x00483755
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020801 RID: 133121 RVA: 0x0048555C File Offset: 0x0048375C
		public static IColorStrategyOfSplineEffectType GetRootAsIColorStrategyOfSplineEffectType(ByteBuffer _bb)
		{
			return IColorStrategyOfSplineEffectType.GetRootAsIColorStrategyOfSplineEffectType(_bb, default(IColorStrategyOfSplineEffectType));
		}

		// Token: 0x06020802 RID: 133122 RVA: 0x00485578 File Offset: 0x00483778
		public static IColorStrategyOfSplineEffectType GetRootAsIColorStrategyOfSplineEffectType(ByteBuffer _bb, IColorStrategyOfSplineEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020803 RID: 133123 RVA: 0x00485595 File Offset: 0x00483795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020804 RID: 133124 RVA: 0x004855A4 File Offset: 0x004837A4
		public IColorStrategyOfSplineEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093DE RID: 37854
		// (get) Token: 0x06020805 RID: 133125 RVA: 0x004855B4 File Offset: 0x004837B4
		public EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EColorChangeStrategyOfSplineEffect.RGB;
				}
				return (EColorChangeStrategyOfSplineEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020806 RID: 133126 RVA: 0x004855F0 File Offset: 0x004837F0
		public static Offset<IColorStrategyOfSplineEffectType> CreateIColorStrategyOfSplineEffectType(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect Type = EColorChangeStrategyOfSplineEffect.RGB)
		{
			builder.StartTable(1);
			IColorStrategyOfSplineEffectType.AddType(builder, Type);
			return IColorStrategyOfSplineEffectType.EndIColorStrategyOfSplineEffectType(builder);
		}

		// Token: 0x06020807 RID: 133127 RVA: 0x00485606 File Offset: 0x00483806
		public static void StartIColorStrategyOfSplineEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020808 RID: 133128 RVA: 0x0048560F File Offset: 0x0048380F
		public static void AddType(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020809 RID: 133129 RVA: 0x0048561A File Offset: 0x0048381A
		public static Offset<IColorStrategyOfSplineEffectType> EndIColorStrategyOfSplineEffectType(FlatBufferBuilder builder)
		{
			return new Offset<IColorStrategyOfSplineEffectType>(builder.EndTable());
		}

		// Token: 0x0602080A RID: 133130 RVA: 0x00485628 File Offset: 0x00483828
		public IColorStrategyOfSplineEffectTypeT UnPack()
		{
			IColorStrategyOfSplineEffectTypeT colorStrategyOfSplineEffectTypeT = new IColorStrategyOfSplineEffectTypeT();
			this.UnPackTo(colorStrategyOfSplineEffectTypeT);
			return colorStrategyOfSplineEffectTypeT;
		}

		// Token: 0x0602080B RID: 133131 RVA: 0x00485643 File Offset: 0x00483843
		public void UnPackTo(IColorStrategyOfSplineEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602080C RID: 133132 RVA: 0x00485654 File Offset: 0x00483854
		public static Offset<IColorStrategyOfSplineEffectType> Pack(FlatBufferBuilder builder, IColorStrategyOfSplineEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColorStrategyOfSplineEffectType>);
			}
			return IColorStrategyOfSplineEffectType.CreateIColorStrategyOfSplineEffectType(builder, _o.Type);
		}

		// Token: 0x0400DE9A RID: 56986
		private Table __p;
	}
}
