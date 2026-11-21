using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEA RID: 3818
	[NetMessage(EMessageId.RemoveGameplayEffectRequest)]
	public sealed class RemoveGameplayEffectRequest : IMessage<RemoveGameplayEffectRequest>, IMessage, IEquatable<RemoveGameplayEffectRequest>, IDeepCloneable<RemoveGameplayEffectRequest>, IBufferMessage
	{
		// Token: 0x060147C9 RID: 83913 RVA: 0x002FAA6A File Offset: 0x002F8C6A
		[NullableContext(1)]
		public static RemoveGameplayEffectRequest Create()
		{
			return new RemoveGameplayEffectRequest();
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x060147CA RID: 83914 RVA: 0x002FAA71 File Offset: 0x002F8C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x060147CB RID: 83915 RVA: 0x002FAA74 File Offset: 0x002F8C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectRequest.Descriptor;
			}
		}

		// Token: 0x060147CC RID: 83916 RVA: 0x002FAA7B File Offset: 0x002F8C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest()
		{
		}

		// Token: 0x060147CD RID: 83917 RVA: 0x002FAA83 File Offset: 0x002F8C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest(RemoveGameplayEffectRequest other) : this()
		{
			this.handle_ = other.handle_;
			this.entityId_ = other.entityId_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147CE RID: 83918 RVA: 0x002FAAC0 File Offset: 0x002F8CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest Clone()
		{
			return new RemoveGameplayEffectRequest(this);
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x060147CF RID: 83919 RVA: 0x002FAAC8 File Offset: 0x002F8CC8
		// (set) Token: 0x060147D0 RID: 83920 RVA: 0x002FAAD0 File Offset: 0x002F8CD0
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

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x060147D1 RID: 83921 RVA: 0x002FAAD9 File Offset: 0x002F8CD9
		// (set) Token: 0x060147D2 RID: 83922 RVA: 0x002FAAE1 File Offset: 0x002F8CE1
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

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x060147D3 RID: 83923 RVA: 0x002FAAEA File Offset: 0x002F8CEA
		// (set) Token: 0x060147D4 RID: 83924 RVA: 0x002FAAF2 File Offset: 0x002F8CF2
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

		// Token: 0x060147D5 RID: 83925 RVA: 0x002FAAFB File Offset: 0x002F8CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectRequest);
		}

		// Token: 0x060147D6 RID: 83926 RVA: 0x002FAB0C File Offset: 0x002F8D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectRequest other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.EntityId == other.EntityId && this.IsPrematureRemoval == other.IsPrematureRemoval && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147D7 RID: 83927 RVA: 0x002FAB68 File Offset: 0x002F8D68
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

		// Token: 0x060147D8 RID: 83928 RVA: 0x002FABD9 File Offset: 0x002F8DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147D9 RID: 83929 RVA: 0x002FABE6 File Offset: 0x002F8DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147DA RID: 83930 RVA: 0x002FABF0 File Offset: 0x002F8DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Handle);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147DB RID: 83931 RVA: 0x002FAC64 File Offset: 0x002F8E64
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

		// Token: 0x060147DC RID: 83932 RVA: 0x002FACC8 File Offset: 0x002F8EC8
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

		// Token: 0x060147DD RID: 83933 RVA: 0x002FAD2C File Offset: 0x002F8F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147DE RID: 83934 RVA: 0x002FAD38 File Offset: 0x002F8F38
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
				if (num != 8U)
				{
					if (num != 48U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Handle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CAE RID: 31918
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CAF RID: 31919
		public const int HandleFieldNumber = 1;

		// Token: 0x04007CB0 RID: 31920
		private int handle_;

		// Token: 0x04007CB1 RID: 31921
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04007CB2 RID: 31922
		private long entityId_;

		// Token: 0x04007CB3 RID: 31923
		public const int IsPrematureRemovalFieldNumber = 14;

		// Token: 0x04007CB4 RID: 31924
		private bool isPrematureRemoval_;
	}
}
