using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F1 RID: 28913
	public struct ILiveDanmakuTrackCountParam : IFlatbufferObject
	{
		// Token: 0x1700D3BC RID: 54204
		// (get) Token: 0x06032360 RID: 205664 RVA: 0x006CAB08 File Offset: 0x006C8D08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032361 RID: 205665 RVA: 0x006CAB15 File Offset: 0x006C8D15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032362 RID: 205666 RVA: 0x006CAB1C File Offset: 0x006C8D1C
		public static ILiveDanmakuTrackCountParam GetRootAsILiveDanmakuTrackCountParam(ByteBuffer _bb)
		{
			return ILiveDanmakuTrackCountParam.GetRootAsILiveDanmakuTrackCountParam(_bb, default(ILiveDanmakuTrackCountParam));
		}

		// Token: 0x06032363 RID: 205667 RVA: 0x006CAB38 File Offset: 0x006C8D38
		public static ILiveDanmakuTrackCountParam GetRootAsILiveDanmakuTrackCountParam(ByteBuffer _bb, ILiveDanmakuTrackCountParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032364 RID: 205668 RVA: 0x006CAB55 File Offset: 0x006C8D55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032365 RID: 205669 RVA: 0x006CAB64 File Offset: 0x006C8D64
		public ILiveDanmakuTrackCountParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3BD RID: 54205
		// (get) Token: 0x06032366 RID: 205670 RVA: 0x006CAB74 File Offset: 0x006C8D74
		public ELiveParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveParamType.Heat;
				}
				return (ELiveParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3BE RID: 54206
		// (get) Token: 0x06032367 RID: 205671 RVA: 0x006CABB0 File Offset: 0x006C8DB0
		public int TrackCount
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

		// Token: 0x06032368 RID: 205672 RVA: 0x006CABEC File Offset: 0x006C8DEC
		public static Offset<ILiveDanmakuTrackCountParam> CreateILiveDanmakuTrackCountParam(FlatBufferBuilder builder, ELiveParamType Type = ELiveParamType.Heat, int TrackCount = 0)
		{
			builder.StartTable(2);
			ILiveDanmakuTrackCountParam.AddTrackCount(builder, TrackCount);
			ILiveDanmakuTrackCountParam.AddType(builder, Type);
			return ILiveDanmakuTrackCountParam.EndILiveDanmakuTrackCountParam(builder);
		}

		// Token: 0x06032369 RID: 205673 RVA: 0x006CAC09 File Offset: 0x006C8E09
		public static void StartILiveDanmakuTrackCountParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603236A RID: 205674 RVA: 0x006CAC12 File Offset: 0x006C8E12
		public static void AddType(FlatBufferBuilder builder, ELiveParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603236B RID: 205675 RVA: 0x006CAC1D File Offset: 0x006C8E1D
		public static void AddTrackCount(FlatBufferBuilder builder, int trackCount)
		{
			builder.AddInt(1, trackCount, 0);
		}

		// Token: 0x0603236C RID: 205676 RVA: 0x006CAC28 File Offset: 0x006C8E28
		public static Offset<ILiveDanmakuTrackCountParam> EndILiveDanmakuTrackCountParam(FlatBufferBuilder builder)
		{
			return new Offset<ILiveDanmakuTrackCountParam>(builder.EndTable());
		}

		// Token: 0x0603236D RID: 205677 RVA: 0x006CAC38 File Offset: 0x006C8E38
		public ILiveDanmakuTrackCountParamT UnPack()
		{
			ILiveDanmakuTrackCountParamT liveDanmakuTrackCountParamT = new ILiveDanmakuTrackCountParamT();
			this.UnPackTo(liveDanmakuTrackCountParamT);
			return liveDanmakuTrackCountParamT;
		}

		// Token: 0x0603236E RID: 205678 RVA: 0x006CAC53 File Offset: 0x006C8E53
		public void UnPackTo(ILiveDanmakuTrackCountParamT _o)
		{
			_o.Type = this.Type;
			_o.TrackCount = this.TrackCount;
		}

		// Token: 0x0603236F RID: 205679 RVA: 0x006CAC70 File Offset: 0x006C8E70
		public static Offset<ILiveDanmakuTrackCountParam> Pack(FlatBufferBuilder builder, ILiveDanmakuTrackCountParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveDanmakuTrackCountParam>);
			}
			return ILiveDanmakuTrackCountParam.CreateILiveDanmakuTrackCountParam(builder, _o.Type, _o.TrackCount);
		}

		// Token: 0x040120C1 RID: 73921
		private Table __p;
	}
}
