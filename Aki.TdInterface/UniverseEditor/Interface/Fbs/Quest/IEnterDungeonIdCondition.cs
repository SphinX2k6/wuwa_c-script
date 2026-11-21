using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004238 RID: 16952
	public struct IEnterDungeonIdCondition : IFlatbufferObject
	{
		// Token: 0x17007391 RID: 29585
		// (get) Token: 0x0601794E RID: 96590 RVA: 0x0035D5F7 File Offset: 0x0035B7F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601794F RID: 96591 RVA: 0x0035D604 File Offset: 0x0035B804
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017950 RID: 96592 RVA: 0x0035D60C File Offset: 0x0035B80C
		public static IEnterDungeonIdCondition GetRootAsIEnterDungeonIdCondition(ByteBuffer _bb)
		{
			return IEnterDungeonIdCondition.GetRootAsIEnterDungeonIdCondition(_bb, default(IEnterDungeonIdCondition));
		}

		// Token: 0x06017951 RID: 96593 RVA: 0x0035D628 File Offset: 0x0035B828
		public static IEnterDungeonIdCondition GetRootAsIEnterDungeonIdCondition(ByteBuffer _bb, IEnterDungeonIdCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017952 RID: 96594 RVA: 0x0035D645 File Offset: 0x0035B845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017953 RID: 96595 RVA: 0x0035D654 File Offset: 0x0035B854
		public IEnterDungeonIdCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007392 RID: 29586
		// (get) Token: 0x06017954 RID: 96596 RVA: 0x0035D664 File Offset: 0x0035B864
		public EDungeonConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return (EDungeonConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007393 RID: 29587
		// (get) Token: 0x06017955 RID: 96597 RVA: 0x0035D6A0 File Offset: 0x0035B8A0
		public int DungeonId
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

		// Token: 0x06017956 RID: 96598 RVA: 0x0035D6DC File Offset: 0x0035B8DC
		public static Offset<IEnterDungeonIdCondition> CreateIEnterDungeonIdCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, int DungeonId = 0)
		{
			builder.StartTable(2);
			IEnterDungeonIdCondition.AddDungeonId(builder, DungeonId);
			IEnterDungeonIdCondition.AddType(builder, Type);
			return IEnterDungeonIdCondition.EndIEnterDungeonIdCondition(builder);
		}

		// Token: 0x06017957 RID: 96599 RVA: 0x0035D6F9 File Offset: 0x0035B8F9
		public static void StartIEnterDungeonIdCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017958 RID: 96600 RVA: 0x0035D702 File Offset: 0x0035B902
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017959 RID: 96601 RVA: 0x0035D70D File Offset: 0x0035B90D
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601795A RID: 96602 RVA: 0x0035D718 File Offset: 0x0035B918
		public static Offset<IEnterDungeonIdCondition> EndIEnterDungeonIdCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeonIdCondition>(builder.EndTable());
		}

		// Token: 0x0601795B RID: 96603 RVA: 0x0035D728 File Offset: 0x0035B928
		public IEnterDungeonIdConditionT UnPack()
		{
			IEnterDungeonIdConditionT enterDungeonIdConditionT = new IEnterDungeonIdConditionT();
			this.UnPackTo(enterDungeonIdConditionT);
			return enterDungeonIdConditionT;
		}

		// Token: 0x0601795C RID: 96604 RVA: 0x0035D743 File Offset: 0x0035B943
		public void UnPackTo(IEnterDungeonIdConditionT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
		}

		// Token: 0x0601795D RID: 96605 RVA: 0x0035D760 File Offset: 0x0035B960
		public static Offset<IEnterDungeonIdCondition> Pack(FlatBufferBuilder builder, IEnterDungeonIdConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeonIdCondition>);
			}
			return IEnterDungeonIdCondition.CreateIEnterDungeonIdCondition(builder, _o.Type, _o.DungeonId);
		}

		// Token: 0x0400C140 RID: 49472
		private Table __p;
	}
}
