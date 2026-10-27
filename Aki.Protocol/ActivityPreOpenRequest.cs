using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008C RID: 140
	[NetMessage(EMessageId.ActivityPreOpenRequest)]
	public sealed class ActivityPreOpenRequest : IMessage<ActivityPreOpenRequest>, IMessage, IEquatable<ActivityPreOpenRequest>, IDeepCloneable<ActivityPreOpenRequest>, IBufferMessage
	{
		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004B494 File Offset: 0x00049694
		[NullableContext(1)]
		public static ActivityPreOpenRequest Create()
		{
			return new ActivityPreOpenRequest();
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0004B49B File Offset: 0x0004969B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0004B49E File Offset: 0x0004969E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPreOpenRequest.Descriptor;
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0004B4A5 File Offset: 0x000496A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenRequest()
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0004B4AD File Offset: 0x000496AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenRequest(ActivityPreOpenRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0004B4D2 File Offset: 0x000496D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenRequest Clone()
		{
			return new ActivityPreOpenRequest(this);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0004B4DA File Offset: 0x000496DA
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0004B4E2 File Offset: 0x000496E2
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

		// Token: 0x06001ABA RID: 6842 RVA: 0x0004B4EB File Offset: 0x000496EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPreOpenRequest);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004B4F9 File Offset: 0x000496F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPreOpenRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0004B528 File Offset: 0x00049728
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

		// Token: 0x06001ABD RID: 6845 RVA: 0x0004B567 File Offset: 0x00049767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0004B574 File Offset: 0x00049774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0004B57D File Offset: 0x0004977D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0004B5B0 File Offset: 0x000497B0
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

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0004B5EE File Offset: 0x000497EE
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

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0004B61F File Offset: 0x0004981F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0004B628 File Offset: 0x00049828
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002268 RID: 8808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002269 RID: 8809
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400226A RID: 8810
		private int activityId_;
	}
}
