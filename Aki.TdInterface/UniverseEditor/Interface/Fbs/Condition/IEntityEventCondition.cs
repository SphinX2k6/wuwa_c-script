using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C13 RID: 19475
	public struct IEntityEventCondition : IFlatbufferObject
	{
		// Token: 0x17008D72 RID: 36210
		// (get) Token: 0x0601ED7D RID: 126333 RVA: 0x0045177E File Offset: 0x0044F97E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED7E RID: 126334 RVA: 0x0045178B File Offset: 0x0044F98B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED7F RID: 126335 RVA: 0x00451794 File Offset: 0x0044F994
		public static IEntityEventCondition GetRootAsIEntityEventCondition(ByteBuffer _bb)
		{
			return IEntityEventCondition.GetRootAsIEntityEventCondition(_bb, default(IEntityEventCondition));
		}

		// Token: 0x0601ED80 RID: 126336 RVA: 0x004517B0 File Offset: 0x0044F9B0
		public static IEntityEventCondition GetRootAsIEntityEventCondition(ByteBuffer _bb, IEntityEventCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED81 RID: 126337 RVA: 0x004517CD File Offset: 0x0044F9CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED82 RID: 126338 RVA: 0x004517DC File Offset: 0x0044F9DC
		public IEntityEventCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D73 RID: 36211
		// (get) Token: 0x0601ED83 RID: 126339 RVA: 0x004517EC File Offset: 0x0044F9EC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D74 RID: 36212
		// (get) Token: 0x0601ED84 RID: 126340 RVA: 0x00451828 File Offset: 0x0044FA28
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED85 RID: 126341 RVA: 0x0045185F File Offset: 0x0044FA5F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ED86 RID: 126342 RVA: 0x0045186E File Offset: 0x0044FA6E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008D75 RID: 36213
		// (get) Token: 0x0601ED87 RID: 126343 RVA: 0x0045187C File Offset: 0x0044FA7C
		public bool IsDead
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008D76 RID: 36214
		// (get) Token: 0x0601ED88 RID: 126344 RVA: 0x004518BC File Offset: 0x0044FABC
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008D77 RID: 36215
		// (get) Token: 0x0601ED89 RID: 126345 RVA: 0x004518FC File Offset: 0x0044FAFC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED8A RID: 126346 RVA: 0x00451939 File Offset: 0x0044FB39
		public static Offset<IEntityEventCondition> CreateIEntityEventCondition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset), bool IsDead = false, bool IsLocked = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityEventCondition.AddState(builder, StateOffset);
			IEntityEventCondition.AddEntityId(builder, EntityId);
			IEntityEventCondition.AddNullMask(builder, NullMask);
			IEntityEventCondition.AddIsLocked(builder, IsLocked);
			IEntityEventCondition.AddIsDead(builder, IsDead);
			return IEntityEventCondition.EndIEntityEventCondition(builder);
		}

		// Token: 0x0601ED8B RID: 126347 RVA: 0x0045196D File Offset: 0x0044FB6D
		public static void StartIEntityEventCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601ED8C RID: 126348 RVA: 0x00451976 File Offset: 0x0044FB76
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601ED8D RID: 126349 RVA: 0x00451981 File Offset: 0x0044FB81
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601ED8E RID: 126350 RVA: 0x00451991 File Offset: 0x0044FB91
		public static void AddIsDead(FlatBufferBuilder builder, bool isDead)
		{
			builder.AddBool(2, isDead, false);
		}

		// Token: 0x0601ED8F RID: 126351 RVA: 0x0045199C File Offset: 0x0044FB9C
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(3, isLocked, false);
		}

		// Token: 0x0601ED90 RID: 126352 RVA: 0x004519A7 File Offset: 0x0044FBA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601ED91 RID: 126353 RVA: 0x004519B2 File Offset: 0x0044FBB2
		public static Offset<IEntityEventCondition> EndIEntityEventCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityEventCondition>(builder.EndTable());
		}

		// Token: 0x0601ED92 RID: 126354 RVA: 0x004519C0 File Offset: 0x0044FBC0
		public IEntityEventConditionT UnPack()
		{
			IEntityEventConditionT entityEventConditionT = new IEntityEventConditionT();
			this.UnPackTo(entityEventConditionT);
			return entityEventConditionT;
		}

		// Token: 0x0601ED93 RID: 126355 RVA: 0x004519DB File Offset: 0x0044FBDB
		public void UnPackTo(IEntityEventConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.IsDead = this.IsDead;
			_o.IsLocked = this.IsLocked;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601ED94 RID: 126356 RVA: 0x00451A1C File Offset: 0x0044FC1C
		public static Offset<IEntityEventCondition> Pack(FlatBufferBuilder builder, IEntityEventConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityEventCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityEventCondition.CreateIEntityEventCondition(builder, _o.EntityId, stateOffset, _o.IsDead, _o.IsLocked, _o.NullMask);
		}

		// Token: 0x0400D5A7 RID: 54695
		private Table __p;
	}
}
