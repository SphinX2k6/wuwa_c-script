using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A61 RID: 23137
	public struct IThrowDestroyCondition : IFlatbufferObject
	{
		// Token: 0x1700AE17 RID: 44567
		// (get) Token: 0x060275D3 RID: 161235 RVA: 0x0056AC25 File Offset: 0x00568E25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060275D4 RID: 161236 RVA: 0x0056AC32 File Offset: 0x00568E32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060275D5 RID: 161237 RVA: 0x0056AC3C File Offset: 0x00568E3C
		public static IThrowDestroyCondition GetRootAsIThrowDestroyCondition(ByteBuffer _bb)
		{
			return IThrowDestroyCondition.GetRootAsIThrowDestroyCondition(_bb, default(IThrowDestroyCondition));
		}

		// Token: 0x060275D6 RID: 161238 RVA: 0x0056AC58 File Offset: 0x00568E58
		public static IThrowDestroyCondition GetRootAsIThrowDestroyCondition(ByteBuffer _bb, IThrowDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275D7 RID: 161239 RVA: 0x0056AC75 File Offset: 0x00568E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275D8 RID: 161240 RVA: 0x0056AC84 File Offset: 0x00568E84
		public IThrowDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE18 RID: 44568
		// (get) Token: 0x060275D9 RID: 161241 RVA: 0x0056AC94 File Offset: 0x00568E94
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

		// Token: 0x1700AE19 RID: 44569
		// (get) Token: 0x060275DA RID: 161242 RVA: 0x0056ACD0 File Offset: 0x00568ED0
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

		// Token: 0x060275DB RID: 161243 RVA: 0x0056AD10 File Offset: 0x00568F10
		public static Offset<IThrowDestroyCondition> CreateIThrowDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo, float DelayTime = 0f)
		{
			builder.StartTable(2);
			IThrowDestroyCondition.AddDelayTime(builder, DelayTime);
			IThrowDestroyCondition.AddType(builder, Type);
			return IThrowDestroyCondition.EndIThrowDestroyCondition(builder);
		}

		// Token: 0x060275DC RID: 161244 RVA: 0x0056AD2D File Offset: 0x00568F2D
		public static void StartIThrowDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060275DD RID: 161245 RVA: 0x0056AD36 File Offset: 0x00568F36
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060275DE RID: 161246 RVA: 0x0056AD41 File Offset: 0x00568F41
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060275DF RID: 161247 RVA: 0x0056AD54 File Offset: 0x00568F54
		public static Offset<IThrowDestroyCondition> EndIThrowDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<IThrowDestroyCondition>(builder.EndTable());
		}

		// Token: 0x060275E0 RID: 161248 RVA: 0x0056AD64 File Offset: 0x00568F64
		public IThrowDestroyConditionT UnPack()
		{
			IThrowDestroyConditionT throwDestroyConditionT = new IThrowDestroyConditionT();
			this.UnPackTo(throwDestroyConditionT);
			return throwDestroyConditionT;
		}

		// Token: 0x060275E1 RID: 161249 RVA: 0x0056AD7F File Offset: 0x00568F7F
		public void UnPackTo(IThrowDestroyConditionT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
		}

		// Token: 0x060275E2 RID: 161250 RVA: 0x0056AD9C File Offset: 0x00568F9C
		public static Offset<IThrowDestroyCondition> Pack(FlatBufferBuilder builder, IThrowDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowDestroyCondition>);
			}
			return IThrowDestroyCondition.CreateIThrowDestroyCondition(builder, _o.Type, _o.DelayTime);
		}

		// Token: 0x0400F0EF RID: 61679
		private Table __p;
	}
}
