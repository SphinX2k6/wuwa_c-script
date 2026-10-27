using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001025 RID: 4133
	[NetMessage(EMessageId.RogueTowerTrialStartRequest)]
	public sealed class RogueTowerTrialStartRequest : IMessage<RogueTowerTrialStartRequest>, IMessage, IEquatable<RogueTowerTrialStartRequest>, IDeepCloneable<RogueTowerTrialStartRequest>, IBufferMessage
	{
		// Token: 0x06016176 RID: 90486 RVA: 0x00335C7D File Offset: 0x00333E7D
		[NullableContext(1)]
		public static RogueTowerTrialStartRequest Create()
		{
			return new RogueTowerTrialStartRequest();
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x06016177 RID: 90487 RVA: 0x00335C84 File Offset: 0x00333E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x06016178 RID: 90488 RVA: 0x00335C87 File Offset: 0x00333E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialStartRequest.Descriptor;
			}
		}

		// Token: 0x06016179 RID: 90489 RVA: 0x00335C8E File Offset: 0x00333E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartRequest()
		{
		}

		// Token: 0x0601617A RID: 90490 RVA: 0x00335C96 File Offset: 0x00333E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartRequest(RogueTowerTrialStartRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.slotId_ = other.slotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601617B RID: 90491 RVA: 0x00335CC7 File Offset: 0x00333EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartRequest Clone()
		{
			return new RogueTowerTrialStartRequest(this);
		}

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x0601617C RID: 90492 RVA: 0x00335CCF File Offset: 0x00333ECF
		// (set) Token: 0x0601617D RID: 90493 RVA: 0x00335CD7 File Offset: 0x00333ED7
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

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x0601617E RID: 90494 RVA: 0x00335CE0 File Offset: 0x00333EE0
		// (set) Token: 0x0601617F RID: 90495 RVA: 0x00335CE8 File Offset: 0x00333EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x06016180 RID: 90496 RVA: 0x00335CF1 File Offset: 0x00333EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialStartRequest);
		}

		// Token: 0x06016181 RID: 90497 RVA: 0x00335CFF File Offset: 0x00333EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialStartRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SlotId == other.SlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016182 RID: 90498 RVA: 0x00335D40 File Offset: 0x00333F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016183 RID: 90499 RVA: 0x00335D98 File Offset: 0x00333F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016184 RID: 90500 RVA: 0x00335DA5 File Offset: 0x00333FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016185 RID: 90501 RVA: 0x00335DB0 File Offset: 0x00333FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SlotId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016186 RID: 90502 RVA: 0x00335E0C File Offset: 0x0033400C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016187 RID: 90503 RVA: 0x00335E64 File Offset: 0x00334064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016188 RID: 90504 RVA: 0x00335EB4 File Offset: 0x003340B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016189 RID: 90505 RVA: 0x00335EC0 File Offset: 0x003340C0
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
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400845A RID: 33882
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400845B RID: 33883
		public const int InstIdFieldNumber = 11;

		// Token: 0x0400845C RID: 33884
		private int instId_;

		// Token: 0x0400845D RID: 33885
		public const int SlotIdFieldNumber = 3;

		// Token: 0x0400845E RID: 33886
		private int slotId_;
	}
}
