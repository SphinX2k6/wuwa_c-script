using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B11 RID: 2833
	public sealed class NewbieMainActivityPb : IMessage<NewbieMainActivityPb>, IMessage, IEquatable<NewbieMainActivityPb>, IDeepCloneable<NewbieMainActivityPb>, IBufferMessage
	{
		// Token: 0x0600F60C RID: 62988 RVA: 0x0023E2A9 File Offset: 0x0023C4A9
		[NullableContext(1)]
		public static NewbieMainActivityPb Create()
		{
			return new NewbieMainActivityPb();
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600F60D RID: 62989 RVA: 0x0023E2B0 File Offset: 0x0023C4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600F60E RID: 62990 RVA: 0x0023E2B3 File Offset: 0x0023C4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieMainActivityPb.Descriptor;
			}
		}

		// Token: 0x0600F60F RID: 62991 RVA: 0x0023E2BA File Offset: 0x0023C4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb()
		{
		}

		// Token: 0x0600F610 RID: 62992 RVA: 0x0023E2D8 File Offset: 0x0023C4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb(NewbieMainActivityPb other) : this()
		{
			this.newbieMainTabs_ = other.newbieMainTabs_.Clone();
			this.takenScoreRewardIds_ = other.takenScoreRewardIds_.Clone();
			this.progressScore_ = other.progressScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F611 RID: 62993 RVA: 0x0023E32A File Offset: 0x0023C52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb Clone()
		{
			return new NewbieMainActivityPb(this);
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600F612 RID: 62994 RVA: 0x0023E332 File Offset: 0x0023C532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieMainTabPb> NewbieMainTabs
		{
			get
			{
				return this.newbieMainTabs_;
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600F613 RID: 62995 RVA: 0x0023E33A File Offset: 0x0023C53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TakenScoreRewardIds
		{
			get
			{
				return this.takenScoreRewardIds_;
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600F614 RID: 62996 RVA: 0x0023E342 File Offset: 0x0023C542
		// (set) Token: 0x0600F615 RID: 62997 RVA: 0x0023E34A File Offset: 0x0023C54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ProgressScore
		{
			get
			{
				return this.progressScore_;
			}
			set
			{
				this.progressScore_ = value;
			}
		}

		// Token: 0x0600F616 RID: 62998 RVA: 0x0023E353 File Offset: 0x0023C553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieMainActivityPb);
		}

		// Token: 0x0600F617 RID: 62999 RVA: 0x0023E364 File Offset: 0x0023C564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieMainActivityPb other)
		{
			return other != null && (other == this || (this.newbieMainTabs_.Equals(other.newbieMainTabs_) && this.takenScoreRewardIds_.Equals(other.takenScoreRewardIds_) && this.ProgressScore == other.ProgressScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F618 RID: 63000 RVA: 0x0023E3C8 File Offset: 0x0023C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.newbieMainTabs_.GetHashCode();
			num ^= this.takenScoreRewardIds_.GetHashCode();
			if (this.ProgressScore != 0)
			{
				num ^= this.ProgressScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F619 RID: 63001 RVA: 0x0023E423 File Offset: 0x0023C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F61A RID: 63002 RVA: 0x0023E430 File Offset: 0x0023C630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F61B RID: 63003 RVA: 0x0023E43C File Offset: 0x0023C63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.newbieMainTabs_.WriteTo(ref output, NewbieMainActivityPb._repeated_newbieMainTabs_codec);
			this.takenScoreRewardIds_.WriteTo(ref output, NewbieMainActivityPb._repeated_takenScoreRewardIds_codec);
			if (this.ProgressScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ProgressScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F61C RID: 63004 RVA: 0x0023E49C File Offset: 0x0023C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.newbieMainTabs_.CalculateSize(NewbieMainActivityPb._repeated_newbieMainTabs_codec);
			num += this.takenScoreRewardIds_.CalculateSize(NewbieMainActivityPb._repeated_takenScoreRewardIds_codec);
			if (this.ProgressScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProgressScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F61D RID: 63005 RVA: 0x0023E500 File Offset: 0x0023C700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieMainActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.newbieMainTabs_.Add(other.newbieMainTabs_);
			this.takenScoreRewardIds_.Add(other.takenScoreRewardIds_);
			if (other.ProgressScore != 0)
			{
				this.ProgressScore = other.ProgressScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F61E RID: 63006 RVA: 0x0023E55E File Offset: 0x0023C75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F61F RID: 63007 RVA: 0x0023E568 File Offset: 0x0023C768
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
				if (num <= 24U)
				{
					if (num == 18U)
					{
						this.newbieMainTabs_.AddEntriesFrom(ref input, NewbieMainActivityPb._repeated_newbieMainTabs_codec);
						continue;
					}
					if (num == 24U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_4B;
					}
					if (num == 32U)
					{
						this.ProgressScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.takenScoreRewardIds_.AddEntriesFrom(ref input, NewbieMainActivityPb._repeated_takenScoreRewardIds_codec);
			}
		}

		// Token: 0x040062D8 RID: 25304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062D9 RID: 25305
		public const int NewbieMainTabsFieldNumber = 2;

		// Token: 0x040062DA RID: 25306
		private static readonly FieldCodec<NewbieMainTabPb> _repeated_newbieMainTabs_codec = FieldCodec.ForMessage<NewbieMainTabPb>(18U, NewbieMainTabPb.Parser);

		// Token: 0x040062DB RID: 25307
		private readonly RepeatedField<NewbieMainTabPb> newbieMainTabs_ = new RepeatedField<NewbieMainTabPb>();

		// Token: 0x040062DC RID: 25308
		public const int TakenScoreRewardIdsFieldNumber = 3;

		// Token: 0x040062DD RID: 25309
		private static readonly FieldCodec<int> _repeated_takenScoreRewardIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040062DE RID: 25310
		private readonly RepeatedField<int> takenScoreRewardIds_ = new RepeatedField<int>();

		// Token: 0x040062DF RID: 25311
		public const int ProgressScoreFieldNumber = 4;

		// Token: 0x040062E0 RID: 25312
		private int progressScore_;
	}
}
