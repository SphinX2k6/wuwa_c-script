using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A4 RID: 2212
	[NetMessage(EMessageId.KurotatoLimitTaskReceiveRequest)]
	public sealed class KurotatoLimitTaskReceiveRequest : IMessage<KurotatoLimitTaskReceiveRequest>, IMessage, IEquatable<KurotatoLimitTaskReceiveRequest>, IDeepCloneable<KurotatoLimitTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600C486 RID: 50310 RVA: 0x001D2048 File Offset: 0x001D0248
		[NullableContext(1)]
		public static KurotatoLimitTaskReceiveRequest Create()
		{
			return new KurotatoLimitTaskReceiveRequest();
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x0600C487 RID: 50311 RVA: 0x001D204F File Offset: 0x001D024F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600C488 RID: 50312 RVA: 0x001D2052 File Offset: 0x001D0252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLimitTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x001D2059 File Offset: 0x001D0259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveRequest()
		{
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x001D206C File Offset: 0x001D026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveRequest(KurotatoLimitTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x001D2096 File Offset: 0x001D0296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveRequest Clone()
		{
			return new KurotatoLimitTaskReceiveRequest(this);
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x0600C48C RID: 50316 RVA: 0x001D209E File Offset: 0x001D029E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x001D20A6 File Offset: 0x001D02A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLimitTaskReceiveRequest);
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x001D20B4 File Offset: 0x001D02B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLimitTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x001D20E8 File Offset: 0x001D02E8
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

		// Token: 0x0600C490 RID: 50320 RVA: 0x001D211C File Offset: 0x001D031C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x001D2129 File Offset: 0x001D0329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x001D2132 File Offset: 0x001D0332
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

		// Token: 0x0600C493 RID: 50323 RVA: 0x001D215C File Offset: 0x001D035C
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

		// Token: 0x0600C494 RID: 50324 RVA: 0x001D2195 File Offset: 0x001D0395
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

		// Token: 0x0600C495 RID: 50325 RVA: 0x001D21C3 File Offset: 0x001D03C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x001D21CC File Offset: 0x001D03CC
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, KurotatoLimitTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040054C1 RID: 21697
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C2 RID: 21698
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x040054C3 RID: 21699
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040054C4 RID: 21700
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
