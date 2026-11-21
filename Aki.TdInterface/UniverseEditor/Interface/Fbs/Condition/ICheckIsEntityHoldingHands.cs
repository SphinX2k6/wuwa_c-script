using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F4A RID: 20298
	public struct ICheckIsEntityHoldingHands : IFlatbufferObject
	{
		// Token: 0x1700910E RID: 37134
		// (get) Token: 0x0601F939 RID: 129337 RVA: 0x0046497C File Offset: 0x00462B7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F93A RID: 129338 RVA: 0x00464989 File Offset: 0x00462B89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F93B RID: 129339 RVA: 0x00464990 File Offset: 0x00462B90
		public static ICheckIsEntityHoldingHands GetRootAsICheckIsEntityHoldingHands(ByteBuffer _bb)
		{
			return ICheckIsEntityHoldingHands.GetRootAsICheckIsEntityHoldingHands(_bb, default(ICheckIsEntityHoldingHands));
		}

		// Token: 0x0601F93C RID: 129340 RVA: 0x004649AC File Offset: 0x00462BAC
		public static ICheckIsEntityHoldingHands GetRootAsICheckIsEntityHoldingHands(ByteBuffer _bb, ICheckIsEntityHoldingHands obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F93D RID: 129341 RVA: 0x004649C9 File Offset: 0x00462BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F93E RID: 129342 RVA: 0x004649D8 File Offset: 0x00462BD8
		public ICheckIsEntityHoldingHands __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700910F RID: 37135
		// (get) Token: 0x0601F93F RID: 129343 RVA: 0x004649E8 File Offset: 0x00462BE8
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

		// Token: 0x17009110 RID: 37136
		// (get) Token: 0x0601F940 RID: 129344 RVA: 0x00464A24 File Offset: 0x00462C24
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

		// Token: 0x0601F941 RID: 129345 RVA: 0x00464A60 File Offset: 0x00462C60
		public static Offset<ICheckIsEntityHoldingHands> CreateICheckIsEntityHoldingHands(FlatBufferBuilder builder, ECheckHoldingHandsCharacter Type = ECheckHoldingHandsCharacter.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			ICheckIsEntityHoldingHands.AddEntityId(builder, EntityId);
			ICheckIsEntityHoldingHands.AddType(builder, Type);
			return ICheckIsEntityHoldingHands.EndICheckIsEntityHoldingHands(builder);
		}

		// Token: 0x0601F942 RID: 129346 RVA: 0x00464A7D File Offset: 0x00462C7D
		public static void StartICheckIsEntityHoldingHands(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F943 RID: 129347 RVA: 0x00464A86 File Offset: 0x00462C86
		public static void AddType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F944 RID: 129348 RVA: 0x00464A91 File Offset: 0x00462C91
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F945 RID: 129349 RVA: 0x00464A9C File Offset: 0x00462C9C
		public static Offset<ICheckIsEntityHoldingHands> EndICheckIsEntityHoldingHands(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsEntityHoldingHands>(builder.EndTable());
		}

		// Token: 0x0601F946 RID: 129350 RVA: 0x00464AAC File Offset: 0x00462CAC
		public ICheckIsEntityHoldingHandsT UnPack()
		{
			ICheckIsEntityHoldingHandsT checkIsEntityHoldingHandsT = new ICheckIsEntityHoldingHandsT();
			this.UnPackTo(checkIsEntityHoldingHandsT);
			return checkIsEntityHoldingHandsT;
		}

		// Token: 0x0601F947 RID: 129351 RVA: 0x00464AC7 File Offset: 0x00462CC7
		public void UnPackTo(ICheckIsEntityHoldingHandsT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601F948 RID: 129352 RVA: 0x00464AE4 File Offset: 0x00462CE4
		public static Offset<ICheckIsEntityHoldingHands> Pack(FlatBufferBuilder builder, ICheckIsEntityHoldingHandsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsEntityHoldingHands>);
			}
			return ICheckIsEntityHoldingHands.CreateICheckIsEntityHoldingHands(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400DDCD RID: 56781
		private Table __p;
	}
}
