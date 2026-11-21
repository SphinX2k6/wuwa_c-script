using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F56 RID: 20310
	public struct ICheckIsInDartGameplay : IFlatbufferObject
	{
		// Token: 0x17009126 RID: 37158
		// (get) Token: 0x0601F99F RID: 129439 RVA: 0x00465563 File Offset: 0x00463763
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9A0 RID: 129440 RVA: 0x00465570 File Offset: 0x00463770
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9A1 RID: 129441 RVA: 0x00465578 File Offset: 0x00463778
		public static ICheckIsInDartGameplay GetRootAsICheckIsInDartGameplay(ByteBuffer _bb)
		{
			return ICheckIsInDartGameplay.GetRootAsICheckIsInDartGameplay(_bb, default(ICheckIsInDartGameplay));
		}

		// Token: 0x0601F9A2 RID: 129442 RVA: 0x00465594 File Offset: 0x00463794
		public static ICheckIsInDartGameplay GetRootAsICheckIsInDartGameplay(ByteBuffer _bb, ICheckIsInDartGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9A3 RID: 129443 RVA: 0x004655B1 File Offset: 0x004637B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F9A4 RID: 129444 RVA: 0x004655C0 File Offset: 0x004637C0
		public ICheckIsInDartGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009127 RID: 37159
		// (get) Token: 0x0601F9A5 RID: 129445 RVA: 0x004655D0 File Offset: 0x004637D0
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

		// Token: 0x17009128 RID: 37160
		// (get) Token: 0x0601F9A6 RID: 129446 RVA: 0x0046560C File Offset: 0x0046380C
		public bool IsIn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F9A7 RID: 129447 RVA: 0x0046564B File Offset: 0x0046384B
		public static Offset<ICheckIsInDartGameplay> CreateICheckIsInDartGameplay(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsIn = false)
		{
			builder.StartTable(2);
			ICheckIsInDartGameplay.AddIsIn(builder, IsIn);
			ICheckIsInDartGameplay.AddType(builder, Type);
			return ICheckIsInDartGameplay.EndICheckIsInDartGameplay(builder);
		}

		// Token: 0x0601F9A8 RID: 129448 RVA: 0x00465668 File Offset: 0x00463868
		public static void StartICheckIsInDartGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F9A9 RID: 129449 RVA: 0x00465671 File Offset: 0x00463871
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F9AA RID: 129450 RVA: 0x0046567C File Offset: 0x0046387C
		public static void AddIsIn(FlatBufferBuilder builder, bool isIn)
		{
			builder.AddBool(1, isIn, false);
		}

		// Token: 0x0601F9AB RID: 129451 RVA: 0x00465687 File Offset: 0x00463887
		public static Offset<ICheckIsInDartGameplay> EndICheckIsInDartGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsInDartGameplay>(builder.EndTable());
		}

		// Token: 0x0601F9AC RID: 129452 RVA: 0x00465694 File Offset: 0x00463894
		public ICheckIsInDartGameplayT UnPack()
		{
			ICheckIsInDartGameplayT checkIsInDartGameplayT = new ICheckIsInDartGameplayT();
			this.UnPackTo(checkIsInDartGameplayT);
			return checkIsInDartGameplayT;
		}

		// Token: 0x0601F9AD RID: 129453 RVA: 0x004656AF File Offset: 0x004638AF
		public void UnPackTo(ICheckIsInDartGameplayT _o)
		{
			_o.Type = this.Type;
			_o.IsIn = this.IsIn;
		}

		// Token: 0x0601F9AE RID: 129454 RVA: 0x004656CC File Offset: 0x004638CC
		public static Offset<ICheckIsInDartGameplay> Pack(FlatBufferBuilder builder, ICheckIsInDartGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsInDartGameplay>);
			}
			return ICheckIsInDartGameplay.CreateICheckIsInDartGameplay(builder, _o.Type, _o.IsIn);
		}

		// Token: 0x0400DDDB RID: 56795
		private Table __p;
	}
}
