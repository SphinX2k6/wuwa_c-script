using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200665D RID: 26205
	public struct IEnableFollowShooterAbility : IFlatbufferObject
	{
		// Token: 0x1700C2AD RID: 49837
		// (get) Token: 0x0602D851 RID: 186449 RVA: 0x0063BBF9 File Offset: 0x00639DF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D852 RID: 186450 RVA: 0x0063BC06 File Offset: 0x00639E06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D853 RID: 186451 RVA: 0x0063BC10 File Offset: 0x00639E10
		public static IEnableFollowShooterAbility GetRootAsIEnableFollowShooterAbility(ByteBuffer _bb)
		{
			return IEnableFollowShooterAbility.GetRootAsIEnableFollowShooterAbility(_bb, default(IEnableFollowShooterAbility));
		}

		// Token: 0x0602D854 RID: 186452 RVA: 0x0063BC2C File Offset: 0x00639E2C
		public static IEnableFollowShooterAbility GetRootAsIEnableFollowShooterAbility(ByteBuffer _bb, IEnableFollowShooterAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D855 RID: 186453 RVA: 0x0063BC49 File Offset: 0x00639E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D856 RID: 186454 RVA: 0x0063BC58 File Offset: 0x00639E58
		public IEnableFollowShooterAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2AE RID: 49838
		// (get) Token: 0x0602D857 RID: 186455 RVA: 0x0063BC68 File Offset: 0x00639E68
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2AF RID: 49839
		// (get) Token: 0x0602D858 RID: 186456 RVA: 0x0063BCA8 File Offset: 0x00639EA8
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

		// Token: 0x1700C2B0 RID: 49840
		// (get) Token: 0x0602D859 RID: 186457 RVA: 0x0063BCE4 File Offset: 0x00639EE4
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

		// Token: 0x0602D85A RID: 186458 RVA: 0x0063BD41 File Offset: 0x00639F41
		public static Offset<IEnableFollowShooterAbility> CreateIEnableFollowShooterAbility(FlatBufferBuilder builder, bool Enable = false, int Id = 0, Offset<IFollowShooterJellyFishAbility> AbilityTypeOffset = default(Offset<IFollowShooterJellyFishAbility>))
		{
			builder.StartTable(3);
			IEnableFollowShooterAbility.AddAbilityType(builder, AbilityTypeOffset);
			IEnableFollowShooterAbility.AddId(builder, Id);
			IEnableFollowShooterAbility.AddEnable(builder, Enable);
			return IEnableFollowShooterAbility.EndIEnableFollowShooterAbility(builder);
		}

		// Token: 0x0602D85B RID: 186459 RVA: 0x0063BD65 File Offset: 0x00639F65
		public static void StartIEnableFollowShooterAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D85C RID: 186460 RVA: 0x0063BD6E File Offset: 0x00639F6E
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0602D85D RID: 186461 RVA: 0x0063BD79 File Offset: 0x00639F79
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602D85E RID: 186462 RVA: 0x0063BD84 File Offset: 0x00639F84
		public static void AddAbilityType(FlatBufferBuilder builder, Offset<IFollowShooterJellyFishAbility> abilityTypeOffset)
		{
			builder.AddOffset(2, abilityTypeOffset.Value, 0);
		}

		// Token: 0x0602D85F RID: 186463 RVA: 0x0063BD94 File Offset: 0x00639F94
		public static Offset<IEnableFollowShooterAbility> EndIEnableFollowShooterAbility(FlatBufferBuilder builder)
		{
			return new Offset<IEnableFollowShooterAbility>(builder.EndTable());
		}

		// Token: 0x0602D860 RID: 186464 RVA: 0x0063BDA4 File Offset: 0x00639FA4
		public IEnableFollowShooterAbilityT UnPack()
		{
			IEnableFollowShooterAbilityT enableFollowShooterAbilityT = new IEnableFollowShooterAbilityT();
			this.UnPackTo(enableFollowShooterAbilityT);
			return enableFollowShooterAbilityT;
		}

		// Token: 0x0602D861 RID: 186465 RVA: 0x0063BDC0 File Offset: 0x00639FC0
		public void UnPackTo(IEnableFollowShooterAbilityT _o)
		{
			_o.Enable = this.Enable;
			_o.Id = this.Id;
			_o.AbilityType = ((this.AbilityType != null) ? this.AbilityType.Value.UnPack() : null);
		}

		// Token: 0x0602D862 RID: 186466 RVA: 0x0063BE14 File Offset: 0x0063A014
		public static Offset<IEnableFollowShooterAbility> Pack(FlatBufferBuilder builder, IEnableFollowShooterAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableFollowShooterAbility>);
			}
			Offset<IFollowShooterJellyFishAbility> abilityTypeOffset = (_o.AbilityType == null) ? default(Offset<IFollowShooterJellyFishAbility>) : IFollowShooterJellyFishAbility.Pack(builder, _o.AbilityType);
			return IEnableFollowShooterAbility.CreateIEnableFollowShooterAbility(builder, _o.Enable, _o.Id, abilityTypeOffset);
		}

		// Token: 0x04010CFD RID: 68861
		private Table __p;
	}
}
