using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001109 RID: 4361
	[NetMessage(EMessageId.RoverRogueInsListRequest)]
	public sealed class RoverRogueInsListRequest : IMessage<RoverRogueInsListRequest>, IMessage, IEquatable<RoverRogueInsListRequest>, IDeepCloneable<RoverRogueInsListRequest>, IBufferMessage
	{
		// Token: 0x06017430 RID: 95280 RVA: 0x00360CCA File Offset: 0x0035EECA
		[NullableContext(1)]
		public static RoverRogueInsListRequest Create()
		{
			return new RoverRogueInsListRequest();
		}

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06017431 RID: 95281 RVA: 0x00360CD1 File Offset: 0x0035EED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06017432 RID: 95282 RVA: 0x00360CD4 File Offset: 0x0035EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsListRequest.Descriptor;
			}
		}

		// Token: 0x06017433 RID: 95283 RVA: 0x00360CDB File Offset: 0x0035EEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListRequest()
		{
		}

		// Token: 0x06017434 RID: 95284 RVA: 0x00360CE3 File Offset: 0x0035EEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListRequest(RoverRogueInsListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017435 RID: 95285 RVA: 0x00360D08 File Offset: 0x0035EF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListRequest Clone()
		{
			return new RoverRogueInsListRequest(this);
		}

		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06017436 RID: 95286 RVA: 0x00360D10 File Offset: 0x0035EF10
		// (set) Token: 0x06017437 RID: 95287 RVA: 0x00360D18 File Offset: 0x0035EF18
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

		// Token: 0x06017438 RID: 95288 RVA: 0x00360D21 File Offset: 0x0035EF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsListRequest);
		}

		// Token: 0x06017439 RID: 95289 RVA: 0x00360D2F File Offset: 0x0035EF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601743A RID: 95290 RVA: 0x00360D60 File Offset: 0x0035EF60
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

		// Token: 0x0601743B RID: 95291 RVA: 0x00360D9F File Offset: 0x0035EF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601743C RID: 95292 RVA: 0x00360DAC File Offset: 0x0035EFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601743D RID: 95293 RVA: 0x00360DB5 File Offset: 0x0035EFB5
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

		// Token: 0x0601743E RID: 95294 RVA: 0x00360DE8 File Offset: 0x0035EFE8
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

		// Token: 0x0601743F RID: 95295 RVA: 0x00360E26 File Offset: 0x0035F026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsListRequest other)
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

		// Token: 0x06017440 RID: 95296 RVA: 0x00360E57 File Offset: 0x0035F057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017441 RID: 95297 RVA: 0x00360E60 File Offset: 0x0035F060
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

		// Token: 0x04008A6C RID: 35436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A6D RID: 35437
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04008A6E RID: 35438
		private int activityId_;
	}
}
