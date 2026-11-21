using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E5 RID: 1253
	[NetMessage(EMessageId.ExploreProgressRewardRequest)]
	public sealed class ExploreProgressRewardRequest : IMessage<ExploreProgressRewardRequest>, IMessage, IEquatable<ExploreProgressRewardRequest>, IDeepCloneable<ExploreProgressRewardRequest>, IBufferMessage
	{
		// Token: 0x060076D0 RID: 30416 RVA: 0x00122129 File Offset: 0x00120329
		[NullableContext(1)]
		public static ExploreProgressRewardRequest Create()
		{
			return new ExploreProgressRewardRequest();
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x060076D1 RID: 30417 RVA: 0x00122130 File Offset: 0x00120330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x060076D2 RID: 30418 RVA: 0x00122133 File Offset: 0x00120333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardRequest.Descriptor;
			}
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x0012213A File Offset: 0x0012033A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardRequest()
		{
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x0012214D File Offset: 0x0012034D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardRequest(ExploreProgressRewardRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x00122177 File Offset: 0x00120377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardRequest Clone()
		{
			return new ExploreProgressRewardRequest(this);
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x060076D6 RID: 30422 RVA: 0x0012217F File Offset: 0x0012037F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00122187 File Offset: 0x00120387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardRequest);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00122195 File Offset: 0x00120395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x001221C8 File Offset: 0x001203C8
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

		// Token: 0x060076DA RID: 30426 RVA: 0x001221FC File Offset: 0x001203FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x00122209 File Offset: 0x00120409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00122212 File Offset: 0x00120412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, ExploreProgressRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x0012223C File Offset: 0x0012043C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(ExploreProgressRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x00122275 File Offset: 0x00120475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x001222A3 File Offset: 0x001204A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x001222AC File Offset: 0x001204AC
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, ExploreProgressRewardRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003E51 RID: 15953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E52 RID: 15954
		public const int RewardIdsFieldNumber = 2;

		// Token: 0x04003E53 RID: 15955
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003E54 RID: 15956
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
