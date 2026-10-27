using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E09 RID: 3593
	[NetMessage(EMessageId.QuestBranchSelectRequest)]
	public sealed class QuestBranchSelectRequest : IMessage<QuestBranchSelectRequest>, IMessage, IEquatable<QuestBranchSelectRequest>, IDeepCloneable<QuestBranchSelectRequest>, IBufferMessage
	{
		// Token: 0x06013501 RID: 79105 RVA: 0x002CF922 File Offset: 0x002CDB22
		[NullableContext(1)]
		public static QuestBranchSelectRequest Create()
		{
			return new QuestBranchSelectRequest();
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x06013502 RID: 79106 RVA: 0x002CF929 File Offset: 0x002CDB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x06013503 RID: 79107 RVA: 0x002CF92C File Offset: 0x002CDB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchSelectRequest.Descriptor;
			}
		}

		// Token: 0x06013504 RID: 79108 RVA: 0x002CF933 File Offset: 0x002CDB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectRequest()
		{
		}

		// Token: 0x06013505 RID: 79109 RVA: 0x002CF93B File Offset: 0x002CDB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectRequest(QuestBranchSelectRequest other) : this()
		{
			this.branchPageId_ = other.branchPageId_;
			this.branchId_ = other.branchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013506 RID: 79110 RVA: 0x002CF96C File Offset: 0x002CDB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectRequest Clone()
		{
			return new QuestBranchSelectRequest(this);
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x06013507 RID: 79111 RVA: 0x002CF974 File Offset: 0x002CDB74
		// (set) Token: 0x06013508 RID: 79112 RVA: 0x002CF97C File Offset: 0x002CDB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchPageId
		{
			get
			{
				return this.branchPageId_;
			}
			set
			{
				this.branchPageId_ = value;
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x06013509 RID: 79113 RVA: 0x002CF985 File Offset: 0x002CDB85
		// (set) Token: 0x0601350A RID: 79114 RVA: 0x002CF98D File Offset: 0x002CDB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchId
		{
			get
			{
				return this.branchId_;
			}
			set
			{
				this.branchId_ = value;
			}
		}

		// Token: 0x0601350B RID: 79115 RVA: 0x002CF996 File Offset: 0x002CDB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchSelectRequest);
		}

		// Token: 0x0601350C RID: 79116 RVA: 0x002CF9A4 File Offset: 0x002CDBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchSelectRequest other)
		{
			return other != null && (other == this || (this.BranchPageId == other.BranchPageId && this.BranchId == other.BranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601350D RID: 79117 RVA: 0x002CF9E4 File Offset: 0x002CDBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BranchPageId != 0)
			{
				num ^= this.BranchPageId.GetHashCode();
			}
			if (this.BranchId != 0)
			{
				num ^= this.BranchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601350E RID: 79118 RVA: 0x002CFA3C File Offset: 0x002CDC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601350F RID: 79119 RVA: 0x002CFA49 File Offset: 0x002CDC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013510 RID: 79120 RVA: 0x002CFA54 File Offset: 0x002CDC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BranchPageId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BranchPageId);
			}
			if (this.BranchId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013511 RID: 79121 RVA: 0x002CFAB0 File Offset: 0x002CDCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BranchPageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchPageId);
			}
			if (this.BranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013512 RID: 79122 RVA: 0x002CFB08 File Offset: 0x002CDD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BranchPageId != 0)
			{
				this.BranchPageId = other.BranchPageId;
			}
			if (other.BranchId != 0)
			{
				this.BranchId = other.BranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013513 RID: 79123 RVA: 0x002CFB58 File Offset: 0x002CDD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013514 RID: 79124 RVA: 0x002CFB64 File Offset: 0x002CDD64
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BranchId = input.ReadInt32();
					}
				}
				else
				{
					this.BranchPageId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040076AD RID: 30381
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076AE RID: 30382
		public const int BranchPageIdFieldNumber = 2;

		// Token: 0x040076AF RID: 30383
		private int branchPageId_;

		// Token: 0x040076B0 RID: 30384
		public const int BranchIdFieldNumber = 11;

		// Token: 0x040076B1 RID: 30385
		private int branchId_;
	}
}
