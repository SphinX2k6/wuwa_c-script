using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E8 RID: 4328
	[NetMessage(EMessageId.RoleTowerScoreRewardReceiveRequest)]
	public sealed class RoleTowerScoreRewardReceiveRequest : IMessage<RoleTowerScoreRewardReceiveRequest>, IMessage, IEquatable<RoleTowerScoreRewardReceiveRequest>, IDeepCloneable<RoleTowerScoreRewardReceiveRequest>, IBufferMessage
	{
		// Token: 0x06017234 RID: 94772 RVA: 0x0035DC0D File Offset: 0x0035BE0D
		[NullableContext(1)]
		public static RoleTowerScoreRewardReceiveRequest Create()
		{
			return new RoleTowerScoreRewardReceiveRequest();
		}

		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x06017235 RID: 94773 RVA: 0x0035DC14 File Offset: 0x0035BE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x06017236 RID: 94774 RVA: 0x0035DC17 File Offset: 0x0035BE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerScoreRewardReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06017237 RID: 94775 RVA: 0x0035DC1E File Offset: 0x0035BE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreRewardReceiveRequest()
		{
		}

		// Token: 0x06017238 RID: 94776 RVA: 0x0035DC31 File Offset: 0x0035BE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreRewardReceiveRequest(RoleTowerScoreRewardReceiveRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017239 RID: 94777 RVA: 0x0035DC5B File Offset: 0x0035BE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreRewardReceiveRequest Clone()
		{
			return new RoleTowerScoreRewardReceiveRequest(this);
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x0601723A RID: 94778 RVA: 0x0035DC63 File Offset: 0x0035BE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x0601723B RID: 94779 RVA: 0x0035DC6B File Offset: 0x0035BE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerScoreRewardReceiveRequest);
		}

		// Token: 0x0601723C RID: 94780 RVA: 0x0035DC79 File Offset: 0x0035BE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerScoreRewardReceiveRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601723D RID: 94781 RVA: 0x0035DCAC File Offset: 0x0035BEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601723E RID: 94782 RVA: 0x0035DCE0 File Offset: 0x0035BEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601723F RID: 94783 RVA: 0x0035DCED File Offset: 0x0035BEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017240 RID: 94784 RVA: 0x0035DCF6 File Offset: 0x0035BEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, RoleTowerScoreRewardReceiveRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017241 RID: 94785 RVA: 0x0035DD20 File Offset: 0x0035BF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(RoleTowerScoreRewardReceiveRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017242 RID: 94786 RVA: 0x0035DD59 File Offset: 0x0035BF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerScoreRewardReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017243 RID: 94787 RVA: 0x0035DD87 File Offset: 0x0035BF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017244 RID: 94788 RVA: 0x0035DD90 File Offset: 0x0035BF90
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, RoleTowerScoreRewardReceiveRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04008A76 RID: 35446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A77 RID: 35447
		public const int RewardIdsFieldNumber = 9;

		// Token: 0x04008A78 RID: 35448
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008A79 RID: 35449
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
