using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001395 RID: 5013
	[NetMessage(EMessageId.ToughCalcExtraRatioChangeResponse)]
	public sealed class ToughCalcExtraRatioChangeResponse : IMessage<ToughCalcExtraRatioChangeResponse>, IMessage, IEquatable<ToughCalcExtraRatioChangeResponse>, IDeepCloneable<ToughCalcExtraRatioChangeResponse>, IBufferMessage
	{
		// Token: 0x0601A9A0 RID: 108960 RVA: 0x003DBEBC File Offset: 0x003DA0BC
		[NullableContext(1)]
		public static ToughCalcExtraRatioChangeResponse Create()
		{
			return new ToughCalcExtraRatioChangeResponse();
		}

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x0601A9A1 RID: 108961 RVA: 0x003DBEC3 File Offset: 0x003DA0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x0601A9A2 RID: 108962 RVA: 0x003DBEC6 File Offset: 0x003DA0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToughCalcExtraRatioChangeResponse.Descriptor;
			}
		}

		// Token: 0x0601A9A3 RID: 108963 RVA: 0x003DBECD File Offset: 0x003DA0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse()
		{
		}

		// Token: 0x0601A9A4 RID: 108964 RVA: 0x003DBED5 File Offset: 0x003DA0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse(ToughCalcExtraRatioChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9A5 RID: 108965 RVA: 0x003DBEFA File Offset: 0x003DA0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse Clone()
		{
			return new ToughCalcExtraRatioChangeResponse(this);
		}

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x0601A9A6 RID: 108966 RVA: 0x003DBF02 File Offset: 0x003DA102
		// (set) Token: 0x0601A9A7 RID: 108967 RVA: 0x003DBF0A File Offset: 0x003DA10A
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

		// Token: 0x0601A9A8 RID: 108968 RVA: 0x003DBF13 File Offset: 0x003DA113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToughCalcExtraRatioChangeResponse);
		}

		// Token: 0x0601A9A9 RID: 108969 RVA: 0x003DBF21 File Offset: 0x003DA121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ToughCalcExtraRatioChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9AA RID: 108970 RVA: 0x003DBF50 File Offset: 0x003DA150
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

		// Token: 0x0601A9AB RID: 108971 RVA: 0x003DBF95 File Offset: 0x003DA195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9AC RID: 108972 RVA: 0x003DBFA2 File Offset: 0x003DA1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9AD RID: 108973 RVA: 0x003DBFAB File Offset: 0x003DA1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A9AE RID: 108974 RVA: 0x003DBFE0 File Offset: 0x003DA1E0
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

		// Token: 0x0601A9AF RID: 108975 RVA: 0x003DC01E File Offset: 0x003DA21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ToughCalcExtraRatioChangeResponse other)
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

		// Token: 0x0601A9B0 RID: 108976 RVA: 0x003DC04F File Offset: 0x003DA24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9B1 RID: 108977 RVA: 0x003DC058 File Offset: 0x003DA258
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009A98 RID: 39576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A99 RID: 39577
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009A9A RID: 39578
		private ErrorCode errorCode_;
	}
}
