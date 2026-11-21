using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200791D RID: 31005
	public struct ISlideRailRTPCParams : IFlatbufferObject
	{
		// Token: 0x1700E367 RID: 58215
		// (get) Token: 0x06036974 RID: 223604 RVA: 0x0074E5F5 File Offset: 0x0074C7F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036975 RID: 223605 RVA: 0x0074E602 File Offset: 0x0074C802
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036976 RID: 223606 RVA: 0x0074E60C File Offset: 0x0074C80C
		public static ISlideRailRTPCParams GetRootAsISlideRailRTPCParams(ByteBuffer _bb)
		{
			return ISlideRailRTPCParams.GetRootAsISlideRailRTPCParams(_bb, default(ISlideRailRTPCParams));
		}

		// Token: 0x06036977 RID: 223607 RVA: 0x0074E628 File Offset: 0x0074C828
		public static ISlideRailRTPCParams GetRootAsISlideRailRTPCParams(ByteBuffer _bb, ISlideRailRTPCParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036978 RID: 223608 RVA: 0x0074E645 File Offset: 0x0074C845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036979 RID: 223609 RVA: 0x0074E654 File Offset: 0x0074C854
		public ISlideRailRTPCParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E368 RID: 58216
		// (get) Token: 0x0603697A RID: 223610 RVA: 0x0074E664 File Offset: 0x0074C864
		public string RTPCName
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

		// Token: 0x0603697B RID: 223611 RVA: 0x0074E69B File Offset: 0x0074C89B
		public Span<byte> GetRTPCNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603697C RID: 223612 RVA: 0x0074E6AA File Offset: 0x0074C8AA
		public byte[] GetRTPCNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0603697D RID: 223613 RVA: 0x0074E6B8 File Offset: 0x0074C8B8
		public static Offset<ISlideRailRTPCParams> CreateISlideRailRTPCParams(FlatBufferBuilder builder, StringOffset RTPCNameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISlideRailRTPCParams.AddRTPCName(builder, RTPCNameOffset);
			return ISlideRailRTPCParams.EndISlideRailRTPCParams(builder);
		}

		// Token: 0x0603697E RID: 223614 RVA: 0x0074E6CE File Offset: 0x0074C8CE
		public static void StartISlideRailRTPCParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603697F RID: 223615 RVA: 0x0074E6D7 File Offset: 0x0074C8D7
		public static void AddRTPCName(FlatBufferBuilder builder, StringOffset rTPCNameOffset)
		{
			builder.AddOffset(0, rTPCNameOffset.Value, 0);
		}

		// Token: 0x06036980 RID: 223616 RVA: 0x0074E6E7 File Offset: 0x0074C8E7
		public static Offset<ISlideRailRTPCParams> EndISlideRailRTPCParams(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailRTPCParams>(builder.EndTable());
		}

		// Token: 0x06036981 RID: 223617 RVA: 0x0074E6F4 File Offset: 0x0074C8F4
		public ISlideRailRTPCParamsT UnPack()
		{
			ISlideRailRTPCParamsT slideRailRTPCParamsT = new ISlideRailRTPCParamsT();
			this.UnPackTo(slideRailRTPCParamsT);
			return slideRailRTPCParamsT;
		}

		// Token: 0x06036982 RID: 223618 RVA: 0x0074E70F File Offset: 0x0074C90F
		public void UnPackTo(ISlideRailRTPCParamsT _o)
		{
			_o.RTPCName = this.RTPCName;
		}

		// Token: 0x06036983 RID: 223619 RVA: 0x0074E720 File Offset: 0x0074C920
		public static Offset<ISlideRailRTPCParams> Pack(FlatBufferBuilder builder, ISlideRailRTPCParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailRTPCParams>);
			}
			StringOffset rtpcnameOffset = (_o.RTPCName == null) ? default(StringOffset) : builder.CreateString(_o.RTPCName);
			return ISlideRailRTPCParams.CreateISlideRailRTPCParams(builder, rtpcnameOffset);
		}

		// Token: 0x04012BDD RID: 76765
		private Table __p;
	}
}
