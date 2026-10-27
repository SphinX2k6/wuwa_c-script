using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A90 RID: 19088
	public struct ICheckIsInDollGrabGamePlay : IFlatbufferObject
	{
		// Token: 0x17008A4A RID: 35402
		// (get) Token: 0x0601DEFC RID: 122620 RVA: 0x004343D7 File Offset: 0x004325D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DEFD RID: 122621 RVA: 0x004343E4 File Offset: 0x004325E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DEFE RID: 122622 RVA: 0x004343EC File Offset: 0x004325EC
		public static ICheckIsInDollGrabGamePlay GetRootAsICheckIsInDollGrabGamePlay(ByteBuffer _bb)
		{
			return ICheckIsInDollGrabGamePlay.GetRootAsICheckIsInDollGrabGamePlay(_bb, default(ICheckIsInDollGrabGamePlay));
		}

		// Token: 0x0601DEFF RID: 122623 RVA: 0x00434408 File Offset: 0x00432608
		public static ICheckIsInDollGrabGamePlay GetRootAsICheckIsInDollGrabGamePlay(ByteBuffer _bb, ICheckIsInDollGrabGamePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF00 RID: 122624 RVA: 0x00434425 File Offset: 0x00432625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF01 RID: 122625 RVA: 0x00434434 File Offset: 0x00432634
		public ICheckIsInDollGrabGamePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A4B RID: 35403
		// (get) Token: 0x0601DF02 RID: 122626 RVA: 0x00434444 File Offset: 0x00432644
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

		// Token: 0x17008A4C RID: 35404
		// (get) Token: 0x0601DF03 RID: 122627 RVA: 0x00434480 File Offset: 0x00432680
		public bool IsIn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A4D RID: 35405
		// (get) Token: 0x0601DF04 RID: 122628 RVA: 0x004344C0 File Offset: 0x004326C0
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

		// Token: 0x0601DF05 RID: 122629 RVA: 0x004344FC File Offset: 0x004326FC
		public static Offset<ICheckIsInDollGrabGamePlay> CreateICheckIsInDollGrabGamePlay(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsIn = false, int DollGrabEntityId = 0)
		{
			builder.StartTable(3);
			ICheckIsInDollGrabGamePlay.AddDollGrabEntityId(builder, DollGrabEntityId);
			ICheckIsInDollGrabGamePlay.AddIsIn(builder, IsIn);
			ICheckIsInDollGrabGamePlay.AddType(builder, Type);
			return ICheckIsInDollGrabGamePlay.EndICheckIsInDollGrabGamePlay(builder);
		}

		// Token: 0x0601DF06 RID: 122630 RVA: 0x00434520 File Offset: 0x00432720
		public static void StartICheckIsInDollGrabGamePlay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DF07 RID: 122631 RVA: 0x00434529 File Offset: 0x00432729
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DF08 RID: 122632 RVA: 0x00434534 File Offset: 0x00432734
		public static void AddIsIn(FlatBufferBuilder builder, bool isIn)
		{
			builder.AddBool(1, isIn, false);
		}

		// Token: 0x0601DF09 RID: 122633 RVA: 0x0043453F File Offset: 0x0043273F
		public static void AddDollGrabEntityId(FlatBufferBuilder builder, int dollGrabEntityId)
		{
			builder.AddInt(2, dollGrabEntityId, 0);
		}

		// Token: 0x0601DF0A RID: 122634 RVA: 0x0043454A File Offset: 0x0043274A
		public static Offset<ICheckIsInDollGrabGamePlay> EndICheckIsInDollGrabGamePlay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsInDollGrabGamePlay>(builder.EndTable());
		}

		// Token: 0x0601DF0B RID: 122635 RVA: 0x00434558 File Offset: 0x00432758
		public ICheckIsInDollGrabGamePlayT UnPack()
		{
			ICheckIsInDollGrabGamePlayT checkIsInDollGrabGamePlayT = new ICheckIsInDollGrabGamePlayT();
			this.UnPackTo(checkIsInDollGrabGamePlayT);
			return checkIsInDollGrabGamePlayT;
		}

		// Token: 0x0601DF0C RID: 122636 RVA: 0x00434573 File Offset: 0x00432773
		public void UnPackTo(ICheckIsInDollGrabGamePlayT _o)
		{
			_o.Type = this.Type;
			_o.IsIn = this.IsIn;
			_o.DollGrabEntityId = this.DollGrabEntityId;
		}

		// Token: 0x0601DF0D RID: 122637 RVA: 0x0043459C File Offset: 0x0043279C
		public static Offset<ICheckIsInDollGrabGamePlay> Pack(FlatBufferBuilder builder, ICheckIsInDollGrabGamePlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsInDollGrabGamePlay>);
			}
			return ICheckIsInDollGrabGamePlay.CreateICheckIsInDollGrabGamePlay(builder, _o.Type, _o.IsIn, _o.DollGrabEntityId);
		}

		// Token: 0x0400D300 RID: 54016
		private Table __p;
	}
}
