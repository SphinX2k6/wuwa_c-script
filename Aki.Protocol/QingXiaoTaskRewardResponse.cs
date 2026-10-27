using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFC RID: 3580
	[NetMessage(EMessageId.QingXiaoTaskRewardResponse)]
	public sealed class QingXiaoTaskRewardResponse : IMessage<QingXiaoTaskRewardResponse>, IMessage, IEquatable<QingXiaoTaskRewardResponse>, IDeepCloneable<QingXiaoTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0601340D RID: 78861 RVA: 0x002CDB80 File Offset: 0x002CBD80
		[NullableContext(1)]
		public static QingXiaoTaskRewardResponse Create()
		{
			return new QingXiaoTaskRewardResponse();
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x0601340E RID: 78862 RVA: 0x002CDB87 File Offset: 0x002CBD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0601340F RID: 78863 RVA: 0x002CDB8A File Offset: 0x002CBD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06013410 RID: 78864 RVA: 0x002CDB91 File Offset: 0x002CBD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardResponse()
		{
		}

		// Token: 0x06013411 RID: 78865 RVA: 0x002CDB99 File Offset: 0x002CBD99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardResponse(QingXiaoTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013412 RID: 78866 RVA: 0x002CDBBE File Offset: 0x002CBDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardResponse Clone()
		{
			return new QingXiaoTaskRewardResponse(this);
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x06013413 RID: 78867 RVA: 0x002CDBC6 File Offset: 0x002CBDC6
		// (set) Token: 0x06013414 RID: 78868 RVA: 0x002CDBCE File Offset: 0x002CBDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06013415 RID: 78869 RVA: 0x002CDBD7 File Offset: 0x002CBDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoTaskRewardResponse);
		}

		// Token: 0x06013416 RID: 78870 RVA: 0x002CDBE5 File Offset: 0x002CBDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013417 RID: 78871 RVA: 0x002CDC14 File Offset: 0x002CBE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013418 RID: 78872 RVA: 0x002CDC59 File Offset: 0x002CBE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013419 RID: 78873 RVA: 0x002CDC66 File Offset: 0x002CBE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601341A RID: 78874 RVA: 0x002CDC6F File Offset: 0x002CBE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601341B RID: 78875 RVA: 0x002CDCA0 File Offset: 0x002CBEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601341C RID: 78876 RVA: 0x002CDCDE File Offset: 0x002CBEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QingXiaoTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601341D RID: 78877 RVA: 0x002CDD0F File Offset: 0x002CBF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601341E RID: 78878 RVA: 0x002CDD18 File Offset: 0x002CBF18
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007675 RID: 30325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007676 RID: 30326
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04007677 RID: 30327
		private ErrorCode errCode_;
	}
}
