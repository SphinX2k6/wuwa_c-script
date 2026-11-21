using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D94 RID: 28052
	public struct IExecRiskHarvestEffect : IFlatbufferObject
	{
		// Token: 0x1700CDB9 RID: 52665
		// (get) Token: 0x0603069B RID: 198299 RVA: 0x00694081 File Offset: 0x00692281
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603069C RID: 198300 RVA: 0x0069408E File Offset: 0x0069228E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603069D RID: 198301 RVA: 0x00694098 File Offset: 0x00692298
		public static IExecRiskHarvestEffect GetRootAsIExecRiskHarvestEffect(ByteBuffer _bb)
		{
			return IExecRiskHarvestEffect.GetRootAsIExecRiskHarvestEffect(_bb, default(IExecRiskHarvestEffect));
		}

		// Token: 0x0603069E RID: 198302 RVA: 0x006940B4 File Offset: 0x006922B4
		public static IExecRiskHarvestEffect GetRootAsIExecRiskHarvestEffect(ByteBuffer _bb, IExecRiskHarvestEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603069F RID: 198303 RVA: 0x006940D1 File Offset: 0x006922D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306A0 RID: 198304 RVA: 0x006940E0 File Offset: 0x006922E0
		public IExecRiskHarvestEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDBA RID: 52666
		// (get) Token: 0x060306A1 RID: 198305 RVA: 0x006940F0 File Offset: 0x006922F0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060306A2 RID: 198306 RVA: 0x0069412C File Offset: 0x0069232C
		public static Offset<IExecRiskHarvestEffect> CreateIExecRiskHarvestEffect(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IExecRiskHarvestEffect.AddId(builder, Id);
			return IExecRiskHarvestEffect.EndIExecRiskHarvestEffect(builder);
		}

		// Token: 0x060306A3 RID: 198307 RVA: 0x00694142 File Offset: 0x00692342
		public static void StartIExecRiskHarvestEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060306A4 RID: 198308 RVA: 0x0069414B File Offset: 0x0069234B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060306A5 RID: 198309 RVA: 0x00694156 File Offset: 0x00692356
		public static Offset<IExecRiskHarvestEffect> EndIExecRiskHarvestEffect(FlatBufferBuilder builder)
		{
			return new Offset<IExecRiskHarvestEffect>(builder.EndTable());
		}

		// Token: 0x060306A6 RID: 198310 RVA: 0x00694164 File Offset: 0x00692364
		public IExecRiskHarvestEffectT UnPack()
		{
			IExecRiskHarvestEffectT execRiskHarvestEffectT = new IExecRiskHarvestEffectT();
			this.UnPackTo(execRiskHarvestEffectT);
			return execRiskHarvestEffectT;
		}

		// Token: 0x060306A7 RID: 198311 RVA: 0x0069417F File Offset: 0x0069237F
		public void UnPackTo(IExecRiskHarvestEffectT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x060306A8 RID: 198312 RVA: 0x00694190 File Offset: 0x00692390
		public static Offset<IExecRiskHarvestEffect> Pack(FlatBufferBuilder builder, IExecRiskHarvestEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecRiskHarvestEffect>);
			}
			return IExecRiskHarvestEffect.CreateIExecRiskHarvestEffect(builder, _o.Id);
		}

		// Token: 0x04011C2C RID: 72748
		private Table __p;
	}
}
