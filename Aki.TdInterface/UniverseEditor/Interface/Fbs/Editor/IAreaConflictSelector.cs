using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200481D RID: 18461
	public struct IAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x17008471 RID: 33905
		// (get) Token: 0x0601C833 RID: 116787 RVA: 0x0040857C File Offset: 0x0040677C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C834 RID: 116788 RVA: 0x00408589 File Offset: 0x00406789
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C835 RID: 116789 RVA: 0x00408590 File Offset: 0x00406790
		public static IAreaConflictSelector GetRootAsIAreaConflictSelector(ByteBuffer _bb)
		{
			return IAreaConflictSelector.GetRootAsIAreaConflictSelector(_bb, default(IAreaConflictSelector));
		}

		// Token: 0x0601C836 RID: 116790 RVA: 0x004085AC File Offset: 0x004067AC
		public static IAreaConflictSelector GetRootAsIAreaConflictSelector(ByteBuffer _bb, IAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C837 RID: 116791 RVA: 0x004085C9 File Offset: 0x004067C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C838 RID: 116792 RVA: 0x004085D8 File Offset: 0x004067D8
		public IAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008472 RID: 33906
		// (get) Token: 0x0601C839 RID: 116793 RVA: 0x004085E8 File Offset: 0x004067E8
		public EAreaConflictSelector Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaConflictSelector.Quest;
				}
				return (EAreaConflictSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C83A RID: 116794 RVA: 0x00408624 File Offset: 0x00406824
		public static Offset<IAreaConflictSelector> CreateIAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest)
		{
			builder.StartTable(1);
			IAreaConflictSelector.AddType(builder, Type);
			return IAreaConflictSelector.EndIAreaConflictSelector(builder);
		}

		// Token: 0x0601C83B RID: 116795 RVA: 0x0040863A File Offset: 0x0040683A
		public static void StartIAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C83C RID: 116796 RVA: 0x00408643 File Offset: 0x00406843
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C83D RID: 116797 RVA: 0x0040864E File Offset: 0x0040684E
		public static Offset<IAreaConflictSelector> EndIAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<IAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601C83E RID: 116798 RVA: 0x0040865C File Offset: 0x0040685C
		public IAreaConflictSelectorT UnPack()
		{
			IAreaConflictSelectorT areaConflictSelectorT = new IAreaConflictSelectorT();
			this.UnPackTo(areaConflictSelectorT);
			return areaConflictSelectorT;
		}

		// Token: 0x0601C83F RID: 116799 RVA: 0x00408677 File Offset: 0x00406877
		public void UnPackTo(IAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C840 RID: 116800 RVA: 0x00408688 File Offset: 0x00406888
		public static Offset<IAreaConflictSelector> Pack(FlatBufferBuilder builder, IAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaConflictSelector>);
			}
			return IAreaConflictSelector.CreateIAreaConflictSelector(builder, _o.Type);
		}

		// Token: 0x0400CD35 RID: 52533
		private Table __p;
	}
}
