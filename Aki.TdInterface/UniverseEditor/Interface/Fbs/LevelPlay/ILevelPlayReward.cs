using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200497D RID: 18813
	public struct ILevelPlayReward : IFlatbufferObject
	{
		// Token: 0x170083A0 RID: 33696
		// (get) Token: 0x0601C10A RID: 114954 RVA: 0x003F7AAE File Offset: 0x003F5CAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C10B RID: 114955 RVA: 0x003F7ABB File Offset: 0x003F5CBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C10C RID: 114956 RVA: 0x003F7AC4 File Offset: 0x003F5CC4
		public static ILevelPlayReward GetRootAsILevelPlayReward(ByteBuffer _bb)
		{
			return ILevelPlayReward.GetRootAsILevelPlayReward(_bb, default(ILevelPlayReward));
		}

		// Token: 0x0601C10D RID: 114957 RVA: 0x003F7AE0 File Offset: 0x003F5CE0
		public static ILevelPlayReward GetRootAsILevelPlayReward(ByteBuffer _bb, ILevelPlayReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C10E RID: 114958 RVA: 0x003F7AFD File Offset: 0x003F5CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C10F RID: 114959 RVA: 0x003F7B0C File Offset: 0x003F5D0C
		public ILevelPlayReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083A1 RID: 33697
		// (get) Token: 0x0601C110 RID: 114960 RVA: 0x003F7B1C File Offset: 0x003F5D1C
		public ELevelPlayRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRewardType.None;
				}
				return (ELevelPlayRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C111 RID: 114961 RVA: 0x003F7B58 File Offset: 0x003F5D58
		public static Offset<ILevelPlayReward> CreateILevelPlayReward(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None)
		{
			builder.StartTable(1);
			ILevelPlayReward.AddType(builder, Type);
			return ILevelPlayReward.EndILevelPlayReward(builder);
		}

		// Token: 0x0601C112 RID: 114962 RVA: 0x003F7B6E File Offset: 0x003F5D6E
		public static void StartILevelPlayReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C113 RID: 114963 RVA: 0x003F7B77 File Offset: 0x003F5D77
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C114 RID: 114964 RVA: 0x003F7B82 File Offset: 0x003F5D82
		public static Offset<ILevelPlayReward> EndILevelPlayReward(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayReward>(builder.EndTable());
		}

		// Token: 0x0601C115 RID: 114965 RVA: 0x003F7B90 File Offset: 0x003F5D90
		public ILevelPlayRewardT UnPack()
		{
			ILevelPlayRewardT levelPlayRewardT = new ILevelPlayRewardT();
			this.UnPackTo(levelPlayRewardT);
			return levelPlayRewardT;
		}

		// Token: 0x0601C116 RID: 114966 RVA: 0x003F7BAB File Offset: 0x003F5DAB
		public void UnPackTo(ILevelPlayRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C117 RID: 114967 RVA: 0x003F7BBC File Offset: 0x003F5DBC
		public static Offset<ILevelPlayReward> Pack(FlatBufferBuilder builder, ILevelPlayRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayReward>);
			}
			return ILevelPlayReward.CreateILevelPlayReward(builder, _o.Type);
		}

		// Token: 0x0400CFB7 RID: 53175
		private Table __p;
	}
}
