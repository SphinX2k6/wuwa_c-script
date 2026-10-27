using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006636 RID: 26166
	public struct IElementalBoxTargetPrefabPos : IFlatbufferObject
	{
		// Token: 0x1700C261 RID: 49761
		// (get) Token: 0x0602D6FF RID: 186111 RVA: 0x00639674 File Offset: 0x00637874
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D700 RID: 186112 RVA: 0x00639681 File Offset: 0x00637881
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D701 RID: 186113 RVA: 0x00639688 File Offset: 0x00637888
		public static IElementalBoxTargetPrefabPos GetRootAsIElementalBoxTargetPrefabPos(ByteBuffer _bb)
		{
			return IElementalBoxTargetPrefabPos.GetRootAsIElementalBoxTargetPrefabPos(_bb, default(IElementalBoxTargetPrefabPos));
		}

		// Token: 0x0602D702 RID: 186114 RVA: 0x006396A4 File Offset: 0x006378A4
		public static IElementalBoxTargetPrefabPos GetRootAsIElementalBoxTargetPrefabPos(ByteBuffer _bb, IElementalBoxTargetPrefabPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D703 RID: 186115 RVA: 0x006396C1 File Offset: 0x006378C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D704 RID: 186116 RVA: 0x006396D0 File Offset: 0x006378D0
		public IElementalBoxTargetPrefabPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C262 RID: 49762
		// (get) Token: 0x0602D705 RID: 186117 RVA: 0x006396E0 File Offset: 0x006378E0
		public EElementalBoxTargetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				}
				return (EElementalBoxTargetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C263 RID: 49763
		// (get) Token: 0x0602D706 RID: 186118 RVA: 0x0063971C File Offset: 0x0063791C
		public string TargetKey
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

		// Token: 0x0602D707 RID: 186119 RVA: 0x00639753 File Offset: 0x00637953
		public Span<byte> GetTargetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602D708 RID: 186120 RVA: 0x00639762 File Offset: 0x00637962
		public byte[] GetTargetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602D709 RID: 186121 RVA: 0x00639770 File Offset: 0x00637970
		public static Offset<IElementalBoxTargetPrefabPos> CreateIElementalBoxTargetPrefabPos(FlatBufferBuilder builder, EElementalBoxTargetPosType Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos, StringOffset TargetKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IElementalBoxTargetPrefabPos.AddTargetKey(builder, TargetKeyOffset);
			IElementalBoxTargetPrefabPos.AddType(builder, Type);
			return IElementalBoxTargetPrefabPos.EndIElementalBoxTargetPrefabPos(builder);
		}

		// Token: 0x0602D70A RID: 186122 RVA: 0x0063978D File Offset: 0x0063798D
		public static void StartIElementalBoxTargetPrefabPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D70B RID: 186123 RVA: 0x00639796 File Offset: 0x00637996
		public static void AddType(FlatBufferBuilder builder, EElementalBoxTargetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D70C RID: 186124 RVA: 0x006397A1 File Offset: 0x006379A1
		public static void AddTargetKey(FlatBufferBuilder builder, StringOffset targetKeyOffset)
		{
			builder.AddOffset(1, targetKeyOffset.Value, 0);
		}

		// Token: 0x0602D70D RID: 186125 RVA: 0x006397B1 File Offset: 0x006379B1
		public static Offset<IElementalBoxTargetPrefabPos> EndIElementalBoxTargetPrefabPos(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxTargetPrefabPos>(builder.EndTable());
		}

		// Token: 0x0602D70E RID: 186126 RVA: 0x006397C0 File Offset: 0x006379C0
		public IElementalBoxTargetPrefabPosT UnPack()
		{
			IElementalBoxTargetPrefabPosT elementalBoxTargetPrefabPosT = new IElementalBoxTargetPrefabPosT();
			this.UnPackTo(elementalBoxTargetPrefabPosT);
			return elementalBoxTargetPrefabPosT;
		}

		// Token: 0x0602D70F RID: 186127 RVA: 0x006397DB File Offset: 0x006379DB
		public void UnPackTo(IElementalBoxTargetPrefabPosT _o)
		{
			_o.Type = this.Type;
			_o.TargetKey = this.TargetKey;
		}

		// Token: 0x0602D710 RID: 186128 RVA: 0x006397F8 File Offset: 0x006379F8
		public static Offset<IElementalBoxTargetPrefabPos> Pack(FlatBufferBuilder builder, IElementalBoxTargetPrefabPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxTargetPrefabPos>);
			}
			StringOffset targetKeyOffset = (_o.TargetKey == null) ? default(StringOffset) : builder.CreateString(_o.TargetKey);
			return IElementalBoxTargetPrefabPos.CreateIElementalBoxTargetPrefabPos(builder, _o.Type, targetKeyOffset);
		}

		// Token: 0x04010CCC RID: 68812
		private Table __p;
	}
}
