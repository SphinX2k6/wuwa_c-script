using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A6 RID: 422
	public sealed class BlackCoastThemeActivity : IMessage<BlackCoastThemeActivity>, IMessage, IEquatable<BlackCoastThemeActivity>, IDeepCloneable<BlackCoastThemeActivity>, IBufferMessage
	{
		// Token: 0x06003195 RID: 12693 RVA: 0x0007E5B8 File Offset: 0x0007C7B8
		[NullableContext(1)]
		public static BlackCoastThemeActivity Create()
		{
			return new BlackCoastThemeActivity();
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0007E5BF File Offset: 0x0007C7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x0007E5C2 File Offset: 0x0007C7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeActivity.Descriptor;
			}
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0007E5C9 File Offset: 0x0007C7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity()
		{
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x0007E5E7 File Offset: 0x0007C7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity(BlackCoastThemeActivity other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this.activeRewardedIds_ = other.activeRewardedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x0007E622 File Offset: 0x0007C822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity Clone()
		{
			return new BlackCoastThemeActivity(this);
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x0007E62A File Offset: 0x0007C82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackCoastThemeStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x0007E632 File Offset: 0x0007C832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveRewardedIds
		{
			get
			{
				return this.activeRewardedIds_;
			}
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0007E63A File Offset: 0x0007C83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeActivity);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x0007E648 File Offset: 0x0007C848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeActivity other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && this.activeRewardedIds_.Equals(other.activeRewardedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x0007E69C File Offset: 0x0007C89C
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

		// Token: 0x060031A0 RID: 12704 RVA: 0x0007E6DE File Offset: 0x0007C8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x0007E6EB File Offset: 0x0007C8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0007E6F4 File Offset: 0x0007C8F4
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

		// Token: 0x060031A3 RID: 12707 RVA: 0x0007E72C File Offset: 0x0007C92C
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

		// Token: 0x060031A4 RID: 12708 RVA: 0x0007E778 File Offset: 0x0007C978
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

		// Token: 0x060031A5 RID: 12709 RVA: 0x0007E7B7 File Offset: 0x0007C9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x0007E7C0 File Offset: 0x0007C9C0
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

		// Token: 0x0400293D RID: 10557
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400293E RID: 10558
		public const int StagesFieldNumber = 1;

		// Token: 0x0400293F RID: 10559
		private static readonly FieldCodec<BlackCoastThemeStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<BlackCoastThemeStageInfo>(10U, BlackCoastThemeStageInfo.Parser);

		// Token: 0x04002940 RID: 10560
		private readonly RepeatedField<BlackCoastThemeStageInfo> stages_ = new RepeatedField<BlackCoastThemeStageInfo>();

		// Token: 0x04002941 RID: 10561
		public const int ActiveRewardedIdsFieldNumber = 2;

		// Token: 0x04002942 RID: 10562
		private static readonly FieldCodec<int> _repeated_activeRewardedIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002943 RID: 10563
		private readonly RepeatedField<int> activeRewardedIds_ = new RepeatedField<int>();
	}
}
