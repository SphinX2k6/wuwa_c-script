using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BFE RID: 19454
	public struct IElementalBoxStateFoundationSelfTarget : IFlatbufferObject
	{
		// Token: 0x17008D50 RID: 36176
		// (get) Token: 0x0601ECDB RID: 126171 RVA: 0x00450848 File Offset: 0x0044EA48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ECDC RID: 126172 RVA: 0x00450855 File Offset: 0x0044EA55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ECDD RID: 126173 RVA: 0x0045085C File Offset: 0x0044EA5C
		public static IElementalBoxStateFoundationSelfTarget GetRootAsIElementalBoxStateFoundationSelfTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateFoundationSelfTarget.GetRootAsIElementalBoxStateFoundationSelfTarget(_bb, default(IElementalBoxStateFoundationSelfTarget));
		}

		// Token: 0x0601ECDE RID: 126174 RVA: 0x00450878 File Offset: 0x0044EA78
		public static IElementalBoxStateFoundationSelfTarget GetRootAsIElementalBoxStateFoundationSelfTarget(ByteBuffer _bb, IElementalBoxStateFoundationSelfTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ECDF RID: 126175 RVA: 0x00450895 File Offset: 0x0044EA95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ECE0 RID: 126176 RVA: 0x004508A4 File Offset: 0x0044EAA4
		public IElementalBoxStateFoundationSelfTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D51 RID: 36177
		// (get) Token: 0x0601ECE1 RID: 126177 RVA: 0x004508B4 File Offset: 0x0044EAB4
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

		// Token: 0x17008D52 RID: 36178
		// (get) Token: 0x0601ECE2 RID: 126178 RVA: 0x004508F0 File Offset: 0x0044EAF0
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

		// Token: 0x0601ECE3 RID: 126179 RVA: 0x00450927 File Offset: 0x0044EB27
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ECE4 RID: 126180 RVA: 0x00450936 File Offset: 0x0044EB36
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ECE5 RID: 126181 RVA: 0x00450944 File Offset: 0x0044EB44
		public static Offset<IElementalBoxStateFoundationSelfTarget> CreateIElementalBoxStateFoundationSelfTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IElementalBoxStateFoundationSelfTarget.AddState(builder, StateOffset);
			IElementalBoxStateFoundationSelfTarget.AddType(builder, Type);
			return IElementalBoxStateFoundationSelfTarget.EndIElementalBoxStateFoundationSelfTarget(builder);
		}

		// Token: 0x0601ECE6 RID: 126182 RVA: 0x00450961 File Offset: 0x0044EB61
		public static void StartIElementalBoxStateFoundationSelfTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ECE7 RID: 126183 RVA: 0x0045096A File Offset: 0x0044EB6A
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ECE8 RID: 126184 RVA: 0x00450975 File Offset: 0x0044EB75
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601ECE9 RID: 126185 RVA: 0x00450985 File Offset: 0x0044EB85
		public static Offset<IElementalBoxStateFoundationSelfTarget> EndIElementalBoxStateFoundationSelfTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateFoundationSelfTarget>(builder.EndTable());
		}

		// Token: 0x0601ECEA RID: 126186 RVA: 0x00450994 File Offset: 0x0044EB94
		public IElementalBoxStateFoundationSelfTargetT UnPack()
		{
			IElementalBoxStateFoundationSelfTargetT elementalBoxStateFoundationSelfTargetT = new IElementalBoxStateFoundationSelfTargetT();
			this.UnPackTo(elementalBoxStateFoundationSelfTargetT);
			return elementalBoxStateFoundationSelfTargetT;
		}

		// Token: 0x0601ECEB RID: 126187 RVA: 0x004509AF File Offset: 0x0044EBAF
		public void UnPackTo(IElementalBoxStateFoundationSelfTargetT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0601ECEC RID: 126188 RVA: 0x004509CC File Offset: 0x0044EBCC
		public static Offset<IElementalBoxStateFoundationSelfTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateFoundationSelfTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateFoundationSelfTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStateFoundationSelfTarget.CreateIElementalBoxStateFoundationSelfTarget(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400D58B RID: 54667
		private Table __p;
	}
}
