using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005120 RID: 20768
	public struct IEffectSplineWholeLineMode : IFlatbufferObject
	{
		// Token: 0x1700974B RID: 38731
		// (get) Token: 0x06021774 RID: 137076 RVA: 0x004A545A File Offset: 0x004A365A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021775 RID: 137077 RVA: 0x004A5467 File Offset: 0x004A3667
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021776 RID: 137078 RVA: 0x004A5470 File Offset: 0x004A3670
		public static IEffectSplineWholeLineMode GetRootAsIEffectSplineWholeLineMode(ByteBuffer _bb)
		{
			return IEffectSplineWholeLineMode.GetRootAsIEffectSplineWholeLineMode(_bb, default(IEffectSplineWholeLineMode));
		}

		// Token: 0x06021777 RID: 137079 RVA: 0x004A548C File Offset: 0x004A368C
		public static IEffectSplineWholeLineMode GetRootAsIEffectSplineWholeLineMode(ByteBuffer _bb, IEffectSplineWholeLineMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021778 RID: 137080 RVA: 0x004A54A9 File Offset: 0x004A36A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021779 RID: 137081 RVA: 0x004A54B8 File Offset: 0x004A36B8
		public IEffectSplineWholeLineMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700974C RID: 38732
		// (get) Token: 0x0602177A RID: 137082 RVA: 0x004A54C8 File Offset: 0x004A36C8
		public EEffectSplineCreateMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectSplineCreateMode.WholeLine;
				}
				return (EEffectSplineCreateMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602177B RID: 137083 RVA: 0x004A5504 File Offset: 0x004A3704
		public static Offset<IEffectSplineWholeLineMode> CreateIEffectSplineWholeLineMode(FlatBufferBuilder builder, EEffectSplineCreateMode Type = EEffectSplineCreateMode.WholeLine)
		{
			builder.StartTable(1);
			IEffectSplineWholeLineMode.AddType(builder, Type);
			return IEffectSplineWholeLineMode.EndIEffectSplineWholeLineMode(builder);
		}

		// Token: 0x0602177C RID: 137084 RVA: 0x004A551A File Offset: 0x004A371A
		public static void StartIEffectSplineWholeLineMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602177D RID: 137085 RVA: 0x004A5523 File Offset: 0x004A3723
		public static void AddType(FlatBufferBuilder builder, EEffectSplineCreateMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602177E RID: 137086 RVA: 0x004A552E File Offset: 0x004A372E
		public static Offset<IEffectSplineWholeLineMode> EndIEffectSplineWholeLineMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSplineWholeLineMode>(builder.EndTable());
		}

		// Token: 0x0602177F RID: 137087 RVA: 0x004A553C File Offset: 0x004A373C
		public IEffectSplineWholeLineModeT UnPack()
		{
			IEffectSplineWholeLineModeT effectSplineWholeLineModeT = new IEffectSplineWholeLineModeT();
			this.UnPackTo(effectSplineWholeLineModeT);
			return effectSplineWholeLineModeT;
		}

		// Token: 0x06021780 RID: 137088 RVA: 0x004A5557 File Offset: 0x004A3757
		public void UnPackTo(IEffectSplineWholeLineModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021781 RID: 137089 RVA: 0x004A5568 File Offset: 0x004A3768
		public static Offset<IEffectSplineWholeLineMode> Pack(FlatBufferBuilder builder, IEffectSplineWholeLineModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSplineWholeLineMode>);
			}
			return IEffectSplineWholeLineMode.CreateIEffectSplineWholeLineMode(builder, _o.Type);
		}

		// Token: 0x0400E195 RID: 57749
		private Table __p;
	}
}
