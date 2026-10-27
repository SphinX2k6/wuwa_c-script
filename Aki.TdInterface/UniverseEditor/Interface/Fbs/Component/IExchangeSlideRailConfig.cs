using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051CB RID: 20939
	public struct IExchangeSlideRailConfig : IFlatbufferObject
	{
		// Token: 0x1700993B RID: 39227
		// (get) Token: 0x06021F26 RID: 139046 RVA: 0x004B5A53 File Offset: 0x004B3C53
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F27 RID: 139047 RVA: 0x004B5A60 File Offset: 0x004B3C60
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F28 RID: 139048 RVA: 0x004B5A68 File Offset: 0x004B3C68
		public static IExchangeSlideRailConfig GetRootAsIExchangeSlideRailConfig(ByteBuffer _bb)
		{
			return IExchangeSlideRailConfig.GetRootAsIExchangeSlideRailConfig(_bb, default(IExchangeSlideRailConfig));
		}

		// Token: 0x06021F29 RID: 139049 RVA: 0x004B5A84 File Offset: 0x004B3C84
		public static IExchangeSlideRailConfig GetRootAsIExchangeSlideRailConfig(ByteBuffer _bb, IExchangeSlideRailConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F2A RID: 139050 RVA: 0x004B5AA1 File Offset: 0x004B3CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F2B RID: 139051 RVA: 0x004B5AB0 File Offset: 0x004B3CB0
		public IExchangeSlideRailConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700993C RID: 39228
		// (get) Token: 0x06021F2C RID: 139052 RVA: 0x004B5AC0 File Offset: 0x004B3CC0
		public int MaxExchangeDistance
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

		// Token: 0x1700993D RID: 39229
		// (get) Token: 0x06021F2D RID: 139053 RVA: 0x004B5AFC File Offset: 0x004B3CFC
		public int MaxExchangeHigh
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021F2E RID: 139054 RVA: 0x004B5B38 File Offset: 0x004B3D38
		public INextSlideRail? NextRails(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INextSlideRail?(default(INextSlideRail).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700993E RID: 39230
		// (get) Token: 0x06021F2F RID: 139055 RVA: 0x004B5B98 File Offset: 0x004B3D98
		public int NextRailsLength
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

		// Token: 0x1700993F RID: 39231
		// (get) Token: 0x06021F30 RID: 139056 RVA: 0x004B5BC4 File Offset: 0x004B3DC4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021F31 RID: 139057 RVA: 0x004B5C01 File Offset: 0x004B3E01
		public static Offset<IExchangeSlideRailConfig> CreateIExchangeSlideRailConfig(FlatBufferBuilder builder, int MaxExchangeDistance = 0, int MaxExchangeHigh = 0, VectorOffset NextRailsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExchangeSlideRailConfig.AddNextRails(builder, NextRailsOffset);
			IExchangeSlideRailConfig.AddMaxExchangeHigh(builder, MaxExchangeHigh);
			IExchangeSlideRailConfig.AddMaxExchangeDistance(builder, MaxExchangeDistance);
			IExchangeSlideRailConfig.AddNullMask(builder, NullMask);
			return IExchangeSlideRailConfig.EndIExchangeSlideRailConfig(builder);
		}

		// Token: 0x06021F32 RID: 139058 RVA: 0x004B5C2D File Offset: 0x004B3E2D
		public static void StartIExchangeSlideRailConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021F33 RID: 139059 RVA: 0x004B5C36 File Offset: 0x004B3E36
		public static void AddMaxExchangeDistance(FlatBufferBuilder builder, int maxExchangeDistance)
		{
			builder.AddInt(0, maxExchangeDistance, 0);
		}

		// Token: 0x06021F34 RID: 139060 RVA: 0x004B5C41 File Offset: 0x004B3E41
		public static void AddMaxExchangeHigh(FlatBufferBuilder builder, int maxExchangeHigh)
		{
			builder.AddInt(1, maxExchangeHigh, 0);
		}

		// Token: 0x06021F35 RID: 139061 RVA: 0x004B5C4C File Offset: 0x004B3E4C
		public static void AddNextRails(FlatBufferBuilder builder, VectorOffset nextRailsOffset)
		{
			builder.AddOffset(2, nextRailsOffset.Value, 0);
		}

		// Token: 0x06021F36 RID: 139062 RVA: 0x004B5C5C File Offset: 0x004B3E5C
		public static VectorOffset CreateNextRailsVector(FlatBufferBuilder builder, Offset<INextSlideRail>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021F37 RID: 139063 RVA: 0x004B5C9C File Offset: 0x004B3E9C
		public static VectorOffset CreateNextRailsVectorBlock(FlatBufferBuilder builder, Offset<INextSlideRail>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INextSlideRail>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F38 RID: 139064 RVA: 0x004B5CB6 File Offset: 0x004B3EB6
		public static VectorOffset CreateNextRailsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INextSlideRail>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INextSlideRail>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F39 RID: 139065 RVA: 0x004B5CD4 File Offset: 0x004B3ED4
		public static VectorOffset CreateNextRailsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INextSlideRail>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021F3A RID: 139066 RVA: 0x004B5CED File Offset: 0x004B3EED
		public static void StartNextRailsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021F3B RID: 139067 RVA: 0x004B5CF8 File Offset: 0x004B3EF8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021F3C RID: 139068 RVA: 0x004B5D03 File Offset: 0x004B3F03
		public static Offset<IExchangeSlideRailConfig> EndIExchangeSlideRailConfig(FlatBufferBuilder builder)
		{
			return new Offset<IExchangeSlideRailConfig>(builder.EndTable());
		}

		// Token: 0x06021F3D RID: 139069 RVA: 0x004B5D10 File Offset: 0x004B3F10
		public IExchangeSlideRailConfigT UnPack()
		{
			IExchangeSlideRailConfigT exchangeSlideRailConfigT = new IExchangeSlideRailConfigT();
			this.UnPackTo(exchangeSlideRailConfigT);
			return exchangeSlideRailConfigT;
		}

		// Token: 0x06021F3E RID: 139070 RVA: 0x004B5D2C File Offset: 0x004B3F2C
		public void UnPackTo(IExchangeSlideRailConfigT _o)
		{
			_o.MaxExchangeDistance = this.MaxExchangeDistance;
			_o.MaxExchangeHigh = this.MaxExchangeHigh;
			_o.NextRails = new List<INextSlideRailT>();
			for (int i = 0; i < this.NextRailsLength; i++)
			{
				_o.NextRails.Add((this.NextRails(i) != null) ? this.NextRails(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021F3F RID: 139071 RVA: 0x004B5DB0 File Offset: 0x004B3FB0
		public static Offset<IExchangeSlideRailConfig> Pack(FlatBufferBuilder builder, IExchangeSlideRailConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExchangeSlideRailConfig>);
			}
			VectorOffset nextRailsOffset = default(VectorOffset);
			if (_o.NextRails != null)
			{
				Offset<INextSlideRail>[] array = new Offset<INextSlideRail>[_o.NextRails.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INextSlideRail.Pack(builder, _o.NextRails[i]);
				}
				nextRailsOffset = IExchangeSlideRailConfig.CreateNextRailsVector(builder, array);
			}
			return IExchangeSlideRailConfig.CreateIExchangeSlideRailConfig(builder, _o.MaxExchangeDistance, _o.MaxExchangeHigh, nextRailsOffset, _o.NullMask);
		}

		// Token: 0x0400E2CD RID: 58061
		private Table __p;
	}
}
