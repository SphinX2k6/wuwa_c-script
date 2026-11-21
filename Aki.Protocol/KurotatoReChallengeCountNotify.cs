using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089B RID: 2203
	[NetMessage(EMessageId.KurotatoReChallengeCountNotify)]
	public sealed class KurotatoReChallengeCountNotify : IMessage<KurotatoReChallengeCountNotify>, IMessage, IEquatable<KurotatoReChallengeCountNotify>, IDeepCloneable<KurotatoReChallengeCountNotify>, IBufferMessage
	{
		// Token: 0x0600C401 RID: 50177 RVA: 0x001D0E76 File Offset: 0x001CF076
		[NullableContext(1)]
		public static KurotatoReChallengeCountNotify Create()
		{
			return new KurotatoReChallengeCountNotify();
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x0600C402 RID: 50178 RVA: 0x001D0E7D File Offset: 0x001CF07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x0600C403 RID: 50179 RVA: 0x001D0E80 File Offset: 0x001CF080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoReChallengeCountNotify.Descriptor;
			}
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x001D0E87 File Offset: 0x001CF087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeCountNotify()
		{
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x001D0E8F File Offset: 0x001CF08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeCountNotify(KurotatoReChallengeCountNotify other) : this()
		{
			this.maxReChallengeCount_ = other.maxReChallengeCount_;
			this.usedReChallengeCount_ = other.usedReChallengeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C406 RID: 50182 RVA: 0x001D0EC0 File Offset: 0x001CF0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeCountNotify Clone()
		{
			return new KurotatoReChallengeCountNotify(this);
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x0600C407 RID: 50183 RVA: 0x001D0EC8 File Offset: 0x001CF0C8
		// (set) Token: 0x0600C408 RID: 50184 RVA: 0x001D0ED0 File Offset: 0x001CF0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReChallengeCount
		{
			get
			{
				return this.maxReChallengeCount_;
			}
			set
			{
				this.maxReChallengeCount_ = value;
			}
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x0600C409 RID: 50185 RVA: 0x001D0ED9 File Offset: 0x001CF0D9
		// (set) Token: 0x0600C40A RID: 50186 RVA: 0x001D0EE1 File Offset: 0x001CF0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UsedReChallengeCount
		{
			get
			{
				return this.usedReChallengeCount_;
			}
			set
			{
				this.usedReChallengeCount_ = value;
			}
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x001D0EEA File Offset: 0x001CF0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoReChallengeCountNotify);
		}

		// Token: 0x0600C40C RID: 50188 RVA: 0x001D0EF8 File Offset: 0x001CF0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoReChallengeCountNotify other)
		{
			return other != null && (other == this || (this.MaxReChallengeCount == other.MaxReChallengeCount && this.UsedReChallengeCount == other.UsedReChallengeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x001D0F38 File Offset: 0x001CF138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxReChallengeCount != 0)
			{
				num ^= this.MaxReChallengeCount.GetHashCode();
			}
			if (this.UsedReChallengeCount != 0)
			{
				num ^= this.UsedReChallengeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C40E RID: 50190 RVA: 0x001D0F90 File Offset: 0x001CF190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x001D0F9D File Offset: 0x001CF19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x001D0FA8 File Offset: 0x001CF1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UsedReChallengeCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UsedReChallengeCount);
			}
			if (this.MaxReChallengeCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxReChallengeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x001D1004 File Offset: 0x001CF204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxReChallengeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReChallengeCount);
			}
			if (this.UsedReChallengeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UsedReChallengeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x001D105C File Offset: 0x001CF25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoReChallengeCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxReChallengeCount != 0)
			{
				this.MaxReChallengeCount = other.MaxReChallengeCount;
			}
			if (other.UsedReChallengeCount != 0)
			{
				this.UsedReChallengeCount = other.UsedReChallengeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x001D10AC File Offset: 0x001CF2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x001D10B8 File Offset: 0x001CF2B8
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxReChallengeCount = input.ReadInt32();
					}
				}
				else
				{
					this.UsedReChallengeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054EB RID: 21739
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054EC RID: 21740
		public const int MaxReChallengeCountFieldNumber = 11;

		// Token: 0x040054ED RID: 21741
		private int maxReChallengeCount_;

		// Token: 0x040054EE RID: 21742
		public const int UsedReChallengeCountFieldNumber = 3;

		// Token: 0x040054EF RID: 21743
		private int usedReChallengeCount_;
	}
}
