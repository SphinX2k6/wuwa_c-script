using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A19 RID: 23065
	public struct ISystemModuleDataSyncComponent : IFlatbufferObject
	{
		// Token: 0x1700AD64 RID: 44388
		// (get) Token: 0x060272C1 RID: 160449 RVA: 0x00563875 File Offset: 0x00561A75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060272C2 RID: 160450 RVA: 0x00563882 File Offset: 0x00561A82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060272C3 RID: 160451 RVA: 0x0056388C File Offset: 0x00561A8C
		public static ISystemModuleDataSyncComponent GetRootAsISystemModuleDataSyncComponent(ByteBuffer _bb)
		{
			return ISystemModuleDataSyncComponent.GetRootAsISystemModuleDataSyncComponent(_bb, default(ISystemModuleDataSyncComponent));
		}

		// Token: 0x060272C4 RID: 160452 RVA: 0x005638A8 File Offset: 0x00561AA8
		public static ISystemModuleDataSyncComponent GetRootAsISystemModuleDataSyncComponent(ByteBuffer _bb, ISystemModuleDataSyncComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060272C5 RID: 160453 RVA: 0x005638C5 File Offset: 0x00561AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272C6 RID: 160454 RVA: 0x005638D4 File Offset: 0x00561AD4
		public ISystemModuleDataSyncComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD65 RID: 44389
		// (get) Token: 0x060272C7 RID: 160455 RVA: 0x005638E4 File Offset: 0x00561AE4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD66 RID: 44390
		// (get) Token: 0x060272C8 RID: 160456 RVA: 0x00563924 File Offset: 0x00561B24
		public ISystemModuleDataSyncMotorRacing? SystemModuleData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISystemModuleDataSyncMotorRacing?(default(ISystemModuleDataSyncMotorRacing).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD67 RID: 44391
		// (get) Token: 0x060272C9 RID: 160457 RVA: 0x00563984 File Offset: 0x00561B84
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

		// Token: 0x060272CA RID: 160458 RVA: 0x005639C0 File Offset: 0x00561BC0
		public static Offset<ISystemModuleDataSyncComponent> CreateISystemModuleDataSyncComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISystemModuleDataSyncMotorRacing> SystemModuleDataOffset = default(Offset<ISystemModuleDataSyncMotorRacing>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISystemModuleDataSyncComponent.AddSystemModuleData(builder, SystemModuleDataOffset);
			ISystemModuleDataSyncComponent.AddNullMask(builder, NullMask);
			ISystemModuleDataSyncComponent.AddDisabled(builder, Disabled);
			return ISystemModuleDataSyncComponent.EndISystemModuleDataSyncComponent(builder);
		}

		// Token: 0x060272CB RID: 160459 RVA: 0x005639E4 File Offset: 0x00561BE4
		public static void StartISystemModuleDataSyncComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060272CC RID: 160460 RVA: 0x005639ED File Offset: 0x00561BED
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060272CD RID: 160461 RVA: 0x005639F8 File Offset: 0x00561BF8
		public static void AddSystemModuleData(FlatBufferBuilder builder, Offset<ISystemModuleDataSyncMotorRacing> systemModuleDataOffset)
		{
			builder.AddOffset(1, systemModuleDataOffset.Value, 0);
		}

		// Token: 0x060272CE RID: 160462 RVA: 0x00563A08 File Offset: 0x00561C08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060272CF RID: 160463 RVA: 0x00563A13 File Offset: 0x00561C13
		public static Offset<ISystemModuleDataSyncComponent> EndISystemModuleDataSyncComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISystemModuleDataSyncComponent>(builder.EndTable());
		}

		// Token: 0x060272D0 RID: 160464 RVA: 0x00563A20 File Offset: 0x00561C20
		public ISystemModuleDataSyncComponentT UnPack()
		{
			ISystemModuleDataSyncComponentT systemModuleDataSyncComponentT = new ISystemModuleDataSyncComponentT();
			this.UnPackTo(systemModuleDataSyncComponentT);
			return systemModuleDataSyncComponentT;
		}

		// Token: 0x060272D1 RID: 160465 RVA: 0x00563A3C File Offset: 0x00561C3C
		public void UnPackTo(ISystemModuleDataSyncComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SystemModuleData = ((this.SystemModuleData != null) ? this.SystemModuleData.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060272D2 RID: 160466 RVA: 0x00563A90 File Offset: 0x00561C90
		public static Offset<ISystemModuleDataSyncComponent> Pack(FlatBufferBuilder builder, ISystemModuleDataSyncComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemModuleDataSyncComponent>);
			}
			Offset<ISystemModuleDataSyncMotorRacing> systemModuleDataOffset = (_o.SystemModuleData == null) ? default(Offset<ISystemModuleDataSyncMotorRacing>) : ISystemModuleDataSyncMotorRacing.Pack(builder, _o.SystemModuleData);
			return ISystemModuleDataSyncComponent.CreateISystemModuleDataSyncComponent(builder, _o.Disabled, systemModuleDataOffset, _o.NullMask);
		}

		// Token: 0x0400F06C RID: 61548
		private Table __p;
	}
}
