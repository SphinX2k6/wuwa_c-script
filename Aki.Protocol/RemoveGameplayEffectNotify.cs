using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE8 RID: 3816
	[NetMessage(EMessageId.RemoveGameplayEffectNotify)]
	public sealed class RemoveGameplayEffectNotify : IMessage<RemoveGameplayEffectNotify>, IMessage, IEquatable<RemoveGameplayEffectNotify>, IDeepCloneable<RemoveGameplayEffectNotify>, IBufferMessage
	{
		// Token: 0x06014799 RID: 83865 RVA: 0x002FA26D File Offset: 0x002F846D
		[NullableContext(1)]
		public static RemoveGameplayEffectNotify Create()
		{
			return new RemoveGameplayEffectNotify();
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x0601479A RID: 83866 RVA: 0x002FA274 File Offset: 0x002F8474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x0601479B RID: 83867 RVA: 0x002FA277 File Offset: 0x002F8477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectNotify.Descriptor;
			}
		}

		// Token: 0x0601479C RID: 83868 RVA: 0x002FA27E File Offset: 0x002F847E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify()
		{
		}

		// Token: 0x0601479D RID: 83869 RVA: 0x002FA286 File Offset: 0x002F8486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify(RemoveGameplayEffectNotify other) : this()
		{
			this.handle_ = other.handle_;
			this.entityId_ = other.entityId_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601479E RID: 83870 RVA: 0x002FA2C3 File Offset: 0x002F84C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify Clone()
		{
			return new RemoveGameplayEffectNotify(this);
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x0601479F RID: 83871 RVA: 0x002FA2CB File Offset: 0x002F84CB
		// (set) Token: 0x060147A0 RID: 83872 RVA: 0x002FA2D3 File Offset: 0x002F84D3
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

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x060147A1 RID: 83873 RVA: 0x002FA2DC File Offset: 0x002F84DC
		// (set) Token: 0x060147A2 RID: 83874 RVA: 0x002FA2E4 File Offset: 0x002F84E4
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

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x060147A3 RID: 83875 RVA: 0x002FA2ED File Offset: 0x002F84ED
		// (set) Token: 0x060147A4 RID: 83876 RVA: 0x002FA2F5 File Offset: 0x002F84F5
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

		// Token: 0x060147A5 RID: 83877 RVA: 0x002FA2FE File Offset: 0x002F84FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectNotify);
		}

		// Token: 0x060147A6 RID: 83878 RVA: 0x002FA30C File Offset: 0x002F850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.EntityId == other.EntityId && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147A7 RID: 83879 RVA: 0x002FA368 File Offset: 0x002F8568
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

		// Token: 0x060147A8 RID: 83880 RVA: 0x002FA3D9 File Offset: 0x002F85D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147A9 RID: 83881 RVA: 0x002FA3E6 File Offset: 0x002F85E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147AA RID: 83882 RVA: 0x002FA3F0 File Offset: 0x002F85F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Handle);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.InstigatorId);
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

		// Token: 0x060147AB RID: 83883 RVA: 0x002FA464 File Offset: 0x002F8664
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

		// Token: 0x060147AC RID: 83884 RVA: 0x002FA4D4 File Offset: 0x002F86D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveGameplayEffectNotify other)
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
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060147AD RID: 83885 RVA: 0x002FA538 File Offset: 0x002F8738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147AE RID: 83886 RVA: 0x002FA544 File Offset: 0x002F8744
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
					if (num != 56U)
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
						this.InstigatorId = input.ReadInt64();
					}
				}
				else
				{
					this.Handle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C9C RID: 31900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C9D RID: 31901
		public const int HandleFieldNumber = 1;

		// Token: 0x04007C9E RID: 31902
		private int handle_;

		// Token: 0x04007C9F RID: 31903
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04007CA0 RID: 31904
		private long entityId_;

		// Token: 0x04007CA1 RID: 31905
		public const int InstigatorIdFieldNumber = 7;

		// Token: 0x04007CA2 RID: 31906
		private long instigatorId_;
	}
}
