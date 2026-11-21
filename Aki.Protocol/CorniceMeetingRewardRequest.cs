using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030E RID: 782
	[NetMessage(EMessageId.CorniceMeetingRewardRequest)]
	public sealed class CorniceMeetingRewardRequest : IMessage<CorniceMeetingRewardRequest>, IMessage, IEquatable<CorniceMeetingRewardRequest>, IDeepCloneable<CorniceMeetingRewardRequest>, IBufferMessage
	{
		// Token: 0x06004F0B RID: 20235 RVA: 0x000C0361 File Offset: 0x000BE561
		[NullableContext(1)]
		public static CorniceMeetingRewardRequest Create()
		{
			return new CorniceMeetingRewardRequest();
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x000C0368 File Offset: 0x000BE568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x000C036B File Offset: 0x000BE56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x000C0372 File Offset: 0x000BE572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardRequest()
		{
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x000C037A File Offset: 0x000BE57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardRequest(CorniceMeetingRewardRequest other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.scoreIndex_ = other.scoreIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x000C03AB File Offset: 0x000BE5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardRequest Clone()
		{
			return new CorniceMeetingRewardRequest(this);
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x000C03B3 File Offset: 0x000BE5B3
		// (set) Token: 0x06004F12 RID: 20242 RVA: 0x000C03BB File Offset: 0x000BE5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x000C03C4 File Offset: 0x000BE5C4
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x000C03CC File Offset: 0x000BE5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreIndex
		{
			get
			{
				return this.scoreIndex_;
			}
			set
			{
				this.scoreIndex_ = value;
			}
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x000C03D5 File Offset: 0x000BE5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingRewardRequest);
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x000C03E3 File Offset: 0x000BE5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingRewardRequest other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.ScoreIndex == other.ScoreIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x000C0424 File Offset: 0x000BE624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.ScoreIndex != 0)
			{
				num ^= this.ScoreIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x000C047C File Offset: 0x000BE67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x000C0489 File Offset: 0x000BE689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x000C0494 File Offset: 0x000BE694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ScoreIndex);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x000C04F0 File Offset: 0x000BE6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.ScoreIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x000C0548 File Offset: 0x000BE748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceMeetingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.ScoreIndex != 0)
			{
				this.ScoreIndex = other.ScoreIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x000C0598 File Offset: 0x000BE798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x000C05A4 File Offset: 0x000BE7A4
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelPlayId = input.ReadInt32();
					}
				}
				else
				{
					this.ScoreIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400321D RID: 12829
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400321E RID: 12830
		public const int LevelPlayIdFieldNumber = 9;

		// Token: 0x0400321F RID: 12831
		private int levelPlayId_;

		// Token: 0x04003220 RID: 12832
		public const int ScoreIndexFieldNumber = 2;

		// Token: 0x04003221 RID: 12833
		private int scoreIndex_;
	}
}
