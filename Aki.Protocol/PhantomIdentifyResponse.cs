using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC6 RID: 3270
	[NetMessage(EMessageId.PhantomIdentifyResponse)]
	public sealed class PhantomIdentifyResponse : IMessage<PhantomIdentifyResponse>, IMessage, IEquatable<PhantomIdentifyResponse>, IDeepCloneable<PhantomIdentifyResponse>, IBufferMessage
	{
		// Token: 0x06011B91 RID: 72593 RVA: 0x00298648 File Offset: 0x00296848
		[NullableContext(1)]
		public static PhantomIdentifyResponse Create()
		{
			return new PhantomIdentifyResponse();
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x06011B92 RID: 72594 RVA: 0x0029864F File Offset: 0x0029684F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x06011B93 RID: 72595 RVA: 0x00298652 File Offset: 0x00296852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomIdentifyResponse.Descriptor;
			}
		}

		// Token: 0x06011B94 RID: 72596 RVA: 0x00298659 File Offset: 0x00296859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyResponse()
		{
		}

		// Token: 0x06011B95 RID: 72597 RVA: 0x00298664 File Offset: 0x00296864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyResponse(PhantomIdentifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfo_ = ((other.updateInfo_ != null) ? other.updateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B96 RID: 72598 RVA: 0x002986B0 File Offset: 0x002968B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyResponse Clone()
		{
			return new PhantomIdentifyResponse(this);
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x06011B97 RID: 72599 RVA: 0x002986B8 File Offset: 0x002968B8
		// (set) Token: 0x06011B98 RID: 72600 RVA: 0x002986C0 File Offset: 0x002968C0
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

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x06011B99 RID: 72601 RVA: 0x002986C9 File Offset: 0x002968C9
		// (set) Token: 0x06011B9A RID: 72602 RVA: 0x002986D1 File Offset: 0x002968D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
			set
			{
				this.updateInfo_ = value;
			}
		}

		// Token: 0x06011B9B RID: 72603 RVA: 0x002986DA File Offset: 0x002968DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomIdentifyResponse);
		}

		// Token: 0x06011B9C RID: 72604 RVA: 0x002986E8 File Offset: 0x002968E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomIdentifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B9D RID: 72605 RVA: 0x00298738 File Offset: 0x00296938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.updateInfo_ != null)
			{
				num ^= this.UpdateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B9E RID: 72606 RVA: 0x00298793 File Offset: 0x00296993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B9F RID: 72607 RVA: 0x002987A0 File Offset: 0x002969A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BA0 RID: 72608 RVA: 0x002987AC File Offset: 0x002969AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BA1 RID: 72609 RVA: 0x00298808 File Offset: 0x00296A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BA2 RID: 72610 RVA: 0x00298860 File Offset: 0x00296A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomIdentifyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.updateInfo_ != null)
			{
				if (this.updateInfo_ == null)
				{
					this.UpdateInfo = new PhantomItem();
				}
				this.UpdateInfo.MergeFrom(other.UpdateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BA3 RID: 72611 RVA: 0x002988C8 File Offset: 0x00296AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BA4 RID: 72612 RVA: 0x002988D4 File Offset: 0x00296AD4
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
				if (num != 48U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.updateInfo_ == null)
						{
							this.UpdateInfo = new PhantomItem();
						}
						input.ReadMessage(this.UpdateInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FCF RID: 28623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FD0 RID: 28624
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006FD1 RID: 28625
		private ErrorCode errorCode_;

		// Token: 0x04006FD2 RID: 28626
		public const int UpdateInfoFieldNumber = 11;

		// Token: 0x04006FD3 RID: 28627
		private PhantomItem updateInfo_;
	}
}
