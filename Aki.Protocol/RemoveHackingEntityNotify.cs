using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EED RID: 3821
	[NetMessage(EMessageId.RemoveHackingEntityNotify)]
	public sealed class RemoveHackingEntityNotify : IMessage<RemoveHackingEntityNotify>, IMessage, IEquatable<RemoveHackingEntityNotify>, IDeepCloneable<RemoveHackingEntityNotify>, IBufferMessage
	{
		// Token: 0x06014805 RID: 83973 RVA: 0x002FB219 File Offset: 0x002F9419
		[NullableContext(1)]
		public static RemoveHackingEntityNotify Create()
		{
			return new RemoveHackingEntityNotify();
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x06014806 RID: 83974 RVA: 0x002FB220 File Offset: 0x002F9420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x06014807 RID: 83975 RVA: 0x002FB223 File Offset: 0x002F9423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveHackingEntityNotify.Descriptor;
			}
		}

		// Token: 0x06014808 RID: 83976 RVA: 0x002FB22A File Offset: 0x002F942A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveHackingEntityNotify()
		{
		}

		// Token: 0x06014809 RID: 83977 RVA: 0x002FB232 File Offset: 0x002F9432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveHackingEntityNotify(RemoveHackingEntityNotify other) : this()
		{
			this.auxiliaryMachineEntityId_ = other.auxiliaryMachineEntityId_;
			this.hackingEntityId_ = other.hackingEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601480A RID: 83978 RVA: 0x002FB263 File Offset: 0x002F9463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveHackingEntityNotify Clone()
		{
			return new RemoveHackingEntityNotify(this);
		}

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x0601480B RID: 83979 RVA: 0x002FB26B File Offset: 0x002F946B
		// (set) Token: 0x0601480C RID: 83980 RVA: 0x002FB273 File Offset: 0x002F9473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AuxiliaryMachineEntityId
		{
			get
			{
				return this.auxiliaryMachineEntityId_;
			}
			set
			{
				this.auxiliaryMachineEntityId_ = value;
			}
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x0601480D RID: 83981 RVA: 0x002FB27C File Offset: 0x002F947C
		// (set) Token: 0x0601480E RID: 83982 RVA: 0x002FB284 File Offset: 0x002F9484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HackingEntityId
		{
			get
			{
				return this.hackingEntityId_;
			}
			set
			{
				this.hackingEntityId_ = value;
			}
		}

		// Token: 0x0601480F RID: 83983 RVA: 0x002FB28D File Offset: 0x002F948D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveHackingEntityNotify);
		}

		// Token: 0x06014810 RID: 83984 RVA: 0x002FB29B File Offset: 0x002F949B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveHackingEntityNotify other)
		{
			return other != null && (other == this || (this.AuxiliaryMachineEntityId == other.AuxiliaryMachineEntityId && this.HackingEntityId == other.HackingEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014811 RID: 83985 RVA: 0x002FB2DC File Offset: 0x002F94DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AuxiliaryMachineEntityId != 0L)
			{
				num ^= this.AuxiliaryMachineEntityId.GetHashCode();
			}
			if (this.HackingEntityId != 0L)
			{
				num ^= this.HackingEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014812 RID: 83986 RVA: 0x002FB334 File Offset: 0x002F9534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014813 RID: 83987 RVA: 0x002FB341 File Offset: 0x002F9541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014814 RID: 83988 RVA: 0x002FB34C File Offset: 0x002F954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AuxiliaryMachineEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.AuxiliaryMachineEntityId);
			}
			if (this.HackingEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.HackingEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014815 RID: 83989 RVA: 0x002FB3A8 File Offset: 0x002F95A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AuxiliaryMachineEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AuxiliaryMachineEntityId);
			}
			if (this.HackingEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HackingEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014816 RID: 83990 RVA: 0x002FB400 File Offset: 0x002F9600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveHackingEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AuxiliaryMachineEntityId != 0L)
			{
				this.AuxiliaryMachineEntityId = other.AuxiliaryMachineEntityId;
			}
			if (other.HackingEntityId != 0L)
			{
				this.HackingEntityId = other.HackingEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014817 RID: 83991 RVA: 0x002FB450 File Offset: 0x002F9650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014818 RID: 83992 RVA: 0x002FB45C File Offset: 0x002F965C
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
				if (num != 64U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HackingEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.AuxiliaryMachineEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007CBD RID: 31933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CBE RID: 31934
		public const int AuxiliaryMachineEntityIdFieldNumber = 8;

		// Token: 0x04007CBF RID: 31935
		private long auxiliaryMachineEntityId_;

		// Token: 0x04007CC0 RID: 31936
		public const int HackingEntityIdFieldNumber = 12;

		// Token: 0x04007CC1 RID: 31937
		private long hackingEntityId_;
	}
}
