using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C8 RID: 968
	[NetMessage(EMessageId.DiscardWeaponRequest)]
	public sealed class DiscardWeaponRequest : IMessage<DiscardWeaponRequest>, IMessage, IEquatable<DiscardWeaponRequest>, IDeepCloneable<DiscardWeaponRequest>, IBufferMessage
	{
		// Token: 0x06005ED7 RID: 24279 RVA: 0x000E6047 File Offset: 0x000E4247
		[NullableContext(1)]
		public static DiscardWeaponRequest Create()
		{
			return new DiscardWeaponRequest();
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06005ED8 RID: 24280 RVA: 0x000E604E File Offset: 0x000E424E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x000E6051 File Offset: 0x000E4251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardWeaponRequest.Descriptor;
			}
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x000E6058 File Offset: 0x000E4258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponRequest()
		{
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x000E6060 File Offset: 0x000E4260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponRequest(DiscardWeaponRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x000E60AC File Offset: 0x000E42AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponRequest Clone()
		{
			return new DiscardWeaponRequest(this);
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x000E60B4 File Offset: 0x000E42B4
		// (set) Token: 0x06005EDE RID: 24286 RVA: 0x000E60BC File Offset: 0x000E42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x000E60C5 File Offset: 0x000E42C5
		// (set) Token: 0x06005EE0 RID: 24288 RVA: 0x000E60CD File Offset: 0x000E42CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation MovementInformation
		{
			get
			{
				return this.movementInformation_;
			}
			set
			{
				this.movementInformation_ = value;
			}
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x000E60D6 File Offset: 0x000E42D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardWeaponRequest);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x000E60E4 File Offset: 0x000E42E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardWeaponRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.MovementInformation, other.MovementInformation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x000E6134 File Offset: 0x000E4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.movementInformation_ != null)
			{
				num ^= this.MovementInformation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x000E6189 File Offset: 0x000E4389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x000E6196 File Offset: 0x000E4396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x000E61A0 File Offset: 0x000E43A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.movementInformation_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MovementInformation);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x000E61FC File Offset: 0x000E43FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.movementInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MovementInformation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x000E6254 File Offset: 0x000E4454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscardWeaponRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.movementInformation_ != null)
			{
				if (this.movementInformation_ == null)
				{
					this.MovementInformation = new MovementInformation();
				}
				this.MovementInformation.MergeFrom(other.MovementInformation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x000E62BC File Offset: 0x000E44BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x000E62C8 File Offset: 0x000E44C8
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
				if (num != 50U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.movementInformation_ == null)
					{
						this.MovementInformation = new MovementInformation();
					}
					input.ReadMessage(this.MovementInformation);
				}
			}
		}

		// Token: 0x0400374C RID: 14156
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400374D RID: 14157
		public const int EntityIdFieldNumber = 10;

		// Token: 0x0400374E RID: 14158
		private long entityId_;

		// Token: 0x0400374F RID: 14159
		public const int MovementInformationFieldNumber = 6;

		// Token: 0x04003750 RID: 14160
		private MovementInformation movementInformation_;
	}
}
