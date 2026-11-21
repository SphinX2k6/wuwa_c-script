using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B6 RID: 5302
	[NetMessage(EMessageId.TrapDefenseRewardUpdateNotify)]
	public sealed class TrapDefenseRewardUpdateNotify : IMessage<TrapDefenseRewardUpdateNotify>, IMessage, IEquatable<TrapDefenseRewardUpdateNotify>, IDeepCloneable<TrapDefenseRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C221 RID: 115233 RVA: 0x004158CA File Offset: 0x00413ACA
		[NullableContext(1)]
		public static TrapDefenseRewardUpdateNotify Create()
		{
			return new TrapDefenseRewardUpdateNotify();
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x0601C222 RID: 115234 RVA: 0x004158D1 File Offset: 0x00413AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x0601C223 RID: 115235 RVA: 0x004158D4 File Offset: 0x00413AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C224 RID: 115236 RVA: 0x004158DB File Offset: 0x00413ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardUpdateNotify()
		{
		}

		// Token: 0x0601C225 RID: 115237 RVA: 0x004158EE File Offset: 0x00413AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardUpdateNotify(TrapDefenseRewardUpdateNotify other) : this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C226 RID: 115238 RVA: 0x00415918 File Offset: 0x00413B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardUpdateNotify Clone()
		{
			return new TrapDefenseRewardUpdateNotify(this);
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x0601C227 RID: 115239 RVA: 0x00415920 File Offset: 0x00413B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x0601C228 RID: 115240 RVA: 0x00415928 File Offset: 0x00413B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardUpdateNotify);
		}

		// Token: 0x0601C229 RID: 115241 RVA: 0x00415936 File Offset: 0x00413B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.rewards_.Equals(other.rewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C22A RID: 115242 RVA: 0x0041596C File Offset: 0x00413B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C22B RID: 115243 RVA: 0x004159A0 File Offset: 0x00413BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C22C RID: 115244 RVA: 0x004159AD File Offset: 0x00413BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C22D RID: 115245 RVA: 0x004159B6 File Offset: 0x00413BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, TrapDefenseRewardUpdateNotify._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C22E RID: 115246 RVA: 0x004159E0 File Offset: 0x00413BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewards_.CalculateSize(TrapDefenseRewardUpdateNotify._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C22F RID: 115247 RVA: 0x00415A19 File Offset: 0x00413C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewards_.Add(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C230 RID: 115248 RVA: 0x00415A47 File Offset: 0x00413C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C231 RID: 115249 RVA: 0x00415A50 File Offset: 0x00413C50
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, TrapDefenseRewardUpdateNotify._repeated_rewards_codec);
				}
			}
		}

		// Token: 0x0400A2CD RID: 41677
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2CE RID: 41678
		public const int RewardsFieldNumber = 5;

		// Token: 0x0400A2CF RID: 41679
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_rewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(42U, TrapDefenseRewardInfo.Parser);

		// Token: 0x0400A2D0 RID: 41680
		private readonly RepeatedField<TrapDefenseRewardInfo> rewards_ = new RepeatedField<TrapDefenseRewardInfo>();
	}
}
