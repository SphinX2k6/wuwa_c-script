using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA8 RID: 20136
	public struct ICheckEncircleLevelComplete : IFlatbufferObject
	{
		// Token: 0x17008FA7 RID: 36775
		// (get) Token: 0x0601F365 RID: 127845 RVA: 0x00459FB4 File Offset: 0x004581B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F366 RID: 127846 RVA: 0x00459FC1 File Offset: 0x004581C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F367 RID: 127847 RVA: 0x00459FC8 File Offset: 0x004581C8
		public static ICheckEncircleLevelComplete GetRootAsICheckEncircleLevelComplete(ByteBuffer _bb)
		{
			return ICheckEncircleLevelComplete.GetRootAsICheckEncircleLevelComplete(_bb, default(ICheckEncircleLevelComplete));
		}

		// Token: 0x0601F368 RID: 127848 RVA: 0x00459FE4 File Offset: 0x004581E4
		public static ICheckEncircleLevelComplete GetRootAsICheckEncircleLevelComplete(ByteBuffer _bb, ICheckEncircleLevelComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F369 RID: 127849 RVA: 0x0045A001 File Offset: 0x00458201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F36A RID: 127850 RVA: 0x0045A010 File Offset: 0x00458210
		public ICheckEncircleLevelComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FA8 RID: 36776
		// (get) Token: 0x0601F36B RID: 127851 RVA: 0x0045A020 File Offset: 0x00458220
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FA9 RID: 36777
		// (get) Token: 0x0601F36C RID: 127852 RVA: 0x0045A05C File Offset: 0x0045825C
		public int EncircleLevelId
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

		// Token: 0x17008FAA RID: 36778
		// (get) Token: 0x0601F36D RID: 127853 RVA: 0x0045A098 File Offset: 0x00458298
		public bool IsCompleted
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F36E RID: 127854 RVA: 0x0045A0D7 File Offset: 0x004582D7
		public static Offset<ICheckEncircleLevelComplete> CreateICheckEncircleLevelComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int EncircleLevelId = 0, bool IsCompleted = false)
		{
			builder.StartTable(3);
			ICheckEncircleLevelComplete.AddEncircleLevelId(builder, EncircleLevelId);
			ICheckEncircleLevelComplete.AddIsCompleted(builder, IsCompleted);
			ICheckEncircleLevelComplete.AddType(builder, Type);
			return ICheckEncircleLevelComplete.EndICheckEncircleLevelComplete(builder);
		}

		// Token: 0x0601F36F RID: 127855 RVA: 0x0045A0FB File Offset: 0x004582FB
		public static void StartICheckEncircleLevelComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F370 RID: 127856 RVA: 0x0045A104 File Offset: 0x00458304
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F371 RID: 127857 RVA: 0x0045A10F File Offset: 0x0045830F
		public static void AddEncircleLevelId(FlatBufferBuilder builder, int encircleLevelId)
		{
			builder.AddInt(1, encircleLevelId, 0);
		}

		// Token: 0x0601F372 RID: 127858 RVA: 0x0045A11A File Offset: 0x0045831A
		public static void AddIsCompleted(FlatBufferBuilder builder, bool isCompleted)
		{
			builder.AddBool(2, isCompleted, false);
		}

		// Token: 0x0601F373 RID: 127859 RVA: 0x0045A125 File Offset: 0x00458325
		public static Offset<ICheckEncircleLevelComplete> EndICheckEncircleLevelComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEncircleLevelComplete>(builder.EndTable());
		}

		// Token: 0x0601F374 RID: 127860 RVA: 0x0045A134 File Offset: 0x00458334
		public ICheckEncircleLevelCompleteT UnPack()
		{
			ICheckEncircleLevelCompleteT checkEncircleLevelCompleteT = new ICheckEncircleLevelCompleteT();
			this.UnPackTo(checkEncircleLevelCompleteT);
			return checkEncircleLevelCompleteT;
		}

		// Token: 0x0601F375 RID: 127861 RVA: 0x0045A14F File Offset: 0x0045834F
		public void UnPackTo(ICheckEncircleLevelCompleteT _o)
		{
			_o.Type = this.Type;
			_o.EncircleLevelId = this.EncircleLevelId;
			_o.IsCompleted = this.IsCompleted;
		}

		// Token: 0x0601F376 RID: 127862 RVA: 0x0045A178 File Offset: 0x00458378
		public static Offset<ICheckEncircleLevelComplete> Pack(FlatBufferBuilder builder, ICheckEncircleLevelCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEncircleLevelComplete>);
			}
			return ICheckEncircleLevelComplete.CreateICheckEncircleLevelComplete(builder, _o.Type, _o.EncircleLevelId, _o.IsCompleted);
		}

		// Token: 0x0400DCEE RID: 56558
		private Table __p;
	}
}
