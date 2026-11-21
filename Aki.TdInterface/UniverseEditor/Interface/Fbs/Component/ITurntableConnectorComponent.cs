using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006100 RID: 24832
	public struct ITurntableConnectorComponent : IFlatbufferObject
	{
		// Token: 0x1700B8E1 RID: 47329
		// (get) Token: 0x0602A178 RID: 172408 RVA: 0x005BEE4F File Offset: 0x005BD04F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A179 RID: 172409 RVA: 0x005BEE5C File Offset: 0x005BD05C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A17A RID: 172410 RVA: 0x005BEE64 File Offset: 0x005BD064
		public static ITurntableConnectorComponent GetRootAsITurntableConnectorComponent(ByteBuffer _bb)
		{
			return ITurntableConnectorComponent.GetRootAsITurntableConnectorComponent(_bb, default(ITurntableConnectorComponent));
		}

		// Token: 0x0602A17B RID: 172411 RVA: 0x005BEE80 File Offset: 0x005BD080
		public static ITurntableConnectorComponent GetRootAsITurntableConnectorComponent(ByteBuffer _bb, ITurntableConnectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A17C RID: 172412 RVA: 0x005BEE9D File Offset: 0x005BD09D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A17D RID: 172413 RVA: 0x005BEEAC File Offset: 0x005BD0AC
		public ITurntableConnectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8E2 RID: 47330
		// (get) Token: 0x0602A17E RID: 172414 RVA: 0x005BEEBC File Offset: 0x005BD0BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8E3 RID: 47331
		// (get) Token: 0x0602A17F RID: 172415 RVA: 0x005BEEFC File Offset: 0x005BD0FC
		public ICircuitConnect? Gameplay
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICircuitConnect?(default(ICircuitConnect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B8E4 RID: 47332
		// (get) Token: 0x0602A180 RID: 172416 RVA: 0x005BEF5C File Offset: 0x005BD15C
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

		// Token: 0x0602A181 RID: 172417 RVA: 0x005BEF98 File Offset: 0x005BD198
		public static Offset<ITurntableConnectorComponent> CreateITurntableConnectorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ICircuitConnect> GameplayOffset = default(Offset<ICircuitConnect>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ITurntableConnectorComponent.AddGameplay(builder, GameplayOffset);
			ITurntableConnectorComponent.AddNullMask(builder, NullMask);
			ITurntableConnectorComponent.AddDisabled(builder, Disabled);
			return ITurntableConnectorComponent.EndITurntableConnectorComponent(builder);
		}

		// Token: 0x0602A182 RID: 172418 RVA: 0x005BEFBC File Offset: 0x005BD1BC
		public static void StartITurntableConnectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A183 RID: 172419 RVA: 0x005BEFC5 File Offset: 0x005BD1C5
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A184 RID: 172420 RVA: 0x005BEFD0 File Offset: 0x005BD1D0
		public static void AddGameplay(FlatBufferBuilder builder, Offset<ICircuitConnect> gameplayOffset)
		{
			builder.AddOffset(1, gameplayOffset.Value, 0);
		}

		// Token: 0x0602A185 RID: 172421 RVA: 0x005BEFE0 File Offset: 0x005BD1E0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A186 RID: 172422 RVA: 0x005BEFEB File Offset: 0x005BD1EB
		public static Offset<ITurntableConnectorComponent> EndITurntableConnectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorComponent>(builder.EndTable());
		}

		// Token: 0x0602A187 RID: 172423 RVA: 0x005BEFF8 File Offset: 0x005BD1F8
		public ITurntableConnectorComponentT UnPack()
		{
			ITurntableConnectorComponentT turntableConnectorComponentT = new ITurntableConnectorComponentT();
			this.UnPackTo(turntableConnectorComponentT);
			return turntableConnectorComponentT;
		}

		// Token: 0x0602A188 RID: 172424 RVA: 0x005BF014 File Offset: 0x005BD214
		public void UnPackTo(ITurntableConnectorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Gameplay = ((this.Gameplay != null) ? this.Gameplay.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A189 RID: 172425 RVA: 0x005BF068 File Offset: 0x005BD268
		public static Offset<ITurntableConnectorComponent> Pack(FlatBufferBuilder builder, ITurntableConnectorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorComponent>);
			}
			Offset<ICircuitConnect> gameplayOffset = (_o.Gameplay == null) ? default(Offset<ICircuitConnect>) : ICircuitConnect.Pack(builder, _o.Gameplay);
			return ITurntableConnectorComponent.CreateITurntableConnectorComponent(builder, _o.Disabled, gameplayOffset, _o.NullMask);
		}

		// Token: 0x0400FEE7 RID: 65255
		private Table __p;
	}
}
