using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000946 RID: 2374
	[NetMessage(EMessageId.LongShanTaskRewardRequest)]
	public sealed class LongShanTaskRewardRequest : IMessage<LongShanTaskRewardRequest>, IMessage, IEquatable<LongShanTaskRewardRequest>, IDeepCloneable<LongShanTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D1AB RID: 53675 RVA: 0x001EF05A File Offset: 0x001ED25A
		[NullableContext(1)]
		public static LongShanTaskRewardRequest Create()
		{
			return new LongShanTaskRewardRequest();
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600D1AC RID: 53676 RVA: 0x001EF061 File Offset: 0x001ED261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600D1AD RID: 53677 RVA: 0x001EF064 File Offset: 0x001ED264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D1AE RID: 53678 RVA: 0x001EF06B File Offset: 0x001ED26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardRequest()
		{
		}

		// Token: 0x0600D1AF RID: 53679 RVA: 0x001EF07E File Offset: 0x001ED27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardRequest(LongShanTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x001EF0A8 File Offset: 0x001ED2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardRequest Clone()
		{
			return new LongShanTaskRewardRequest(this);
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600D1B1 RID: 53681 RVA: 0x001EF0B0 File Offset: 0x001ED2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x001EF0B8 File Offset: 0x001ED2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanTaskRewardRequest);
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x001EF0C6 File Offset: 0x001ED2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x001EF0FC File Offset: 0x001ED2FC
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

		// Token: 0x0600D1B5 RID: 53685 RVA: 0x001EF130 File Offset: 0x001ED330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x001EF13D File Offset: 0x001ED33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1B7 RID: 53687 RVA: 0x001EF146 File Offset: 0x001ED346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, LongShanTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1B8 RID: 53688 RVA: 0x001EF170 File Offset: 0x001ED370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(LongShanTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1B9 RID: 53689 RVA: 0x001EF1A9 File Offset: 0x001ED3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1BA RID: 53690 RVA: 0x001EF1D7 File Offset: 0x001ED3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1BB RID: 53691 RVA: 0x001EF1E0 File Offset: 0x001ED3E0
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
					this.taskIds_.AddEntriesFrom(ref input, LongShanTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040058B8 RID: 22712
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058B9 RID: 22713
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x040058BA RID: 22714
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040058BB RID: 22715
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
