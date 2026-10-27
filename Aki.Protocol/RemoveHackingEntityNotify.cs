using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFD RID: 3837
	[NetMessage(EMessageId.RemoveHackingEntityNotify)]
	public sealed class RemoveHackingEntityNotify : IMessage<RemoveHackingEntityNotify>, IMessage, IEquatable<RemoveHackingEntityNotify>, IDeepCloneable<RemoveHackingEntityNotify>, IBufferMessage
	{
		// Token: 0x060148EA RID: 84202 RVA: 0x002FC8D5 File Offset: 0x002FAAD5
		[NullableContext(1)]
		public static RemoveHackingEntityNotify Create()
		{
			return new RemoveHackingEntityNotify();
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x060148EB RID: 84203 RVA: 0x002FC8DC File Offset: 0x002FAADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x060148EC RID: 84204 RVA: 0x002FC8DF File Offset: 0x002FAADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveHackingEntityNotify.Descriptor;
			}
		}

		// Token: 0x060148ED RID: 84205 RVA: 0x002FC8E6 File Offset: 0x002FAAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveHackingEntityNotify()
		{
		}

		// Token: 0x060148EE RID: 84206 RVA: 0x002FC8EE File Offset: 0x002FAAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveHackingEntityNotify(RemoveHackingEntityNotify other) : this()
		{
			this.auxiliaryMachineEntityId_ = other.auxiliaryMachineEntityId_;
			this.hackingEntityId_ = other.hackingEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148EF RID: 84207 RVA: 0x002FC91F File Offset: 0x002FAB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveHackingEntityNotify Clone()
		{
			return new RemoveHackingEntityNotify(this);
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x060148F0 RID: 84208 RVA: 0x002FC927 File Offset: 0x002FAB27
		// (set) Token: 0x060148F1 RID: 84209 RVA: 0x002FC92F File Offset: 0x002FAB2F
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

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x060148F2 RID: 84210 RVA: 0x002FC938 File Offset: 0x002FAB38
		// (set) Token: 0x060148F3 RID: 84211 RVA: 0x002FC940 File Offset: 0x002FAB40
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

		// Token: 0x060148F4 RID: 84212 RVA: 0x002FC949 File Offset: 0x002FAB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveHackingEntityNotify);
		}

		// Token: 0x060148F5 RID: 84213 RVA: 0x002FC957 File Offset: 0x002FAB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveHackingEntityNotify other)
		{
			return other != null && (other == this || (this.AuxiliaryMachineEntityId == other.AuxiliaryMachineEntityId && this.HackingEntityId == other.HackingEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148F6 RID: 84214 RVA: 0x002FC998 File Offset: 0x002FAB98
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

		// Token: 0x060148F7 RID: 84215 RVA: 0x002FC9F0 File Offset: 0x002FABF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148F8 RID: 84216 RVA: 0x002FC9FD File Offset: 0x002FABFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148F9 RID: 84217 RVA: 0x002FCA08 File Offset: 0x002FAC08
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
				output.WriteRawTag(104);
				output.WriteInt64(this.HackingEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148FA RID: 84218 RVA: 0x002FCA64 File Offset: 0x002FAC64
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

		// Token: 0x060148FB RID: 84219 RVA: 0x002FCABC File Offset: 0x002FACBC
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

		// Token: 0x060148FC RID: 84220 RVA: 0x002FCB0C File Offset: 0x002FAD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148FD RID: 84221 RVA: 0x002FCB18 File Offset: 0x002FAD18
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
					if (num != 104U)
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

		// Token: 0x04007C93 RID: 31891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C94 RID: 31892
		public const int AuxiliaryMachineEntityIdFieldNumber = 8;

		// Token: 0x04007C95 RID: 31893
		private long auxiliaryMachineEntityId_;

		// Token: 0x04007C96 RID: 31894
		public const int HackingEntityIdFieldNumber = 13;

		// Token: 0x04007C97 RID: 31895
		private long hackingEntityId_;
	}
}
