using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081A RID: 2074
	[NetMessage(EMessageId.InspirationUpdateNotify)]
	public sealed class InspirationUpdateNotify : IMessage<InspirationUpdateNotify>, IMessage, IEquatable<InspirationUpdateNotify>, IDeepCloneable<InspirationUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B95E RID: 47454 RVA: 0x001B9539 File Offset: 0x001B7739
		[NullableContext(1)]
		public static InspirationUpdateNotify Create()
		{
			return new InspirationUpdateNotify();
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x001B9540 File Offset: 0x001B7740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x0600B960 RID: 47456 RVA: 0x001B9543 File Offset: 0x001B7743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InspirationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x001B954A File Offset: 0x001B774A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUpdateNotify()
		{
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x001B9554 File Offset: 0x001B7754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUpdateNotify(InspirationUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.inspirationData_ = ((other.inspirationData_ != null) ? other.inspirationData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x001B95A0 File Offset: 0x001B77A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUpdateNotify Clone()
		{
			return new InspirationUpdateNotify(this);
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x0600B964 RID: 47460 RVA: 0x001B95A8 File Offset: 0x001B77A8
		// (set) Token: 0x0600B965 RID: 47461 RVA: 0x001B95B0 File Offset: 0x001B77B0
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

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x0600B966 RID: 47462 RVA: 0x001B95B9 File Offset: 0x001B77B9
		// (set) Token: 0x0600B967 RID: 47463 RVA: 0x001B95C1 File Offset: 0x001B77C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData InspirationData
		{
			get
			{
				return this.inspirationData_;
			}
			set
			{
				this.inspirationData_ = value;
			}
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x001B95CA File Offset: 0x001B77CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InspirationUpdateNotify);
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x001B95D8 File Offset: 0x001B77D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InspirationUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.InspirationData, other.InspirationData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x001B9628 File Offset: 0x001B7828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.inspirationData_ != null)
			{
				num ^= this.InspirationData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x001B967D File Offset: 0x001B787D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x001B968A File Offset: 0x001B788A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x001B9694 File Offset: 0x001B7894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.inspirationData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.InspirationData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x001B96EC File Offset: 0x001B78EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.inspirationData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InspirationData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x001B9744 File Offset: 0x001B7944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InspirationUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.inspirationData_ != null)
			{
				if (this.inspirationData_ == null)
				{
					this.InspirationData = new CiacconaInspirationPbData();
				}
				this.InspirationData.MergeFrom(other.InspirationData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x001B97AC File Offset: 0x001B79AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x001B97B8 File Offset: 0x001B79B8
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
				if (num != 8U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.inspirationData_ == null)
						{
							this.InspirationData = new CiacconaInspirationPbData();
						}
						input.ReadMessage(this.InspirationData);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400517E RID: 20862
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400517F RID: 20863
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04005180 RID: 20864
		private int activityId_;

		// Token: 0x04005181 RID: 20865
		public const int InspirationDataFieldNumber = 15;

		// Token: 0x04005182 RID: 20866
		private CiacconaInspirationPbData inspirationData_;
	}
}
