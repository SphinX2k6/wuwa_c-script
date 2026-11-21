using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE9 RID: 3817
	[NetMessage(EMessageId.RemoveGameplayEffectPush)]
	public sealed class RemoveGameplayEffectPush : IMessage<RemoveGameplayEffectPush>, IMessage, IEquatable<RemoveGameplayEffectPush>, IDeepCloneable<RemoveGameplayEffectPush>, IBufferMessage
	{
		// Token: 0x060147AF RID: 83887 RVA: 0x002FA5AE File Offset: 0x002F87AE
		[NullableContext(1)]
		public static RemoveGameplayEffectPush Create()
		{
			return new RemoveGameplayEffectPush();
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x060147B0 RID: 83888 RVA: 0x002FA5B5 File Offset: 0x002F87B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x060147B1 RID: 83889 RVA: 0x002FA5B8 File Offset: 0x002F87B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectPush.Descriptor;
			}
		}

		// Token: 0x060147B2 RID: 83890 RVA: 0x002FA5BF File Offset: 0x002F87BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectPush()
		{
		}

		// Token: 0x060147B3 RID: 83891 RVA: 0x002FA5D4 File Offset: 0x002F87D4
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

		// Token: 0x060147B4 RID: 83892 RVA: 0x002FA634 File Offset: 0x002F8834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectPush Clone()
		{
			return new RemoveGameplayEffectPush(this);
		}

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x060147B5 RID: 83893 RVA: 0x002FA63C File Offset: 0x002F883C
		// (set) Token: 0x060147B6 RID: 83894 RVA: 0x002FA644 File Offset: 0x002F8844
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

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x060147B7 RID: 83895 RVA: 0x002FA64D File Offset: 0x002F884D
		// (set) Token: 0x060147B8 RID: 83896 RVA: 0x002FA655 File Offset: 0x002F8855
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

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x060147B9 RID: 83897 RVA: 0x002FA65E File Offset: 0x002F885E
		// (set) Token: 0x060147BA RID: 83898 RVA: 0x002FA666 File Offset: 0x002F8866
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

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x060147BB RID: 83899 RVA: 0x002FA66F File Offset: 0x002F886F
		// (set) Token: 0x060147BC RID: 83900 RVA: 0x002FA677 File Offset: 0x002F8877
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

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x060147BD RID: 83901 RVA: 0x002FA68A File Offset: 0x002F888A
		// (set) Token: 0x060147BE RID: 83902 RVA: 0x002FA692 File Offset: 0x002F8892
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

		// Token: 0x060147BF RID: 83903 RVA: 0x002FA69B File Offset: 0x002F889B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectPush);
		}

		// Token: 0x060147C0 RID: 83904 RVA: 0x002FA6AC File Offset: 0x002F88AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectPush other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.EntityId == other.EntityId && this.IsPrematureRemoval == other.IsPrematureRemoval && !(this.Reason != other.Reason) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147C1 RID: 83905 RVA: 0x002FA72C File Offset: 0x002F892C
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

		// Token: 0x060147C2 RID: 83906 RVA: 0x002FA7D1 File Offset: 0x002F89D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147C3 RID: 83907 RVA: 0x002FA7DE File Offset: 0x002F89DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147C4 RID: 83908 RVA: 0x002FA7E8 File Offset: 0x002F89E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Reason);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Handle);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147C5 RID: 83909 RVA: 0x002FA89C File Offset: 0x002F8A9C
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

		// Token: 0x060147C6 RID: 83910 RVA: 0x002FA934 File Offset: 0x002F8B34
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

		// Token: 0x060147C7 RID: 83911 RVA: 0x002FA9C5 File Offset: 0x002F8BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147C8 RID: 83912 RVA: 0x002FA9D0 File Offset: 0x002F8BD0
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
				if (num <= 42U)
				{
					if (num == 8U)
					{
						this.IsPrematureRemoval = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.Reason = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007CA3 RID: 31907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CA4 RID: 31908
		public const int HandleFieldNumber = 8;

		// Token: 0x04007CA5 RID: 31909
		private int handle_;

		// Token: 0x04007CA6 RID: 31910
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04007CA7 RID: 31911
		private long entityId_;

		// Token: 0x04007CA8 RID: 31912
		public const int IsPrematureRemovalFieldNumber = 1;

		// Token: 0x04007CA9 RID: 31913
		private bool isPrematureRemoval_;

		// Token: 0x04007CAA RID: 31914
		public const int ReasonFieldNumber = 5;

		// Token: 0x04007CAB RID: 31915
		private string reason_ = "";

		// Token: 0x04007CAC RID: 31916
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x04007CAD RID: 31917
		private long instigatorId_;
	}
}
