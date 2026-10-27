using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128C RID: 4748
	[NetMessage(EMessageId.StartMatchRequest)]
	public sealed class StartMatchRequest : IMessage<StartMatchRequest>, IMessage, IEquatable<StartMatchRequest>, IDeepCloneable<StartMatchRequest>, IBufferMessage
	{
		// Token: 0x06019484 RID: 103556 RVA: 0x003AD3BD File Offset: 0x003AB5BD
		[NullableContext(1)]
		public static StartMatchRequest Create()
		{
			return new StartMatchRequest();
		}

		// Token: 0x17005548 RID: 21832
		// (get) Token: 0x06019485 RID: 103557 RVA: 0x003AD3C4 File Offset: 0x003AB5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005549 RID: 21833
		// (get) Token: 0x06019486 RID: 103558 RVA: 0x003AD3C7 File Offset: 0x003AB5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchRequest.Descriptor;
			}
		}

		// Token: 0x06019487 RID: 103559 RVA: 0x003AD3CE File Offset: 0x003AB5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchRequest()
		{
		}

		// Token: 0x06019488 RID: 103560 RVA: 0x003AD3D6 File Offset: 0x003AB5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchRequest(StartMatchRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.isInviteTeammate_ = other.isInviteTeammate_;
			this.instEnterId_ = other.instEnterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019489 RID: 103561 RVA: 0x003AD413 File Offset: 0x003AB613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchRequest Clone()
		{
			return new StartMatchRequest(this);
		}

		// Token: 0x1700554A RID: 21834
		// (get) Token: 0x0601948A RID: 103562 RVA: 0x003AD41B File Offset: 0x003AB61B
		// (set) Token: 0x0601948B RID: 103563 RVA: 0x003AD423 File Offset: 0x003AB623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700554B RID: 21835
		// (get) Token: 0x0601948C RID: 103564 RVA: 0x003AD42C File Offset: 0x003AB62C
		// (set) Token: 0x0601948D RID: 103565 RVA: 0x003AD434 File Offset: 0x003AB634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInviteTeammate
		{
			get
			{
				return this.isInviteTeammate_;
			}
			set
			{
				this.isInviteTeammate_ = value;
			}
		}

		// Token: 0x1700554C RID: 21836
		// (get) Token: 0x0601948E RID: 103566 RVA: 0x003AD43D File Offset: 0x003AB63D
		// (set) Token: 0x0601948F RID: 103567 RVA: 0x003AD445 File Offset: 0x003AB645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstEnterId
		{
			get
			{
				return this.instEnterId_;
			}
			set
			{
				this.instEnterId_ = value;
			}
		}

		// Token: 0x06019490 RID: 103568 RVA: 0x003AD44E File Offset: 0x003AB64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchRequest);
		}

		// Token: 0x06019491 RID: 103569 RVA: 0x003AD45C File Offset: 0x003AB65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsInviteTeammate == other.IsInviteTeammate && this.InstEnterId == other.InstEnterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019492 RID: 103570 RVA: 0x003AD4B8 File Offset: 0x003AB6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsInviteTeammate)
			{
				num ^= this.IsInviteTeammate.GetHashCode();
			}
			if (this.InstEnterId != 0)
			{
				num ^= this.InstEnterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019493 RID: 103571 RVA: 0x003AD529 File Offset: 0x003AB729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019494 RID: 103572 RVA: 0x003AD536 File Offset: 0x003AB736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019495 RID: 103573 RVA: 0x003AD540 File Offset: 0x003AB740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInviteTeammate)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsInviteTeammate);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this.InstEnterId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstEnterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019496 RID: 103574 RVA: 0x003AD5B8 File Offset: 0x003AB7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsInviteTeammate)
			{
				num += 2;
			}
			if (this.InstEnterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstEnterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019497 RID: 103575 RVA: 0x003AD61C File Offset: 0x003AB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsInviteTeammate)
			{
				this.IsInviteTeammate = other.IsInviteTeammate;
			}
			if (other.InstEnterId != 0)
			{
				this.InstEnterId = other.InstEnterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019498 RID: 103576 RVA: 0x003AD680 File Offset: 0x003AB880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019499 RID: 103577 RVA: 0x003AD68C File Offset: 0x003AB88C
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
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstEnterId = input.ReadInt32();
						}
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.IsInviteTeammate = input.ReadBool();
				}
			}
		}

		// Token: 0x040094A9 RID: 38057
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094AA RID: 38058
		public const int InstIdFieldNumber = 8;

		// Token: 0x040094AB RID: 38059
		private int instId_;

		// Token: 0x040094AC RID: 38060
		public const int IsInviteTeammateFieldNumber = 2;

		// Token: 0x040094AD RID: 38061
		private bool isInviteTeammate_;

		// Token: 0x040094AE RID: 38062
		public const int InstEnterIdFieldNumber = 11;

		// Token: 0x040094AF RID: 38063
		private int instEnterId_;
	}
}
