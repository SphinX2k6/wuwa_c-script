using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000818 RID: 2072
	[NetMessage(EMessageId.InspirationUnlockChoiceRequest)]
	public sealed class InspirationUnlockChoiceRequest : IMessage<InspirationUnlockChoiceRequest>, IMessage, IEquatable<InspirationUnlockChoiceRequest>, IDeepCloneable<InspirationUnlockChoiceRequest>, IBufferMessage
	{
		// Token: 0x0600B936 RID: 47414 RVA: 0x001B9011 File Offset: 0x001B7211
		[NullableContext(1)]
		public static InspirationUnlockChoiceRequest Create()
		{
			return new InspirationUnlockChoiceRequest();
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x0600B937 RID: 47415 RVA: 0x001B9018 File Offset: 0x001B7218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x0600B938 RID: 47416 RVA: 0x001B901B File Offset: 0x001B721B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InspirationUnlockChoiceRequest.Descriptor;
			}
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x001B9022 File Offset: 0x001B7222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceRequest()
		{
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x001B902A File Offset: 0x001B722A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceRequest(InspirationUnlockChoiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.choiceId_ = other.choiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x001B9067 File Offset: 0x001B7267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceRequest Clone()
		{
			return new InspirationUnlockChoiceRequest(this);
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x0600B93C RID: 47420 RVA: 0x001B906F File Offset: 0x001B726F
		// (set) Token: 0x0600B93D RID: 47421 RVA: 0x001B9077 File Offset: 0x001B7277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x0600B93E RID: 47422 RVA: 0x001B9080 File Offset: 0x001B7280
		// (set) Token: 0x0600B93F RID: 47423 RVA: 0x001B9088 File Offset: 0x001B7288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600B940 RID: 47424 RVA: 0x001B9091 File Offset: 0x001B7291
		// (set) Token: 0x0600B941 RID: 47425 RVA: 0x001B9099 File Offset: 0x001B7299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChoiceId
		{
			get
			{
				return this.choiceId_;
			}
			set
			{
				this.choiceId_ = value;
			}
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x001B90A2 File Offset: 0x001B72A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InspirationUnlockChoiceRequest);
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x001B90B0 File Offset: 0x001B72B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InspirationUnlockChoiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.ChoiceId == other.ChoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x001B910C File Offset: 0x001B730C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.ChoiceId != 0)
			{
				num ^= this.ChoiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x001B917D File Offset: 0x001B737D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x001B918A File Offset: 0x001B738A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x001B9194 File Offset: 0x001B7394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChapterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x001B920C File Offset: 0x001B740C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.ChoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChoiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x001B927C File Offset: 0x001B747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InspirationUnlockChoiceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x001B92E0 File Offset: 0x001B74E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x001B92EC File Offset: 0x001B74EC
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
				if (num != 72U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChapterId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ChoiceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005174 RID: 20852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005175 RID: 20853
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04005176 RID: 20854
		private int activityId_;

		// Token: 0x04005177 RID: 20855
		public const int ChapterIdFieldNumber = 14;

		// Token: 0x04005178 RID: 20856
		private int chapterId_;

		// Token: 0x04005179 RID: 20857
		public const int ChoiceIdFieldNumber = 9;

		// Token: 0x0400517A RID: 20858
		private int choiceId_;
	}
}
