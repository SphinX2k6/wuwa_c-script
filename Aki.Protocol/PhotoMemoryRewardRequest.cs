using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D27 RID: 3367
	[NetMessage(EMessageId.PhotoMemoryRewardRequest)]
	public sealed class PhotoMemoryRewardRequest : IMessage<PhotoMemoryRewardRequest>, IMessage, IEquatable<PhotoMemoryRewardRequest>, IDeepCloneable<PhotoMemoryRewardRequest>, IBufferMessage
	{
		// Token: 0x06012330 RID: 74544 RVA: 0x002A8B11 File Offset: 0x002A6D11
		[NullableContext(1)]
		public static PhotoMemoryRewardRequest Create()
		{
			return new PhotoMemoryRewardRequest();
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x06012331 RID: 74545 RVA: 0x002A8B18 File Offset: 0x002A6D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x06012332 RID: 74546 RVA: 0x002A8B1B File Offset: 0x002A6D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryRewardRequest.Descriptor;
			}
		}

		// Token: 0x06012333 RID: 74547 RVA: 0x002A8B22 File Offset: 0x002A6D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardRequest()
		{
		}

		// Token: 0x06012334 RID: 74548 RVA: 0x002A8B35 File Offset: 0x002A6D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardRequest(PhotoMemoryRewardRequest other) : this()
		{
			this.collectIds_ = other.collectIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012335 RID: 74549 RVA: 0x002A8B5F File Offset: 0x002A6D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardRequest Clone()
		{
			return new PhotoMemoryRewardRequest(this);
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x06012336 RID: 74550 RVA: 0x002A8B67 File Offset: 0x002A6D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CollectIds
		{
			get
			{
				return this.collectIds_;
			}
		}

		// Token: 0x06012337 RID: 74551 RVA: 0x002A8B6F File Offset: 0x002A6D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryRewardRequest);
		}

		// Token: 0x06012338 RID: 74552 RVA: 0x002A8B7D File Offset: 0x002A6D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryRewardRequest other)
		{
			return other != null && (other == this || (this.collectIds_.Equals(other.collectIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012339 RID: 74553 RVA: 0x002A8BB0 File Offset: 0x002A6DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.collectIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601233A RID: 74554 RVA: 0x002A8BE4 File Offset: 0x002A6DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601233B RID: 74555 RVA: 0x002A8BF1 File Offset: 0x002A6DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601233C RID: 74556 RVA: 0x002A8BFA File Offset: 0x002A6DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.collectIds_.WriteTo(ref output, PhotoMemoryRewardRequest._repeated_collectIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601233D RID: 74557 RVA: 0x002A8C24 File Offset: 0x002A6E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.collectIds_.CalculateSize(PhotoMemoryRewardRequest._repeated_collectIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601233E RID: 74558 RVA: 0x002A8C5D File Offset: 0x002A6E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.collectIds_.Add(other.collectIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601233F RID: 74559 RVA: 0x002A8C8B File Offset: 0x002A6E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012340 RID: 74560 RVA: 0x002A8C94 File Offset: 0x002A6E94
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.collectIds_.AddEntriesFrom(ref input, PhotoMemoryRewardRequest._repeated_collectIds_codec);
				}
			}
		}

		// Token: 0x04007204 RID: 29188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007205 RID: 29189
		public const int CollectIdsFieldNumber = 15;

		// Token: 0x04007206 RID: 29190
		private static readonly FieldCodec<int> _repeated_collectIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04007207 RID: 29191
		private readonly RepeatedField<int> collectIds_ = new RepeatedField<int>();
	}
}
