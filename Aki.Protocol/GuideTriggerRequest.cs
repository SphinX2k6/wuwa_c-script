using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000728 RID: 1832
	[NetMessage(EMessageId.GuideTriggerRequest)]
	public sealed class GuideTriggerRequest : IMessage<GuideTriggerRequest>, IMessage, IEquatable<GuideTriggerRequest>, IDeepCloneable<GuideTriggerRequest>, IBufferMessage
	{
		// Token: 0x0600A65C RID: 42588 RVA: 0x00191049 File Offset: 0x0018F249
		[NullableContext(1)]
		public static GuideTriggerRequest Create()
		{
			return new GuideTriggerRequest();
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x00191050 File Offset: 0x0018F250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x00191053 File Offset: 0x0018F253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideTriggerRequest.Descriptor;
			}
		}

		// Token: 0x0600A65F RID: 42591 RVA: 0x0019105A File Offset: 0x0018F25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerRequest()
		{
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x00191062 File Offset: 0x0018F262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerRequest(GuideTriggerRequest other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A661 RID: 42593 RVA: 0x00191087 File Offset: 0x0018F287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerRequest Clone()
		{
			return new GuideTriggerRequest(this);
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x0600A662 RID: 42594 RVA: 0x0019108F File Offset: 0x0018F28F
		// (set) Token: 0x0600A663 RID: 42595 RVA: 0x00191097 File Offset: 0x0018F297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600A664 RID: 42596 RVA: 0x001910A0 File Offset: 0x0018F2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideTriggerRequest);
		}

		// Token: 0x0600A665 RID: 42597 RVA: 0x001910AE File Offset: 0x0018F2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideTriggerRequest other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x001910DC File Offset: 0x0018F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A667 RID: 42599 RVA: 0x0019111B File Offset: 0x0018F31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x00191128 File Offset: 0x0018F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x00191131 File Offset: 0x0018F331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x00191164 File Offset: 0x0018F364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x001911A2 File Offset: 0x0018F3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideTriggerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x001911D3 File Offset: 0x0018F3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x001911DC File Offset: 0x0018F3DC
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
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C52 RID: 19538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C53 RID: 19539
		public const int GroupIdFieldNumber = 2;

		// Token: 0x04004C54 RID: 19540
		private int groupId_;
	}
}
