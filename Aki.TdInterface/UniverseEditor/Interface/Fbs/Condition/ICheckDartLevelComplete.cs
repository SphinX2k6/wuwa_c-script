using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E7B RID: 20091
	public struct ICheckDartLevelComplete : IFlatbufferObject
	{
		// Token: 0x17008F44 RID: 36676
		// (get) Token: 0x0601F1DB RID: 127451 RVA: 0x0045759E File Offset: 0x0045579E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1DC RID: 127452 RVA: 0x004575AB File Offset: 0x004557AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1DD RID: 127453 RVA: 0x004575B4 File Offset: 0x004557B4
		public static ICheckDartLevelComplete GetRootAsICheckDartLevelComplete(ByteBuffer _bb)
		{
			return ICheckDartLevelComplete.GetRootAsICheckDartLevelComplete(_bb, default(ICheckDartLevelComplete));
		}

		// Token: 0x0601F1DE RID: 127454 RVA: 0x004575D0 File Offset: 0x004557D0
		public static ICheckDartLevelComplete GetRootAsICheckDartLevelComplete(ByteBuffer _bb, ICheckDartLevelComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1DF RID: 127455 RVA: 0x004575ED File Offset: 0x004557ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1E0 RID: 127456 RVA: 0x004575FC File Offset: 0x004557FC
		public ICheckDartLevelComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F45 RID: 36677
		// (get) Token: 0x0601F1E1 RID: 127457 RVA: 0x0045760C File Offset: 0x0045580C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F46 RID: 36678
		// (get) Token: 0x0601F1E2 RID: 127458 RVA: 0x00457648 File Offset: 0x00455848
		public bool IsCompleted
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008F47 RID: 36679
		// (get) Token: 0x0601F1E3 RID: 127459 RVA: 0x00457688 File Offset: 0x00455888
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F1E4 RID: 127460 RVA: 0x004576C4 File Offset: 0x004558C4
		public static Offset<ICheckDartLevelComplete> CreateICheckDartLevelComplete(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsCompleted = false, int LevelId = 0)
		{
			builder.StartTable(3);
			ICheckDartLevelComplete.AddLevelId(builder, LevelId);
			ICheckDartLevelComplete.AddIsCompleted(builder, IsCompleted);
			ICheckDartLevelComplete.AddType(builder, Type);
			return ICheckDartLevelComplete.EndICheckDartLevelComplete(builder);
		}

		// Token: 0x0601F1E5 RID: 127461 RVA: 0x004576E8 File Offset: 0x004558E8
		public static void StartICheckDartLevelComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F1E6 RID: 127462 RVA: 0x004576F1 File Offset: 0x004558F1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1E7 RID: 127463 RVA: 0x004576FC File Offset: 0x004558FC
		public static void AddIsCompleted(FlatBufferBuilder builder, bool isCompleted)
		{
			builder.AddBool(1, isCompleted, false);
		}

		// Token: 0x0601F1E8 RID: 127464 RVA: 0x00457707 File Offset: 0x00455907
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x0601F1E9 RID: 127465 RVA: 0x00457712 File Offset: 0x00455912
		public static Offset<ICheckDartLevelComplete> EndICheckDartLevelComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDartLevelComplete>(builder.EndTable());
		}

		// Token: 0x0601F1EA RID: 127466 RVA: 0x00457720 File Offset: 0x00455920
		public ICheckDartLevelCompleteT UnPack()
		{
			ICheckDartLevelCompleteT checkDartLevelCompleteT = new ICheckDartLevelCompleteT();
			this.UnPackTo(checkDartLevelCompleteT);
			return checkDartLevelCompleteT;
		}

		// Token: 0x0601F1EB RID: 127467 RVA: 0x0045773B File Offset: 0x0045593B
		public void UnPackTo(ICheckDartLevelCompleteT _o)
		{
			_o.Type = this.Type;
			_o.IsCompleted = this.IsCompleted;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x0601F1EC RID: 127468 RVA: 0x00457764 File Offset: 0x00455964
		public static Offset<ICheckDartLevelComplete> Pack(FlatBufferBuilder builder, ICheckDartLevelCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDartLevelComplete>);
			}
			return ICheckDartLevelComplete.CreateICheckDartLevelComplete(builder, _o.Type, _o.IsCompleted, _o.LevelId);
		}

		// Token: 0x0400DCB5 RID: 56501
		private Table __p;
	}
}
