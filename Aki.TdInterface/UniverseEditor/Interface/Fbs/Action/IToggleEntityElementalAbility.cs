using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF0 RID: 31728
	public struct IToggleEntityElementalAbility : IFlatbufferObject
	{
		// Token: 0x1700EDAD RID: 60845
		// (get) Token: 0x0603930E RID: 234254 RVA: 0x007BA198 File Offset: 0x007B8398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603930F RID: 234255 RVA: 0x007BA1A5 File Offset: 0x007B83A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039310 RID: 234256 RVA: 0x007BA1AC File Offset: 0x007B83AC
		public static IToggleEntityElementalAbility GetRootAsIToggleEntityElementalAbility(ByteBuffer _bb)
		{
			return IToggleEntityElementalAbility.GetRootAsIToggleEntityElementalAbility(_bb, default(IToggleEntityElementalAbility));
		}

		// Token: 0x06039311 RID: 234257 RVA: 0x007BA1C8 File Offset: 0x007B83C8
		public static IToggleEntityElementalAbility GetRootAsIToggleEntityElementalAbility(ByteBuffer _bb, IToggleEntityElementalAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039312 RID: 234258 RVA: 0x007BA1E5 File Offset: 0x007B83E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039313 RID: 234259 RVA: 0x007BA1F4 File Offset: 0x007B83F4
		public IToggleEntityElementalAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDAE RID: 60846
		// (get) Token: 0x06039314 RID: 234260 RVA: 0x007BA204 File Offset: 0x007B8404
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

		// Token: 0x1700EDAF RID: 60847
		// (get) Token: 0x06039315 RID: 234261 RVA: 0x007BA240 File Offset: 0x007B8440
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06039316 RID: 234262 RVA: 0x007BA27F File Offset: 0x007B847F
		public static Offset<IToggleEntityElementalAbility> CreateIToggleEntityElementalAbility(FlatBufferBuilder builder, int EntityId = 0, bool Enable = false)
		{
			builder.StartTable(2);
			IToggleEntityElementalAbility.AddEntityId(builder, EntityId);
			IToggleEntityElementalAbility.AddEnable(builder, Enable);
			return IToggleEntityElementalAbility.EndIToggleEntityElementalAbility(builder);
		}

		// Token: 0x06039317 RID: 234263 RVA: 0x007BA29C File Offset: 0x007B849C
		public static void StartIToggleEntityElementalAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039318 RID: 234264 RVA: 0x007BA2A5 File Offset: 0x007B84A5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06039319 RID: 234265 RVA: 0x007BA2B0 File Offset: 0x007B84B0
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x0603931A RID: 234266 RVA: 0x007BA2BB File Offset: 0x007B84BB
		public static Offset<IToggleEntityElementalAbility> EndIToggleEntityElementalAbility(FlatBufferBuilder builder)
		{
			return new Offset<IToggleEntityElementalAbility>(builder.EndTable());
		}

		// Token: 0x0603931B RID: 234267 RVA: 0x007BA2C8 File Offset: 0x007B84C8
		public IToggleEntityElementalAbilityT UnPack()
		{
			IToggleEntityElementalAbilityT toggleEntityElementalAbilityT = new IToggleEntityElementalAbilityT();
			this.UnPackTo(toggleEntityElementalAbilityT);
			return toggleEntityElementalAbilityT;
		}

		// Token: 0x0603931C RID: 234268 RVA: 0x007BA2E3 File Offset: 0x007B84E3
		public void UnPackTo(IToggleEntityElementalAbilityT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Enable = this.Enable;
		}

		// Token: 0x0603931D RID: 234269 RVA: 0x007BA300 File Offset: 0x007B8500
		public static Offset<IToggleEntityElementalAbility> Pack(FlatBufferBuilder builder, IToggleEntityElementalAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleEntityElementalAbility>);
			}
			return IToggleEntityElementalAbility.CreateIToggleEntityElementalAbility(builder, _o.EntityId, _o.Enable);
		}

		// Token: 0x0401328B RID: 78475
		private Table __p;
	}
}
