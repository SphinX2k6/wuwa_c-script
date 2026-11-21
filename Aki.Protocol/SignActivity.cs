using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001250 RID: 4688
	public sealed class SignActivity : IMessage<SignActivity>, IMessage, IEquatable<SignActivity>, IDeepCloneable<SignActivity>, IBufferMessage
	{
		// Token: 0x0601907F RID: 102527 RVA: 0x003A643F File Offset: 0x003A463F
		[NullableContext(1)]
		public static SignActivity Create()
		{
			return new SignActivity();
		}

		// Token: 0x17005498 RID: 21656
		// (get) Token: 0x06019080 RID: 102528 RVA: 0x003A6446 File Offset: 0x003A4646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x06019081 RID: 102529 RVA: 0x003A6449 File Offset: 0x003A4649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivity.Descriptor;
			}
		}

		// Token: 0x06019082 RID: 102530 RVA: 0x003A6450 File Offset: 0x003A4650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity()
		{
		}

		// Token: 0x06019083 RID: 102531 RVA: 0x003A6463 File Offset: 0x003A4663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity(SignActivity other) : this()
		{
			this.signStateList_ = other.signStateList_.Clone();
			this.rewardFree_ = other.rewardFree_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019084 RID: 102532 RVA: 0x003A6499 File Offset: 0x003A4699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity Clone()
		{
			return new SignActivity(this);
		}

		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x06019085 RID: 102533 RVA: 0x003A64A1 File Offset: 0x003A46A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SignState> SignStateList
		{
			get
			{
				return this.signStateList_;
			}
		}

		// Token: 0x1700549B RID: 21659
		// (get) Token: 0x06019086 RID: 102534 RVA: 0x003A64A9 File Offset: 0x003A46A9
		// (set) Token: 0x06019087 RID: 102535 RVA: 0x003A64B1 File Offset: 0x003A46B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardFree
		{
			get
			{
				return this.rewardFree_;
			}
			set
			{
				this.rewardFree_ = value;
			}
		}

		// Token: 0x06019088 RID: 102536 RVA: 0x003A64BA File Offset: 0x003A46BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivity);
		}

		// Token: 0x06019089 RID: 102537 RVA: 0x003A64C8 File Offset: 0x003A46C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivity other)
		{
			return other != null && (other == this || (this.signStateList_.Equals(other.signStateList_) && this.RewardFree == other.RewardFree && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601908A RID: 102538 RVA: 0x003A6518 File Offset: 0x003A4718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.signStateList_.GetHashCode();
			if (this.RewardFree)
			{
				num ^= this.RewardFree.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601908B RID: 102539 RVA: 0x003A6565 File Offset: 0x003A4765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601908C RID: 102540 RVA: 0x003A6572 File Offset: 0x003A4772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601908D RID: 102541 RVA: 0x003A657C File Offset: 0x003A477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.signStateList_.WriteTo(ref output, SignActivity._repeated_signStateList_codec);
			if (this.RewardFree)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.RewardFree);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601908E RID: 102542 RVA: 0x003A65CC File Offset: 0x003A47CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.signStateList_.CalculateSize(SignActivity._repeated_signStateList_codec);
			if (this.RewardFree)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601908F RID: 102543 RVA: 0x003A6614 File Offset: 0x003A4814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.signStateList_.Add(other.signStateList_);
			if (other.RewardFree)
			{
				this.RewardFree = other.RewardFree;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019090 RID: 102544 RVA: 0x003A6661 File Offset: 0x003A4861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019091 RID: 102545 RVA: 0x003A666C File Offset: 0x003A486C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RewardFree = input.ReadBool();
					}
				}
				else
				{
					this.signStateList_.AddEntriesFrom(ref input, SignActivity._repeated_signStateList_codec);
				}
			}
		}

		// Token: 0x04009460 RID: 37984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009461 RID: 37985
		public const int SignStateListFieldNumber = 1;

		// Token: 0x04009462 RID: 37986
		private static readonly FieldCodec<SignState> _repeated_signStateList_codec = FieldCodec.ForEnum<SignState>(10U, (SignState x) => (int)x, (int x) => (SignState)x);

		// Token: 0x04009463 RID: 37987
		private readonly RepeatedField<SignState> signStateList_ = new RepeatedField<SignState>();

		// Token: 0x04009464 RID: 37988
		public const int RewardFreeFieldNumber = 2;

		// Token: 0x04009465 RID: 37989
		private bool rewardFree_;
	}
}
