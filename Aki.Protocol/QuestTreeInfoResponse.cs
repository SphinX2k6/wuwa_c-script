using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E35 RID: 3637
	[NetMessage(EMessageId.QuestTreeInfoResponse)]
	public sealed class QuestTreeInfoResponse : IMessage<QuestTreeInfoResponse>, IMessage, IEquatable<QuestTreeInfoResponse>, IDeepCloneable<QuestTreeInfoResponse>, IBufferMessage
	{
		// Token: 0x06013861 RID: 79969 RVA: 0x002D628E File Offset: 0x002D448E
		[NullableContext(1)]
		public static QuestTreeInfoResponse Create()
		{
			return new QuestTreeInfoResponse();
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x06013862 RID: 79970 RVA: 0x002D6295 File Offset: 0x002D4495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x06013863 RID: 79971 RVA: 0x002D6298 File Offset: 0x002D4498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTreeInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013864 RID: 79972 RVA: 0x002D629F File Offset: 0x002D449F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoResponse()
		{
		}

		// Token: 0x06013865 RID: 79973 RVA: 0x002D62A7 File Offset: 0x002D44A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoResponse(QuestTreeInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013866 RID: 79974 RVA: 0x002D62CC File Offset: 0x002D44CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoResponse Clone()
		{
			return new QuestTreeInfoResponse(this);
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x06013867 RID: 79975 RVA: 0x002D62D4 File Offset: 0x002D44D4
		// (set) Token: 0x06013868 RID: 79976 RVA: 0x002D62DC File Offset: 0x002D44DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06013869 RID: 79977 RVA: 0x002D62E5 File Offset: 0x002D44E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTreeInfoResponse);
		}

		// Token: 0x0601386A RID: 79978 RVA: 0x002D62F3 File Offset: 0x002D44F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTreeInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601386B RID: 79979 RVA: 0x002D6324 File Offset: 0x002D4524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601386C RID: 79980 RVA: 0x002D6369 File Offset: 0x002D4569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601386D RID: 79981 RVA: 0x002D6376 File Offset: 0x002D4576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601386E RID: 79982 RVA: 0x002D637F File Offset: 0x002D457F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601386F RID: 79983 RVA: 0x002D63B0 File Offset: 0x002D45B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013870 RID: 79984 RVA: 0x002D63EE File Offset: 0x002D45EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTreeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013871 RID: 79985 RVA: 0x002D641F File Offset: 0x002D461F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013872 RID: 79986 RVA: 0x002D6428 File Offset: 0x002D4628
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007785 RID: 30597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007786 RID: 30598
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007787 RID: 30599
		private ErrorCode errorCode_;
	}
}
