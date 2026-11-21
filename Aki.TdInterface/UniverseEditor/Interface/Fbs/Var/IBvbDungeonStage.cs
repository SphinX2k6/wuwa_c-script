using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E2C RID: 15916
	public struct IBvbDungeonStage : IFlatbufferObject
	{
		// Token: 0x17006B89 RID: 27529
		// (get) Token: 0x060156B4 RID: 87732 RVA: 0x00317A71 File Offset: 0x00315C71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060156B5 RID: 87733 RVA: 0x00317A7E File Offset: 0x00315C7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060156B6 RID: 87734 RVA: 0x00317A88 File Offset: 0x00315C88
		public static IBvbDungeonStage GetRootAsIBvbDungeonStage(ByteBuffer _bb)
		{
			return IBvbDungeonStage.GetRootAsIBvbDungeonStage(_bb, default(IBvbDungeonStage));
		}

		// Token: 0x060156B7 RID: 87735 RVA: 0x00317AA4 File Offset: 0x00315CA4
		public static IBvbDungeonStage GetRootAsIBvbDungeonStage(ByteBuffer _bb, IBvbDungeonStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060156B8 RID: 87736 RVA: 0x00317AC1 File Offset: 0x00315CC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060156B9 RID: 87737 RVA: 0x00317AD0 File Offset: 0x00315CD0
		public IBvbDungeonStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B8A RID: 27530
		// (get) Token: 0x060156BA RID: 87738 RVA: 0x00317AE0 File Offset: 0x00315CE0
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060156BB RID: 87739 RVA: 0x00317B1C File Offset: 0x00315D1C
		public static Offset<IBvbDungeonStage> CreateIBvbDungeonStage(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbDungeonStage.AddType(builder, Type);
			return IBvbDungeonStage.EndIBvbDungeonStage(builder);
		}

		// Token: 0x060156BC RID: 87740 RVA: 0x00317B32 File Offset: 0x00315D32
		public static void StartIBvbDungeonStage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060156BD RID: 87741 RVA: 0x00317B3B File Offset: 0x00315D3B
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060156BE RID: 87742 RVA: 0x00317B46 File Offset: 0x00315D46
		public static Offset<IBvbDungeonStage> EndIBvbDungeonStage(FlatBufferBuilder builder)
		{
			return new Offset<IBvbDungeonStage>(builder.EndTable());
		}

		// Token: 0x060156BF RID: 87743 RVA: 0x00317B54 File Offset: 0x00315D54
		public IBvbDungeonStageT UnPack()
		{
			IBvbDungeonStageT bvbDungeonStageT = new IBvbDungeonStageT();
			this.UnPackTo(bvbDungeonStageT);
			return bvbDungeonStageT;
		}

		// Token: 0x060156C0 RID: 87744 RVA: 0x00317B6F File Offset: 0x00315D6F
		public void UnPackTo(IBvbDungeonStageT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060156C1 RID: 87745 RVA: 0x00317B80 File Offset: 0x00315D80
		public static Offset<IBvbDungeonStage> Pack(FlatBufferBuilder builder, IBvbDungeonStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbDungeonStage>);
			}
			return IBvbDungeonStage.CreateIBvbDungeonStage(builder, _o.Type);
		}

		// Token: 0x0400B7F9 RID: 47097
		private Table __p;
	}
}
