using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000770 RID: 1904
	[NetMessage(EMessageId.HonamiStoryLifeSupportNotify)]
	public sealed class HonamiStoryLifeSupportNotify : IMessage<HonamiStoryLifeSupportNotify>, IMessage, IEquatable<HonamiStoryLifeSupportNotify>, IDeepCloneable<HonamiStoryLifeSupportNotify>, IBufferMessage
	{
		// Token: 0x0600AC81 RID: 44161 RVA: 0x0019F427 File Offset: 0x0019D627
		[NullableContext(1)]
		public static HonamiStoryLifeSupportNotify Create()
		{
			return new HonamiStoryLifeSupportNotify();
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600AC82 RID: 44162 RVA: 0x0019F42E File Offset: 0x0019D62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x0019F431 File Offset: 0x0019D631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLifeSupportNotify.Descriptor;
			}
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x0019F438 File Offset: 0x0019D638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportNotify()
		{
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x0019F440 File Offset: 0x0019D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportNotify(HonamiStoryLifeSupportNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.lifeSupportLevel_ = other.lifeSupportLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x0019F471 File Offset: 0x0019D671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportNotify Clone()
		{
			return new HonamiStoryLifeSupportNotify(this);
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x0019F479 File Offset: 0x0019D679
		// (set) Token: 0x0600AC88 RID: 44168 RVA: 0x0019F481 File Offset: 0x0019D681
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

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600AC89 RID: 44169 RVA: 0x0019F48A File Offset: 0x0019D68A
		// (set) Token: 0x0600AC8A RID: 44170 RVA: 0x0019F492 File Offset: 0x0019D692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeSupportLevel
		{
			get
			{
				return this.lifeSupportLevel_;
			}
			set
			{
				this.lifeSupportLevel_ = value;
			}
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x0019F49B File Offset: 0x0019D69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLifeSupportNotify);
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x0019F4A9 File Offset: 0x0019D6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLifeSupportNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LifeSupportLevel == other.LifeSupportLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x0019F4E8 File Offset: 0x0019D6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LifeSupportLevel != 0)
			{
				num ^= this.LifeSupportLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC8E RID: 44174 RVA: 0x0019F540 File Offset: 0x0019D740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x0019F54D File Offset: 0x0019D74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x0019F558 File Offset: 0x0019D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LifeSupportLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LifeSupportLevel);
			}
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

		// Token: 0x0600AC91 RID: 44177 RVA: 0x0019F5B4 File Offset: 0x0019D7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LifeSupportLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeSupportLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x0019F60C File Offset: 0x0019D80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLifeSupportNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LifeSupportLevel != 0)
			{
				this.LifeSupportLevel = other.LifeSupportLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x0019F65C File Offset: 0x0019D85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x0019F668 File Offset: 0x0019D868
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
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.LifeSupportLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E8D RID: 20109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E8E RID: 20110
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004E8F RID: 20111
		private int activityId_;

		// Token: 0x04004E90 RID: 20112
		public const int LifeSupportLevelFieldNumber = 3;

		// Token: 0x04004E91 RID: 20113
		private int lifeSupportLevel_;
	}
}
