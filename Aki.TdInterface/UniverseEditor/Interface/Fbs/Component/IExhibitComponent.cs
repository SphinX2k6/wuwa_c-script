using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051CE RID: 20942
	public struct IExhibitComponent : IFlatbufferObject
	{
		// Token: 0x17009944 RID: 39236
		// (get) Token: 0x06021F4A RID: 139082 RVA: 0x004B5F0F File Offset: 0x004B410F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F4B RID: 139083 RVA: 0x004B5F1C File Offset: 0x004B411C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F4C RID: 139084 RVA: 0x004B5F24 File Offset: 0x004B4124
		public static IExhibitComponent GetRootAsIExhibitComponent(ByteBuffer _bb)
		{
			return IExhibitComponent.GetRootAsIExhibitComponent(_bb, default(IExhibitComponent));
		}

		// Token: 0x06021F4D RID: 139085 RVA: 0x004B5F40 File Offset: 0x004B4140
		public static IExhibitComponent GetRootAsIExhibitComponent(ByteBuffer _bb, IExhibitComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F4E RID: 139086 RVA: 0x004B5F5D File Offset: 0x004B415D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F4F RID: 139087 RVA: 0x004B5F6C File Offset: 0x004B416C
		public IExhibitComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009945 RID: 39237
		// (get) Token: 0x06021F50 RID: 139088 RVA: 0x004B5F7C File Offset: 0x004B417C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009946 RID: 39238
		// (get) Token: 0x06021F51 RID: 139089 RVA: 0x004B5FBC File Offset: 0x004B41BC
		public TExhibitConfig ExhibitConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TExhibitConfig.NONE;
				}
				return (TExhibitConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021F52 RID: 139090 RVA: 0x004B5FF8 File Offset: 0x004B41F8
		public TTable? ExhibitConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021F53 RID: 139091 RVA: 0x004B603C File Offset: 0x004B423C
		public IPhantomExhibitConfig ExhibitConfigAsIPhantomExhibitConfig()
		{
			return this.ExhibitConfig<IPhantomExhibitConfig>().Value;
		}

		// Token: 0x06021F54 RID: 139092 RVA: 0x004B6058 File Offset: 0x004B4258
		public IWeaponExhibitConfig ExhibitConfigAsIWeaponExhibitConfig()
		{
			return this.ExhibitConfig<IWeaponExhibitConfig>().Value;
		}

		// Token: 0x17009947 RID: 39239
		// (get) Token: 0x06021F55 RID: 139093 RVA: 0x004B6074 File Offset: 0x004B4274
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

		// Token: 0x06021F56 RID: 139094 RVA: 0x004B60B1 File Offset: 0x004B42B1
		public static Offset<IExhibitComponent> CreateIExhibitComponent(FlatBufferBuilder builder, bool Disabled = false, TExhibitConfig ExhibitConfig_type = TExhibitConfig.NONE, int ExhibitConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IExhibitComponent.AddExhibitConfig(builder, ExhibitConfigOffset);
			IExhibitComponent.AddNullMask(builder, NullMask);
			IExhibitComponent.AddExhibitConfigType(builder, ExhibitConfig_type);
			IExhibitComponent.AddDisabled(builder, Disabled);
			return IExhibitComponent.EndIExhibitComponent(builder);
		}

		// Token: 0x06021F57 RID: 139095 RVA: 0x004B60DD File Offset: 0x004B42DD
		public static void StartIExhibitComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021F58 RID: 139096 RVA: 0x004B60E6 File Offset: 0x004B42E6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021F59 RID: 139097 RVA: 0x004B60F1 File Offset: 0x004B42F1
		public static void AddExhibitConfigType(FlatBufferBuilder builder, TExhibitConfig exhibitConfigType)
		{
			builder.AddByte(1, (byte)exhibitConfigType, 0);
		}

		// Token: 0x06021F5A RID: 139098 RVA: 0x004B60FC File Offset: 0x004B42FC
		public static void AddExhibitConfig(FlatBufferBuilder builder, int exhibitConfigOffset)
		{
			builder.AddOffset(2, exhibitConfigOffset, 0);
		}

		// Token: 0x06021F5B RID: 139099 RVA: 0x004B6107 File Offset: 0x004B4307
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021F5C RID: 139100 RVA: 0x004B6112 File Offset: 0x004B4312
		public static Offset<IExhibitComponent> EndIExhibitComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExhibitComponent>(builder.EndTable());
		}

		// Token: 0x06021F5D RID: 139101 RVA: 0x004B6120 File Offset: 0x004B4320
		public IExhibitComponentT UnPack()
		{
			IExhibitComponentT exhibitComponentT = new IExhibitComponentT();
			this.UnPackTo(exhibitComponentT);
			return exhibitComponentT;
		}

		// Token: 0x06021F5E RID: 139102 RVA: 0x004B613C File Offset: 0x004B433C
		public void UnPackTo(IExhibitComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ExhibitConfig = new TExhibitConfigUnion();
			_o.ExhibitConfig.Type = this.ExhibitConfigType;
			TExhibitConfig exhibitConfigType = this.ExhibitConfigType;
			if (exhibitConfigType != TExhibitConfig.IPhantomExhibitConfig)
			{
				if (exhibitConfigType == TExhibitConfig.IWeaponExhibitConfig)
				{
					_o.ExhibitConfig.Value = ((this.ExhibitConfig<IWeaponExhibitConfig>() != null) ? this.ExhibitConfig<IWeaponExhibitConfig>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ExhibitConfig.Value = ((this.ExhibitConfig<IPhantomExhibitConfig>() != null) ? this.ExhibitConfig<IPhantomExhibitConfig>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021F5F RID: 139103 RVA: 0x004B61FC File Offset: 0x004B43FC
		public static Offset<IExhibitComponent> Pack(FlatBufferBuilder builder, IExhibitComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExhibitComponent>);
			}
			TExhibitConfig exhibitConfig_type = (_o.ExhibitConfig == null) ? TExhibitConfig.NONE : _o.ExhibitConfig.Type;
			int exhibitConfigOffset = (_o.ExhibitConfig == null) ? 0 : TExhibitConfigUnion.Pack(builder, _o.ExhibitConfig);
			return IExhibitComponent.CreateIExhibitComponent(builder, _o.Disabled, exhibitConfig_type, exhibitConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E2D2 RID: 58066
		private Table __p;
	}
}
