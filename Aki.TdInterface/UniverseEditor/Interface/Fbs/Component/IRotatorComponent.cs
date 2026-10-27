using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588E RID: 22670
	public struct IRotatorComponent : IFlatbufferObject
	{
		// Token: 0x1700A990 RID: 43408
		// (get) Token: 0x0602633E RID: 156478 RVA: 0x00544102 File Offset: 0x00542302
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602633F RID: 156479 RVA: 0x0054410F File Offset: 0x0054230F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026340 RID: 156480 RVA: 0x00544118 File Offset: 0x00542318
		public static IRotatorComponent GetRootAsIRotatorComponent(ByteBuffer _bb)
		{
			return IRotatorComponent.GetRootAsIRotatorComponent(_bb, default(IRotatorComponent));
		}

		// Token: 0x06026341 RID: 156481 RVA: 0x00544134 File Offset: 0x00542334
		public static IRotatorComponent GetRootAsIRotatorComponent(ByteBuffer _bb, IRotatorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026342 RID: 156482 RVA: 0x00544151 File Offset: 0x00542351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026343 RID: 156483 RVA: 0x00544160 File Offset: 0x00542360
		public IRotatorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A991 RID: 43409
		// (get) Token: 0x06026344 RID: 156484 RVA: 0x00544170 File Offset: 0x00542370
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A992 RID: 43410
		// (get) Token: 0x06026345 RID: 156485 RVA: 0x005441B0 File Offset: 0x005423B0
		public string Content
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

		// Token: 0x06026346 RID: 156486 RVA: 0x005441E7 File Offset: 0x005423E7
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026347 RID: 156487 RVA: 0x005441F6 File Offset: 0x005423F6
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A993 RID: 43411
		// (get) Token: 0x06026348 RID: 156488 RVA: 0x00544204 File Offset: 0x00542404
		public string Icon
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

		// Token: 0x06026349 RID: 156489 RVA: 0x0054423B File Offset: 0x0054243B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602634A RID: 156490 RVA: 0x0054424A File Offset: 0x0054244A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A994 RID: 43412
		// (get) Token: 0x0602634B RID: 156491 RVA: 0x00544258 File Offset: 0x00542458
		public IVectorInfo? RotatorSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A995 RID: 43413
		// (get) Token: 0x0602634C RID: 156492 RVA: 0x005442B8 File Offset: 0x005424B8
		public IVectorInfo? LocationOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A996 RID: 43414
		// (get) Token: 0x0602634D RID: 156493 RVA: 0x00544318 File Offset: 0x00542518
		public IVectorInfo? RotationOffset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A997 RID: 43415
		// (get) Token: 0x0602634E RID: 156494 RVA: 0x00544378 File Offset: 0x00542578
		public IVectorInfo? RotationMapping
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A998 RID: 43416
		// (get) Token: 0x0602634F RID: 156495 RVA: 0x005443D8 File Offset: 0x005425D8
		public bool IsLocalSpace
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A999 RID: 43417
		// (get) Token: 0x06026350 RID: 156496 RVA: 0x00544418 File Offset: 0x00542618
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A99A RID: 43418
		// (get) Token: 0x06026351 RID: 156497 RVA: 0x00544458 File Offset: 0x00542658
		public bool IsRotatorSelf
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99B RID: 43419
		// (get) Token: 0x06026352 RID: 156498 RVA: 0x00544498 File Offset: 0x00542698
		public IEventRotator? InteractAction
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IEventRotator?(default(IEventRotator).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A99C RID: 43420
		// (get) Token: 0x06026353 RID: 156499 RVA: 0x005444F8 File Offset: 0x005426F8
		public bool IsLockZ
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99D RID: 43421
		// (get) Token: 0x06026354 RID: 156500 RVA: 0x00544538 File Offset: 0x00542738
		public bool IsRecovery
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99E RID: 43422
		// (get) Token: 0x06026355 RID: 156501 RVA: 0x00544578 File Offset: 0x00542778
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026356 RID: 156502 RVA: 0x005445B8 File Offset: 0x005427B8
		public static Offset<IRotatorComponent> CreateIRotatorComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ContentOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), Offset<IVectorInfo> RotatorSpeedOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LocationOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationMappingOffset = default(Offset<IVectorInfo>), bool IsLocalSpace = false, int EntityId = 0, bool IsRotatorSelf = false, Offset<IEventRotator> InteractActionOffset = default(Offset<IEventRotator>), bool IsLockZ = false, bool IsRecovery = false, byte NullMask = 0)
		{
			builder.StartTable(14);
			IRotatorComponent.AddInteractAction(builder, InteractActionOffset);
			IRotatorComponent.AddEntityId(builder, EntityId);
			IRotatorComponent.AddRotationMapping(builder, RotationMappingOffset);
			IRotatorComponent.AddRotationOffset(builder, RotationOffsetOffset);
			IRotatorComponent.AddLocationOffset(builder, LocationOffsetOffset);
			IRotatorComponent.AddRotatorSpeed(builder, RotatorSpeedOffset);
			IRotatorComponent.AddIcon(builder, IconOffset);
			IRotatorComponent.AddContent(builder, ContentOffset);
			IRotatorComponent.AddNullMask(builder, NullMask);
			IRotatorComponent.AddIsRecovery(builder, IsRecovery);
			IRotatorComponent.AddIsLockZ(builder, IsLockZ);
			IRotatorComponent.AddIsRotatorSelf(builder, IsRotatorSelf);
			IRotatorComponent.AddIsLocalSpace(builder, IsLocalSpace);
			IRotatorComponent.AddDisabled(builder, Disabled);
			return IRotatorComponent.EndIRotatorComponent(builder);
		}

		// Token: 0x06026357 RID: 156503 RVA: 0x00544640 File Offset: 0x00542840
		public static void StartIRotatorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06026358 RID: 156504 RVA: 0x0054464A File Offset: 0x0054284A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026359 RID: 156505 RVA: 0x00544655 File Offset: 0x00542855
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x0602635A RID: 156506 RVA: 0x00544665 File Offset: 0x00542865
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x0602635B RID: 156507 RVA: 0x00544675 File Offset: 0x00542875
		public static void AddRotatorSpeed(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorSpeedOffset)
		{
			builder.AddOffset(3, rotatorSpeedOffset.Value, 0);
		}

		// Token: 0x0602635C RID: 156508 RVA: 0x00544685 File Offset: 0x00542885
		public static void AddLocationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> locationOffsetOffset)
		{
			builder.AddOffset(4, locationOffsetOffset.Value, 0);
		}

		// Token: 0x0602635D RID: 156509 RVA: 0x00544695 File Offset: 0x00542895
		public static void AddRotationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffsetOffset)
		{
			builder.AddOffset(5, rotationOffsetOffset.Value, 0);
		}

		// Token: 0x0602635E RID: 156510 RVA: 0x005446A5 File Offset: 0x005428A5
		public static void AddRotationMapping(FlatBufferBuilder builder, Offset<IVectorInfo> rotationMappingOffset)
		{
			builder.AddOffset(6, rotationMappingOffset.Value, 0);
		}

		// Token: 0x0602635F RID: 156511 RVA: 0x005446B5 File Offset: 0x005428B5
		public static void AddIsLocalSpace(FlatBufferBuilder builder, bool isLocalSpace)
		{
			builder.AddBool(7, isLocalSpace, false);
		}

		// Token: 0x06026360 RID: 156512 RVA: 0x005446C0 File Offset: 0x005428C0
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(8, entityId, 0);
		}

		// Token: 0x06026361 RID: 156513 RVA: 0x005446CB File Offset: 0x005428CB
		public static void AddIsRotatorSelf(FlatBufferBuilder builder, bool isRotatorSelf)
		{
			builder.AddBool(9, isRotatorSelf, false);
		}

		// Token: 0x06026362 RID: 156514 RVA: 0x005446D7 File Offset: 0x005428D7
		public static void AddInteractAction(FlatBufferBuilder builder, Offset<IEventRotator> interactActionOffset)
		{
			builder.AddOffset(10, interactActionOffset.Value, 0);
		}

		// Token: 0x06026363 RID: 156515 RVA: 0x005446E8 File Offset: 0x005428E8
		public static void AddIsLockZ(FlatBufferBuilder builder, bool isLockZ)
		{
			builder.AddBool(11, isLockZ, false);
		}

		// Token: 0x06026364 RID: 156516 RVA: 0x005446F4 File Offset: 0x005428F4
		public static void AddIsRecovery(FlatBufferBuilder builder, bool isRecovery)
		{
			builder.AddBool(12, isRecovery, false);
		}

		// Token: 0x06026365 RID: 156517 RVA: 0x00544700 File Offset: 0x00542900
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06026366 RID: 156518 RVA: 0x0054470C File Offset: 0x0054290C
		public static Offset<IRotatorComponent> EndIRotatorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRotatorComponent>(builder.EndTable());
		}

		// Token: 0x06026367 RID: 156519 RVA: 0x0054471C File Offset: 0x0054291C
		public IRotatorComponentT UnPack()
		{
			IRotatorComponentT rotatorComponentT = new IRotatorComponentT();
			this.UnPackTo(rotatorComponentT);
			return rotatorComponentT;
		}

		// Token: 0x06026368 RID: 156520 RVA: 0x00544738 File Offset: 0x00542938
		public void UnPackTo(IRotatorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Content = this.Content;
			_o.Icon = this.Icon;
			_o.RotatorSpeed = ((this.RotatorSpeed != null) ? this.RotatorSpeed.Value.UnPack() : null);
			_o.LocationOffset = ((this.LocationOffset != null) ? this.LocationOffset.Value.UnPack() : null);
			_o.RotationOffset = ((this.RotationOffset != null) ? this.RotationOffset.Value.UnPack() : null);
			_o.RotationMapping = ((this.RotationMapping != null) ? this.RotationMapping.Value.UnPack() : null);
			_o.IsLocalSpace = this.IsLocalSpace;
			_o.EntityId = this.EntityId;
			_o.IsRotatorSelf = this.IsRotatorSelf;
			_o.InteractAction = ((this.InteractAction != null) ? this.InteractAction.Value.UnPack() : null);
			_o.IsLockZ = this.IsLockZ;
			_o.IsRecovery = this.IsRecovery;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026369 RID: 156521 RVA: 0x0054489C File Offset: 0x00542A9C
		public static Offset<IRotatorComponent> Pack(FlatBufferBuilder builder, IRotatorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRotatorComponent>);
			}
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			Offset<IVectorInfo> rotatorSpeedOffset = (_o.RotatorSpeed == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RotatorSpeed);
			Offset<IVectorInfo> locationOffsetOffset = (_o.LocationOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LocationOffset);
			Offset<IVectorInfo> rotationOffsetOffset = (_o.RotationOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RotationOffset);
			Offset<IVectorInfo> rotationMappingOffset = (_o.RotationMapping == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RotationMapping);
			Offset<IEventRotator> interactActionOffset = (_o.InteractAction == null) ? default(Offset<IEventRotator>) : IEventRotator.Pack(builder, _o.InteractAction);
			return IRotatorComponent.CreateIRotatorComponent(builder, _o.Disabled, contentOffset, iconOffset, rotatorSpeedOffset, locationOffsetOffset, rotationOffsetOffset, rotationMappingOffset, _o.IsLocalSpace, _o.EntityId, _o.IsRotatorSelf, interactActionOffset, _o.IsLockZ, _o.IsRecovery, _o.NullMask);
		}

		// Token: 0x0400EDDE RID: 60894
		private Table __p;
	}
}
