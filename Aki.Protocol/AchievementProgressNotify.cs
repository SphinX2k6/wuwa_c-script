using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000065 RID: 101
	[NetMessage(EMessageId.AchievementProgressNotify)]
	public sealed class AchievementProgressNotify : IMessage<AchievementProgressNotify>, IMessage, IEquatable<AchievementProgressNotify>, IDeepCloneable<AchievementProgressNotify>, IBufferMessage
	{
		// Token: 0x060016A6 RID: 5798 RVA: 0x0003B733 File Offset: 0x00039933
		[NullableContext(1)]
		public static AchievementProgressNotify Create()
		{
			return new AchievementProgressNotify();
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0003B73A File Offset: 0x0003993A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0003B73D File Offset: 0x0003993D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementProgressNotify.Descriptor;
			}
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0003B744 File Offset: 0x00039944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgressNotify()
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0003B74C File Offset: 0x0003994C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgressNotify(AchievementProgressNotify other) : this()
		{
			this.achievementEntry_ = ((other.achievementEntry_ != null) ? other.achievementEntry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0003B781 File Offset: 0x00039981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgressNotify Clone()
		{
			return new AchievementProgressNotify(this);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x0003B789 File Offset: 0x00039989
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x0003B791 File Offset: 0x00039991
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

		// Token: 0x060016AE RID: 5806 RVA: 0x0003B79A File Offset: 0x0003999A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementProgressNotify);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0003B7A8 File Offset: 0x000399A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementProgressNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AchievementEntry, other.AchievementEntry) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0003B7DC File Offset: 0x000399DC
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

		// Token: 0x060016B1 RID: 5809 RVA: 0x0003B818 File Offset: 0x00039A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0003B825 File Offset: 0x00039A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0003B82E File Offset: 0x00039A2E
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

		// Token: 0x060016B4 RID: 5812 RVA: 0x0003B860 File Offset: 0x00039A60
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

		// Token: 0x060016B5 RID: 5813 RVA: 0x0003B8A0 File Offset: 0x00039AA0
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

		// Token: 0x060016B6 RID: 5814 RVA: 0x0003B8F4 File Offset: 0x00039AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0003B900 File Offset: 0x00039B00
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

		// Token: 0x0400213D RID: 8509
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400213E RID: 8510
		public const int AchievementEntryFieldNumber = 1;

		// Token: 0x0400213F RID: 8511
		private AchievementEntry achievementEntry_;
	}
}
