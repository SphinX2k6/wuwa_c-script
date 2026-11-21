using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA7 RID: 27815
	public struct IElementalBoxTargetPrefabPos : IFlatbufferObject
	{
		// Token: 0x1700CBFF RID: 52223
		// (get) Token: 0x0602FED0 RID: 196304 RVA: 0x006861DC File Offset: 0x006843DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FED1 RID: 196305 RVA: 0x006861E9 File Offset: 0x006843E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FED2 RID: 196306 RVA: 0x006861F0 File Offset: 0x006843F0
		public static IElementalBoxTargetPrefabPos GetRootAsIElementalBoxTargetPrefabPos(ByteBuffer _bb)
		{
			return IElementalBoxTargetPrefabPos.GetRootAsIElementalBoxTargetPrefabPos(_bb, default(IElementalBoxTargetPrefabPos));
		}

		// Token: 0x0602FED3 RID: 196307 RVA: 0x0068620C File Offset: 0x0068440C
		public static IElementalBoxTargetPrefabPos GetRootAsIElementalBoxTargetPrefabPos(ByteBuffer _bb, IElementalBoxTargetPrefabPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FED4 RID: 196308 RVA: 0x00686229 File Offset: 0x00684429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FED5 RID: 196309 RVA: 0x00686238 File Offset: 0x00684438
		public IElementalBoxTargetPrefabPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC00 RID: 52224
		// (get) Token: 0x0602FED6 RID: 196310 RVA: 0x00686248 File Offset: 0x00684448
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

		// Token: 0x1700CC01 RID: 52225
		// (get) Token: 0x0602FED7 RID: 196311 RVA: 0x00686284 File Offset: 0x00684484
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

		// Token: 0x0602FED8 RID: 196312 RVA: 0x006862BB File Offset: 0x006844BB
		public Span<byte> GetTargetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602FED9 RID: 196313 RVA: 0x006862CA File Offset: 0x006844CA
		public byte[] GetTargetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602FEDA RID: 196314 RVA: 0x006862D8 File Offset: 0x006844D8
		public static Offset<IElementalBoxTargetPrefabPos> CreateIElementalBoxTargetPrefabPos(FlatBufferBuilder builder, EElementalBoxTargetPosType Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos, StringOffset TargetKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IElementalBoxTargetPrefabPos.AddTargetKey(builder, TargetKeyOffset);
			IElementalBoxTargetPrefabPos.AddType(builder, Type);
			return IElementalBoxTargetPrefabPos.EndIElementalBoxTargetPrefabPos(builder);
		}

		// Token: 0x0602FEDB RID: 196315 RVA: 0x006862F5 File Offset: 0x006844F5
		public static void StartIElementalBoxTargetPrefabPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FEDC RID: 196316 RVA: 0x006862FE File Offset: 0x006844FE
		public static void AddType(FlatBufferBuilder builder, EElementalBoxTargetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FEDD RID: 196317 RVA: 0x00686309 File Offset: 0x00684509
		public static void AddTargetKey(FlatBufferBuilder builder, StringOffset targetKeyOffset)
		{
			builder.AddOffset(1, targetKeyOffset.Value, 0);
		}

		// Token: 0x0602FEDE RID: 196318 RVA: 0x00686319 File Offset: 0x00684519
		public static Offset<IElementalBoxTargetPrefabPos> EndIElementalBoxTargetPrefabPos(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxTargetPrefabPos>(builder.EndTable());
		}

		// Token: 0x0602FEDF RID: 196319 RVA: 0x00686328 File Offset: 0x00684528
		public IElementalBoxTargetPrefabPosT UnPack()
		{
			IElementalBoxTargetPrefabPosT elementalBoxTargetPrefabPosT = new IElementalBoxTargetPrefabPosT();
			this.UnPackTo(elementalBoxTargetPrefabPosT);
			return elementalBoxTargetPrefabPosT;
		}

		// Token: 0x0602FEE0 RID: 196320 RVA: 0x00686343 File Offset: 0x00684543
		public void UnPackTo(IElementalBoxTargetPrefabPosT _o)
		{
			_o.Type = this.Type;
			_o.TargetKey = this.TargetKey;
		}

		// Token: 0x0602FEE1 RID: 196321 RVA: 0x00686360 File Offset: 0x00684560
		public static Offset<IElementalBoxTargetPrefabPos> Pack(FlatBufferBuilder builder, IElementalBoxTargetPrefabPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxTargetPrefabPos>);
			}
			StringOffset targetKeyOffset = (_o.TargetKey == null) ? default(StringOffset) : builder.CreateString(_o.TargetKey);
			return IElementalBoxTargetPrefabPos.CreateIElementalBoxTargetPrefabPos(builder, _o.Type, targetKeyOffset);
		}

		// Token: 0x04011AE7 RID: 72423
		private Table __p;
	}
}
