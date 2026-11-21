using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E69 RID: 3689
	[NetMessage(EMessageId.RacingBetsTaskRequest)]
	public sealed class RacingBetsTaskRequest : IMessage<RacingBetsTaskRequest>, IMessage, IEquatable<RacingBetsTaskRequest>, IDeepCloneable<RacingBetsTaskRequest>, IBufferMessage
	{
		// Token: 0x06013D86 RID: 81286 RVA: 0x002E47A1 File Offset: 0x002E29A1
		[NullableContext(1)]
		public static RacingBetsTaskRequest Create()
		{
			return new RacingBetsTaskRequest();
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x06013D87 RID: 81287 RVA: 0x002E47A8 File Offset: 0x002E29A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x06013D88 RID: 81288 RVA: 0x002E47AB File Offset: 0x002E29AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskRequest.Descriptor;
			}
		}

		// Token: 0x06013D89 RID: 81289 RVA: 0x002E47B2 File Offset: 0x002E29B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRequest()
		{
		}

		// Token: 0x06013D8A RID: 81290 RVA: 0x002E47BA File Offset: 0x002E29BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRequest(RacingBetsTaskRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D8B RID: 81291 RVA: 0x002E47DF File Offset: 0x002E29DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRequest Clone()
		{
			return new RacingBetsTaskRequest(this);
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x06013D8C RID: 81292 RVA: 0x002E47E7 File Offset: 0x002E29E7
		// (set) Token: 0x06013D8D RID: 81293 RVA: 0x002E47EF File Offset: 0x002E29EF
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

		// Token: 0x06013D8E RID: 81294 RVA: 0x002E47F8 File Offset: 0x002E29F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskRequest);
		}

		// Token: 0x06013D8F RID: 81295 RVA: 0x002E4806 File Offset: 0x002E2A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D90 RID: 81296 RVA: 0x002E4834 File Offset: 0x002E2A34
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

		// Token: 0x06013D91 RID: 81297 RVA: 0x002E4873 File Offset: 0x002E2A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D92 RID: 81298 RVA: 0x002E4880 File Offset: 0x002E2A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D93 RID: 81299 RVA: 0x002E4889 File Offset: 0x002E2A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D94 RID: 81300 RVA: 0x002E48BC File Offset: 0x002E2ABC
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

		// Token: 0x06013D95 RID: 81301 RVA: 0x002E48FA File Offset: 0x002E2AFA
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

		// Token: 0x06013D96 RID: 81302 RVA: 0x002E492B File Offset: 0x002E2B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D97 RID: 81303 RVA: 0x002E4934 File Offset: 0x002E2B34
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079D4 RID: 31188
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079D5 RID: 31189
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040079D6 RID: 31190
		private int activityId_;
	}
}
