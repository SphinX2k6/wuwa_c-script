using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F8A RID: 24458
	public struct ISphereFactoryComponent : IFlatbufferObject
	{
		// Token: 0x1700B517 RID: 46359
		// (get) Token: 0x060291DF RID: 168415 RVA: 0x0059D41C File Offset: 0x0059B61C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291E0 RID: 168416 RVA: 0x0059D429 File Offset: 0x0059B629
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291E1 RID: 168417 RVA: 0x0059D430 File Offset: 0x0059B630
		public static ISphereFactoryComponent GetRootAsISphereFactoryComponent(ByteBuffer _bb)
		{
			return ISphereFactoryComponent.GetRootAsISphereFactoryComponent(_bb, default(ISphereFactoryComponent));
		}

		// Token: 0x060291E2 RID: 168418 RVA: 0x0059D44C File Offset: 0x0059B64C
		public static ISphereFactoryComponent GetRootAsISphereFactoryComponent(ByteBuffer _bb, ISphereFactoryComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291E3 RID: 168419 RVA: 0x0059D469 File Offset: 0x0059B669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291E4 RID: 168420 RVA: 0x0059D478 File Offset: 0x0059B678
		public ISphereFactoryComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B518 RID: 46360
		// (get) Token: 0x060291E5 RID: 168421 RVA: 0x0059D488 File Offset: 0x0059B688
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B519 RID: 46361
		// (get) Token: 0x060291E6 RID: 168422 RVA: 0x0059D4C8 File Offset: 0x0059B6C8
		public IVectorInfo? SphereLocation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B51A RID: 46362
		// (get) Token: 0x060291E7 RID: 168423 RVA: 0x0059D528 File Offset: 0x0059B728
		public string SphereGuid
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060291E8 RID: 168424 RVA: 0x0059D55F File Offset: 0x0059B75F
		public Span<byte> GetSphereGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060291E9 RID: 168425 RVA: 0x0059D56E File Offset: 0x0059B76E
		public byte[] GetSphereGuidArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B51B RID: 46363
		// (get) Token: 0x060291EA RID: 168426 RVA: 0x0059D57C File Offset: 0x0059B77C
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

		// Token: 0x060291EB RID: 168427 RVA: 0x0059D5B9 File Offset: 0x0059B7B9
		public static Offset<ISphereFactoryComponent> CreateISphereFactoryComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IVectorInfo> SphereLocationOffset = default(Offset<IVectorInfo>), StringOffset SphereGuidOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISphereFactoryComponent.AddSphereGuid(builder, SphereGuidOffset);
			ISphereFactoryComponent.AddSphereLocation(builder, SphereLocationOffset);
			ISphereFactoryComponent.AddNullMask(builder, NullMask);
			ISphereFactoryComponent.AddDisabled(builder, Disabled);
			return ISphereFactoryComponent.EndISphereFactoryComponent(builder);
		}

		// Token: 0x060291EC RID: 168428 RVA: 0x0059D5E5 File Offset: 0x0059B7E5
		public static void StartISphereFactoryComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060291ED RID: 168429 RVA: 0x0059D5EE File Offset: 0x0059B7EE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060291EE RID: 168430 RVA: 0x0059D5F9 File Offset: 0x0059B7F9
		public static void AddSphereLocation(FlatBufferBuilder builder, Offset<IVectorInfo> sphereLocationOffset)
		{
			builder.AddOffset(1, sphereLocationOffset.Value, 0);
		}

		// Token: 0x060291EF RID: 168431 RVA: 0x0059D609 File Offset: 0x0059B809
		public static void AddSphereGuid(FlatBufferBuilder builder, StringOffset sphereGuidOffset)
		{
			builder.AddOffset(2, sphereGuidOffset.Value, 0);
		}

		// Token: 0x060291F0 RID: 168432 RVA: 0x0059D619 File Offset: 0x0059B819
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060291F1 RID: 168433 RVA: 0x0059D624 File Offset: 0x0059B824
		public static Offset<ISphereFactoryComponent> EndISphereFactoryComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISphereFactoryComponent>(builder.EndTable());
		}

		// Token: 0x060291F2 RID: 168434 RVA: 0x0059D634 File Offset: 0x0059B834
		public ISphereFactoryComponentT UnPack()
		{
			ISphereFactoryComponentT sphereFactoryComponentT = new ISphereFactoryComponentT();
			this.UnPackTo(sphereFactoryComponentT);
			return sphereFactoryComponentT;
		}

		// Token: 0x060291F3 RID: 168435 RVA: 0x0059D650 File Offset: 0x0059B850
		public void UnPackTo(ISphereFactoryComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SphereLocation = ((this.SphereLocation != null) ? this.SphereLocation.Value.UnPack() : null);
			_o.SphereGuid = this.SphereGuid;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060291F4 RID: 168436 RVA: 0x0059D6B0 File Offset: 0x0059B8B0
		public static Offset<ISphereFactoryComponent> Pack(FlatBufferBuilder builder, ISphereFactoryComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereFactoryComponent>);
			}
			Offset<IVectorInfo> sphereLocationOffset = (_o.SphereLocation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SphereLocation);
			StringOffset sphereGuidOffset = (_o.SphereGuid == null) ? default(StringOffset) : builder.CreateString(_o.SphereGuid);
			return ISphereFactoryComponent.CreateISphereFactoryComponent(builder, _o.Disabled, sphereLocationOffset, sphereGuidOffset, _o.NullMask);
		}

		// Token: 0x0400FC60 RID: 64608
		private Table __p;
	}
}
