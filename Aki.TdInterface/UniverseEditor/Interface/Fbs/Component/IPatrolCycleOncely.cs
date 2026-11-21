using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF9 RID: 23801
	public struct IPatrolCycleOncely : IFlatbufferObject
	{
		// Token: 0x1700AEE9 RID: 44777
		// (get) Token: 0x06027878 RID: 161912 RVA: 0x00568A3E File Offset: 0x00566C3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027879 RID: 161913 RVA: 0x00568A4B File Offset: 0x00566C4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602787A RID: 161914 RVA: 0x00568A54 File Offset: 0x00566C54
		public static IPatrolCycleOncely GetRootAsIPatrolCycleOncely(ByteBuffer _bb)
		{
			return IPatrolCycleOncely.GetRootAsIPatrolCycleOncely(_bb, default(IPatrolCycleOncely));
		}

		// Token: 0x0602787B RID: 161915 RVA: 0x00568A70 File Offset: 0x00566C70
		public static IPatrolCycleOncely GetRootAsIPatrolCycleOncely(ByteBuffer _bb, IPatrolCycleOncely obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602787C RID: 161916 RVA: 0x00568A8D File Offset: 0x00566C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602787D RID: 161917 RVA: 0x00568A9C File Offset: 0x00566C9C
		public IPatrolCycleOncely __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEEA RID: 44778
		// (get) Token: 0x0602787E RID: 161918 RVA: 0x00568AAC File Offset: 0x00566CAC
		public EPatrolCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolCycleMode.Loop;
				}
				return (EPatrolCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602787F RID: 161919 RVA: 0x00568AE8 File Offset: 0x00566CE8
		public static Offset<IPatrolCycleOncely> CreateIPatrolCycleOncely(FlatBufferBuilder builder, EPatrolCycleMode Type = EPatrolCycleMode.Loop)
		{
			builder.StartTable(1);
			IPatrolCycleOncely.AddType(builder, Type);
			return IPatrolCycleOncely.EndIPatrolCycleOncely(builder);
		}

		// Token: 0x06027880 RID: 161920 RVA: 0x00568AFE File Offset: 0x00566CFE
		public static void StartIPatrolCycleOncely(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027881 RID: 161921 RVA: 0x00568B07 File Offset: 0x00566D07
		public static void AddType(FlatBufferBuilder builder, EPatrolCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027882 RID: 161922 RVA: 0x00568B12 File Offset: 0x00566D12
		public static Offset<IPatrolCycleOncely> EndIPatrolCycleOncely(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolCycleOncely>(builder.EndTable());
		}

		// Token: 0x06027883 RID: 161923 RVA: 0x00568B20 File Offset: 0x00566D20
		public IPatrolCycleOncelyT UnPack()
		{
			IPatrolCycleOncelyT patrolCycleOncelyT = new IPatrolCycleOncelyT();
			this.UnPackTo(patrolCycleOncelyT);
			return patrolCycleOncelyT;
		}

		// Token: 0x06027884 RID: 161924 RVA: 0x00568B3B File Offset: 0x00566D3B
		public void UnPackTo(IPatrolCycleOncelyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027885 RID: 161925 RVA: 0x00568B4C File Offset: 0x00566D4C
		public static Offset<IPatrolCycleOncely> Pack(FlatBufferBuilder builder, IPatrolCycleOncelyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolCycleOncely>);
			}
			return IPatrolCycleOncely.CreateIPatrolCycleOncely(builder, _o.Type);
		}

		// Token: 0x0400F837 RID: 63543
		private Table __p;
	}
}
