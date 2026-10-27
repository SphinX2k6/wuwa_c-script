using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E1 RID: 5345
	[NetMessage(EMessageId.VisionSkillCallNotify)]
	public sealed class VisionSkillCallNotify : IMessage<VisionSkillCallNotify>, IMessage, IEquatable<VisionSkillCallNotify>, IDeepCloneable<VisionSkillCallNotify>, IBufferMessage
	{
		// Token: 0x0601C433 RID: 115763 RVA: 0x00415910 File Offset: 0x00413B10
		[NullableContext(1)]
		public static VisionSkillCallNotify Create()
		{
			return new VisionSkillCallNotify();
		}

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x0601C434 RID: 115764 RVA: 0x00415917 File Offset: 0x00413B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x0601C435 RID: 115765 RVA: 0x0041591A File Offset: 0x00413B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillCallNotify.Descriptor;
			}
		}

		// Token: 0x0601C436 RID: 115766 RVA: 0x00415921 File Offset: 0x00413B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillCallNotify()
		{
		}

		// Token: 0x0601C437 RID: 115767 RVA: 0x0041592C File Offset: 0x00413B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillCallNotify(VisionSkillCallNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityInfo_ = ((other.entityInfo_ != null) ? other.entityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C438 RID: 115768 RVA: 0x00415978 File Offset: 0x00413B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillCallNotify Clone()
		{
			return new VisionSkillCallNotify(this);
		}

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x0601C439 RID: 115769 RVA: 0x00415980 File Offset: 0x00413B80
		// (set) Token: 0x0601C43A RID: 115770 RVA: 0x00415988 File Offset: 0x00413B88
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

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x0601C43B RID: 115771 RVA: 0x00415991 File Offset: 0x00413B91
		// (set) Token: 0x0601C43C RID: 115772 RVA: 0x00415999 File Offset: 0x00413B99
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

		// Token: 0x0601C43D RID: 115773 RVA: 0x004159A2 File Offset: 0x00413BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillCallNotify);
		}

		// Token: 0x0601C43E RID: 115774 RVA: 0x004159B0 File Offset: 0x00413BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillCallNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.EntityInfo, other.EntityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C43F RID: 115775 RVA: 0x00415A00 File Offset: 0x00413C00
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

		// Token: 0x0601C440 RID: 115776 RVA: 0x00415A55 File Offset: 0x00413C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C441 RID: 115777 RVA: 0x00415A62 File Offset: 0x00413C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C442 RID: 115778 RVA: 0x00415A6C File Offset: 0x00413C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.entityInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.EntityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C443 RID: 115779 RVA: 0x00415AC8 File Offset: 0x00413CC8
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

		// Token: 0x0601C444 RID: 115780 RVA: 0x00415B20 File Offset: 0x00413D20
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

		// Token: 0x0601C445 RID: 115781 RVA: 0x00415B88 File Offset: 0x00413D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C446 RID: 115782 RVA: 0x00415B94 File Offset: 0x00413D94
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
				if (num != 80U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A202 RID: 41474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A203 RID: 41475
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x0400A204 RID: 41476
		private int playerId_;

		// Token: 0x0400A205 RID: 41477
		public const int EntityInfoFieldNumber = 11;

		// Token: 0x0400A206 RID: 41478
		private DynamicEntityInformation entityInfo_;
	}
}
