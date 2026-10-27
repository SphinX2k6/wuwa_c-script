using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E21 RID: 15905
	public struct IFastReturnMapPos : IFlatbufferObject
	{
		// Token: 0x17006DF7 RID: 28151
		// (get) Token: 0x06016477 RID: 91255 RVA: 0x00337868 File Offset: 0x00335A68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016478 RID: 91256 RVA: 0x00337875 File Offset: 0x00335A75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016479 RID: 91257 RVA: 0x0033787C File Offset: 0x00335A7C
		public static IFastReturnMapPos GetRootAsIFastReturnMapPos(ByteBuffer _bb)
		{
			return IFastReturnMapPos.GetRootAsIFastReturnMapPos(_bb, default(IFastReturnMapPos));
		}

		// Token: 0x0601647A RID: 91258 RVA: 0x00337898 File Offset: 0x00335A98
		public static IFastReturnMapPos GetRootAsIFastReturnMapPos(ByteBuffer _bb, IFastReturnMapPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601647B RID: 91259 RVA: 0x003378B5 File Offset: 0x00335AB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601647C RID: 91260 RVA: 0x003378C4 File Offset: 0x00335AC4
		public IFastReturnMapPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DF8 RID: 28152
		// (get) Token: 0x0601647D RID: 91261 RVA: 0x003378D4 File Offset: 0x00335AD4
		public string TidTip
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601647E RID: 91262 RVA: 0x0033790B File Offset: 0x00335B0B
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601647F RID: 91263 RVA: 0x0033791A File Offset: 0x00335B1A
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06016480 RID: 91264 RVA: 0x00337928 File Offset: 0x00335B28
		public IConditionGroup? ShowButtonConditionGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006DF9 RID: 28153
		// (get) Token: 0x06016481 RID: 91265 RVA: 0x00337988 File Offset: 0x00335B88
		public int ShowButtonConditionGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006DFA RID: 28154
		// (get) Token: 0x06016482 RID: 91266 RVA: 0x003379B4 File Offset: 0x00335BB4
		public TFastReturnPos DefaultPosType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TFastReturnPos.NONE;
				}
				return (TFastReturnPos)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016483 RID: 91267 RVA: 0x003379F0 File Offset: 0x00335BF0
		public TTable? DefaultPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016484 RID: 91268 RVA: 0x00337A38 File Offset: 0x00335C38
		public IFastReturnEntityPos DefaultPosAsIFastReturnEntityPos()
		{
			return this.DefaultPos<IFastReturnEntityPos>().Value;
		}

		// Token: 0x06016485 RID: 91269 RVA: 0x00337A54 File Offset: 0x00335C54
		public IFastReturnGravityEntityPos DefaultPosAsIFastReturnGravityEntityPos()
		{
			return this.DefaultPos<IFastReturnGravityEntityPos>().Value;
		}

		// Token: 0x06016486 RID: 91270 RVA: 0x00337A70 File Offset: 0x00335C70
		public IConditionReturnPos? ConditionPositionGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IConditionReturnPos?(default(IConditionReturnPos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006DFB RID: 28155
		// (get) Token: 0x06016487 RID: 91271 RVA: 0x00337AD4 File Offset: 0x00335CD4
		public int ConditionPositionGroupLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006DFC RID: 28156
		// (get) Token: 0x06016488 RID: 91272 RVA: 0x00337B00 File Offset: 0x00335D00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016489 RID: 91273 RVA: 0x00337B3D File Offset: 0x00335D3D
		public static Offset<IFastReturnMapPos> CreateIFastReturnMapPos(FlatBufferBuilder builder, StringOffset TidTipOffset = default(StringOffset), VectorOffset ShowButtonConditionGroupOffset = default(VectorOffset), TFastReturnPos DefaultPos_type = TFastReturnPos.NONE, int DefaultPosOffset = 0, VectorOffset ConditionPositionGroupOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFastReturnMapPos.AddConditionPositionGroup(builder, ConditionPositionGroupOffset);
			IFastReturnMapPos.AddDefaultPos(builder, DefaultPosOffset);
			IFastReturnMapPos.AddShowButtonConditionGroup(builder, ShowButtonConditionGroupOffset);
			IFastReturnMapPos.AddTidTip(builder, TidTipOffset);
			IFastReturnMapPos.AddNullMask(builder, NullMask);
			IFastReturnMapPos.AddDefaultPosType(builder, DefaultPos_type);
			return IFastReturnMapPos.EndIFastReturnMapPos(builder);
		}

		// Token: 0x0601648A RID: 91274 RVA: 0x00337B79 File Offset: 0x00335D79
		public static void StartIFastReturnMapPos(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601648B RID: 91275 RVA: 0x00337B82 File Offset: 0x00335D82
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x0601648C RID: 91276 RVA: 0x00337B92 File Offset: 0x00335D92
		public static void AddShowButtonConditionGroup(FlatBufferBuilder builder, VectorOffset showButtonConditionGroupOffset)
		{
			builder.AddOffset(1, showButtonConditionGroupOffset.Value, 0);
		}

		// Token: 0x0601648D RID: 91277 RVA: 0x00337BA4 File Offset: 0x00335DA4
		public static VectorOffset CreateShowButtonConditionGroupVector(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601648E RID: 91278 RVA: 0x00337BE4 File Offset: 0x00335DE4
		public static VectorOffset CreateShowButtonConditionGroupVectorBlock(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601648F RID: 91279 RVA: 0x00337BFE File Offset: 0x00335DFE
		public static VectorOffset CreateShowButtonConditionGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016490 RID: 91280 RVA: 0x00337C1C File Offset: 0x00335E1C
		public static VectorOffset CreateShowButtonConditionGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016491 RID: 91281 RVA: 0x00337C35 File Offset: 0x00335E35
		public static void StartShowButtonConditionGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016492 RID: 91282 RVA: 0x00337C40 File Offset: 0x00335E40
		public static void AddDefaultPosType(FlatBufferBuilder builder, TFastReturnPos defaultPosType)
		{
			builder.AddByte(2, (byte)defaultPosType, 0);
		}

		// Token: 0x06016493 RID: 91283 RVA: 0x00337C4B File Offset: 0x00335E4B
		public static void AddDefaultPos(FlatBufferBuilder builder, int defaultPosOffset)
		{
			builder.AddOffset(3, defaultPosOffset, 0);
		}

		// Token: 0x06016494 RID: 91284 RVA: 0x00337C56 File Offset: 0x00335E56
		public static void AddConditionPositionGroup(FlatBufferBuilder builder, VectorOffset conditionPositionGroupOffset)
		{
			builder.AddOffset(4, conditionPositionGroupOffset.Value, 0);
		}

		// Token: 0x06016495 RID: 91285 RVA: 0x00337C68 File Offset: 0x00335E68
		public static VectorOffset CreateConditionPositionGroupVector(FlatBufferBuilder builder, Offset<IConditionReturnPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016496 RID: 91286 RVA: 0x00337CA8 File Offset: 0x00335EA8
		public static VectorOffset CreateConditionPositionGroupVectorBlock(FlatBufferBuilder builder, Offset<IConditionReturnPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionReturnPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016497 RID: 91287 RVA: 0x00337CC2 File Offset: 0x00335EC2
		public static VectorOffset CreateConditionPositionGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionReturnPos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionReturnPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016498 RID: 91288 RVA: 0x00337CE0 File Offset: 0x00335EE0
		public static VectorOffset CreateConditionPositionGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionReturnPos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016499 RID: 91289 RVA: 0x00337CF9 File Offset: 0x00335EF9
		public static void StartConditionPositionGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601649A RID: 91290 RVA: 0x00337D04 File Offset: 0x00335F04
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601649B RID: 91291 RVA: 0x00337D0F File Offset: 0x00335F0F
		public static Offset<IFastReturnMapPos> EndIFastReturnMapPos(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnMapPos>(builder.EndTable());
		}

		// Token: 0x0601649C RID: 91292 RVA: 0x00337D1C File Offset: 0x00335F1C
		public IFastReturnMapPosT UnPack()
		{
			IFastReturnMapPosT fastReturnMapPosT = new IFastReturnMapPosT();
			this.UnPackTo(fastReturnMapPosT);
			return fastReturnMapPosT;
		}

		// Token: 0x0601649D RID: 91293 RVA: 0x00337D38 File Offset: 0x00335F38
		public void UnPackTo(IFastReturnMapPosT _o)
		{
			_o.TidTip = this.TidTip;
			_o.ShowButtonConditionGroup = new List<IConditionGroupT>();
			for (int i = 0; i < this.ShowButtonConditionGroupLength; i++)
			{
				_o.ShowButtonConditionGroup.Add((this.ShowButtonConditionGroup(i) != null) ? this.ShowButtonConditionGroup(i).Value.UnPack() : null);
			}
			_o.DefaultPos = new TFastReturnPosUnion();
			_o.DefaultPos.Type = this.DefaultPosType;
			TFastReturnPos defaultPosType = this.DefaultPosType;
			if (defaultPosType != TFastReturnPos.IFastReturnEntityPos)
			{
				if (defaultPosType == TFastReturnPos.IFastReturnGravityEntityPos)
				{
					_o.DefaultPos.Value = ((this.DefaultPos<IFastReturnGravityEntityPos>() != null) ? this.DefaultPos<IFastReturnGravityEntityPos>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DefaultPos.Value = ((this.DefaultPos<IFastReturnEntityPos>() != null) ? this.DefaultPos<IFastReturnEntityPos>().Value.UnPack() : null);
			}
			_o.ConditionPositionGroup = new List<IConditionReturnPosT>();
			for (int j = 0; j < this.ConditionPositionGroupLength; j++)
			{
				_o.ConditionPositionGroup.Add((this.ConditionPositionGroup(j) != null) ? this.ConditionPositionGroup(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601649E RID: 91294 RVA: 0x00337EA8 File Offset: 0x003360A8
		public static Offset<IFastReturnMapPos> Pack(FlatBufferBuilder builder, IFastReturnMapPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFastReturnMapPos>);
			}
			StringOffset tidTipOffset = (_o.TidTip == null) ? default(StringOffset) : builder.CreateString(_o.TidTip);
			VectorOffset showButtonConditionGroupOffset = default(VectorOffset);
			if (_o.ShowButtonConditionGroup != null)
			{
				Offset<IConditionGroup>[] array = new Offset<IConditionGroup>[_o.ShowButtonConditionGroup.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionGroup.Pack(builder, _o.ShowButtonConditionGroup[i]);
				}
				showButtonConditionGroupOffset = IFastReturnMapPos.CreateShowButtonConditionGroupVector(builder, array);
			}
			TFastReturnPos defaultPos_type = (_o.DefaultPos == null) ? TFastReturnPos.NONE : _o.DefaultPos.Type;
			int defaultPosOffset = (_o.DefaultPos == null) ? 0 : TFastReturnPosUnion.Pack(builder, _o.DefaultPos);
			VectorOffset conditionPositionGroupOffset = default(VectorOffset);
			if (_o.ConditionPositionGroup != null)
			{
				Offset<IConditionReturnPos>[] array2 = new Offset<IConditionReturnPos>[_o.ConditionPositionGroup.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionReturnPos.Pack(builder, _o.ConditionPositionGroup[j]);
				}
				conditionPositionGroupOffset = IFastReturnMapPos.CreateConditionPositionGroupVector(builder, array2);
			}
			return IFastReturnMapPos.CreateIFastReturnMapPos(builder, tidTipOffset, showButtonConditionGroupOffset, defaultPos_type, defaultPosOffset, conditionPositionGroupOffset, _o.NullMask);
		}

		// Token: 0x0400B79F RID: 47007
		private Table __p;
	}
}
