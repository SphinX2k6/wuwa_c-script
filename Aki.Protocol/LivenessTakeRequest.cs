using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000922 RID: 2338
	[NetMessage(EMessageId.LivenessTakeRequest)]
	public sealed class LivenessTakeRequest : IMessage<LivenessTakeRequest>, IMessage, IEquatable<LivenessTakeRequest>, IDeepCloneable<LivenessTakeRequest>, IBufferMessage
	{
		// Token: 0x0600CE7C RID: 52860 RVA: 0x001E6D64 File Offset: 0x001E4F64
		[NullableContext(1)]
		public static LivenessTakeRequest Create()
		{
			return new LivenessTakeRequest();
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x0600CE7D RID: 52861 RVA: 0x001E6D6B File Offset: 0x001E4F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0600CE7E RID: 52862 RVA: 0x001E6D6E File Offset: 0x001E4F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTakeRequest.Descriptor;
			}
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x001E6D75 File Offset: 0x001E4F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeRequest()
		{
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x001E6D88 File Offset: 0x001E4F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeRequest(LivenessTakeRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x001E6DB2 File Offset: 0x001E4FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeRequest Clone()
		{
			return new LivenessTakeRequest(this);
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x0600CE82 RID: 52866 RVA: 0x001E6DBA File Offset: 0x001E4FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x001E6DC2 File Offset: 0x001E4FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTakeRequest);
		}

		// Token: 0x0600CE84 RID: 52868 RVA: 0x001E6DD0 File Offset: 0x001E4FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTakeRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE85 RID: 52869 RVA: 0x001E6E04 File Offset: 0x001E5004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE86 RID: 52870 RVA: 0x001E6E38 File Offset: 0x001E5038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x001E6E45 File Offset: 0x001E5045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE88 RID: 52872 RVA: 0x001E6E4E File Offset: 0x001E504E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, LivenessTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x001E6E78 File Offset: 0x001E5078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(LivenessTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE8A RID: 52874 RVA: 0x001E6EB1 File Offset: 0x001E50B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE8B RID: 52875 RVA: 0x001E6EDF File Offset: 0x001E50DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE8C RID: 52876 RVA: 0x001E6EE8 File Offset: 0x001E50E8
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, LivenessTakeRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005796 RID: 22422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005797 RID: 22423
		public const int IdsFieldNumber = 7;

		// Token: 0x04005798 RID: 22424
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005799 RID: 22425
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
