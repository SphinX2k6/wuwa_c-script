using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057ED RID: 22509
	public struct IRandomNpcRule : IFlatbufferObject
	{
		// Token: 0x1700A81E RID: 43038
		// (get) Token: 0x06025D30 RID: 154928 RVA: 0x005376C8 File Offset: 0x005358C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D31 RID: 154929 RVA: 0x005376D5 File Offset: 0x005358D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D32 RID: 154930 RVA: 0x005376DC File Offset: 0x005358DC
		public static IRandomNpcRule GetRootAsIRandomNpcRule(ByteBuffer _bb)
		{
			return IRandomNpcRule.GetRootAsIRandomNpcRule(_bb, default(IRandomNpcRule));
		}

		// Token: 0x06025D33 RID: 154931 RVA: 0x005376F8 File Offset: 0x005358F8
		public static IRandomNpcRule GetRootAsIRandomNpcRule(ByteBuffer _bb, IRandomNpcRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D34 RID: 154932 RVA: 0x00537715 File Offset: 0x00535915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D35 RID: 154933 RVA: 0x00537724 File Offset: 0x00535924
		public IRandomNpcRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A81F RID: 43039
		// (get) Token: 0x06025D36 RID: 154934 RVA: 0x00537734 File Offset: 0x00535934
		public ERefreshRule Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefreshRule.CD;
				}
				return (ERefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025D37 RID: 154935 RVA: 0x00537770 File Offset: 0x00535970
		public IFixedDateTime? DateTimeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFixedDateTime?(default(IFixedDateTime).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A820 RID: 43040
		// (get) Token: 0x06025D38 RID: 154936 RVA: 0x005377D0 File Offset: 0x005359D0
		public int DateTimeListLength
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

		// Token: 0x1700A821 RID: 43041
		// (get) Token: 0x06025D39 RID: 154937 RVA: 0x005377FC File Offset: 0x005359FC
		public IProbabilityRefreshGroup? ProbabilityRefreshGroup
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IProbabilityRefreshGroup?(default(IProbabilityRefreshGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025D3A RID: 154938 RVA: 0x00537859 File Offset: 0x00535A59
		public static Offset<IRandomNpcRule> CreateIRandomNpcRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD, VectorOffset DateTimeListOffset = default(VectorOffset), Offset<IProbabilityRefreshGroup> ProbabilityRefreshGroupOffset = default(Offset<IProbabilityRefreshGroup>))
		{
			builder.StartTable(3);
			IRandomNpcRule.AddProbabilityRefreshGroup(builder, ProbabilityRefreshGroupOffset);
			IRandomNpcRule.AddDateTimeList(builder, DateTimeListOffset);
			IRandomNpcRule.AddType(builder, Type);
			return IRandomNpcRule.EndIRandomNpcRule(builder);
		}

		// Token: 0x06025D3B RID: 154939 RVA: 0x0053787D File Offset: 0x00535A7D
		public static void StartIRandomNpcRule(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025D3C RID: 154940 RVA: 0x00537886 File Offset: 0x00535A86
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025D3D RID: 154941 RVA: 0x00537891 File Offset: 0x00535A91
		public static void AddDateTimeList(FlatBufferBuilder builder, VectorOffset dateTimeListOffset)
		{
			builder.AddOffset(1, dateTimeListOffset.Value, 0);
		}

		// Token: 0x06025D3E RID: 154942 RVA: 0x005378A4 File Offset: 0x00535AA4
		public static VectorOffset CreateDateTimeListVector(FlatBufferBuilder builder, Offset<IFixedDateTime>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025D3F RID: 154943 RVA: 0x005378E4 File Offset: 0x00535AE4
		public static VectorOffset CreateDateTimeListVectorBlock(FlatBufferBuilder builder, Offset<IFixedDateTime>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixedDateTime>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D40 RID: 154944 RVA: 0x005378FE File Offset: 0x00535AFE
		public static VectorOffset CreateDateTimeListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixedDateTime>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixedDateTime>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D41 RID: 154945 RVA: 0x0053791C File Offset: 0x00535B1C
		public static VectorOffset CreateDateTimeListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixedDateTime>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025D42 RID: 154946 RVA: 0x00537935 File Offset: 0x00535B35
		public static void StartDateTimeListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025D43 RID: 154947 RVA: 0x00537940 File Offset: 0x00535B40
		public static void AddProbabilityRefreshGroup(FlatBufferBuilder builder, Offset<IProbabilityRefreshGroup> probabilityRefreshGroupOffset)
		{
			builder.AddOffset(2, probabilityRefreshGroupOffset.Value, 0);
		}

		// Token: 0x06025D44 RID: 154948 RVA: 0x00537950 File Offset: 0x00535B50
		public static Offset<IRandomNpcRule> EndIRandomNpcRule(FlatBufferBuilder builder)
		{
			return new Offset<IRandomNpcRule>(builder.EndTable());
		}

		// Token: 0x06025D45 RID: 154949 RVA: 0x00537960 File Offset: 0x00535B60
		public IRandomNpcRuleT UnPack()
		{
			IRandomNpcRuleT randomNpcRuleT = new IRandomNpcRuleT();
			this.UnPackTo(randomNpcRuleT);
			return randomNpcRuleT;
		}

		// Token: 0x06025D46 RID: 154950 RVA: 0x0053797C File Offset: 0x00535B7C
		public void UnPackTo(IRandomNpcRuleT _o)
		{
			_o.Type = this.Type;
			_o.DateTimeList = new List<IFixedDateTimeT>();
			for (int i = 0; i < this.DateTimeListLength; i++)
			{
				_o.DateTimeList.Add((this.DateTimeList(i) != null) ? this.DateTimeList(i).Value.UnPack() : null);
			}
			_o.ProbabilityRefreshGroup = ((this.ProbabilityRefreshGroup != null) ? this.ProbabilityRefreshGroup.Value.UnPack() : null);
		}

		// Token: 0x06025D47 RID: 154951 RVA: 0x00537A18 File Offset: 0x00535C18
		public static Offset<IRandomNpcRule> Pack(FlatBufferBuilder builder, IRandomNpcRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomNpcRule>);
			}
			VectorOffset dateTimeListOffset = default(VectorOffset);
			if (_o.DateTimeList != null)
			{
				Offset<IFixedDateTime>[] array = new Offset<IFixedDateTime>[_o.DateTimeList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFixedDateTime.Pack(builder, _o.DateTimeList[i]);
				}
				dateTimeListOffset = IRandomNpcRule.CreateDateTimeListVector(builder, array);
			}
			Offset<IProbabilityRefreshGroup> probabilityRefreshGroupOffset = (_o.ProbabilityRefreshGroup == null) ? default(Offset<IProbabilityRefreshGroup>) : IProbabilityRefreshGroup.Pack(builder, _o.ProbabilityRefreshGroup);
			return IRandomNpcRule.CreateIRandomNpcRule(builder, _o.Type, dateTimeListOffset, probabilityRefreshGroupOffset);
		}

		// Token: 0x0400ECDF RID: 60639
		private Table __p;
	}
}
