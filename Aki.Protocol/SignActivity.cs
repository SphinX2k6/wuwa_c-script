using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001214 RID: 4628
	public sealed class SignActivity : IMessage<SignActivity>, IMessage, IEquatable<SignActivity>, IDeepCloneable<SignActivity>, IBufferMessage
	{
		// Token: 0x06018AA5 RID: 101029 RVA: 0x00396597 File Offset: 0x00394797
		[NullableContext(1)]
		public static SignActivity Create()
		{
			return new SignActivity();
		}

		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x06018AA6 RID: 101030 RVA: 0x0039659E File Offset: 0x0039479E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x06018AA7 RID: 101031 RVA: 0x003965A1 File Offset: 0x003947A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivity.Descriptor;
			}
		}

		// Token: 0x06018AA8 RID: 101032 RVA: 0x003965A8 File Offset: 0x003947A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity()
		{
		}

		// Token: 0x06018AA9 RID: 101033 RVA: 0x003965BB File Offset: 0x003947BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity(SignActivity other) : this()
		{
			this.signStateList_ = other.signStateList_.Clone();
			this.rewardFree_ = other.rewardFree_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AAA RID: 101034 RVA: 0x003965F1 File Offset: 0x003947F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity Clone()
		{
			return new SignActivity(this);
		}

		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x06018AAB RID: 101035 RVA: 0x003965F9 File Offset: 0x003947F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SignState> SignStateList
		{
			get
			{
				return this.signStateList_;
			}
		}

		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x06018AAC RID: 101036 RVA: 0x00396601 File Offset: 0x00394801
		// (set) Token: 0x06018AAD RID: 101037 RVA: 0x00396609 File Offset: 0x00394809
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

		// Token: 0x06018AAE RID: 101038 RVA: 0x00396612 File Offset: 0x00394812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivity);
		}

		// Token: 0x06018AAF RID: 101039 RVA: 0x00396620 File Offset: 0x00394820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivity other)
		{
			return other != null && (other == this || (this.signStateList_.Equals(other.signStateList_) && this.RewardFree == other.RewardFree && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AB0 RID: 101040 RVA: 0x00396670 File Offset: 0x00394870
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

		// Token: 0x06018AB1 RID: 101041 RVA: 0x003966BD File Offset: 0x003948BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AB2 RID: 101042 RVA: 0x003966CA File Offset: 0x003948CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AB3 RID: 101043 RVA: 0x003966D4 File Offset: 0x003948D4
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

		// Token: 0x06018AB4 RID: 101044 RVA: 0x00396724 File Offset: 0x00394924
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

		// Token: 0x06018AB5 RID: 101045 RVA: 0x0039676C File Offset: 0x0039496C
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

		// Token: 0x06018AB6 RID: 101046 RVA: 0x003967B9 File Offset: 0x003949B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AB7 RID: 101047 RVA: 0x003967C4 File Offset: 0x003949C4
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

		// Token: 0x040091AF RID: 37295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091B0 RID: 37296
		public const int SignStateListFieldNumber = 1;

		// Token: 0x040091B1 RID: 37297
		private static readonly FieldCodec<SignState> _repeated_signStateList_codec = FieldCodec.ForEnum<SignState>(10U, (SignState x) => (int)x, (int x) => (SignState)x);

		// Token: 0x040091B2 RID: 37298
		private readonly RepeatedField<SignState> signStateList_ = new RepeatedField<SignState>();

		// Token: 0x040091B3 RID: 37299
		public const int RewardFreeFieldNumber = 2;

		// Token: 0x040091B4 RID: 37300
		private bool rewardFree_;
	}
}
