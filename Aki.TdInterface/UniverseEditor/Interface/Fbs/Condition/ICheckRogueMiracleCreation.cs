using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B11 RID: 19217
	public struct ICheckRogueMiracleCreation : IFlatbufferObject
	{
		// Token: 0x17008B69 RID: 35689
		// (get) Token: 0x0601E396 RID: 123798 RVA: 0x0043CD28 File Offset: 0x0043AF28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E397 RID: 123799 RVA: 0x0043CD35 File Offset: 0x0043AF35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E398 RID: 123800 RVA: 0x0043CD3C File Offset: 0x0043AF3C
		public static ICheckRogueMiracleCreation GetRootAsICheckRogueMiracleCreation(ByteBuffer _bb)
		{
			return ICheckRogueMiracleCreation.GetRootAsICheckRogueMiracleCreation(_bb, default(ICheckRogueMiracleCreation));
		}

		// Token: 0x0601E399 RID: 123801 RVA: 0x0043CD58 File Offset: 0x0043AF58
		public static ICheckRogueMiracleCreation GetRootAsICheckRogueMiracleCreation(ByteBuffer _bb, ICheckRogueMiracleCreation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E39A RID: 123802 RVA: 0x0043CD75 File Offset: 0x0043AF75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E39B RID: 123803 RVA: 0x0043CD84 File Offset: 0x0043AF84
		public ICheckRogueMiracleCreation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B6A RID: 35690
		// (get) Token: 0x0601E39C RID: 123804 RVA: 0x0043CD94 File Offset: 0x0043AF94
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

		// Token: 0x17008B6B RID: 35691
		// (get) Token: 0x0601E39D RID: 123805 RVA: 0x0043CDD0 File Offset: 0x0043AFD0
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

		// Token: 0x0601E39E RID: 123806 RVA: 0x0043CE0C File Offset: 0x0043B00C
		public static Offset<ICheckRogueMiracleCreation> CreateICheckRogueMiracleCreation(FlatBufferBuilder builder, ERogueStateType Type = ERogueStateType.Talent, int Id = 0)
		{
			builder.StartTable(2);
			ICheckRogueMiracleCreation.AddId(builder, Id);
			ICheckRogueMiracleCreation.AddType(builder, Type);
			return ICheckRogueMiracleCreation.EndICheckRogueMiracleCreation(builder);
		}

		// Token: 0x0601E39F RID: 123807 RVA: 0x0043CE29 File Offset: 0x0043B029
		public static void StartICheckRogueMiracleCreation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E3A0 RID: 123808 RVA: 0x0043CE32 File Offset: 0x0043B032
		public static void AddType(FlatBufferBuilder builder, ERogueStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E3A1 RID: 123809 RVA: 0x0043CE3D File Offset: 0x0043B03D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601E3A2 RID: 123810 RVA: 0x0043CE48 File Offset: 0x0043B048
		public static Offset<ICheckRogueMiracleCreation> EndICheckRogueMiracleCreation(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueMiracleCreation>(builder.EndTable());
		}

		// Token: 0x0601E3A3 RID: 123811 RVA: 0x0043CE58 File Offset: 0x0043B058
		public ICheckRogueMiracleCreationT UnPack()
		{
			ICheckRogueMiracleCreationT checkRogueMiracleCreationT = new ICheckRogueMiracleCreationT();
			this.UnPackTo(checkRogueMiracleCreationT);
			return checkRogueMiracleCreationT;
		}

		// Token: 0x0601E3A4 RID: 123812 RVA: 0x0043CE73 File Offset: 0x0043B073
		public void UnPackTo(ICheckRogueMiracleCreationT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601E3A5 RID: 123813 RVA: 0x0043CE90 File Offset: 0x0043B090
		public static Offset<ICheckRogueMiracleCreation> Pack(FlatBufferBuilder builder, ICheckRogueMiracleCreationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueMiracleCreation>);
			}
			return ICheckRogueMiracleCreation.CreateICheckRogueMiracleCreation(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400D3AE RID: 54190
		private Table __p;
	}
}
