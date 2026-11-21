using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103E RID: 4158
	[NetMessage(EMessageId.RogueWhiteCatDataUpdateNotify)]
	public sealed class RogueWhiteCatDataUpdateNotify : IMessage<RogueWhiteCatDataUpdateNotify>, IMessage, IEquatable<RogueWhiteCatDataUpdateNotify>, IDeepCloneable<RogueWhiteCatDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016401 RID: 91137 RVA: 0x0033C7C8 File Offset: 0x0033A9C8
		[NullableContext(1)]
		public static RogueWhiteCatDataUpdateNotify Create()
		{
			return new RogueWhiteCatDataUpdateNotify();
		}

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x06016402 RID: 91138 RVA: 0x0033C7CF File Offset: 0x0033A9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x06016403 RID: 91139 RVA: 0x0033C7D2 File Offset: 0x0033A9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016404 RID: 91140 RVA: 0x0033C7D9 File Offset: 0x0033A9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatDataUpdateNotify()
		{
		}

		// Token: 0x06016405 RID: 91141 RVA: 0x0033C7E4 File Offset: 0x0033A9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatDataUpdateNotify(RogueWhiteCatDataUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rogueWhiteCatData_ = ((other.rogueWhiteCatData_ != null) ? other.rogueWhiteCatData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016406 RID: 91142 RVA: 0x0033C830 File Offset: 0x0033AA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatDataUpdateNotify Clone()
		{
			return new RogueWhiteCatDataUpdateNotify(this);
		}

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x06016407 RID: 91143 RVA: 0x0033C838 File Offset: 0x0033AA38
		// (set) Token: 0x06016408 RID: 91144 RVA: 0x0033C840 File Offset: 0x0033AA40
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

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x06016409 RID: 91145 RVA: 0x0033C849 File Offset: 0x0033AA49
		// (set) Token: 0x0601640A RID: 91146 RVA: 0x0033C851 File Offset: 0x0033AA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData RogueWhiteCatData
		{
			get
			{
				return this.rogueWhiteCatData_;
			}
			set
			{
				this.rogueWhiteCatData_ = value;
			}
		}

		// Token: 0x0601640B RID: 91147 RVA: 0x0033C85A File Offset: 0x0033AA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatDataUpdateNotify);
		}

		// Token: 0x0601640C RID: 91148 RVA: 0x0033C868 File Offset: 0x0033AA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatDataUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.RogueWhiteCatData, other.RogueWhiteCatData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601640D RID: 91149 RVA: 0x0033C8B8 File Offset: 0x0033AAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.rogueWhiteCatData_ != null)
			{
				num ^= this.RogueWhiteCatData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601640E RID: 91150 RVA: 0x0033C90D File Offset: 0x0033AB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601640F RID: 91151 RVA: 0x0033C91A File Offset: 0x0033AB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016410 RID: 91152 RVA: 0x0033C924 File Offset: 0x0033AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.rogueWhiteCatData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueWhiteCatData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016411 RID: 91153 RVA: 0x0033C980 File Offset: 0x0033AB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.rogueWhiteCatData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueWhiteCatData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016412 RID: 91154 RVA: 0x0033C9D8 File Offset: 0x0033ABD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.rogueWhiteCatData_ != null)
			{
				if (this.rogueWhiteCatData_ == null)
				{
					this.RogueWhiteCatData = new RogueWhiteCatData();
				}
				this.RogueWhiteCatData.MergeFrom(other.RogueWhiteCatData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016413 RID: 91155 RVA: 0x0033CA40 File Offset: 0x0033AC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016414 RID: 91156 RVA: 0x0033CA4C File Offset: 0x0033AC4C
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueWhiteCatData_ == null)
						{
							this.RogueWhiteCatData = new RogueWhiteCatData();
						}
						input.ReadMessage(this.RogueWhiteCatData);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085A7 RID: 34215
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085A8 RID: 34216
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040085A9 RID: 34217
		private int activityId_;

		// Token: 0x040085AA RID: 34218
		public const int RogueWhiteCatDataFieldNumber = 9;

		// Token: 0x040085AB RID: 34219
		private RogueWhiteCatData rogueWhiteCatData_;
	}
}
