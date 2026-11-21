using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006109 RID: 24841
	public struct ITurntableControlComponent : IFlatbufferObject
	{
		// Token: 0x1700B8ED RID: 47341
		// (get) Token: 0x0602A1B0 RID: 172464 RVA: 0x005BF3DE File Offset: 0x005BD5DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A1B1 RID: 172465 RVA: 0x005BF3EB File Offset: 0x005BD5EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A1B2 RID: 172466 RVA: 0x005BF3F4 File Offset: 0x005BD5F4
		public static ITurntableControlComponent GetRootAsITurntableControlComponent(ByteBuffer _bb)
		{
			return ITurntableControlComponent.GetRootAsITurntableControlComponent(_bb, default(ITurntableControlComponent));
		}

		// Token: 0x0602A1B3 RID: 172467 RVA: 0x005BF410 File Offset: 0x005BD610
		public static ITurntableControlComponent GetRootAsITurntableControlComponent(ByteBuffer _bb, ITurntableControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A1B4 RID: 172468 RVA: 0x005BF42D File Offset: 0x005BD62D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A1B5 RID: 172469 RVA: 0x005BF43C File Offset: 0x005BD63C
		public ITurntableControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8EE RID: 47342
		// (get) Token: 0x0602A1B6 RID: 172470 RVA: 0x005BF44C File Offset: 0x005BD64C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8EF RID: 47343
		// (get) Token: 0x0602A1B7 RID: 172471 RVA: 0x005BF48C File Offset: 0x005BD68C
		public TTurntableController ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTurntableController.NONE;
				}
				return (TTurntableController)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A1B8 RID: 172472 RVA: 0x005BF4C8 File Offset: 0x005BD6C8
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A1B9 RID: 172473 RVA: 0x005BF50C File Offset: 0x005BD70C
		public IFixedAngleTurntable ConfigAsIFixedAngleTurntable()
		{
			return this.Config<IFixedAngleTurntable>().Value;
		}

		// Token: 0x0602A1BA RID: 172474 RVA: 0x005BF528 File Offset: 0x005BD728
		public IFreeAngleTurntable ConfigAsIFreeAngleTurntable()
		{
			return this.Config<IFreeAngleTurntable>().Value;
		}

		// Token: 0x1700B8F0 RID: 47344
		// (get) Token: 0x0602A1BB RID: 172475 RVA: 0x005BF544 File Offset: 0x005BD744
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

		// Token: 0x0602A1BC RID: 172476 RVA: 0x005BF581 File Offset: 0x005BD781
		public static Offset<ITurntableControlComponent> CreateITurntableControlComponent(FlatBufferBuilder builder, bool Disabled = false, TTurntableController Config_type = TTurntableController.NONE, int ConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITurntableControlComponent.AddConfig(builder, ConfigOffset);
			ITurntableControlComponent.AddNullMask(builder, NullMask);
			ITurntableControlComponent.AddConfigType(builder, Config_type);
			ITurntableControlComponent.AddDisabled(builder, Disabled);
			return ITurntableControlComponent.EndITurntableControlComponent(builder);
		}

		// Token: 0x0602A1BD RID: 172477 RVA: 0x005BF5AD File Offset: 0x005BD7AD
		public static void StartITurntableControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A1BE RID: 172478 RVA: 0x005BF5B6 File Offset: 0x005BD7B6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A1BF RID: 172479 RVA: 0x005BF5C1 File Offset: 0x005BD7C1
		public static void AddConfigType(FlatBufferBuilder builder, TTurntableController configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602A1C0 RID: 172480 RVA: 0x005BF5CC File Offset: 0x005BD7CC
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602A1C1 RID: 172481 RVA: 0x005BF5D7 File Offset: 0x005BD7D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A1C2 RID: 172482 RVA: 0x005BF5E2 File Offset: 0x005BD7E2
		public static Offset<ITurntableControlComponent> EndITurntableControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableControlComponent>(builder.EndTable());
		}

		// Token: 0x0602A1C3 RID: 172483 RVA: 0x005BF5F0 File Offset: 0x005BD7F0
		public ITurntableControlComponentT UnPack()
		{
			ITurntableControlComponentT turntableControlComponentT = new ITurntableControlComponentT();
			this.UnPackTo(turntableControlComponentT);
			return turntableControlComponentT;
		}

		// Token: 0x0602A1C4 RID: 172484 RVA: 0x005BF60C File Offset: 0x005BD80C
		public void UnPackTo(ITurntableControlComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = new TTurntableControllerUnion();
			_o.Config.Type = this.ConfigType;
			TTurntableController configType = this.ConfigType;
			if (configType != TTurntableController.IFixedAngleTurntable)
			{
				if (configType == TTurntableController.IFreeAngleTurntable)
				{
					_o.Config.Value = ((this.Config<IFreeAngleTurntable>() != null) ? this.Config<IFreeAngleTurntable>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Config.Value = ((this.Config<IFixedAngleTurntable>() != null) ? this.Config<IFixedAngleTurntable>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A1C5 RID: 172485 RVA: 0x005BF6CC File Offset: 0x005BD8CC
		public static Offset<ITurntableControlComponent> Pack(FlatBufferBuilder builder, ITurntableControlComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableControlComponent>);
			}
			TTurntableController config_type = (_o.Config == null) ? TTurntableController.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TTurntableControllerUnion.Pack(builder, _o.Config);
			return ITurntableControlComponent.CreateITurntableControlComponent(builder, _o.Disabled, config_type, configOffset, _o.NullMask);
		}

		// Token: 0x0400FEF3 RID: 65267
		private Table __p;
	}
}
