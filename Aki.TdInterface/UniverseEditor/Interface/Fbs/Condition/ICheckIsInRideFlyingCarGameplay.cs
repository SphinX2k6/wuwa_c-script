using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F5F RID: 20319
	public struct ICheckIsInRideFlyingCarGameplay : IFlatbufferObject
	{
		// Token: 0x17009137 RID: 37175
		// (get) Token: 0x0601F9E5 RID: 129509 RVA: 0x00465BF6 File Offset: 0x00463DF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9E6 RID: 129510 RVA: 0x00465C03 File Offset: 0x00463E03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9E7 RID: 129511 RVA: 0x00465C0C File Offset: 0x00463E0C
		public static ICheckIsInRideFlyingCarGameplay GetRootAsICheckIsInRideFlyingCarGameplay(ByteBuffer _bb)
		{
			return ICheckIsInRideFlyingCarGameplay.GetRootAsICheckIsInRideFlyingCarGameplay(_bb, default(ICheckIsInRideFlyingCarGameplay));
		}

		// Token: 0x0601F9E8 RID: 129512 RVA: 0x00465C28 File Offset: 0x00463E28
		public static ICheckIsInRideFlyingCarGameplay GetRootAsICheckIsInRideFlyingCarGameplay(ByteBuffer _bb, ICheckIsInRideFlyingCarGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9E9 RID: 129513 RVA: 0x00465C45 File Offset: 0x00463E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F9EA RID: 129514 RVA: 0x00465C54 File Offset: 0x00463E54
		public ICheckIsInRideFlyingCarGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009138 RID: 37176
		// (get) Token: 0x0601F9EB RID: 129515 RVA: 0x00465C64 File Offset: 0x00463E64
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

		// Token: 0x17009139 RID: 37177
		// (get) Token: 0x0601F9EC RID: 129516 RVA: 0x00465CA0 File Offset: 0x00463EA0
		public bool IsIn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F9ED RID: 129517 RVA: 0x00465CDF File Offset: 0x00463EDF
		public static Offset<ICheckIsInRideFlyingCarGameplay> CreateICheckIsInRideFlyingCarGameplay(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsIn = false)
		{
			builder.StartTable(2);
			ICheckIsInRideFlyingCarGameplay.AddIsIn(builder, IsIn);
			ICheckIsInRideFlyingCarGameplay.AddType(builder, Type);
			return ICheckIsInRideFlyingCarGameplay.EndICheckIsInRideFlyingCarGameplay(builder);
		}

		// Token: 0x0601F9EE RID: 129518 RVA: 0x00465CFC File Offset: 0x00463EFC
		public static void StartICheckIsInRideFlyingCarGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F9EF RID: 129519 RVA: 0x00465D05 File Offset: 0x00463F05
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F9F0 RID: 129520 RVA: 0x00465D10 File Offset: 0x00463F10
		public static void AddIsIn(FlatBufferBuilder builder, bool isIn)
		{
			builder.AddBool(1, isIn, false);
		}

		// Token: 0x0601F9F1 RID: 129521 RVA: 0x00465D1B File Offset: 0x00463F1B
		public static Offset<ICheckIsInRideFlyingCarGameplay> EndICheckIsInRideFlyingCarGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsInRideFlyingCarGameplay>(builder.EndTable());
		}

		// Token: 0x0601F9F2 RID: 129522 RVA: 0x00465D28 File Offset: 0x00463F28
		public ICheckIsInRideFlyingCarGameplayT UnPack()
		{
			ICheckIsInRideFlyingCarGameplayT checkIsInRideFlyingCarGameplayT = new ICheckIsInRideFlyingCarGameplayT();
			this.UnPackTo(checkIsInRideFlyingCarGameplayT);
			return checkIsInRideFlyingCarGameplayT;
		}

		// Token: 0x0601F9F3 RID: 129523 RVA: 0x00465D43 File Offset: 0x00463F43
		public void UnPackTo(ICheckIsInRideFlyingCarGameplayT _o)
		{
			_o.Type = this.Type;
			_o.IsIn = this.IsIn;
		}

		// Token: 0x0601F9F4 RID: 129524 RVA: 0x00465D60 File Offset: 0x00463F60
		public static Offset<ICheckIsInRideFlyingCarGameplay> Pack(FlatBufferBuilder builder, ICheckIsInRideFlyingCarGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsInRideFlyingCarGameplay>);
			}
			return ICheckIsInRideFlyingCarGameplay.CreateICheckIsInRideFlyingCarGameplay(builder, _o.Type, _o.IsIn);
		}

		// Token: 0x0400DDE5 RID: 56805
		private Table __p;
	}
}
