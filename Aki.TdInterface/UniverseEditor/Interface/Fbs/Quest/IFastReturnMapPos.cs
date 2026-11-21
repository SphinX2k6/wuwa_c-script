using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425C RID: 16988
	public struct IFastReturnMapPos : IFlatbufferObject
	{
		// Token: 0x170073DD RID: 29661
		// (get) Token: 0x06017AA4 RID: 96932 RVA: 0x00360460 File Offset: 0x0035E660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017AA5 RID: 96933 RVA: 0x0036046D File Offset: 0x0035E66D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017AA6 RID: 96934 RVA: 0x00360474 File Offset: 0x0035E674
		public static IFastReturnMapPos GetRootAsIFastReturnMapPos(ByteBuffer _bb)
		{
			return IFastReturnMapPos.GetRootAsIFastReturnMapPos(_bb, default(IFastReturnMapPos));
		}

		// Token: 0x06017AA7 RID: 96935 RVA: 0x00360490 File Offset: 0x0035E690
		public static IFastReturnMapPos GetRootAsIFastReturnMapPos(ByteBuffer _bb, IFastReturnMapPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017AA8 RID: 96936 RVA: 0x003604AD File Offset: 0x0035E6AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017AA9 RID: 96937 RVA: 0x003604BC File Offset: 0x0035E6BC
		public IFastReturnMapPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073DE RID: 29662
		// (get) Token: 0x06017AAA RID: 96938 RVA: 0x003604CC File Offset: 0x0035E6CC
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

		// Token: 0x06017AAB RID: 96939 RVA: 0x00360503 File Offset: 0x0035E703
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06017AAC RID: 96940 RVA: 0x00360512 File Offset: 0x0035E712
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06017AAD RID: 96941 RVA: 0x00360520 File Offset: 0x0035E720
		public IConditionGroup? ShowButtonConditionGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170073DF RID: 29663
		// (get) Token: 0x06017AAE RID: 96942 RVA: 0x00360580 File Offset: 0x0035E780
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

		// Token: 0x170073E0 RID: 29664
		// (get) Token: 0x06017AAF RID: 96943 RVA: 0x003605AC File Offset: 0x0035E7AC
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

		// Token: 0x06017AB0 RID: 96944 RVA: 0x003605E8 File Offset: 0x0035E7E8
		public TTable? DefaultPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017AB1 RID: 96945 RVA: 0x00360630 File Offset: 0x0035E830
		public IFastReturnEntityPos DefaultPosAsIFastReturnEntityPos()
		{
			return this.DefaultPos<IFastReturnEntityPos>().Value;
		}

		// Token: 0x06017AB2 RID: 96946 RVA: 0x0036064C File Offset: 0x0035E84C
		public IFastReturnGravityEntityPos DefaultPosAsIFastReturnGravityEntityPos()
		{
			return this.DefaultPos<IFastReturnGravityEntityPos>().Value;
		}

		// Token: 0x06017AB3 RID: 96947 RVA: 0x00360668 File Offset: 0x0035E868
		public IConditionReturnPos? ConditionPositionGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IConditionReturnPos?(default(IConditionReturnPos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170073E1 RID: 29665
		// (get) Token: 0x06017AB4 RID: 96948 RVA: 0x003606CC File Offset: 0x0035E8CC
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

		// Token: 0x170073E2 RID: 29666
		// (get) Token: 0x06017AB5 RID: 96949 RVA: 0x003606F8 File Offset: 0x0035E8F8
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

		// Token: 0x06017AB6 RID: 96950 RVA: 0x00360735 File Offset: 0x0035E935
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

		// Token: 0x06017AB7 RID: 96951 RVA: 0x00360771 File Offset: 0x0035E971
		public static void StartIFastReturnMapPos(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017AB8 RID: 96952 RVA: 0x0036077A File Offset: 0x0035E97A
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x06017AB9 RID: 96953 RVA: 0x0036078A File Offset: 0x0035E98A
		public static void AddShowButtonConditionGroup(FlatBufferBuilder builder, VectorOffset showButtonConditionGroupOffset)
		{
			builder.AddOffset(1, showButtonConditionGroupOffset.Value, 0);
		}

		// Token: 0x06017ABA RID: 96954 RVA: 0x0036079C File Offset: 0x0035E99C
		public static VectorOffset CreateShowButtonConditionGroupVector(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017ABB RID: 96955 RVA: 0x003607DC File Offset: 0x0035E9DC
		public static VectorOffset CreateShowButtonConditionGroupVectorBlock(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017ABC RID: 96956 RVA: 0x003607F6 File Offset: 0x0035E9F6
		public static VectorOffset CreateShowButtonConditionGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017ABD RID: 96957 RVA: 0x00360814 File Offset: 0x0035EA14
		public static VectorOffset CreateShowButtonConditionGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017ABE RID: 96958 RVA: 0x0036082D File Offset: 0x0035EA2D
		public static void StartShowButtonConditionGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017ABF RID: 96959 RVA: 0x00360838 File Offset: 0x0035EA38
		public static void AddDefaultPosType(FlatBufferBuilder builder, TFastReturnPos defaultPosType)
		{
			builder.AddByte(2, (byte)defaultPosType, 0);
		}

		// Token: 0x06017AC0 RID: 96960 RVA: 0x00360843 File Offset: 0x0035EA43
		public static void AddDefaultPos(FlatBufferBuilder builder, int defaultPosOffset)
		{
			builder.AddOffset(3, defaultPosOffset, 0);
		}

		// Token: 0x06017AC1 RID: 96961 RVA: 0x0036084E File Offset: 0x0035EA4E
		public static void AddConditionPositionGroup(FlatBufferBuilder builder, VectorOffset conditionPositionGroupOffset)
		{
			builder.AddOffset(4, conditionPositionGroupOffset.Value, 0);
		}

		// Token: 0x06017AC2 RID: 96962 RVA: 0x00360860 File Offset: 0x0035EA60
		public static VectorOffset CreateConditionPositionGroupVector(FlatBufferBuilder builder, Offset<IConditionReturnPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017AC3 RID: 96963 RVA: 0x003608A0 File Offset: 0x0035EAA0
		public static VectorOffset CreateConditionPositionGroupVectorBlock(FlatBufferBuilder builder, Offset<IConditionReturnPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionReturnPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017AC4 RID: 96964 RVA: 0x003608BA File Offset: 0x0035EABA
		public static VectorOffset CreateConditionPositionGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionReturnPos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionReturnPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017AC5 RID: 96965 RVA: 0x003608D8 File Offset: 0x0035EAD8
		public static VectorOffset CreateConditionPositionGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionReturnPos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017AC6 RID: 96966 RVA: 0x003608F1 File Offset: 0x0035EAF1
		public static void StartConditionPositionGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017AC7 RID: 96967 RVA: 0x003608FC File Offset: 0x0035EAFC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06017AC8 RID: 96968 RVA: 0x00360907 File Offset: 0x0035EB07
		public static Offset<IFastReturnMapPos> EndIFastReturnMapPos(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnMapPos>(builder.EndTable());
		}

		// Token: 0x06017AC9 RID: 96969 RVA: 0x00360914 File Offset: 0x0035EB14
		public IFastReturnMapPosT UnPack()
		{
			IFastReturnMapPosT fastReturnMapPosT = new IFastReturnMapPosT();
			this.UnPackTo(fastReturnMapPosT);
			return fastReturnMapPosT;
		}

		// Token: 0x06017ACA RID: 96970 RVA: 0x00360930 File Offset: 0x0035EB30
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

		// Token: 0x06017ACB RID: 96971 RVA: 0x00360AA0 File Offset: 0x0035ECA0
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

		// Token: 0x0400C177 RID: 49527
		private Table __p;
	}
}
