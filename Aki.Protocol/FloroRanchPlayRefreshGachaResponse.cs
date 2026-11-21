using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B0 RID: 1456
	[NetMessage(EMessageId.FloroRanchPlayRefreshGachaResponse)]
	public sealed class FloroRanchPlayRefreshGachaResponse : IMessage<FloroRanchPlayRefreshGachaResponse>, IMessage, IEquatable<FloroRanchPlayRefreshGachaResponse>, IDeepCloneable<FloroRanchPlayRefreshGachaResponse>, IBufferMessage
	{
		// Token: 0x06008718 RID: 34584 RVA: 0x0014619F File Offset: 0x0014439F
		[NullableContext(1)]
		public static FloroRanchPlayRefreshGachaResponse Create()
		{
			return new FloroRanchPlayRefreshGachaResponse();
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06008719 RID: 34585 RVA: 0x001461A6 File Offset: 0x001443A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x0600871A RID: 34586 RVA: 0x001461A9 File Offset: 0x001443A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshGachaResponse.Descriptor;
			}
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x001461B0 File Offset: 0x001443B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaResponse()
		{
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x001461B8 File Offset: 0x001443B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaResponse(FloroRanchPlayRefreshGachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gacha_ = ((other.gacha_ != null) ? other.gacha_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x00146204 File Offset: 0x00144404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaResponse Clone()
		{
			return new FloroRanchPlayRefreshGachaResponse(this);
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600871E RID: 34590 RVA: 0x0014620C File Offset: 0x0014440C
		// (set) Token: 0x0600871F RID: 34591 RVA: 0x00146214 File Offset: 0x00144414
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

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06008720 RID: 34592 RVA: 0x0014621D File Offset: 0x0014441D
		// (set) Token: 0x06008721 RID: 34593 RVA: 0x00146225 File Offset: 0x00144425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha Gacha
		{
			get
			{
				return this.gacha_;
			}
			set
			{
				this.gacha_ = value;
			}
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x0014622E File Offset: 0x0014442E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshGachaResponse);
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x0014623C File Offset: 0x0014443C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshGachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Gacha, other.Gacha) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x0014628C File Offset: 0x0014448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.gacha_ != null)
			{
				num ^= this.Gacha.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x001462E7 File Offset: 0x001444E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x001462F4 File Offset: 0x001444F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x00146300 File Offset: 0x00144500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.gacha_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Gacha);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x0014635C File Offset: 0x0014455C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.gacha_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Gacha);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x001463B4 File Offset: 0x001445B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshGachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.gacha_ != null)
			{
				if (this.gacha_ == null)
				{
					this.Gacha = new FloroRanchGacha();
				}
				this.Gacha.MergeFrom(other.Gacha);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x0014641C File Offset: 0x0014461C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x00146428 File Offset: 0x00144628
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
				if (num != 56U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gacha_ == null)
						{
							this.Gacha = new FloroRanchGacha();
						}
						input.ReadMessage(this.Gacha);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400432A RID: 17194
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400432B RID: 17195
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400432C RID: 17196
		private ErrorCode errorCode_;

		// Token: 0x0400432D RID: 17197
		public const int GachaFieldNumber = 15;

		// Token: 0x0400432E RID: 17198
		private FloroRanchGacha gacha_;
	}
}
