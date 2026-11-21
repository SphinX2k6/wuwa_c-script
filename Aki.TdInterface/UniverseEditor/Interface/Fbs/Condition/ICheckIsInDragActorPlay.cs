using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F5C RID: 20316
	public struct ICheckIsInDragActorPlay : IFlatbufferObject
	{
		// Token: 0x17009132 RID: 37170
		// (get) Token: 0x0601F9CF RID: 129487 RVA: 0x004659F8 File Offset: 0x00463BF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9D0 RID: 129488 RVA: 0x00465A05 File Offset: 0x00463C05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9D1 RID: 129489 RVA: 0x00465A0C File Offset: 0x00463C0C
		public static ICheckIsInDragActorPlay GetRootAsICheckIsInDragActorPlay(ByteBuffer _bb)
		{
			return ICheckIsInDragActorPlay.GetRootAsICheckIsInDragActorPlay(_bb, default(ICheckIsInDragActorPlay));
		}

		// Token: 0x0601F9D2 RID: 129490 RVA: 0x00465A28 File Offset: 0x00463C28
		public static ICheckIsInDragActorPlay GetRootAsICheckIsInDragActorPlay(ByteBuffer _bb, ICheckIsInDragActorPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9D3 RID: 129491 RVA: 0x00465A45 File Offset: 0x00463C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F9D4 RID: 129492 RVA: 0x00465A54 File Offset: 0x00463C54
		public ICheckIsInDragActorPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009133 RID: 37171
		// (get) Token: 0x0601F9D5 RID: 129493 RVA: 0x00465A64 File Offset: 0x00463C64
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

		// Token: 0x17009134 RID: 37172
		// (get) Token: 0x0601F9D6 RID: 129494 RVA: 0x00465AA0 File Offset: 0x00463CA0
		public bool IsIn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F9D7 RID: 129495 RVA: 0x00465ADF File Offset: 0x00463CDF
		public static Offset<ICheckIsInDragActorPlay> CreateICheckIsInDragActorPlay(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsIn = false)
		{
			builder.StartTable(2);
			ICheckIsInDragActorPlay.AddIsIn(builder, IsIn);
			ICheckIsInDragActorPlay.AddType(builder, Type);
			return ICheckIsInDragActorPlay.EndICheckIsInDragActorPlay(builder);
		}

		// Token: 0x0601F9D8 RID: 129496 RVA: 0x00465AFC File Offset: 0x00463CFC
		public static void StartICheckIsInDragActorPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F9D9 RID: 129497 RVA: 0x00465B05 File Offset: 0x00463D05
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F9DA RID: 129498 RVA: 0x00465B10 File Offset: 0x00463D10
		public static void AddIsIn(FlatBufferBuilder builder, bool isIn)
		{
			builder.AddBool(1, isIn, false);
		}

		// Token: 0x0601F9DB RID: 129499 RVA: 0x00465B1B File Offset: 0x00463D1B
		public static Offset<ICheckIsInDragActorPlay> EndICheckIsInDragActorPlay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsInDragActorPlay>(builder.EndTable());
		}

		// Token: 0x0601F9DC RID: 129500 RVA: 0x00465B28 File Offset: 0x00463D28
		public ICheckIsInDragActorPlayT UnPack()
		{
			ICheckIsInDragActorPlayT checkIsInDragActorPlayT = new ICheckIsInDragActorPlayT();
			this.UnPackTo(checkIsInDragActorPlayT);
			return checkIsInDragActorPlayT;
		}

		// Token: 0x0601F9DD RID: 129501 RVA: 0x00465B43 File Offset: 0x00463D43
		public void UnPackTo(ICheckIsInDragActorPlayT _o)
		{
			_o.Type = this.Type;
			_o.IsIn = this.IsIn;
		}

		// Token: 0x0601F9DE RID: 129502 RVA: 0x00465B60 File Offset: 0x00463D60
		public static Offset<ICheckIsInDragActorPlay> Pack(FlatBufferBuilder builder, ICheckIsInDragActorPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsInDragActorPlay>);
			}
			return ICheckIsInDragActorPlay.CreateICheckIsInDragActorPlay(builder, _o.Type, _o.IsIn);
		}

		// Token: 0x0400DDE2 RID: 56802
		private Table __p;
	}
}
