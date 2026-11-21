using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000893 RID: 2195
	[NetMessage(EMessageId.KurotatoLimitTaskReceiveRequest)]
	public sealed class KurotatoLimitTaskReceiveRequest : IMessage<KurotatoLimitTaskReceiveRequest>, IMessage, IEquatable<KurotatoLimitTaskReceiveRequest>, IDeepCloneable<KurotatoLimitTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600C36A RID: 50026 RVA: 0x001CFD69 File Offset: 0x001CDF69
		[NullableContext(1)]
		public static KurotatoLimitTaskReceiveRequest Create()
		{
			return new KurotatoLimitTaskReceiveRequest();
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x0600C36B RID: 50027 RVA: 0x001CFD70 File Offset: 0x001CDF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x0600C36C RID: 50028 RVA: 0x001CFD73 File Offset: 0x001CDF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLimitTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x001CFD7A File Offset: 0x001CDF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveRequest()
		{
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x001CFD8D File Offset: 0x001CDF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveRequest(KurotatoLimitTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x001CFDB7 File Offset: 0x001CDFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveRequest Clone()
		{
			return new KurotatoLimitTaskReceiveRequest(this);
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x0600C370 RID: 50032 RVA: 0x001CFDBF File Offset: 0x001CDFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600C371 RID: 50033 RVA: 0x001CFDC7 File Offset: 0x001CDFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLimitTaskReceiveRequest);
		}

		// Token: 0x0600C372 RID: 50034 RVA: 0x001CFDD5 File Offset: 0x001CDFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLimitTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C373 RID: 50035 RVA: 0x001CFE08 File Offset: 0x001CE008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x001CFE3C File Offset: 0x001CE03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x001CFE49 File Offset: 0x001CE049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x001CFE52 File Offset: 0x001CE052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, KurotatoLimitTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x001CFE7C File Offset: 0x001CE07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(KurotatoLimitTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x001CFEB5 File Offset: 0x001CE0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLimitTaskReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x001CFEE3 File Offset: 0x001CE0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x001CFEEC File Offset: 0x001CE0EC
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, KurotatoLimitTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040054C8 RID: 21704
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C9 RID: 21705
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x040054CA RID: 21706
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040054CB RID: 21707
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
