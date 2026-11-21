using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A3A RID: 19002
	public struct ITrapDefenseSpline : IFlatbufferObject
	{
		// Token: 0x1700854E RID: 34126
		// (get) Token: 0x0601C886 RID: 116870 RVA: 0x00406E08 File Offset: 0x00405008
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C887 RID: 116871 RVA: 0x00406E15 File Offset: 0x00405015
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C888 RID: 116872 RVA: 0x00406E1C File Offset: 0x0040501C
		public static ITrapDefenseSpline GetRootAsITrapDefenseSpline(ByteBuffer _bb)
		{
			return ITrapDefenseSpline.GetRootAsITrapDefenseSpline(_bb, default(ITrapDefenseSpline));
		}

		// Token: 0x0601C889 RID: 116873 RVA: 0x00406E38 File Offset: 0x00405038
		public static ITrapDefenseSpline GetRootAsITrapDefenseSpline(ByteBuffer _bb, ITrapDefenseSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C88A RID: 116874 RVA: 0x00406E55 File Offset: 0x00405055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C88B RID: 116875 RVA: 0x00406E64 File Offset: 0x00405064
		public ITrapDefenseSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700854F RID: 34127
		// (get) Token: 0x0601C88C RID: 116876 RVA: 0x00406E74 File Offset: 0x00405074
		public string SplineEntityId
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

		// Token: 0x0601C88D RID: 116877 RVA: 0x00406EAB File Offset: 0x004050AB
		public Span<byte> GetSplineEntityIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C88E RID: 116878 RVA: 0x00406EBA File Offset: 0x004050BA
		public byte[] GetSplineEntityIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008550 RID: 34128
		// (get) Token: 0x0601C88F RID: 116879 RVA: 0x00406EC8 File Offset: 0x004050C8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008551 RID: 34129
		// (get) Token: 0x0601C890 RID: 116880 RVA: 0x00406F08 File Offset: 0x00405108
		public float IntervalTime
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

		// Token: 0x0601C891 RID: 116881 RVA: 0x00406F48 File Offset: 0x00405148
		public static Offset<ITrapDefenseSpline> CreateITrapDefenseSpline(FlatBufferBuilder builder, StringOffset SplineEntityIdOffset = default(StringOffset), float DelayTime = 0f, float IntervalTime = 0f)
		{
			builder.StartTable(3);
			ITrapDefenseSpline.AddIntervalTime(builder, IntervalTime);
			ITrapDefenseSpline.AddDelayTime(builder, DelayTime);
			ITrapDefenseSpline.AddSplineEntityId(builder, SplineEntityIdOffset);
			return ITrapDefenseSpline.EndITrapDefenseSpline(builder);
		}

		// Token: 0x0601C892 RID: 116882 RVA: 0x00406F6C File Offset: 0x0040516C
		public static void StartITrapDefenseSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C893 RID: 116883 RVA: 0x00406F75 File Offset: 0x00405175
		public static void AddSplineEntityId(FlatBufferBuilder builder, StringOffset splineEntityIdOffset)
		{
			builder.AddOffset(0, splineEntityIdOffset.Value, 0);
		}

		// Token: 0x0601C894 RID: 116884 RVA: 0x00406F85 File Offset: 0x00405185
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0601C895 RID: 116885 RVA: 0x00406F98 File Offset: 0x00405198
		public static void AddIntervalTime(FlatBufferBuilder builder, float intervalTime)
		{
			builder.AddFloat(2, intervalTime, 0.0);
		}

		// Token: 0x0601C896 RID: 116886 RVA: 0x00406FAB File Offset: 0x004051AB
		public static Offset<ITrapDefenseSpline> EndITrapDefenseSpline(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpline>(builder.EndTable());
		}

		// Token: 0x0601C897 RID: 116887 RVA: 0x00406FB8 File Offset: 0x004051B8
		public ITrapDefenseSplineT UnPack()
		{
			ITrapDefenseSplineT trapDefenseSplineT = new ITrapDefenseSplineT();
			this.UnPackTo(trapDefenseSplineT);
			return trapDefenseSplineT;
		}

		// Token: 0x0601C898 RID: 116888 RVA: 0x00406FD3 File Offset: 0x004051D3
		public void UnPackTo(ITrapDefenseSplineT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.DelayTime = this.DelayTime;
			_o.IntervalTime = this.IntervalTime;
		}

		// Token: 0x0601C899 RID: 116889 RVA: 0x00406FFC File Offset: 0x004051FC
		public static Offset<ITrapDefenseSpline> Pack(FlatBufferBuilder builder, ITrapDefenseSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpline>);
			}
			StringOffset splineEntityIdOffset = (_o.SplineEntityId == null) ? default(StringOffset) : builder.CreateString(_o.SplineEntityId);
			return ITrapDefenseSpline.CreateITrapDefenseSpline(builder, splineEntityIdOffset, _o.DelayTime, _o.IntervalTime);
		}

		// Token: 0x0400D0D4 RID: 53460
		private Table __p;
	}
}
