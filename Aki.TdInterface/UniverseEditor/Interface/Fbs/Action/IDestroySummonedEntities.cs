using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A0 RID: 26016
	public struct IDestroySummonedEntities : IFlatbufferObject
	{
		// Token: 0x1700C134 RID: 49460
		// (get) Token: 0x0602D213 RID: 184851 RVA: 0x006308AE File Offset: 0x0062EAAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D214 RID: 184852 RVA: 0x006308BB File Offset: 0x0062EABB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D215 RID: 184853 RVA: 0x006308C4 File Offset: 0x0062EAC4
		public static IDestroySummonedEntities GetRootAsIDestroySummonedEntities(ByteBuffer _bb)
		{
			return IDestroySummonedEntities.GetRootAsIDestroySummonedEntities(_bb, default(IDestroySummonedEntities));
		}

		// Token: 0x0602D216 RID: 184854 RVA: 0x006308E0 File Offset: 0x0062EAE0
		public static IDestroySummonedEntities GetRootAsIDestroySummonedEntities(ByteBuffer _bb, IDestroySummonedEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D217 RID: 184855 RVA: 0x006308FD File Offset: 0x0062EAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D218 RID: 184856 RVA: 0x0063090C File Offset: 0x0062EB0C
		public IDestroySummonedEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C135 RID: 49461
		// (get) Token: 0x0602D219 RID: 184857 RVA: 0x0063091C File Offset: 0x0062EB1C
		public IDestroySummonedVehicle? DestroyEntitiesConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDestroySummonedVehicle?(default(IDestroySummonedVehicle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602D21A RID: 184858 RVA: 0x00630979 File Offset: 0x0062EB79
		public static Offset<IDestroySummonedEntities> CreateIDestroySummonedEntities(FlatBufferBuilder builder, Offset<IDestroySummonedVehicle> DestroyEntitiesConfigOffset = default(Offset<IDestroySummonedVehicle>))
		{
			builder.StartTable(1);
			IDestroySummonedEntities.AddDestroyEntitiesConfig(builder, DestroyEntitiesConfigOffset);
			return IDestroySummonedEntities.EndIDestroySummonedEntities(builder);
		}

		// Token: 0x0602D21B RID: 184859 RVA: 0x0063098F File Offset: 0x0062EB8F
		public static void StartIDestroySummonedEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D21C RID: 184860 RVA: 0x00630998 File Offset: 0x0062EB98
		public static void AddDestroyEntitiesConfig(FlatBufferBuilder builder, Offset<IDestroySummonedVehicle> destroyEntitiesConfigOffset)
		{
			builder.AddOffset(0, destroyEntitiesConfigOffset.Value, 0);
		}

		// Token: 0x0602D21D RID: 184861 RVA: 0x006309A8 File Offset: 0x0062EBA8
		public static Offset<IDestroySummonedEntities> EndIDestroySummonedEntities(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySummonedEntities>(builder.EndTable());
		}

		// Token: 0x0602D21E RID: 184862 RVA: 0x006309B8 File Offset: 0x0062EBB8
		public IDestroySummonedEntitiesT UnPack()
		{
			IDestroySummonedEntitiesT destroySummonedEntitiesT = new IDestroySummonedEntitiesT();
			this.UnPackTo(destroySummonedEntitiesT);
			return destroySummonedEntitiesT;
		}

		// Token: 0x0602D21F RID: 184863 RVA: 0x006309D4 File Offset: 0x0062EBD4
		public void UnPackTo(IDestroySummonedEntitiesT _o)
		{
			_o.DestroyEntitiesConfig = ((this.DestroyEntitiesConfig != null) ? this.DestroyEntitiesConfig.Value.UnPack() : null);
		}

		// Token: 0x0602D220 RID: 184864 RVA: 0x00630A10 File Offset: 0x0062EC10
		public static Offset<IDestroySummonedEntities> Pack(FlatBufferBuilder builder, IDestroySummonedEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySummonedEntities>);
			}
			Offset<IDestroySummonedVehicle> destroyEntitiesConfigOffset = (_o.DestroyEntitiesConfig == null) ? default(Offset<IDestroySummonedVehicle>) : IDestroySummonedVehicle.Pack(builder, _o.DestroyEntitiesConfig);
			return IDestroySummonedEntities.CreateIDestroySummonedEntities(builder, destroyEntitiesConfigOffset);
		}

		// Token: 0x04010BFA RID: 68602
		private Table __p;
	}
}
