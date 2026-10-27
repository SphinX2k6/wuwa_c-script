using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000552 RID: 1362
	[NetMessage(EMessageId.FishingEntrustHandInRequest)]
	public sealed class FishingEntrustHandInRequest : IMessage<FishingEntrustHandInRequest>, IMessage, IEquatable<FishingEntrustHandInRequest>, IDeepCloneable<FishingEntrustHandInRequest>, IBufferMessage
	{
		// Token: 0x06007F3D RID: 32573 RVA: 0x00133D41 File Offset: 0x00131F41
		[NullableContext(1)]
		public static FishingEntrustHandInRequest Create()
		{
			return new FishingEntrustHandInRequest();
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06007F3E RID: 32574 RVA: 0x00133D48 File Offset: 0x00131F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06007F3F RID: 32575 RVA: 0x00133D4B File Offset: 0x00131F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustHandInRequest.Descriptor;
			}
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x00133D52 File Offset: 0x00131F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInRequest()
		{
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x00133D65 File Offset: 0x00131F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInRequest(FishingEntrustHandInRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.handInItem_ = other.handInItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00133D9B File Offset: 0x00131F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInRequest Clone()
		{
			return new FishingEntrustHandInRequest(this);
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06007F43 RID: 32579 RVA: 0x00133DA3 File Offset: 0x00131FA3
		// (set) Token: 0x06007F44 RID: 32580 RVA: 0x00133DAB File Offset: 0x00131FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06007F45 RID: 32581 RVA: 0x00133DB4 File Offset: 0x00131FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingHandInItem> HandInItem
		{
			get
			{
				return this.handInItem_;
			}
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00133DBC File Offset: 0x00131FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustHandInRequest);
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x00133DCC File Offset: 0x00131FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustHandInRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.handInItem_.Equals(other.handInItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00133E1C File Offset: 0x0013201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			num ^= this.handInItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x00133E69 File Offset: 0x00132069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x00133E76 File Offset: 0x00132076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x00133E80 File Offset: 0x00132080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EntrustId);
			}
			this.handInItem_.WriteTo(ref output, FishingEntrustHandInRequest._repeated_handInItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x00133ED0 File Offset: 0x001320D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			num += this.handInItem_.CalculateSize(FishingEntrustHandInRequest._repeated_handInItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x00133F24 File Offset: 0x00132124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustHandInRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this.handInItem_.Add(other.handInItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x00133F71 File Offset: 0x00132171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x00133F7C File Offset: 0x0013217C
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
				if (num != 40U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.handInItem_.AddEntriesFrom(ref input, FishingEntrustHandInRequest._repeated_handInItem_codec);
					}
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004055 RID: 16469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004056 RID: 16470
		public const int EntrustIdFieldNumber = 5;

		// Token: 0x04004057 RID: 16471
		private int entrustId_;

		// Token: 0x04004058 RID: 16472
		public const int HandInItemFieldNumber = 10;

		// Token: 0x04004059 RID: 16473
		private static readonly FieldCodec<FishingHandInItem> _repeated_handInItem_codec = FieldCodec.ForMessage<FishingHandInItem>(82U, FishingHandInItem.Parser);

		// Token: 0x0400405A RID: 16474
		private readonly RepeatedField<FishingHandInItem> handInItem_ = new RepeatedField<FishingHandInItem>();
	}
}
