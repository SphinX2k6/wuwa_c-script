using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005102 RID: 20738
	public struct IDynamicTeleportComponent : IFlatbufferObject
	{
		// Token: 0x17009717 RID: 38679
		// (get) Token: 0x06021686 RID: 136838 RVA: 0x004A3A30 File Offset: 0x004A1C30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021687 RID: 136839 RVA: 0x004A3A3D File Offset: 0x004A1C3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021688 RID: 136840 RVA: 0x004A3A44 File Offset: 0x004A1C44
		public static IDynamicTeleportComponent GetRootAsIDynamicTeleportComponent(ByteBuffer _bb)
		{
			return IDynamicTeleportComponent.GetRootAsIDynamicTeleportComponent(_bb, default(IDynamicTeleportComponent));
		}

		// Token: 0x06021689 RID: 136841 RVA: 0x004A3A60 File Offset: 0x004A1C60
		public static IDynamicTeleportComponent GetRootAsIDynamicTeleportComponent(ByteBuffer _bb, IDynamicTeleportComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602168A RID: 136842 RVA: 0x004A3A7D File Offset: 0x004A1C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602168B RID: 136843 RVA: 0x004A3A8C File Offset: 0x004A1C8C
		public IDynamicTeleportComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009718 RID: 38680
		// (get) Token: 0x0602168C RID: 136844 RVA: 0x004A3A9C File Offset: 0x004A1C9C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009719 RID: 38681
		// (get) Token: 0x0602168D RID: 136845 RVA: 0x004A3ADC File Offset: 0x004A1CDC
		public IPosA? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700971A RID: 38682
		// (get) Token: 0x0602168E RID: 136846 RVA: 0x004A3B3C File Offset: 0x004A1D3C
		public int PhantomSkillId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700971B RID: 38683
		// (get) Token: 0x0602168F RID: 136847 RVA: 0x004A3B78 File Offset: 0x004A1D78
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021690 RID: 136848 RVA: 0x004A3BB5 File Offset: 0x004A1DB5
		public static Offset<IDynamicTeleportComponent> CreateIDynamicTeleportComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPosA> OffsetOffset = default(Offset<IPosA>), int PhantomSkillId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDynamicTeleportComponent.AddPhantomSkillId(builder, PhantomSkillId);
			IDynamicTeleportComponent.AddOffset(builder, OffsetOffset);
			IDynamicTeleportComponent.AddNullMask(builder, NullMask);
			IDynamicTeleportComponent.AddDisabled(builder, Disabled);
			return IDynamicTeleportComponent.EndIDynamicTeleportComponent(builder);
		}

		// Token: 0x06021691 RID: 136849 RVA: 0x004A3BE1 File Offset: 0x004A1DE1
		public static void StartIDynamicTeleportComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021692 RID: 136850 RVA: 0x004A3BEA File Offset: 0x004A1DEA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021693 RID: 136851 RVA: 0x004A3BF5 File Offset: 0x004A1DF5
		public static void AddOffset(FlatBufferBuilder builder, Offset<IPosA> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x06021694 RID: 136852 RVA: 0x004A3C05 File Offset: 0x004A1E05
		public static void AddPhantomSkillId(FlatBufferBuilder builder, int phantomSkillId)
		{
			builder.AddInt(2, phantomSkillId, 0);
		}

		// Token: 0x06021695 RID: 136853 RVA: 0x004A3C10 File Offset: 0x004A1E10
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021696 RID: 136854 RVA: 0x004A3C1B File Offset: 0x004A1E1B
		public static Offset<IDynamicTeleportComponent> EndIDynamicTeleportComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicTeleportComponent>(builder.EndTable());
		}

		// Token: 0x06021697 RID: 136855 RVA: 0x004A3C28 File Offset: 0x004A1E28
		public IDynamicTeleportComponentT UnPack()
		{
			IDynamicTeleportComponentT dynamicTeleportComponentT = new IDynamicTeleportComponentT();
			this.UnPackTo(dynamicTeleportComponentT);
			return dynamicTeleportComponentT;
		}

		// Token: 0x06021698 RID: 136856 RVA: 0x004A3C44 File Offset: 0x004A1E44
		public void UnPackTo(IDynamicTeleportComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.PhantomSkillId = this.PhantomSkillId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021699 RID: 136857 RVA: 0x004A3CA4 File Offset: 0x004A1EA4
		public static Offset<IDynamicTeleportComponent> Pack(FlatBufferBuilder builder, IDynamicTeleportComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicTeleportComponent>);
			}
			Offset<IPosA> offsetOffset = (_o.Offset == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Offset);
			return IDynamicTeleportComponent.CreateIDynamicTeleportComponent(builder, _o.Disabled, offsetOffset, _o.PhantomSkillId, _o.NullMask);
		}

		// Token: 0x0400E16C RID: 57708
		private Table __p;
	}
}
