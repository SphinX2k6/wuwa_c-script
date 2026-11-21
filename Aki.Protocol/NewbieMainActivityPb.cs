using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B00 RID: 2816
	public sealed class NewbieMainActivityPb : IMessage<NewbieMainActivityPb>, IMessage, IEquatable<NewbieMainActivityPb>, IDeepCloneable<NewbieMainActivityPb>, IBufferMessage
	{
		// Token: 0x0600F4F2 RID: 62706 RVA: 0x0023C09D File Offset: 0x0023A29D
		[NullableContext(1)]
		public static NewbieMainActivityPb Create()
		{
			return new NewbieMainActivityPb();
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600F4F3 RID: 62707 RVA: 0x0023C0A4 File Offset: 0x0023A2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x0023C0A7 File Offset: 0x0023A2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieMainActivityPb.Descriptor;
			}
		}

		// Token: 0x0600F4F5 RID: 62709 RVA: 0x0023C0AE File Offset: 0x0023A2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb()
		{
		}

		// Token: 0x0600F4F6 RID: 62710 RVA: 0x0023C0CC File Offset: 0x0023A2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb(NewbieMainActivityPb other) : this()
		{
			this.newbieMainTabs_ = other.newbieMainTabs_.Clone();
			this.takenScoreRewardIds_ = other.takenScoreRewardIds_.Clone();
			this.progressScore_ = other.progressScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4F7 RID: 62711 RVA: 0x0023C11E File Offset: 0x0023A31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb Clone()
		{
			return new NewbieMainActivityPb(this);
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600F4F8 RID: 62712 RVA: 0x0023C126 File Offset: 0x0023A326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieMainTabPb> NewbieMainTabs
		{
			get
			{
				return this.newbieMainTabs_;
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600F4F9 RID: 62713 RVA: 0x0023C12E File Offset: 0x0023A32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TakenScoreRewardIds
		{
			get
			{
				return this.takenScoreRewardIds_;
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600F4FA RID: 62714 RVA: 0x0023C136 File Offset: 0x0023A336
		// (set) Token: 0x0600F4FB RID: 62715 RVA: 0x0023C13E File Offset: 0x0023A33E
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

		// Token: 0x0600F4FC RID: 62716 RVA: 0x0023C147 File Offset: 0x0023A347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieMainActivityPb);
		}

		// Token: 0x0600F4FD RID: 62717 RVA: 0x0023C158 File Offset: 0x0023A358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieMainActivityPb other)
		{
			return other != null && (other == this || (this.newbieMainTabs_.Equals(other.newbieMainTabs_) && this.takenScoreRewardIds_.Equals(other.takenScoreRewardIds_) && this.ProgressScore == other.ProgressScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4FE RID: 62718 RVA: 0x0023C1BC File Offset: 0x0023A3BC
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

		// Token: 0x0600F4FF RID: 62719 RVA: 0x0023C217 File Offset: 0x0023A417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F500 RID: 62720 RVA: 0x0023C224 File Offset: 0x0023A424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F501 RID: 62721 RVA: 0x0023C230 File Offset: 0x0023A430
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

		// Token: 0x0600F502 RID: 62722 RVA: 0x0023C290 File Offset: 0x0023A490
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

		// Token: 0x0600F503 RID: 62723 RVA: 0x0023C2F4 File Offset: 0x0023A4F4
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

		// Token: 0x0600F504 RID: 62724 RVA: 0x0023C352 File Offset: 0x0023A552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F505 RID: 62725 RVA: 0x0023C35C File Offset: 0x0023A55C
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

		// Token: 0x040062E1 RID: 25313
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062E2 RID: 25314
		public const int NewbieMainTabsFieldNumber = 2;

		// Token: 0x040062E3 RID: 25315
		private static readonly FieldCodec<NewbieMainTabPb> _repeated_newbieMainTabs_codec = FieldCodec.ForMessage<NewbieMainTabPb>(18U, NewbieMainTabPb.Parser);

		// Token: 0x040062E4 RID: 25316
		private readonly RepeatedField<NewbieMainTabPb> newbieMainTabs_ = new RepeatedField<NewbieMainTabPb>();

		// Token: 0x040062E5 RID: 25317
		public const int TakenScoreRewardIdsFieldNumber = 3;

		// Token: 0x040062E6 RID: 25318
		private static readonly FieldCodec<int> _repeated_takenScoreRewardIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040062E7 RID: 25319
		private readonly RepeatedField<int> takenScoreRewardIds_ = new RepeatedField<int>();

		// Token: 0x040062E8 RID: 25320
		public const int ProgressScoreFieldNumber = 4;

		// Token: 0x040062E9 RID: 25321
		private int progressScore_;
	}
}
