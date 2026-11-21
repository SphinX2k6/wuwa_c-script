using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B59 RID: 19289
	public struct IGameCurrBreakNodeInfo : IFlatbufferObject
	{
		// Token: 0x17008814 RID: 34836
		// (get) Token: 0x0601D486 RID: 119942 RVA: 0x0041CC40 File Offset: 0x0041AE40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D487 RID: 119943 RVA: 0x0041CC4D File Offset: 0x0041AE4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D488 RID: 119944 RVA: 0x0041CC54 File Offset: 0x0041AE54
		public static IGameCurrBreakNodeInfo GetRootAsIGameCurrBreakNodeInfo(ByteBuffer _bb)
		{
			return IGameCurrBreakNodeInfo.GetRootAsIGameCurrBreakNodeInfo(_bb, default(IGameCurrBreakNodeInfo));
		}

		// Token: 0x0601D489 RID: 119945 RVA: 0x0041CC70 File Offset: 0x0041AE70
		public static IGameCurrBreakNodeInfo GetRootAsIGameCurrBreakNodeInfo(ByteBuffer _bb, IGameCurrBreakNodeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D48A RID: 119946 RVA: 0x0041CC8D File Offset: 0x0041AE8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D48B RID: 119947 RVA: 0x0041CC9C File Offset: 0x0041AE9C
		public IGameCurrBreakNodeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008815 RID: 34837
		// (get) Token: 0x0601D48C RID: 119948 RVA: 0x0041CCAC File Offset: 0x0041AEAC
		public int Id
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

		// Token: 0x17008816 RID: 34838
		// (get) Token: 0x0601D48D RID: 119949 RVA: 0x0041CCE8 File Offset: 0x0041AEE8
		public ENodeBreakMoment BreakMoment
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ENodeBreakMoment.Null;
				}
				return (ENodeBreakMoment)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D48E RID: 119950 RVA: 0x0041CD24 File Offset: 0x0041AF24
		public IGameCurrBreakNodeInfo_RefVars? RefVars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGameCurrBreakNodeInfo_RefVars?(default(IGameCurrBreakNodeInfo_RefVars).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008817 RID: 34839
		// (get) Token: 0x0601D48F RID: 119951 RVA: 0x0041CD84 File Offset: 0x0041AF84
		public int RefVarsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D490 RID: 119952 RVA: 0x0041CDAF File Offset: 0x0041AFAF
		public static Offset<IGameCurrBreakNodeInfo> CreateIGameCurrBreakNodeInfo(FlatBufferBuilder builder, int Id = 0, ENodeBreakMoment BreakMoment = ENodeBreakMoment.Null, VectorOffset RefVarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGameCurrBreakNodeInfo.AddRefVars(builder, RefVarsOffset);
			IGameCurrBreakNodeInfo.AddId(builder, Id);
			IGameCurrBreakNodeInfo.AddBreakMoment(builder, BreakMoment);
			return IGameCurrBreakNodeInfo.EndIGameCurrBreakNodeInfo(builder);
		}

		// Token: 0x0601D491 RID: 119953 RVA: 0x0041CDD3 File Offset: 0x0041AFD3
		public static void StartIGameCurrBreakNodeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D492 RID: 119954 RVA: 0x0041CDDC File Offset: 0x0041AFDC
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D493 RID: 119955 RVA: 0x0041CDE7 File Offset: 0x0041AFE7
		public static void AddBreakMoment(FlatBufferBuilder builder, ENodeBreakMoment breakMoment)
		{
			builder.AddByte(1, (byte)breakMoment, 0);
		}

		// Token: 0x0601D494 RID: 119956 RVA: 0x0041CDF2 File Offset: 0x0041AFF2
		public static void AddRefVars(FlatBufferBuilder builder, VectorOffset refVarsOffset)
		{
			builder.AddOffset(2, refVarsOffset.Value, 0);
		}

		// Token: 0x0601D495 RID: 119957 RVA: 0x0041CE04 File Offset: 0x0041B004
		public static VectorOffset CreateRefVarsVector(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeInfo_RefVars>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D496 RID: 119958 RVA: 0x0041CE44 File Offset: 0x0041B044
		public static VectorOffset CreateRefVarsVectorBlock(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeInfo_RefVars>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGameCurrBreakNodeInfo_RefVars>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D497 RID: 119959 RVA: 0x0041CE5E File Offset: 0x0041B05E
		public static VectorOffset CreateRefVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGameCurrBreakNodeInfo_RefVars>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGameCurrBreakNodeInfo_RefVars>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D498 RID: 119960 RVA: 0x0041CE7C File Offset: 0x0041B07C
		public static VectorOffset CreateRefVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGameCurrBreakNodeInfo_RefVars>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D499 RID: 119961 RVA: 0x0041CE95 File Offset: 0x0041B095
		public static void StartRefVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D49A RID: 119962 RVA: 0x0041CEA0 File Offset: 0x0041B0A0
		public static Offset<IGameCurrBreakNodeInfo> EndIGameCurrBreakNodeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IGameCurrBreakNodeInfo>(builder.EndTable());
		}

		// Token: 0x0601D49B RID: 119963 RVA: 0x0041CEB0 File Offset: 0x0041B0B0
		public IGameCurrBreakNodeInfoT UnPack()
		{
			IGameCurrBreakNodeInfoT gameCurrBreakNodeInfoT = new IGameCurrBreakNodeInfoT();
			this.UnPackTo(gameCurrBreakNodeInfoT);
			return gameCurrBreakNodeInfoT;
		}

		// Token: 0x0601D49C RID: 119964 RVA: 0x0041CECC File Offset: 0x0041B0CC
		public void UnPackTo(IGameCurrBreakNodeInfoT _o)
		{
			_o.Id = this.Id;
			_o.BreakMoment = this.BreakMoment;
			_o.RefVars = new List<IGameCurrBreakNodeInfo_RefVarsT>();
			for (int i = 0; i < this.RefVarsLength; i++)
			{
				_o.RefVars.Add((this.RefVars(i) != null) ? this.RefVars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D49D RID: 119965 RVA: 0x0041CF44 File Offset: 0x0041B144
		public static Offset<IGameCurrBreakNodeInfo> Pack(FlatBufferBuilder builder, IGameCurrBreakNodeInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameCurrBreakNodeInfo>);
			}
			VectorOffset refVarsOffset = default(VectorOffset);
			if (_o.RefVars != null)
			{
				Offset<IGameCurrBreakNodeInfo_RefVars>[] array = new Offset<IGameCurrBreakNodeInfo_RefVars>[_o.RefVars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGameCurrBreakNodeInfo_RefVars.Pack(builder, _o.RefVars[i]);
				}
				refVarsOffset = IGameCurrBreakNodeInfo.CreateRefVarsVector(builder, array);
			}
			return IGameCurrBreakNodeInfo.CreateIGameCurrBreakNodeInfo(builder, _o.Id, _o.BreakMoment, refVarsOffset);
		}

		// Token: 0x0400D3C9 RID: 54217
		private Table __p;
	}
}
