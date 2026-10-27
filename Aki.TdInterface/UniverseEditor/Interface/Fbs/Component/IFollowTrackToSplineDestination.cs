using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B5 RID: 21173
	public struct IFollowTrackToSplineDestination : IFlatbufferObject
	{
		// Token: 0x17009B42 RID: 39746
		// (get) Token: 0x06022851 RID: 141393 RVA: 0x004C8EAF File Offset: 0x004C70AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022852 RID: 141394 RVA: 0x004C8EBC File Offset: 0x004C70BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022853 RID: 141395 RVA: 0x004C8EC4 File Offset: 0x004C70C4
		public static IFollowTrackToSplineDestination GetRootAsIFollowTrackToSplineDestination(ByteBuffer _bb)
		{
			return IFollowTrackToSplineDestination.GetRootAsIFollowTrackToSplineDestination(_bb, default(IFollowTrackToSplineDestination));
		}

		// Token: 0x06022854 RID: 141396 RVA: 0x004C8EE0 File Offset: 0x004C70E0
		public static IFollowTrackToSplineDestination GetRootAsIFollowTrackToSplineDestination(ByteBuffer _bb, IFollowTrackToSplineDestination obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022855 RID: 141397 RVA: 0x004C8EFD File Offset: 0x004C70FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022856 RID: 141398 RVA: 0x004C8F0C File Offset: 0x004C710C
		public IFollowTrackToSplineDestination __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B43 RID: 39747
		// (get) Token: 0x06022857 RID: 141399 RVA: 0x004C8F1C File Offset: 0x004C711C
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

		// Token: 0x17009B44 RID: 39748
		// (get) Token: 0x06022858 RID: 141400 RVA: 0x004C8F58 File Offset: 0x004C7158
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

		// Token: 0x06022859 RID: 141401 RVA: 0x004C8F8F File Offset: 0x004C718F
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602285A RID: 141402 RVA: 0x004C8F9E File Offset: 0x004C719E
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602285B RID: 141403 RVA: 0x004C8FAC File Offset: 0x004C71AC
		public static Offset<IFollowTrackToSplineDestination> CreateIFollowTrackToSplineDestination(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart, StringOffset ChangeSelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFollowTrackToSplineDestination.AddChangeSelfState(builder, ChangeSelfStateOffset);
			IFollowTrackToSplineDestination.AddType(builder, Type);
			return IFollowTrackToSplineDestination.EndIFollowTrackToSplineDestination(builder);
		}

		// Token: 0x0602285C RID: 141404 RVA: 0x004C8FC9 File Offset: 0x004C71C9
		public static void StartIFollowTrackToSplineDestination(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602285D RID: 141405 RVA: 0x004C8FD2 File Offset: 0x004C71D2
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602285E RID: 141406 RVA: 0x004C8FDD File Offset: 0x004C71DD
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(1, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x0602285F RID: 141407 RVA: 0x004C8FED File Offset: 0x004C71ED
		public static Offset<IFollowTrackToSplineDestination> EndIFollowTrackToSplineDestination(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackToSplineDestination>(builder.EndTable());
		}

		// Token: 0x06022860 RID: 141408 RVA: 0x004C8FFC File Offset: 0x004C71FC
		public IFollowTrackToSplineDestinationT UnPack()
		{
			IFollowTrackToSplineDestinationT followTrackToSplineDestinationT = new IFollowTrackToSplineDestinationT();
			this.UnPackTo(followTrackToSplineDestinationT);
			return followTrackToSplineDestinationT;
		}

		// Token: 0x06022861 RID: 141409 RVA: 0x004C9017 File Offset: 0x004C7217
		public void UnPackTo(IFollowTrackToSplineDestinationT _o)
		{
			_o.Type = this.Type;
			_o.ChangeSelfState = this.ChangeSelfState;
		}

		// Token: 0x06022862 RID: 141410 RVA: 0x004C9034 File Offset: 0x004C7234
		public static Offset<IFollowTrackToSplineDestination> Pack(FlatBufferBuilder builder, IFollowTrackToSplineDestinationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackToSplineDestination>);
			}
			StringOffset changeSelfStateOffset = (_o.ChangeSelfState == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfState);
			return IFollowTrackToSplineDestination.CreateIFollowTrackToSplineDestination(builder, _o.Type, changeSelfStateOffset);
		}

		// Token: 0x0400E436 RID: 58422
		private Table __p;
	}
}
