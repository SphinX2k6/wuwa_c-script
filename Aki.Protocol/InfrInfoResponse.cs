using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CB RID: 1995
	[NetMessage(EMessageId.InfrInfoResponse)]
	public sealed class InfrInfoResponse : IMessage<InfrInfoResponse>, IMessage, IEquatable<InfrInfoResponse>, IDeepCloneable<InfrInfoResponse>, IBufferMessage
	{
		// Token: 0x0600B390 RID: 45968 RVA: 0x001ADA52 File Offset: 0x001ABC52
		[NullableContext(1)]
		public static InfrInfoResponse Create()
		{
			return new InfrInfoResponse();
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600B391 RID: 45969 RVA: 0x001ADA59 File Offset: 0x001ABC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600B392 RID: 45970 RVA: 0x001ADA5C File Offset: 0x001ABC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x001ADA63 File Offset: 0x001ABC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoResponse()
		{
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x001ADA6C File Offset: 0x001ABC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoResponse(InfrInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.infrInfo_ = ((other.infrInfo_ != null) ? other.infrInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x001ADAB8 File Offset: 0x001ABCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoResponse Clone()
		{
			return new InfrInfoResponse(this);
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x0600B396 RID: 45974 RVA: 0x001ADAC0 File Offset: 0x001ABCC0
		// (set) Token: 0x0600B397 RID: 45975 RVA: 0x001ADAC8 File Offset: 0x001ABCC8
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

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x0600B398 RID: 45976 RVA: 0x001ADAD1 File Offset: 0x001ABCD1
		// (set) Token: 0x0600B399 RID: 45977 RVA: 0x001ADAD9 File Offset: 0x001ABCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb InfrInfo
		{
			get
			{
				return this.infrInfo_;
			}
			set
			{
				this.infrInfo_ = value;
			}
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x001ADAE2 File Offset: 0x001ABCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrInfoResponse);
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x001ADAF0 File Offset: 0x001ABCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InfrInfo, other.InfrInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x001ADB40 File Offset: 0x001ABD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.infrInfo_ != null)
			{
				num ^= this.InfrInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x001ADB9B File Offset: 0x001ABD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B39E RID: 45982 RVA: 0x001ADBA8 File Offset: 0x001ABDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x001ADBB4 File Offset: 0x001ABDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infrInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.InfrInfo);
			}
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

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x001ADC10 File Offset: 0x001ABE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.infrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x001ADC68 File Offset: 0x001ABE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.infrInfo_ != null)
			{
				if (this.infrInfo_ == null)
				{
					this.InfrInfo = new InfrPb();
				}
				this.InfrInfo.MergeFrom(other.InfrInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x001ADCD0 File Offset: 0x001ABED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x001ADCDC File Offset: 0x001ABEDC
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
				if (num != 10U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.infrInfo_ == null)
					{
						this.InfrInfo = new InfrPb();
					}
					input.ReadMessage(this.InfrInfo);
				}
			}
		}

		// Token: 0x0400505D RID: 20573
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400505E RID: 20574
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400505F RID: 20575
		private ErrorCode errorCode_;

		// Token: 0x04005060 RID: 20576
		public const int InfrInfoFieldNumber = 1;

		// Token: 0x04005061 RID: 20577
		private InfrPb infrInfo_;
	}
}
