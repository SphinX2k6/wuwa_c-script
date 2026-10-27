using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000587 RID: 1415
	[NetMessage(EMessageId.FishingSkillBombResponse)]
	public sealed class FishingSkillBombResponse : IMessage<FishingSkillBombResponse>, IMessage, IEquatable<FishingSkillBombResponse>, IDeepCloneable<FishingSkillBombResponse>, IBufferMessage
	{
		// Token: 0x06008350 RID: 33616 RVA: 0x0013C6A5 File Offset: 0x0013A8A5
		[NullableContext(1)]
		public static FishingSkillBombResponse Create()
		{
			return new FishingSkillBombResponse();
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x0013C6AC File Offset: 0x0013A8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x0013C6AF File Offset: 0x0013A8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBombResponse.Descriptor;
			}
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x0013C6B6 File Offset: 0x0013A8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombResponse()
		{
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0013C6C9 File Offset: 0x0013A8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombResponse(FishingSkillBombResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x0013C6FF File Offset: 0x0013A8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombResponse Clone()
		{
			return new FishingSkillBombResponse(this);
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06008356 RID: 33622 RVA: 0x0013C707 File Offset: 0x0013A907
		// (set) Token: 0x06008357 RID: 33623 RVA: 0x0013C70F File Offset: 0x0013A90F
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

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06008358 RID: 33624 RVA: 0x0013C718 File Offset: 0x0013A918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x0013C720 File Offset: 0x0013A920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBombResponse);
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x0013C730 File Offset: 0x0013A930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBombResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x0013C780 File Offset: 0x0013A980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0013C7D3 File Offset: 0x0013A9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0013C7E0 File Offset: 0x0013A9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0013C7EC File Offset: 0x0013A9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, FishingSkillBombResponse._repeated_items_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x0013C83C File Offset: 0x0013AA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(FishingSkillBombResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0013C890 File Offset: 0x0013AA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillBombResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x0013C8DD File Offset: 0x0013AADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0013C8E8 File Offset: 0x0013AAE8
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
				if (num != 26U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, FishingSkillBombResponse._repeated_items_codec);
				}
			}
		}

		// Token: 0x04004172 RID: 16754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004173 RID: 16755
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004174 RID: 16756
		private ErrorCode errorCode_;

		// Token: 0x04004175 RID: 16757
		public const int ItemsFieldNumber = 3;

		// Token: 0x04004176 RID: 16758
		private static readonly FieldCodec<FishingItemInfo> _repeated_items_codec = FieldCodec.ForMessage<FishingItemInfo>(26U, FishingItemInfo.Parser);

		// Token: 0x04004177 RID: 16759
		private readonly RepeatedField<FishingItemInfo> items_ = new RepeatedField<FishingItemInfo>();
	}
}
