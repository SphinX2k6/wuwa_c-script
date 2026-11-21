using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200606E RID: 24686
	public struct IThrowDestroyCondition : IFlatbufferObject
	{
		// Token: 0x1700B74F RID: 46927
		// (get) Token: 0x06029B4B RID: 170827 RVA: 0x005B1C31 File Offset: 0x005AFE31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B4C RID: 170828 RVA: 0x005B1C3E File Offset: 0x005AFE3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B4D RID: 170829 RVA: 0x005B1C48 File Offset: 0x005AFE48
		public static IThrowDestroyCondition GetRootAsIThrowDestroyCondition(ByteBuffer _bb)
		{
			return IThrowDestroyCondition.GetRootAsIThrowDestroyCondition(_bb, default(IThrowDestroyCondition));
		}

		// Token: 0x06029B4E RID: 170830 RVA: 0x005B1C64 File Offset: 0x005AFE64
		public static IThrowDestroyCondition GetRootAsIThrowDestroyCondition(ByteBuffer _bb, IThrowDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B4F RID: 170831 RVA: 0x005B1C81 File Offset: 0x005AFE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B50 RID: 170832 RVA: 0x005B1C90 File Offset: 0x005AFE90
		public IThrowDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B750 RID: 46928
		// (get) Token: 0x06029B51 RID: 170833 RVA: 0x005B1CA0 File Offset: 0x005AFEA0
		public ETeleControlDestroyCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return (ETeleControlDestroyCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B751 RID: 46929
		// (get) Token: 0x06029B52 RID: 170834 RVA: 0x005B1CDC File Offset: 0x005AFEDC
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029B53 RID: 170835 RVA: 0x005B1D1C File Offset: 0x005AFF1C
		public static Offset<IThrowDestroyCondition> CreateIThrowDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo, float DelayTime = 0f)
		{
			builder.StartTable(2);
			IThrowDestroyCondition.AddDelayTime(builder, DelayTime);
			IThrowDestroyCondition.AddType(builder, Type);
			return IThrowDestroyCondition.EndIThrowDestroyCondition(builder);
		}

		// Token: 0x06029B54 RID: 170836 RVA: 0x005B1D39 File Offset: 0x005AFF39
		public static void StartIThrowDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029B55 RID: 170837 RVA: 0x005B1D42 File Offset: 0x005AFF42
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029B56 RID: 170838 RVA: 0x005B1D4D File Offset: 0x005AFF4D
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x06029B57 RID: 170839 RVA: 0x005B1D60 File Offset: 0x005AFF60
		public static Offset<IThrowDestroyCondition> EndIThrowDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<IThrowDestroyCondition>(builder.EndTable());
		}

		// Token: 0x06029B58 RID: 170840 RVA: 0x005B1D70 File Offset: 0x005AFF70
		public IThrowDestroyConditionT UnPack()
		{
			IThrowDestroyConditionT throwDestroyConditionT = new IThrowDestroyConditionT();
			this.UnPackTo(throwDestroyConditionT);
			return throwDestroyConditionT;
		}

		// Token: 0x06029B59 RID: 170841 RVA: 0x005B1D8B File Offset: 0x005AFF8B
		public void UnPackTo(IThrowDestroyConditionT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
		}

		// Token: 0x06029B5A RID: 170842 RVA: 0x005B1DA8 File Offset: 0x005AFFA8
		public static Offset<IThrowDestroyCondition> Pack(FlatBufferBuilder builder, IThrowDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowDestroyCondition>);
			}
			return IThrowDestroyCondition.CreateIThrowDestroyCondition(builder, _o.Type, _o.DelayTime);
		}

		// Token: 0x0400FDE6 RID: 64998
		private Table __p;
	}
}
