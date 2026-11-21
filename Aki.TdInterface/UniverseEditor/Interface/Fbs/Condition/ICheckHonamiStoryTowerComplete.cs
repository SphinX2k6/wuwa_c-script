using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F2C RID: 20268
	public struct ICheckHonamiStoryTowerComplete : IFlatbufferObject
	{
		// Token: 0x170090C2 RID: 37058
		// (get) Token: 0x0601F801 RID: 129025 RVA: 0x004624C2 File Offset: 0x004606C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F802 RID: 129026 RVA: 0x004624CF File Offset: 0x004606CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F803 RID: 129027 RVA: 0x004624D8 File Offset: 0x004606D8
		public static ICheckHonamiStoryTowerComplete GetRootAsICheckHonamiStoryTowerComplete(ByteBuffer _bb)
		{
			return ICheckHonamiStoryTowerComplete.GetRootAsICheckHonamiStoryTowerComplete(_bb, default(ICheckHonamiStoryTowerComplete));
		}

		// Token: 0x0601F804 RID: 129028 RVA: 0x004624F4 File Offset: 0x004606F4
		public static ICheckHonamiStoryTowerComplete GetRootAsICheckHonamiStoryTowerComplete(ByteBuffer _bb, ICheckHonamiStoryTowerComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F805 RID: 129029 RVA: 0x00462511 File Offset: 0x00460711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F806 RID: 129030 RVA: 0x00462520 File Offset: 0x00460720
		public ICheckHonamiStoryTowerComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090C3 RID: 37059
		// (get) Token: 0x0601F807 RID: 129031 RVA: 0x00462530 File Offset: 0x00460730
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

		// Token: 0x170090C4 RID: 37060
		// (get) Token: 0x0601F808 RID: 129032 RVA: 0x0046256C File Offset: 0x0046076C
		public int ActivityId
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

		// Token: 0x170090C5 RID: 37061
		// (get) Token: 0x0601F809 RID: 129033 RVA: 0x004625A8 File Offset: 0x004607A8
		public int Floor
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

		// Token: 0x0601F80A RID: 129034 RVA: 0x004625E4 File Offset: 0x004607E4
		public static Offset<ICheckHonamiStoryTowerComplete> CreateICheckHonamiStoryTowerComplete(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ActivityId = 0, int Floor = 0)
		{
			builder.StartTable(3);
			ICheckHonamiStoryTowerComplete.AddFloor(builder, Floor);
			ICheckHonamiStoryTowerComplete.AddActivityId(builder, ActivityId);
			ICheckHonamiStoryTowerComplete.AddType(builder, Type);
			return ICheckHonamiStoryTowerComplete.EndICheckHonamiStoryTowerComplete(builder);
		}

		// Token: 0x0601F80B RID: 129035 RVA: 0x00462608 File Offset: 0x00460808
		public static void StartICheckHonamiStoryTowerComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F80C RID: 129036 RVA: 0x00462611 File Offset: 0x00460811
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F80D RID: 129037 RVA: 0x0046261C File Offset: 0x0046081C
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0601F80E RID: 129038 RVA: 0x00462627 File Offset: 0x00460827
		public static void AddFloor(FlatBufferBuilder builder, int floor)
		{
			builder.AddInt(2, floor, 0);
		}

		// Token: 0x0601F80F RID: 129039 RVA: 0x00462632 File Offset: 0x00460832
		public static Offset<ICheckHonamiStoryTowerComplete> EndICheckHonamiStoryTowerComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryTowerComplete>(builder.EndTable());
		}

		// Token: 0x0601F810 RID: 129040 RVA: 0x00462640 File Offset: 0x00460840
		public ICheckHonamiStoryTowerCompleteT UnPack()
		{
			ICheckHonamiStoryTowerCompleteT checkHonamiStoryTowerCompleteT = new ICheckHonamiStoryTowerCompleteT();
			this.UnPackTo(checkHonamiStoryTowerCompleteT);
			return checkHonamiStoryTowerCompleteT;
		}

		// Token: 0x0601F811 RID: 129041 RVA: 0x0046265B File Offset: 0x0046085B
		public void UnPackTo(ICheckHonamiStoryTowerCompleteT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.Floor = this.Floor;
		}

		// Token: 0x0601F812 RID: 129042 RVA: 0x00462684 File Offset: 0x00460884
		public static Offset<ICheckHonamiStoryTowerComplete> Pack(FlatBufferBuilder builder, ICheckHonamiStoryTowerCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryTowerComplete>);
			}
			return ICheckHonamiStoryTowerComplete.CreateICheckHonamiStoryTowerComplete(builder, _o.Type, _o.ActivityId, _o.Floor);
		}

		// Token: 0x0400DDA2 RID: 56738
		private Table __p;
	}
}
