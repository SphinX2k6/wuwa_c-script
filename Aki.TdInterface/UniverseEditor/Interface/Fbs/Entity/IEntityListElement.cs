using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C16 RID: 19478
	public struct IEntityListElement : IFlatbufferObject
	{
		// Token: 0x17008A0A RID: 35338
		// (get) Token: 0x0601DCE2 RID: 122082 RVA: 0x0042E44C File Offset: 0x0042C64C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCE3 RID: 122083 RVA: 0x0042E459 File Offset: 0x0042C659
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCE4 RID: 122084 RVA: 0x0042E460 File Offset: 0x0042C660
		public static IEntityListElement GetRootAsIEntityListElement(ByteBuffer _bb)
		{
			return IEntityListElement.GetRootAsIEntityListElement(_bb, default(IEntityListElement));
		}

		// Token: 0x0601DCE5 RID: 122085 RVA: 0x0042E47C File Offset: 0x0042C67C
		public static IEntityListElement GetRootAsIEntityListElement(ByteBuffer _bb, IEntityListElement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCE6 RID: 122086 RVA: 0x0042E499 File Offset: 0x0042C699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCE7 RID: 122087 RVA: 0x0042E4A8 File Offset: 0x0042C6A8
		public IEntityListElement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A0B RID: 35339
		// (get) Token: 0x0601DCE8 RID: 122088 RVA: 0x0042E4B8 File Offset: 0x0042C6B8
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

		// Token: 0x17008A0C RID: 35340
		// (get) Token: 0x0601DCE9 RID: 122089 RVA: 0x0042E4F4 File Offset: 0x0042C6F4
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

		// Token: 0x0601DCEA RID: 122090 RVA: 0x0042E551 File Offset: 0x0042C751
		public static Offset<IEntityListElement> CreateIEntityListElement(FlatBufferBuilder builder, int ParentId = 0, Offset<IEntityData> EntityDataOffset = default(Offset<IEntityData>))
		{
			builder.StartTable(2);
			IEntityListElement.AddEntityData(builder, EntityDataOffset);
			IEntityListElement.AddParentId(builder, ParentId);
			return IEntityListElement.EndIEntityListElement(builder);
		}

		// Token: 0x0601DCEB RID: 122091 RVA: 0x0042E56E File Offset: 0x0042C76E
		public static void StartIEntityListElement(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DCEC RID: 122092 RVA: 0x0042E577 File Offset: 0x0042C777
		public static void AddParentId(FlatBufferBuilder builder, int parentId)
		{
			builder.AddInt(0, parentId, 0);
		}

		// Token: 0x0601DCED RID: 122093 RVA: 0x0042E582 File Offset: 0x0042C782
		public static void AddEntityData(FlatBufferBuilder builder, Offset<IEntityData> entityDataOffset)
		{
			builder.AddOffset(1, entityDataOffset.Value, 0);
		}

		// Token: 0x0601DCEE RID: 122094 RVA: 0x0042E592 File Offset: 0x0042C792
		public static Offset<IEntityListElement> EndIEntityListElement(FlatBufferBuilder builder)
		{
			return new Offset<IEntityListElement>(builder.EndTable());
		}

		// Token: 0x0601DCEF RID: 122095 RVA: 0x0042E5A0 File Offset: 0x0042C7A0
		public IEntityListElementT UnPack()
		{
			IEntityListElementT entityListElementT = new IEntityListElementT();
			this.UnPackTo(entityListElementT);
			return entityListElementT;
		}

		// Token: 0x0601DCF0 RID: 122096 RVA: 0x0042E5BC File Offset: 0x0042C7BC
		public void UnPackTo(IEntityListElementT _o)
		{
			_o.ParentId = this.ParentId;
			_o.EntityData = ((this.EntityData != null) ? this.EntityData.Value.UnPack() : null);
		}

		// Token: 0x0601DCF1 RID: 122097 RVA: 0x0042E604 File Offset: 0x0042C804
		public static Offset<IEntityListElement> Pack(FlatBufferBuilder builder, IEntityListElementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityListElement>);
			}
			Offset<IEntityData> entityDataOffset = (_o.EntityData == null) ? default(Offset<IEntityData>) : IEntityData.Pack(builder, _o.EntityData);
			return IEntityListElement.CreateIEntityListElement(builder, _o.ParentId, entityDataOffset);
		}

		// Token: 0x0400D664 RID: 54884
		private Table __p;
	}
}
