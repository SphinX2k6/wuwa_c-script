using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007145 RID: 28997
	public struct ISlideRailEnd : IFlatbufferObject
	{
		// Token: 0x1700D775 RID: 55157
		// (get) Token: 0x0603367C RID: 210556 RVA: 0x006ED600 File Offset: 0x006EB800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603367D RID: 210557 RVA: 0x006ED60D File Offset: 0x006EB80D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603367E RID: 210558 RVA: 0x006ED614 File Offset: 0x006EB814
		public static ISlideRailEnd GetRootAsISlideRailEnd(ByteBuffer _bb)
		{
			return ISlideRailEnd.GetRootAsISlideRailEnd(_bb, default(ISlideRailEnd));
		}

		// Token: 0x0603367F RID: 210559 RVA: 0x006ED630 File Offset: 0x006EB830
		public static ISlideRailEnd GetRootAsISlideRailEnd(ByteBuffer _bb, ISlideRailEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033680 RID: 210560 RVA: 0x006ED64D File Offset: 0x006EB84D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033681 RID: 210561 RVA: 0x006ED65C File Offset: 0x006EB85C
		public ISlideRailEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D776 RID: 55158
		// (get) Token: 0x06033682 RID: 210562 RVA: 0x006ED66C File Offset: 0x006EB86C
		public TSlideRailEnd EndTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSlideRailEnd.NONE;
				}
				return (TSlideRailEnd)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033683 RID: 210563 RVA: 0x006ED6A8 File Offset: 0x006EB8A8
		public TTable? EndTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033684 RID: 210564 RVA: 0x006ED6EC File Offset: 0x006EB8EC
		public IAiFollowerSlideRailEnd EndTargetAsIAiFollowerSlideRailEnd()
		{
			return this.EndTarget<IAiFollowerSlideRailEnd>().Value;
		}

		// Token: 0x06033685 RID: 210565 RVA: 0x006ED708 File Offset: 0x006EB908
		public IPlayerSlideRailEnd EndTargetAsIPlayerSlideRailEnd()
		{
			return this.EndTarget<IPlayerSlideRailEnd>().Value;
		}

		// Token: 0x06033686 RID: 210566 RVA: 0x006ED723 File Offset: 0x006EB923
		public static Offset<ISlideRailEnd> CreateISlideRailEnd(FlatBufferBuilder builder, TSlideRailEnd EndTarget_type = TSlideRailEnd.NONE, int EndTargetOffset = 0)
		{
			builder.StartTable(2);
			ISlideRailEnd.AddEndTarget(builder, EndTargetOffset);
			ISlideRailEnd.AddEndTargetType(builder, EndTarget_type);
			return ISlideRailEnd.EndISlideRailEnd(builder);
		}

		// Token: 0x06033687 RID: 210567 RVA: 0x006ED740 File Offset: 0x006EB940
		public static void StartISlideRailEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033688 RID: 210568 RVA: 0x006ED749 File Offset: 0x006EB949
		public static void AddEndTargetType(FlatBufferBuilder builder, TSlideRailEnd endTargetType)
		{
			builder.AddByte(0, (byte)endTargetType, 0);
		}

		// Token: 0x06033689 RID: 210569 RVA: 0x006ED754 File Offset: 0x006EB954
		public static void AddEndTarget(FlatBufferBuilder builder, int endTargetOffset)
		{
			builder.AddOffset(1, endTargetOffset, 0);
		}

		// Token: 0x0603368A RID: 210570 RVA: 0x006ED75F File Offset: 0x006EB95F
		public static Offset<ISlideRailEnd> EndISlideRailEnd(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailEnd>(builder.EndTable());
		}

		// Token: 0x0603368B RID: 210571 RVA: 0x006ED76C File Offset: 0x006EB96C
		public ISlideRailEndT UnPack()
		{
			ISlideRailEndT slideRailEndT = new ISlideRailEndT();
			this.UnPackTo(slideRailEndT);
			return slideRailEndT;
		}

		// Token: 0x0603368C RID: 210572 RVA: 0x006ED788 File Offset: 0x006EB988
		public void UnPackTo(ISlideRailEndT _o)
		{
			_o.EndTarget = new TSlideRailEndUnion();
			_o.EndTarget.Type = this.EndTargetType;
			TSlideRailEnd endTargetType = this.EndTargetType;
			if (endTargetType == TSlideRailEnd.IAiFollowerSlideRailEnd)
			{
				_o.EndTarget.Value = ((this.EndTarget<IAiFollowerSlideRailEnd>() != null) ? this.EndTarget<IAiFollowerSlideRailEnd>().Value.UnPack() : null);
				return;
			}
			if (endTargetType != TSlideRailEnd.IPlayerSlideRailEnd)
			{
				return;
			}
			_o.EndTarget.Value = ((this.EndTarget<IPlayerSlideRailEnd>() != null) ? this.EndTarget<IPlayerSlideRailEnd>().Value.UnPack() : null);
		}

		// Token: 0x0603368D RID: 210573 RVA: 0x006ED82C File Offset: 0x006EBA2C
		public static Offset<ISlideRailEnd> Pack(FlatBufferBuilder builder, ISlideRailEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailEnd>);
			}
			TSlideRailEnd endTarget_type = (_o.EndTarget == null) ? TSlideRailEnd.NONE : _o.EndTarget.Type;
			int endTargetOffset = (_o.EndTarget == null) ? 0 : TSlideRailEndUnion.Pack(builder, _o.EndTarget);
			return ISlideRailEnd.CreateISlideRailEnd(builder, endTarget_type, endTargetOffset);
		}

		// Token: 0x04011BE0 RID: 72672
		private Table __p;
	}
}
