using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF4 RID: 3572
	[NetMessage(EMessageId.QuestActionResponse)]
	public sealed class QuestActionResponse : IMessage<QuestActionResponse>, IMessage, IEquatable<QuestActionResponse>, IDeepCloneable<QuestActionResponse>, IBufferMessage
	{
		// Token: 0x060133C0 RID: 78784 RVA: 0x002CD725 File Offset: 0x002CB925
		[NullableContext(1)]
		public static QuestActionResponse Create()
		{
			return new QuestActionResponse();
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x060133C1 RID: 78785 RVA: 0x002CD72C File Offset: 0x002CB92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x060133C2 RID: 78786 RVA: 0x002CD72F File Offset: 0x002CB92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestActionResponse.Descriptor;
			}
		}

		// Token: 0x060133C3 RID: 78787 RVA: 0x002CD736 File Offset: 0x002CB936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionResponse()
		{
		}

		// Token: 0x060133C4 RID: 78788 RVA: 0x002CD73E File Offset: 0x002CB93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionResponse(QuestActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133C5 RID: 78789 RVA: 0x002CD763 File Offset: 0x002CB963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionResponse Clone()
		{
			return new QuestActionResponse(this);
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x060133C6 RID: 78790 RVA: 0x002CD76B File Offset: 0x002CB96B
		// (set) Token: 0x060133C7 RID: 78791 RVA: 0x002CD773 File Offset: 0x002CB973
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

		// Token: 0x060133C8 RID: 78792 RVA: 0x002CD77C File Offset: 0x002CB97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestActionResponse);
		}

		// Token: 0x060133C9 RID: 78793 RVA: 0x002CD78A File Offset: 0x002CB98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133CA RID: 78794 RVA: 0x002CD7B8 File Offset: 0x002CB9B8
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

		// Token: 0x060133CB RID: 78795 RVA: 0x002CD7FD File Offset: 0x002CB9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133CC RID: 78796 RVA: 0x002CD80A File Offset: 0x002CBA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133CD RID: 78797 RVA: 0x002CD813 File Offset: 0x002CBA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133CE RID: 78798 RVA: 0x002CD844 File Offset: 0x002CBA44
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

		// Token: 0x060133CF RID: 78799 RVA: 0x002CD882 File Offset: 0x002CBA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestActionResponse other)
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

		// Token: 0x060133D0 RID: 78800 RVA: 0x002CD8B3 File Offset: 0x002CBAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133D1 RID: 78801 RVA: 0x002CD8BC File Offset: 0x002CBABC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076C1 RID: 30401
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076C2 RID: 30402
		public const int ErrorIdFieldNumber = 1;

		// Token: 0x040076C3 RID: 30403
		private ErrorCode errorId_;
	}
}
