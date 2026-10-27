using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000723 RID: 1827
	[NetMessage(EMessageId.GuideFinishRequest)]
	public sealed class GuideFinishRequest : IMessage<GuideFinishRequest>, IMessage, IEquatable<GuideFinishRequest>, IDeepCloneable<GuideFinishRequest>, IBufferMessage
	{
		// Token: 0x0600A602 RID: 42498 RVA: 0x001906C5 File Offset: 0x0018E8C5
		[NullableContext(1)]
		public static GuideFinishRequest Create()
		{
			return new GuideFinishRequest();
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x001906CC File Offset: 0x0018E8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x001906CF File Offset: 0x0018E8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideFinishRequest.Descriptor;
			}
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x001906D6 File Offset: 0x0018E8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishRequest()
		{
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x001906DE File Offset: 0x0018E8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishRequest(GuideFinishRequest other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x00190703 File Offset: 0x0018E903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishRequest Clone()
		{
			return new GuideFinishRequest(this);
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x0600A608 RID: 42504 RVA: 0x0019070B File Offset: 0x0018E90B
		// (set) Token: 0x0600A609 RID: 42505 RVA: 0x00190713 File Offset: 0x0018E913
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

		// Token: 0x0600A60A RID: 42506 RVA: 0x0019071C File Offset: 0x0018E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideFinishRequest);
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x0019072A File Offset: 0x0018E92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideFinishRequest other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x00190758 File Offset: 0x0018E958
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

		// Token: 0x0600A60D RID: 42509 RVA: 0x00190797 File Offset: 0x0018E997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A60E RID: 42510 RVA: 0x001907A4 File Offset: 0x0018E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A60F RID: 42511 RVA: 0x001907AD File Offset: 0x0018E9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x001907E0 File Offset: 0x0018E9E0
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

		// Token: 0x0600A611 RID: 42513 RVA: 0x0019081E File Offset: 0x0018EA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideFinishRequest other)
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

		// Token: 0x0600A612 RID: 42514 RVA: 0x0019084F File Offset: 0x0018EA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x00190858 File Offset: 0x0018EA58
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C40 RID: 19520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C41 RID: 19521
		public const int GroupIdFieldNumber = 15;

		// Token: 0x04004C42 RID: 19522
		private int groupId_;
	}
}
