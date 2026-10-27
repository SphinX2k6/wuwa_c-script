using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D9 RID: 16601
	public struct IRoleTowerConditionStepPrepare : IFlatbufferObject
	{
		// Token: 0x1700750D RID: 29965
		// (get) Token: 0x060182FE RID: 99070 RVA: 0x0037BE09 File Offset: 0x0037A009
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182FF RID: 99071 RVA: 0x0037BE16 File Offset: 0x0037A016
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018300 RID: 99072 RVA: 0x0037BE20 File Offset: 0x0037A020
		public static IRoleTowerConditionStepPrepare GetRootAsIRoleTowerConditionStepPrepare(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepPrepare.GetRootAsIRoleTowerConditionStepPrepare(_bb, default(IRoleTowerConditionStepPrepare));
		}

		// Token: 0x06018301 RID: 99073 RVA: 0x0037BE3C File Offset: 0x0037A03C
		public static IRoleTowerConditionStepPrepare GetRootAsIRoleTowerConditionStepPrepare(ByteBuffer _bb, IRoleTowerConditionStepPrepare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018302 RID: 99074 RVA: 0x0037BE59 File Offset: 0x0037A059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018303 RID: 99075 RVA: 0x0037BE68 File Offset: 0x0037A068
		public IRoleTowerConditionStepPrepare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700750E RID: 29966
		// (get) Token: 0x06018304 RID: 99076 RVA: 0x0037BE78 File Offset: 0x0037A078
		public ERoleTowerConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return (ERoleTowerConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018305 RID: 99077 RVA: 0x0037BEB4 File Offset: 0x0037A0B4
		public static Offset<IRoleTowerConditionStepPrepare> CreateIRoleTowerConditionStepPrepare(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepPrepare.AddType(builder, Type);
			return IRoleTowerConditionStepPrepare.EndIRoleTowerConditionStepPrepare(builder);
		}

		// Token: 0x06018306 RID: 99078 RVA: 0x0037BECA File Offset: 0x0037A0CA
		public static void StartIRoleTowerConditionStepPrepare(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018307 RID: 99079 RVA: 0x0037BED3 File Offset: 0x0037A0D3
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018308 RID: 99080 RVA: 0x0037BEDE File Offset: 0x0037A0DE
		public static Offset<IRoleTowerConditionStepPrepare> EndIRoleTowerConditionStepPrepare(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepPrepare>(builder.EndTable());
		}

		// Token: 0x06018309 RID: 99081 RVA: 0x0037BEEC File Offset: 0x0037A0EC
		public IRoleTowerConditionStepPrepareT UnPack()
		{
			IRoleTowerConditionStepPrepareT roleTowerConditionStepPrepareT = new IRoleTowerConditionStepPrepareT();
			this.UnPackTo(roleTowerConditionStepPrepareT);
			return roleTowerConditionStepPrepareT;
		}

		// Token: 0x0601830A RID: 99082 RVA: 0x0037BF07 File Offset: 0x0037A107
		public void UnPackTo(IRoleTowerConditionStepPrepareT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601830B RID: 99083 RVA: 0x0037BF18 File Offset: 0x0037A118
		public static Offset<IRoleTowerConditionStepPrepare> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepPrepareT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepPrepare>);
			}
			return IRoleTowerConditionStepPrepare.CreateIRoleTowerConditionStepPrepare(builder, _o.Type);
		}

		// Token: 0x0400BC74 RID: 48244
		private Table __p;
	}
}
