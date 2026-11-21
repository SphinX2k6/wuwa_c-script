using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004307 RID: 17159
	public struct IKillMonster : IFlatbufferObject
	{
		// Token: 0x17007587 RID: 30087
		// (get) Token: 0x060181FE RID: 98814 RVA: 0x00371434 File Offset: 0x0036F634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060181FF RID: 98815 RVA: 0x00371441 File Offset: 0x0036F641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018200 RID: 98816 RVA: 0x00371448 File Offset: 0x0036F648
		public static IKillMonster GetRootAsIKillMonster(ByteBuffer _bb)
		{
			return IKillMonster.GetRootAsIKillMonster(_bb, default(IKillMonster));
		}

		// Token: 0x06018201 RID: 98817 RVA: 0x00371464 File Offset: 0x0036F664
		public static IKillMonster GetRootAsIKillMonster(ByteBuffer _bb, IKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018202 RID: 98818 RVA: 0x00371481 File Offset: 0x0036F681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018203 RID: 98819 RVA: 0x00371490 File Offset: 0x0036F690
		public IKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007588 RID: 30088
		// (get) Token: 0x06018204 RID: 98820 RVA: 0x003714A0 File Offset: 0x0036F6A0
		public int NormalAddTime
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

		// Token: 0x06018205 RID: 98821 RVA: 0x003714DC File Offset: 0x0036F6DC
		public IKillSingleMonster? SpecialTime(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IKillSingleMonster?(default(IKillSingleMonster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007589 RID: 30089
		// (get) Token: 0x06018206 RID: 98822 RVA: 0x0037153C File Offset: 0x0036F73C
		public int SpecialTimeLength
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

		// Token: 0x1700758A RID: 30090
		// (get) Token: 0x06018207 RID: 98823 RVA: 0x00371568 File Offset: 0x0036F768
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018208 RID: 98824 RVA: 0x003715A4 File Offset: 0x0036F7A4
		public static Offset<IKillMonster> CreateIKillMonster(FlatBufferBuilder builder, int NormalAddTime = 0, VectorOffset SpecialTimeOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IKillMonster.AddSpecialTime(builder, SpecialTimeOffset);
			IKillMonster.AddNormalAddTime(builder, NormalAddTime);
			IKillMonster.AddNullMask(builder, NullMask);
			return IKillMonster.EndIKillMonster(builder);
		}

		// Token: 0x06018209 RID: 98825 RVA: 0x003715C8 File Offset: 0x0036F7C8
		public static void StartIKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601820A RID: 98826 RVA: 0x003715D1 File Offset: 0x0036F7D1
		public static void AddNormalAddTime(FlatBufferBuilder builder, int normalAddTime)
		{
			builder.AddInt(0, normalAddTime, 0);
		}

		// Token: 0x0601820B RID: 98827 RVA: 0x003715DC File Offset: 0x0036F7DC
		public static void AddSpecialTime(FlatBufferBuilder builder, VectorOffset specialTimeOffset)
		{
			builder.AddOffset(1, specialTimeOffset.Value, 0);
		}

		// Token: 0x0601820C RID: 98828 RVA: 0x003715EC File Offset: 0x0036F7EC
		public static VectorOffset CreateSpecialTimeVector(FlatBufferBuilder builder, Offset<IKillSingleMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601820D RID: 98829 RVA: 0x0037162C File Offset: 0x0036F82C
		public static VectorOffset CreateSpecialTimeVectorBlock(FlatBufferBuilder builder, Offset<IKillSingleMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IKillSingleMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601820E RID: 98830 RVA: 0x00371646 File Offset: 0x0036F846
		public static VectorOffset CreateSpecialTimeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IKillSingleMonster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IKillSingleMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601820F RID: 98831 RVA: 0x00371664 File Offset: 0x0036F864
		public static VectorOffset CreateSpecialTimeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IKillSingleMonster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018210 RID: 98832 RVA: 0x0037167D File Offset: 0x0036F87D
		public static void StartSpecialTimeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018211 RID: 98833 RVA: 0x00371688 File Offset: 0x0036F888
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06018212 RID: 98834 RVA: 0x00371693 File Offset: 0x0036F893
		public static Offset<IKillMonster> EndIKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<IKillMonster>(builder.EndTable());
		}

		// Token: 0x06018213 RID: 98835 RVA: 0x003716A0 File Offset: 0x0036F8A0
		public IKillMonsterT UnPack()
		{
			IKillMonsterT killMonsterT = new IKillMonsterT();
			this.UnPackTo(killMonsterT);
			return killMonsterT;
		}

		// Token: 0x06018214 RID: 98836 RVA: 0x003716BC File Offset: 0x0036F8BC
		public void UnPackTo(IKillMonsterT _o)
		{
			_o.NormalAddTime = this.NormalAddTime;
			_o.SpecialTime = new List<IKillSingleMonsterT>();
			for (int i = 0; i < this.SpecialTimeLength; i++)
			{
				_o.SpecialTime.Add((this.SpecialTime(i) != null) ? this.SpecialTime(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018215 RID: 98837 RVA: 0x00371734 File Offset: 0x0036F934
		public static Offset<IKillMonster> Pack(FlatBufferBuilder builder, IKillMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKillMonster>);
			}
			VectorOffset specialTimeOffset = default(VectorOffset);
			if (_o.SpecialTime != null)
			{
				Offset<IKillSingleMonster>[] array = new Offset<IKillSingleMonster>[_o.SpecialTime.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IKillSingleMonster.Pack(builder, _o.SpecialTime[i]);
				}
				specialTimeOffset = IKillMonster.CreateSpecialTimeVector(builder, array);
			}
			return IKillMonster.CreateIKillMonster(builder, _o.NormalAddTime, specialTimeOffset, _o.NullMask);
		}

		// Token: 0x0400C282 RID: 49794
		private Table __p;
	}
}
