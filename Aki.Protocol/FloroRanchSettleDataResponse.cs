using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E0 RID: 1504
	[NetMessage(EMessageId.FloroRanchSettleDataResponse)]
	public sealed class FloroRanchSettleDataResponse : IMessage<FloroRanchSettleDataResponse>, IMessage, IEquatable<FloroRanchSettleDataResponse>, IDeepCloneable<FloroRanchSettleDataResponse>, IBufferMessage
	{
		// Token: 0x06008B13 RID: 35603 RVA: 0x00150170 File Offset: 0x0014E370
		[NullableContext(1)]
		public static FloroRanchSettleDataResponse Create()
		{
			return new FloroRanchSettleDataResponse();
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06008B14 RID: 35604 RVA: 0x00150177 File Offset: 0x0014E377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06008B15 RID: 35605 RVA: 0x0015017A File Offset: 0x0014E37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleDataResponse.Descriptor;
			}
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x00150181 File Offset: 0x0014E381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataResponse()
		{
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0015018C File Offset: 0x0014E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataResponse(FloroRanchSettleDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.settleData_ = ((other.settleData_ != null) ? other.settleData_.Clone() : null);
			this.showMvp_ = other.showMvp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x001501E4 File Offset: 0x0014E3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataResponse Clone()
		{
			return new FloroRanchSettleDataResponse(this);
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06008B19 RID: 35609 RVA: 0x001501EC File Offset: 0x0014E3EC
		// (set) Token: 0x06008B1A RID: 35610 RVA: 0x001501F4 File Offset: 0x0014E3F4
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

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06008B1B RID: 35611 RVA: 0x001501FD File Offset: 0x0014E3FD
		// (set) Token: 0x06008B1C RID: 35612 RVA: 0x00150205 File Offset: 0x0014E405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData SettleData
		{
			get
			{
				return this.settleData_;
			}
			set
			{
				this.settleData_ = value;
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06008B1D RID: 35613 RVA: 0x0015020E File Offset: 0x0014E40E
		// (set) Token: 0x06008B1E RID: 35614 RVA: 0x00150216 File Offset: 0x0014E416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowMvp
		{
			get
			{
				return this.showMvp_;
			}
			set
			{
				this.showMvp_ = value;
			}
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x0015021F File Offset: 0x0014E41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleDataResponse);
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x00150230 File Offset: 0x0014E430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SettleData, other.SettleData) && this.ShowMvp == other.ShowMvp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x00150290 File Offset: 0x0014E490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.settleData_ != null)
			{
				num ^= this.SettleData.GetHashCode();
			}
			if (this.ShowMvp)
			{
				num ^= this.ShowMvp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x00150304 File Offset: 0x0014E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x00150311 File Offset: 0x0014E511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x0015031C File Offset: 0x0014E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowMvp)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowMvp);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.settleData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.SettleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B25 RID: 35621 RVA: 0x00150394 File Offset: 0x0014E594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.settleData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SettleData);
			}
			if (this.ShowMvp)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x001503F8 File Offset: 0x0014E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSettleDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.settleData_ != null)
			{
				if (this.settleData_ == null)
				{
					this.SettleData = new FloroRanchPlaySettleData();
				}
				this.SettleData.MergeFrom(other.SettleData);
			}
			if (other.ShowMvp)
			{
				this.ShowMvp = other.ShowMvp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x00150474 File Offset: 0x0014E674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x00150480 File Offset: 0x0014E680
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
					if (num != 64U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.settleData_ == null)
							{
								this.SettleData = new FloroRanchPlaySettleData();
							}
							input.ReadMessage(this.SettleData);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ShowMvp = input.ReadBool();
				}
			}
		}

		// Token: 0x0400442E RID: 17454
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400442F RID: 17455
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004430 RID: 17456
		private ErrorCode errorCode_;

		// Token: 0x04004431 RID: 17457
		public const int SettleDataFieldNumber = 15;

		// Token: 0x04004432 RID: 17458
		private FloroRanchPlaySettleData settleData_;

		// Token: 0x04004433 RID: 17459
		public const int ShowMvpFieldNumber = 2;

		// Token: 0x04004434 RID: 17460
		private bool showMvp_;
	}
}
