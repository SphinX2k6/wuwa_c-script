using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113F RID: 4415
	[NetMessage(EMessageId.RunTurntableActivityRequest)]
	public sealed class RunTurntableActivityRequest : IMessage<RunTurntableActivityRequest>, IMessage, IEquatable<RunTurntableActivityRequest>, IDeepCloneable<RunTurntableActivityRequest>, IBufferMessage
	{
		// Token: 0x060178AC RID: 96428 RVA: 0x0036B159 File Offset: 0x00369359
		[NullableContext(1)]
		public static RunTurntableActivityRequest Create()
		{
			return new RunTurntableActivityRequest();
		}

		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x060178AD RID: 96429 RVA: 0x0036B160 File Offset: 0x00369360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x060178AE RID: 96430 RVA: 0x0036B163 File Offset: 0x00369363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTurntableActivityRequest.Descriptor;
			}
		}

		// Token: 0x060178AF RID: 96431 RVA: 0x0036B16A File Offset: 0x0036936A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityRequest()
		{
		}

		// Token: 0x060178B0 RID: 96432 RVA: 0x0036B172 File Offset: 0x00369372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityRequest(RunTurntableActivityRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060178B1 RID: 96433 RVA: 0x0036B197 File Offset: 0x00369397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityRequest Clone()
		{
			return new RunTurntableActivityRequest(this);
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x060178B2 RID: 96434 RVA: 0x0036B19F File Offset: 0x0036939F
		// (set) Token: 0x060178B3 RID: 96435 RVA: 0x0036B1A7 File Offset: 0x003693A7
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

		// Token: 0x060178B4 RID: 96436 RVA: 0x0036B1B0 File Offset: 0x003693B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTurntableActivityRequest);
		}

		// Token: 0x060178B5 RID: 96437 RVA: 0x0036B1BE File Offset: 0x003693BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTurntableActivityRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178B6 RID: 96438 RVA: 0x0036B1EC File Offset: 0x003693EC
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

		// Token: 0x060178B7 RID: 96439 RVA: 0x0036B22B File Offset: 0x0036942B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178B8 RID: 96440 RVA: 0x0036B238 File Offset: 0x00369438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178B9 RID: 96441 RVA: 0x0036B241 File Offset: 0x00369441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178BA RID: 96442 RVA: 0x0036B274 File Offset: 0x00369474
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

		// Token: 0x060178BB RID: 96443 RVA: 0x0036B2B2 File Offset: 0x003694B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RunTurntableActivityRequest other)
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

		// Token: 0x060178BC RID: 96444 RVA: 0x0036B2E3 File Offset: 0x003694E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178BD RID: 96445 RVA: 0x0036B2EC File Offset: 0x003694EC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BD5 RID: 35797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BD6 RID: 35798
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04008BD7 RID: 35799
		private int activityId_;
	}
}
