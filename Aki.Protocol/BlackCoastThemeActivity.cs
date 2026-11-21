using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AA RID: 426
	public sealed class BlackCoastThemeActivity : IMessage<BlackCoastThemeActivity>, IMessage, IEquatable<BlackCoastThemeActivity>, IDeepCloneable<BlackCoastThemeActivity>, IBufferMessage
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x0007FD24 File Offset: 0x0007DF24
		[NullableContext(1)]
		public static BlackCoastThemeActivity Create()
		{
			return new BlackCoastThemeActivity();
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x0007FD2B File Offset: 0x0007DF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x0007FD2E File Offset: 0x0007DF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeActivity.Descriptor;
			}
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0007FD35 File Offset: 0x0007DF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity()
		{
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0007FD53 File Offset: 0x0007DF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity(BlackCoastThemeActivity other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this.activeRewardedIds_ = other.activeRewardedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x0007FD8E File Offset: 0x0007DF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity Clone()
		{
			return new BlackCoastThemeActivity(this);
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x0007FD96 File Offset: 0x0007DF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackCoastThemeStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x0007FD9E File Offset: 0x0007DF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveRewardedIds
		{
			get
			{
				return this.activeRewardedIds_;
			}
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0007FDA6 File Offset: 0x0007DFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeActivity);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x0007FDB4 File Offset: 0x0007DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeActivity other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && this.activeRewardedIds_.Equals(other.activeRewardedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x0007FE08 File Offset: 0x0007E008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stages_.GetHashCode();
			num ^= this.activeRewardedIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x0007FE4A File Offset: 0x0007E04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x0007FE57 File Offset: 0x0007E057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x0007FE60 File Offset: 0x0007E060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stages_.WriteTo(ref output, BlackCoastThemeActivity._repeated_stages_codec);
			this.activeRewardedIds_.WriteTo(ref output, BlackCoastThemeActivity._repeated_activeRewardedIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0007FE98 File Offset: 0x0007E098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stages_.CalculateSize(BlackCoastThemeActivity._repeated_stages_codec);
			num += this.activeRewardedIds_.CalculateSize(BlackCoastThemeActivity._repeated_activeRewardedIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0007FEE4 File Offset: 0x0007E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.stages_.Add(other.stages_);
			this.activeRewardedIds_.Add(other.activeRewardedIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0007FF23 File Offset: 0x0007E123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x0007FF2C File Offset: 0x0007E12C
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
				if (num != 10U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.activeRewardedIds_.AddEntriesFrom(ref input, BlackCoastThemeActivity._repeated_activeRewardedIds_codec);
					}
				}
				else
				{
					this.stages_.AddEntriesFrom(ref input, BlackCoastThemeActivity._repeated_stages_codec);
				}
			}
		}

		// Token: 0x040029B8 RID: 10680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B9 RID: 10681
		public const int StagesFieldNumber = 1;

		// Token: 0x040029BA RID: 10682
		private static readonly FieldCodec<BlackCoastThemeStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<BlackCoastThemeStageInfo>(10U, BlackCoastThemeStageInfo.Parser);

		// Token: 0x040029BB RID: 10683
		private readonly RepeatedField<BlackCoastThemeStageInfo> stages_ = new RepeatedField<BlackCoastThemeStageInfo>();

		// Token: 0x040029BC RID: 10684
		public const int ActiveRewardedIdsFieldNumber = 2;

		// Token: 0x040029BD RID: 10685
		private static readonly FieldCodec<int> _repeated_activeRewardedIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040029BE RID: 10686
		private readonly RepeatedField<int> activeRewardedIds_ = new RepeatedField<int>();
	}
}
