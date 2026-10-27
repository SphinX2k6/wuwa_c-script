using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C01 RID: 19457
	public struct IElementalBoxStateFoundationTarget : IFlatbufferObject
	{
		// Token: 0x17008D55 RID: 36181
		// (get) Token: 0x0601ECF3 RID: 126195 RVA: 0x00450A79 File Offset: 0x0044EC79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ECF4 RID: 126196 RVA: 0x00450A86 File Offset: 0x0044EC86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ECF5 RID: 126197 RVA: 0x00450A90 File Offset: 0x0044EC90
		public static IElementalBoxStateFoundationTarget GetRootAsIElementalBoxStateFoundationTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateFoundationTarget.GetRootAsIElementalBoxStateFoundationTarget(_bb, default(IElementalBoxStateFoundationTarget));
		}

		// Token: 0x0601ECF6 RID: 126198 RVA: 0x00450AAC File Offset: 0x0044ECAC
		public static IElementalBoxStateFoundationTarget GetRootAsIElementalBoxStateFoundationTarget(ByteBuffer _bb, IElementalBoxStateFoundationTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ECF7 RID: 126199 RVA: 0x00450AC9 File Offset: 0x0044ECC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ECF8 RID: 126200 RVA: 0x00450AD8 File Offset: 0x0044ECD8
		public IElementalBoxStateFoundationTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D56 RID: 36182
		// (get) Token: 0x0601ECF9 RID: 126201 RVA: 0x00450AE8 File Offset: 0x0044ECE8
		public EElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxStateTargetType.Player;
				}
				return (EElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D57 RID: 36183
		// (get) Token: 0x0601ECFA RID: 126202 RVA: 0x00450B24 File Offset: 0x0044ED24
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

		// Token: 0x17008D58 RID: 36184
		// (get) Token: 0x0601ECFB RID: 126203 RVA: 0x00450B60 File Offset: 0x0044ED60
		public string State
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ECFC RID: 126204 RVA: 0x00450B97 File Offset: 0x0044ED97
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601ECFD RID: 126205 RVA: 0x00450BA6 File Offset: 0x0044EDA6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601ECFE RID: 126206 RVA: 0x00450BB4 File Offset: 0x0044EDB4
		public static Offset<IElementalBoxStateFoundationTarget> CreateIElementalBoxStateFoundationTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IElementalBoxStateFoundationTarget.AddState(builder, StateOffset);
			IElementalBoxStateFoundationTarget.AddEntityId(builder, EntityId);
			IElementalBoxStateFoundationTarget.AddType(builder, Type);
			return IElementalBoxStateFoundationTarget.EndIElementalBoxStateFoundationTarget(builder);
		}

		// Token: 0x0601ECFF RID: 126207 RVA: 0x00450BD8 File Offset: 0x0044EDD8
		public static void StartIElementalBoxStateFoundationTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601ED00 RID: 126208 RVA: 0x00450BE1 File Offset: 0x0044EDE1
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED01 RID: 126209 RVA: 0x00450BEC File Offset: 0x0044EDEC
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601ED02 RID: 126210 RVA: 0x00450BF7 File Offset: 0x0044EDF7
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0601ED03 RID: 126211 RVA: 0x00450C07 File Offset: 0x0044EE07
		public static Offset<IElementalBoxStateFoundationTarget> EndIElementalBoxStateFoundationTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateFoundationTarget>(builder.EndTable());
		}

		// Token: 0x0601ED04 RID: 126212 RVA: 0x00450C14 File Offset: 0x0044EE14
		public IElementalBoxStateFoundationTargetT UnPack()
		{
			IElementalBoxStateFoundationTargetT elementalBoxStateFoundationTargetT = new IElementalBoxStateFoundationTargetT();
			this.UnPackTo(elementalBoxStateFoundationTargetT);
			return elementalBoxStateFoundationTargetT;
		}

		// Token: 0x0601ED05 RID: 126213 RVA: 0x00450C2F File Offset: 0x0044EE2F
		public void UnPackTo(IElementalBoxStateFoundationTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x0601ED06 RID: 126214 RVA: 0x00450C58 File Offset: 0x0044EE58
		public static Offset<IElementalBoxStateFoundationTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateFoundationTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateFoundationTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStateFoundationTarget.CreateIElementalBoxStateFoundationTarget(builder, _o.Type, _o.EntityId, stateOffset);
		}

		// Token: 0x0400D58E RID: 54670
		private Table __p;
	}
}
