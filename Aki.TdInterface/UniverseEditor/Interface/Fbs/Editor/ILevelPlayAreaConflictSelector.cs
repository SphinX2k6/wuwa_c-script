using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE8 RID: 19688
	public struct ILevelPlayAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x17008CE5 RID: 36069
		// (get) Token: 0x0601E729 RID: 124713 RVA: 0x00443DD0 File Offset: 0x00441FD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E72A RID: 124714 RVA: 0x00443DDD File Offset: 0x00441FDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E72B RID: 124715 RVA: 0x00443DE4 File Offset: 0x00441FE4
		public static ILevelPlayAreaConflictSelector GetRootAsILevelPlayAreaConflictSelector(ByteBuffer _bb)
		{
			return ILevelPlayAreaConflictSelector.GetRootAsILevelPlayAreaConflictSelector(_bb, default(ILevelPlayAreaConflictSelector));
		}

		// Token: 0x0601E72C RID: 124716 RVA: 0x00443E00 File Offset: 0x00442000
		public static ILevelPlayAreaConflictSelector GetRootAsILevelPlayAreaConflictSelector(ByteBuffer _bb, ILevelPlayAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E72D RID: 124717 RVA: 0x00443E1D File Offset: 0x0044201D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E72E RID: 124718 RVA: 0x00443E2C File Offset: 0x0044202C
		public ILevelPlayAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CE6 RID: 36070
		// (get) Token: 0x0601E72F RID: 124719 RVA: 0x00443E3C File Offset: 0x0044203C
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

		// Token: 0x17008CE7 RID: 36071
		// (get) Token: 0x0601E730 RID: 124720 RVA: 0x00443E78 File Offset: 0x00442078
		public int Id
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

		// Token: 0x17008CE8 RID: 36072
		// (get) Token: 0x0601E731 RID: 124721 RVA: 0x00443EB4 File Offset: 0x004420B4
		public bool CheckEnterArea
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E732 RID: 124722 RVA: 0x00443EF3 File Offset: 0x004420F3
		public static Offset<ILevelPlayAreaConflictSelector> CreateILevelPlayAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest, int Id = 0, bool CheckEnterArea = false)
		{
			builder.StartTable(3);
			ILevelPlayAreaConflictSelector.AddId(builder, Id);
			ILevelPlayAreaConflictSelector.AddCheckEnterArea(builder, CheckEnterArea);
			ILevelPlayAreaConflictSelector.AddType(builder, Type);
			return ILevelPlayAreaConflictSelector.EndILevelPlayAreaConflictSelector(builder);
		}

		// Token: 0x0601E733 RID: 124723 RVA: 0x00443F17 File Offset: 0x00442117
		public static void StartILevelPlayAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E734 RID: 124724 RVA: 0x00443F20 File Offset: 0x00442120
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E735 RID: 124725 RVA: 0x00443F2B File Offset: 0x0044212B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601E736 RID: 124726 RVA: 0x00443F36 File Offset: 0x00442136
		public static void AddCheckEnterArea(FlatBufferBuilder builder, bool checkEnterArea)
		{
			builder.AddBool(2, checkEnterArea, false);
		}

		// Token: 0x0601E737 RID: 124727 RVA: 0x00443F41 File Offset: 0x00442141
		public static Offset<ILevelPlayAreaConflictSelector> EndILevelPlayAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601E738 RID: 124728 RVA: 0x00443F50 File Offset: 0x00442150
		public ILevelPlayAreaConflictSelectorT UnPack()
		{
			ILevelPlayAreaConflictSelectorT levelPlayAreaConflictSelectorT = new ILevelPlayAreaConflictSelectorT();
			this.UnPackTo(levelPlayAreaConflictSelectorT);
			return levelPlayAreaConflictSelectorT;
		}

		// Token: 0x0601E739 RID: 124729 RVA: 0x00443F6B File Offset: 0x0044216B
		public void UnPackTo(ILevelPlayAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.CheckEnterArea = this.CheckEnterArea;
		}

		// Token: 0x0601E73A RID: 124730 RVA: 0x00443F94 File Offset: 0x00442194
		public static Offset<ILevelPlayAreaConflictSelector> Pack(FlatBufferBuilder builder, ILevelPlayAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayAreaConflictSelector>);
			}
			return ILevelPlayAreaConflictSelector.CreateILevelPlayAreaConflictSelector(builder, _o.Type, _o.Id, _o.CheckEnterArea);
		}

		// Token: 0x0400D8A1 RID: 55457
		private Table __p;
	}
}
