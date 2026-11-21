using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB2 RID: 23986
	public struct IPullingCategoryMatchingFoundation : IFlatbufferObject
	{
		// Token: 0x1700B0AC RID: 45228
		// (get) Token: 0x06027FB8 RID: 163768 RVA: 0x00578159 File Offset: 0x00576359
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027FB9 RID: 163769 RVA: 0x00578166 File Offset: 0x00576366
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027FBA RID: 163770 RVA: 0x00578170 File Offset: 0x00576370
		public static IPullingCategoryMatchingFoundation GetRootAsIPullingCategoryMatchingFoundation(ByteBuffer _bb)
		{
			return IPullingCategoryMatchingFoundation.GetRootAsIPullingCategoryMatchingFoundation(_bb, default(IPullingCategoryMatchingFoundation));
		}

		// Token: 0x06027FBB RID: 163771 RVA: 0x0057818C File Offset: 0x0057638C
		public static IPullingCategoryMatchingFoundation GetRootAsIPullingCategoryMatchingFoundation(ByteBuffer _bb, IPullingCategoryMatchingFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027FBC RID: 163772 RVA: 0x005781A9 File Offset: 0x005763A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027FBD RID: 163773 RVA: 0x005781B8 File Offset: 0x005763B8
		public IPullingCategoryMatchingFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0AD RID: 45229
		// (get) Token: 0x06027FBE RID: 163774 RVA: 0x005781C8 File Offset: 0x005763C8
		public EPullingFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPullingFoundation.CategoryMatching;
				}
				return (EPullingFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0AE RID: 45230
		// (get) Token: 0x06027FBF RID: 163775 RVA: 0x00578204 File Offset: 0x00576404
		public int InitMatchEntity
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

		// Token: 0x06027FC0 RID: 163776 RVA: 0x00578240 File Offset: 0x00576440
		public ICategoryMatchingConfigBase? MatchingConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICategoryMatchingConfigBase?(default(ICategoryMatchingConfigBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0AF RID: 45231
		// (get) Token: 0x06027FC1 RID: 163777 RVA: 0x005782A0 File Offset: 0x005764A0
		public int MatchingConfigsLength
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

		// Token: 0x1700B0B0 RID: 45232
		// (get) Token: 0x06027FC2 RID: 163778 RVA: 0x005782CC File Offset: 0x005764CC
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

		// Token: 0x06027FC3 RID: 163779 RVA: 0x00578309 File Offset: 0x00576509
		public static Offset<IPullingCategoryMatchingFoundation> CreateIPullingCategoryMatchingFoundation(FlatBufferBuilder builder, EPullingFoundation Type = EPullingFoundation.CategoryMatching, int InitMatchEntity = 0, VectorOffset MatchingConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPullingCategoryMatchingFoundation.AddMatchingConfigs(builder, MatchingConfigsOffset);
			IPullingCategoryMatchingFoundation.AddInitMatchEntity(builder, InitMatchEntity);
			IPullingCategoryMatchingFoundation.AddNullMask(builder, NullMask);
			IPullingCategoryMatchingFoundation.AddType(builder, Type);
			return IPullingCategoryMatchingFoundation.EndIPullingCategoryMatchingFoundation(builder);
		}

		// Token: 0x06027FC4 RID: 163780 RVA: 0x00578335 File Offset: 0x00576535
		public static void StartIPullingCategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027FC5 RID: 163781 RVA: 0x0057833E File Offset: 0x0057653E
		public static void AddType(FlatBufferBuilder builder, EPullingFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027FC6 RID: 163782 RVA: 0x00578349 File Offset: 0x00576549
		public static void AddInitMatchEntity(FlatBufferBuilder builder, int initMatchEntity)
		{
			builder.AddInt(1, initMatchEntity, 0);
		}

		// Token: 0x06027FC7 RID: 163783 RVA: 0x00578354 File Offset: 0x00576554
		public static void AddMatchingConfigs(FlatBufferBuilder builder, VectorOffset matchingConfigsOffset)
		{
			builder.AddOffset(2, matchingConfigsOffset.Value, 0);
		}

		// Token: 0x06027FC8 RID: 163784 RVA: 0x00578364 File Offset: 0x00576564
		public static VectorOffset CreateMatchingConfigsVector(FlatBufferBuilder builder, Offset<ICategoryMatchingConfigBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027FC9 RID: 163785 RVA: 0x005783A4 File Offset: 0x005765A4
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICategoryMatchingConfigBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICategoryMatchingConfigBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027FCA RID: 163786 RVA: 0x005783BE File Offset: 0x005765BE
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICategoryMatchingConfigBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICategoryMatchingConfigBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027FCB RID: 163787 RVA: 0x005783DC File Offset: 0x005765DC
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICategoryMatchingConfigBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027FCC RID: 163788 RVA: 0x005783F5 File Offset: 0x005765F5
		public static void StartMatchingConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027FCD RID: 163789 RVA: 0x00578400 File Offset: 0x00576600
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027FCE RID: 163790 RVA: 0x0057840B File Offset: 0x0057660B
		public static Offset<IPullingCategoryMatchingFoundation> EndIPullingCategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IPullingCategoryMatchingFoundation>(builder.EndTable());
		}

		// Token: 0x06027FCF RID: 163791 RVA: 0x00578418 File Offset: 0x00576618
		public IPullingCategoryMatchingFoundationT UnPack()
		{
			IPullingCategoryMatchingFoundationT pullingCategoryMatchingFoundationT = new IPullingCategoryMatchingFoundationT();
			this.UnPackTo(pullingCategoryMatchingFoundationT);
			return pullingCategoryMatchingFoundationT;
		}

		// Token: 0x06027FD0 RID: 163792 RVA: 0x00578434 File Offset: 0x00576634
		public void UnPackTo(IPullingCategoryMatchingFoundationT _o)
		{
			_o.Type = this.Type;
			_o.InitMatchEntity = this.InitMatchEntity;
			_o.MatchingConfigs = new List<ICategoryMatchingConfigBaseT>();
			for (int i = 0; i < this.MatchingConfigsLength; i++)
			{
				_o.MatchingConfigs.Add((this.MatchingConfigs(i) != null) ? this.MatchingConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027FD1 RID: 163793 RVA: 0x005784B8 File Offset: 0x005766B8
		public static Offset<IPullingCategoryMatchingFoundation> Pack(FlatBufferBuilder builder, IPullingCategoryMatchingFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPullingCategoryMatchingFoundation>);
			}
			VectorOffset matchingConfigsOffset = default(VectorOffset);
			if (_o.MatchingConfigs != null)
			{
				Offset<ICategoryMatchingConfigBase>[] array = new Offset<ICategoryMatchingConfigBase>[_o.MatchingConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICategoryMatchingConfigBase.Pack(builder, _o.MatchingConfigs[i]);
				}
				matchingConfigsOffset = IPullingCategoryMatchingFoundation.CreateMatchingConfigsVector(builder, array);
			}
			return IPullingCategoryMatchingFoundation.CreateIPullingCategoryMatchingFoundation(builder, _o.Type, _o.InitMatchEntity, matchingConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F96B RID: 63851
		private Table __p;
	}
}
