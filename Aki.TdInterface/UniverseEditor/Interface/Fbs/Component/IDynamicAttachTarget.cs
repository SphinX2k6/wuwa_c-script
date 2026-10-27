using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D2 RID: 20690
	public struct IDynamicAttachTarget : IFlatbufferObject
	{
		// Token: 0x17009695 RID: 38549
		// (get) Token: 0x06021495 RID: 136341 RVA: 0x0049F8B4 File Offset: 0x0049DAB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021496 RID: 136342 RVA: 0x0049F8C1 File Offset: 0x0049DAC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021497 RID: 136343 RVA: 0x0049F8C8 File Offset: 0x0049DAC8
		public static IDynamicAttachTarget GetRootAsIDynamicAttachTarget(ByteBuffer _bb)
		{
			return IDynamicAttachTarget.GetRootAsIDynamicAttachTarget(_bb, default(IDynamicAttachTarget));
		}

		// Token: 0x06021498 RID: 136344 RVA: 0x0049F8E4 File Offset: 0x0049DAE4
		public static IDynamicAttachTarget GetRootAsIDynamicAttachTarget(ByteBuffer _bb, IDynamicAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021499 RID: 136345 RVA: 0x0049F901 File Offset: 0x0049DB01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602149A RID: 136346 RVA: 0x0049F910 File Offset: 0x0049DB10
		public IDynamicAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009696 RID: 38550
		// (get) Token: 0x0602149B RID: 136347 RVA: 0x0049F920 File Offset: 0x0049DB20
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602149C RID: 136348 RVA: 0x0049F95C File Offset: 0x0049DB5C
		public static Offset<IDynamicAttachTarget> CreateIDynamicAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor)
		{
			builder.StartTable(1);
			IDynamicAttachTarget.AddType(builder, Type);
			return IDynamicAttachTarget.EndIDynamicAttachTarget(builder);
		}

		// Token: 0x0602149D RID: 136349 RVA: 0x0049F972 File Offset: 0x0049DB72
		public static void StartIDynamicAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602149E RID: 136350 RVA: 0x0049F97B File Offset: 0x0049DB7B
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602149F RID: 136351 RVA: 0x0049F986 File Offset: 0x0049DB86
		public static Offset<IDynamicAttachTarget> EndIDynamicAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicAttachTarget>(builder.EndTable());
		}

		// Token: 0x060214A0 RID: 136352 RVA: 0x0049F994 File Offset: 0x0049DB94
		public IDynamicAttachTargetT UnPack()
		{
			IDynamicAttachTargetT dynamicAttachTargetT = new IDynamicAttachTargetT();
			this.UnPackTo(dynamicAttachTargetT);
			return dynamicAttachTargetT;
		}

		// Token: 0x060214A1 RID: 136353 RVA: 0x0049F9AF File Offset: 0x0049DBAF
		public void UnPackTo(IDynamicAttachTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060214A2 RID: 136354 RVA: 0x0049F9C0 File Offset: 0x0049DBC0
		public static Offset<IDynamicAttachTarget> Pack(FlatBufferBuilder builder, IDynamicAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicAttachTarget>);
			}
			return IDynamicAttachTarget.CreateIDynamicAttachTarget(builder, _o.Type);
		}

		// Token: 0x0400E11A RID: 57626
		private Table __p;
	}
}
