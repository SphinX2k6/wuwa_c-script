using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8B RID: 3467
	[NetMessage(EMessageId.PlayerEnterPollutionResponse)]
	public sealed class PlayerEnterPollutionResponse : IMessage<PlayerEnterPollutionResponse>, IMessage, IEquatable<PlayerEnterPollutionResponse>, IDeepCloneable<PlayerEnterPollutionResponse>, IBufferMessage
	{
		// Token: 0x06012B30 RID: 76592 RVA: 0x002BAE54 File Offset: 0x002B9054
		[NullableContext(1)]
		public static PlayerEnterPollutionResponse Create()
		{
			return new PlayerEnterPollutionResponse();
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x06012B31 RID: 76593 RVA: 0x002BAE5B File Offset: 0x002B905B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x06012B32 RID: 76594 RVA: 0x002BAE5E File Offset: 0x002B905E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerEnterPollutionResponse.Descriptor;
			}
		}

		// Token: 0x06012B33 RID: 76595 RVA: 0x002BAE65 File Offset: 0x002B9065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionResponse()
		{
		}

		// Token: 0x06012B34 RID: 76596 RVA: 0x002BAE6D File Offset: 0x002B906D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionResponse(PlayerEnterPollutionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B35 RID: 76597 RVA: 0x002BAE92 File Offset: 0x002B9092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionResponse Clone()
		{
			return new PlayerEnterPollutionResponse(this);
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x06012B36 RID: 76598 RVA: 0x002BAE9A File Offset: 0x002B909A
		// (set) Token: 0x06012B37 RID: 76599 RVA: 0x002BAEA2 File Offset: 0x002B90A2
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

		// Token: 0x06012B38 RID: 76600 RVA: 0x002BAEAB File Offset: 0x002B90AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerEnterPollutionResponse);
		}

		// Token: 0x06012B39 RID: 76601 RVA: 0x002BAEB9 File Offset: 0x002B90B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerEnterPollutionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B3A RID: 76602 RVA: 0x002BAEE8 File Offset: 0x002B90E8
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

		// Token: 0x06012B3B RID: 76603 RVA: 0x002BAF2D File Offset: 0x002B912D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B3C RID: 76604 RVA: 0x002BAF3A File Offset: 0x002B913A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B3D RID: 76605 RVA: 0x002BAF43 File Offset: 0x002B9143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B3E RID: 76606 RVA: 0x002BAF78 File Offset: 0x002B9178
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

		// Token: 0x06012B3F RID: 76607 RVA: 0x002BAFB6 File Offset: 0x002B91B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerEnterPollutionResponse other)
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

		// Token: 0x06012B40 RID: 76608 RVA: 0x002BAFE7 File Offset: 0x002B91E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B41 RID: 76609 RVA: 0x002BAFF0 File Offset: 0x002B91F0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007410 RID: 29712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007411 RID: 29713
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007412 RID: 29714
		private ErrorCode errorCode_;
	}
}
