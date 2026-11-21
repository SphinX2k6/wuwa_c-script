using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008D RID: 141
	[NetMessage(EMessageId.ActivityPreOpenRequest)]
	public sealed class ActivityPreOpenRequest : IMessage<ActivityPreOpenRequest>, IMessage, IEquatable<ActivityPreOpenRequest>, IDeepCloneable<ActivityPreOpenRequest>, IBufferMessage
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
		[NullableContext(1)]
		public static ActivityPreOpenRequest Create()
		{
			return new ActivityPreOpenRequest();
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x0004C0AB File Offset: 0x0004A2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0004C0AE File Offset: 0x0004A2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPreOpenRequest.Descriptor;
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0004C0B5 File Offset: 0x0004A2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenRequest()
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0004C0BD File Offset: 0x0004A2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenRequest(ActivityPreOpenRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0004C0E2 File Offset: 0x0004A2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenRequest Clone()
		{
			return new ActivityPreOpenRequest(this);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0004C0EA File Offset: 0x0004A2EA
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0004C0F2 File Offset: 0x0004A2F2
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

		// Token: 0x06001B01 RID: 6913 RVA: 0x0004C0FB File Offset: 0x0004A2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPreOpenRequest);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0004C109 File Offset: 0x0004A309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPreOpenRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0004C138 File Offset: 0x0004A338
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

		// Token: 0x06001B04 RID: 6916 RVA: 0x0004C177 File Offset: 0x0004A377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0004C184 File Offset: 0x0004A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0004C18D File Offset: 0x0004A38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0004C1C0 File Offset: 0x0004A3C0
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

		// Token: 0x06001B08 RID: 6920 RVA: 0x0004C1FE File Offset: 0x0004A3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityPreOpenRequest other)
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

		// Token: 0x06001B09 RID: 6921 RVA: 0x0004C22F File Offset: 0x0004A42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0004C238 File Offset: 0x0004A438
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022C9 RID: 8905
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022CA RID: 8906
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040022CB RID: 8907
		private int activityId_;
	}
}
