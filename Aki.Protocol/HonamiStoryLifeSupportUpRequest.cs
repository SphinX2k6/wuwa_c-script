using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000771 RID: 1905
	[NetMessage(EMessageId.HonamiStoryLifeSupportUpRequest)]
	public sealed class HonamiStoryLifeSupportUpRequest : IMessage<HonamiStoryLifeSupportUpRequest>, IMessage, IEquatable<HonamiStoryLifeSupportUpRequest>, IDeepCloneable<HonamiStoryLifeSupportUpRequest>, IBufferMessage
	{
		// Token: 0x0600AC95 RID: 44181 RVA: 0x0019F6C0 File Offset: 0x0019D8C0
		[NullableContext(1)]
		public static HonamiStoryLifeSupportUpRequest Create()
		{
			return new HonamiStoryLifeSupportUpRequest();
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600AC96 RID: 44182 RVA: 0x0019F6C7 File Offset: 0x0019D8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x0019F6CA File Offset: 0x0019D8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLifeSupportUpRequest.Descriptor;
			}
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x0019F6D1 File Offset: 0x0019D8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpRequest()
		{
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x0019F6D9 File Offset: 0x0019D8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpRequest(HonamiStoryLifeSupportUpRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x0019F6FE File Offset: 0x0019D8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpRequest Clone()
		{
			return new HonamiStoryLifeSupportUpRequest(this);
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600AC9B RID: 44187 RVA: 0x0019F706 File Offset: 0x0019D906
		// (set) Token: 0x0600AC9C RID: 44188 RVA: 0x0019F70E File Offset: 0x0019D90E
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

		// Token: 0x0600AC9D RID: 44189 RVA: 0x0019F717 File Offset: 0x0019D917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLifeSupportUpRequest);
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x0019F725 File Offset: 0x0019D925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLifeSupportUpRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x0019F754 File Offset: 0x0019D954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x0019F793 File Offset: 0x0019D993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACA1 RID: 44193 RVA: 0x0019F7A0 File Offset: 0x0019D9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x0019F7A9 File Offset: 0x0019D9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x0019F7DC File Offset: 0x0019D9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x0019F81A File Offset: 0x0019DA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLifeSupportUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x0019F84B File Offset: 0x0019DA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x0019F854 File Offset: 0x0019DA54
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E92 RID: 20114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E93 RID: 20115
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04004E94 RID: 20116
		private int activityId_;
	}
}
