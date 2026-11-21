using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF4 RID: 24052
	public struct IRandomNpcRule : IFlatbufferObject
	{
		// Token: 0x1700B142 RID: 45378
		// (get) Token: 0x06028250 RID: 164432 RVA: 0x0057D854 File Offset: 0x0057BA54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028251 RID: 164433 RVA: 0x0057D861 File Offset: 0x0057BA61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028252 RID: 164434 RVA: 0x0057D868 File Offset: 0x0057BA68
		public static IRandomNpcRule GetRootAsIRandomNpcRule(ByteBuffer _bb)
		{
			return IRandomNpcRule.GetRootAsIRandomNpcRule(_bb, default(IRandomNpcRule));
		}

		// Token: 0x06028253 RID: 164435 RVA: 0x0057D884 File Offset: 0x0057BA84
		public static IRandomNpcRule GetRootAsIRandomNpcRule(ByteBuffer _bb, IRandomNpcRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028254 RID: 164436 RVA: 0x0057D8A1 File Offset: 0x0057BAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028255 RID: 164437 RVA: 0x0057D8B0 File Offset: 0x0057BAB0
		public IRandomNpcRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B143 RID: 45379
		// (get) Token: 0x06028256 RID: 164438 RVA: 0x0057D8C0 File Offset: 0x0057BAC0
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

		// Token: 0x06028257 RID: 164439 RVA: 0x0057D8FC File Offset: 0x0057BAFC
		public IFixedDateTime? DateTimeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFixedDateTime?(default(IFixedDateTime).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B144 RID: 45380
		// (get) Token: 0x06028258 RID: 164440 RVA: 0x0057D95C File Offset: 0x0057BB5C
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

		// Token: 0x1700B145 RID: 45381
		// (get) Token: 0x06028259 RID: 164441 RVA: 0x0057D988 File Offset: 0x0057BB88
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

		// Token: 0x0602825A RID: 164442 RVA: 0x0057D9E5 File Offset: 0x0057BBE5
		public static Offset<IRandomNpcRule> CreateIRandomNpcRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD, VectorOffset DateTimeListOffset = default(VectorOffset), Offset<IProbabilityRefreshGroup> ProbabilityRefreshGroupOffset = default(Offset<IProbabilityRefreshGroup>))
		{
			builder.StartTable(3);
			IRandomNpcRule.AddProbabilityRefreshGroup(builder, ProbabilityRefreshGroupOffset);
			IRandomNpcRule.AddDateTimeList(builder, DateTimeListOffset);
			IRandomNpcRule.AddType(builder, Type);
			return IRandomNpcRule.EndIRandomNpcRule(builder);
		}

		// Token: 0x0602825B RID: 164443 RVA: 0x0057DA09 File Offset: 0x0057BC09
		public static void StartIRandomNpcRule(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602825C RID: 164444 RVA: 0x0057DA12 File Offset: 0x0057BC12
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602825D RID: 164445 RVA: 0x0057DA1D File Offset: 0x0057BC1D
		public static void AddDateTimeList(FlatBufferBuilder builder, VectorOffset dateTimeListOffset)
		{
			builder.AddOffset(1, dateTimeListOffset.Value, 0);
		}

		// Token: 0x0602825E RID: 164446 RVA: 0x0057DA30 File Offset: 0x0057BC30
		public static VectorOffset CreateDateTimeListVector(FlatBufferBuilder builder, Offset<IFixedDateTime>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602825F RID: 164447 RVA: 0x0057DA70 File Offset: 0x0057BC70
		public static VectorOffset CreateDateTimeListVectorBlock(FlatBufferBuilder builder, Offset<IFixedDateTime>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixedDateTime>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028260 RID: 164448 RVA: 0x0057DA8A File Offset: 0x0057BC8A
		public static VectorOffset CreateDateTimeListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixedDateTime>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixedDateTime>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028261 RID: 164449 RVA: 0x0057DAA8 File Offset: 0x0057BCA8
		public static VectorOffset CreateDateTimeListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixedDateTime>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028262 RID: 164450 RVA: 0x0057DAC1 File Offset: 0x0057BCC1
		public static void StartDateTimeListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028263 RID: 164451 RVA: 0x0057DACC File Offset: 0x0057BCCC
		public static void AddProbabilityRefreshGroup(FlatBufferBuilder builder, Offset<IProbabilityRefreshGroup> probabilityRefreshGroupOffset)
		{
			builder.AddOffset(2, probabilityRefreshGroupOffset.Value, 0);
		}

		// Token: 0x06028264 RID: 164452 RVA: 0x0057DADC File Offset: 0x0057BCDC
		public static Offset<IRandomNpcRule> EndIRandomNpcRule(FlatBufferBuilder builder)
		{
			return new Offset<IRandomNpcRule>(builder.EndTable());
		}

		// Token: 0x06028265 RID: 164453 RVA: 0x0057DAEC File Offset: 0x0057BCEC
		public IRandomNpcRuleT UnPack()
		{
			IRandomNpcRuleT randomNpcRuleT = new IRandomNpcRuleT();
			this.UnPackTo(randomNpcRuleT);
			return randomNpcRuleT;
		}

		// Token: 0x06028266 RID: 164454 RVA: 0x0057DB08 File Offset: 0x0057BD08
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

		// Token: 0x06028267 RID: 164455 RVA: 0x0057DBA4 File Offset: 0x0057BDA4
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

		// Token: 0x0400F9CA RID: 63946
		private Table __p;
	}
}
