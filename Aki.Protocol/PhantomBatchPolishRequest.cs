using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C20 RID: 3104
	[NetMessage(EMessageId.PhantomBatchPolishRequest)]
	public sealed class PhantomBatchPolishRequest : IMessage<PhantomBatchPolishRequest>, IMessage, IEquatable<PhantomBatchPolishRequest>, IDeepCloneable<PhantomBatchPolishRequest>, IBufferMessage
	{
		// Token: 0x06010D8A RID: 69002 RVA: 0x00277909 File Offset: 0x00275B09
		[NullableContext(1)]
		public static PhantomBatchPolishRequest Create()
		{
			return new PhantomBatchPolishRequest();
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x06010D8B RID: 69003 RVA: 0x00277910 File Offset: 0x00275B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x06010D8C RID: 69004 RVA: 0x00277913 File Offset: 0x00275B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchPolishRequest.Descriptor;
			}
		}

		// Token: 0x06010D8D RID: 69005 RVA: 0x0027791A File Offset: 0x00275B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishRequest()
		{
		}

		// Token: 0x06010D8E RID: 69006 RVA: 0x0027792D File Offset: 0x00275B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishRequest(PhantomBatchPolishRequest other) : this()
		{
			this.phantomMainPropItemId_ = other.phantomMainPropItemId_;
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D8F RID: 69007 RVA: 0x00277963 File Offset: 0x00275B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishRequest Clone()
		{
			return new PhantomBatchPolishRequest(this);
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x06010D90 RID: 69008 RVA: 0x0027796B File Offset: 0x00275B6B
		// (set) Token: 0x06010D91 RID: 69009 RVA: 0x00277973 File Offset: 0x00275B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomMainPropItemId
		{
			get
			{
				return this.phantomMainPropItemId_;
			}
			set
			{
				this.phantomMainPropItemId_ = value;
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x06010D92 RID: 69010 RVA: 0x0027797C File Offset: 0x00275B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06010D93 RID: 69011 RVA: 0x00277984 File Offset: 0x00275B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchPolishRequest);
		}

		// Token: 0x06010D94 RID: 69012 RVA: 0x00277994 File Offset: 0x00275B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchPolishRequest other)
		{
			return other != null && (other == this || (this.PhantomMainPropItemId == other.PhantomMainPropItemId && this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D95 RID: 69013 RVA: 0x002779E4 File Offset: 0x00275BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomMainPropItemId != 0)
			{
				num ^= this.PhantomMainPropItemId.GetHashCode();
			}
			num ^= this.stackEntries_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010D96 RID: 69014 RVA: 0x00277A31 File Offset: 0x00275C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D97 RID: 69015 RVA: 0x00277A3E File Offset: 0x00275C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D98 RID: 69016 RVA: 0x00277A48 File Offset: 0x00275C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomBatchPolishRequest._repeated_stackEntries_codec);
			if (this.PhantomMainPropItemId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PhantomMainPropItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D99 RID: 69017 RVA: 0x00277A98 File Offset: 0x00275C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomMainPropItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomMainPropItemId);
			}
			num += this.stackEntries_.CalculateSize(PhantomBatchPolishRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010D9A RID: 69018 RVA: 0x00277AEC File Offset: 0x00275CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchPolishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomMainPropItemId != 0)
			{
				this.PhantomMainPropItemId = other.PhantomMainPropItemId;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010D9B RID: 69019 RVA: 0x00277B39 File Offset: 0x00275D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D9C RID: 69020 RVA: 0x00277B44 File Offset: 0x00275D44
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
				if (num != 42U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PhantomMainPropItemId = input.ReadInt32();
					}
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomBatchPolishRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x04006AEF RID: 27375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AF0 RID: 27376
		public const int PhantomMainPropItemIdFieldNumber = 14;

		// Token: 0x04006AF1 RID: 27377
		private int phantomMainPropItemId_;

		// Token: 0x04006AF2 RID: 27378
		public const int StackEntriesFieldNumber = 5;

		// Token: 0x04006AF3 RID: 27379
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(42U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04006AF4 RID: 27380
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
