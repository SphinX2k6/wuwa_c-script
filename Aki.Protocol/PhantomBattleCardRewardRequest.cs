using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C59 RID: 3161
	[NetMessage(EMessageId.PhantomBattleCardRewardRequest)]
	public sealed class PhantomBattleCardRewardRequest : IMessage<PhantomBattleCardRewardRequest>, IMessage, IEquatable<PhantomBattleCardRewardRequest>, IDeepCloneable<PhantomBattleCardRewardRequest>, IBufferMessage
	{
		// Token: 0x06011236 RID: 70198 RVA: 0x002825B5 File Offset: 0x002807B5
		[NullableContext(1)]
		public static PhantomBattleCardRewardRequest Create()
		{
			return new PhantomBattleCardRewardRequest();
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x06011237 RID: 70199 RVA: 0x002825BC File Offset: 0x002807BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x06011238 RID: 70200 RVA: 0x002825BF File Offset: 0x002807BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardRequest.Descriptor;
			}
		}

		// Token: 0x06011239 RID: 70201 RVA: 0x002825C6 File Offset: 0x002807C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardRequest()
		{
		}

		// Token: 0x0601123A RID: 70202 RVA: 0x002825D9 File Offset: 0x002807D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardRequest(PhantomBattleCardRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.cardRewardId_ = other.cardRewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601123B RID: 70203 RVA: 0x0028260F File Offset: 0x0028080F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardRequest Clone()
		{
			return new PhantomBattleCardRewardRequest(this);
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0601123C RID: 70204 RVA: 0x00282617 File Offset: 0x00280817
		// (set) Token: 0x0601123D RID: 70205 RVA: 0x0028261F File Offset: 0x0028081F
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

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0601123E RID: 70206 RVA: 0x00282628 File Offset: 0x00280828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardRewardId
		{
			get
			{
				return this.cardRewardId_;
			}
		}

		// Token: 0x0601123F RID: 70207 RVA: 0x00282630 File Offset: 0x00280830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardRequest);
		}

		// Token: 0x06011240 RID: 70208 RVA: 0x00282640 File Offset: 0x00280840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.cardRewardId_.Equals(other.cardRewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011241 RID: 70209 RVA: 0x00282690 File Offset: 0x00280890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.cardRewardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011242 RID: 70210 RVA: 0x002826DD File Offset: 0x002808DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011243 RID: 70211 RVA: 0x002826EA File Offset: 0x002808EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011244 RID: 70212 RVA: 0x002826F4 File Offset: 0x002808F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardRewardId_.WriteTo(ref output, PhantomBattleCardRewardRequest._repeated_cardRewardId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011245 RID: 70213 RVA: 0x00282744 File Offset: 0x00280944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.cardRewardId_.CalculateSize(PhantomBattleCardRewardRequest._repeated_cardRewardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011246 RID: 70214 RVA: 0x00282798 File Offset: 0x00280998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.cardRewardId_.Add(other.cardRewardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011247 RID: 70215 RVA: 0x002827E5 File Offset: 0x002809E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011248 RID: 70216 RVA: 0x002827F0 File Offset: 0x002809F0
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
				if (num != 64U && num != 66U)
				{
					if (num != 88U)
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
					this.cardRewardId_.AddEntriesFrom(ref input, PhantomBattleCardRewardRequest._repeated_cardRewardId_codec);
				}
			}
		}

		// Token: 0x04006C7D RID: 27773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C7E RID: 27774
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04006C7F RID: 27775
		private int activityId_;

		// Token: 0x04006C80 RID: 27776
		public const int CardRewardIdFieldNumber = 8;

		// Token: 0x04006C81 RID: 27777
		private static readonly FieldCodec<int> _repeated_cardRewardId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006C82 RID: 27778
		private readonly RepeatedField<int> cardRewardId_ = new RepeatedField<int>();
	}
}
