using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8C RID: 23436
	public struct IWoodenOxenAndFlowingHorsesPerform : IFlatbufferObject
	{
		// Token: 0x1700B118 RID: 45336
		// (get) Token: 0x060281E1 RID: 164321 RVA: 0x005838F5 File Offset: 0x00581AF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060281E2 RID: 164322 RVA: 0x00583902 File Offset: 0x00581B02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060281E3 RID: 164323 RVA: 0x0058390C File Offset: 0x00581B0C
		public static IWoodenOxenAndFlowingHorsesPerform GetRootAsIWoodenOxenAndFlowingHorsesPerform(ByteBuffer _bb)
		{
			return IWoodenOxenAndFlowingHorsesPerform.GetRootAsIWoodenOxenAndFlowingHorsesPerform(_bb, default(IWoodenOxenAndFlowingHorsesPerform));
		}

		// Token: 0x060281E4 RID: 164324 RVA: 0x00583928 File Offset: 0x00581B28
		public static IWoodenOxenAndFlowingHorsesPerform GetRootAsIWoodenOxenAndFlowingHorsesPerform(ByteBuffer _bb, IWoodenOxenAndFlowingHorsesPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060281E5 RID: 164325 RVA: 0x00583945 File Offset: 0x00581B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060281E6 RID: 164326 RVA: 0x00583954 File Offset: 0x00581B54
		public IWoodenOxenAndFlowingHorsesPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B119 RID: 45337
		// (get) Token: 0x060281E7 RID: 164327 RVA: 0x00583964 File Offset: 0x00581B64
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

		// Token: 0x1700B11A RID: 45338
		// (get) Token: 0x060281E8 RID: 164328 RVA: 0x005839A0 File Offset: 0x00581BA0
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

		// Token: 0x060281E9 RID: 164329 RVA: 0x005839D7 File Offset: 0x00581BD7
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060281EA RID: 164330 RVA: 0x005839E6 File Offset: 0x00581BE6
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B11B RID: 45339
		// (get) Token: 0x060281EB RID: 164331 RVA: 0x005839F4 File Offset: 0x00581BF4
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

		// Token: 0x1700B11C RID: 45340
		// (get) Token: 0x060281EC RID: 164332 RVA: 0x00583A54 File Offset: 0x00581C54
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

		// Token: 0x1700B11D RID: 45341
		// (get) Token: 0x060281ED RID: 164333 RVA: 0x00583AB4 File Offset: 0x00581CB4
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

		// Token: 0x1700B11E RID: 45342
		// (get) Token: 0x060281EE RID: 164334 RVA: 0x00583B14 File Offset: 0x00581D14
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

		// Token: 0x060281EF RID: 164335 RVA: 0x00583B72 File Offset: 0x00581D72
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

		// Token: 0x060281F0 RID: 164336 RVA: 0x00583BAE File Offset: 0x00581DAE
		public static void StartIWoodenOxenAndFlowingHorsesPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060281F1 RID: 164337 RVA: 0x00583BB7 File Offset: 0x00581DB7
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060281F2 RID: 164338 RVA: 0x00583BC2 File Offset: 0x00581DC2
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x060281F3 RID: 164339 RVA: 0x00583BD2 File Offset: 0x00581DD2
		public static void AddMountPerformLeft(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> mountPerformLeftOffset)
		{
			builder.AddOffset(2, mountPerformLeftOffset.Value, 0);
		}

		// Token: 0x060281F4 RID: 164340 RVA: 0x00583BE2 File Offset: 0x00581DE2
		public static void AddMountPerformRight(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> mountPerformRightOffset)
		{
			builder.AddOffset(3, mountPerformRightOffset.Value, 0);
		}

		// Token: 0x060281F5 RID: 164341 RVA: 0x00583BF2 File Offset: 0x00581DF2
		public static void AddDismountPerformLeft(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> dismountPerformLeftOffset)
		{
			builder.AddOffset(4, dismountPerformLeftOffset.Value, 0);
		}

		// Token: 0x060281F6 RID: 164342 RVA: 0x00583C02 File Offset: 0x00581E02
		public static void AddDismountPerformRight(FlatBufferBuilder builder, Offset<IWoodenOxenAndFlowingHorsesPerformConfig> dismountPerformRightOffset)
		{
			builder.AddOffset(5, dismountPerformRightOffset.Value, 0);
		}

		// Token: 0x060281F7 RID: 164343 RVA: 0x00583C12 File Offset: 0x00581E12
		public static Offset<IWoodenOxenAndFlowingHorsesPerform> EndIWoodenOxenAndFlowingHorsesPerform(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenOxenAndFlowingHorsesPerform>(builder.EndTable());
		}

		// Token: 0x060281F8 RID: 164344 RVA: 0x00583C20 File Offset: 0x00581E20
		public IWoodenOxenAndFlowingHorsesPerformT UnPack()
		{
			IWoodenOxenAndFlowingHorsesPerformT woodenOxenAndFlowingHorsesPerformT = new IWoodenOxenAndFlowingHorsesPerformT();
			this.UnPackTo(woodenOxenAndFlowingHorsesPerformT);
			return woodenOxenAndFlowingHorsesPerformT;
		}

		// Token: 0x060281F9 RID: 164345 RVA: 0x00583C3C File Offset: 0x00581E3C
		public void UnPackTo(IWoodenOxenAndFlowingHorsesPerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
			_o.MountPerformLeft = ((this.MountPerformLeft != null) ? this.MountPerformLeft.Value.UnPack() : null);
			_o.MountPerformRight = ((this.MountPerformRight != null) ? this.MountPerformRight.Value.UnPack() : null);
			_o.DismountPerformLeft = ((this.DismountPerformLeft != null) ? this.DismountPerformLeft.Value.UnPack() : null);
			_o.DismountPerformRight = ((this.DismountPerformRight != null) ? this.DismountPerformRight.Value.UnPack() : null);
		}

		// Token: 0x060281FA RID: 164346 RVA: 0x00583D20 File Offset: 0x00581F20
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

		// Token: 0x0400F2E9 RID: 62185
		private Table __p;
	}
}
