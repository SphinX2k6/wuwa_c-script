using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074B RID: 1867
	[NetMessage(EMessageId.HonamiStoryActivityInfoRequest)]
	public sealed class HonamiStoryActivityInfoRequest : IMessage<HonamiStoryActivityInfoRequest>, IMessage, IEquatable<HonamiStoryActivityInfoRequest>, IDeepCloneable<HonamiStoryActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A981 RID: 43393 RVA: 0x00198B5A File Offset: 0x00196D5A
		[NullableContext(1)]
		public static HonamiStoryActivityInfoRequest Create()
		{
			return new HonamiStoryActivityInfoRequest();
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600A982 RID: 43394 RVA: 0x00198B61 File Offset: 0x00196D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600A983 RID: 43395 RVA: 0x00198B64 File Offset: 0x00196D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x00198B6B File Offset: 0x00196D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoRequest()
		{
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x00198B73 File Offset: 0x00196D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoRequest(HonamiStoryActivityInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x00198B98 File Offset: 0x00196D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoRequest Clone()
		{
			return new HonamiStoryActivityInfoRequest(this);
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600A987 RID: 43399 RVA: 0x00198BA0 File Offset: 0x00196DA0
		// (set) Token: 0x0600A988 RID: 43400 RVA: 0x00198BA8 File Offset: 0x00196DA8
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

		// Token: 0x0600A989 RID: 43401 RVA: 0x00198BB1 File Offset: 0x00196DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivityInfoRequest);
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x00198BBF File Offset: 0x00196DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivityInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x00198BF0 File Offset: 0x00196DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x00198C2F File Offset: 0x00196E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x00198C3C File Offset: 0x00196E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x00198C45 File Offset: 0x00196E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x00198C78 File Offset: 0x00196E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x00198CB6 File Offset: 0x00196EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivityInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x00198CE7 File Offset: 0x00196EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x00198CF0 File Offset: 0x00196EF0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DAA RID: 19882
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DAB RID: 19883
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004DAC RID: 19884
		private int activityId_;
	}
}
