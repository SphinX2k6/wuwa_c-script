using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E02 RID: 3586
	[NetMessage(EMessageId.QuestFinishActionEndResponse)]
	public sealed class QuestFinishActionEndResponse : IMessage<QuestFinishActionEndResponse>, IMessage, IEquatable<QuestFinishActionEndResponse>, IDeepCloneable<QuestFinishActionEndResponse>, IBufferMessage
	{
		// Token: 0x060134C8 RID: 79048 RVA: 0x002CF781 File Offset: 0x002CD981
		[NullableContext(1)]
		public static QuestFinishActionEndResponse Create()
		{
			return new QuestFinishActionEndResponse();
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x060134C9 RID: 79049 RVA: 0x002CF788 File Offset: 0x002CD988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x060134CA RID: 79050 RVA: 0x002CF78B File Offset: 0x002CD98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionEndResponse.Descriptor;
			}
		}

		// Token: 0x060134CB RID: 79051 RVA: 0x002CF792 File Offset: 0x002CD992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndResponse()
		{
		}

		// Token: 0x060134CC RID: 79052 RVA: 0x002CF79A File Offset: 0x002CD99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndResponse(QuestFinishActionEndResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134CD RID: 79053 RVA: 0x002CF7BF File Offset: 0x002CD9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndResponse Clone()
		{
			return new QuestFinishActionEndResponse(this);
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x060134CE RID: 79054 RVA: 0x002CF7C7 File Offset: 0x002CD9C7
		// (set) Token: 0x060134CF RID: 79055 RVA: 0x002CF7CF File Offset: 0x002CD9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060134D0 RID: 79056 RVA: 0x002CF7D8 File Offset: 0x002CD9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionEndResponse);
		}

		// Token: 0x060134D1 RID: 79057 RVA: 0x002CF7E6 File Offset: 0x002CD9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionEndResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134D2 RID: 79058 RVA: 0x002CF814 File Offset: 0x002CDA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060134D3 RID: 79059 RVA: 0x002CF859 File Offset: 0x002CDA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134D4 RID: 79060 RVA: 0x002CF866 File Offset: 0x002CDA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134D5 RID: 79061 RVA: 0x002CF86F File Offset: 0x002CDA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134D6 RID: 79062 RVA: 0x002CF8A4 File Offset: 0x002CDAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060134D7 RID: 79063 RVA: 0x002CF8E2 File Offset: 0x002CDAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishActionEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134D8 RID: 79064 RVA: 0x002CF913 File Offset: 0x002CDB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134D9 RID: 79065 RVA: 0x002CF91C File Offset: 0x002CDB1C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076FE RID: 30462
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076FF RID: 30463
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04007700 RID: 30464
		private ErrorCode errorId_;
	}
}
