using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001557 RID: 5463
	[NetMessage(EMessageId.VisionSkillCallNotify)]
	public sealed class VisionSkillCallNotify : IMessage<VisionSkillCallNotify>, IMessage, IEquatable<VisionSkillCallNotify>, IDeepCloneable<VisionSkillCallNotify>, IBufferMessage
	{
		// Token: 0x0601CEFA RID: 118522 RVA: 0x004313CC File Offset: 0x0042F5CC
		[NullableContext(1)]
		public static VisionSkillCallNotify Create()
		{
			return new VisionSkillCallNotify();
		}

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x0601CEFB RID: 118523 RVA: 0x004313D3 File Offset: 0x0042F5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061EA RID: 25066
		// (get) Token: 0x0601CEFC RID: 118524 RVA: 0x004313D6 File Offset: 0x0042F5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillCallNotify.Descriptor;
			}
		}

		// Token: 0x0601CEFD RID: 118525 RVA: 0x004313DD File Offset: 0x0042F5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillCallNotify()
		{
		}

		// Token: 0x0601CEFE RID: 118526 RVA: 0x004313E8 File Offset: 0x0042F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillCallNotify(VisionSkillCallNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityInfo_ = ((other.entityInfo_ != null) ? other.entityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEFF RID: 118527 RVA: 0x00431434 File Offset: 0x0042F634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillCallNotify Clone()
		{
			return new VisionSkillCallNotify(this);
		}

		// Token: 0x170061EB RID: 25067
		// (get) Token: 0x0601CF00 RID: 118528 RVA: 0x0043143C File Offset: 0x0042F63C
		// (set) Token: 0x0601CF01 RID: 118529 RVA: 0x00431444 File Offset: 0x0042F644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x0601CF02 RID: 118530 RVA: 0x0043144D File Offset: 0x0042F64D
		// (set) Token: 0x0601CF03 RID: 118531 RVA: 0x00431455 File Offset: 0x0042F655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityInformation EntityInfo
		{
			get
			{
				return this.entityInfo_;
			}
			set
			{
				this.entityInfo_ = value;
			}
		}

		// Token: 0x0601CF04 RID: 118532 RVA: 0x0043145E File Offset: 0x0042F65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillCallNotify);
		}

		// Token: 0x0601CF05 RID: 118533 RVA: 0x0043146C File Offset: 0x0042F66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillCallNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.EntityInfo, other.EntityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF06 RID: 118534 RVA: 0x004314BC File Offset: 0x0042F6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.entityInfo_ != null)
			{
				num ^= this.EntityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF07 RID: 118535 RVA: 0x00431511 File Offset: 0x0042F711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF08 RID: 118536 RVA: 0x0043151E File Offset: 0x0042F71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF09 RID: 118537 RVA: 0x00431528 File Offset: 0x0042F728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EntityInfo);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF0A RID: 118538 RVA: 0x00431584 File Offset: 0x0042F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.entityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF0B RID: 118539 RVA: 0x004315DC File Offset: 0x0042F7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionSkillCallNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.entityInfo_ != null)
			{
				if (this.entityInfo_ == null)
				{
					this.EntityInfo = new DynamicEntityInformation();
				}
				this.EntityInfo.MergeFrom(other.EntityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF0C RID: 118540 RVA: 0x00431644 File Offset: 0x0042F844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF0D RID: 118541 RVA: 0x00431650 File Offset: 0x0042F850
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
				if (num != 58U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityInfo_ == null)
					{
						this.EntityInfo = new DynamicEntityInformation();
					}
					input.ReadMessage(this.EntityInfo);
				}
			}
		}

		// Token: 0x0400A65B RID: 42587
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A65C RID: 42588
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x0400A65D RID: 42589
		private int playerId_;

		// Token: 0x0400A65E RID: 42590
		public const int EntityInfoFieldNumber = 7;

		// Token: 0x0400A65F RID: 42591
		private DynamicEntityInformation entityInfo_;
	}
}
