using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047AE RID: 18350
	public struct IEntityListElement : IFlatbufferObject
	{
		// Token: 0x170083C9 RID: 33737
		// (get) Token: 0x0601C50D RID: 115981 RVA: 0x004021B0 File Offset: 0x004003B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C50E RID: 115982 RVA: 0x004021BD File Offset: 0x004003BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C50F RID: 115983 RVA: 0x004021C4 File Offset: 0x004003C4
		public static IEntityListElement GetRootAsIEntityListElement(ByteBuffer _bb)
		{
			return IEntityListElement.GetRootAsIEntityListElement(_bb, default(IEntityListElement));
		}

		// Token: 0x0601C510 RID: 115984 RVA: 0x004021E0 File Offset: 0x004003E0
		public static IEntityListElement GetRootAsIEntityListElement(ByteBuffer _bb, IEntityListElement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C511 RID: 115985 RVA: 0x004021FD File Offset: 0x004003FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C512 RID: 115986 RVA: 0x0040220C File Offset: 0x0040040C
		public IEntityListElement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083CA RID: 33738
		// (get) Token: 0x0601C513 RID: 115987 RVA: 0x0040221C File Offset: 0x0040041C
		public int ParentId
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

		// Token: 0x170083CB RID: 33739
		// (get) Token: 0x0601C514 RID: 115988 RVA: 0x00402258 File Offset: 0x00400458
		public IEntityData? EntityData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C515 RID: 115989 RVA: 0x004022B5 File Offset: 0x004004B5
		public static Offset<IEntityListElement> CreateIEntityListElement(FlatBufferBuilder builder, int ParentId = 0, Offset<IEntityData> EntityDataOffset = default(Offset<IEntityData>))
		{
			builder.StartTable(2);
			IEntityListElement.AddEntityData(builder, EntityDataOffset);
			IEntityListElement.AddParentId(builder, ParentId);
			return IEntityListElement.EndIEntityListElement(builder);
		}

		// Token: 0x0601C516 RID: 115990 RVA: 0x004022D2 File Offset: 0x004004D2
		public static void StartIEntityListElement(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C517 RID: 115991 RVA: 0x004022DB File Offset: 0x004004DB
		public static void AddParentId(FlatBufferBuilder builder, int parentId)
		{
			builder.AddInt(0, parentId, 0);
		}

		// Token: 0x0601C518 RID: 115992 RVA: 0x004022E6 File Offset: 0x004004E6
		public static void AddEntityData(FlatBufferBuilder builder, Offset<IEntityData> entityDataOffset)
		{
			builder.AddOffset(1, entityDataOffset.Value, 0);
		}

		// Token: 0x0601C519 RID: 115993 RVA: 0x004022F6 File Offset: 0x004004F6
		public static Offset<IEntityListElement> EndIEntityListElement(FlatBufferBuilder builder)
		{
			return new Offset<IEntityListElement>(builder.EndTable());
		}

		// Token: 0x0601C51A RID: 115994 RVA: 0x00402304 File Offset: 0x00400504
		public IEntityListElementT UnPack()
		{
			IEntityListElementT entityListElementT = new IEntityListElementT();
			this.UnPackTo(entityListElementT);
			return entityListElementT;
		}

		// Token: 0x0601C51B RID: 115995 RVA: 0x00402320 File Offset: 0x00400520
		public void UnPackTo(IEntityListElementT _o)
		{
			_o.ParentId = this.ParentId;
			_o.EntityData = ((this.EntityData != null) ? this.EntityData.Value.UnPack() : null);
		}

		// Token: 0x0601C51C RID: 115996 RVA: 0x00402368 File Offset: 0x00400568
		public static Offset<IEntityListElement> Pack(FlatBufferBuilder builder, IEntityListElementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityListElement>);
			}
			Offset<IEntityData> entityDataOffset = (_o.EntityData == null) ? default(Offset<IEntityData>) : IEntityData.Pack(builder, _o.EntityData);
			return IEntityListElement.CreateIEntityListElement(builder, _o.ParentId, entityDataOffset);
		}

		// Token: 0x0400CC2E RID: 52270
		private Table __p;
	}
}
