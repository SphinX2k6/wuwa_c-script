using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007112 RID: 28946
	public struct ILiveLoadDanmakuConfig : IFlatbufferObject
	{
		// Token: 0x1700D3FC RID: 54268
		// (get) Token: 0x06032477 RID: 205943 RVA: 0x006CC8A6 File Offset: 0x006CAAA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032478 RID: 205944 RVA: 0x006CC8B3 File Offset: 0x006CAAB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032479 RID: 205945 RVA: 0x006CC8BC File Offset: 0x006CAABC
		public static ILiveLoadDanmakuConfig GetRootAsILiveLoadDanmakuConfig(ByteBuffer _bb)
		{
			return ILiveLoadDanmakuConfig.GetRootAsILiveLoadDanmakuConfig(_bb, default(ILiveLoadDanmakuConfig));
		}

		// Token: 0x0603247A RID: 205946 RVA: 0x006CC8D8 File Offset: 0x006CAAD8
		public static ILiveLoadDanmakuConfig GetRootAsILiveLoadDanmakuConfig(ByteBuffer _bb, ILiveLoadDanmakuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603247B RID: 205947 RVA: 0x006CC8F5 File Offset: 0x006CAAF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603247C RID: 205948 RVA: 0x006CC904 File Offset: 0x006CAB04
		public ILiveLoadDanmakuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3FD RID: 54269
		// (get) Token: 0x0603247D RID: 205949 RVA: 0x006CC914 File Offset: 0x006CAB14
		public ELiveDanmakuOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return (ELiveDanmakuOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603247E RID: 205950 RVA: 0x006CC950 File Offset: 0x006CAB50
		public ILiveDanmakuPool? DanmakuPools(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILiveDanmakuPool?(default(ILiveDanmakuPool).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D3FE RID: 54270
		// (get) Token: 0x0603247F RID: 205951 RVA: 0x006CC9B0 File Offset: 0x006CABB0
		public int DanmakuPoolsLength
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

		// Token: 0x1700D3FF RID: 54271
		// (get) Token: 0x06032480 RID: 205952 RVA: 0x006CC9DC File Offset: 0x006CABDC
		public float SendInterval
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D400 RID: 54272
		// (get) Token: 0x06032481 RID: 205953 RVA: 0x006CCA1C File Offset: 0x006CAC1C
		public int TrackCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D401 RID: 54273
		// (get) Token: 0x06032482 RID: 205954 RVA: 0x006CCA5C File Offset: 0x006CAC5C
		public ELiveDanmakuLinkType LinkType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ELiveDanmakuLinkType.KeepCurrent;
				}
				return (ELiveDanmakuLinkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D402 RID: 54274
		// (get) Token: 0x06032483 RID: 205955 RVA: 0x006CCA9C File Offset: 0x006CAC9C
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

		// Token: 0x06032484 RID: 205956 RVA: 0x006CCAD9 File Offset: 0x006CACD9
		public static Offset<ILiveLoadDanmakuConfig> CreateILiveLoadDanmakuConfig(FlatBufferBuilder builder, ELiveDanmakuOperationType Type = ELiveDanmakuOperationType.Load, VectorOffset DanmakuPoolsOffset = default(VectorOffset), float SendInterval = 0f, int TrackCount = 0, ELiveDanmakuLinkType LinkType = ELiveDanmakuLinkType.KeepCurrent, byte NullMask = 0)
		{
			builder.StartTable(6);
			ILiveLoadDanmakuConfig.AddTrackCount(builder, TrackCount);
			ILiveLoadDanmakuConfig.AddSendInterval(builder, SendInterval);
			ILiveLoadDanmakuConfig.AddDanmakuPools(builder, DanmakuPoolsOffset);
			ILiveLoadDanmakuConfig.AddNullMask(builder, NullMask);
			ILiveLoadDanmakuConfig.AddLinkType(builder, LinkType);
			ILiveLoadDanmakuConfig.AddType(builder, Type);
			return ILiveLoadDanmakuConfig.EndILiveLoadDanmakuConfig(builder);
		}

		// Token: 0x06032485 RID: 205957 RVA: 0x006CCB15 File Offset: 0x006CAD15
		public static void StartILiveLoadDanmakuConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032486 RID: 205958 RVA: 0x006CCB1E File Offset: 0x006CAD1E
		public static void AddType(FlatBufferBuilder builder, ELiveDanmakuOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032487 RID: 205959 RVA: 0x006CCB29 File Offset: 0x006CAD29
		public static void AddDanmakuPools(FlatBufferBuilder builder, VectorOffset danmakuPoolsOffset)
		{
			builder.AddOffset(1, danmakuPoolsOffset.Value, 0);
		}

		// Token: 0x06032488 RID: 205960 RVA: 0x006CCB3C File Offset: 0x006CAD3C
		public static VectorOffset CreateDanmakuPoolsVector(FlatBufferBuilder builder, Offset<ILiveDanmakuPool>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032489 RID: 205961 RVA: 0x006CCB7C File Offset: 0x006CAD7C
		public static VectorOffset CreateDanmakuPoolsVectorBlock(FlatBufferBuilder builder, Offset<ILiveDanmakuPool>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILiveDanmakuPool>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603248A RID: 205962 RVA: 0x006CCB96 File Offset: 0x006CAD96
		public static VectorOffset CreateDanmakuPoolsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILiveDanmakuPool>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILiveDanmakuPool>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603248B RID: 205963 RVA: 0x006CCBB4 File Offset: 0x006CADB4
		public static VectorOffset CreateDanmakuPoolsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILiveDanmakuPool>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603248C RID: 205964 RVA: 0x006CCBCD File Offset: 0x006CADCD
		public static void StartDanmakuPoolsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603248D RID: 205965 RVA: 0x006CCBD8 File Offset: 0x006CADD8
		public static void AddSendInterval(FlatBufferBuilder builder, float sendInterval)
		{
			builder.AddFloat(2, sendInterval, 0.0);
		}

		// Token: 0x0603248E RID: 205966 RVA: 0x006CCBEB File Offset: 0x006CADEB
		public static void AddTrackCount(FlatBufferBuilder builder, int trackCount)
		{
			builder.AddInt(3, trackCount, 0);
		}

		// Token: 0x0603248F RID: 205967 RVA: 0x006CCBF6 File Offset: 0x006CADF6
		public static void AddLinkType(FlatBufferBuilder builder, ELiveDanmakuLinkType linkType)
		{
			builder.AddByte(4, (byte)linkType, 0);
		}

		// Token: 0x06032490 RID: 205968 RVA: 0x006CCC01 File Offset: 0x006CAE01
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06032491 RID: 205969 RVA: 0x006CCC0C File Offset: 0x006CAE0C
		public static Offset<ILiveLoadDanmakuConfig> EndILiveLoadDanmakuConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveLoadDanmakuConfig>(builder.EndTable());
		}

		// Token: 0x06032492 RID: 205970 RVA: 0x006CCC1C File Offset: 0x006CAE1C
		public ILiveLoadDanmakuConfigT UnPack()
		{
			ILiveLoadDanmakuConfigT liveLoadDanmakuConfigT = new ILiveLoadDanmakuConfigT();
			this.UnPackTo(liveLoadDanmakuConfigT);
			return liveLoadDanmakuConfigT;
		}

		// Token: 0x06032493 RID: 205971 RVA: 0x006CCC38 File Offset: 0x006CAE38
		public void UnPackTo(ILiveLoadDanmakuConfigT _o)
		{
			_o.Type = this.Type;
			_o.DanmakuPools = new List<ILiveDanmakuPoolT>();
			for (int i = 0; i < this.DanmakuPoolsLength; i++)
			{
				_o.DanmakuPools.Add((this.DanmakuPools(i) != null) ? this.DanmakuPools(i).Value.UnPack() : null);
			}
			_o.SendInterval = this.SendInterval;
			_o.TrackCount = this.TrackCount;
			_o.LinkType = this.LinkType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032494 RID: 205972 RVA: 0x006CCCD4 File Offset: 0x006CAED4
		public static Offset<ILiveLoadDanmakuConfig> Pack(FlatBufferBuilder builder, ILiveLoadDanmakuConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveLoadDanmakuConfig>);
			}
			VectorOffset danmakuPoolsOffset = default(VectorOffset);
			if (_o.DanmakuPools != null)
			{
				Offset<ILiveDanmakuPool>[] array = new Offset<ILiveDanmakuPool>[_o.DanmakuPools.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILiveDanmakuPool.Pack(builder, _o.DanmakuPools[i]);
				}
				danmakuPoolsOffset = ILiveLoadDanmakuConfig.CreateDanmakuPoolsVector(builder, array);
			}
			return ILiveLoadDanmakuConfig.CreateILiveLoadDanmakuConfig(builder, _o.Type, danmakuPoolsOffset, _o.SendInterval, _o.TrackCount, _o.LinkType, _o.NullMask);
		}

		// Token: 0x040120ED RID: 73965
		private Table __p;
	}
}
