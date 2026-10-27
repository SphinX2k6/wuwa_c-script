using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A51 RID: 14929
	public struct IBvbDungeonStage : IFlatbufferObject
	{
		// Token: 0x17006659 RID: 26201
		// (get) Token: 0x06014398 RID: 82840 RVA: 0x002F4885 File Offset: 0x002F2A85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014399 RID: 82841 RVA: 0x002F4892 File Offset: 0x002F2A92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601439A RID: 82842 RVA: 0x002F489C File Offset: 0x002F2A9C
		public static IBvbDungeonStage GetRootAsIBvbDungeonStage(ByteBuffer _bb)
		{
			return IBvbDungeonStage.GetRootAsIBvbDungeonStage(_bb, default(IBvbDungeonStage));
		}

		// Token: 0x0601439B RID: 82843 RVA: 0x002F48B8 File Offset: 0x002F2AB8
		public static IBvbDungeonStage GetRootAsIBvbDungeonStage(ByteBuffer _bb, IBvbDungeonStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601439C RID: 82844 RVA: 0x002F48D5 File Offset: 0x002F2AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601439D RID: 82845 RVA: 0x002F48E4 File Offset: 0x002F2AE4
		public IBvbDungeonStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x0601439E RID: 82846 RVA: 0x002F48F4 File Offset: 0x002F2AF4
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

		// Token: 0x0601439F RID: 82847 RVA: 0x002F4930 File Offset: 0x002F2B30
		public static Offset<IBvbDungeonStage> CreateIBvbDungeonStage(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbDungeonStage.AddType(builder, Type);
			return IBvbDungeonStage.EndIBvbDungeonStage(builder);
		}

		// Token: 0x060143A0 RID: 82848 RVA: 0x002F4946 File Offset: 0x002F2B46
		public static void StartIBvbDungeonStage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060143A1 RID: 82849 RVA: 0x002F494F File Offset: 0x002F2B4F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060143A2 RID: 82850 RVA: 0x002F495A File Offset: 0x002F2B5A
		public static Offset<IBvbDungeonStage> EndIBvbDungeonStage(FlatBufferBuilder builder)
		{
			return new Offset<IBvbDungeonStage>(builder.EndTable());
		}

		// Token: 0x060143A3 RID: 82851 RVA: 0x002F4968 File Offset: 0x002F2B68
		public IBvbDungeonStageT UnPack()
		{
			IBvbDungeonStageT bvbDungeonStageT = new IBvbDungeonStageT();
			this.UnPackTo(bvbDungeonStageT);
			return bvbDungeonStageT;
		}

		// Token: 0x060143A4 RID: 82852 RVA: 0x002F4983 File Offset: 0x002F2B83
		public void UnPackTo(IBvbDungeonStageT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060143A5 RID: 82853 RVA: 0x002F4994 File Offset: 0x002F2B94
		public static Offset<IBvbDungeonStage> Pack(FlatBufferBuilder builder, IBvbDungeonStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbDungeonStage>);
			}
			return IBvbDungeonStage.CreateIBvbDungeonStage(builder, _o.Type);
		}

		// Token: 0x0400AED7 RID: 44759
		private Table __p;
	}
}
