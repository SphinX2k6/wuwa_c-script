using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000806 RID: 2054
	[NetMessage(EMessageId.InspirationUpdateNotify)]
	public sealed class InspirationUpdateNotify : IMessage<InspirationUpdateNotify>, IMessage, IEquatable<InspirationUpdateNotify>, IDeepCloneable<InspirationUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B808 RID: 47112 RVA: 0x001B6AF9 File Offset: 0x001B4CF9
		[NullableContext(1)]
		public static InspirationUpdateNotify Create()
		{
			return new InspirationUpdateNotify();
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600B809 RID: 47113 RVA: 0x001B6B00 File Offset: 0x001B4D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600B80A RID: 47114 RVA: 0x001B6B03 File Offset: 0x001B4D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InspirationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x001B6B0A File Offset: 0x001B4D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUpdateNotify()
		{
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x001B6B14 File Offset: 0x001B4D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUpdateNotify(InspirationUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.inspirationData_ = ((other.inspirationData_ != null) ? other.inspirationData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x001B6B60 File Offset: 0x001B4D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUpdateNotify Clone()
		{
			return new InspirationUpdateNotify(this);
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600B80E RID: 47118 RVA: 0x001B6B68 File Offset: 0x001B4D68
		// (set) Token: 0x0600B80F RID: 47119 RVA: 0x001B6B70 File Offset: 0x001B4D70
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

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x0600B810 RID: 47120 RVA: 0x001B6B79 File Offset: 0x001B4D79
		// (set) Token: 0x0600B811 RID: 47121 RVA: 0x001B6B81 File Offset: 0x001B4D81
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

		// Token: 0x0600B812 RID: 47122 RVA: 0x001B6B8A File Offset: 0x001B4D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InspirationUpdateNotify);
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x001B6B98 File Offset: 0x001B4D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InspirationUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.InspirationData, other.InspirationData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x001B6BE8 File Offset: 0x001B4DE8
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

		// Token: 0x0600B815 RID: 47125 RVA: 0x001B6C3D File Offset: 0x001B4E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x001B6C4A File Offset: 0x001B4E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x001B6C54 File Offset: 0x001B4E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inspirationData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InspirationData);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x001B6CB0 File Offset: 0x001B4EB0
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

		// Token: 0x0600B819 RID: 47129 RVA: 0x001B6D08 File Offset: 0x001B4F08
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

		// Token: 0x0600B81A RID: 47130 RVA: 0x001B6D70 File Offset: 0x001B4F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x001B6D7C File Offset: 0x001B4F7C
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
				if (num != 34U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
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
		}

		// Token: 0x04005177 RID: 20855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005178 RID: 20856
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04005179 RID: 20857
		private int activityId_;

		// Token: 0x0400517A RID: 20858
		public const int InspirationDataFieldNumber = 4;

		// Token: 0x0400517B RID: 20859
		private CiacconaInspirationPbData inspirationData_;
	}
}
