using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C07 RID: 19463
	public struct IElementalBoxStateSpecifiedTarget : IFlatbufferObject
	{
		// Token: 0x17008D61 RID: 36193
		// (get) Token: 0x0601ED27 RID: 126247 RVA: 0x00450F65 File Offset: 0x0044F165
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED28 RID: 126248 RVA: 0x00450F72 File Offset: 0x0044F172
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED29 RID: 126249 RVA: 0x00450F7C File Offset: 0x0044F17C
		public static IElementalBoxStateSpecifiedTarget GetRootAsIElementalBoxStateSpecifiedTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateSpecifiedTarget.GetRootAsIElementalBoxStateSpecifiedTarget(_bb, default(IElementalBoxStateSpecifiedTarget));
		}

		// Token: 0x0601ED2A RID: 126250 RVA: 0x00450F98 File Offset: 0x0044F198
		public static IElementalBoxStateSpecifiedTarget GetRootAsIElementalBoxStateSpecifiedTarget(ByteBuffer _bb, IElementalBoxStateSpecifiedTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED2B RID: 126251 RVA: 0x00450FB5 File Offset: 0x0044F1B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED2C RID: 126252 RVA: 0x00450FC4 File Offset: 0x0044F1C4
		public IElementalBoxStateSpecifiedTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D62 RID: 36194
		// (get) Token: 0x0601ED2D RID: 126253 RVA: 0x00450FD4 File Offset: 0x0044F1D4
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

		// Token: 0x17008D63 RID: 36195
		// (get) Token: 0x0601ED2E RID: 126254 RVA: 0x00451010 File Offset: 0x0044F210
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

		// Token: 0x17008D64 RID: 36196
		// (get) Token: 0x0601ED2F RID: 126255 RVA: 0x0045104C File Offset: 0x0044F24C
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

		// Token: 0x0601ED30 RID: 126256 RVA: 0x00451083 File Offset: 0x0044F283
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601ED31 RID: 126257 RVA: 0x00451092 File Offset: 0x0044F292
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601ED32 RID: 126258 RVA: 0x004510A0 File Offset: 0x0044F2A0
		public static Offset<IElementalBoxStateSpecifiedTarget> CreateIElementalBoxStateSpecifiedTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, int ElementalBoxId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IElementalBoxStateSpecifiedTarget.AddState(builder, StateOffset);
			IElementalBoxStateSpecifiedTarget.AddElementalBoxId(builder, ElementalBoxId);
			IElementalBoxStateSpecifiedTarget.AddType(builder, Type);
			return IElementalBoxStateSpecifiedTarget.EndIElementalBoxStateSpecifiedTarget(builder);
		}

		// Token: 0x0601ED33 RID: 126259 RVA: 0x004510C4 File Offset: 0x0044F2C4
		public static void StartIElementalBoxStateSpecifiedTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601ED34 RID: 126260 RVA: 0x004510CD File Offset: 0x0044F2CD
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED35 RID: 126261 RVA: 0x004510D8 File Offset: 0x0044F2D8
		public static void AddElementalBoxId(FlatBufferBuilder builder, int elementalBoxId)
		{
			builder.AddInt(1, elementalBoxId, 0);
		}

		// Token: 0x0601ED36 RID: 126262 RVA: 0x004510E3 File Offset: 0x0044F2E3
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0601ED37 RID: 126263 RVA: 0x004510F3 File Offset: 0x0044F2F3
		public static Offset<IElementalBoxStateSpecifiedTarget> EndIElementalBoxStateSpecifiedTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateSpecifiedTarget>(builder.EndTable());
		}

		// Token: 0x0601ED38 RID: 126264 RVA: 0x00451100 File Offset: 0x0044F300
		public IElementalBoxStateSpecifiedTargetT UnPack()
		{
			IElementalBoxStateSpecifiedTargetT elementalBoxStateSpecifiedTargetT = new IElementalBoxStateSpecifiedTargetT();
			this.UnPackTo(elementalBoxStateSpecifiedTargetT);
			return elementalBoxStateSpecifiedTargetT;
		}

		// Token: 0x0601ED39 RID: 126265 RVA: 0x0045111B File Offset: 0x0044F31B
		public void UnPackTo(IElementalBoxStateSpecifiedTargetT _o)
		{
			_o.Type = this.Type;
			_o.ElementalBoxId = this.ElementalBoxId;
			_o.State = this.State;
		}

		// Token: 0x0601ED3A RID: 126266 RVA: 0x00451144 File Offset: 0x0044F344
		public static Offset<IElementalBoxStateSpecifiedTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateSpecifiedTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateSpecifiedTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStateSpecifiedTarget.CreateIElementalBoxStateSpecifiedTarget(builder, _o.Type, _o.ElementalBoxId, stateOffset);
		}

		// Token: 0x0400D595 RID: 54677
		private Table __p;
	}
}
