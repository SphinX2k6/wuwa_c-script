using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEC RID: 3564
	[NetMessage(EMessageId.QingXiaoTaskRewardResponse)]
	public sealed class QingXiaoTaskRewardResponse : IMessage<QingXiaoTaskRewardResponse>, IMessage, IEquatable<QingXiaoTaskRewardResponse>, IDeepCloneable<QingXiaoTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06013328 RID: 78632 RVA: 0x002CC4BC File Offset: 0x002CA6BC
		[NullableContext(1)]
		public static QingXiaoTaskRewardResponse Create()
		{
			return new QingXiaoTaskRewardResponse();
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x06013329 RID: 78633 RVA: 0x002CC4C3 File Offset: 0x002CA6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0601332A RID: 78634 RVA: 0x002CC4C6 File Offset: 0x002CA6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601332B RID: 78635 RVA: 0x002CC4CD File Offset: 0x002CA6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardResponse()
		{
		}

		// Token: 0x0601332C RID: 78636 RVA: 0x002CC4D5 File Offset: 0x002CA6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardResponse(QingXiaoTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601332D RID: 78637 RVA: 0x002CC4FA File Offset: 0x002CA6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardResponse Clone()
		{
			return new QingXiaoTaskRewardResponse(this);
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x0601332E RID: 78638 RVA: 0x002CC502 File Offset: 0x002CA702
		// (set) Token: 0x0601332F RID: 78639 RVA: 0x002CC50A File Offset: 0x002CA70A
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

		// Token: 0x06013330 RID: 78640 RVA: 0x002CC513 File Offset: 0x002CA713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoTaskRewardResponse);
		}

		// Token: 0x06013331 RID: 78641 RVA: 0x002CC521 File Offset: 0x002CA721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013332 RID: 78642 RVA: 0x002CC550 File Offset: 0x002CA750
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

		// Token: 0x06013333 RID: 78643 RVA: 0x002CC595 File Offset: 0x002CA795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013334 RID: 78644 RVA: 0x002CC5A2 File Offset: 0x002CA7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013335 RID: 78645 RVA: 0x002CC5AB File Offset: 0x002CA7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013336 RID: 78646 RVA: 0x002CC5E0 File Offset: 0x002CA7E0
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

		// Token: 0x06013337 RID: 78647 RVA: 0x002CC61E File Offset: 0x002CA81E
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

		// Token: 0x06013338 RID: 78648 RVA: 0x002CC64F File Offset: 0x002CA84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013339 RID: 78649 RVA: 0x002CC658 File Offset: 0x002CA858
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400769F RID: 30367
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076A0 RID: 30368
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x040076A1 RID: 30369
		private ErrorCode errCode_;
	}
}
