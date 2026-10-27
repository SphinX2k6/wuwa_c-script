using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DFD RID: 15869
	public struct IEnterDungeonIdCondition : IFlatbufferObject
	{
		// Token: 0x17006DAB RID: 28075
		// (get) Token: 0x06016321 RID: 90913 RVA: 0x003349FF File Offset: 0x00332BFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016322 RID: 90914 RVA: 0x00334A0C File Offset: 0x00332C0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016323 RID: 90915 RVA: 0x00334A14 File Offset: 0x00332C14
		public static IEnterDungeonIdCondition GetRootAsIEnterDungeonIdCondition(ByteBuffer _bb)
		{
			return IEnterDungeonIdCondition.GetRootAsIEnterDungeonIdCondition(_bb, default(IEnterDungeonIdCondition));
		}

		// Token: 0x06016324 RID: 90916 RVA: 0x00334A30 File Offset: 0x00332C30
		public static IEnterDungeonIdCondition GetRootAsIEnterDungeonIdCondition(ByteBuffer _bb, IEnterDungeonIdCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016325 RID: 90917 RVA: 0x00334A4D File Offset: 0x00332C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016326 RID: 90918 RVA: 0x00334A5C File Offset: 0x00332C5C
		public IEnterDungeonIdCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DAC RID: 28076
		// (get) Token: 0x06016327 RID: 90919 RVA: 0x00334A6C File Offset: 0x00332C6C
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

		// Token: 0x17006DAD RID: 28077
		// (get) Token: 0x06016328 RID: 90920 RVA: 0x00334AA8 File Offset: 0x00332CA8
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

		// Token: 0x06016329 RID: 90921 RVA: 0x00334AE4 File Offset: 0x00332CE4
		public static Offset<IEnterDungeonIdCondition> CreateIEnterDungeonIdCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, int DungeonId = 0)
		{
			builder.StartTable(2);
			IEnterDungeonIdCondition.AddDungeonId(builder, DungeonId);
			IEnterDungeonIdCondition.AddType(builder, Type);
			return IEnterDungeonIdCondition.EndIEnterDungeonIdCondition(builder);
		}

		// Token: 0x0601632A RID: 90922 RVA: 0x00334B01 File Offset: 0x00332D01
		public static void StartIEnterDungeonIdCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601632B RID: 90923 RVA: 0x00334B0A File Offset: 0x00332D0A
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601632C RID: 90924 RVA: 0x00334B15 File Offset: 0x00332D15
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601632D RID: 90925 RVA: 0x00334B20 File Offset: 0x00332D20
		public static Offset<IEnterDungeonIdCondition> EndIEnterDungeonIdCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeonIdCondition>(builder.EndTable());
		}

		// Token: 0x0601632E RID: 90926 RVA: 0x00334B30 File Offset: 0x00332D30
		public IEnterDungeonIdConditionT UnPack()
		{
			IEnterDungeonIdConditionT enterDungeonIdConditionT = new IEnterDungeonIdConditionT();
			this.UnPackTo(enterDungeonIdConditionT);
			return enterDungeonIdConditionT;
		}

		// Token: 0x0601632F RID: 90927 RVA: 0x00334B4B File Offset: 0x00332D4B
		public void UnPackTo(IEnterDungeonIdConditionT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
		}

		// Token: 0x06016330 RID: 90928 RVA: 0x00334B68 File Offset: 0x00332D68
		public static Offset<IEnterDungeonIdCondition> Pack(FlatBufferBuilder builder, IEnterDungeonIdConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeonIdCondition>);
			}
			return IEnterDungeonIdCondition.CreateIEnterDungeonIdCondition(builder, _o.Type, _o.DungeonId);
		}

		// Token: 0x0400B768 RID: 46952
		private Table __p;
	}
}
