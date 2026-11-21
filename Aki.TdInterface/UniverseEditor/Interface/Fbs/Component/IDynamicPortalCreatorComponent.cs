using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565B RID: 22107
	public struct IDynamicPortalCreatorComponent : IFlatbufferObject
	{
		// Token: 0x17009EDE RID: 40670
		// (get) Token: 0x06023553 RID: 144723 RVA: 0x004DC6DA File Offset: 0x004DA8DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023554 RID: 144724 RVA: 0x004DC6E7 File Offset: 0x004DA8E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023555 RID: 144725 RVA: 0x004DC6F0 File Offset: 0x004DA8F0
		public static IDynamicPortalCreatorComponent GetRootAsIDynamicPortalCreatorComponent(ByteBuffer _bb)
		{
			return IDynamicPortalCreatorComponent.GetRootAsIDynamicPortalCreatorComponent(_bb, default(IDynamicPortalCreatorComponent));
		}

		// Token: 0x06023556 RID: 144726 RVA: 0x004DC70C File Offset: 0x004DA90C
		public static IDynamicPortalCreatorComponent GetRootAsIDynamicPortalCreatorComponent(ByteBuffer _bb, IDynamicPortalCreatorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023557 RID: 144727 RVA: 0x004DC729 File Offset: 0x004DA929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023558 RID: 144728 RVA: 0x004DC738 File Offset: 0x004DA938
		public IDynamicPortalCreatorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EDF RID: 40671
		// (get) Token: 0x06023559 RID: 144729 RVA: 0x004DC748 File Offset: 0x004DA948
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EE0 RID: 40672
		// (get) Token: 0x0602355A RID: 144730 RVA: 0x004DC788 File Offset: 0x004DA988
		public IDynamicPortalByBullet? Model
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicPortalByBullet?(default(IDynamicPortalByBullet).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009EE1 RID: 40673
		// (get) Token: 0x0602355B RID: 144731 RVA: 0x004DC7E8 File Offset: 0x004DA9E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602355C RID: 144732 RVA: 0x004DC824 File Offset: 0x004DAA24
		public static Offset<IDynamicPortalCreatorComponent> CreateIDynamicPortalCreatorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IDynamicPortalByBullet> ModelOffset = default(Offset<IDynamicPortalByBullet>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicPortalCreatorComponent.AddModel(builder, ModelOffset);
			IDynamicPortalCreatorComponent.AddNullMask(builder, NullMask);
			IDynamicPortalCreatorComponent.AddDisabled(builder, Disabled);
			return IDynamicPortalCreatorComponent.EndIDynamicPortalCreatorComponent(builder);
		}

		// Token: 0x0602355D RID: 144733 RVA: 0x004DC848 File Offset: 0x004DAA48
		public static void StartIDynamicPortalCreatorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602355E RID: 144734 RVA: 0x004DC851 File Offset: 0x004DAA51
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602355F RID: 144735 RVA: 0x004DC85C File Offset: 0x004DAA5C
		public static void AddModel(FlatBufferBuilder builder, Offset<IDynamicPortalByBullet> modelOffset)
		{
			builder.AddOffset(1, modelOffset.Value, 0);
		}

		// Token: 0x06023560 RID: 144736 RVA: 0x004DC86C File Offset: 0x004DAA6C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023561 RID: 144737 RVA: 0x004DC877 File Offset: 0x004DAA77
		public static Offset<IDynamicPortalCreatorComponent> EndIDynamicPortalCreatorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalCreatorComponent>(builder.EndTable());
		}

		// Token: 0x06023562 RID: 144738 RVA: 0x004DC884 File Offset: 0x004DAA84
		public IDynamicPortalCreatorComponentT UnPack()
		{
			IDynamicPortalCreatorComponentT dynamicPortalCreatorComponentT = new IDynamicPortalCreatorComponentT();
			this.UnPackTo(dynamicPortalCreatorComponentT);
			return dynamicPortalCreatorComponentT;
		}

		// Token: 0x06023563 RID: 144739 RVA: 0x004DC8A0 File Offset: 0x004DAAA0
		public void UnPackTo(IDynamicPortalCreatorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Model = ((this.Model != null) ? this.Model.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023564 RID: 144740 RVA: 0x004DC8F4 File Offset: 0x004DAAF4
		public static Offset<IDynamicPortalCreatorComponent> Pack(FlatBufferBuilder builder, IDynamicPortalCreatorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortalCreatorComponent>);
			}
			Offset<IDynamicPortalByBullet> modelOffset = (_o.Model == null) ? default(Offset<IDynamicPortalByBullet>) : IDynamicPortalByBullet.Pack(builder, _o.Model);
			return IDynamicPortalCreatorComponent.CreateIDynamicPortalCreatorComponent(builder, _o.Disabled, modelOffset, _o.NullMask);
		}

		// Token: 0x0400ED54 RID: 60756
		private Table __p;
	}
}
