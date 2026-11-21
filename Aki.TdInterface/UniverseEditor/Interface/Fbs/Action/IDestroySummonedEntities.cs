using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C08 RID: 27656
	public struct IDestroySummonedEntities : IFlatbufferObject
	{
		// Token: 0x1700CAC3 RID: 51907
		// (get) Token: 0x0602F997 RID: 194967 RVA: 0x0067CA72 File Offset: 0x0067AC72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F998 RID: 194968 RVA: 0x0067CA7F File Offset: 0x0067AC7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F999 RID: 194969 RVA: 0x0067CA88 File Offset: 0x0067AC88
		public static IDestroySummonedEntities GetRootAsIDestroySummonedEntities(ByteBuffer _bb)
		{
			return IDestroySummonedEntities.GetRootAsIDestroySummonedEntities(_bb, default(IDestroySummonedEntities));
		}

		// Token: 0x0602F99A RID: 194970 RVA: 0x0067CAA4 File Offset: 0x0067ACA4
		public static IDestroySummonedEntities GetRootAsIDestroySummonedEntities(ByteBuffer _bb, IDestroySummonedEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F99B RID: 194971 RVA: 0x0067CAC1 File Offset: 0x0067ACC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F99C RID: 194972 RVA: 0x0067CAD0 File Offset: 0x0067ACD0
		public IDestroySummonedEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAC4 RID: 51908
		// (get) Token: 0x0602F99D RID: 194973 RVA: 0x0067CAE0 File Offset: 0x0067ACE0
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

		// Token: 0x0602F99E RID: 194974 RVA: 0x0067CB3D File Offset: 0x0067AD3D
		public static Offset<IDestroySummonedEntities> CreateIDestroySummonedEntities(FlatBufferBuilder builder, Offset<IDestroySummonedVehicle> DestroyEntitiesConfigOffset = default(Offset<IDestroySummonedVehicle>))
		{
			builder.StartTable(1);
			IDestroySummonedEntities.AddDestroyEntitiesConfig(builder, DestroyEntitiesConfigOffset);
			return IDestroySummonedEntities.EndIDestroySummonedEntities(builder);
		}

		// Token: 0x0602F99F RID: 194975 RVA: 0x0067CB53 File Offset: 0x0067AD53
		public static void StartIDestroySummonedEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F9A0 RID: 194976 RVA: 0x0067CB5C File Offset: 0x0067AD5C
		public static void AddDestroyEntitiesConfig(FlatBufferBuilder builder, Offset<IDestroySummonedVehicle> destroyEntitiesConfigOffset)
		{
			builder.AddOffset(0, destroyEntitiesConfigOffset.Value, 0);
		}

		// Token: 0x0602F9A1 RID: 194977 RVA: 0x0067CB6C File Offset: 0x0067AD6C
		public static Offset<IDestroySummonedEntities> EndIDestroySummonedEntities(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySummonedEntities>(builder.EndTable());
		}

		// Token: 0x0602F9A2 RID: 194978 RVA: 0x0067CB7C File Offset: 0x0067AD7C
		public IDestroySummonedEntitiesT UnPack()
		{
			IDestroySummonedEntitiesT destroySummonedEntitiesT = new IDestroySummonedEntitiesT();
			this.UnPackTo(destroySummonedEntitiesT);
			return destroySummonedEntitiesT;
		}

		// Token: 0x0602F9A3 RID: 194979 RVA: 0x0067CB98 File Offset: 0x0067AD98
		public void UnPackTo(IDestroySummonedEntitiesT _o)
		{
			_o.DestroyEntitiesConfig = ((this.DestroyEntitiesConfig != null) ? this.DestroyEntitiesConfig.Value.UnPack() : null);
		}

		// Token: 0x0602F9A4 RID: 194980 RVA: 0x0067CBD4 File Offset: 0x0067ADD4
		public static Offset<IDestroySummonedEntities> Pack(FlatBufferBuilder builder, IDestroySummonedEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySummonedEntities>);
			}
			Offset<IDestroySummonedVehicle> destroyEntitiesConfigOffset = (_o.DestroyEntitiesConfig == null) ? default(Offset<IDestroySummonedVehicle>) : IDestroySummonedVehicle.Pack(builder, _o.DestroyEntitiesConfig);
			return IDestroySummonedEntities.CreateIDestroySummonedEntities(builder, destroyEntitiesConfigOffset);
		}

		// Token: 0x04011A0C RID: 72204
		private Table __p;
	}
}
