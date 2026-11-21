using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CB RID: 1483
	[NetMessage(EMessageId.FloroRanchSettleDataResponse)]
	public sealed class FloroRanchSettleDataResponse : IMessage<FloroRanchSettleDataResponse>, IMessage, IEquatable<FloroRanchSettleDataResponse>, IDeepCloneable<FloroRanchSettleDataResponse>, IBufferMessage
	{
		// Token: 0x060089AB RID: 35243 RVA: 0x0014D558 File Offset: 0x0014B758
		[NullableContext(1)]
		public static FloroRanchSettleDataResponse Create()
		{
			return new FloroRanchSettleDataResponse();
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x0014D55F File Offset: 0x0014B75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x0014D562 File Offset: 0x0014B762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleDataResponse.Descriptor;
			}
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x0014D569 File Offset: 0x0014B769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataResponse()
		{
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x0014D574 File Offset: 0x0014B774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataResponse(FloroRanchSettleDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.settleData_ = ((other.settleData_ != null) ? other.settleData_.Clone() : null);
			this.showMvp_ = other.showMvp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x0014D5CC File Offset: 0x0014B7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataResponse Clone()
		{
			return new FloroRanchSettleDataResponse(this);
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x060089B1 RID: 35249 RVA: 0x0014D5D4 File Offset: 0x0014B7D4
		// (set) Token: 0x060089B2 RID: 35250 RVA: 0x0014D5DC File Offset: 0x0014B7DC
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

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060089B3 RID: 35251 RVA: 0x0014D5E5 File Offset: 0x0014B7E5
		// (set) Token: 0x060089B4 RID: 35252 RVA: 0x0014D5ED File Offset: 0x0014B7ED
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

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060089B5 RID: 35253 RVA: 0x0014D5F6 File Offset: 0x0014B7F6
		// (set) Token: 0x060089B6 RID: 35254 RVA: 0x0014D5FE File Offset: 0x0014B7FE
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

		// Token: 0x060089B7 RID: 35255 RVA: 0x0014D607 File Offset: 0x0014B807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleDataResponse);
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x0014D618 File Offset: 0x0014B818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SettleData, other.SettleData) && this.ShowMvp == other.ShowMvp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x0014D678 File Offset: 0x0014B878
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

		// Token: 0x060089BA RID: 35258 RVA: 0x0014D6EC File Offset: 0x0014B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x0014D6F9 File Offset: 0x0014B8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x0014D704 File Offset: 0x0014B904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.settleData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SettleData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ShowMvp)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.ShowMvp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x0014D77C File Offset: 0x0014B97C
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

		// Token: 0x060089BE RID: 35262 RVA: 0x0014D7E0 File Offset: 0x0014B9E0
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

		// Token: 0x060089BF RID: 35263 RVA: 0x0014D85C File Offset: 0x0014BA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x0014D868 File Offset: 0x0014BA68
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
				if (num != 34U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ShowMvp = input.ReadBool();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x04004424 RID: 17444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004425 RID: 17445
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004426 RID: 17446
		private ErrorCode errorCode_;

		// Token: 0x04004427 RID: 17447
		public const int SettleDataFieldNumber = 4;

		// Token: 0x04004428 RID: 17448
		private FloroRanchPlaySettleData settleData_;

		// Token: 0x04004429 RID: 17449
		public const int ShowMvpFieldNumber = 13;

		// Token: 0x0400442A RID: 17450
		private bool showMvp_;
	}
}
