using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000064 RID: 100
	[NetMessage(EMessageId.AchievementProgressNotify)]
	public sealed class AchievementProgressNotify : IMessage<AchievementProgressNotify>, IMessage, IEquatable<AchievementProgressNotify>, IDeepCloneable<AchievementProgressNotify>, IBufferMessage
	{
		// Token: 0x06001663 RID: 5731 RVA: 0x0003AD8F File Offset: 0x00038F8F
		[NullableContext(1)]
		public static AchievementProgressNotify Create()
		{
			return new AchievementProgressNotify();
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x0003AD96 File Offset: 0x00038F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x0003AD99 File Offset: 0x00038F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementProgressNotify.Descriptor;
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgressNotify()
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0003ADA8 File Offset: 0x00038FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgressNotify(AchievementProgressNotify other) : this()
		{
			this.achievementEntry_ = ((other.achievementEntry_ != null) ? other.achievementEntry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0003ADDD File Offset: 0x00038FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgressNotify Clone()
		{
			return new AchievementProgressNotify(this);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x0003ADE5 File Offset: 0x00038FE5
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x0003ADED File Offset: 0x00038FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry AchievementEntry
		{
			get
			{
				return this.achievementEntry_;
			}
			set
			{
				this.achievementEntry_ = value;
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0003ADF6 File Offset: 0x00038FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementProgressNotify);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0003AE04 File Offset: 0x00039004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementProgressNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AchievementEntry, other.AchievementEntry) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0003AE38 File Offset: 0x00039038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.achievementEntry_ != null)
			{
				num ^= this.AchievementEntry.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0003AE74 File Offset: 0x00039074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0003AE81 File Offset: 0x00039081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0003AE8A File Offset: 0x0003908A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.achievementEntry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AchievementEntry);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0003AEBC File Offset: 0x000390BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.achievementEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AchievementEntry);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0003AEFC File Offset: 0x000390FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementProgressNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.achievementEntry_ != null)
			{
				if (this.achievementEntry_ == null)
				{
					this.AchievementEntry = new AchievementEntry();
				}
				this.AchievementEntry.MergeFrom(other.AchievementEntry);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0003AF50 File Offset: 0x00039150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0003AF5C File Offset: 0x0003915C
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
					if (this.achievementEntry_ == null)
					{
						this.AchievementEntry = new AchievementEntry();
					}
					input.ReadMessage(this.AchievementEntry);
				}
			}
		}

		// Token: 0x040020DE RID: 8414
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020DF RID: 8415
		public const int AchievementEntryFieldNumber = 1;

		// Token: 0x040020E0 RID: 8416
		private AchievementEntry achievementEntry_;
	}
}
