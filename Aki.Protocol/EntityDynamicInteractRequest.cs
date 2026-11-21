using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046E RID: 1134
	[NetMessage(EMessageId.EntityDynamicInteractRequest)]
	public sealed class EntityDynamicInteractRequest : IMessage<EntityDynamicInteractRequest>, IMessage, IEquatable<EntityDynamicInteractRequest>, IDeepCloneable<EntityDynamicInteractRequest>, IBufferMessage
	{
		// Token: 0x06006D34 RID: 27956 RVA: 0x0010CF83 File Offset: 0x0010B183
		[NullableContext(1)]
		public static EntityDynamicInteractRequest Create()
		{
			return new EntityDynamicInteractRequest();
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x0010CF8A File Offset: 0x0010B18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x0010CF8D File Offset: 0x0010B18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDynamicInteractRequest.Descriptor;
			}
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x0010CF94 File Offset: 0x0010B194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractRequest()
		{
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x0010CFA7 File Offset: 0x0010B1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractRequest(EntityDynamicInteractRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x0010CFD8 File Offset: 0x0010B1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractRequest Clone()
		{
			return new EntityDynamicInteractRequest(this);
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x0010CFE0 File Offset: 0x0010B1E0
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x0010CFE8 File Offset: 0x0010B1E8
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

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x0010CFF1 File Offset: 0x0010B1F1
		// (set) Token: 0x06006D3D RID: 27965 RVA: 0x0010CFF9 File Offset: 0x0010B1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OptionGuid
		{
			get
			{
				return this.optionGuid_;
			}
			set
			{
				this.optionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x0010D00C File Offset: 0x0010B20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDynamicInteractRequest);
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x0010D01C File Offset: 0x0010B21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDynamicInteractRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x0010D06C File Offset: 0x0010B26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OptionGuid.Length != 0)
			{
				num ^= this.OptionGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x0010D0C6 File Offset: 0x0010B2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x0010D0D3 File Offset: 0x0010B2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x0010D0DC File Offset: 0x0010B2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.OptionGuid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x0010D13C File Offset: 0x0010B33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OptionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OptionGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0010D198 File Offset: 0x0010B398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityDynamicInteractRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OptionGuid.Length != 0)
			{
				this.OptionGuid = other.OptionGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x0010D1ED File Offset: 0x0010B3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x0010D1F8 File Offset: 0x0010B3F8
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
				if (num != 66U)
				{
					if (num != 96U)
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
					this.OptionGuid = input.ReadString();
				}
			}
		}

		// Token: 0x04003BA6 RID: 15270
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BA7 RID: 15271
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003BA8 RID: 15272
		private long entityId_;

		// Token: 0x04003BA9 RID: 15273
		public const int OptionGuidFieldNumber = 8;

		// Token: 0x04003BAA RID: 15274
		private string optionGuid_ = "";
	}
}
