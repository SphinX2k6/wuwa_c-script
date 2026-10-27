using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E25 RID: 3621
	[NetMessage(EMessageId.QuestRedDotRequest)]
	public sealed class QuestRedDotRequest : IMessage<QuestRedDotRequest>, IMessage, IEquatable<QuestRedDotRequest>, IDeepCloneable<QuestRedDotRequest>, IBufferMessage
	{
		// Token: 0x0601371F RID: 79647 RVA: 0x002D3A0D File Offset: 0x002D1C0D
		[NullableContext(1)]
		public static QuestRedDotRequest Create()
		{
			return new QuestRedDotRequest();
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x06013720 RID: 79648 RVA: 0x002D3A14 File Offset: 0x002D1C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x06013721 RID: 79649 RVA: 0x002D3A17 File Offset: 0x002D1C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRedDotRequest.Descriptor;
			}
		}

		// Token: 0x06013722 RID: 79650 RVA: 0x002D3A1E File Offset: 0x002D1C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotRequest()
		{
		}

		// Token: 0x06013723 RID: 79651 RVA: 0x002D3A26 File Offset: 0x002D1C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotRequest(QuestRedDotRequest other) : this()
		{
			this.questId_ = other.questId_;
			this.operate_ = other.operate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013724 RID: 79652 RVA: 0x002D3A57 File Offset: 0x002D1C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotRequest Clone()
		{
			return new QuestRedDotRequest(this);
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x06013725 RID: 79653 RVA: 0x002D3A5F File Offset: 0x002D1C5F
		// (set) Token: 0x06013726 RID: 79654 RVA: 0x002D3A67 File Offset: 0x002D1C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x06013727 RID: 79655 RVA: 0x002D3A70 File Offset: 0x002D1C70
		// (set) Token: 0x06013728 RID: 79656 RVA: 0x002D3A78 File Offset: 0x002D1C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Operate
		{
			get
			{
				return this.operate_;
			}
			set
			{
				this.operate_ = value;
			}
		}

		// Token: 0x06013729 RID: 79657 RVA: 0x002D3A81 File Offset: 0x002D1C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRedDotRequest);
		}

		// Token: 0x0601372A RID: 79658 RVA: 0x002D3A8F File Offset: 0x002D1C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRedDotRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.Operate == other.Operate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601372B RID: 79659 RVA: 0x002D3AD0 File Offset: 0x002D1CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Operate != 0)
			{
				num ^= this.Operate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601372C RID: 79660 RVA: 0x002D3B28 File Offset: 0x002D1D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601372D RID: 79661 RVA: 0x002D3B35 File Offset: 0x002D1D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601372E RID: 79662 RVA: 0x002D3B40 File Offset: 0x002D1D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Operate != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Operate);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601372F RID: 79663 RVA: 0x002D3B9C File Offset: 0x002D1D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Operate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013730 RID: 79664 RVA: 0x002D3BF4 File Offset: 0x002D1DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRedDotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Operate != 0)
			{
				this.Operate = other.Operate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013731 RID: 79665 RVA: 0x002D3C44 File Offset: 0x002D1E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013732 RID: 79666 RVA: 0x002D3C50 File Offset: 0x002D1E50
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
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Operate = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400772C RID: 30508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400772D RID: 30509
		public const int QuestIdFieldNumber = 15;

		// Token: 0x0400772E RID: 30510
		private int questId_;

		// Token: 0x0400772F RID: 30511
		public const int OperateFieldNumber = 7;

		// Token: 0x04007730 RID: 30512
		private int operate_;
	}
}
