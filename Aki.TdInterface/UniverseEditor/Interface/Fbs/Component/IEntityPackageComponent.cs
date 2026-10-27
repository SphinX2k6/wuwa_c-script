using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A4 RID: 20900
	public struct IEntityPackageComponent : IFlatbufferObject
	{
		// Token: 0x170098B2 RID: 39090
		// (get) Token: 0x06021D19 RID: 138521 RVA: 0x004B0FFD File Offset: 0x004AF1FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D1A RID: 138522 RVA: 0x004B100A File Offset: 0x004AF20A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D1B RID: 138523 RVA: 0x004B1014 File Offset: 0x004AF214
		public static IEntityPackageComponent GetRootAsIEntityPackageComponent(ByteBuffer _bb)
		{
			return IEntityPackageComponent.GetRootAsIEntityPackageComponent(_bb, default(IEntityPackageComponent));
		}

		// Token: 0x06021D1C RID: 138524 RVA: 0x004B1030 File Offset: 0x004AF230
		public static IEntityPackageComponent GetRootAsIEntityPackageComponent(ByteBuffer _bb, IEntityPackageComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D1D RID: 138525 RVA: 0x004B104D File Offset: 0x004AF24D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D1E RID: 138526 RVA: 0x004B105C File Offset: 0x004AF25C
		public IEntityPackageComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098B3 RID: 39091
		// (get) Token: 0x06021D1F RID: 138527 RVA: 0x004B106C File Offset: 0x004AF26C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098B4 RID: 39092
		// (get) Token: 0x06021D20 RID: 138528 RVA: 0x004B10AC File Offset: 0x004AF2AC
		public bool BindTemplate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098B5 RID: 39093
		// (get) Token: 0x06021D21 RID: 138529 RVA: 0x004B10EC File Offset: 0x004AF2EC
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

		// Token: 0x170098B6 RID: 39094
		// (get) Token: 0x06021D22 RID: 138530 RVA: 0x004B114C File Offset: 0x004AF34C
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

		// Token: 0x06021D23 RID: 138531 RVA: 0x004B1189 File Offset: 0x004AF389
		public static Offset<IEntityPackageComponent> CreateIEntityPackageComponent(FlatBufferBuilder builder, bool Disabled = false, bool BindTemplate = false, Offset<IEntityPackageData> PackageDataOffset = default(Offset<IEntityPackageData>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityPackageComponent.AddPackageData(builder, PackageDataOffset);
			IEntityPackageComponent.AddNullMask(builder, NullMask);
			IEntityPackageComponent.AddBindTemplate(builder, BindTemplate);
			IEntityPackageComponent.AddDisabled(builder, Disabled);
			return IEntityPackageComponent.EndIEntityPackageComponent(builder);
		}

		// Token: 0x06021D24 RID: 138532 RVA: 0x004B11B5 File Offset: 0x004AF3B5
		public static void StartIEntityPackageComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021D25 RID: 138533 RVA: 0x004B11BE File Offset: 0x004AF3BE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021D26 RID: 138534 RVA: 0x004B11C9 File Offset: 0x004AF3C9
		public static void AddBindTemplate(FlatBufferBuilder builder, bool bindTemplate)
		{
			builder.AddBool(1, bindTemplate, false);
		}

		// Token: 0x06021D27 RID: 138535 RVA: 0x004B11D4 File Offset: 0x004AF3D4
		public static void AddPackageData(FlatBufferBuilder builder, Offset<IEntityPackageData> packageDataOffset)
		{
			builder.AddOffset(2, packageDataOffset.Value, 0);
		}

		// Token: 0x06021D28 RID: 138536 RVA: 0x004B11E4 File Offset: 0x004AF3E4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021D29 RID: 138537 RVA: 0x004B11EF File Offset: 0x004AF3EF
		public static Offset<IEntityPackageComponent> EndIEntityPackageComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPackageComponent>(builder.EndTable());
		}

		// Token: 0x06021D2A RID: 138538 RVA: 0x004B11FC File Offset: 0x004AF3FC
		public IEntityPackageComponentT UnPack()
		{
			IEntityPackageComponentT entityPackageComponentT = new IEntityPackageComponentT();
			this.UnPackTo(entityPackageComponentT);
			return entityPackageComponentT;
		}

		// Token: 0x06021D2B RID: 138539 RVA: 0x004B1218 File Offset: 0x004AF418
		public void UnPackTo(IEntityPackageComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BindTemplate = this.BindTemplate;
			_o.PackageData = ((this.PackageData != null) ? this.PackageData.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021D2C RID: 138540 RVA: 0x004B1278 File Offset: 0x004AF478
		public static Offset<IEntityPackageComponent> Pack(FlatBufferBuilder builder, IEntityPackageComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPackageComponent>);
			}
			Offset<IEntityPackageData> packageDataOffset = (_o.PackageData == null) ? default(Offset<IEntityPackageData>) : IEntityPackageData.Pack(builder, _o.PackageData);
			return IEntityPackageComponent.CreateIEntityPackageComponent(builder, _o.Disabled, _o.BindTemplate, packageDataOffset, _o.NullMask);
		}

		// Token: 0x0400E282 RID: 57986
		private Table __p;
	}
}
