using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3D RID: 3133
	[NetMessage(EMessageId.PhantomBattleBvBLoadingFinishResponse)]
	public sealed class PhantomBattleBvBLoadingFinishResponse : IMessage<PhantomBattleBvBLoadingFinishResponse>, IMessage, IEquatable<PhantomBattleBvBLoadingFinishResponse>, IDeepCloneable<PhantomBattleBvBLoadingFinishResponse>, IBufferMessage
	{
		// Token: 0x06010FCC RID: 69580 RVA: 0x0027C76E File Offset: 0x0027A96E
		[NullableContext(1)]
		public static PhantomBattleBvBLoadingFinishResponse Create()
		{
			return new PhantomBattleBvBLoadingFinishResponse();
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x06010FCD RID: 69581 RVA: 0x0027C775 File Offset: 0x0027A975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x06010FCE RID: 69582 RVA: 0x0027C778 File Offset: 0x0027A978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBLoadingFinishResponse.Descriptor;
			}
		}

		// Token: 0x06010FCF RID: 69583 RVA: 0x0027C77F File Offset: 0x0027A97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishResponse()
		{
		}

		// Token: 0x06010FD0 RID: 69584 RVA: 0x0027C787 File Offset: 0x0027A987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishResponse(PhantomBattleBvBLoadingFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FD1 RID: 69585 RVA: 0x0027C7AC File Offset: 0x0027A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishResponse Clone()
		{
			return new PhantomBattleBvBLoadingFinishResponse(this);
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x06010FD2 RID: 69586 RVA: 0x0027C7B4 File Offset: 0x0027A9B4
		// (set) Token: 0x06010FD3 RID: 69587 RVA: 0x0027C7BC File Offset: 0x0027A9BC
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

		// Token: 0x06010FD4 RID: 69588 RVA: 0x0027C7C5 File Offset: 0x0027A9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBLoadingFinishResponse);
		}

		// Token: 0x06010FD5 RID: 69589 RVA: 0x0027C7D3 File Offset: 0x0027A9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBLoadingFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010FD6 RID: 69590 RVA: 0x0027C804 File Offset: 0x0027AA04
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

		// Token: 0x06010FD7 RID: 69591 RVA: 0x0027C849 File Offset: 0x0027AA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FD8 RID: 69592 RVA: 0x0027C856 File Offset: 0x0027AA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FD9 RID: 69593 RVA: 0x0027C85F File Offset: 0x0027AA5F
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

		// Token: 0x06010FDA RID: 69594 RVA: 0x0027C894 File Offset: 0x0027AA94
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

		// Token: 0x06010FDB RID: 69595 RVA: 0x0027C8D2 File Offset: 0x0027AAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBLoadingFinishResponse other)
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

		// Token: 0x06010FDC RID: 69596 RVA: 0x0027C903 File Offset: 0x0027AB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FDD RID: 69597 RVA: 0x0027C90C File Offset: 0x0027AB0C
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

		// Token: 0x04006BA1 RID: 27553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BA2 RID: 27554
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006BA3 RID: 27555
		private ErrorCode errorCode_;
	}
}
