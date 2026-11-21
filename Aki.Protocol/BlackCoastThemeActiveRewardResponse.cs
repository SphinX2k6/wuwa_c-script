using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A9 RID: 425
	[NetMessage(EMessageId.BlackCoastThemeActiveRewardResponse)]
	public sealed class BlackCoastThemeActiveRewardResponse : IMessage<BlackCoastThemeActiveRewardResponse>, IMessage, IEquatable<BlackCoastThemeActiveRewardResponse>, IDeepCloneable<BlackCoastThemeActiveRewardResponse>, IBufferMessage
	{
		// Token: 0x0600320E RID: 12814 RVA: 0x0007FA70 File Offset: 0x0007DC70
		[NullableContext(1)]
		public static BlackCoastThemeActiveRewardResponse Create()
		{
			return new BlackCoastThemeActiveRewardResponse();
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x0007FA77 File Offset: 0x0007DC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x0007FA7A File Offset: 0x0007DC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeActiveRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x0007FA81 File Offset: 0x0007DC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardResponse()
		{
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x0007FA94 File Offset: 0x0007DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardResponse(BlackCoastThemeActiveRewardResponse other) : this()
		{
			this.activeRewardedIds_ = other.activeRewardedIds_.Clone();
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x0007FACA File Offset: 0x0007DCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardResponse Clone()
		{
			return new BlackCoastThemeActiveRewardResponse(this);
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x0007FAD2 File Offset: 0x0007DCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveRewardedIds
		{
			get
			{
				return this.activeRewardedIds_;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0007FADA File Offset: 0x0007DCDA
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0007FAE2 File Offset: 0x0007DCE2
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

		// Token: 0x06003217 RID: 12823 RVA: 0x0007FAEB File Offset: 0x0007DCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeActiveRewardResponse);
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x0007FAFC File Offset: 0x0007DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeActiveRewardResponse other)
		{
			return other != null && (other == this || (this.activeRewardedIds_.Equals(other.activeRewardedIds_) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x0007FB4C File Offset: 0x0007DD4C
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

		// Token: 0x0600321A RID: 12826 RVA: 0x0007FB9F File Offset: 0x0007DD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x0007FBAC File Offset: 0x0007DDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x0007FBB8 File Offset: 0x0007DDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Error);
			}
			this.activeRewardedIds_.WriteTo(ref output, BlackCoastThemeActiveRewardResponse._repeated_activeRewardedIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x0007FC08 File Offset: 0x0007DE08
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

		// Token: 0x0600321E RID: 12830 RVA: 0x0007FC5C File Offset: 0x0007DE5C
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

		// Token: 0x0600321F RID: 12831 RVA: 0x0007FCA9 File Offset: 0x0007DEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0007FCB4 File Offset: 0x0007DEB4
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
				if (num != 104U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.activeRewardedIds_.AddEntriesFrom(ref input, BlackCoastThemeActiveRewardResponse._repeated_activeRewardedIds_codec);
					}
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040029B2 RID: 10674
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B3 RID: 10675
		public const int ActiveRewardedIdsFieldNumber = 15;

		// Token: 0x040029B4 RID: 10676
		private static readonly FieldCodec<int> _repeated_activeRewardedIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040029B5 RID: 10677
		private readonly RepeatedField<int> activeRewardedIds_ = new RepeatedField<int>();

		// Token: 0x040029B6 RID: 10678
		public const int ErrorFieldNumber = 13;

		// Token: 0x040029B7 RID: 10679
		private ErrorCode error_;
	}
}
