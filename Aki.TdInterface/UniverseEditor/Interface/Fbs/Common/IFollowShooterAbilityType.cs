using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DAC RID: 23980
	public struct IFollowShooterAbilityType : IFlatbufferObject
	{
		// Token: 0x1700B397 RID: 45975
		// (get) Token: 0x060290B6 RID: 168118 RVA: 0x005A2D04 File Offset: 0x005A0F04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060290B7 RID: 168119 RVA: 0x005A2D11 File Offset: 0x005A0F11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060290B8 RID: 168120 RVA: 0x005A2D18 File Offset: 0x005A0F18
		public static IFollowShooterAbilityType GetRootAsIFollowShooterAbilityType(ByteBuffer _bb)
		{
			return IFollowShooterAbilityType.GetRootAsIFollowShooterAbilityType(_bb, default(IFollowShooterAbilityType));
		}

		// Token: 0x060290B9 RID: 168121 RVA: 0x005A2D34 File Offset: 0x005A0F34
		public static IFollowShooterAbilityType GetRootAsIFollowShooterAbilityType(ByteBuffer _bb, IFollowShooterAbilityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060290BA RID: 168122 RVA: 0x005A2D51 File Offset: 0x005A0F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060290BB RID: 168123 RVA: 0x005A2D60 File Offset: 0x005A0F60
		public IFollowShooterAbilityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B398 RID: 45976
		// (get) Token: 0x060290BC RID: 168124 RVA: 0x005A2D70 File Offset: 0x005A0F70
		public EFollowShooterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterType.JellyFish;
				}
				return (EFollowShooterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060290BD RID: 168125 RVA: 0x005A2DAC File Offset: 0x005A0FAC
		public static Offset<IFollowShooterAbilityType> CreateIFollowShooterAbilityType(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish)
		{
			builder.StartTable(1);
			IFollowShooterAbilityType.AddType(builder, Type);
			return IFollowShooterAbilityType.EndIFollowShooterAbilityType(builder);
		}

		// Token: 0x060290BE RID: 168126 RVA: 0x005A2DC2 File Offset: 0x005A0FC2
		public static void StartIFollowShooterAbilityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060290BF RID: 168127 RVA: 0x005A2DCB File Offset: 0x005A0FCB
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060290C0 RID: 168128 RVA: 0x005A2DD6 File Offset: 0x005A0FD6
		public static Offset<IFollowShooterAbilityType> EndIFollowShooterAbilityType(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterAbilityType>(builder.EndTable());
		}

		// Token: 0x060290C1 RID: 168129 RVA: 0x005A2DE4 File Offset: 0x005A0FE4
		public IFollowShooterAbilityTypeT UnPack()
		{
			IFollowShooterAbilityTypeT followShooterAbilityTypeT = new IFollowShooterAbilityTypeT();
			this.UnPackTo(followShooterAbilityTypeT);
			return followShooterAbilityTypeT;
		}

		// Token: 0x060290C2 RID: 168130 RVA: 0x005A2DFF File Offset: 0x005A0FFF
		public void UnPackTo(IFollowShooterAbilityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060290C3 RID: 168131 RVA: 0x005A2E10 File Offset: 0x005A1010
		public static Offset<IFollowShooterAbilityType> Pack(FlatBufferBuilder builder, IFollowShooterAbilityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterAbilityType>);
			}
			return IFollowShooterAbilityType.CreateIFollowShooterAbilityType(builder, _o.Type);
		}

		// Token: 0x0400F787 RID: 63367
		private Table __p;
	}
}
