using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCE RID: 27854
	public struct IEnableFollowShooterAbility : IFlatbufferObject
	{
		// Token: 0x1700CC4B RID: 52299
		// (get) Token: 0x06030022 RID: 196642 RVA: 0x00688761 File Offset: 0x00686961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030023 RID: 196643 RVA: 0x0068876E File Offset: 0x0068696E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030024 RID: 196644 RVA: 0x00688778 File Offset: 0x00686978
		public static IEnableFollowShooterAbility GetRootAsIEnableFollowShooterAbility(ByteBuffer _bb)
		{
			return IEnableFollowShooterAbility.GetRootAsIEnableFollowShooterAbility(_bb, default(IEnableFollowShooterAbility));
		}

		// Token: 0x06030025 RID: 196645 RVA: 0x00688794 File Offset: 0x00686994
		public static IEnableFollowShooterAbility GetRootAsIEnableFollowShooterAbility(ByteBuffer _bb, IEnableFollowShooterAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030026 RID: 196646 RVA: 0x006887B1 File Offset: 0x006869B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030027 RID: 196647 RVA: 0x006887C0 File Offset: 0x006869C0
		public IEnableFollowShooterAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC4C RID: 52300
		// (get) Token: 0x06030028 RID: 196648 RVA: 0x006887D0 File Offset: 0x006869D0
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC4D RID: 52301
		// (get) Token: 0x06030029 RID: 196649 RVA: 0x00688810 File Offset: 0x00686A10
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC4E RID: 52302
		// (get) Token: 0x0603002A RID: 196650 RVA: 0x0068884C File Offset: 0x00686A4C
		public IFollowShooterJellyFishAbility? AbilityType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFollowShooterJellyFishAbility?(default(IFollowShooterJellyFishAbility).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603002B RID: 196651 RVA: 0x006888A9 File Offset: 0x00686AA9
		public static Offset<IEnableFollowShooterAbility> CreateIEnableFollowShooterAbility(FlatBufferBuilder builder, bool Enable = false, int Id = 0, Offset<IFollowShooterJellyFishAbility> AbilityTypeOffset = default(Offset<IFollowShooterJellyFishAbility>))
		{
			builder.StartTable(3);
			IEnableFollowShooterAbility.AddAbilityType(builder, AbilityTypeOffset);
			IEnableFollowShooterAbility.AddId(builder, Id);
			IEnableFollowShooterAbility.AddEnable(builder, Enable);
			return IEnableFollowShooterAbility.EndIEnableFollowShooterAbility(builder);
		}

		// Token: 0x0603002C RID: 196652 RVA: 0x006888CD File Offset: 0x00686ACD
		public static void StartIEnableFollowShooterAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603002D RID: 196653 RVA: 0x006888D6 File Offset: 0x00686AD6
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0603002E RID: 196654 RVA: 0x006888E1 File Offset: 0x00686AE1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603002F RID: 196655 RVA: 0x006888EC File Offset: 0x00686AEC
		public static void AddAbilityType(FlatBufferBuilder builder, Offset<IFollowShooterJellyFishAbility> abilityTypeOffset)
		{
			builder.AddOffset(2, abilityTypeOffset.Value, 0);
		}

		// Token: 0x06030030 RID: 196656 RVA: 0x006888FC File Offset: 0x00686AFC
		public static Offset<IEnableFollowShooterAbility> EndIEnableFollowShooterAbility(FlatBufferBuilder builder)
		{
			return new Offset<IEnableFollowShooterAbility>(builder.EndTable());
		}

		// Token: 0x06030031 RID: 196657 RVA: 0x0068890C File Offset: 0x00686B0C
		public IEnableFollowShooterAbilityT UnPack()
		{
			IEnableFollowShooterAbilityT enableFollowShooterAbilityT = new IEnableFollowShooterAbilityT();
			this.UnPackTo(enableFollowShooterAbilityT);
			return enableFollowShooterAbilityT;
		}

		// Token: 0x06030032 RID: 196658 RVA: 0x00688928 File Offset: 0x00686B28
		public void UnPackTo(IEnableFollowShooterAbilityT _o)
		{
			_o.Enable = this.Enable;
			_o.Id = this.Id;
			_o.AbilityType = ((this.AbilityType != null) ? this.AbilityType.Value.UnPack() : null);
		}

		// Token: 0x06030033 RID: 196659 RVA: 0x0068897C File Offset: 0x00686B7C
		public static Offset<IEnableFollowShooterAbility> Pack(FlatBufferBuilder builder, IEnableFollowShooterAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableFollowShooterAbility>);
			}
			Offset<IFollowShooterJellyFishAbility> abilityTypeOffset = (_o.AbilityType == null) ? default(Offset<IFollowShooterJellyFishAbility>) : IFollowShooterJellyFishAbility.Pack(builder, _o.AbilityType);
			return IEnableFollowShooterAbility.CreateIEnableFollowShooterAbility(builder, _o.Enable, _o.Id, abilityTypeOffset);
		}

		// Token: 0x04011B18 RID: 72472
		private Table __p;
	}
}
