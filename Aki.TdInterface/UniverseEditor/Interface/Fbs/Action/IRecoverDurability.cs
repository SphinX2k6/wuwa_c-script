using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007591 RID: 30097
	public struct IRecoverDurability : IFlatbufferObject
	{
		// Token: 0x1700DD57 RID: 56663
		// (get) Token: 0x06034CAA RID: 216234 RVA: 0x007192F2 File Offset: 0x007174F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034CAB RID: 216235 RVA: 0x007192FF File Offset: 0x007174FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034CAC RID: 216236 RVA: 0x00719308 File Offset: 0x00717508
		public static IRecoverDurability GetRootAsIRecoverDurability(ByteBuffer _bb)
		{
			return IRecoverDurability.GetRootAsIRecoverDurability(_bb, default(IRecoverDurability));
		}

		// Token: 0x06034CAD RID: 216237 RVA: 0x00719324 File Offset: 0x00717524
		public static IRecoverDurability GetRootAsIRecoverDurability(ByteBuffer _bb, IRecoverDurability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034CAE RID: 216238 RVA: 0x00719341 File Offset: 0x00717541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034CAF RID: 216239 RVA: 0x00719350 File Offset: 0x00717550
		public IRecoverDurability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD58 RID: 56664
		// (get) Token: 0x06034CB0 RID: 216240 RVA: 0x00719360 File Offset: 0x00717560
		public int EntityId
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

		// Token: 0x06034CB1 RID: 216241 RVA: 0x0071939C File Offset: 0x0071759C
		public static Offset<IRecoverDurability> CreateIRecoverDurability(FlatBufferBuilder builder, int EntityId = 0)
		{
			builder.StartTable(1);
			IRecoverDurability.AddEntityId(builder, EntityId);
			return IRecoverDurability.EndIRecoverDurability(builder);
		}

		// Token: 0x06034CB2 RID: 216242 RVA: 0x007193B2 File Offset: 0x007175B2
		public static void StartIRecoverDurability(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034CB3 RID: 216243 RVA: 0x007193BB File Offset: 0x007175BB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06034CB4 RID: 216244 RVA: 0x007193C6 File Offset: 0x007175C6
		public static Offset<IRecoverDurability> EndIRecoverDurability(FlatBufferBuilder builder)
		{
			return new Offset<IRecoverDurability>(builder.EndTable());
		}

		// Token: 0x06034CB5 RID: 216245 RVA: 0x007193D4 File Offset: 0x007175D4
		public IRecoverDurabilityT UnPack()
		{
			IRecoverDurabilityT recoverDurabilityT = new IRecoverDurabilityT();
			this.UnPackTo(recoverDurabilityT);
			return recoverDurabilityT;
		}

		// Token: 0x06034CB6 RID: 216246 RVA: 0x007193EF File Offset: 0x007175EF
		public void UnPackTo(IRecoverDurabilityT _o)
		{
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06034CB7 RID: 216247 RVA: 0x00719400 File Offset: 0x00717600
		public static Offset<IRecoverDurability> Pack(FlatBufferBuilder builder, IRecoverDurabilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecoverDurability>);
			}
			return IRecoverDurability.CreateIRecoverDurability(builder, _o.EntityId);
		}

		// Token: 0x0401277A RID: 75642
		private Table __p;
	}
}
