using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551A RID: 21786
	public struct IColorStrategyOfSplineEffectType : IFlatbufferObject
	{
		// Token: 0x17009BB5 RID: 39861
		// (get) Token: 0x060226F3 RID: 141043 RVA: 0x004BEA2C File Offset: 0x004BCC2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060226F4 RID: 141044 RVA: 0x004BEA39 File Offset: 0x004BCC39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060226F5 RID: 141045 RVA: 0x004BEA40 File Offset: 0x004BCC40
		public static IColorStrategyOfSplineEffectType GetRootAsIColorStrategyOfSplineEffectType(ByteBuffer _bb)
		{
			return IColorStrategyOfSplineEffectType.GetRootAsIColorStrategyOfSplineEffectType(_bb, default(IColorStrategyOfSplineEffectType));
		}

		// Token: 0x060226F6 RID: 141046 RVA: 0x004BEA5C File Offset: 0x004BCC5C
		public static IColorStrategyOfSplineEffectType GetRootAsIColorStrategyOfSplineEffectType(ByteBuffer _bb, IColorStrategyOfSplineEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060226F7 RID: 141047 RVA: 0x004BEA79 File Offset: 0x004BCC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060226F8 RID: 141048 RVA: 0x004BEA88 File Offset: 0x004BCC88
		public IColorStrategyOfSplineEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BB6 RID: 39862
		// (get) Token: 0x060226F9 RID: 141049 RVA: 0x004BEA98 File Offset: 0x004BCC98
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

		// Token: 0x060226FA RID: 141050 RVA: 0x004BEAD4 File Offset: 0x004BCCD4
		public static Offset<IColorStrategyOfSplineEffectType> CreateIColorStrategyOfSplineEffectType(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect Type = EColorChangeStrategyOfSplineEffect.RGB)
		{
			builder.StartTable(1);
			IColorStrategyOfSplineEffectType.AddType(builder, Type);
			return IColorStrategyOfSplineEffectType.EndIColorStrategyOfSplineEffectType(builder);
		}

		// Token: 0x060226FB RID: 141051 RVA: 0x004BEAEA File Offset: 0x004BCCEA
		public static void StartIColorStrategyOfSplineEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060226FC RID: 141052 RVA: 0x004BEAF3 File Offset: 0x004BCCF3
		public static void AddType(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060226FD RID: 141053 RVA: 0x004BEAFE File Offset: 0x004BCCFE
		public static Offset<IColorStrategyOfSplineEffectType> EndIColorStrategyOfSplineEffectType(FlatBufferBuilder builder)
		{
			return new Offset<IColorStrategyOfSplineEffectType>(builder.EndTable());
		}

		// Token: 0x060226FE RID: 141054 RVA: 0x004BEB0C File Offset: 0x004BCD0C
		public IColorStrategyOfSplineEffectTypeT UnPack()
		{
			IColorStrategyOfSplineEffectTypeT colorStrategyOfSplineEffectTypeT = new IColorStrategyOfSplineEffectTypeT();
			this.UnPackTo(colorStrategyOfSplineEffectTypeT);
			return colorStrategyOfSplineEffectTypeT;
		}

		// Token: 0x060226FF RID: 141055 RVA: 0x004BEB27 File Offset: 0x004BCD27
		public void UnPackTo(IColorStrategyOfSplineEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022700 RID: 141056 RVA: 0x004BEB38 File Offset: 0x004BCD38
		public static Offset<IColorStrategyOfSplineEffectType> Pack(FlatBufferBuilder builder, IColorStrategyOfSplineEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColorStrategyOfSplineEffectType>);
			}
			return IColorStrategyOfSplineEffectType.CreateIColorStrategyOfSplineEffectType(builder, _o.Type);
		}

		// Token: 0x0400EA88 RID: 60040
		private Table __p;
	}
}
