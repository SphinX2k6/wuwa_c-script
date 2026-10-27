using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC8 RID: 3784
	[NetMessage(EMessageId.RecallQuestStatusUpdateNotify)]
	public sealed class RecallQuestStatusUpdateNotify : IMessage<RecallQuestStatusUpdateNotify>, IMessage, IEquatable<RecallQuestStatusUpdateNotify>, IDeepCloneable<RecallQuestStatusUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601449F RID: 83103 RVA: 0x002F2EDC File Offset: 0x002F10DC
		[NullableContext(1)]
		public static RecallQuestStatusUpdateNotify Create()
		{
			return new RecallQuestStatusUpdateNotify();
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x060144A0 RID: 83104 RVA: 0x002F2EE3 File Offset: 0x002F10E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x060144A1 RID: 83105 RVA: 0x002F2EE6 File Offset: 0x002F10E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestStatusUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060144A2 RID: 83106 RVA: 0x002F2EED File Offset: 0x002F10ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatusUpdateNotify()
		{
		}

		// Token: 0x060144A3 RID: 83107 RVA: 0x002F2EF5 File Offset: 0x002F10F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatusUpdateNotify(RecallQuestStatusUpdateNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144A4 RID: 83108 RVA: 0x002F2F26 File Offset: 0x002F1126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatusUpdateNotify Clone()
		{
			return new RecallQuestStatusUpdateNotify(this);
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x060144A5 RID: 83109 RVA: 0x002F2F2E File Offset: 0x002F112E
		// (set) Token: 0x060144A6 RID: 83110 RVA: 0x002F2F36 File Offset: 0x002F1136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x060144A7 RID: 83111 RVA: 0x002F2F3F File Offset: 0x002F113F
		// (set) Token: 0x060144A8 RID: 83112 RVA: 0x002F2F47 File Offset: 0x002F1147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x060144A9 RID: 83113 RVA: 0x002F2F50 File Offset: 0x002F1150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestStatusUpdateNotify);
		}

		// Token: 0x060144AA RID: 83114 RVA: 0x002F2F5E File Offset: 0x002F115E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestStatusUpdateNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144AB RID: 83115 RVA: 0x002F2F9C File Offset: 0x002F119C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060144AC RID: 83116 RVA: 0x002F2FFA File Offset: 0x002F11FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144AD RID: 83117 RVA: 0x002F3007 File Offset: 0x002F1207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144AE RID: 83118 RVA: 0x002F3010 File Offset: 0x002F1210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144AF RID: 83119 RVA: 0x002F306C File Offset: 0x002F126C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060144B0 RID: 83120 RVA: 0x002F30C4 File Offset: 0x002F12C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestStatusUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.Status != RecallQuestStatus.InActive)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060144B1 RID: 83121 RVA: 0x002F3114 File Offset: 0x002F1314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144B2 RID: 83122 RVA: 0x002F3120 File Offset: 0x002F1320
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (RecallQuestStatus)input.ReadEnum();
					}
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B47 RID: 31559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B48 RID: 31560
		public const int RecallQuestIdFieldNumber = 2;

		// Token: 0x04007B49 RID: 31561
		private int recallQuestId_;

		// Token: 0x04007B4A RID: 31562
		public const int StatusFieldNumber = 7;

		// Token: 0x04007B4B RID: 31563
		private RecallQuestStatus status_;
	}
}
