using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000459 RID: 1113
	[NetMessage(EMessageId.EntityBeamReceiveRequest)]
	public sealed class EntityBeamReceiveRequest : IMessage<EntityBeamReceiveRequest>, IMessage, IEquatable<EntityBeamReceiveRequest>, IDeepCloneable<EntityBeamReceiveRequest>, IBufferMessage
	{
		// Token: 0x06006ACC RID: 27340 RVA: 0x00102A1A File Offset: 0x00100C1A
		[NullableContext(1)]
		public static EntityBeamReceiveRequest Create()
		{
			return new EntityBeamReceiveRequest();
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x00102A21 File Offset: 0x00100C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06006ACE RID: 27342 RVA: 0x00102A24 File Offset: 0x00100C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBeamReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00102A2B File Offset: 0x00100C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveRequest()
		{
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00102A33 File Offset: 0x00100C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveRequest(EntityBeamReceiveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.receiveType_ = other.receiveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00102A64 File Offset: 0x00100C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveRequest Clone()
		{
			return new EntityBeamReceiveRequest(this);
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06006AD2 RID: 27346 RVA: 0x00102A6C File Offset: 0x00100C6C
		// (set) Token: 0x06006AD3 RID: 27347 RVA: 0x00102A74 File Offset: 0x00100C74
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

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06006AD4 RID: 27348 RVA: 0x00102A7D File Offset: 0x00100C7D
		// (set) Token: 0x06006AD5 RID: 27349 RVA: 0x00102A85 File Offset: 0x00100C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveType ReceiveType
		{
			get
			{
				return this.receiveType_;
			}
			set
			{
				this.receiveType_ = value;
			}
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00102A8E File Offset: 0x00100C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBeamReceiveRequest);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00102A9C File Offset: 0x00100C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBeamReceiveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ReceiveType == other.ReceiveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00102ADC File Offset: 0x00100CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num ^= this.ReceiveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00102B3A File Offset: 0x00100D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00102B47 File Offset: 0x00100D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00102B50 File Offset: 0x00100D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ReceiveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00102BAC File Offset: 0x00100DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReceiveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00102C04 File Offset: 0x00100E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBeamReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				this.ReceiveType = other.ReceiveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x00102C54 File Offset: 0x00100E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00102C60 File Offset: 0x00100E60
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
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReceiveType = (EntityBeamReceiveType)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003ADA RID: 15066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ADB RID: 15067
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003ADC RID: 15068
		private long entityId_;

		// Token: 0x04003ADD RID: 15069
		public const int ReceiveTypeFieldNumber = 10;

		// Token: 0x04003ADE RID: 15070
		private EntityBeamReceiveType receiveType_;
	}
}
