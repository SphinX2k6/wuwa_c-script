using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007406 RID: 29702
	public struct IToggleEntityElementalAbility : IFlatbufferObject
	{
		// Token: 0x1700E198 RID: 57752
		// (get) Token: 0x06035F5B RID: 221019 RVA: 0x00757A24 File Offset: 0x00755C24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F5C RID: 221020 RVA: 0x00757A31 File Offset: 0x00755C31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F5D RID: 221021 RVA: 0x00757A38 File Offset: 0x00755C38
		public static IToggleEntityElementalAbility GetRootAsIToggleEntityElementalAbility(ByteBuffer _bb)
		{
			return IToggleEntityElementalAbility.GetRootAsIToggleEntityElementalAbility(_bb, default(IToggleEntityElementalAbility));
		}

		// Token: 0x06035F5E RID: 221022 RVA: 0x00757A54 File Offset: 0x00755C54
		public static IToggleEntityElementalAbility GetRootAsIToggleEntityElementalAbility(ByteBuffer _bb, IToggleEntityElementalAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F5F RID: 221023 RVA: 0x00757A71 File Offset: 0x00755C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F60 RID: 221024 RVA: 0x00757A80 File Offset: 0x00755C80
		public IToggleEntityElementalAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E199 RID: 57753
		// (get) Token: 0x06035F61 RID: 221025 RVA: 0x00757A90 File Offset: 0x00755C90
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E19A RID: 57754
		// (get) Token: 0x06035F62 RID: 221026 RVA: 0x00757ACC File Offset: 0x00755CCC
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035F63 RID: 221027 RVA: 0x00757B0B File Offset: 0x00755D0B
		public static Offset<IToggleEntityElementalAbility> CreateIToggleEntityElementalAbility(FlatBufferBuilder builder, int EntityId = 0, bool Enable = false)
		{
			builder.StartTable(2);
			IToggleEntityElementalAbility.AddEntityId(builder, EntityId);
			IToggleEntityElementalAbility.AddEnable(builder, Enable);
			return IToggleEntityElementalAbility.EndIToggleEntityElementalAbility(builder);
		}

		// Token: 0x06035F64 RID: 221028 RVA: 0x00757B28 File Offset: 0x00755D28
		public static void StartIToggleEntityElementalAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035F65 RID: 221029 RVA: 0x00757B31 File Offset: 0x00755D31
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035F66 RID: 221030 RVA: 0x00757B3C File Offset: 0x00755D3C
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x06035F67 RID: 221031 RVA: 0x00757B47 File Offset: 0x00755D47
		public static Offset<IToggleEntityElementalAbility> EndIToggleEntityElementalAbility(FlatBufferBuilder builder)
		{
			return new Offset<IToggleEntityElementalAbility>(builder.EndTable());
		}

		// Token: 0x06035F68 RID: 221032 RVA: 0x00757B54 File Offset: 0x00755D54
		public IToggleEntityElementalAbilityT UnPack()
		{
			IToggleEntityElementalAbilityT toggleEntityElementalAbilityT = new IToggleEntityElementalAbilityT();
			this.UnPackTo(toggleEntityElementalAbilityT);
			return toggleEntityElementalAbilityT;
		}

		// Token: 0x06035F69 RID: 221033 RVA: 0x00757B6F File Offset: 0x00755D6F
		public void UnPackTo(IToggleEntityElementalAbilityT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Enable = this.Enable;
		}

		// Token: 0x06035F6A RID: 221034 RVA: 0x00757B8C File Offset: 0x00755D8C
		public static Offset<IToggleEntityElementalAbility> Pack(FlatBufferBuilder builder, IToggleEntityElementalAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleEntityElementalAbility>);
			}
			return IToggleEntityElementalAbility.CreateIToggleEntityElementalAbility(builder, _o.EntityId, _o.Enable);
		}

		// Token: 0x0401226F RID: 74351
		private Table __p;
	}
}
