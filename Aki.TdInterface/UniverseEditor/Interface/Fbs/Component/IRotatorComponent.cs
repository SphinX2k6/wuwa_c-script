using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E9B RID: 24219
	public struct IRotatorComponent : IFlatbufferObject
	{
		// Token: 0x1700B2C0 RID: 45760
		// (get) Token: 0x060288A0 RID: 166048 RVA: 0x0058AC4E File Offset: 0x00588E4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060288A1 RID: 166049 RVA: 0x0058AC5B File Offset: 0x00588E5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060288A2 RID: 166050 RVA: 0x0058AC64 File Offset: 0x00588E64
		public static IRotatorComponent GetRootAsIRotatorComponent(ByteBuffer _bb)
		{
			return IRotatorComponent.GetRootAsIRotatorComponent(_bb, default(IRotatorComponent));
		}

		// Token: 0x060288A3 RID: 166051 RVA: 0x0058AC80 File Offset: 0x00588E80
		public static IRotatorComponent GetRootAsIRotatorComponent(ByteBuffer _bb, IRotatorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060288A4 RID: 166052 RVA: 0x0058AC9D File Offset: 0x00588E9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060288A5 RID: 166053 RVA: 0x0058ACAC File Offset: 0x00588EAC
		public IRotatorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2C1 RID: 45761
		// (get) Token: 0x060288A6 RID: 166054 RVA: 0x0058ACBC File Offset: 0x00588EBC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2C2 RID: 45762
		// (get) Token: 0x060288A7 RID: 166055 RVA: 0x0058ACFC File Offset: 0x00588EFC
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

		// Token: 0x060288A8 RID: 166056 RVA: 0x0058AD33 File Offset: 0x00588F33
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060288A9 RID: 166057 RVA: 0x0058AD42 File Offset: 0x00588F42
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B2C3 RID: 45763
		// (get) Token: 0x060288AA RID: 166058 RVA: 0x0058AD50 File Offset: 0x00588F50
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

		// Token: 0x060288AB RID: 166059 RVA: 0x0058AD87 File Offset: 0x00588F87
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060288AC RID: 166060 RVA: 0x0058AD96 File Offset: 0x00588F96
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B2C4 RID: 45764
		// (get) Token: 0x060288AD RID: 166061 RVA: 0x0058ADA4 File Offset: 0x00588FA4
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

		// Token: 0x1700B2C5 RID: 45765
		// (get) Token: 0x060288AE RID: 166062 RVA: 0x0058AE04 File Offset: 0x00589004
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

		// Token: 0x1700B2C6 RID: 45766
		// (get) Token: 0x060288AF RID: 166063 RVA: 0x0058AE64 File Offset: 0x00589064
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

		// Token: 0x1700B2C7 RID: 45767
		// (get) Token: 0x060288B0 RID: 166064 RVA: 0x0058AEC4 File Offset: 0x005890C4
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

		// Token: 0x1700B2C8 RID: 45768
		// (get) Token: 0x060288B1 RID: 166065 RVA: 0x0058AF24 File Offset: 0x00589124
		public bool IsLocalSpace
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2C9 RID: 45769
		// (get) Token: 0x060288B2 RID: 166066 RVA: 0x0058AF64 File Offset: 0x00589164
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

		// Token: 0x1700B2CA RID: 45770
		// (get) Token: 0x060288B3 RID: 166067 RVA: 0x0058AFA4 File Offset: 0x005891A4
		public bool IsRotatorSelf
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2CB RID: 45771
		// (get) Token: 0x060288B4 RID: 166068 RVA: 0x0058AFE4 File Offset: 0x005891E4
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

		// Token: 0x1700B2CC RID: 45772
		// (get) Token: 0x060288B5 RID: 166069 RVA: 0x0058B044 File Offset: 0x00589244
		public bool IsLockZ
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2CD RID: 45773
		// (get) Token: 0x060288B6 RID: 166070 RVA: 0x0058B084 File Offset: 0x00589284
		public bool IsRecovery
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2CE RID: 45774
		// (get) Token: 0x060288B7 RID: 166071 RVA: 0x0058B0C4 File Offset: 0x005892C4
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

		// Token: 0x060288B8 RID: 166072 RVA: 0x0058B104 File Offset: 0x00589304
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

		// Token: 0x060288B9 RID: 166073 RVA: 0x0058B18C File Offset: 0x0058938C
		public static void StartIRotatorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x060288BA RID: 166074 RVA: 0x0058B196 File Offset: 0x00589396
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060288BB RID: 166075 RVA: 0x0058B1A1 File Offset: 0x005893A1
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x060288BC RID: 166076 RVA: 0x0058B1B1 File Offset: 0x005893B1
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x060288BD RID: 166077 RVA: 0x0058B1C1 File Offset: 0x005893C1
		public static void AddRotatorSpeed(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorSpeedOffset)
		{
			builder.AddOffset(3, rotatorSpeedOffset.Value, 0);
		}

		// Token: 0x060288BE RID: 166078 RVA: 0x0058B1D1 File Offset: 0x005893D1
		public static void AddLocationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> locationOffsetOffset)
		{
			builder.AddOffset(4, locationOffsetOffset.Value, 0);
		}

		// Token: 0x060288BF RID: 166079 RVA: 0x0058B1E1 File Offset: 0x005893E1
		public static void AddRotationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffsetOffset)
		{
			builder.AddOffset(5, rotationOffsetOffset.Value, 0);
		}

		// Token: 0x060288C0 RID: 166080 RVA: 0x0058B1F1 File Offset: 0x005893F1
		public static void AddRotationMapping(FlatBufferBuilder builder, Offset<IVectorInfo> rotationMappingOffset)
		{
			builder.AddOffset(6, rotationMappingOffset.Value, 0);
		}

		// Token: 0x060288C1 RID: 166081 RVA: 0x0058B201 File Offset: 0x00589401
		public static void AddIsLocalSpace(FlatBufferBuilder builder, bool isLocalSpace)
		{
			builder.AddBool(7, isLocalSpace, false);
		}

		// Token: 0x060288C2 RID: 166082 RVA: 0x0058B20C File Offset: 0x0058940C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(8, entityId, 0);
		}

		// Token: 0x060288C3 RID: 166083 RVA: 0x0058B217 File Offset: 0x00589417
		public static void AddIsRotatorSelf(FlatBufferBuilder builder, bool isRotatorSelf)
		{
			builder.AddBool(9, isRotatorSelf, false);
		}

		// Token: 0x060288C4 RID: 166084 RVA: 0x0058B223 File Offset: 0x00589423
		public static void AddInteractAction(FlatBufferBuilder builder, Offset<IEventRotator> interactActionOffset)
		{
			builder.AddOffset(10, interactActionOffset.Value, 0);
		}

		// Token: 0x060288C5 RID: 166085 RVA: 0x0058B234 File Offset: 0x00589434
		public static void AddIsLockZ(FlatBufferBuilder builder, bool isLockZ)
		{
			builder.AddBool(11, isLockZ, false);
		}

		// Token: 0x060288C6 RID: 166086 RVA: 0x0058B240 File Offset: 0x00589440
		public static void AddIsRecovery(FlatBufferBuilder builder, bool isRecovery)
		{
			builder.AddBool(12, isRecovery, false);
		}

		// Token: 0x060288C7 RID: 166087 RVA: 0x0058B24C File Offset: 0x0058944C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x060288C8 RID: 166088 RVA: 0x0058B258 File Offset: 0x00589458
		public static Offset<IRotatorComponent> EndIRotatorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRotatorComponent>(builder.EndTable());
		}

		// Token: 0x060288C9 RID: 166089 RVA: 0x0058B268 File Offset: 0x00589468
		public IRotatorComponentT UnPack()
		{
			IRotatorComponentT rotatorComponentT = new IRotatorComponentT();
			this.UnPackTo(rotatorComponentT);
			return rotatorComponentT;
		}

		// Token: 0x060288CA RID: 166090 RVA: 0x0058B284 File Offset: 0x00589484
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

		// Token: 0x060288CB RID: 166091 RVA: 0x0058B3E8 File Offset: 0x005895E8
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

		// Token: 0x0400FAD1 RID: 64209
		private Table __p;
	}
}
