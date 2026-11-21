using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000464 RID: 1124
	[NetMessage(EMessageId.EntityCameraAlertRequest)]
	public sealed class EntityCameraAlertRequest : IMessage<EntityCameraAlertRequest>, IMessage, IEquatable<EntityCameraAlertRequest>, IDeepCloneable<EntityCameraAlertRequest>, IBufferMessage
	{
		// Token: 0x06006BA4 RID: 27556 RVA: 0x001045B3 File Offset: 0x001027B3
		[NullableContext(1)]
		public static EntityCameraAlertRequest Create()
		{
			return new EntityCameraAlertRequest();
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06006BA5 RID: 27557 RVA: 0x001045BA File Offset: 0x001027BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06006BA6 RID: 27558 RVA: 0x001045BD File Offset: 0x001027BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCameraAlertRequest.Descriptor;
			}
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x001045C4 File Offset: 0x001027C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertRequest()
		{
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x001045CC File Offset: 0x001027CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertRequest(EntityCameraAlertRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isAlert_ = other.isAlert_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x001045FD File Offset: 0x001027FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertRequest Clone()
		{
			return new EntityCameraAlertRequest(this);
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06006BAA RID: 27562 RVA: 0x00104605 File Offset: 0x00102805
		// (set) Token: 0x06006BAB RID: 27563 RVA: 0x0010460D File Offset: 0x0010280D
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06006BAC RID: 27564 RVA: 0x00104616 File Offset: 0x00102816
		// (set) Token: 0x06006BAD RID: 27565 RVA: 0x0010461E File Offset: 0x0010281E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAlert
		{
			get
			{
				return this.isAlert_;
			}
			set
			{
				this.isAlert_ = value;
			}
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00104627 File Offset: 0x00102827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCameraAlertRequest);
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00104635 File Offset: 0x00102835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCameraAlertRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsAlert == other.IsAlert && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00104674 File Offset: 0x00102874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsAlert)
			{
				num ^= this.IsAlert.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x001046CC File Offset: 0x001028CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x001046D9 File Offset: 0x001028D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x001046E4 File Offset: 0x001028E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsAlert)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsAlert);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00104740 File Offset: 0x00102940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsAlert)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BB5 RID: 27573 RVA: 0x0010478C File Offset: 0x0010298C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCameraAlertRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsAlert)
			{
				this.IsAlert = other.IsAlert;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x001047DC File Offset: 0x001029DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x001047E8 File Offset: 0x001029E8
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
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsAlert = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B0F RID: 15119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B10 RID: 15120
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003B11 RID: 15121
		private long entityId_;

		// Token: 0x04003B12 RID: 15122
		public const int IsAlertFieldNumber = 14;

		// Token: 0x04003B13 RID: 15123
		private bool isAlert_;
	}
}
