using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BB RID: 1467
	[NetMessage(EMessageId.FloroRanchPlayEventChoiceResponse)]
	public sealed class FloroRanchPlayEventChoiceResponse : IMessage<FloroRanchPlayEventChoiceResponse>, IMessage, IEquatable<FloroRanchPlayEventChoiceResponse>, IDeepCloneable<FloroRanchPlayEventChoiceResponse>, IBufferMessage
	{
		// Token: 0x06008789 RID: 34697 RVA: 0x00146129 File Offset: 0x00144329
		[NullableContext(1)]
		public static FloroRanchPlayEventChoiceResponse Create()
		{
			return new FloroRanchPlayEventChoiceResponse();
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x0600878A RID: 34698 RVA: 0x00146130 File Offset: 0x00144330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600878B RID: 34699 RVA: 0x00146133 File Offset: 0x00144333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayEventChoiceResponse.Descriptor;
			}
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x0014613A File Offset: 0x0014433A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceResponse()
		{
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x00146144 File Offset: 0x00144344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceResponse(FloroRanchPlayEventChoiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.update_ = ((other.update_ != null) ? other.update_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x00146190 File Offset: 0x00144390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceResponse Clone()
		{
			return new FloroRanchPlayEventChoiceResponse(this);
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600878F RID: 34703 RVA: 0x00146198 File Offset: 0x00144398
		// (set) Token: 0x06008790 RID: 34704 RVA: 0x001461A0 File Offset: 0x001443A0
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

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06008791 RID: 34705 RVA: 0x001461A9 File Offset: 0x001443A9
		// (set) Token: 0x06008792 RID: 34706 RVA: 0x001461B1 File Offset: 0x001443B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo Update
		{
			get
			{
				return this.update_;
			}
			set
			{
				this.update_ = value;
			}
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x001461BA File Offset: 0x001443BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayEventChoiceResponse);
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x001461C8 File Offset: 0x001443C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayEventChoiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Update, other.Update) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x00146218 File Offset: 0x00144418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.update_ != null)
			{
				num ^= this.Update.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x00146273 File Offset: 0x00144473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x00146280 File Offset: 0x00144480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x0014628C File Offset: 0x0014448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.update_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Update);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x001462E8 File Offset: 0x001444E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.update_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Update);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x00146340 File Offset: 0x00144540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayEventChoiceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.update_ != null)
			{
				if (this.update_ == null)
				{
					this.Update = new FloroRanchPlayInfo();
				}
				this.Update.MergeFrom(other.Update);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x001463A8 File Offset: 0x001445A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x001463B4 File Offset: 0x001445B4
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
				if (num != 64U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.update_ == null)
						{
							this.Update = new FloroRanchPlayInfo();
						}
						input.ReadMessage(this.Update);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040042C9 RID: 17097
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042CA RID: 17098
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040042CB RID: 17099
		private ErrorCode errorCode_;

		// Token: 0x040042CC RID: 17100
		public const int UpdateFieldNumber = 13;

		// Token: 0x040042CD RID: 17101
		private FloroRanchPlayInfo update_;
	}
}
