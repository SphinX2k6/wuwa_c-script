using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C04 RID: 19460
	public struct IElementalBoxStatePlayerTarget : IFlatbufferObject
	{
		// Token: 0x17008D5C RID: 36188
		// (get) Token: 0x0601ED0F RID: 126223 RVA: 0x00450D32 File Offset: 0x0044EF32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED10 RID: 126224 RVA: 0x00450D3F File Offset: 0x0044EF3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED11 RID: 126225 RVA: 0x00450D48 File Offset: 0x0044EF48
		public static IElementalBoxStatePlayerTarget GetRootAsIElementalBoxStatePlayerTarget(ByteBuffer _bb)
		{
			return IElementalBoxStatePlayerTarget.GetRootAsIElementalBoxStatePlayerTarget(_bb, default(IElementalBoxStatePlayerTarget));
		}

		// Token: 0x0601ED12 RID: 126226 RVA: 0x00450D64 File Offset: 0x0044EF64
		public static IElementalBoxStatePlayerTarget GetRootAsIElementalBoxStatePlayerTarget(ByteBuffer _bb, IElementalBoxStatePlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED13 RID: 126227 RVA: 0x00450D81 File Offset: 0x0044EF81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED14 RID: 126228 RVA: 0x00450D90 File Offset: 0x0044EF90
		public IElementalBoxStatePlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D5D RID: 36189
		// (get) Token: 0x0601ED15 RID: 126229 RVA: 0x00450DA0 File Offset: 0x0044EFA0
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

		// Token: 0x17008D5E RID: 36190
		// (get) Token: 0x0601ED16 RID: 126230 RVA: 0x00450DDC File Offset: 0x0044EFDC
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

		// Token: 0x0601ED17 RID: 126231 RVA: 0x00450E13 File Offset: 0x0044F013
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ED18 RID: 126232 RVA: 0x00450E22 File Offset: 0x0044F022
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ED19 RID: 126233 RVA: 0x00450E30 File Offset: 0x0044F030
		public static Offset<IElementalBoxStatePlayerTarget> CreateIElementalBoxStatePlayerTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IElementalBoxStatePlayerTarget.AddState(builder, StateOffset);
			IElementalBoxStatePlayerTarget.AddType(builder, Type);
			return IElementalBoxStatePlayerTarget.EndIElementalBoxStatePlayerTarget(builder);
		}

		// Token: 0x0601ED1A RID: 126234 RVA: 0x00450E4D File Offset: 0x0044F04D
		public static void StartIElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ED1B RID: 126235 RVA: 0x00450E56 File Offset: 0x0044F056
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED1C RID: 126236 RVA: 0x00450E61 File Offset: 0x0044F061
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601ED1D RID: 126237 RVA: 0x00450E71 File Offset: 0x0044F071
		public static Offset<IElementalBoxStatePlayerTarget> EndIElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStatePlayerTarget>(builder.EndTable());
		}

		// Token: 0x0601ED1E RID: 126238 RVA: 0x00450E80 File Offset: 0x0044F080
		public IElementalBoxStatePlayerTargetT UnPack()
		{
			IElementalBoxStatePlayerTargetT elementalBoxStatePlayerTargetT = new IElementalBoxStatePlayerTargetT();
			this.UnPackTo(elementalBoxStatePlayerTargetT);
			return elementalBoxStatePlayerTargetT;
		}

		// Token: 0x0601ED1F RID: 126239 RVA: 0x00450E9B File Offset: 0x0044F09B
		public void UnPackTo(IElementalBoxStatePlayerTargetT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0601ED20 RID: 126240 RVA: 0x00450EB8 File Offset: 0x0044F0B8
		public static Offset<IElementalBoxStatePlayerTarget> Pack(FlatBufferBuilder builder, IElementalBoxStatePlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStatePlayerTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStatePlayerTarget.CreateIElementalBoxStatePlayerTarget(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400D592 RID: 54674
		private Table __p;
	}
}
