using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000075 RID: 117
	[NetMessage(EMessageId.ActionOperationScreenSuccessRequest)]
	public sealed class ActionOperationScreenSuccessRequest : IMessage<ActionOperationScreenSuccessRequest>, IMessage, IEquatable<ActionOperationScreenSuccessRequest>, IDeepCloneable<ActionOperationScreenSuccessRequest>, IBufferMessage
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x0003F1F9 File Offset: 0x0003D3F9
		[NullableContext(1)]
		public static ActionOperationScreenSuccessRequest Create()
		{
			return new ActionOperationScreenSuccessRequest();
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0003F200 File Offset: 0x0003D400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0003F203 File Offset: 0x0003D403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOperationScreenSuccessRequest.Descriptor;
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0003F20A File Offset: 0x0003D40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessRequest()
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0003F212 File Offset: 0x0003D412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessRequest(ActionOperationScreenSuccessRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0003F24F File Offset: 0x0003D44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessRequest Clone()
		{
			return new ActionOperationScreenSuccessRequest(this);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x0003F257 File Offset: 0x0003D457
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0003F25F File Offset: 0x0003D45F
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x0003F268 File Offset: 0x0003D468
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0003F270 File Offset: 0x0003D470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x0003F279 File Offset: 0x0003D479
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0003F281 File Offset: 0x0003D481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionScreenOperationType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0003F28A File Offset: 0x0003D48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOperationScreenSuccessRequest);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0003F298 File Offset: 0x0003D498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOperationScreenSuccessRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0003F2F4 File Offset: 0x0003D4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0003F36B File Offset: 0x0003D56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0003F378 File Offset: 0x0003D578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0003F384 File Offset: 0x0003D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.IncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0003F3FC File Offset: 0x0003D5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0003F46C File Offset: 0x0003D66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOperationScreenSuccessRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Type != ActionScreenOperationType.Close)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0003F4D0 File Offset: 0x0003D6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0003F4DC File Offset: 0x0003D6DC
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = (ActionScreenOperationType)input.ReadEnum();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040021AC RID: 8620
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021AD RID: 8621
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x040021AE RID: 8622
		private int playerId_;

		// Token: 0x040021AF RID: 8623
		public const int IncIdFieldNumber = 8;

		// Token: 0x040021B0 RID: 8624
		private int incId_;

		// Token: 0x040021B1 RID: 8625
		public const int TypeFieldNumber = 14;

		// Token: 0x040021B2 RID: 8626
		private ActionScreenOperationType type_;
	}
}
