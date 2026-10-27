using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001363 RID: 4963
	[NetMessage(EMessageId.ThroughTrainFinishViewResponse)]
	public sealed class ThroughTrainFinishViewResponse : IMessage<ThroughTrainFinishViewResponse>, IMessage, IEquatable<ThroughTrainFinishViewResponse>, IDeepCloneable<ThroughTrainFinishViewResponse>, IBufferMessage
	{
		// Token: 0x0601A5BD RID: 107965 RVA: 0x003D3EC9 File Offset: 0x003D20C9
		[NullableContext(1)]
		public static ThroughTrainFinishViewResponse Create()
		{
			return new ThroughTrainFinishViewResponse();
		}

		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x0601A5BE RID: 107966 RVA: 0x003D3ED0 File Offset: 0x003D20D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x0601A5BF RID: 107967 RVA: 0x003D3ED3 File Offset: 0x003D20D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainFinishViewResponse.Descriptor;
			}
		}

		// Token: 0x0601A5C0 RID: 107968 RVA: 0x003D3EDA File Offset: 0x003D20DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewResponse()
		{
		}

		// Token: 0x0601A5C1 RID: 107969 RVA: 0x003D3EE2 File Offset: 0x003D20E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewResponse(ThroughTrainFinishViewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5C2 RID: 107970 RVA: 0x003D3F07 File Offset: 0x003D2107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewResponse Clone()
		{
			return new ThroughTrainFinishViewResponse(this);
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x0601A5C3 RID: 107971 RVA: 0x003D3F0F File Offset: 0x003D210F
		// (set) Token: 0x0601A5C4 RID: 107972 RVA: 0x003D3F17 File Offset: 0x003D2117
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

		// Token: 0x0601A5C5 RID: 107973 RVA: 0x003D3F20 File Offset: 0x003D2120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainFinishViewResponse);
		}

		// Token: 0x0601A5C6 RID: 107974 RVA: 0x003D3F2E File Offset: 0x003D212E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainFinishViewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5C7 RID: 107975 RVA: 0x003D3F5C File Offset: 0x003D215C
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

		// Token: 0x0601A5C8 RID: 107976 RVA: 0x003D3FA1 File Offset: 0x003D21A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5C9 RID: 107977 RVA: 0x003D3FAE File Offset: 0x003D21AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5CA RID: 107978 RVA: 0x003D3FB7 File Offset: 0x003D21B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5CB RID: 107979 RVA: 0x003D3FEC File Offset: 0x003D21EC
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

		// Token: 0x0601A5CC RID: 107980 RVA: 0x003D402A File Offset: 0x003D222A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainFinishViewResponse other)
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

		// Token: 0x0601A5CD RID: 107981 RVA: 0x003D405B File Offset: 0x003D225B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5CE RID: 107982 RVA: 0x003D4064 File Offset: 0x003D2264
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009995 RID: 39317
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009996 RID: 39318
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009997 RID: 39319
		private ErrorCode errorCode_;
	}
}
