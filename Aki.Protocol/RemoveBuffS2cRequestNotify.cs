using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF3 RID: 3827
	[NetMessage(EMessageId.RemoveBuffS2cRequestNotify)]
	public sealed class RemoveBuffS2cRequestNotify : IMessage<RemoveBuffS2cRequestNotify>, IMessage, IEquatable<RemoveBuffS2cRequestNotify>, IDeepCloneable<RemoveBuffS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x0601481C RID: 83996 RVA: 0x002FACED File Offset: 0x002F8EED
		[NullableContext(1)]
		public static RemoveBuffS2cRequestNotify Create()
		{
			return new RemoveBuffS2cRequestNotify();
		}

		// Token: 0x17004433 RID: 17459
		// (get) Token: 0x0601481D RID: 83997 RVA: 0x002FACF4 File Offset: 0x002F8EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x0601481E RID: 83998 RVA: 0x002FACF7 File Offset: 0x002F8EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x0601481F RID: 83999 RVA: 0x002FACFE File Offset: 0x002F8EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify()
		{
		}

		// Token: 0x06014820 RID: 84000 RVA: 0x002FAD08 File Offset: 0x002F8F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify(RemoveBuffS2cRequestNotify other) : this()
		{
			this.handle_ = other.handle_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014821 RID: 84001 RVA: 0x002FAD5C File Offset: 0x002F8F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify Clone()
		{
			return new RemoveBuffS2cRequestNotify(this);
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x06014822 RID: 84002 RVA: 0x002FAD64 File Offset: 0x002F8F64
		// (set) Token: 0x06014823 RID: 84003 RVA: 0x002FAD6C File Offset: 0x002F8F6C
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

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x06014824 RID: 84004 RVA: 0x002FAD75 File Offset: 0x002F8F75
		// (set) Token: 0x06014825 RID: 84005 RVA: 0x002FAD7D File Offset: 0x002F8F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x06014826 RID: 84006 RVA: 0x002FAD86 File Offset: 0x002F8F86
		// (set) Token: 0x06014827 RID: 84007 RVA: 0x002FAD8E File Offset: 0x002F8F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x06014828 RID: 84008 RVA: 0x002FAD97 File Offset: 0x002F8F97
		// (set) Token: 0x06014829 RID: 84009 RVA: 0x002FAD9F File Offset: 0x002F8F9F
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

		// Token: 0x0601482A RID: 84010 RVA: 0x002FADA8 File Offset: 0x002F8FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffS2cRequestNotify);
		}

		// Token: 0x0601482B RID: 84011 RVA: 0x002FADB8 File Offset: 0x002F8FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffS2cRequestNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.StackCount == other.StackCount && this.Reason == other.Reason && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601482C RID: 84012 RVA: 0x002FAE24 File Offset: 0x002F9024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.Reason != 0)
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

		// Token: 0x0601482D RID: 84013 RVA: 0x002FAEAE File Offset: 0x002F90AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601482E RID: 84014 RVA: 0x002FAEBB File Offset: 0x002F90BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601482F RID: 84015 RVA: 0x002FAEC4 File Offset: 0x002F90C4
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
				output.WriteRawTag(16);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014830 RID: 84016 RVA: 0x002FAF54 File Offset: 0x002F9154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
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

		// Token: 0x06014831 RID: 84017 RVA: 0x002FAFDC File Offset: 0x002F91DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffS2cRequestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014832 RID: 84018 RVA: 0x002FB054 File Offset: 0x002F9254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014833 RID: 84019 RVA: 0x002FB060 File Offset: 0x002F9260
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C59 RID: 31833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C5A RID: 31834
		public const int HandleFieldNumber = 1;

		// Token: 0x04007C5B RID: 31835
		private int handle_;

		// Token: 0x04007C5C RID: 31836
		public const int StackCountFieldNumber = 12;

		// Token: 0x04007C5D RID: 31837
		private int stackCount_;

		// Token: 0x04007C5E RID: 31838
		public const int ReasonFieldNumber = 11;

		// Token: 0x04007C5F RID: 31839
		private int reason_;

		// Token: 0x04007C60 RID: 31840
		public const int InstigatorIdFieldNumber = 2;

		// Token: 0x04007C61 RID: 31841
		private long instigatorId_;
	}
}
