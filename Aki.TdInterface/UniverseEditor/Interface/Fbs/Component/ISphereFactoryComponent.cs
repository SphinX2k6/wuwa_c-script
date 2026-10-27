using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597D RID: 22909
	public struct ISphereFactoryComponent : IFlatbufferObject
	{
		// Token: 0x1700ABE3 RID: 44003
		// (get) Token: 0x06026C75 RID: 158837 RVA: 0x005567B0 File Offset: 0x005549B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C76 RID: 158838 RVA: 0x005567BD File Offset: 0x005549BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C77 RID: 158839 RVA: 0x005567C4 File Offset: 0x005549C4
		public static ISphereFactoryComponent GetRootAsISphereFactoryComponent(ByteBuffer _bb)
		{
			return ISphereFactoryComponent.GetRootAsISphereFactoryComponent(_bb, default(ISphereFactoryComponent));
		}

		// Token: 0x06026C78 RID: 158840 RVA: 0x005567E0 File Offset: 0x005549E0
		public static ISphereFactoryComponent GetRootAsISphereFactoryComponent(ByteBuffer _bb, ISphereFactoryComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C79 RID: 158841 RVA: 0x005567FD File Offset: 0x005549FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C7A RID: 158842 RVA: 0x0055680C File Offset: 0x00554A0C
		public ISphereFactoryComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABE4 RID: 44004
		// (get) Token: 0x06026C7B RID: 158843 RVA: 0x0055681C File Offset: 0x00554A1C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABE5 RID: 44005
		// (get) Token: 0x06026C7C RID: 158844 RVA: 0x0055685C File Offset: 0x00554A5C
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

		// Token: 0x1700ABE6 RID: 44006
		// (get) Token: 0x06026C7D RID: 158845 RVA: 0x005568BC File Offset: 0x00554ABC
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

		// Token: 0x06026C7E RID: 158846 RVA: 0x005568F3 File Offset: 0x00554AF3
		public Span<byte> GetSphereGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026C7F RID: 158847 RVA: 0x00556902 File Offset: 0x00554B02
		public byte[] GetSphereGuidArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700ABE7 RID: 44007
		// (get) Token: 0x06026C80 RID: 158848 RVA: 0x00556910 File Offset: 0x00554B10
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

		// Token: 0x06026C81 RID: 158849 RVA: 0x0055694D File Offset: 0x00554B4D
		public static Offset<ISphereFactoryComponent> CreateISphereFactoryComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IVectorInfo> SphereLocationOffset = default(Offset<IVectorInfo>), StringOffset SphereGuidOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISphereFactoryComponent.AddSphereGuid(builder, SphereGuidOffset);
			ISphereFactoryComponent.AddSphereLocation(builder, SphereLocationOffset);
			ISphereFactoryComponent.AddNullMask(builder, NullMask);
			ISphereFactoryComponent.AddDisabled(builder, Disabled);
			return ISphereFactoryComponent.EndISphereFactoryComponent(builder);
		}

		// Token: 0x06026C82 RID: 158850 RVA: 0x00556979 File Offset: 0x00554B79
		public static void StartISphereFactoryComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026C83 RID: 158851 RVA: 0x00556982 File Offset: 0x00554B82
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026C84 RID: 158852 RVA: 0x0055698D File Offset: 0x00554B8D
		public static void AddSphereLocation(FlatBufferBuilder builder, Offset<IVectorInfo> sphereLocationOffset)
		{
			builder.AddOffset(1, sphereLocationOffset.Value, 0);
		}

		// Token: 0x06026C85 RID: 158853 RVA: 0x0055699D File Offset: 0x00554B9D
		public static void AddSphereGuid(FlatBufferBuilder builder, StringOffset sphereGuidOffset)
		{
			builder.AddOffset(2, sphereGuidOffset.Value, 0);
		}

		// Token: 0x06026C86 RID: 158854 RVA: 0x005569AD File Offset: 0x00554BAD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06026C87 RID: 158855 RVA: 0x005569B8 File Offset: 0x00554BB8
		public static Offset<ISphereFactoryComponent> EndISphereFactoryComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISphereFactoryComponent>(builder.EndTable());
		}

		// Token: 0x06026C88 RID: 158856 RVA: 0x005569C8 File Offset: 0x00554BC8
		public ISphereFactoryComponentT UnPack()
		{
			ISphereFactoryComponentT sphereFactoryComponentT = new ISphereFactoryComponentT();
			this.UnPackTo(sphereFactoryComponentT);
			return sphereFactoryComponentT;
		}

		// Token: 0x06026C89 RID: 158857 RVA: 0x005569E4 File Offset: 0x00554BE4
		public void UnPackTo(ISphereFactoryComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SphereLocation = ((this.SphereLocation != null) ? this.SphereLocation.Value.UnPack() : null);
			_o.SphereGuid = this.SphereGuid;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026C8A RID: 158858 RVA: 0x00556A44 File Offset: 0x00554C44
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

		// Token: 0x0400EF6B RID: 61291
		private Table __p;
	}
}
