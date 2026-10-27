using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A6 RID: 166
	[NetMessage(EMessageId.AddHackingEntityNotify)]
	public sealed class AddHackingEntityNotify : IMessage<AddHackingEntityNotify>, IMessage, IEquatable<AddHackingEntityNotify>, IDeepCloneable<AddHackingEntityNotify>, IBufferMessage
	{
		// Token: 0x06001CB7 RID: 7351 RVA: 0x0004F665 File Offset: 0x0004D865
		[NullableContext(1)]
		public static AddHackingEntityNotify Create()
		{
			return new AddHackingEntityNotify();
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0004F66C File Offset: 0x0004D86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0004F66F File Offset: 0x0004D86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddHackingEntityNotify.Descriptor;
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0004F676 File Offset: 0x0004D876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddHackingEntityNotify()
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0004F67E File Offset: 0x0004D87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddHackingEntityNotify(AddHackingEntityNotify other) : this()
		{
			this.auxiliaryMachineEntityId_ = other.auxiliaryMachineEntityId_;
			this.hackingEntityId_ = other.hackingEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0004F6AF File Offset: 0x0004D8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddHackingEntityNotify Clone()
		{
			return new AddHackingEntityNotify(this);
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0004F6B7 File Offset: 0x0004D8B7
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0004F6BF File Offset: 0x0004D8BF
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0004F6D0 File Offset: 0x0004D8D0
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

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0004F6D9 File Offset: 0x0004D8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddHackingEntityNotify);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0004F6E7 File Offset: 0x0004D8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddHackingEntityNotify other)
		{
			return other != null && (other == this || (this.AuxiliaryMachineEntityId == other.AuxiliaryMachineEntityId && this.HackingEntityId == other.HackingEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0004F728 File Offset: 0x0004D928
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

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0004F780 File Offset: 0x0004D980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0004F78D File Offset: 0x0004D98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0004F798 File Offset: 0x0004D998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HackingEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.HackingEntityId);
			}
			if (this.AuxiliaryMachineEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.AuxiliaryMachineEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0004F7F0 File Offset: 0x0004D9F0
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

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0004F848 File Offset: 0x0004DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddHackingEntityNotify other)
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

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0004F898 File Offset: 0x0004DA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0004F8A4 File Offset: 0x0004DAA4
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AuxiliaryMachineEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.HackingEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040022EE RID: 8942
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022EF RID: 8943
		public const int AuxiliaryMachineEntityIdFieldNumber = 13;

		// Token: 0x040022F0 RID: 8944
		private long auxiliaryMachineEntityId_;

		// Token: 0x040022F1 RID: 8945
		public const int HackingEntityIdFieldNumber = 1;

		// Token: 0x040022F2 RID: 8946
		private long hackingEntityId_;
	}
}
