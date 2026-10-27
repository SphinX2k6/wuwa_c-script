using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B2 RID: 21170
	public struct IFollowTrackToFoundation : IFlatbufferObject
	{
		// Token: 0x17009B3B RID: 39739
		// (get) Token: 0x06022837 RID: 141367 RVA: 0x004C8B96 File Offset: 0x004C6D96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022838 RID: 141368 RVA: 0x004C8BA3 File Offset: 0x004C6DA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022839 RID: 141369 RVA: 0x004C8BAC File Offset: 0x004C6DAC
		public static IFollowTrackToFoundation GetRootAsIFollowTrackToFoundation(ByteBuffer _bb)
		{
			return IFollowTrackToFoundation.GetRootAsIFollowTrackToFoundation(_bb, default(IFollowTrackToFoundation));
		}

		// Token: 0x0602283A RID: 141370 RVA: 0x004C8BC8 File Offset: 0x004C6DC8
		public static IFollowTrackToFoundation GetRootAsIFollowTrackToFoundation(ByteBuffer _bb, IFollowTrackToFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602283B RID: 141371 RVA: 0x004C8BE5 File Offset: 0x004C6DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602283C RID: 141372 RVA: 0x004C8BF4 File Offset: 0x004C6DF4
		public IFollowTrackToFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B3C RID: 39740
		// (get) Token: 0x0602283D RID: 141373 RVA: 0x004C8C04 File Offset: 0x004C6E04
		public EFollowTrackEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowTrackEndType.ToStart;
				}
				return (EFollowTrackEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B3D RID: 39741
		// (get) Token: 0x0602283E RID: 141374 RVA: 0x004C8C40 File Offset: 0x004C6E40
		public int FoundationId
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

		// Token: 0x17009B3E RID: 39742
		// (get) Token: 0x0602283F RID: 141375 RVA: 0x004C8C7C File Offset: 0x004C6E7C
		public IVectorInfo? FinalOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022840 RID: 141376 RVA: 0x004C8CD9 File Offset: 0x004C6ED9
		public static Offset<IFollowTrackToFoundation> CreateIFollowTrackToFoundation(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart, int FoundationId = 0, Offset<IVectorInfo> FinalOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IFollowTrackToFoundation.AddFinalOffset(builder, FinalOffsetOffset);
			IFollowTrackToFoundation.AddFoundationId(builder, FoundationId);
			IFollowTrackToFoundation.AddType(builder, Type);
			return IFollowTrackToFoundation.EndIFollowTrackToFoundation(builder);
		}

		// Token: 0x06022841 RID: 141377 RVA: 0x004C8CFD File Offset: 0x004C6EFD
		public static void StartIFollowTrackToFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022842 RID: 141378 RVA: 0x004C8D06 File Offset: 0x004C6F06
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022843 RID: 141379 RVA: 0x004C8D11 File Offset: 0x004C6F11
		public static void AddFoundationId(FlatBufferBuilder builder, int foundationId)
		{
			builder.AddInt(1, foundationId, 0);
		}

		// Token: 0x06022844 RID: 141380 RVA: 0x004C8D1C File Offset: 0x004C6F1C
		public static void AddFinalOffset(FlatBufferBuilder builder, Offset<IVectorInfo> finalOffsetOffset)
		{
			builder.AddOffset(2, finalOffsetOffset.Value, 0);
		}

		// Token: 0x06022845 RID: 141381 RVA: 0x004C8D2C File Offset: 0x004C6F2C
		public static Offset<IFollowTrackToFoundation> EndIFollowTrackToFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackToFoundation>(builder.EndTable());
		}

		// Token: 0x06022846 RID: 141382 RVA: 0x004C8D3C File Offset: 0x004C6F3C
		public IFollowTrackToFoundationT UnPack()
		{
			IFollowTrackToFoundationT followTrackToFoundationT = new IFollowTrackToFoundationT();
			this.UnPackTo(followTrackToFoundationT);
			return followTrackToFoundationT;
		}

		// Token: 0x06022847 RID: 141383 RVA: 0x004C8D58 File Offset: 0x004C6F58
		public void UnPackTo(IFollowTrackToFoundationT _o)
		{
			_o.Type = this.Type;
			_o.FoundationId = this.FoundationId;
			_o.FinalOffset = ((this.FinalOffset != null) ? this.FinalOffset.Value.UnPack() : null);
		}

		// Token: 0x06022848 RID: 141384 RVA: 0x004C8DAC File Offset: 0x004C6FAC
		public static Offset<IFollowTrackToFoundation> Pack(FlatBufferBuilder builder, IFollowTrackToFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackToFoundation>);
			}
			Offset<IVectorInfo> finalOffsetOffset = (_o.FinalOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.FinalOffset);
			return IFollowTrackToFoundation.CreateIFollowTrackToFoundation(builder, _o.Type, _o.FoundationId, finalOffsetOffset);
		}

		// Token: 0x0400E432 RID: 58418
		private Table __p;
	}
}
