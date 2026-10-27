using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DC RID: 28892
	public struct IShowHidedGroup : IFlatbufferObject
	{
		// Token: 0x1700D6AB RID: 54955
		// (get) Token: 0x060332EB RID: 209643 RVA: 0x006E67A6 File Offset: 0x006E49A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060332EC RID: 209644 RVA: 0x006E67B3 File Offset: 0x006E49B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060332ED RID: 209645 RVA: 0x006E67BC File Offset: 0x006E49BC
		public static IShowHidedGroup GetRootAsIShowHidedGroup(ByteBuffer _bb)
		{
			return IShowHidedGroup.GetRootAsIShowHidedGroup(_bb, default(IShowHidedGroup));
		}

		// Token: 0x060332EE RID: 209646 RVA: 0x006E67D8 File Offset: 0x006E49D8
		public static IShowHidedGroup GetRootAsIShowHidedGroup(ByteBuffer _bb, IShowHidedGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060332EF RID: 209647 RVA: 0x006E67F5 File Offset: 0x006E49F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060332F0 RID: 209648 RVA: 0x006E6804 File Offset: 0x006E4A04
		public IShowHidedGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6AC RID: 54956
		// (get) Token: 0x060332F1 RID: 209649 RVA: 0x006E6814 File Offset: 0x006E4A14
		public string GroupKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060332F2 RID: 209650 RVA: 0x006E684B File Offset: 0x006E4A4B
		public Span<byte> GetGroupKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060332F3 RID: 209651 RVA: 0x006E685A File Offset: 0x006E4A5A
		public byte[] GetGroupKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D6AD RID: 54957
		// (get) Token: 0x060332F4 RID: 209652 RVA: 0x006E6868 File Offset: 0x006E4A68
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060332F5 RID: 209653 RVA: 0x006E68A7 File Offset: 0x006E4AA7
		public static Offset<IShowHidedGroup> CreateIShowHidedGroup(FlatBufferBuilder builder, StringOffset GroupKeyOffset = default(StringOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IShowHidedGroup.AddGroupKey(builder, GroupKeyOffset);
			IShowHidedGroup.AddDelayShow(builder, DelayShow);
			return IShowHidedGroup.EndIShowHidedGroup(builder);
		}

		// Token: 0x060332F6 RID: 209654 RVA: 0x006E68C4 File Offset: 0x006E4AC4
		public static void StartIShowHidedGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060332F7 RID: 209655 RVA: 0x006E68CD File Offset: 0x006E4ACD
		public static void AddGroupKey(FlatBufferBuilder builder, StringOffset groupKeyOffset)
		{
			builder.AddOffset(0, groupKeyOffset.Value, 0);
		}

		// Token: 0x060332F8 RID: 209656 RVA: 0x006E68DD File Offset: 0x006E4ADD
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x060332F9 RID: 209657 RVA: 0x006E68E8 File Offset: 0x006E4AE8
		public static Offset<IShowHidedGroup> EndIShowHidedGroup(FlatBufferBuilder builder)
		{
			return new Offset<IShowHidedGroup>(builder.EndTable());
		}

		// Token: 0x060332FA RID: 209658 RVA: 0x006E68F8 File Offset: 0x006E4AF8
		public IShowHidedGroupT UnPack()
		{
			IShowHidedGroupT showHidedGroupT = new IShowHidedGroupT();
			this.UnPackTo(showHidedGroupT);
			return showHidedGroupT;
		}

		// Token: 0x060332FB RID: 209659 RVA: 0x006E6913 File Offset: 0x006E4B13
		public void UnPackTo(IShowHidedGroupT _o)
		{
			_o.GroupKey = this.GroupKey;
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x060332FC RID: 209660 RVA: 0x006E6930 File Offset: 0x006E4B30
		public static Offset<IShowHidedGroup> Pack(FlatBufferBuilder builder, IShowHidedGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowHidedGroup>);
			}
			StringOffset groupKeyOffset = (_o.GroupKey == null) ? default(StringOffset) : builder.CreateString(_o.GroupKey);
			return IShowHidedGroup.CreateIShowHidedGroup(builder, groupKeyOffset, _o.DelayShow);
		}

		// Token: 0x04011B53 RID: 72531
		private Table __p;
	}
}
