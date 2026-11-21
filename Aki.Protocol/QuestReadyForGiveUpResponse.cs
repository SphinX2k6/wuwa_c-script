using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E10 RID: 3600
	[NetMessage(EMessageId.QuestReadyForGiveUpResponse)]
	public sealed class QuestReadyForGiveUpResponse : IMessage<QuestReadyForGiveUpResponse>, IMessage, IEquatable<QuestReadyForGiveUpResponse>, IDeepCloneable<QuestReadyForGiveUpResponse>, IBufferMessage
	{
		// Token: 0x060135DC RID: 79324 RVA: 0x002D1889 File Offset: 0x002CFA89
		[NullableContext(1)]
		public static QuestReadyForGiveUpResponse Create()
		{
			return new QuestReadyForGiveUpResponse();
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x060135DD RID: 79325 RVA: 0x002D1890 File Offset: 0x002CFA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x060135DE RID: 79326 RVA: 0x002D1893 File Offset: 0x002CFA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReadyForGiveUpResponse.Descriptor;
			}
		}

		// Token: 0x060135DF RID: 79327 RVA: 0x002D189A File Offset: 0x002CFA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpResponse()
		{
		}

		// Token: 0x060135E0 RID: 79328 RVA: 0x002D18A2 File Offset: 0x002CFAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpResponse(QuestReadyForGiveUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135E1 RID: 79329 RVA: 0x002D18C7 File Offset: 0x002CFAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpResponse Clone()
		{
			return new QuestReadyForGiveUpResponse(this);
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x060135E2 RID: 79330 RVA: 0x002D18CF File Offset: 0x002CFACF
		// (set) Token: 0x060135E3 RID: 79331 RVA: 0x002D18D7 File Offset: 0x002CFAD7
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

		// Token: 0x060135E4 RID: 79332 RVA: 0x002D18E0 File Offset: 0x002CFAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReadyForGiveUpResponse);
		}

		// Token: 0x060135E5 RID: 79333 RVA: 0x002D18EE File Offset: 0x002CFAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReadyForGiveUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135E6 RID: 79334 RVA: 0x002D191C File Offset: 0x002CFB1C
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

		// Token: 0x060135E7 RID: 79335 RVA: 0x002D1961 File Offset: 0x002CFB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135E8 RID: 79336 RVA: 0x002D196E File Offset: 0x002CFB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135E9 RID: 79337 RVA: 0x002D1977 File Offset: 0x002CFB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135EA RID: 79338 RVA: 0x002D19AC File Offset: 0x002CFBAC
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

		// Token: 0x060135EB RID: 79339 RVA: 0x002D19EA File Offset: 0x002CFBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReadyForGiveUpResponse other)
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

		// Token: 0x060135EC RID: 79340 RVA: 0x002D1A1B File Offset: 0x002CFC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135ED RID: 79341 RVA: 0x002D1A24 File Offset: 0x002CFC24
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007741 RID: 30529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007742 RID: 30530
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007743 RID: 30531
		private ErrorCode errorCode_;
	}
}
