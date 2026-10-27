using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFA RID: 3834
	[NetMessage(EMessageId.RemoveGameplayEffectRequest)]
	public sealed class RemoveGameplayEffectRequest : IMessage<RemoveGameplayEffectRequest>, IMessage, IEquatable<RemoveGameplayEffectRequest>, IDeepCloneable<RemoveGameplayEffectRequest>, IBufferMessage
	{
		// Token: 0x060148AE RID: 84142 RVA: 0x002FC123 File Offset: 0x002FA323
		[NullableContext(1)]
		public static RemoveGameplayEffectRequest Create()
		{
			return new RemoveGameplayEffectRequest();
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x060148AF RID: 84143 RVA: 0x002FC12A File Offset: 0x002FA32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x060148B0 RID: 84144 RVA: 0x002FC12D File Offset: 0x002FA32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectRequest.Descriptor;
			}
		}

		// Token: 0x060148B1 RID: 84145 RVA: 0x002FC134 File Offset: 0x002FA334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest()
		{
		}

		// Token: 0x060148B2 RID: 84146 RVA: 0x002FC13C File Offset: 0x002FA33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest(RemoveGameplayEffectRequest other) : this()
		{
			this.handle_ = other.handle_;
			this.entityId_ = other.entityId_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148B3 RID: 84147 RVA: 0x002FC179 File Offset: 0x002FA379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest Clone()
		{
			return new RemoveGameplayEffectRequest(this);
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x060148B4 RID: 84148 RVA: 0x002FC181 File Offset: 0x002FA381
		// (set) Token: 0x060148B5 RID: 84149 RVA: 0x002FC189 File Offset: 0x002FA389
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

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x060148B6 RID: 84150 RVA: 0x002FC192 File Offset: 0x002FA392
		// (set) Token: 0x060148B7 RID: 84151 RVA: 0x002FC19A File Offset: 0x002FA39A
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

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x060148B8 RID: 84152 RVA: 0x002FC1A3 File Offset: 0x002FA3A3
		// (set) Token: 0x060148B9 RID: 84153 RVA: 0x002FC1AB File Offset: 0x002FA3AB
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

		// Token: 0x060148BA RID: 84154 RVA: 0x002FC1B4 File Offset: 0x002FA3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectRequest);
		}

		// Token: 0x060148BB RID: 84155 RVA: 0x002FC1C4 File Offset: 0x002FA3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectRequest other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.EntityId == other.EntityId && this.IsPrematureRemoval == other.IsPrematureRemoval && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148BC RID: 84156 RVA: 0x002FC220 File Offset: 0x002FA420
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060148BD RID: 84157 RVA: 0x002FC291 File Offset: 0x002FA491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148BE RID: 84158 RVA: 0x002FC29E File Offset: 0x002FA49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148BF RID: 84159 RVA: 0x002FC2A8 File Offset: 0x002FA4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148C0 RID: 84160 RVA: 0x002FC320 File Offset: 0x002FA520
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060148C1 RID: 84161 RVA: 0x002FC384 File Offset: 0x002FA584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveGameplayEffectRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060148C2 RID: 84162 RVA: 0x002FC3E8 File Offset: 0x002FA5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148C3 RID: 84163 RVA: 0x002FC3F4 File Offset: 0x002FA5F4
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 48U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Handle = input.ReadInt32();
						}
					}
					else
					{
						this.IsPrematureRemoval = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007C84 RID: 31876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C85 RID: 31877
		public const int HandleFieldNumber = 6;

		// Token: 0x04007C86 RID: 31878
		private int handle_;

		// Token: 0x04007C87 RID: 31879
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04007C88 RID: 31880
		private long entityId_;

		// Token: 0x04007C89 RID: 31881
		public const int IsPrematureRemovalFieldNumber = 3;

		// Token: 0x04007C8A RID: 31882
		private bool isPrematureRemoval_;
	}
}
