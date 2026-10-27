using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC1 RID: 3777
	public sealed class RecallQuestInfo : IMessage<RecallQuestInfo>, IMessage, IEquatable<RecallQuestInfo>, IDeepCloneable<RecallQuestInfo>, IBufferMessage
	{
		// Token: 0x0601441B RID: 82971 RVA: 0x002F2032 File Offset: 0x002F0232
		[NullableContext(1)]
		public static RecallQuestInfo Create()
		{
			return new RecallQuestInfo();
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x0601441C RID: 82972 RVA: 0x002F2039 File Offset: 0x002F0239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallQuestInfo> Parser
		{
			get
			{
				return RecallQuestInfo._parser;
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0601441D RID: 82973 RVA: 0x002F2040 File Offset: 0x002F0240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0601441E RID: 82974 RVA: 0x002F2043 File Offset: 0x002F0243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestInfo.Descriptor;
			}
		}

		// Token: 0x0601441F RID: 82975 RVA: 0x002F204A File Offset: 0x002F024A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestInfo()
		{
		}

		// Token: 0x06014420 RID: 82976 RVA: 0x002F2052 File Offset: 0x002F0252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestInfo(RecallQuestInfo other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014421 RID: 82977 RVA: 0x002F2083 File Offset: 0x002F0283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestInfo Clone()
		{
			return new RecallQuestInfo(this);
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x06014422 RID: 82978 RVA: 0x002F208B File Offset: 0x002F028B
		// (set) Token: 0x06014423 RID: 82979 RVA: 0x002F2093 File Offset: 0x002F0293
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

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x06014424 RID: 82980 RVA: 0x002F209C File Offset: 0x002F029C
		// (set) Token: 0x06014425 RID: 82981 RVA: 0x002F20A4 File Offset: 0x002F02A4
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

		// Token: 0x06014426 RID: 82982 RVA: 0x002F20AD File Offset: 0x002F02AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestInfo);
		}

		// Token: 0x06014427 RID: 82983 RVA: 0x002F20BB File Offset: 0x002F02BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestInfo other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014428 RID: 82984 RVA: 0x002F20FC File Offset: 0x002F02FC
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

		// Token: 0x06014429 RID: 82985 RVA: 0x002F215A File Offset: 0x002F035A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601442A RID: 82986 RVA: 0x002F2167 File Offset: 0x002F0367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601442B RID: 82987 RVA: 0x002F2170 File Offset: 0x002F0370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601442C RID: 82988 RVA: 0x002F21C8 File Offset: 0x002F03C8
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

		// Token: 0x0601442D RID: 82989 RVA: 0x002F2220 File Offset: 0x002F0420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestInfo other)
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

		// Token: 0x0601442E RID: 82990 RVA: 0x002F2270 File Offset: 0x002F0470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601442F RID: 82991 RVA: 0x002F227C File Offset: 0x002F047C
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
				if (num != 8U)
				{
					if (num != 16U)
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

		// Token: 0x04007B2C RID: 31532
		private static readonly MessageParser<RecallQuestInfo> _parser = new MessageParser<RecallQuestInfo>(() => new RecallQuestInfo());

		// Token: 0x04007B2D RID: 31533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B2E RID: 31534
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B2F RID: 31535
		private int recallQuestId_;

		// Token: 0x04007B30 RID: 31536
		public const int StatusFieldNumber = 2;

		// Token: 0x04007B31 RID: 31537
		private RecallQuestStatus status_;
	}
}
