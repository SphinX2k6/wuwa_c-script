using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006918 RID: 26904
	public struct IHonamiStoryActivateSafeEvacuation : IFlatbufferObject
	{
		// Token: 0x1700C7A2 RID: 51106
		// (get) Token: 0x0602EF7A RID: 192378 RVA: 0x00667A3F File Offset: 0x00665C3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF7B RID: 192379 RVA: 0x00667A4C File Offset: 0x00665C4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF7C RID: 192380 RVA: 0x00667A54 File Offset: 0x00665C54
		public static IHonamiStoryActivateSafeEvacuation GetRootAsIHonamiStoryActivateSafeEvacuation(ByteBuffer _bb)
		{
			return IHonamiStoryActivateSafeEvacuation.GetRootAsIHonamiStoryActivateSafeEvacuation(_bb, default(IHonamiStoryActivateSafeEvacuation));
		}

		// Token: 0x0602EF7D RID: 192381 RVA: 0x00667A70 File Offset: 0x00665C70
		public static IHonamiStoryActivateSafeEvacuation GetRootAsIHonamiStoryActivateSafeEvacuation(ByteBuffer _bb, IHonamiStoryActivateSafeEvacuation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EF7E RID: 192382 RVA: 0x00667A8D File Offset: 0x00665C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EF7F RID: 192383 RVA: 0x00667A9C File Offset: 0x00665C9C
		public IHonamiStoryActivateSafeEvacuation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EF80 RID: 192384 RVA: 0x00667AAC File Offset: 0x00665CAC
		public static void StartIHonamiStoryActivateSafeEvacuation(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602EF81 RID: 192385 RVA: 0x00667AB5 File Offset: 0x00665CB5
		public static Offset<IHonamiStoryActivateSafeEvacuation> EndIHonamiStoryActivateSafeEvacuation(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryActivateSafeEvacuation>(builder.EndTable());
		}

		// Token: 0x0602EF82 RID: 192386 RVA: 0x00667AC4 File Offset: 0x00665CC4
		public IHonamiStoryActivateSafeEvacuationT UnPack()
		{
			IHonamiStoryActivateSafeEvacuationT honamiStoryActivateSafeEvacuationT = new IHonamiStoryActivateSafeEvacuationT();
			this.UnPackTo(honamiStoryActivateSafeEvacuationT);
			return honamiStoryActivateSafeEvacuationT;
		}

		// Token: 0x0602EF83 RID: 192387 RVA: 0x00667ADF File Offset: 0x00665CDF
		public void UnPackTo(IHonamiStoryActivateSafeEvacuationT _o)
		{
		}

		// Token: 0x0602EF84 RID: 192388 RVA: 0x00667AE4 File Offset: 0x00665CE4
		public static Offset<IHonamiStoryActivateSafeEvacuation> Pack(FlatBufferBuilder builder, IHonamiStoryActivateSafeEvacuationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryActivateSafeEvacuation>);
			}
			IHonamiStoryActivateSafeEvacuation.StartIHonamiStoryActivateSafeEvacuation(builder);
			return IHonamiStoryActivateSafeEvacuation.EndIHonamiStoryActivateSafeEvacuation(builder);
		}

		// Token: 0x04011095 RID: 69781
		private Table __p;
	}
}
