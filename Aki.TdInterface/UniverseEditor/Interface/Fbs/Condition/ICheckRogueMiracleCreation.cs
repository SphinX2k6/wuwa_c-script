using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF8 RID: 20472
	public struct ICheckRogueMiracleCreation : IFlatbufferObject
	{
		// Token: 0x17009279 RID: 37497
		// (get) Token: 0x0601FF21 RID: 130849 RVA: 0x0046F4D4 File Offset: 0x0046D6D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF22 RID: 130850 RVA: 0x0046F4E1 File Offset: 0x0046D6E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF23 RID: 130851 RVA: 0x0046F4E8 File Offset: 0x0046D6E8
		public static ICheckRogueMiracleCreation GetRootAsICheckRogueMiracleCreation(ByteBuffer _bb)
		{
			return ICheckRogueMiracleCreation.GetRootAsICheckRogueMiracleCreation(_bb, default(ICheckRogueMiracleCreation));
		}

		// Token: 0x0601FF24 RID: 130852 RVA: 0x0046F504 File Offset: 0x0046D704
		public static ICheckRogueMiracleCreation GetRootAsICheckRogueMiracleCreation(ByteBuffer _bb, ICheckRogueMiracleCreation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF25 RID: 130853 RVA: 0x0046F521 File Offset: 0x0046D721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF26 RID: 130854 RVA: 0x0046F530 File Offset: 0x0046D730
		public ICheckRogueMiracleCreation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700927A RID: 37498
		// (get) Token: 0x0601FF27 RID: 130855 RVA: 0x0046F540 File Offset: 0x0046D740
		public ERogueStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueStateType.Talent;
				}
				return (ERogueStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700927B RID: 37499
		// (get) Token: 0x0601FF28 RID: 130856 RVA: 0x0046F57C File Offset: 0x0046D77C
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

		// Token: 0x0601FF29 RID: 130857 RVA: 0x0046F5B8 File Offset: 0x0046D7B8
		public static Offset<ICheckRogueMiracleCreation> CreateICheckRogueMiracleCreation(FlatBufferBuilder builder, ERogueStateType Type = ERogueStateType.Talent, int Id = 0)
		{
			builder.StartTable(2);
			ICheckRogueMiracleCreation.AddId(builder, Id);
			ICheckRogueMiracleCreation.AddType(builder, Type);
			return ICheckRogueMiracleCreation.EndICheckRogueMiracleCreation(builder);
		}

		// Token: 0x0601FF2A RID: 130858 RVA: 0x0046F5D5 File Offset: 0x0046D7D5
		public static void StartICheckRogueMiracleCreation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FF2B RID: 130859 RVA: 0x0046F5DE File Offset: 0x0046D7DE
		public static void AddType(FlatBufferBuilder builder, ERogueStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF2C RID: 130860 RVA: 0x0046F5E9 File Offset: 0x0046D7E9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601FF2D RID: 130861 RVA: 0x0046F5F4 File Offset: 0x0046D7F4
		public static Offset<ICheckRogueMiracleCreation> EndICheckRogueMiracleCreation(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueMiracleCreation>(builder.EndTable());
		}

		// Token: 0x0601FF2E RID: 130862 RVA: 0x0046F604 File Offset: 0x0046D804
		public ICheckRogueMiracleCreationT UnPack()
		{
			ICheckRogueMiracleCreationT checkRogueMiracleCreationT = new ICheckRogueMiracleCreationT();
			this.UnPackTo(checkRogueMiracleCreationT);
			return checkRogueMiracleCreationT;
		}

		// Token: 0x0601FF2F RID: 130863 RVA: 0x0046F61F File Offset: 0x0046D81F
		public void UnPackTo(ICheckRogueMiracleCreationT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601FF30 RID: 130864 RVA: 0x0046F63C File Offset: 0x0046D83C
		public static Offset<ICheckRogueMiracleCreation> Pack(FlatBufferBuilder builder, ICheckRogueMiracleCreationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueMiracleCreation>);
			}
			return ICheckRogueMiracleCreation.CreateICheckRogueMiracleCreation(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400DEAD RID: 57005
		private Table __p;
	}
}
