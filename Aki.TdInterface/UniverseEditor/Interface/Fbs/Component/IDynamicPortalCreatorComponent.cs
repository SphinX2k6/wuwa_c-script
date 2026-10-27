using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F6 RID: 20726
	public struct IDynamicPortalCreatorComponent : IFlatbufferObject
	{
		// Token: 0x170096F1 RID: 38641
		// (get) Token: 0x060215FF RID: 136703 RVA: 0x004A274E File Offset: 0x004A094E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021600 RID: 136704 RVA: 0x004A275B File Offset: 0x004A095B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021601 RID: 136705 RVA: 0x004A2764 File Offset: 0x004A0964
		public static IDynamicPortalCreatorComponent GetRootAsIDynamicPortalCreatorComponent(ByteBuffer _bb)
		{
			return IDynamicPortalCreatorComponent.GetRootAsIDynamicPortalCreatorComponent(_bb, default(IDynamicPortalCreatorComponent));
		}

		// Token: 0x06021602 RID: 136706 RVA: 0x004A2780 File Offset: 0x004A0980
		public static IDynamicPortalCreatorComponent GetRootAsIDynamicPortalCreatorComponent(ByteBuffer _bb, IDynamicPortalCreatorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021603 RID: 136707 RVA: 0x004A279D File Offset: 0x004A099D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021604 RID: 136708 RVA: 0x004A27AC File Offset: 0x004A09AC
		public IDynamicPortalCreatorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096F2 RID: 38642
		// (get) Token: 0x06021605 RID: 136709 RVA: 0x004A27BC File Offset: 0x004A09BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170096F3 RID: 38643
		// (get) Token: 0x06021606 RID: 136710 RVA: 0x004A27FC File Offset: 0x004A09FC
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

		// Token: 0x170096F4 RID: 38644
		// (get) Token: 0x06021607 RID: 136711 RVA: 0x004A285C File Offset: 0x004A0A5C
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

		// Token: 0x06021608 RID: 136712 RVA: 0x004A2898 File Offset: 0x004A0A98
		public static Offset<IDynamicPortalCreatorComponent> CreateIDynamicPortalCreatorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IDynamicPortalByBullet> ModelOffset = default(Offset<IDynamicPortalByBullet>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicPortalCreatorComponent.AddModel(builder, ModelOffset);
			IDynamicPortalCreatorComponent.AddNullMask(builder, NullMask);
			IDynamicPortalCreatorComponent.AddDisabled(builder, Disabled);
			return IDynamicPortalCreatorComponent.EndIDynamicPortalCreatorComponent(builder);
		}

		// Token: 0x06021609 RID: 136713 RVA: 0x004A28BC File Offset: 0x004A0ABC
		public static void StartIDynamicPortalCreatorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602160A RID: 136714 RVA: 0x004A28C5 File Offset: 0x004A0AC5
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602160B RID: 136715 RVA: 0x004A28D0 File Offset: 0x004A0AD0
		public static void AddModel(FlatBufferBuilder builder, Offset<IDynamicPortalByBullet> modelOffset)
		{
			builder.AddOffset(1, modelOffset.Value, 0);
		}

		// Token: 0x0602160C RID: 136716 RVA: 0x004A28E0 File Offset: 0x004A0AE0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602160D RID: 136717 RVA: 0x004A28EB File Offset: 0x004A0AEB
		public static Offset<IDynamicPortalCreatorComponent> EndIDynamicPortalCreatorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalCreatorComponent>(builder.EndTable());
		}

		// Token: 0x0602160E RID: 136718 RVA: 0x004A28F8 File Offset: 0x004A0AF8
		public IDynamicPortalCreatorComponentT UnPack()
		{
			IDynamicPortalCreatorComponentT dynamicPortalCreatorComponentT = new IDynamicPortalCreatorComponentT();
			this.UnPackTo(dynamicPortalCreatorComponentT);
			return dynamicPortalCreatorComponentT;
		}

		// Token: 0x0602160F RID: 136719 RVA: 0x004A2914 File Offset: 0x004A0B14
		public void UnPackTo(IDynamicPortalCreatorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Model = ((this.Model != null) ? this.Model.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021610 RID: 136720 RVA: 0x004A2968 File Offset: 0x004A0B68
		public static Offset<IDynamicPortalCreatorComponent> Pack(FlatBufferBuilder builder, IDynamicPortalCreatorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortalCreatorComponent>);
			}
			Offset<IDynamicPortalByBullet> modelOffset = (_o.Model == null) ? default(Offset<IDynamicPortalByBullet>) : IDynamicPortalByBullet.Pack(builder, _o.Model);
			return IDynamicPortalCreatorComponent.CreateIDynamicPortalCreatorComponent(builder, _o.Disabled, modelOffset, _o.NullMask);
		}

		// Token: 0x0400E157 RID: 57687
		private Table __p;
	}
}
