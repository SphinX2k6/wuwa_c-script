using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A84 RID: 19076
	public struct ICheckIsEntityHoldingHands : IFlatbufferObject
	{
		// Token: 0x17008A32 RID: 35378
		// (get) Token: 0x0601DE96 RID: 122518 RVA: 0x004337F0 File Offset: 0x004319F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE97 RID: 122519 RVA: 0x004337FD File Offset: 0x004319FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE98 RID: 122520 RVA: 0x00433804 File Offset: 0x00431A04
		public static ICheckIsEntityHoldingHands GetRootAsICheckIsEntityHoldingHands(ByteBuffer _bb)
		{
			return ICheckIsEntityHoldingHands.GetRootAsICheckIsEntityHoldingHands(_bb, default(ICheckIsEntityHoldingHands));
		}

		// Token: 0x0601DE99 RID: 122521 RVA: 0x00433820 File Offset: 0x00431A20
		public static ICheckIsEntityHoldingHands GetRootAsICheckIsEntityHoldingHands(ByteBuffer _bb, ICheckIsEntityHoldingHands obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE9A RID: 122522 RVA: 0x0043383D File Offset: 0x00431A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE9B RID: 122523 RVA: 0x0043384C File Offset: 0x00431A4C
		public ICheckIsEntityHoldingHands __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A33 RID: 35379
		// (get) Token: 0x0601DE9C RID: 122524 RVA: 0x0043385C File Offset: 0x00431A5C
		public ECheckHoldingHandsCharacter Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckHoldingHandsCharacter.Player;
				}
				return (ECheckHoldingHandsCharacter)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A34 RID: 35380
		// (get) Token: 0x0601DE9D RID: 122525 RVA: 0x00433898 File Offset: 0x00431A98
		public int EntityId
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

		// Token: 0x0601DE9E RID: 122526 RVA: 0x004338D4 File Offset: 0x00431AD4
		public static Offset<ICheckIsEntityHoldingHands> CreateICheckIsEntityHoldingHands(FlatBufferBuilder builder, ECheckHoldingHandsCharacter Type = ECheckHoldingHandsCharacter.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			ICheckIsEntityHoldingHands.AddEntityId(builder, EntityId);
			ICheckIsEntityHoldingHands.AddType(builder, Type);
			return ICheckIsEntityHoldingHands.EndICheckIsEntityHoldingHands(builder);
		}

		// Token: 0x0601DE9F RID: 122527 RVA: 0x004338F1 File Offset: 0x00431AF1
		public static void StartICheckIsEntityHoldingHands(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DEA0 RID: 122528 RVA: 0x004338FA File Offset: 0x00431AFA
		public static void AddType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DEA1 RID: 122529 RVA: 0x00433905 File Offset: 0x00431B05
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601DEA2 RID: 122530 RVA: 0x00433910 File Offset: 0x00431B10
		public static Offset<ICheckIsEntityHoldingHands> EndICheckIsEntityHoldingHands(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsEntityHoldingHands>(builder.EndTable());
		}

		// Token: 0x0601DEA3 RID: 122531 RVA: 0x00433920 File Offset: 0x00431B20
		public ICheckIsEntityHoldingHandsT UnPack()
		{
			ICheckIsEntityHoldingHandsT checkIsEntityHoldingHandsT = new ICheckIsEntityHoldingHandsT();
			this.UnPackTo(checkIsEntityHoldingHandsT);
			return checkIsEntityHoldingHandsT;
		}

		// Token: 0x0601DEA4 RID: 122532 RVA: 0x0043393B File Offset: 0x00431B3B
		public void UnPackTo(ICheckIsEntityHoldingHandsT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601DEA5 RID: 122533 RVA: 0x00433958 File Offset: 0x00431B58
		public static Offset<ICheckIsEntityHoldingHands> Pack(FlatBufferBuilder builder, ICheckIsEntityHoldingHandsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsEntityHoldingHands>);
			}
			return ICheckIsEntityHoldingHands.CreateICheckIsEntityHoldingHands(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400D2F2 RID: 54002
		private Table __p;
	}
}
