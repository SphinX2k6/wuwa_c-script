using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104E RID: 4174
	[NetMessage(EMessageId.RogueWhiteCatDataUpdateNotify)]
	public sealed class RogueWhiteCatDataUpdateNotify : IMessage<RogueWhiteCatDataUpdateNotify>, IMessage, IEquatable<RogueWhiteCatDataUpdateNotify>, IDeepCloneable<RogueWhiteCatDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x060164E6 RID: 91366 RVA: 0x0033DE94 File Offset: 0x0033C094
		[NullableContext(1)]
		public static RogueWhiteCatDataUpdateNotify Create()
		{
			return new RogueWhiteCatDataUpdateNotify();
		}

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x060164E7 RID: 91367 RVA: 0x0033DE9B File Offset: 0x0033C09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x060164E8 RID: 91368 RVA: 0x0033DE9E File Offset: 0x0033C09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060164E9 RID: 91369 RVA: 0x0033DEA5 File Offset: 0x0033C0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatDataUpdateNotify()
		{
		}

		// Token: 0x060164EA RID: 91370 RVA: 0x0033DEB0 File Offset: 0x0033C0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatDataUpdateNotify(RogueWhiteCatDataUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rogueWhiteCatData_ = ((other.rogueWhiteCatData_ != null) ? other.rogueWhiteCatData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060164EB RID: 91371 RVA: 0x0033DEFC File Offset: 0x0033C0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatDataUpdateNotify Clone()
		{
			return new RogueWhiteCatDataUpdateNotify(this);
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x060164EC RID: 91372 RVA: 0x0033DF04 File Offset: 0x0033C104
		// (set) Token: 0x060164ED RID: 91373 RVA: 0x0033DF0C File Offset: 0x0033C10C
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

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x060164EE RID: 91374 RVA: 0x0033DF15 File Offset: 0x0033C115
		// (set) Token: 0x060164EF RID: 91375 RVA: 0x0033DF1D File Offset: 0x0033C11D
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

		// Token: 0x060164F0 RID: 91376 RVA: 0x0033DF26 File Offset: 0x0033C126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatDataUpdateNotify);
		}

		// Token: 0x060164F1 RID: 91377 RVA: 0x0033DF34 File Offset: 0x0033C134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatDataUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.RogueWhiteCatData, other.RogueWhiteCatData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164F2 RID: 91378 RVA: 0x0033DF84 File Offset: 0x0033C184
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

		// Token: 0x060164F3 RID: 91379 RVA: 0x0033DFD9 File Offset: 0x0033C1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164F4 RID: 91380 RVA: 0x0033DFE6 File Offset: 0x0033C1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164F5 RID: 91381 RVA: 0x0033DFF0 File Offset: 0x0033C1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.rogueWhiteCatData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueWhiteCatData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060164F6 RID: 91382 RVA: 0x0033E04C File Offset: 0x0033C24C
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

		// Token: 0x060164F7 RID: 91383 RVA: 0x0033E0A4 File Offset: 0x0033C2A4
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

		// Token: 0x060164F8 RID: 91384 RVA: 0x0033E10C File Offset: 0x0033C30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164F9 RID: 91385 RVA: 0x0033E118 File Offset: 0x0033C318
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
				if (num != 40U)
				{
					if (num != 114U)
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

		// Token: 0x0400857D RID: 34173
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400857E RID: 34174
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x0400857F RID: 34175
		private int activityId_;

		// Token: 0x04008580 RID: 34176
		public const int RogueWhiteCatDataFieldNumber = 14;

		// Token: 0x04008581 RID: 34177
		private RogueWhiteCatData rogueWhiteCatData_;
	}
}
