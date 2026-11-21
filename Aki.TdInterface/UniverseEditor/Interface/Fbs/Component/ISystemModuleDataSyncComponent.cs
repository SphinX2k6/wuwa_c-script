using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006026 RID: 24614
	public struct ISystemModuleDataSyncComponent : IFlatbufferObject
	{
		// Token: 0x1700B69C RID: 46748
		// (get) Token: 0x06029839 RID: 170041 RVA: 0x005AA839 File Offset: 0x005A8A39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602983A RID: 170042 RVA: 0x005AA846 File Offset: 0x005A8A46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602983B RID: 170043 RVA: 0x005AA850 File Offset: 0x005A8A50
		public static ISystemModuleDataSyncComponent GetRootAsISystemModuleDataSyncComponent(ByteBuffer _bb)
		{
			return ISystemModuleDataSyncComponent.GetRootAsISystemModuleDataSyncComponent(_bb, default(ISystemModuleDataSyncComponent));
		}

		// Token: 0x0602983C RID: 170044 RVA: 0x005AA86C File Offset: 0x005A8A6C
		public static ISystemModuleDataSyncComponent GetRootAsISystemModuleDataSyncComponent(ByteBuffer _bb, ISystemModuleDataSyncComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602983D RID: 170045 RVA: 0x005AA889 File Offset: 0x005A8A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602983E RID: 170046 RVA: 0x005AA898 File Offset: 0x005A8A98
		public ISystemModuleDataSyncComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B69D RID: 46749
		// (get) Token: 0x0602983F RID: 170047 RVA: 0x005AA8A8 File Offset: 0x005A8AA8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B69E RID: 46750
		// (get) Token: 0x06029840 RID: 170048 RVA: 0x005AA8E8 File Offset: 0x005A8AE8
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

		// Token: 0x1700B69F RID: 46751
		// (get) Token: 0x06029841 RID: 170049 RVA: 0x005AA948 File Offset: 0x005A8B48
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

		// Token: 0x06029842 RID: 170050 RVA: 0x005AA984 File Offset: 0x005A8B84
		public static Offset<ISystemModuleDataSyncComponent> CreateISystemModuleDataSyncComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISystemModuleDataSyncMotorRacing> SystemModuleDataOffset = default(Offset<ISystemModuleDataSyncMotorRacing>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISystemModuleDataSyncComponent.AddSystemModuleData(builder, SystemModuleDataOffset);
			ISystemModuleDataSyncComponent.AddNullMask(builder, NullMask);
			ISystemModuleDataSyncComponent.AddDisabled(builder, Disabled);
			return ISystemModuleDataSyncComponent.EndISystemModuleDataSyncComponent(builder);
		}

		// Token: 0x06029843 RID: 170051 RVA: 0x005AA9A8 File Offset: 0x005A8BA8
		public static void StartISystemModuleDataSyncComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029844 RID: 170052 RVA: 0x005AA9B1 File Offset: 0x005A8BB1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029845 RID: 170053 RVA: 0x005AA9BC File Offset: 0x005A8BBC
		public static void AddSystemModuleData(FlatBufferBuilder builder, Offset<ISystemModuleDataSyncMotorRacing> systemModuleDataOffset)
		{
			builder.AddOffset(1, systemModuleDataOffset.Value, 0);
		}

		// Token: 0x06029846 RID: 170054 RVA: 0x005AA9CC File Offset: 0x005A8BCC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06029847 RID: 170055 RVA: 0x005AA9D7 File Offset: 0x005A8BD7
		public static Offset<ISystemModuleDataSyncComponent> EndISystemModuleDataSyncComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISystemModuleDataSyncComponent>(builder.EndTable());
		}

		// Token: 0x06029848 RID: 170056 RVA: 0x005AA9E4 File Offset: 0x005A8BE4
		public ISystemModuleDataSyncComponentT UnPack()
		{
			ISystemModuleDataSyncComponentT systemModuleDataSyncComponentT = new ISystemModuleDataSyncComponentT();
			this.UnPackTo(systemModuleDataSyncComponentT);
			return systemModuleDataSyncComponentT;
		}

		// Token: 0x06029849 RID: 170057 RVA: 0x005AAA00 File Offset: 0x005A8C00
		public void UnPackTo(ISystemModuleDataSyncComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SystemModuleData = ((this.SystemModuleData != null) ? this.SystemModuleData.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602984A RID: 170058 RVA: 0x005AAA54 File Offset: 0x005A8C54
		public static Offset<ISystemModuleDataSyncComponent> Pack(FlatBufferBuilder builder, ISystemModuleDataSyncComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemModuleDataSyncComponent>);
			}
			Offset<ISystemModuleDataSyncMotorRacing> systemModuleDataOffset = (_o.SystemModuleData == null) ? default(Offset<ISystemModuleDataSyncMotorRacing>) : ISystemModuleDataSyncMotorRacing.Pack(builder, _o.SystemModuleData);
			return ISystemModuleDataSyncComponent.CreateISystemModuleDataSyncComponent(builder, _o.Disabled, systemModuleDataOffset, _o.NullMask);
		}

		// Token: 0x0400FD63 RID: 64867
		private Table __p;
	}
}
