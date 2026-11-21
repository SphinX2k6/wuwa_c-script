using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC5 RID: 2757
	[NetMessage(EMessageId.MulCalabashLevelRewardRequest)]
	public sealed class MulCalabashLevelRewardRequest : IMessage<MulCalabashLevelRewardRequest>, IMessage, IEquatable<MulCalabashLevelRewardRequest>, IDeepCloneable<MulCalabashLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F059 RID: 61529 RVA: 0x0023241C File Offset: 0x0023061C
		[NullableContext(1)]
		public static MulCalabashLevelRewardRequest Create()
		{
			return new MulCalabashLevelRewardRequest();
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600F05A RID: 61530 RVA: 0x00232423 File Offset: 0x00230623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600F05B RID: 61531 RVA: 0x00232426 File Offset: 0x00230626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCalabashLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F05C RID: 61532 RVA: 0x0023242D File Offset: 0x0023062D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardRequest()
		{
		}

		// Token: 0x0600F05D RID: 61533 RVA: 0x00232440 File Offset: 0x00230640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardRequest(MulCalabashLevelRewardRequest other) : this()
		{
			this.level_ = other.level_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F05E RID: 61534 RVA: 0x0023246A File Offset: 0x0023066A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardRequest Clone()
		{
			return new MulCalabashLevelRewardRequest(this);
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600F05F RID: 61535 RVA: 0x00232472 File Offset: 0x00230672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Level
		{
			get
			{
				return this.level_;
			}
		}

		// Token: 0x0600F060 RID: 61536 RVA: 0x0023247A File Offset: 0x0023067A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCalabashLevelRewardRequest);
		}

		// Token: 0x0600F061 RID: 61537 RVA: 0x00232488 File Offset: 0x00230688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCalabashLevelRewardRequest other)
		{
			return other != null && (other == this || (this.level_.Equals(other.level_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F062 RID: 61538 RVA: 0x002324BC File Offset: 0x002306BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.level_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F063 RID: 61539 RVA: 0x002324F0 File Offset: 0x002306F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F064 RID: 61540 RVA: 0x002324FD File Offset: 0x002306FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F065 RID: 61541 RVA: 0x00232506 File Offset: 0x00230706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.level_.WriteTo(ref output, MulCalabashLevelRewardRequest._repeated_level_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F066 RID: 61542 RVA: 0x00232530 File Offset: 0x00230730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.level_.CalculateSize(MulCalabashLevelRewardRequest._repeated_level_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F067 RID: 61543 RVA: 0x00232569 File Offset: 0x00230769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulCalabashLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.level_.Add(other.level_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F068 RID: 61544 RVA: 0x00232597 File Offset: 0x00230797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F069 RID: 61545 RVA: 0x002325A0 File Offset: 0x002307A0
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.level_.AddEntriesFrom(ref input, MulCalabashLevelRewardRequest._repeated_level_codec);
				}
			}
		}

		// Token: 0x04006194 RID: 24980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006195 RID: 24981
		public const int LevelFieldNumber = 4;

		// Token: 0x04006196 RID: 24982
		private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006197 RID: 24983
		private readonly RepeatedField<int> level_ = new RepeatedField<int>();
	}
}
