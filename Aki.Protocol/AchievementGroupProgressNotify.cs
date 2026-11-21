using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000060 RID: 96
	[NetMessage(EMessageId.AchievementGroupProgressNotify)]
	public sealed class AchievementGroupProgressNotify : IMessage<AchievementGroupProgressNotify>, IMessage, IEquatable<AchievementGroupProgressNotify>, IDeepCloneable<AchievementGroupProgressNotify>, IBufferMessage
	{
		// Token: 0x06001648 RID: 5704 RVA: 0x0003AC01 File Offset: 0x00038E01
		[NullableContext(1)]
		public static AchievementGroupProgressNotify Create()
		{
			return new AchievementGroupProgressNotify();
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x0003AC08 File Offset: 0x00038E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x0003AC0B File Offset: 0x00038E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementGroupProgressNotify.Descriptor;
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0003AC12 File Offset: 0x00038E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupProgressNotify()
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0003AC1A File Offset: 0x00038E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupProgressNotify(AchievementGroupProgressNotify other) : this()
		{
			this.achievementGroupEntry_ = ((other.achievementGroupEntry_ != null) ? other.achievementGroupEntry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0003AC4F File Offset: 0x00038E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupProgressNotify Clone()
		{
			return new AchievementGroupProgressNotify(this);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x0003AC57 File Offset: 0x00038E57
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x0003AC5F File Offset: 0x00038E5F
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

		// Token: 0x06001650 RID: 5712 RVA: 0x0003AC68 File Offset: 0x00038E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementGroupProgressNotify);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0003AC76 File Offset: 0x00038E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementGroupProgressNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AchievementGroupEntry, other.AchievementGroupEntry) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0003ACAC File Offset: 0x00038EAC
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

		// Token: 0x06001653 RID: 5715 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0003ACF5 File Offset: 0x00038EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0003ACFE File Offset: 0x00038EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.achievementGroupEntry_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AchievementGroupEntry);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0003AD30 File Offset: 0x00038F30
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

		// Token: 0x06001657 RID: 5719 RVA: 0x0003AD70 File Offset: 0x00038F70
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

		// Token: 0x06001658 RID: 5720 RVA: 0x0003ADC4 File Offset: 0x00038FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0003ADD0 File Offset: 0x00038FD0
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
				if (num != 34U)
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

		// Token: 0x04002128 RID: 8488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002129 RID: 8489
		public const int AchievementGroupEntryFieldNumber = 4;

		// Token: 0x0400212A RID: 8490
		private AchievementGroupEntry achievementGroupEntry_;
	}
}
