using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A5 RID: 421
	[NetMessage(EMessageId.BlackCoastThemeActiveRewardResponse)]
	public sealed class BlackCoastThemeActiveRewardResponse : IMessage<BlackCoastThemeActiveRewardResponse>, IMessage, IEquatable<BlackCoastThemeActiveRewardResponse>, IDeepCloneable<BlackCoastThemeActiveRewardResponse>, IBufferMessage
	{
		// Token: 0x06003181 RID: 12673 RVA: 0x0007E307 File Offset: 0x0007C507
		[NullableContext(1)]
		public static BlackCoastThemeActiveRewardResponse Create()
		{
			return new BlackCoastThemeActiveRewardResponse();
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0007E30E File Offset: 0x0007C50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x0007E311 File Offset: 0x0007C511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeActiveRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x0007E318 File Offset: 0x0007C518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardResponse()
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x0007E32B File Offset: 0x0007C52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardResponse(BlackCoastThemeActiveRewardResponse other) : this()
		{
			this.activeRewardedIds_ = other.activeRewardedIds_.Clone();
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x0007E361 File Offset: 0x0007C561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardResponse Clone()
		{
			return new BlackCoastThemeActiveRewardResponse(this);
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0007E369 File Offset: 0x0007C569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveRewardedIds
		{
			get
			{
				return this.activeRewardedIds_;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x0007E371 File Offset: 0x0007C571
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0007E379 File Offset: 0x0007C579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x0007E382 File Offset: 0x0007C582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeActiveRewardResponse);
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x0007E390 File Offset: 0x0007C590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeActiveRewardResponse other)
		{
			return other != null && (other == this || (this.activeRewardedIds_.Equals(other.activeRewardedIds_) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0007E3E0 File Offset: 0x0007C5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activeRewardedIds_.GetHashCode();
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0007E433 File Offset: 0x0007C633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0007E440 File Offset: 0x0007C640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x0007E44C File Offset: 0x0007C64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeRewardedIds_.WriteTo(ref output, BlackCoastThemeActiveRewardResponse._repeated_activeRewardedIds_codec);
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x0007E49C File Offset: 0x0007C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activeRewardedIds_.CalculateSize(BlackCoastThemeActiveRewardResponse._repeated_activeRewardedIds_codec);
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0007E4F0 File Offset: 0x0007C6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeActiveRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.activeRewardedIds_.Add(other.activeRewardedIds_);
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0007E53D File Offset: 0x0007C73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x0007E548 File Offset: 0x0007C748
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
				if (num != 72U && num != 74U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Error = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.activeRewardedIds_.AddEntriesFrom(ref input, BlackCoastThemeActiveRewardResponse._repeated_activeRewardedIds_codec);
				}
			}
		}

		// Token: 0x04002937 RID: 10551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002938 RID: 10552
		public const int ActiveRewardedIdsFieldNumber = 9;

		// Token: 0x04002939 RID: 10553
		private static readonly FieldCodec<int> _repeated_activeRewardedIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400293A RID: 10554
		private readonly RepeatedField<int> activeRewardedIds_ = new RepeatedField<int>();

		// Token: 0x0400293B RID: 10555
		public const int ErrorFieldNumber = 12;

		// Token: 0x0400293C RID: 10556
		private ErrorCode error_;
	}
}
