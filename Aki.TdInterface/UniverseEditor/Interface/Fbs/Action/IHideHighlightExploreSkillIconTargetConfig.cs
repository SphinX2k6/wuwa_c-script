using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA1 RID: 28577
	public struct IHideHighlightExploreSkillIconTargetConfig : IFlatbufferObject
	{
		// Token: 0x1700D150 RID: 53584
		// (get) Token: 0x06031793 RID: 202643 RVA: 0x006B4E9B File Offset: 0x006B309B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031794 RID: 202644 RVA: 0x006B4EA8 File Offset: 0x006B30A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031795 RID: 202645 RVA: 0x006B4EB0 File Offset: 0x006B30B0
		public static IHideHighlightExploreSkillIconTargetConfig GetRootAsIHideHighlightExploreSkillIconTargetConfig(ByteBuffer _bb)
		{
			return IHideHighlightExploreSkillIconTargetConfig.GetRootAsIHideHighlightExploreSkillIconTargetConfig(_bb, default(IHideHighlightExploreSkillIconTargetConfig));
		}

		// Token: 0x06031796 RID: 202646 RVA: 0x006B4ECC File Offset: 0x006B30CC
		public static IHideHighlightExploreSkillIconTargetConfig GetRootAsIHideHighlightExploreSkillIconTargetConfig(ByteBuffer _bb, IHideHighlightExploreSkillIconTargetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031797 RID: 202647 RVA: 0x006B4EE9 File Offset: 0x006B30E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031798 RID: 202648 RVA: 0x006B4EF8 File Offset: 0x006B30F8
		public IHideHighlightExploreSkillIconTargetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D151 RID: 53585
		// (get) Token: 0x06031799 RID: 202649 RVA: 0x006B4F08 File Offset: 0x006B3108
		public int SkillType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D152 RID: 53586
		// (get) Token: 0x0603179A RID: 202650 RVA: 0x006B4F44 File Offset: 0x006B3144
		public int ItemId
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

		// Token: 0x1700D153 RID: 53587
		// (get) Token: 0x0603179B RID: 202651 RVA: 0x006B4F80 File Offset: 0x006B3180
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603179C RID: 202652 RVA: 0x006B4FBC File Offset: 0x006B31BC
		public static Offset<IHideHighlightExploreSkillIconTargetConfig> CreateIHideHighlightExploreSkillIconTargetConfig(FlatBufferBuilder builder, int SkillType = 0, int ItemId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IHideHighlightExploreSkillIconTargetConfig.AddItemId(builder, ItemId);
			IHideHighlightExploreSkillIconTargetConfig.AddSkillType(builder, SkillType);
			IHideHighlightExploreSkillIconTargetConfig.AddNullMask(builder, NullMask);
			return IHideHighlightExploreSkillIconTargetConfig.EndIHideHighlightExploreSkillIconTargetConfig(builder);
		}

		// Token: 0x0603179D RID: 202653 RVA: 0x006B4FE0 File Offset: 0x006B31E0
		public static void StartIHideHighlightExploreSkillIconTargetConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603179E RID: 202654 RVA: 0x006B4FE9 File Offset: 0x006B31E9
		public static void AddSkillType(FlatBufferBuilder builder, int skillType)
		{
			builder.AddInt(0, skillType, 0);
		}

		// Token: 0x0603179F RID: 202655 RVA: 0x006B4FF4 File Offset: 0x006B31F4
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x060317A0 RID: 202656 RVA: 0x006B4FFF File Offset: 0x006B31FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060317A1 RID: 202657 RVA: 0x006B500A File Offset: 0x006B320A
		public static Offset<IHideHighlightExploreSkillIconTargetConfig> EndIHideHighlightExploreSkillIconTargetConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHideHighlightExploreSkillIconTargetConfig>(builder.EndTable());
		}

		// Token: 0x060317A2 RID: 202658 RVA: 0x006B5018 File Offset: 0x006B3218
		public IHideHighlightExploreSkillIconTargetConfigT UnPack()
		{
			IHideHighlightExploreSkillIconTargetConfigT hideHighlightExploreSkillIconTargetConfigT = new IHideHighlightExploreSkillIconTargetConfigT();
			this.UnPackTo(hideHighlightExploreSkillIconTargetConfigT);
			return hideHighlightExploreSkillIconTargetConfigT;
		}

		// Token: 0x060317A3 RID: 202659 RVA: 0x006B5033 File Offset: 0x006B3233
		public void UnPackTo(IHideHighlightExploreSkillIconTargetConfigT _o)
		{
			_o.SkillType = this.SkillType;
			_o.ItemId = this.ItemId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060317A4 RID: 202660 RVA: 0x006B505C File Offset: 0x006B325C
		public static Offset<IHideHighlightExploreSkillIconTargetConfig> Pack(FlatBufferBuilder builder, IHideHighlightExploreSkillIconTargetConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideHighlightExploreSkillIconTargetConfig>);
			}
			return IHideHighlightExploreSkillIconTargetConfig.CreateIHideHighlightExploreSkillIconTargetConfig(builder, _o.SkillType, _o.ItemId, _o.NullMask);
		}

		// Token: 0x04011EC9 RID: 73417
		private Table __p;
	}
}
