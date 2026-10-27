using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047CF RID: 18383
	public struct IEntityPrefabElement : IFlatbufferObject
	{
		// Token: 0x17008414 RID: 33812
		// (get) Token: 0x0601C66F RID: 116335 RVA: 0x00404DC3 File Offset: 0x00402FC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C670 RID: 116336 RVA: 0x00404DD0 File Offset: 0x00402FD0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C671 RID: 116337 RVA: 0x00404DD8 File Offset: 0x00402FD8
		public static IEntityPrefabElement GetRootAsIEntityPrefabElement(ByteBuffer _bb)
		{
			return IEntityPrefabElement.GetRootAsIEntityPrefabElement(_bb, default(IEntityPrefabElement));
		}

		// Token: 0x0601C672 RID: 116338 RVA: 0x00404DF4 File Offset: 0x00402FF4
		public static IEntityPrefabElement GetRootAsIEntityPrefabElement(ByteBuffer _bb, IEntityPrefabElement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C673 RID: 116339 RVA: 0x00404E11 File Offset: 0x00403011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C674 RID: 116340 RVA: 0x00404E20 File Offset: 0x00403020
		public IEntityPrefabElement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008415 RID: 33813
		// (get) Token: 0x0601C675 RID: 116341 RVA: 0x00404E30 File Offset: 0x00403030
		public IEntityData? EntityData
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C676 RID: 116342 RVA: 0x00404E8D File Offset: 0x0040308D
		public static Offset<IEntityPrefabElement> CreateIEntityPrefabElement(FlatBufferBuilder builder, Offset<IEntityData> EntityDataOffset = default(Offset<IEntityData>))
		{
			builder.StartTable(1);
			IEntityPrefabElement.AddEntityData(builder, EntityDataOffset);
			return IEntityPrefabElement.EndIEntityPrefabElement(builder);
		}

		// Token: 0x0601C677 RID: 116343 RVA: 0x00404EA3 File Offset: 0x004030A3
		public static void StartIEntityPrefabElement(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C678 RID: 116344 RVA: 0x00404EAC File Offset: 0x004030AC
		public static void AddEntityData(FlatBufferBuilder builder, Offset<IEntityData> entityDataOffset)
		{
			builder.AddOffset(0, entityDataOffset.Value, 0);
		}

		// Token: 0x0601C679 RID: 116345 RVA: 0x00404EBC File Offset: 0x004030BC
		public static Offset<IEntityPrefabElement> EndIEntityPrefabElement(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPrefabElement>(builder.EndTable());
		}

		// Token: 0x0601C67A RID: 116346 RVA: 0x00404ECC File Offset: 0x004030CC
		public IEntityPrefabElementT UnPack()
		{
			IEntityPrefabElementT entityPrefabElementT = new IEntityPrefabElementT();
			this.UnPackTo(entityPrefabElementT);
			return entityPrefabElementT;
		}

		// Token: 0x0601C67B RID: 116347 RVA: 0x00404EE8 File Offset: 0x004030E8
		public void UnPackTo(IEntityPrefabElementT _o)
		{
			_o.EntityData = ((this.EntityData != null) ? this.EntityData.Value.UnPack() : null);
		}

		// Token: 0x0601C67C RID: 116348 RVA: 0x00404F24 File Offset: 0x00403124
		public static Offset<IEntityPrefabElement> Pack(FlatBufferBuilder builder, IEntityPrefabElementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPrefabElement>);
			}
			Offset<IEntityData> entityDataOffset = (_o.EntityData == null) ? default(Offset<IEntityData>) : IEntityData.Pack(builder, _o.EntityData);
			return IEntityPrefabElement.CreateIEntityPrefabElement(builder, entityDataOffset);
		}

		// Token: 0x0400CC5F RID: 52319
		private Table __p;
	}
}
