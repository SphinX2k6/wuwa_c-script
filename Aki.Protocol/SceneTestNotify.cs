using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CD RID: 4557
	[NetMessage(EMessageId.SceneTestNotify)]
	public sealed class SceneTestNotify : IMessage<SceneTestNotify>, IMessage, IEquatable<SceneTestNotify>, IDeepCloneable<SceneTestNotify>, IBufferMessage
	{
		// Token: 0x06018545 RID: 99653 RVA: 0x0038AAB6 File Offset: 0x00388CB6
		[NullableContext(1)]
		public static SceneTestNotify Create()
		{
			return new SceneTestNotify();
		}

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x06018546 RID: 99654 RVA: 0x0038AABD File Offset: 0x00388CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x06018547 RID: 99655 RVA: 0x0038AAC0 File Offset: 0x00388CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneTestNotify.Descriptor;
			}
		}

		// Token: 0x06018548 RID: 99656 RVA: 0x0038AAC7 File Offset: 0x00388CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTestNotify()
		{
		}

		// Token: 0x06018549 RID: 99657 RVA: 0x0038AADA File Offset: 0x00388CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTestNotify(SceneTestNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorMsg_ = other.errorMsg_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601854A RID: 99658 RVA: 0x0038AB17 File Offset: 0x00388D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTestNotify Clone()
		{
			return new SceneTestNotify(this);
		}

		// Token: 0x17005201 RID: 20993
		// (get) Token: 0x0601854B RID: 99659 RVA: 0x0038AB1F File Offset: 0x00388D1F
		// (set) Token: 0x0601854C RID: 99660 RVA: 0x0038AB27 File Offset: 0x00388D27
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

		// Token: 0x17005202 RID: 20994
		// (get) Token: 0x0601854D RID: 99661 RVA: 0x0038AB30 File Offset: 0x00388D30
		// (set) Token: 0x0601854E RID: 99662 RVA: 0x0038AB38 File Offset: 0x00388D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ErrorMsg
		{
			get
			{
				return this.errorMsg_;
			}
			set
			{
				this.errorMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x0601854F RID: 99663 RVA: 0x0038AB4B File Offset: 0x00388D4B
		// (set) Token: 0x06018550 RID: 99664 RVA: 0x0038AB53 File Offset: 0x00388D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06018551 RID: 99665 RVA: 0x0038AB5C File Offset: 0x00388D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneTestNotify);
		}

		// Token: 0x06018552 RID: 99666 RVA: 0x0038AB6C File Offset: 0x00388D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneTestNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.ErrorMsg != other.ErrorMsg) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018553 RID: 99667 RVA: 0x0038ABCC File Offset: 0x00388DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ErrorMsg.Length != 0)
			{
				num ^= this.ErrorMsg.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018554 RID: 99668 RVA: 0x0038AC45 File Offset: 0x00388E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018555 RID: 99669 RVA: 0x0038AC52 File Offset: 0x00388E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018556 RID: 99670 RVA: 0x0038AC5C File Offset: 0x00388E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ErrorMsg.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.ErrorMsg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018557 RID: 99671 RVA: 0x0038ACD8 File Offset: 0x00388ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ErrorMsg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ErrorMsg);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018558 RID: 99672 RVA: 0x0038AD4C File Offset: 0x00388F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneTestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ErrorMsg.Length != 0)
			{
				this.ErrorMsg = other.ErrorMsg;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018559 RID: 99673 RVA: 0x0038ADB5 File Offset: 0x00388FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601855A RID: 99674 RVA: 0x0038ADC0 File Offset: 0x00388FC0
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
				if (num != 24U)
				{
					if (num != 48U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorMsg = input.ReadString();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400909C RID: 37020
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400909D RID: 37021
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400909E RID: 37022
		private ErrorCode errorCode_;

		// Token: 0x0400909F RID: 37023
		public const int ErrorMsgFieldNumber = 7;

		// Token: 0x040090A0 RID: 37024
		private string errorMsg_ = "";

		// Token: 0x040090A1 RID: 37025
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x040090A2 RID: 37026
		private int playerId_;
	}
}
