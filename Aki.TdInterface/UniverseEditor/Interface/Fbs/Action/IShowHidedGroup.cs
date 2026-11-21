using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A8 RID: 30888
	public struct IShowHidedGroup : IFlatbufferObject
	{
		// Token: 0x1700E28E RID: 57998
		// (get) Token: 0x0603658D RID: 222605 RVA: 0x00746DB2 File Offset: 0x00744FB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603658E RID: 222606 RVA: 0x00746DBF File Offset: 0x00744FBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603658F RID: 222607 RVA: 0x00746DC8 File Offset: 0x00744FC8
		public static IShowHidedGroup GetRootAsIShowHidedGroup(ByteBuffer _bb)
		{
			return IShowHidedGroup.GetRootAsIShowHidedGroup(_bb, default(IShowHidedGroup));
		}

		// Token: 0x06036590 RID: 222608 RVA: 0x00746DE4 File Offset: 0x00744FE4
		public static IShowHidedGroup GetRootAsIShowHidedGroup(ByteBuffer _bb, IShowHidedGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036591 RID: 222609 RVA: 0x00746E01 File Offset: 0x00745001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036592 RID: 222610 RVA: 0x00746E10 File Offset: 0x00745010
		public IShowHidedGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E28F RID: 57999
		// (get) Token: 0x06036593 RID: 222611 RVA: 0x00746E20 File Offset: 0x00745020
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

		// Token: 0x06036594 RID: 222612 RVA: 0x00746E57 File Offset: 0x00745057
		public Span<byte> GetGroupKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036595 RID: 222613 RVA: 0x00746E66 File Offset: 0x00745066
		public byte[] GetGroupKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E290 RID: 58000
		// (get) Token: 0x06036596 RID: 222614 RVA: 0x00746E74 File Offset: 0x00745074
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036597 RID: 222615 RVA: 0x00746EB3 File Offset: 0x007450B3
		public static Offset<IShowHidedGroup> CreateIShowHidedGroup(FlatBufferBuilder builder, StringOffset GroupKeyOffset = default(StringOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IShowHidedGroup.AddGroupKey(builder, GroupKeyOffset);
			IShowHidedGroup.AddDelayShow(builder, DelayShow);
			return IShowHidedGroup.EndIShowHidedGroup(builder);
		}

		// Token: 0x06036598 RID: 222616 RVA: 0x00746ED0 File Offset: 0x007450D0
		public static void StartIShowHidedGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036599 RID: 222617 RVA: 0x00746ED9 File Offset: 0x007450D9
		public static void AddGroupKey(FlatBufferBuilder builder, StringOffset groupKeyOffset)
		{
			builder.AddOffset(0, groupKeyOffset.Value, 0);
		}

		// Token: 0x0603659A RID: 222618 RVA: 0x00746EE9 File Offset: 0x007450E9
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x0603659B RID: 222619 RVA: 0x00746EF4 File Offset: 0x007450F4
		public static Offset<IShowHidedGroup> EndIShowHidedGroup(FlatBufferBuilder builder)
		{
			return new Offset<IShowHidedGroup>(builder.EndTable());
		}

		// Token: 0x0603659C RID: 222620 RVA: 0x00746F04 File Offset: 0x00745104
		public IShowHidedGroupT UnPack()
		{
			IShowHidedGroupT showHidedGroupT = new IShowHidedGroupT();
			this.UnPackTo(showHidedGroupT);
			return showHidedGroupT;
		}

		// Token: 0x0603659D RID: 222621 RVA: 0x00746F1F File Offset: 0x0074511F
		public void UnPackTo(IShowHidedGroupT _o)
		{
			_o.GroupKey = this.GroupKey;
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x0603659E RID: 222622 RVA: 0x00746F3C File Offset: 0x0074513C
		public static Offset<IShowHidedGroup> Pack(FlatBufferBuilder builder, IShowHidedGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowHidedGroup>);
			}
			StringOffset groupKeyOffset = (_o.GroupKey == null) ? default(StringOffset) : builder.CreateString(_o.GroupKey);
			return IShowHidedGroup.CreateIShowHidedGroup(builder, groupKeyOffset, _o.DelayShow);
		}

		// Token: 0x04012B41 RID: 76609
		private Table __p;
	}
}
