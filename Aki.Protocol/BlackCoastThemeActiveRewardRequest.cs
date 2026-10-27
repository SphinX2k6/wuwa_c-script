using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A4 RID: 420
	[NetMessage(EMessageId.BlackCoastThemeActiveRewardRequest)]
	public sealed class BlackCoastThemeActiveRewardRequest : IMessage<BlackCoastThemeActiveRewardRequest>, IMessage, IEquatable<BlackCoastThemeActiveRewardRequest>, IDeepCloneable<BlackCoastThemeActiveRewardRequest>, IBufferMessage
	{
		// Token: 0x0600316D RID: 12653 RVA: 0x0007E05D File Offset: 0x0007C25D
		[NullableContext(1)]
		public static BlackCoastThemeActiveRewardRequest Create()
		{
			return new BlackCoastThemeActiveRewardRequest();
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x0007E064 File Offset: 0x0007C264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x0007E067 File Offset: 0x0007C267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeActiveRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x0007E06E File Offset: 0x0007C26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardRequest()
		{
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0007E081 File Offset: 0x0007C281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardRequest(BlackCoastThemeActiveRewardRequest other) : this()
		{
			this.activeRewardIds_ = other.activeRewardIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x0007E0B7 File Offset: 0x0007C2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardRequest Clone()
		{
			return new BlackCoastThemeActiveRewardRequest(this);
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x0007E0BF File Offset: 0x0007C2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveRewardIds
		{
			get
			{
				return this.activeRewardIds_;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x0007E0C7 File Offset: 0x0007C2C7
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x0007E0CF File Offset: 0x0007C2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0007E0D8 File Offset: 0x0007C2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeActiveRewardRequest);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0007E0E8 File Offset: 0x0007C2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeActiveRewardRequest other)
		{
			return other != null && (other == this || (this.activeRewardIds_.Equals(other.activeRewardIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x0007E138 File Offset: 0x0007C338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activeRewardIds_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x0007E185 File Offset: 0x0007C385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x0007E192 File Offset: 0x0007C392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x0007E19C File Offset: 0x0007C39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeRewardIds_.WriteTo(ref output, BlackCoastThemeActiveRewardRequest._repeated_activeRewardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x0007E1EC File Offset: 0x0007C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activeRewardIds_.CalculateSize(BlackCoastThemeActiveRewardRequest._repeated_activeRewardIds_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x0007E240 File Offset: 0x0007C440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeActiveRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.activeRewardIds_.Add(other.activeRewardIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x0007E28D File Offset: 0x0007C48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x0007E298 File Offset: 0x0007C498
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
				if (num != 8U && num != 10U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.activeRewardIds_.AddEntriesFrom(ref input, BlackCoastThemeActiveRewardRequest._repeated_activeRewardIds_codec);
				}
			}
		}

		// Token: 0x04002931 RID: 10545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002932 RID: 10546
		public const int ActiveRewardIdsFieldNumber = 1;

		// Token: 0x04002933 RID: 10547
		private static readonly FieldCodec<int> _repeated_activeRewardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002934 RID: 10548
		private readonly RepeatedField<int> activeRewardIds_ = new RepeatedField<int>();

		// Token: 0x04002935 RID: 10549
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04002936 RID: 10550
		private int activityId_;
	}
}
