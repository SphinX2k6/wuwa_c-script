using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070E RID: 1806
	[NetMessage(EMessageId.GuideCondDoneNotify)]
	public sealed class GuideCondDoneNotify : IMessage<GuideCondDoneNotify>, IMessage, IEquatable<GuideCondDoneNotify>, IDeepCloneable<GuideCondDoneNotify>, IBufferMessage
	{
		// Token: 0x0600A49A RID: 42138 RVA: 0x0018DAB9 File Offset: 0x0018BCB9
		[NullableContext(1)]
		public static GuideCondDoneNotify Create()
		{
			return new GuideCondDoneNotify();
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x0600A49B RID: 42139 RVA: 0x0018DAC0 File Offset: 0x0018BCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600A49C RID: 42140 RVA: 0x0018DAC3 File Offset: 0x0018BCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideCondDoneNotify.Descriptor;
			}
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x0018DACA File Offset: 0x0018BCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideCondDoneNotify()
		{
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x0018DAD2 File Offset: 0x0018BCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideCondDoneNotify(GuideCondDoneNotify other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x0018DAF7 File Offset: 0x0018BCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideCondDoneNotify Clone()
		{
			return new GuideCondDoneNotify(this);
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600A4A0 RID: 42144 RVA: 0x0018DAFF File Offset: 0x0018BCFF
		// (set) Token: 0x0600A4A1 RID: 42145 RVA: 0x0018DB07 File Offset: 0x0018BD07
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

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x0018DB10 File Offset: 0x0018BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideCondDoneNotify);
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x0018DB1E File Offset: 0x0018BD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideCondDoneNotify other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x0018DB4C File Offset: 0x0018BD4C
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

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x0018DB8B File Offset: 0x0018BD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x0018DB98 File Offset: 0x0018BD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x0018DBA1 File Offset: 0x0018BDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x0018DBD4 File Offset: 0x0018BDD4
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

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x0018DC12 File Offset: 0x0018BE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideCondDoneNotify other)
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

		// Token: 0x0600A4AA RID: 42154 RVA: 0x0018DC43 File Offset: 0x0018BE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x0018DC4C File Offset: 0x0018BE4C
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
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C36 RID: 19510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C37 RID: 19511
		public const int GroupIdFieldNumber = 5;

		// Token: 0x04004C38 RID: 19512
		private int groupId_;
	}
}
