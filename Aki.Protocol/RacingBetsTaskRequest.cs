using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E79 RID: 3705
	[NetMessage(EMessageId.RacingBetsTaskRequest)]
	public sealed class RacingBetsTaskRequest : IMessage<RacingBetsTaskRequest>, IMessage, IEquatable<RacingBetsTaskRequest>, IDeepCloneable<RacingBetsTaskRequest>, IBufferMessage
	{
		// Token: 0x06013E6B RID: 81515 RVA: 0x002E5E61 File Offset: 0x002E4061
		[NullableContext(1)]
		public static RacingBetsTaskRequest Create()
		{
			return new RacingBetsTaskRequest();
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x06013E6C RID: 81516 RVA: 0x002E5E68 File Offset: 0x002E4068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x06013E6D RID: 81517 RVA: 0x002E5E6B File Offset: 0x002E406B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskRequest.Descriptor;
			}
		}

		// Token: 0x06013E6E RID: 81518 RVA: 0x002E5E72 File Offset: 0x002E4072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRequest()
		{
		}

		// Token: 0x06013E6F RID: 81519 RVA: 0x002E5E7A File Offset: 0x002E407A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRequest(RacingBetsTaskRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E70 RID: 81520 RVA: 0x002E5E9F File Offset: 0x002E409F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRequest Clone()
		{
			return new RacingBetsTaskRequest(this);
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x06013E71 RID: 81521 RVA: 0x002E5EA7 File Offset: 0x002E40A7
		// (set) Token: 0x06013E72 RID: 81522 RVA: 0x002E5EAF File Offset: 0x002E40AF
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

		// Token: 0x06013E73 RID: 81523 RVA: 0x002E5EB8 File Offset: 0x002E40B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskRequest);
		}

		// Token: 0x06013E74 RID: 81524 RVA: 0x002E5EC6 File Offset: 0x002E40C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E75 RID: 81525 RVA: 0x002E5EF4 File Offset: 0x002E40F4
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

		// Token: 0x06013E76 RID: 81526 RVA: 0x002E5F33 File Offset: 0x002E4133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E77 RID: 81527 RVA: 0x002E5F40 File Offset: 0x002E4140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E78 RID: 81528 RVA: 0x002E5F49 File Offset: 0x002E4149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E79 RID: 81529 RVA: 0x002E5F7C File Offset: 0x002E417C
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

		// Token: 0x06013E7A RID: 81530 RVA: 0x002E5FBA File Offset: 0x002E41BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskRequest other)
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

		// Token: 0x06013E7B RID: 81531 RVA: 0x002E5FEB File Offset: 0x002E41EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E7C RID: 81532 RVA: 0x002E5FF4 File Offset: 0x002E41F4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079AA RID: 31146
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079AB RID: 31147
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040079AC RID: 31148
		private int activityId_;
	}
}
