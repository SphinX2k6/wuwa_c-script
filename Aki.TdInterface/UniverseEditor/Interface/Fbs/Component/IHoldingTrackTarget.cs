using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005936 RID: 22838
	public struct IHoldingTrackTarget : IFlatbufferObject
	{
		// Token: 0x1700A5A7 RID: 42407
		// (get) Token: 0x0602524A RID: 152138 RVA: 0x00518CAE File Offset: 0x00516EAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602524B RID: 152139 RVA: 0x00518CBB File Offset: 0x00516EBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602524C RID: 152140 RVA: 0x00518CC4 File Offset: 0x00516EC4
		public static IHoldingTrackTarget GetRootAsIHoldingTrackTarget(ByteBuffer _bb)
		{
			return IHoldingTrackTarget.GetRootAsIHoldingTrackTarget(_bb, default(IHoldingTrackTarget));
		}

		// Token: 0x0602524D RID: 152141 RVA: 0x00518CE0 File Offset: 0x00516EE0
		public static IHoldingTrackTarget GetRootAsIHoldingTrackTarget(ByteBuffer _bb, IHoldingTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602524E RID: 152142 RVA: 0x00518CFD File Offset: 0x00516EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602524F RID: 152143 RVA: 0x00518D0C File Offset: 0x00516F0C
		public IHoldingTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5A8 RID: 42408
		// (get) Token: 0x06025250 RID: 152144 RVA: 0x00518D1C File Offset: 0x00516F1C
		public string EffectPath
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

		// Token: 0x06025251 RID: 152145 RVA: 0x00518D53 File Offset: 0x00516F53
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025252 RID: 152146 RVA: 0x00518D62 File Offset: 0x00516F62
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A5A9 RID: 42409
		// (get) Token: 0x06025253 RID: 152147 RVA: 0x00518D70 File Offset: 0x00516F70
		public int EffectLength
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

		// Token: 0x1700A5AA RID: 42410
		// (get) Token: 0x06025254 RID: 152148 RVA: 0x00518DAC File Offset: 0x00516FAC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025255 RID: 152149 RVA: 0x00518DE8 File Offset: 0x00516FE8
		public static Offset<IHoldingTrackTarget> CreateIHoldingTrackTarget(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), int EffectLength = 0, int EntityId = 0)
		{
			builder.StartTable(3);
			IHoldingTrackTarget.AddEntityId(builder, EntityId);
			IHoldingTrackTarget.AddEffectLength(builder, EffectLength);
			IHoldingTrackTarget.AddEffectPath(builder, EffectPathOffset);
			return IHoldingTrackTarget.EndIHoldingTrackTarget(builder);
		}

		// Token: 0x06025256 RID: 152150 RVA: 0x00518E0C File Offset: 0x0051700C
		public static void StartIHoldingTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025257 RID: 152151 RVA: 0x00518E15 File Offset: 0x00517015
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06025258 RID: 152152 RVA: 0x00518E25 File Offset: 0x00517025
		public static void AddEffectLength(FlatBufferBuilder builder, int effectLength)
		{
			builder.AddInt(1, effectLength, 0);
		}

		// Token: 0x06025259 RID: 152153 RVA: 0x00518E30 File Offset: 0x00517030
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0602525A RID: 152154 RVA: 0x00518E3B File Offset: 0x0051703B
		public static Offset<IHoldingTrackTarget> EndIHoldingTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IHoldingTrackTarget>(builder.EndTable());
		}

		// Token: 0x0602525B RID: 152155 RVA: 0x00518E48 File Offset: 0x00517048
		public IHoldingTrackTargetT UnPack()
		{
			IHoldingTrackTargetT holdingTrackTargetT = new IHoldingTrackTargetT();
			this.UnPackTo(holdingTrackTargetT);
			return holdingTrackTargetT;
		}

		// Token: 0x0602525C RID: 152156 RVA: 0x00518E63 File Offset: 0x00517063
		public void UnPackTo(IHoldingTrackTargetT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.EffectLength = this.EffectLength;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602525D RID: 152157 RVA: 0x00518E8C File Offset: 0x0051708C
		public static Offset<IHoldingTrackTarget> Pack(FlatBufferBuilder builder, IHoldingTrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldingTrackTarget>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return IHoldingTrackTarget.CreateIHoldingTrackTarget(builder, effectPathOffset, _o.EffectLength, _o.EntityId);
		}

		// Token: 0x0400F1D9 RID: 61913
		private Table __p;
	}
}
