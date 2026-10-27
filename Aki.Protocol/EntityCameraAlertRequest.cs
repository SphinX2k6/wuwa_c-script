using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047B RID: 1147
	[NetMessage(EMessageId.EntityCameraAlertRequest)]
	public sealed class EntityCameraAlertRequest : IMessage<EntityCameraAlertRequest>, IMessage, IEquatable<EntityCameraAlertRequest>, IDeepCloneable<EntityCameraAlertRequest>, IBufferMessage
	{
		// Token: 0x06006D32 RID: 27954 RVA: 0x00107627 File Offset: 0x00105827
		[NullableContext(1)]
		public static EntityCameraAlertRequest Create()
		{
			return new EntityCameraAlertRequest();
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x0010762E File Offset: 0x0010582E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06006D34 RID: 27956 RVA: 0x00107631 File Offset: 0x00105831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCameraAlertRequest.Descriptor;
			}
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x00107638 File Offset: 0x00105838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertRequest()
		{
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x00107640 File Offset: 0x00105840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertRequest(EntityCameraAlertRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isAlert_ = other.isAlert_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x00107671 File Offset: 0x00105871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertRequest Clone()
		{
			return new EntityCameraAlertRequest(this);
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06006D38 RID: 27960 RVA: 0x00107679 File Offset: 0x00105879
		// (set) Token: 0x06006D39 RID: 27961 RVA: 0x00107681 File Offset: 0x00105881
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

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x0010768A File Offset: 0x0010588A
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x00107692 File Offset: 0x00105892
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

		// Token: 0x06006D3C RID: 27964 RVA: 0x0010769B File Offset: 0x0010589B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCameraAlertRequest);
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x001076A9 File Offset: 0x001058A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCameraAlertRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsAlert == other.IsAlert && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x001076E8 File Offset: 0x001058E8
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

		// Token: 0x06006D3F RID: 27967 RVA: 0x00107740 File Offset: 0x00105940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x0010774D File Offset: 0x0010594D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x00107758 File Offset: 0x00105958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAlert)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsAlert);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x001077B4 File Offset: 0x001059B4
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

		// Token: 0x06006D43 RID: 27971 RVA: 0x00107800 File Offset: 0x00105A00
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

		// Token: 0x06006D44 RID: 27972 RVA: 0x00107850 File Offset: 0x00105A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0010785C File Offset: 0x00105A5C
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
					if (num != 32U)
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
					this.IsAlert = input.ReadBool();
				}
			}
		}

		// Token: 0x04003B21 RID: 15137
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B22 RID: 15138
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04003B23 RID: 15139
		private long entityId_;

		// Token: 0x04003B24 RID: 15140
		public const int IsAlertFieldNumber = 3;

		// Token: 0x04003B25 RID: 15141
		private bool isAlert_;
	}
}
