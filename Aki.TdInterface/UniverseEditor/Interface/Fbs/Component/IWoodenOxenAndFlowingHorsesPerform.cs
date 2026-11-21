using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A2 RID: 24994
	public struct IWoodenOxenAndFlowingHorsesPerform : IFlatbufferObject
	{
		// Token: 0x1700BA60 RID: 47712
		// (get) Token: 0x0602A7A5 RID: 173989 RVA: 0x005CB385 File Offset: 0x005C9585
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A7A6 RID: 173990 RVA: 0x005CB392 File Offset: 0x005C9592
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A7A7 RID: 173991 RVA: 0x005CB39C File Offset: 0x005C959C
		public static IWoodenOxenAndFlowingHorsesPerform GetRootAsIWoodenOxenAndFlowingHorsesPerform(ByteBuffer _bb)
		{
			return IWoodenOxenAndFlowingHorsesPerform.GetRootAsIWoodenOxenAndFlowingHorsesPerform(_bb, default(IWoodenOxenAndFlowingHorsesPerform));
		}

		// Token: 0x0602A7A8 RID: 173992 RVA: 0x005CB3B8 File Offset: 0x005C95B8
		public static IWoodenOxenAndFlowingHorsesPerform GetRootAsIWoodenOxenAndFlowingHorsesPerform(ByteBuffer _bb, IWoodenOxenAndFlowingHorsesPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A7A9 RID: 173993 RVA: 0x005CB3D5 File Offset: 0x005C95D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A7AA RID: 173994 RVA: 0x005CB3E4 File Offset: 0x005C95E4
		public IWoodenOxenAndFlowingHorsesPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA61 RID: 47713
		// (get) Token: 0x0602A7AB RID: 173995 RVA: 0x005CB3F4 File Offset: 0x005C95F4
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA62 RID: 47714
		// (get) Token: 0x0602A7AC RID: 173996 RVA: 0x005CB430 File Offset: 0x005C9630
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A7AD RID: 173997 RVA: 0x005CB467 File Offset: 0x005C9667
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602A7AE RID: 173998 RVA: 0x005CB476 File Offset: 0x005C9676
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BA63 RID: 47715
		// (get) Token: 0x0602A7AF RID: 173999 RVA: 0x005CB484 File Offset: 0x005C9684
		public IWoodenOxenAndFlowingHorsesPerformConfig? MountPerformLeft
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IWoodenOxenAndFlowingHorsesPerformConfig?(default(IWoodenOxenAndFlowingHorsesPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA64 RID: 47716
		// (get) Token: 0x0602A7B0 RID: 174000 RVA: 0x005CB4E4 File Offset: 0x005C96E4
		public IWoodenOxenAndFlowingHorsesPerformConfig? MountPerformRight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IWoodenOxenAndFlowingHorsesPerformConfig?(default(IWoodenOxenAndFlowingHorsesPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA65 RID: 47717
		// (get) Token: 0x0602A7B1 RID: 174001 RVA: 0x005CB544 File Offset: 0x005C9744
		public IWoodenOxenAndFlowingHorsesPerformConfig? DismountPerformLeft
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IWoodenOxenAndFlowingHorsesPerformConfig?(default(IWoodenOxenAndFlowingHorsesPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA66 RID: 47718
		// (get) Token: 0x0602A7B2 RID: 174002 RVA: 0x005CB5A4 File Offset: 0x005C97A4
		public IWoodenOxenAndFlowingHorsesPerformConfig? DismountPerformRight
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IWoodenOxenAndFlowingHorsesPerformConfig?(default(IWoodenOxenAndFlowingHorsesPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A7B3 RID: 174003 RVA: 0x005CB602 File Offset: 0x005C9802
		public static Offset<IWoodenOxenAndFlowingHorsesPerform> CreateIWoodenOxenAndFlowingHorsesPerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset), Offset<IWoodenOxenAndFlowingHorsesPerformConfig> MountPerformLeftOffset = default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>), Offset<IWoodenOxenAndFlowingHorsesPerformConfig> MountPerformRightOffset = default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>), Offset<IWoodenOxenAndFlowingHorsesPerformConfig> DismountPerformLeftOffset = default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>), Offset<IWoodenOxenAndFlowingHorsesPerformConfig> DismountPerformRightOffset = default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>))
		{
			builder.StartTable(6);
			IWoodenOxenAndFlowingHorsesPerform.AddDismountPerformRight(builder, DismountPerformRightOffset);
			IWoodenOxenAndFlowingHorsesPerform.AddDismountPerformLeft(builder, DismountPerformLeftOffset);
			IWoodenOxenAndFlowingHorsesPerform.AddMountPerformRight(builder, MountPerformRightOffset);
			IWoodenOxenAndFlowingHorsesPerform.AddMountPerformLeft(builder, MountPerformLeftOffset);
			IWoodenOxenAndFlowingHorsesPerform.AddMontage(builder, MontageOffset);
			IWoodenOxenAndFlowingHorsesPerform.AddType(builder, Type);
			return IWoodenOxenAndFlowingHorsesPerform.EndIWoodenOxenAndFlowingHorsesPerform(builder);
		}

		// Token: 0x0602A7B4 RID: 174004 RVA: 0x005CB63E File Offset: 0x005C983E
		public static void StartIWoodenOxenAndFlowingHorsesPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A7B5 RID: 174005 RVA: 0x005CB647 File Offset: 0x005C9847
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A7B6 RID: 174006 RVA: 0x005CB652 File Offset: 0x005C9852
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x0602A7B7 RID: 174007 RVA: 0x005CB662 File Offset: 0x005C9862
		public static void AddMountPerformLeft(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> mountPerformLeftOffset)
		{
			builder.AddOffset(2, mountPerformLeftOffset.Value, 0);
		}

		// Token: 0x0602A7B8 RID: 174008 RVA: 0x005CB672 File Offset: 0x005C9872
		public static void AddMountPerformRight(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> mountPerformRightOffset)
		{
			builder.AddOffset(3, mountPerformRightOffset.Value, 0);
		}

		// Token: 0x0602A7B9 RID: 174009 RVA: 0x005CB682 File Offset: 0x005C9882
		public static void AddDismountPerformLeft(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> dismountPerformLeftOffset)
		{
			builder.AddOffset(4, dismountPerformLeftOffset.Value, 0);
		}

		// Token: 0x0602A7BA RID: 174010 RVA: 0x005CB692 File Offset: 0x005C9892
		public static void AddDismountPerformRight(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> dismountPerformRightOffset)
		{
			builder.AddOffset(5, dismountPerformRightOffset.Value, 0);
		}

		// Token: 0x0602A7BB RID: 174011 RVA: 0x005CB6A2 File Offset: 0x005C98A2
		public static Offset<IWoodenOxenAndFlowingHorsesPerform> EndIWoodenOxenAndFlowingHorsesPerform(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenOxenAndFlowingHorsesPerform>(builder.EndTable());
		}

		// Token: 0x0602A7BC RID: 174012 RVA: 0x005CB6B0 File Offset: 0x005C98B0
		public IWoodenOxenAndFlowingHorsesPerformT UnPack()
		{
			IWoodenOxenAndFlowingHorsesPerformT woodenOxenAndFlowingHorsesPerformT = new IWoodenOxenAndFlowingHorsesPerformT();
			this.UnPackTo(woodenOxenAndFlowingHorsesPerformT);
			return woodenOxenAndFlowingHorsesPerformT;
		}

		// Token: 0x0602A7BD RID: 174013 RVA: 0x005CB6CC File Offset: 0x005C98CC
		public void UnPackTo(IWoodenOxenAndFlowingHorsesPerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
			_o.MountPerformLeft = ((this.MountPerformLeft != null) ? this.MountPerformLeft.Value.UnPack() : null);
			_o.MountPerformRight = ((this.MountPerformRight != null) ? this.MountPerformRight.Value.UnPack() : null);
			_o.DismountPerformLeft = ((this.DismountPerformLeft != null) ? this.DismountPerformLeft.Value.UnPack() : null);
			_o.DismountPerformRight = ((this.DismountPerformRight != null) ? this.DismountPerformRight.Value.UnPack() : null);
		}

		// Token: 0x0602A7BE RID: 174014 RVA: 0x005CB7B0 File Offset: 0x005C99B0
		public static Offset<IWoodenOxenAndFlowingHorsesPerform> Pack(FlatBufferBuilder builder, IWoodenOxenAndFlowingHorsesPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenOxenAndFlowingHorsesPerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			Offset<IWoodenOxenAndFlowingHorsesPerformConfig> mountPerformLeftOffset = (_o.MountPerformLeft == null) ? default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>) : IWoodenOxenAndFlowingHorsesPerformConfig.Pack(builder, _o.MountPerformLeft);
			Offset<IWoodenOxenAndFlowingHorsesPerformConfig> mountPerformRightOffset = (_o.MountPerformRight == null) ? default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>) : IWoodenOxenAndFlowingHorsesPerformConfig.Pack(builder, _o.MountPerformRight);
			Offset<IWoodenOxenAndFlowingHorsesPerformConfig> dismountPerformLeftOffset = (_o.DismountPerformLeft == null) ? default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>) : IWoodenOxenAndFlowingHorsesPerformConfig.Pack(builder, _o.DismountPerformLeft);
			Offset<IWoodenOxenAndFlowingHorsesPerformConfig> dismountPerformRightOffset = (_o.DismountPerformRight == null) ? default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>) : IWoodenOxenAndFlowingHorsesPerformConfig.Pack(builder, _o.DismountPerformRight);
			return IWoodenOxenAndFlowingHorsesPerform.CreateIWoodenOxenAndFlowingHorsesPerform(builder, _o.Type, montageOffset, mountPerformLeftOffset, mountPerformRightOffset, dismountPerformLeftOffset, dismountPerformRightOffset);
		}

		// Token: 0x0400FFEF RID: 65519
		private Table __p;
	}
}
