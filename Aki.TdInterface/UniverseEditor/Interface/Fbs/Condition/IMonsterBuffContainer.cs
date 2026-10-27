using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C55 RID: 19541
	public struct IMonsterBuffContainer : IFlatbufferObject
	{
		// Token: 0x17008DFB RID: 36347
		// (get) Token: 0x0601EFBF RID: 126911 RVA: 0x004556E2 File Offset: 0x004538E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFC0 RID: 126912 RVA: 0x004556EF File Offset: 0x004538EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFC1 RID: 126913 RVA: 0x004556F8 File Offset: 0x004538F8
		public static IMonsterBuffContainer GetRootAsIMonsterBuffContainer(ByteBuffer _bb)
		{
			return IMonsterBuffContainer.GetRootAsIMonsterBuffContainer(_bb, default(IMonsterBuffContainer));
		}

		// Token: 0x0601EFC2 RID: 126914 RVA: 0x00455714 File Offset: 0x00453914
		public static IMonsterBuffContainer GetRootAsIMonsterBuffContainer(ByteBuffer _bb, IMonsterBuffContainer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFC3 RID: 126915 RVA: 0x00455731 File Offset: 0x00453931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFC4 RID: 126916 RVA: 0x00455740 File Offset: 0x00453940
		public IMonsterBuffContainer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DFC RID: 36348
		// (get) Token: 0x0601EFC5 RID: 126917 RVA: 0x00455750 File Offset: 0x00453950
		public ETargetBuffContainer Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBuffContainer.Monster;
				}
				return (ETargetBuffContainer)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DFD RID: 36349
		// (get) Token: 0x0601EFC6 RID: 126918 RVA: 0x0045578C File Offset: 0x0045398C
		public int MonsterEntityId
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

		// Token: 0x0601EFC7 RID: 126919 RVA: 0x004557C8 File Offset: 0x004539C8
		public static Offset<IMonsterBuffContainer> CreateIMonsterBuffContainer(FlatBufferBuilder builder, ETargetBuffContainer Type = ETargetBuffContainer.Monster, int MonsterEntityId = 0)
		{
			builder.StartTable(2);
			IMonsterBuffContainer.AddMonsterEntityId(builder, MonsterEntityId);
			IMonsterBuffContainer.AddType(builder, Type);
			return IMonsterBuffContainer.EndIMonsterBuffContainer(builder);
		}

		// Token: 0x0601EFC8 RID: 126920 RVA: 0x004557E5 File Offset: 0x004539E5
		public static void StartIMonsterBuffContainer(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EFC9 RID: 126921 RVA: 0x004557EE File Offset: 0x004539EE
		public static void AddType(FlatBufferBuilder builder, ETargetBuffContainer type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFCA RID: 126922 RVA: 0x004557F9 File Offset: 0x004539F9
		public static void AddMonsterEntityId(FlatBufferBuilder builder, int monsterEntityId)
		{
			builder.AddInt(1, monsterEntityId, 0);
		}

		// Token: 0x0601EFCB RID: 126923 RVA: 0x00455804 File Offset: 0x00453A04
		public static Offset<IMonsterBuffContainer> EndIMonsterBuffContainer(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterBuffContainer>(builder.EndTable());
		}

		// Token: 0x0601EFCC RID: 126924 RVA: 0x00455814 File Offset: 0x00453A14
		public IMonsterBuffContainerT UnPack()
		{
			IMonsterBuffContainerT monsterBuffContainerT = new IMonsterBuffContainerT();
			this.UnPackTo(monsterBuffContainerT);
			return monsterBuffContainerT;
		}

		// Token: 0x0601EFCD RID: 126925 RVA: 0x0045582F File Offset: 0x00453A2F
		public void UnPackTo(IMonsterBuffContainerT _o)
		{
			_o.Type = this.Type;
			_o.MonsterEntityId = this.MonsterEntityId;
		}

		// Token: 0x0601EFCE RID: 126926 RVA: 0x0045584C File Offset: 0x00453A4C
		public static Offset<IMonsterBuffContainer> Pack(FlatBufferBuilder builder, IMonsterBuffContainerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterBuffContainer>);
			}
			return IMonsterBuffContainer.CreateIMonsterBuffContainer(builder, _o.Type, _o.MonsterEntityId);
		}

		// Token: 0x0400D5FF RID: 54783
		private Table __p;
	}
}
