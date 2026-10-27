using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC9 RID: 3785
	[NetMessage(EMessageId.RecallTeleportToMarkIdRequest)]
	public sealed class RecallTeleportToMarkIdRequest : IMessage<RecallTeleportToMarkIdRequest>, IMessage, IEquatable<RecallTeleportToMarkIdRequest>, IDeepCloneable<RecallTeleportToMarkIdRequest>, IBufferMessage
	{
		// Token: 0x060144B3 RID: 83123 RVA: 0x002F3178 File Offset: 0x002F1378
		[NullableContext(1)]
		public static RecallTeleportToMarkIdRequest Create()
		{
			return new RecallTeleportToMarkIdRequest();
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x060144B4 RID: 83124 RVA: 0x002F317F File Offset: 0x002F137F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x060144B5 RID: 83125 RVA: 0x002F3182 File Offset: 0x002F1382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallTeleportToMarkIdRequest.Descriptor;
			}
		}

		// Token: 0x060144B6 RID: 83126 RVA: 0x002F3189 File Offset: 0x002F1389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdRequest()
		{
		}

		// Token: 0x060144B7 RID: 83127 RVA: 0x002F3191 File Offset: 0x002F1391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdRequest(RecallTeleportToMarkIdRequest other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144B8 RID: 83128 RVA: 0x002F31B6 File Offset: 0x002F13B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdRequest Clone()
		{
			return new RecallTeleportToMarkIdRequest(this);
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x060144B9 RID: 83129 RVA: 0x002F31BE File Offset: 0x002F13BE
		// (set) Token: 0x060144BA RID: 83130 RVA: 0x002F31C6 File Offset: 0x002F13C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x060144BB RID: 83131 RVA: 0x002F31CF File Offset: 0x002F13CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallTeleportToMarkIdRequest);
		}

		// Token: 0x060144BC RID: 83132 RVA: 0x002F31DD File Offset: 0x002F13DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallTeleportToMarkIdRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144BD RID: 83133 RVA: 0x002F320C File Offset: 0x002F140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060144BE RID: 83134 RVA: 0x002F324B File Offset: 0x002F144B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144BF RID: 83135 RVA: 0x002F3258 File Offset: 0x002F1458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144C0 RID: 83136 RVA: 0x002F3261 File Offset: 0x002F1461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144C1 RID: 83137 RVA: 0x002F3294 File Offset: 0x002F1494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060144C2 RID: 83138 RVA: 0x002F32D2 File Offset: 0x002F14D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallTeleportToMarkIdRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060144C3 RID: 83139 RVA: 0x002F3303 File Offset: 0x002F1503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144C4 RID: 83140 RVA: 0x002F330C File Offset: 0x002F150C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B4C RID: 31564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B4D RID: 31565
		public const int MarkIdFieldNumber = 9;

		// Token: 0x04007B4E RID: 31566
		private int markId_;
	}
}
