using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005709 RID: 22281
	public struct IEntityPackageComponent : IFlatbufferObject
	{
		// Token: 0x1700A0A1 RID: 41121
		// (get) Token: 0x06023C71 RID: 146545 RVA: 0x004EB065 File Offset: 0x004E9265
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C72 RID: 146546 RVA: 0x004EB072 File Offset: 0x004E9272
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C73 RID: 146547 RVA: 0x004EB07C File Offset: 0x004E927C
		public static IEntityPackageComponent GetRootAsIEntityPackageComponent(ByteBuffer _bb)
		{
			return IEntityPackageComponent.GetRootAsIEntityPackageComponent(_bb, default(IEntityPackageComponent));
		}

		// Token: 0x06023C74 RID: 146548 RVA: 0x004EB098 File Offset: 0x004E9298
		public static IEntityPackageComponent GetRootAsIEntityPackageComponent(ByteBuffer _bb, IEntityPackageComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C75 RID: 146549 RVA: 0x004EB0B5 File Offset: 0x004E92B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C76 RID: 146550 RVA: 0x004EB0C4 File Offset: 0x004E92C4
		public IEntityPackageComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0A2 RID: 41122
		// (get) Token: 0x06023C77 RID: 146551 RVA: 0x004EB0D4 File Offset: 0x004E92D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0A3 RID: 41123
		// (get) Token: 0x06023C78 RID: 146552 RVA: 0x004EB114 File Offset: 0x004E9314
		public bool BindTemplate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0A4 RID: 41124
		// (get) Token: 0x06023C79 RID: 146553 RVA: 0x004EB154 File Offset: 0x004E9354
		public IEntityPackageData? PackageData
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IEntityPackageData?(default(IEntityPackageData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A0A5 RID: 41125
		// (get) Token: 0x06023C7A RID: 146554 RVA: 0x004EB1B4 File Offset: 0x004E93B4
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

		// Token: 0x06023C7B RID: 146555 RVA: 0x004EB1F1 File Offset: 0x004E93F1
		public static Offset<IEntityPackageComponent> CreateIEntityPackageComponent(FlatBufferBuilder builder, bool Disabled = false, bool BindTemplate = false, Offset<IEntityPackageData> PackageDataOffset = default(Offset<IEntityPackageData>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityPackageComponent.AddPackageData(builder, PackageDataOffset);
			IEntityPackageComponent.AddNullMask(builder, NullMask);
			IEntityPackageComponent.AddBindTemplate(builder, BindTemplate);
			IEntityPackageComponent.AddDisabled(builder, Disabled);
			return IEntityPackageComponent.EndIEntityPackageComponent(builder);
		}

		// Token: 0x06023C7C RID: 146556 RVA: 0x004EB21D File Offset: 0x004E941D
		public static void StartIEntityPackageComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023C7D RID: 146557 RVA: 0x004EB226 File Offset: 0x004E9426
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023C7E RID: 146558 RVA: 0x004EB231 File Offset: 0x004E9431
		public static void AddBindTemplate(FlatBufferBuilder builder, bool bindTemplate)
		{
			builder.AddBool(1, bindTemplate, false);
		}

		// Token: 0x06023C7F RID: 146559 RVA: 0x004EB23C File Offset: 0x004E943C
		public static void AddPackageData(FlatBufferBuilder builder, Offset<IEntityPackageData> packageDataOffset)
		{
			builder.AddOffset(2, packageDataOffset.Value, 0);
		}

		// Token: 0x06023C80 RID: 146560 RVA: 0x004EB24C File Offset: 0x004E944C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023C81 RID: 146561 RVA: 0x004EB257 File Offset: 0x004E9457
		public static Offset<IEntityPackageComponent> EndIEntityPackageComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPackageComponent>(builder.EndTable());
		}

		// Token: 0x06023C82 RID: 146562 RVA: 0x004EB264 File Offset: 0x004E9464
		public IEntityPackageComponentT UnPack()
		{
			IEntityPackageComponentT entityPackageComponentT = new IEntityPackageComponentT();
			this.UnPackTo(entityPackageComponentT);
			return entityPackageComponentT;
		}

		// Token: 0x06023C83 RID: 146563 RVA: 0x004EB280 File Offset: 0x004E9480
		public void UnPackTo(IEntityPackageComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BindTemplate = this.BindTemplate;
			_o.PackageData = ((this.PackageData != null) ? this.PackageData.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023C84 RID: 146564 RVA: 0x004EB2E0 File Offset: 0x004E94E0
		public static Offset<IEntityPackageComponent> Pack(FlatBufferBuilder builder, IEntityPackageComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPackageComponent>);
			}
			Offset<IEntityPackageData> packageDataOffset = (_o.PackageData == null) ? default(Offset<IEntityPackageData>) : IEntityPackageData.Pack(builder, _o.PackageData);
			return IEntityPackageComponent.CreateIEntityPackageComponent(builder, _o.Disabled, _o.BindTemplate, packageDataOffset, _o.NullMask);
		}

		// Token: 0x0400EE80 RID: 61056
		private Table __p;
	}
}
