using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C4 RID: 5316
	[NetMessage(EMessageId.TrapDefenseSpecialRewardUpdateNotify)]
	public sealed class TrapDefenseSpecialRewardUpdateNotify : IMessage<TrapDefenseSpecialRewardUpdateNotify>, IMessage, IEquatable<TrapDefenseSpecialRewardUpdateNotify>, IDeepCloneable<TrapDefenseSpecialRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C339 RID: 115513 RVA: 0x00417C48 File Offset: 0x00415E48
		[NullableContext(1)]
		public static TrapDefenseSpecialRewardUpdateNotify Create()
		{
			return new TrapDefenseSpecialRewardUpdateNotify();
		}

		// Token: 0x17005F72 RID: 24434
		// (get) Token: 0x0601C33A RID: 115514 RVA: 0x00417C4F File Offset: 0x00415E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F73 RID: 24435
		// (get) Token: 0x0601C33B RID: 115515 RVA: 0x00417C52 File Offset: 0x00415E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpecialRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C33C RID: 115516 RVA: 0x00417C59 File Offset: 0x00415E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialRewardUpdateNotify()
		{
		}

		// Token: 0x0601C33D RID: 115517 RVA: 0x00417C6C File Offset: 0x00415E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialRewardUpdateNotify(TrapDefenseSpecialRewardUpdateNotify other) : this()
		{
			this.specialRewards_ = other.specialRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C33E RID: 115518 RVA: 0x00417C96 File Offset: 0x00415E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialRewardUpdateNotify Clone()
		{
			return new TrapDefenseSpecialRewardUpdateNotify(this);
		}

		// Token: 0x17005F74 RID: 24436
		// (get) Token: 0x0601C33F RID: 115519 RVA: 0x00417C9E File Offset: 0x00415E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> SpecialRewards
		{
			get
			{
				return this.specialRewards_;
			}
		}

		// Token: 0x0601C340 RID: 115520 RVA: 0x00417CA6 File Offset: 0x00415EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpecialRewardUpdateNotify);
		}

		// Token: 0x0601C341 RID: 115521 RVA: 0x00417CB4 File Offset: 0x00415EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpecialRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.specialRewards_.Equals(other.specialRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C342 RID: 115522 RVA: 0x00417CE8 File Offset: 0x00415EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.specialRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C343 RID: 115523 RVA: 0x00417D1C File Offset: 0x00415F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C344 RID: 115524 RVA: 0x00417D29 File Offset: 0x00415F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C345 RID: 115525 RVA: 0x00417D32 File Offset: 0x00415F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.specialRewards_.WriteTo(ref output, TrapDefenseSpecialRewardUpdateNotify._repeated_specialRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C346 RID: 115526 RVA: 0x00417D5C File Offset: 0x00415F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.specialRewards_.CalculateSize(TrapDefenseSpecialRewardUpdateNotify._repeated_specialRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C347 RID: 115527 RVA: 0x00417D95 File Offset: 0x00415F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSpecialRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.specialRewards_.Add(other.specialRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C348 RID: 115528 RVA: 0x00417DC3 File Offset: 0x00415FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C349 RID: 115529 RVA: 0x00417DCC File Offset: 0x00415FCC
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.specialRewards_.AddEntriesFrom(ref input, TrapDefenseSpecialRewardUpdateNotify._repeated_specialRewards_codec);
				}
			}
		}

		// Token: 0x0400A310 RID: 41744
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A311 RID: 41745
		public const int SpecialRewardsFieldNumber = 7;

		// Token: 0x0400A312 RID: 41746
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_specialRewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(58U, TrapDefenseRewardInfo.Parser);

		// Token: 0x0400A313 RID: 41747
		private readonly RepeatedField<TrapDefenseRewardInfo> specialRewards_ = new RepeatedField<TrapDefenseRewardInfo>();
	}
}
