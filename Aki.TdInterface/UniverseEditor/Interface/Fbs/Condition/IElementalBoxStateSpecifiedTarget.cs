using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F4 RID: 20724
	public struct IElementalBoxStateSpecifiedTarget : IFlatbufferObject
	{
		// Token: 0x17009485 RID: 38021
		// (get) Token: 0x0602090D RID: 133389 RVA: 0x004845CD File Offset: 0x004827CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602090E RID: 133390 RVA: 0x004845DA File Offset: 0x004827DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602090F RID: 133391 RVA: 0x004845E4 File Offset: 0x004827E4
		public static IElementalBoxStateSpecifiedTarget GetRootAsIElementalBoxStateSpecifiedTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateSpecifiedTarget.GetRootAsIElementalBoxStateSpecifiedTarget(_bb, default(IElementalBoxStateSpecifiedTarget));
		}

		// Token: 0x06020910 RID: 133392 RVA: 0x00484600 File Offset: 0x00482800
		public static IElementalBoxStateSpecifiedTarget GetRootAsIElementalBoxStateSpecifiedTarget(ByteBuffer _bb, IElementalBoxStateSpecifiedTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020911 RID: 133393 RVA: 0x0048461D File Offset: 0x0048281D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020912 RID: 133394 RVA: 0x0048462C File Offset: 0x0048282C
		public IElementalBoxStateSpecifiedTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009486 RID: 38022
		// (get) Token: 0x06020913 RID: 133395 RVA: 0x0048463C File Offset: 0x0048283C
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

		// Token: 0x17009487 RID: 38023
		// (get) Token: 0x06020914 RID: 133396 RVA: 0x00484678 File Offset: 0x00482878
		public int ElementalBoxId
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

		// Token: 0x17009488 RID: 38024
		// (get) Token: 0x06020915 RID: 133397 RVA: 0x004846B4 File Offset: 0x004828B4
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

		// Token: 0x06020916 RID: 133398 RVA: 0x004846EB File Offset: 0x004828EB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020917 RID: 133399 RVA: 0x004846FA File Offset: 0x004828FA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06020918 RID: 133400 RVA: 0x00484708 File Offset: 0x00482908
		public static Offset<IElementalBoxStateSpecifiedTarget> CreateIElementalBoxStateSpecifiedTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, int ElementalBoxId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IElementalBoxStateSpecifiedTarget.AddState(builder, StateOffset);
			IElementalBoxStateSpecifiedTarget.AddElementalBoxId(builder, ElementalBoxId);
			IElementalBoxStateSpecifiedTarget.AddType(builder, Type);
			return IElementalBoxStateSpecifiedTarget.EndIElementalBoxStateSpecifiedTarget(builder);
		}

		// Token: 0x06020919 RID: 133401 RVA: 0x0048472C File Offset: 0x0048292C
		public static void StartIElementalBoxStateSpecifiedTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602091A RID: 133402 RVA: 0x00484735 File Offset: 0x00482935
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602091B RID: 133403 RVA: 0x00484740 File Offset: 0x00482940
		public static void AddElementalBoxId(FlatBufferBuilder builder, int elementalBoxId)
		{
			builder.AddInt(1, elementalBoxId, 0);
		}

		// Token: 0x0602091C RID: 133404 RVA: 0x0048474B File Offset: 0x0048294B
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0602091D RID: 133405 RVA: 0x0048475B File Offset: 0x0048295B
		public static Offset<IElementalBoxStateSpecifiedTarget> EndIElementalBoxStateSpecifiedTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateSpecifiedTarget>(builder.EndTable());
		}

		// Token: 0x0602091E RID: 133406 RVA: 0x00484768 File Offset: 0x00482968
		public IElementalBoxStateSpecifiedTargetT UnPack()
		{
			IElementalBoxStateSpecifiedTargetT elementalBoxStateSpecifiedTargetT = new IElementalBoxStateSpecifiedTargetT();
			this.UnPackTo(elementalBoxStateSpecifiedTargetT);
			return elementalBoxStateSpecifiedTargetT;
		}

		// Token: 0x0602091F RID: 133407 RVA: 0x00484783 File Offset: 0x00482983
		public void UnPackTo(IElementalBoxStateSpecifiedTargetT _o)
		{
			_o.Type = this.Type;
			_o.ElementalBoxId = this.ElementalBoxId;
			_o.State = this.State;
		}

		// Token: 0x06020920 RID: 133408 RVA: 0x004847AC File Offset: 0x004829AC
		public static Offset<IElementalBoxStateSpecifiedTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateSpecifiedTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateSpecifiedTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStateSpecifiedTarget.CreateIElementalBoxStateSpecifiedTarget(builder, _o.Type, _o.ElementalBoxId, stateOffset);
		}

		// Token: 0x0400E0AC RID: 57516
		private Table __p;
	}
}
