using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF9 RID: 3833
	[NetMessage(EMessageId.RemoveGameplayEffectPush)]
	public sealed class RemoveGameplayEffectPush : IMessage<RemoveGameplayEffectPush>, IMessage, IEquatable<RemoveGameplayEffectPush>, IDeepCloneable<RemoveGameplayEffectPush>, IBufferMessage
	{
		// Token: 0x06014894 RID: 84116 RVA: 0x002FBC67 File Offset: 0x002F9E67
		[NullableContext(1)]
		public static RemoveGameplayEffectPush Create()
		{
			return new RemoveGameplayEffectPush();
		}

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x06014895 RID: 84117 RVA: 0x002FBC6E File Offset: 0x002F9E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x06014896 RID: 84118 RVA: 0x002FBC71 File Offset: 0x002F9E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectPush.Descriptor;
			}
		}

		// Token: 0x06014897 RID: 84119 RVA: 0x002FBC78 File Offset: 0x002F9E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectPush()
		{
		}

		// Token: 0x06014898 RID: 84120 RVA: 0x002FBC8C File Offset: 0x002F9E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectPush(RemoveGameplayEffectPush other) : this()
		{
			this.handle_ = other.handle_;
			this.entityId_ = other.entityId_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014899 RID: 84121 RVA: 0x002FBCEC File Offset: 0x002F9EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectPush Clone()
		{
			return new RemoveGameplayEffectPush(this);
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x0601489A RID: 84122 RVA: 0x002FBCF4 File Offset: 0x002F9EF4
		// (set) Token: 0x0601489B RID: 84123 RVA: 0x002FBCFC File Offset: 0x002F9EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x0601489C RID: 84124 RVA: 0x002FBD05 File Offset: 0x002F9F05
		// (set) Token: 0x0601489D RID: 84125 RVA: 0x002FBD0D File Offset: 0x002F9F0D
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

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x0601489E RID: 84126 RVA: 0x002FBD16 File Offset: 0x002F9F16
		// (set) Token: 0x0601489F RID: 84127 RVA: 0x002FBD1E File Offset: 0x002F9F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPrematureRemoval
		{
			get
			{
				return this.isPrematureRemoval_;
			}
			set
			{
				this.isPrematureRemoval_ = value;
			}
		}

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x060148A0 RID: 84128 RVA: 0x002FBD27 File Offset: 0x002F9F27
		// (set) Token: 0x060148A1 RID: 84129 RVA: 0x002FBD2F File Offset: 0x002F9F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x060148A2 RID: 84130 RVA: 0x002FBD42 File Offset: 0x002F9F42
		// (set) Token: 0x060148A3 RID: 84131 RVA: 0x002FBD4A File Offset: 0x002F9F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x060148A4 RID: 84132 RVA: 0x002FBD53 File Offset: 0x002F9F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectPush);
		}

		// Token: 0x060148A5 RID: 84133 RVA: 0x002FBD64 File Offset: 0x002F9F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectPush other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.EntityId == other.EntityId && this.IsPrematureRemoval == other.IsPrematureRemoval && !(this.Reason != other.Reason) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148A6 RID: 84134 RVA: 0x002FBDE4 File Offset: 0x002F9FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsPrematureRemoval)
			{
				num ^= this.IsPrematureRemoval.GetHashCode();
			}
			if (this.Reason.Length != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060148A7 RID: 84135 RVA: 0x002FBE89 File Offset: 0x002FA089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148A8 RID: 84136 RVA: 0x002FBE96 File Offset: 0x002FA096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148A9 RID: 84137 RVA: 0x002FBEA0 File Offset: 0x002FA0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Handle);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148AA RID: 84138 RVA: 0x002FBF54 File Offset: 0x002FA154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsPrematureRemoval)
			{
				num += 2;
			}
			if (this.Reason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060148AB RID: 84139 RVA: 0x002FBFEC File Offset: 0x002FA1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveGameplayEffectPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsPrematureRemoval)
			{
				this.IsPrematureRemoval = other.IsPrematureRemoval;
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060148AC RID: 84140 RVA: 0x002FC07D File Offset: 0x002FA27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148AD RID: 84141 RVA: 0x002FC088 File Offset: 0x002FA288
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.Reason = input.ReadString();
						continue;
					}
					if (num == 32U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.IsPrematureRemoval = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C79 RID: 31865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C7A RID: 31866
		public const int HandleFieldNumber = 14;

		// Token: 0x04007C7B RID: 31867
		private int handle_;

		// Token: 0x04007C7C RID: 31868
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04007C7D RID: 31869
		private long entityId_;

		// Token: 0x04007C7E RID: 31870
		public const int IsPrematureRemovalFieldNumber = 10;

		// Token: 0x04007C7F RID: 31871
		private bool isPrematureRemoval_;

		// Token: 0x04007C80 RID: 31872
		public const int ReasonFieldNumber = 1;

		// Token: 0x04007C81 RID: 31873
		private string reason_ = "";

		// Token: 0x04007C82 RID: 31874
		public const int InstigatorIdFieldNumber = 4;

		// Token: 0x04007C83 RID: 31875
		private long instigatorId_;
	}
}
