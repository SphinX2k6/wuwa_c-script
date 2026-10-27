using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC3 RID: 3267
	public sealed class PhantomCollectActivity : IMessage<PhantomCollectActivity>, IMessage, IEquatable<PhantomCollectActivity>, IDeepCloneable<PhantomCollectActivity>, IBufferMessage
	{
		// Token: 0x06011B0D RID: 72461 RVA: 0x00297065 File Offset: 0x00295265
		[NullableContext(1)]
		public static PhantomCollectActivity Create()
		{
			return new PhantomCollectActivity();
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x06011B0E RID: 72462 RVA: 0x0029706C File Offset: 0x0029526C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x06011B0F RID: 72463 RVA: 0x0029706F File Offset: 0x0029526F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectActivity.Descriptor;
			}
		}

		// Token: 0x06011B10 RID: 72464 RVA: 0x00297076 File Offset: 0x00295276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity()
		{
		}

		// Token: 0x06011B11 RID: 72465 RVA: 0x00297089 File Offset: 0x00295289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity(PhantomCollectActivity other) : this()
		{
			this.phantomCollectRewards_ = other.phantomCollectRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B12 RID: 72466 RVA: 0x002970B3 File Offset: 0x002952B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity Clone()
		{
			return new PhantomCollectActivity(this);
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x06011B13 RID: 72467 RVA: 0x002970BB File Offset: 0x002952BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomCollectReward> PhantomCollectRewards
		{
			get
			{
				return this.phantomCollectRewards_;
			}
		}

		// Token: 0x06011B14 RID: 72468 RVA: 0x002970C3 File Offset: 0x002952C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectActivity);
		}

		// Token: 0x06011B15 RID: 72469 RVA: 0x002970D1 File Offset: 0x002952D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectActivity other)
		{
			return other != null && (other == this || (this.phantomCollectRewards_.Equals(other.phantomCollectRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B16 RID: 72470 RVA: 0x00297104 File Offset: 0x00295304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomCollectRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B17 RID: 72471 RVA: 0x00297138 File Offset: 0x00295338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B18 RID: 72472 RVA: 0x00297145 File Offset: 0x00295345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B19 RID: 72473 RVA: 0x0029714E File Offset: 0x0029534E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomCollectRewards_.WriteTo(ref output, PhantomCollectActivity._repeated_phantomCollectRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B1A RID: 72474 RVA: 0x00297178 File Offset: 0x00295378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomCollectRewards_.CalculateSize(PhantomCollectActivity._repeated_phantomCollectRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B1B RID: 72475 RVA: 0x002971B1 File Offset: 0x002953B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomCollectRewards_.Add(other.phantomCollectRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B1C RID: 72476 RVA: 0x002971DF File Offset: 0x002953DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B1D RID: 72477 RVA: 0x002971E8 File Offset: 0x002953E8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomCollectRewards_.AddEntriesFrom(ref input, PhantomCollectActivity._repeated_phantomCollectRewards_codec);
				}
			}
		}

		// Token: 0x04006F4A RID: 28490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F4B RID: 28491
		public const int PhantomCollectRewardsFieldNumber = 1;

		// Token: 0x04006F4C RID: 28492
		private static readonly FieldCodec<PhantomCollectReward> _repeated_phantomCollectRewards_codec = FieldCodec.ForMessage<PhantomCollectReward>(10U, PhantomCollectReward.Parser);

		// Token: 0x04006F4D RID: 28493
		private readonly RepeatedField<PhantomCollectReward> phantomCollectRewards_ = new RepeatedField<PhantomCollectReward>();
	}
}
