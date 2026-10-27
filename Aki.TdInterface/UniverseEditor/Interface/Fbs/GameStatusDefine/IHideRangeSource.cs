using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046FA RID: 18170
	public struct IHideRangeSource : IFlatbufferObject
	{
		// Token: 0x170081EA RID: 33258
		// (get) Token: 0x0601BD2F RID: 113967 RVA: 0x003F18C4 File Offset: 0x003EFAC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD30 RID: 113968 RVA: 0x003F18D1 File Offset: 0x003EFAD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD31 RID: 113969 RVA: 0x003F18D8 File Offset: 0x003EFAD8
		public static IHideRangeSource GetRootAsIHideRangeSource(ByteBuffer _bb)
		{
			return IHideRangeSource.GetRootAsIHideRangeSource(_bb, default(IHideRangeSource));
		}

		// Token: 0x0601BD32 RID: 113970 RVA: 0x003F18F4 File Offset: 0x003EFAF4
		public static IHideRangeSource GetRootAsIHideRangeSource(ByteBuffer _bb, IHideRangeSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD33 RID: 113971 RVA: 0x003F1911 File Offset: 0x003EFB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD34 RID: 113972 RVA: 0x003F1920 File Offset: 0x003EFB20
		public IHideRangeSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081EB RID: 33259
		// (get) Token: 0x0601BD35 RID: 113973 RVA: 0x003F1930 File Offset: 0x003EFB30
		public TBehaviorTreeType TreeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TBehaviorTreeType.BehaviorTreeFragment;
				}
				return (TBehaviorTreeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081EC RID: 33260
		// (get) Token: 0x0601BD36 RID: 113974 RVA: 0x003F196C File Offset: 0x003EFB6C
		public int TreeId
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

		// Token: 0x170081ED RID: 33261
		// (get) Token: 0x0601BD37 RID: 113975 RVA: 0x003F19A8 File Offset: 0x003EFBA8
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081EE RID: 33262
		// (get) Token: 0x0601BD38 RID: 113976 RVA: 0x003F19E4 File Offset: 0x003EFBE4
		public int NodeId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081EF RID: 33263
		// (get) Token: 0x0601BD39 RID: 113977 RVA: 0x003F1A24 File Offset: 0x003EFC24
		public int ActionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081F0 RID: 33264
		// (get) Token: 0x0601BD3A RID: 113978 RVA: 0x003F1A64 File Offset: 0x003EFC64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BD3B RID: 113979 RVA: 0x003F1AA1 File Offset: 0x003EFCA1
		public static Offset<IHideRangeSource> CreateIHideRangeSource(FlatBufferBuilder builder, TBehaviorTreeType TreeType = TBehaviorTreeType.BehaviorTreeFragment, int TreeId = 0, int LevelId = 0, int NodeId = 0, int ActionId = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IHideRangeSource.AddActionId(builder, ActionId);
			IHideRangeSource.AddNodeId(builder, NodeId);
			IHideRangeSource.AddLevelId(builder, LevelId);
			IHideRangeSource.AddTreeId(builder, TreeId);
			IHideRangeSource.AddNullMask(builder, NullMask);
			IHideRangeSource.AddTreeType(builder, TreeType);
			return IHideRangeSource.EndIHideRangeSource(builder);
		}

		// Token: 0x0601BD3C RID: 113980 RVA: 0x003F1ADD File Offset: 0x003EFCDD
		public static void StartIHideRangeSource(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601BD3D RID: 113981 RVA: 0x003F1AE6 File Offset: 0x003EFCE6
		public static void AddTreeType(FlatBufferBuilder builder, TBehaviorTreeType treeType)
		{
			builder.AddByte(0, (byte)treeType, 0);
		}

		// Token: 0x0601BD3E RID: 113982 RVA: 0x003F1AF1 File Offset: 0x003EFCF1
		public static void AddTreeId(FlatBufferBuilder builder, int treeId)
		{
			builder.AddInt(1, treeId, 0);
		}

		// Token: 0x0601BD3F RID: 113983 RVA: 0x003F1AFC File Offset: 0x003EFCFC
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x0601BD40 RID: 113984 RVA: 0x003F1B07 File Offset: 0x003EFD07
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(3, nodeId, 0);
		}

		// Token: 0x0601BD41 RID: 113985 RVA: 0x003F1B12 File Offset: 0x003EFD12
		public static void AddActionId(FlatBufferBuilder builder, int actionId)
		{
			builder.AddInt(4, actionId, 0);
		}

		// Token: 0x0601BD42 RID: 113986 RVA: 0x003F1B1D File Offset: 0x003EFD1D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601BD43 RID: 113987 RVA: 0x003F1B28 File Offset: 0x003EFD28
		public static Offset<IHideRangeSource> EndIHideRangeSource(FlatBufferBuilder builder)
		{
			return new Offset<IHideRangeSource>(builder.EndTable());
		}

		// Token: 0x0601BD44 RID: 113988 RVA: 0x003F1B38 File Offset: 0x003EFD38
		public IHideRangeSourceT UnPack()
		{
			IHideRangeSourceT hideRangeSourceT = new IHideRangeSourceT();
			this.UnPackTo(hideRangeSourceT);
			return hideRangeSourceT;
		}

		// Token: 0x0601BD45 RID: 113989 RVA: 0x003F1B54 File Offset: 0x003EFD54
		public void UnPackTo(IHideRangeSourceT _o)
		{
			_o.TreeType = this.TreeType;
			_o.TreeId = this.TreeId;
			_o.LevelId = this.LevelId;
			_o.NodeId = this.NodeId;
			_o.ActionId = this.ActionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BD46 RID: 113990 RVA: 0x003F1BAC File Offset: 0x003EFDAC
		public static Offset<IHideRangeSource> Pack(FlatBufferBuilder builder, IHideRangeSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideRangeSource>);
			}
			return IHideRangeSource.CreateIHideRangeSource(builder, _o.TreeType, _o.TreeId, _o.LevelId, _o.NodeId, _o.ActionId, _o.NullMask);
		}

		// Token: 0x0400C9A7 RID: 51623
		private Table __p;
	}
}
