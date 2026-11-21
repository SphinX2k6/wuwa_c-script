using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C02 RID: 27650
	public struct IDestroyQuestItem : IFlatbufferObject
	{
		// Token: 0x1700CAB7 RID: 51895
		// (get) Token: 0x0602F967 RID: 194919 RVA: 0x0067C5DC File Offset: 0x0067A7DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F968 RID: 194920 RVA: 0x0067C5E9 File Offset: 0x0067A7E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F969 RID: 194921 RVA: 0x0067C5F0 File Offset: 0x0067A7F0
		public static IDestroyQuestItem GetRootAsIDestroyQuestItem(ByteBuffer _bb)
		{
			return IDestroyQuestItem.GetRootAsIDestroyQuestItem(_bb, default(IDestroyQuestItem));
		}

		// Token: 0x0602F96A RID: 194922 RVA: 0x0067C60C File Offset: 0x0067A80C
		public static IDestroyQuestItem GetRootAsIDestroyQuestItem(ByteBuffer _bb, IDestroyQuestItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F96B RID: 194923 RVA: 0x0067C629 File Offset: 0x0067A829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F96C RID: 194924 RVA: 0x0067C638 File Offset: 0x0067A838
		public IDestroyQuestItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAB8 RID: 51896
		// (get) Token: 0x0602F96D RID: 194925 RVA: 0x0067C648 File Offset: 0x0067A848
		public int ItemId
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

		// Token: 0x1700CAB9 RID: 51897
		// (get) Token: 0x0602F96E RID: 194926 RVA: 0x0067C684 File Offset: 0x0067A884
		public int Count
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

		// Token: 0x1700CABA RID: 51898
		// (get) Token: 0x0602F96F RID: 194927 RVA: 0x0067C6C0 File Offset: 0x0067A8C0
		public bool IsAll
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602F970 RID: 194928 RVA: 0x0067C6FF File Offset: 0x0067A8FF
		public static Offset<IDestroyQuestItem> CreateIDestroyQuestItem(FlatBufferBuilder builder, int ItemId = 0, int Count = 0, bool IsAll = false)
		{
			builder.StartTable(3);
			IDestroyQuestItem.AddCount(builder, Count);
			IDestroyQuestItem.AddItemId(builder, ItemId);
			IDestroyQuestItem.AddIsAll(builder, IsAll);
			return IDestroyQuestItem.EndIDestroyQuestItem(builder);
		}

		// Token: 0x0602F971 RID: 194929 RVA: 0x0067C723 File Offset: 0x0067A923
		public static void StartIDestroyQuestItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F972 RID: 194930 RVA: 0x0067C72C File Offset: 0x0067A92C
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0602F973 RID: 194931 RVA: 0x0067C737 File Offset: 0x0067A937
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0602F974 RID: 194932 RVA: 0x0067C742 File Offset: 0x0067A942
		public static void AddIsAll(FlatBufferBuilder builder, bool isAll)
		{
			builder.AddBool(2, isAll, false);
		}

		// Token: 0x0602F975 RID: 194933 RVA: 0x0067C74D File Offset: 0x0067A94D
		public static Offset<IDestroyQuestItem> EndIDestroyQuestItem(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyQuestItem>(builder.EndTable());
		}

		// Token: 0x0602F976 RID: 194934 RVA: 0x0067C75C File Offset: 0x0067A95C
		public IDestroyQuestItemT UnPack()
		{
			IDestroyQuestItemT destroyQuestItemT = new IDestroyQuestItemT();
			this.UnPackTo(destroyQuestItemT);
			return destroyQuestItemT;
		}

		// Token: 0x0602F977 RID: 194935 RVA: 0x0067C777 File Offset: 0x0067A977
		public void UnPackTo(IDestroyQuestItemT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
			_o.IsAll = this.IsAll;
		}

		// Token: 0x0602F978 RID: 194936 RVA: 0x0067C7A0 File Offset: 0x0067A9A0
		public static Offset<IDestroyQuestItem> Pack(FlatBufferBuilder builder, IDestroyQuestItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyQuestItem>);
			}
			return IDestroyQuestItem.CreateIDestroyQuestItem(builder, _o.ItemId, _o.Count, _o.IsAll);
		}

		// Token: 0x04011A05 RID: 72197
		private Table __p;
	}
}
