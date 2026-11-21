using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E49 RID: 3657
	public sealed class RacingBetsDiceInfo : IMessage<RacingBetsDiceInfo>, IMessage, IEquatable<RacingBetsDiceInfo>, IDeepCloneable<RacingBetsDiceInfo>, IBufferMessage
	{
		// Token: 0x06013A8F RID: 80527 RVA: 0x002DC1B8 File Offset: 0x002DA3B8
		[NullableContext(1)]
		public static RacingBetsDiceInfo Create()
		{
			return new RacingBetsDiceInfo();
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x06013A90 RID: 80528 RVA: 0x002DC1BF File Offset: 0x002DA3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x06013A91 RID: 80529 RVA: 0x002DC1C2 File Offset: 0x002DA3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDiceInfo.Descriptor;
			}
		}

		// Token: 0x06013A92 RID: 80530 RVA: 0x002DC1C9 File Offset: 0x002DA3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo()
		{
		}

		// Token: 0x06013A93 RID: 80531 RVA: 0x002DC1DC File Offset: 0x002DA3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo(RacingBetsDiceInfo other) : this()
		{
			this.diceInfo_ = other.diceInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A94 RID: 80532 RVA: 0x002DC206 File Offset: 0x002DA406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo Clone()
		{
			return new RacingBetsDiceInfo(this);
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x06013A95 RID: 80533 RVA: 0x002DC20E File Offset: 0x002DA40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoIdToDiceNum> DiceInfo
		{
			get
			{
				return this.diceInfo_;
			}
		}

		// Token: 0x06013A96 RID: 80534 RVA: 0x002DC216 File Offset: 0x002DA416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDiceInfo);
		}

		// Token: 0x06013A97 RID: 80535 RVA: 0x002DC224 File Offset: 0x002DA424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDiceInfo other)
		{
			return other != null && (other == this || (this.diceInfo_.Equals(other.diceInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A98 RID: 80536 RVA: 0x002DC258 File Offset: 0x002DA458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.diceInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A99 RID: 80537 RVA: 0x002DC28C File Offset: 0x002DA48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A9A RID: 80538 RVA: 0x002DC299 File Offset: 0x002DA499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A9B RID: 80539 RVA: 0x002DC2A2 File Offset: 0x002DA4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.diceInfo_.WriteTo(ref output, RacingBetsDiceInfo._repeated_diceInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A9C RID: 80540 RVA: 0x002DC2CC File Offset: 0x002DA4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.diceInfo_.CalculateSize(RacingBetsDiceInfo._repeated_diceInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A9D RID: 80541 RVA: 0x002DC305 File Offset: 0x002DA505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDiceInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.diceInfo_.Add(other.diceInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A9E RID: 80542 RVA: 0x002DC333 File Offset: 0x002DA533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A9F RID: 80543 RVA: 0x002DC33C File Offset: 0x002DA53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.diceInfo_.AddEntriesFrom(ref input, RacingBetsDiceInfo._repeated_diceInfo_codec);
				}
			}
		}

		// Token: 0x040078BA RID: 30906
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078BB RID: 30907
		public const int DiceInfoFieldNumber = 1;

		// Token: 0x040078BC RID: 30908
		private static readonly FieldCodec<DangoIdToDiceNum> _repeated_diceInfo_codec = FieldCodec.ForMessage<DangoIdToDiceNum>(10U, DangoIdToDiceNum.Parser);

		// Token: 0x040078BD RID: 30909
		private readonly RepeatedField<DangoIdToDiceNum> diceInfo_ = new RepeatedField<DangoIdToDiceNum>();
	}
}
