using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006714 RID: 26388
	public struct IExecRiskHarvestEffect : IFlatbufferObject
	{
		// Token: 0x1700C403 RID: 50179
		// (get) Token: 0x0602DE55 RID: 187989 RVA: 0x0064693D File Offset: 0x00644B3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE56 RID: 187990 RVA: 0x0064694A File Offset: 0x00644B4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE57 RID: 187991 RVA: 0x00646954 File Offset: 0x00644B54
		public static IExecRiskHarvestEffect GetRootAsIExecRiskHarvestEffect(ByteBuffer _bb)
		{
			return IExecRiskHarvestEffect.GetRootAsIExecRiskHarvestEffect(_bb, default(IExecRiskHarvestEffect));
		}

		// Token: 0x0602DE58 RID: 187992 RVA: 0x00646970 File Offset: 0x00644B70
		public static IExecRiskHarvestEffect GetRootAsIExecRiskHarvestEffect(ByteBuffer _bb, IExecRiskHarvestEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE59 RID: 187993 RVA: 0x0064698D File Offset: 0x00644B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE5A RID: 187994 RVA: 0x0064699C File Offset: 0x00644B9C
		public IExecRiskHarvestEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C404 RID: 50180
		// (get) Token: 0x0602DE5B RID: 187995 RVA: 0x006469AC File Offset: 0x00644BAC
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

		// Token: 0x0602DE5C RID: 187996 RVA: 0x006469E8 File Offset: 0x00644BE8
		public static Offset<IExecRiskHarvestEffect> CreateIExecRiskHarvestEffect(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IExecRiskHarvestEffect.AddId(builder, Id);
			return IExecRiskHarvestEffect.EndIExecRiskHarvestEffect(builder);
		}

		// Token: 0x0602DE5D RID: 187997 RVA: 0x006469FE File Offset: 0x00644BFE
		public static void StartIExecRiskHarvestEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DE5E RID: 187998 RVA: 0x00646A07 File Offset: 0x00644C07
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602DE5F RID: 187999 RVA: 0x00646A12 File Offset: 0x00644C12
		public static Offset<IExecRiskHarvestEffect> EndIExecRiskHarvestEffect(FlatBufferBuilder builder)
		{
			return new Offset<IExecRiskHarvestEffect>(builder.EndTable());
		}

		// Token: 0x0602DE60 RID: 188000 RVA: 0x00646A20 File Offset: 0x00644C20
		public IExecRiskHarvestEffectT UnPack()
		{
			IExecRiskHarvestEffectT execRiskHarvestEffectT = new IExecRiskHarvestEffectT();
			this.UnPackTo(execRiskHarvestEffectT);
			return execRiskHarvestEffectT;
		}

		// Token: 0x0602DE61 RID: 188001 RVA: 0x00646A3B File Offset: 0x00644C3B
		public void UnPackTo(IExecRiskHarvestEffectT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0602DE62 RID: 188002 RVA: 0x00646A4C File Offset: 0x00644C4C
		public static Offset<IExecRiskHarvestEffect> Pack(FlatBufferBuilder builder, IExecRiskHarvestEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecRiskHarvestEffect>);
			}
			return IExecRiskHarvestEffect.CreateIExecRiskHarvestEffect(builder, _o.Id);
		}

		// Token: 0x04010DFA RID: 69114
		private Table __p;
	}
}
