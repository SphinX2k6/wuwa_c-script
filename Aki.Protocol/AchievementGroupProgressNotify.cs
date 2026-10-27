using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005F RID: 95
	[NetMessage(EMessageId.AchievementGroupProgressNotify)]
	public sealed class AchievementGroupProgressNotify : IMessage<AchievementGroupProgressNotify>, IMessage, IEquatable<AchievementGroupProgressNotify>, IDeepCloneable<AchievementGroupProgressNotify>, IBufferMessage
	{
		// Token: 0x06001605 RID: 5637 RVA: 0x0003A25D File Offset: 0x0003845D
		[NullableContext(1)]
		public static AchievementGroupProgressNotify Create()
		{
			return new AchievementGroupProgressNotify();
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0003A264 File Offset: 0x00038464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0003A267 File Offset: 0x00038467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementGroupProgressNotify.Descriptor;
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0003A26E File Offset: 0x0003846E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupProgressNotify()
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0003A276 File Offset: 0x00038476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupProgressNotify(AchievementGroupProgressNotify other) : this()
		{
			this.achievementGroupEntry_ = ((other.achievementGroupEntry_ != null) ? other.achievementGroupEntry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0003A2AB File Offset: 0x000384AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupProgressNotify Clone()
		{
			return new AchievementGroupProgressNotify(this);
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0003A2B3 File Offset: 0x000384B3
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x0003A2BB File Offset: 0x000384BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry AchievementGroupEntry
		{
			get
			{
				return this.achievementGroupEntry_;
			}
			set
			{
				this.achievementGroupEntry_ = value;
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0003A2C4 File Offset: 0x000384C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementGroupProgressNotify);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0003A2D2 File Offset: 0x000384D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementGroupProgressNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AchievementGroupEntry, other.AchievementGroupEntry) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0003A308 File Offset: 0x00038508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.achievementGroupEntry_ != null)
			{
				num ^= this.AchievementGroupEntry.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0003A344 File Offset: 0x00038544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0003A351 File Offset: 0x00038551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0003A35A File Offset: 0x0003855A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.achievementGroupEntry_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.AchievementGroupEntry);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0003A38C File Offset: 0x0003858C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.achievementGroupEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AchievementGroupEntry);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x0003A3CC File Offset: 0x000385CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementGroupProgressNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.achievementGroupEntry_ != null)
			{
				if (this.achievementGroupEntry_ == null)
				{
					this.AchievementGroupEntry = new AchievementGroupEntry();
				}
				this.AchievementGroupEntry.MergeFrom(other.AchievementGroupEntry);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0003A420 File Offset: 0x00038620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0003A42C File Offset: 0x0003862C
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
					if (this.achievementGroupEntry_ == null)
					{
						this.AchievementGroupEntry = new AchievementGroupEntry();
					}
					input.ReadMessage(this.AchievementGroupEntry);
				}
			}
		}

		// Token: 0x040020C9 RID: 8393
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020CA RID: 8394
		public const int AchievementGroupEntryFieldNumber = 5;

		// Token: 0x040020CB RID: 8395
		private AchievementGroupEntry achievementGroupEntry_;
	}
}
