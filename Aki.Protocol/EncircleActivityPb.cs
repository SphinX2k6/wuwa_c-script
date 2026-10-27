using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000437 RID: 1079
	public sealed class EncircleActivityPb : IMessage<EncircleActivityPb>, IMessage, IEquatable<EncircleActivityPb>, IDeepCloneable<EncircleActivityPb>, IBufferMessage
	{
		// Token: 0x06006769 RID: 26473 RVA: 0x000F861B File Offset: 0x000F681B
		[NullableContext(1)]
		public static EncircleActivityPb Create()
		{
			return new EncircleActivityPb();
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x000F8622 File Offset: 0x000F6822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x0600676B RID: 26475 RVA: 0x000F8625 File Offset: 0x000F6825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleActivityPb.Descriptor;
			}
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x000F862C File Offset: 0x000F682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb()
		{
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x000F863F File Offset: 0x000F683F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb(EncircleActivityPb other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x000F8669 File Offset: 0x000F6869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb Clone()
		{
			return new EncircleActivityPb(this);
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x000F8671 File Offset: 0x000F6871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EncircleChallengePb> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x000F8679 File Offset: 0x000F6879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleActivityPb);
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x000F8687 File Offset: 0x000F6887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleActivityPb other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x000F86BC File Offset: 0x000F68BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challenges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x000F86F0 File Offset: 0x000F68F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x000F86FD File Offset: 0x000F68FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x000F8706 File Offset: 0x000F6906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, EncircleActivityPb._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x000F8730 File Offset: 0x000F6930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(EncircleActivityPb._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x000F8769 File Offset: 0x000F6969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x000F8797 File Offset: 0x000F6997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x000F87A0 File Offset: 0x000F69A0
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
					this.challenges_.AddEntriesFrom(ref input, EncircleActivityPb._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04003965 RID: 14693
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003966 RID: 14694
		public const int ChallengesFieldNumber = 1;

		// Token: 0x04003967 RID: 14695
		private static readonly FieldCodec<EncircleChallengePb> _repeated_challenges_codec = FieldCodec.ForMessage<EncircleChallengePb>(10U, EncircleChallengePb.Parser);

		// Token: 0x04003968 RID: 14696
		private readonly RepeatedField<EncircleChallengePb> challenges_ = new RepeatedField<EncircleChallengePb>();
	}
}
