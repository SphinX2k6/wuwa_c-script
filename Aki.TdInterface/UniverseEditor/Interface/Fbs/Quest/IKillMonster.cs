using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC9 RID: 16073
	public struct IKillMonster : IFlatbufferObject
	{
		// Token: 0x17006F98 RID: 28568
		// (get) Token: 0x06016BA7 RID: 93095 RVA: 0x00348267 File Offset: 0x00346467
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BA8 RID: 93096 RVA: 0x00348274 File Offset: 0x00346474
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BA9 RID: 93097 RVA: 0x0034827C File Offset: 0x0034647C
		public static IKillMonster GetRootAsIKillMonster(ByteBuffer _bb)
		{
			return IKillMonster.GetRootAsIKillMonster(_bb, default(IKillMonster));
		}

		// Token: 0x06016BAA RID: 93098 RVA: 0x00348298 File Offset: 0x00346498
		public static IKillMonster GetRootAsIKillMonster(ByteBuffer _bb, IKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BAB RID: 93099 RVA: 0x003482B5 File Offset: 0x003464B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BAC RID: 93100 RVA: 0x003482C4 File Offset: 0x003464C4
		public IKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F99 RID: 28569
		// (get) Token: 0x06016BAD RID: 93101 RVA: 0x003482D4 File Offset: 0x003464D4
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

		// Token: 0x06016BAE RID: 93102 RVA: 0x00348310 File Offset: 0x00346510
		public IKillSingleMonster? SpecialTime(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IKillSingleMonster?(default(IKillSingleMonster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006F9A RID: 28570
		// (get) Token: 0x06016BAF RID: 93103 RVA: 0x00348370 File Offset: 0x00346570
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

		// Token: 0x17006F9B RID: 28571
		// (get) Token: 0x06016BB0 RID: 93104 RVA: 0x0034839C File Offset: 0x0034659C
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

		// Token: 0x06016BB1 RID: 93105 RVA: 0x003483D8 File Offset: 0x003465D8
		public static Offset<IKillMonster> CreateIKillMonster(FlatBufferBuilder builder, int NormalAddTime = 0, VectorOffset SpecialTimeOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IKillMonster.AddSpecialTime(builder, SpecialTimeOffset);
			IKillMonster.AddNormalAddTime(builder, NormalAddTime);
			IKillMonster.AddNullMask(builder, NullMask);
			return IKillMonster.EndIKillMonster(builder);
		}

		// Token: 0x06016BB2 RID: 93106 RVA: 0x003483FC File Offset: 0x003465FC
		public static void StartIKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016BB3 RID: 93107 RVA: 0x00348405 File Offset: 0x00346605
		public static void AddNormalAddTime(FlatBufferBuilder builder, int normalAddTime)
		{
			builder.AddInt(0, normalAddTime, 0);
		}

		// Token: 0x06016BB4 RID: 93108 RVA: 0x00348410 File Offset: 0x00346610
		public static void AddSpecialTime(FlatBufferBuilder builder, VectorOffset specialTimeOffset)
		{
			builder.AddOffset(1, specialTimeOffset.Value, 0);
		}

		// Token: 0x06016BB5 RID: 93109 RVA: 0x00348420 File Offset: 0x00346620
		public static VectorOffset CreateSpecialTimeVector(FlatBufferBuilder builder, Offset<IKillSingleMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016BB6 RID: 93110 RVA: 0x00348460 File Offset: 0x00346660
		public static VectorOffset CreateSpecialTimeVectorBlock(FlatBufferBuilder builder, Offset<IKillSingleMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IKillSingleMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016BB7 RID: 93111 RVA: 0x0034847A File Offset: 0x0034667A
		public static VectorOffset CreateSpecialTimeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IKillSingleMonster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IKillSingleMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016BB8 RID: 93112 RVA: 0x00348498 File Offset: 0x00346698
		public static VectorOffset CreateSpecialTimeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IKillSingleMonster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016BB9 RID: 93113 RVA: 0x003484B1 File Offset: 0x003466B1
		public static void StartSpecialTimeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016BBA RID: 93114 RVA: 0x003484BC File Offset: 0x003466BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06016BBB RID: 93115 RVA: 0x003484C7 File Offset: 0x003466C7
		public static Offset<IKillMonster> EndIKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<IKillMonster>(builder.EndTable());
		}

		// Token: 0x06016BBC RID: 93116 RVA: 0x003484D4 File Offset: 0x003466D4
		public IKillMonsterT UnPack()
		{
			IKillMonsterT killMonsterT = new IKillMonsterT();
			this.UnPackTo(killMonsterT);
			return killMonsterT;
		}

		// Token: 0x06016BBD RID: 93117 RVA: 0x003484F0 File Offset: 0x003466F0
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

		// Token: 0x06016BBE RID: 93118 RVA: 0x00348568 File Offset: 0x00346768
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

		// Token: 0x0400B8A5 RID: 47269
		private Table __p;
	}
}
