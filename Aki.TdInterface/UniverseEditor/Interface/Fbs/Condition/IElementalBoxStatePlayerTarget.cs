using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F1 RID: 20721
	public struct IElementalBoxStatePlayerTarget : IFlatbufferObject
	{
		// Token: 0x17009480 RID: 38016
		// (get) Token: 0x060208F5 RID: 133365 RVA: 0x0048439A File Offset: 0x0048259A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060208F6 RID: 133366 RVA: 0x004843A7 File Offset: 0x004825A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060208F7 RID: 133367 RVA: 0x004843B0 File Offset: 0x004825B0
		public static IElementalBoxStatePlayerTarget GetRootAsIElementalBoxStatePlayerTarget(ByteBuffer _bb)
		{
			return IElementalBoxStatePlayerTarget.GetRootAsIElementalBoxStatePlayerTarget(_bb, default(IElementalBoxStatePlayerTarget));
		}

		// Token: 0x060208F8 RID: 133368 RVA: 0x004843CC File Offset: 0x004825CC
		public static IElementalBoxStatePlayerTarget GetRootAsIElementalBoxStatePlayerTarget(ByteBuffer _bb, IElementalBoxStatePlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060208F9 RID: 133369 RVA: 0x004843E9 File Offset: 0x004825E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060208FA RID: 133370 RVA: 0x004843F8 File Offset: 0x004825F8
		public IElementalBoxStatePlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009481 RID: 38017
		// (get) Token: 0x060208FB RID: 133371 RVA: 0x00484408 File Offset: 0x00482608
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

		// Token: 0x17009482 RID: 38018
		// (get) Token: 0x060208FC RID: 133372 RVA: 0x00484444 File Offset: 0x00482644
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

		// Token: 0x060208FD RID: 133373 RVA: 0x0048447B File Offset: 0x0048267B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060208FE RID: 133374 RVA: 0x0048448A File Offset: 0x0048268A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060208FF RID: 133375 RVA: 0x00484498 File Offset: 0x00482698
		public static Offset<IElementalBoxStatePlayerTarget> CreateIElementalBoxStatePlayerTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IElementalBoxStatePlayerTarget.AddState(builder, StateOffset);
			IElementalBoxStatePlayerTarget.AddType(builder, Type);
			return IElementalBoxStatePlayerTarget.EndIElementalBoxStatePlayerTarget(builder);
		}

		// Token: 0x06020900 RID: 133376 RVA: 0x004844B5 File Offset: 0x004826B5
		public static void StartIElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020901 RID: 133377 RVA: 0x004844BE File Offset: 0x004826BE
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020902 RID: 133378 RVA: 0x004844C9 File Offset: 0x004826C9
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06020903 RID: 133379 RVA: 0x004844D9 File Offset: 0x004826D9
		public static Offset<IElementalBoxStatePlayerTarget> EndIElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStatePlayerTarget>(builder.EndTable());
		}

		// Token: 0x06020904 RID: 133380 RVA: 0x004844E8 File Offset: 0x004826E8
		public IElementalBoxStatePlayerTargetT UnPack()
		{
			IElementalBoxStatePlayerTargetT elementalBoxStatePlayerTargetT = new IElementalBoxStatePlayerTargetT();
			this.UnPackTo(elementalBoxStatePlayerTargetT);
			return elementalBoxStatePlayerTargetT;
		}

		// Token: 0x06020905 RID: 133381 RVA: 0x00484503 File Offset: 0x00482703
		public void UnPackTo(IElementalBoxStatePlayerTargetT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06020906 RID: 133382 RVA: 0x00484520 File Offset: 0x00482720
		public static Offset<IElementalBoxStatePlayerTarget> Pack(FlatBufferBuilder builder, IElementalBoxStatePlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStatePlayerTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStatePlayerTarget.CreateIElementalBoxStatePlayerTarget(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400E0A9 RID: 57513
		private Table __p;
	}
}
