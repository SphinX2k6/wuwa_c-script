using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005820 RID: 22560
	public struct IFollowTrackToSplineDestination : IFlatbufferObject
	{
		// Token: 0x1700A34B RID: 41803
		// (get) Token: 0x06024815 RID: 149525 RVA: 0x00503FAB File Offset: 0x005021AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024816 RID: 149526 RVA: 0x00503FB8 File Offset: 0x005021B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024817 RID: 149527 RVA: 0x00503FC0 File Offset: 0x005021C0
		public static IFollowTrackToSplineDestination GetRootAsIFollowTrackToSplineDestination(ByteBuffer _bb)
		{
			return IFollowTrackToSplineDestination.GetRootAsIFollowTrackToSplineDestination(_bb, default(IFollowTrackToSplineDestination));
		}

		// Token: 0x06024818 RID: 149528 RVA: 0x00503FDC File Offset: 0x005021DC
		public static IFollowTrackToSplineDestination GetRootAsIFollowTrackToSplineDestination(ByteBuffer _bb, IFollowTrackToSplineDestination obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024819 RID: 149529 RVA: 0x00503FF9 File Offset: 0x005021F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602481A RID: 149530 RVA: 0x00504008 File Offset: 0x00502208
		public IFollowTrackToSplineDestination __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A34C RID: 41804
		// (get) Token: 0x0602481B RID: 149531 RVA: 0x00504018 File Offset: 0x00502218
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

		// Token: 0x1700A34D RID: 41805
		// (get) Token: 0x0602481C RID: 149532 RVA: 0x00504054 File Offset: 0x00502254
		public string ChangeSelfState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602481D RID: 149533 RVA: 0x0050408B File Offset: 0x0050228B
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602481E RID: 149534 RVA: 0x0050409A File Offset: 0x0050229A
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602481F RID: 149535 RVA: 0x005040A8 File Offset: 0x005022A8
		public static Offset<IFollowTrackToSplineDestination> CreateIFollowTrackToSplineDestination(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart, StringOffset ChangeSelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFollowTrackToSplineDestination.AddChangeSelfState(builder, ChangeSelfStateOffset);
			IFollowTrackToSplineDestination.AddType(builder, Type);
			return IFollowTrackToSplineDestination.EndIFollowTrackToSplineDestination(builder);
		}

		// Token: 0x06024820 RID: 149536 RVA: 0x005040C5 File Offset: 0x005022C5
		public static void StartIFollowTrackToSplineDestination(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024821 RID: 149537 RVA: 0x005040CE File Offset: 0x005022CE
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024822 RID: 149538 RVA: 0x005040D9 File Offset: 0x005022D9
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(1, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x06024823 RID: 149539 RVA: 0x005040E9 File Offset: 0x005022E9
		public static Offset<IFollowTrackToSplineDestination> EndIFollowTrackToSplineDestination(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackToSplineDestination>(builder.EndTable());
		}

		// Token: 0x06024824 RID: 149540 RVA: 0x005040F8 File Offset: 0x005022F8
		public IFollowTrackToSplineDestinationT UnPack()
		{
			IFollowTrackToSplineDestinationT followTrackToSplineDestinationT = new IFollowTrackToSplineDestinationT();
			this.UnPackTo(followTrackToSplineDestinationT);
			return followTrackToSplineDestinationT;
		}

		// Token: 0x06024825 RID: 149541 RVA: 0x00504113 File Offset: 0x00502313
		public void UnPackTo(IFollowTrackToSplineDestinationT _o)
		{
			_o.Type = this.Type;
			_o.ChangeSelfState = this.ChangeSelfState;
		}

		// Token: 0x06024826 RID: 149542 RVA: 0x00504130 File Offset: 0x00502330
		public static Offset<IFollowTrackToSplineDestination> Pack(FlatBufferBuilder builder, IFollowTrackToSplineDestinationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackToSplineDestination>);
			}
			StringOffset changeSelfStateOffset = (_o.ChangeSelfState == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfState);
			return IFollowTrackToSplineDestination.CreateIFollowTrackToSplineDestination(builder, _o.Type, changeSelfStateOffset);
		}

		// Token: 0x0400F043 RID: 61507
		private Table __p;
	}
}
