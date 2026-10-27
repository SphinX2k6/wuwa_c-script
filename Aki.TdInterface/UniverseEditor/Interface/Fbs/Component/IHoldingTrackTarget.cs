using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B0 RID: 21424
	public struct IHoldingTrackTarget : IFlatbufferObject
	{
		// Token: 0x17009D6F RID: 40303
		// (get) Token: 0x06023196 RID: 143766 RVA: 0x004DBDDA File Offset: 0x004D9FDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023197 RID: 143767 RVA: 0x004DBDE7 File Offset: 0x004D9FE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023198 RID: 143768 RVA: 0x004DBDF0 File Offset: 0x004D9FF0
		public static IHoldingTrackTarget GetRootAsIHoldingTrackTarget(ByteBuffer _bb)
		{
			return IHoldingTrackTarget.GetRootAsIHoldingTrackTarget(_bb, default(IHoldingTrackTarget));
		}

		// Token: 0x06023199 RID: 143769 RVA: 0x004DBE0C File Offset: 0x004DA00C
		public static IHoldingTrackTarget GetRootAsIHoldingTrackTarget(ByteBuffer _bb, IHoldingTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602319A RID: 143770 RVA: 0x004DBE29 File Offset: 0x004DA029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602319B RID: 143771 RVA: 0x004DBE38 File Offset: 0x004DA038
		public IHoldingTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D70 RID: 40304
		// (get) Token: 0x0602319C RID: 143772 RVA: 0x004DBE48 File Offset: 0x004DA048
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

		// Token: 0x0602319D RID: 143773 RVA: 0x004DBE7F File Offset: 0x004DA07F
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602319E RID: 143774 RVA: 0x004DBE8E File Offset: 0x004DA08E
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009D71 RID: 40305
		// (get) Token: 0x0602319F RID: 143775 RVA: 0x004DBE9C File Offset: 0x004DA09C
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

		// Token: 0x17009D72 RID: 40306
		// (get) Token: 0x060231A0 RID: 143776 RVA: 0x004DBED8 File Offset: 0x004DA0D8
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

		// Token: 0x060231A1 RID: 143777 RVA: 0x004DBF14 File Offset: 0x004DA114
		public static Offset<IHoldingTrackTarget> CreateIHoldingTrackTarget(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), int EffectLength = 0, int EntityId = 0)
		{
			builder.StartTable(3);
			IHoldingTrackTarget.AddEntityId(builder, EntityId);
			IHoldingTrackTarget.AddEffectLength(builder, EffectLength);
			IHoldingTrackTarget.AddEffectPath(builder, EffectPathOffset);
			return IHoldingTrackTarget.EndIHoldingTrackTarget(builder);
		}

		// Token: 0x060231A2 RID: 143778 RVA: 0x004DBF38 File Offset: 0x004DA138
		public static void StartIHoldingTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060231A3 RID: 143779 RVA: 0x004DBF41 File Offset: 0x004DA141
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x060231A4 RID: 143780 RVA: 0x004DBF51 File Offset: 0x004DA151
		public static void AddEffectLength(FlatBufferBuilder builder, int effectLength)
		{
			builder.AddInt(1, effectLength, 0);
		}

		// Token: 0x060231A5 RID: 143781 RVA: 0x004DBF5C File Offset: 0x004DA15C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x060231A6 RID: 143782 RVA: 0x004DBF67 File Offset: 0x004DA167
		public static Offset<IHoldingTrackTarget> EndIHoldingTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IHoldingTrackTarget>(builder.EndTable());
		}

		// Token: 0x060231A7 RID: 143783 RVA: 0x004DBF74 File Offset: 0x004DA174
		public IHoldingTrackTargetT UnPack()
		{
			IHoldingTrackTargetT holdingTrackTargetT = new IHoldingTrackTargetT();
			this.UnPackTo(holdingTrackTargetT);
			return holdingTrackTargetT;
		}

		// Token: 0x060231A8 RID: 143784 RVA: 0x004DBF8F File Offset: 0x004DA18F
		public void UnPackTo(IHoldingTrackTargetT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.EffectLength = this.EffectLength;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060231A9 RID: 143785 RVA: 0x004DBFB8 File Offset: 0x004DA1B8
		public static Offset<IHoldingTrackTarget> Pack(FlatBufferBuilder builder, IHoldingTrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldingTrackTarget>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return IHoldingTrackTarget.CreateIHoldingTrackTarget(builder, effectPathOffset, _o.EffectLength, _o.EntityId);
		}

		// Token: 0x0400E5A9 RID: 58793
		private Table __p;
	}
}
