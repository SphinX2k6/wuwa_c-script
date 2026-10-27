using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF7 RID: 15863
	public struct IEnterDungeon : IFlatbufferObject
	{
		// Token: 0x17006DA1 RID: 28065
		// (get) Token: 0x060162F1 RID: 90865 RVA: 0x003343F5 File Offset: 0x003325F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162F2 RID: 90866 RVA: 0x00334402 File Offset: 0x00332602
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060162F3 RID: 90867 RVA: 0x0033440C File Offset: 0x0033260C
		public static IEnterDungeon GetRootAsIEnterDungeon(ByteBuffer _bb)
		{
			return IEnterDungeon.GetRootAsIEnterDungeon(_bb, default(IEnterDungeon));
		}

		// Token: 0x060162F4 RID: 90868 RVA: 0x00334428 File Offset: 0x00332628
		public static IEnterDungeon GetRootAsIEnterDungeon(ByteBuffer _bb, IEnterDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060162F5 RID: 90869 RVA: 0x00334445 File Offset: 0x00332645
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060162F6 RID: 90870 RVA: 0x00334454 File Offset: 0x00332654
		public IEnterDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DA2 RID: 28066
		// (get) Token: 0x060162F7 RID: 90871 RVA: 0x00334464 File Offset: 0x00332664
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

		// Token: 0x060162F8 RID: 90872 RVA: 0x003344A0 File Offset: 0x003326A0
		public static Offset<IEnterDungeon> CreateIEnterDungeon(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType)
		{
			builder.StartTable(1);
			IEnterDungeon.AddType(builder, Type);
			return IEnterDungeon.EndIEnterDungeon(builder);
		}

		// Token: 0x060162F9 RID: 90873 RVA: 0x003344B6 File Offset: 0x003326B6
		public static void StartIEnterDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060162FA RID: 90874 RVA: 0x003344BF File Offset: 0x003326BF
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060162FB RID: 90875 RVA: 0x003344CA File Offset: 0x003326CA
		public static Offset<IEnterDungeon> EndIEnterDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeon>(builder.EndTable());
		}

		// Token: 0x060162FC RID: 90876 RVA: 0x003344D8 File Offset: 0x003326D8
		public IEnterDungeonT UnPack()
		{
			IEnterDungeonT enterDungeonT = new IEnterDungeonT();
			this.UnPackTo(enterDungeonT);
			return enterDungeonT;
		}

		// Token: 0x060162FD RID: 90877 RVA: 0x003344F3 File Offset: 0x003326F3
		public void UnPackTo(IEnterDungeonT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060162FE RID: 90878 RVA: 0x00334504 File Offset: 0x00332704
		public static Offset<IEnterDungeon> Pack(FlatBufferBuilder builder, IEnterDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeon>);
			}
			return IEnterDungeon.CreateIEnterDungeon(builder, _o.Type);
		}

		// Token: 0x0400B762 RID: 46946
		private Table __p;
	}
}
