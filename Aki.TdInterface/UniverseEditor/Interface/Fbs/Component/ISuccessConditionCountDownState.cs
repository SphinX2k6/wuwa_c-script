using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E3 RID: 23011
	public struct ISuccessConditionCountDownState : IFlatbufferObject
	{
		// Token: 0x1700ACE1 RID: 44257
		// (get) Token: 0x0602709E RID: 159902 RVA: 0x0055F0DE File Offset: 0x0055D2DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602709F RID: 159903 RVA: 0x0055F0EB File Offset: 0x0055D2EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270A0 RID: 159904 RVA: 0x0055F0F4 File Offset: 0x0055D2F4
		public static ISuccessConditionCountDownState GetRootAsISuccessConditionCountDownState(ByteBuffer _bb)
		{
			return ISuccessConditionCountDownState.GetRootAsISuccessConditionCountDownState(_bb, default(ISuccessConditionCountDownState));
		}

		// Token: 0x060270A1 RID: 159905 RVA: 0x0055F110 File Offset: 0x0055D310
		public static ISuccessConditionCountDownState GetRootAsISuccessConditionCountDownState(ByteBuffer _bb, ISuccessConditionCountDownState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270A2 RID: 159906 RVA: 0x0055F12D File Offset: 0x0055D32D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270A3 RID: 159907 RVA: 0x0055F13C File Offset: 0x0055D33C
		public ISuccessConditionCountDownState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACE2 RID: 44258
		// (get) Token: 0x060270A4 RID: 159908 RVA: 0x0055F14C File Offset: 0x0055D34C
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

		// Token: 0x060270A5 RID: 159909 RVA: 0x0055F188 File Offset: 0x0055D388
		public static Offset<ISuccessConditionCountDownState> CreateISuccessConditionCountDownState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState)
		{
			builder.StartTable(1);
			ISuccessConditionCountDownState.AddType(builder, Type);
			return ISuccessConditionCountDownState.EndISuccessConditionCountDownState(builder);
		}

		// Token: 0x060270A6 RID: 159910 RVA: 0x0055F19E File Offset: 0x0055D39E
		public static void StartISuccessConditionCountDownState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060270A7 RID: 159911 RVA: 0x0055F1A7 File Offset: 0x0055D3A7
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060270A8 RID: 159912 RVA: 0x0055F1B2 File Offset: 0x0055D3B2
		public static Offset<ISuccessConditionCountDownState> EndISuccessConditionCountDownState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionCountDownState>(builder.EndTable());
		}

		// Token: 0x060270A9 RID: 159913 RVA: 0x0055F1C0 File Offset: 0x0055D3C0
		public ISuccessConditionCountDownStateT UnPack()
		{
			ISuccessConditionCountDownStateT successConditionCountDownStateT = new ISuccessConditionCountDownStateT();
			this.UnPackTo(successConditionCountDownStateT);
			return successConditionCountDownStateT;
		}

		// Token: 0x060270AA RID: 159914 RVA: 0x0055F1DB File Offset: 0x0055D3DB
		public void UnPackTo(ISuccessConditionCountDownStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060270AB RID: 159915 RVA: 0x0055F1EC File Offset: 0x0055D3EC
		public static Offset<ISuccessConditionCountDownState> Pack(FlatBufferBuilder builder, ISuccessConditionCountDownStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionCountDownState>);
			}
			return ISuccessConditionCountDownState.CreateISuccessConditionCountDownState(builder, _o.Type);
		}

		// Token: 0x0400F01C RID: 61468
		private Table __p;
	}
}
