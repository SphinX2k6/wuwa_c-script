using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000086 RID: 134
	[NetMessage(EMessageId.ActivityFirstReadRequest)]
	public sealed class ActivityFirstReadRequest : IMessage<ActivityFirstReadRequest>, IMessage, IEquatable<ActivityFirstReadRequest>, IDeepCloneable<ActivityFirstReadRequest>, IBufferMessage
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x0004AD45 File Offset: 0x00048F45
		[NullableContext(1)]
		public static ActivityFirstReadRequest Create()
		{
			return new ActivityFirstReadRequest();
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0004AD4C File Offset: 0x00048F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0004AD4F File Offset: 0x00048F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityFirstReadRequest.Descriptor;
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0004AD56 File Offset: 0x00048F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadRequest()
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0004AD5E File Offset: 0x00048F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadRequest(ActivityFirstReadRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0004AD83 File Offset: 0x00048F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadRequest Clone()
		{
			return new ActivityFirstReadRequest(this);
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0004AD8B File Offset: 0x00048F8B
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0004AD93 File Offset: 0x00048F93
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

		// Token: 0x06001A70 RID: 6768 RVA: 0x0004AD9C File Offset: 0x00048F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityFirstReadRequest);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0004ADAA File Offset: 0x00048FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityFirstReadRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0004ADD8 File Offset: 0x00048FD8
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

		// Token: 0x06001A73 RID: 6771 RVA: 0x0004AE17 File Offset: 0x00049017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0004AE24 File Offset: 0x00049024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0004AE2D File Offset: 0x0004902D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0004AE60 File Offset: 0x00049060
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

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004AE9E File Offset: 0x0004909E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityFirstReadRequest other)
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

		// Token: 0x06001A78 RID: 6776 RVA: 0x0004AECF File Offset: 0x000490CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0004AED8 File Offset: 0x000490D8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400229E RID: 8862
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400229F RID: 8863
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040022A0 RID: 8864
		private int activityId_;
	}
}
