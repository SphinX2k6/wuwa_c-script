using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF0 RID: 24560
	public struct ISuccessConditionCountDownState : IFlatbufferObject
	{
		// Token: 0x1700B619 RID: 46617
		// (get) Token: 0x06029616 RID: 169494 RVA: 0x005A60A2 File Offset: 0x005A42A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029617 RID: 169495 RVA: 0x005A60AF File Offset: 0x005A42AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029618 RID: 169496 RVA: 0x005A60B8 File Offset: 0x005A42B8
		public static ISuccessConditionCountDownState GetRootAsISuccessConditionCountDownState(ByteBuffer _bb)
		{
			return ISuccessConditionCountDownState.GetRootAsISuccessConditionCountDownState(_bb, default(ISuccessConditionCountDownState));
		}

		// Token: 0x06029619 RID: 169497 RVA: 0x005A60D4 File Offset: 0x005A42D4
		public static ISuccessConditionCountDownState GetRootAsISuccessConditionCountDownState(ByteBuffer _bb, ISuccessConditionCountDownState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602961A RID: 169498 RVA: 0x005A60F1 File Offset: 0x005A42F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602961B RID: 169499 RVA: 0x005A6100 File Offset: 0x005A4300
		public ISuccessConditionCountDownState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B61A RID: 46618
		// (get) Token: 0x0602961C RID: 169500 RVA: 0x005A6110 File Offset: 0x005A4310
		public ETargetGearGroupSuccessCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return (ETargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602961D RID: 169501 RVA: 0x005A614C File Offset: 0x005A434C
		public static Offset<ISuccessConditionCountDownState> CreateISuccessConditionCountDownState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState)
		{
			builder.StartTable(1);
			ISuccessConditionCountDownState.AddType(builder, Type);
			return ISuccessConditionCountDownState.EndISuccessConditionCountDownState(builder);
		}

		// Token: 0x0602961E RID: 169502 RVA: 0x005A6162 File Offset: 0x005A4362
		public static void StartISuccessConditionCountDownState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602961F RID: 169503 RVA: 0x005A616B File Offset: 0x005A436B
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029620 RID: 169504 RVA: 0x005A6176 File Offset: 0x005A4376
		public static Offset<ISuccessConditionCountDownState> EndISuccessConditionCountDownState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionCountDownState>(builder.EndTable());
		}

		// Token: 0x06029621 RID: 169505 RVA: 0x005A6184 File Offset: 0x005A4384
		public ISuccessConditionCountDownStateT UnPack()
		{
			ISuccessConditionCountDownStateT successConditionCountDownStateT = new ISuccessConditionCountDownStateT();
			this.UnPackTo(successConditionCountDownStateT);
			return successConditionCountDownStateT;
		}

		// Token: 0x06029622 RID: 169506 RVA: 0x005A619F File Offset: 0x005A439F
		public void UnPackTo(ISuccessConditionCountDownStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029623 RID: 169507 RVA: 0x005A61B0 File Offset: 0x005A43B0
		public static Offset<ISuccessConditionCountDownState> Pack(FlatBufferBuilder builder, ISuccessConditionCountDownStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionCountDownState>);
			}
			return ISuccessConditionCountDownState.CreateISuccessConditionCountDownState(builder, _o.Type);
		}

		// Token: 0x0400FD13 RID: 64787
		private Table __p;
	}
}
