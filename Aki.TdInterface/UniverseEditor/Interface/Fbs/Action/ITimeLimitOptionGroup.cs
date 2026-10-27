using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D9 RID: 29657
	public struct ITimeLimitOptionGroup : IFlatbufferObject
	{
		// Token: 0x1700E14F RID: 57679
		// (get) Token: 0x06035E0D RID: 220685 RVA: 0x00755616 File Offset: 0x00753816
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E0E RID: 220686 RVA: 0x00755623 File Offset: 0x00753823
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E0F RID: 220687 RVA: 0x0075562C File Offset: 0x0075382C
		public static ITimeLimitOptionGroup GetRootAsITimeLimitOptionGroup(ByteBuffer _bb)
		{
			return ITimeLimitOptionGroup.GetRootAsITimeLimitOptionGroup(_bb, default(ITimeLimitOptionGroup));
		}

		// Token: 0x06035E10 RID: 220688 RVA: 0x00755648 File Offset: 0x00753848
		public static ITimeLimitOptionGroup GetRootAsITimeLimitOptionGroup(ByteBuffer _bb, ITimeLimitOptionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E11 RID: 220689 RVA: 0x00755665 File Offset: 0x00753865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E12 RID: 220690 RVA: 0x00755674 File Offset: 0x00753874
		public ITimeLimitOptionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E150 RID: 57680
		// (get) Token: 0x06035E13 RID: 220691 RVA: 0x00755684 File Offset: 0x00753884
		public ITimeLimitOptionGroupDefault? Style
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITimeLimitOptionGroupDefault?(default(ITimeLimitOptionGroupDefault).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035E14 RID: 220692 RVA: 0x007556E1 File Offset: 0x007538E1
		public static Offset<ITimeLimitOptionGroup> CreateITimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroupDefault> StyleOffset = default(Offset<ITimeLimitOptionGroupDefault>))
		{
			builder.StartTable(1);
			ITimeLimitOptionGroup.AddStyle(builder, StyleOffset);
			return ITimeLimitOptionGroup.EndITimeLimitOptionGroup(builder);
		}

		// Token: 0x06035E15 RID: 220693 RVA: 0x007556F7 File Offset: 0x007538F7
		public static void StartITimeLimitOptionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E16 RID: 220694 RVA: 0x00755700 File Offset: 0x00753900
		public static void AddStyle(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroupDefault> styleOffset)
		{
			builder.AddOffset(0, styleOffset.Value, 0);
		}

		// Token: 0x06035E17 RID: 220695 RVA: 0x00755710 File Offset: 0x00753910
		public static Offset<ITimeLimitOptionGroup> EndITimeLimitOptionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITimeLimitOptionGroup>(builder.EndTable());
		}

		// Token: 0x06035E18 RID: 220696 RVA: 0x00755720 File Offset: 0x00753920
		public ITimeLimitOptionGroupT UnPack()
		{
			ITimeLimitOptionGroupT timeLimitOptionGroupT = new ITimeLimitOptionGroupT();
			this.UnPackTo(timeLimitOptionGroupT);
			return timeLimitOptionGroupT;
		}

		// Token: 0x06035E19 RID: 220697 RVA: 0x0075573C File Offset: 0x0075393C
		public void UnPackTo(ITimeLimitOptionGroupT _o)
		{
			_o.Style = ((this.Style != null) ? this.Style.Value.UnPack() : null);
		}

		// Token: 0x06035E1A RID: 220698 RVA: 0x00755778 File Offset: 0x00753978
		public static Offset<ITimeLimitOptionGroup> Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeLimitOptionGroup>);
			}
			Offset<ITimeLimitOptionGroupDefault> styleOffset = (_o.Style == null) ? default(Offset<ITimeLimitOptionGroupDefault>) : ITimeLimitOptionGroupDefault.Pack(builder, _o.Style);
			return ITimeLimitOptionGroup.CreateITimeLimitOptionGroup(builder, styleOffset);
		}

		// Token: 0x0401222F RID: 74287
		private Table __p;
	}
}
