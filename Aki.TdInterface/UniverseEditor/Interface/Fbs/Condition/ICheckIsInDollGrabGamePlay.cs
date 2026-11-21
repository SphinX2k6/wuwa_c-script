using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F59 RID: 20313
	public struct ICheckIsInDollGrabGamePlay : IFlatbufferObject
	{
		// Token: 0x1700912B RID: 37163
		// (get) Token: 0x0601F9B5 RID: 129461 RVA: 0x00465762 File Offset: 0x00463962
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9B6 RID: 129462 RVA: 0x0046576F File Offset: 0x0046396F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9B7 RID: 129463 RVA: 0x00465778 File Offset: 0x00463978
		public static ICheckIsInDollGrabGamePlay GetRootAsICheckIsInDollGrabGamePlay(ByteBuffer _bb)
		{
			return ICheckIsInDollGrabGamePlay.GetRootAsICheckIsInDollGrabGamePlay(_bb, default(ICheckIsInDollGrabGamePlay));
		}

		// Token: 0x0601F9B8 RID: 129464 RVA: 0x00465794 File Offset: 0x00463994
		public static ICheckIsInDollGrabGamePlay GetRootAsICheckIsInDollGrabGamePlay(ByteBuffer _bb, ICheckIsInDollGrabGamePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9B9 RID: 129465 RVA: 0x004657B1 File Offset: 0x004639B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F9BA RID: 129466 RVA: 0x004657C0 File Offset: 0x004639C0
		public ICheckIsInDollGrabGamePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700912C RID: 37164
		// (get) Token: 0x0601F9BB RID: 129467 RVA: 0x004657D0 File Offset: 0x004639D0
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

		// Token: 0x1700912D RID: 37165
		// (get) Token: 0x0601F9BC RID: 129468 RVA: 0x0046580C File Offset: 0x00463A0C
		public bool IsIn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700912E RID: 37166
		// (get) Token: 0x0601F9BD RID: 129469 RVA: 0x0046584C File Offset: 0x00463A4C
		public int DollGrabEntityId
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

		// Token: 0x0601F9BE RID: 129470 RVA: 0x00465888 File Offset: 0x00463A88
		public static Offset<ICheckIsInDollGrabGamePlay> CreateICheckIsInDollGrabGamePlay(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsIn = false, int DollGrabEntityId = 0)
		{
			builder.StartTable(3);
			ICheckIsInDollGrabGamePlay.AddDollGrabEntityId(builder, DollGrabEntityId);
			ICheckIsInDollGrabGamePlay.AddIsIn(builder, IsIn);
			ICheckIsInDollGrabGamePlay.AddType(builder, Type);
			return ICheckIsInDollGrabGamePlay.EndICheckIsInDollGrabGamePlay(builder);
		}

		// Token: 0x0601F9BF RID: 129471 RVA: 0x004658AC File Offset: 0x00463AAC
		public static void StartICheckIsInDollGrabGamePlay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F9C0 RID: 129472 RVA: 0x004658B5 File Offset: 0x00463AB5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F9C1 RID: 129473 RVA: 0x004658C0 File Offset: 0x00463AC0
		public static void AddIsIn(FlatBufferBuilder builder, bool isIn)
		{
			builder.AddBool(1, isIn, false);
		}

		// Token: 0x0601F9C2 RID: 129474 RVA: 0x004658CB File Offset: 0x00463ACB
		public static void AddDollGrabEntityId(FlatBufferBuilder builder, int dollGrabEntityId)
		{
			builder.AddInt(2, dollGrabEntityId, 0);
		}

		// Token: 0x0601F9C3 RID: 129475 RVA: 0x004658D6 File Offset: 0x00463AD6
		public static Offset<ICheckIsInDollGrabGamePlay> EndICheckIsInDollGrabGamePlay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsInDollGrabGamePlay>(builder.EndTable());
		}

		// Token: 0x0601F9C4 RID: 129476 RVA: 0x004658E4 File Offset: 0x00463AE4
		public ICheckIsInDollGrabGamePlayT UnPack()
		{
			ICheckIsInDollGrabGamePlayT checkIsInDollGrabGamePlayT = new ICheckIsInDollGrabGamePlayT();
			this.UnPackTo(checkIsInDollGrabGamePlayT);
			return checkIsInDollGrabGamePlayT;
		}

		// Token: 0x0601F9C5 RID: 129477 RVA: 0x004658FF File Offset: 0x00463AFF
		public void UnPackTo(ICheckIsInDollGrabGamePlayT _o)
		{
			_o.Type = this.Type;
			_o.IsIn = this.IsIn;
			_o.DollGrabEntityId = this.DollGrabEntityId;
		}

		// Token: 0x0601F9C6 RID: 129478 RVA: 0x00465928 File Offset: 0x00463B28
		public static Offset<ICheckIsInDollGrabGamePlay> Pack(FlatBufferBuilder builder, ICheckIsInDollGrabGamePlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsInDollGrabGamePlay>);
			}
			return ICheckIsInDollGrabGamePlay.CreateICheckIsInDollGrabGamePlay(builder, _o.Type, _o.IsIn, _o.DollGrabEntityId);
		}

		// Token: 0x0400DDDE RID: 56798
		private Table __p;
	}
}
