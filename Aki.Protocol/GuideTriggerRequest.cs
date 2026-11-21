using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000714 RID: 1812
	[NetMessage(EMessageId.GuideTriggerRequest)]
	public sealed class GuideTriggerRequest : IMessage<GuideTriggerRequest>, IMessage, IEquatable<GuideTriggerRequest>, IDeepCloneable<GuideTriggerRequest>, IBufferMessage
	{
		// Token: 0x0600A506 RID: 42246 RVA: 0x0018E615 File Offset: 0x0018C815
		[NullableContext(1)]
		public static GuideTriggerRequest Create()
		{
			return new GuideTriggerRequest();
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x0600A507 RID: 42247 RVA: 0x0018E61C File Offset: 0x0018C81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x0600A508 RID: 42248 RVA: 0x0018E61F File Offset: 0x0018C81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideTriggerRequest.Descriptor;
			}
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x0018E626 File Offset: 0x0018C826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerRequest()
		{
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x0018E62E File Offset: 0x0018C82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerRequest(GuideTriggerRequest other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x0018E653 File Offset: 0x0018C853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerRequest Clone()
		{
			return new GuideTriggerRequest(this);
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x0600A50C RID: 42252 RVA: 0x0018E65B File Offset: 0x0018C85B
		// (set) Token: 0x0600A50D RID: 42253 RVA: 0x0018E663 File Offset: 0x0018C863
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

		// Token: 0x0600A50E RID: 42254 RVA: 0x0018E66C File Offset: 0x0018C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideTriggerRequest);
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x0018E67A File Offset: 0x0018C87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideTriggerRequest other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x0018E6A8 File Offset: 0x0018C8A8
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

		// Token: 0x0600A511 RID: 42257 RVA: 0x0018E6E7 File Offset: 0x0018C8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x0018E6F4 File Offset: 0x0018C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x0018E6FD File Offset: 0x0018C8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x0018E730 File Offset: 0x0018C930
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

		// Token: 0x0600A515 RID: 42261 RVA: 0x0018E76E File Offset: 0x0018C96E
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

		// Token: 0x0600A516 RID: 42262 RVA: 0x0018E79F File Offset: 0x0018C99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x0018E7A8 File Offset: 0x0018C9A8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C4B RID: 19531
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C4C RID: 19532
		public const int GroupIdFieldNumber = 6;

		// Token: 0x04004C4D RID: 19533
		private int groupId_;
	}
}
