using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A7 RID: 167
	[NetMessage(EMessageId.AddHackingEntityNotify)]
	public sealed class AddHackingEntityNotify : IMessage<AddHackingEntityNotify>, IMessage, IEquatable<AddHackingEntityNotify>, IDeepCloneable<AddHackingEntityNotify>, IBufferMessage
	{
		// Token: 0x06001CFE RID: 7422 RVA: 0x00050275 File Offset: 0x0004E475
		[NullableContext(1)]
		public static AddHackingEntityNotify Create()
		{
			return new AddHackingEntityNotify();
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0005027C File Offset: 0x0004E47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0005027F File Offset: 0x0004E47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddHackingEntityNotify.Descriptor;
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00050286 File Offset: 0x0004E486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddHackingEntityNotify()
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0005028E File Offset: 0x0004E48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddHackingEntityNotify(AddHackingEntityNotify other) : this()
		{
			this.auxiliaryMachineEntityId_ = other.auxiliaryMachineEntityId_;
			this.hackingEntityId_ = other.hackingEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000502BF File Offset: 0x0004E4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddHackingEntityNotify Clone()
		{
			return new AddHackingEntityNotify(this);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000502C7 File Offset: 0x0004E4C7
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x000502CF File Offset: 0x0004E4CF
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000502D8 File Offset: 0x0004E4D8
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x000502E0 File Offset: 0x0004E4E0
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

		// Token: 0x06001D08 RID: 7432 RVA: 0x000502E9 File Offset: 0x0004E4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddHackingEntityNotify);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000502F7 File Offset: 0x0004E4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddHackingEntityNotify other)
		{
			return other != null && (other == this || (this.AuxiliaryMachineEntityId == other.AuxiliaryMachineEntityId && this.HackingEntityId == other.HackingEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00050338 File Offset: 0x0004E538
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

		// Token: 0x06001D0B RID: 7435 RVA: 0x00050390 File Offset: 0x0004E590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0005039D File Offset: 0x0004E59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000503A8 File Offset: 0x0004E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HackingEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.HackingEntityId);
			}
			if (this.AuxiliaryMachineEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.AuxiliaryMachineEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00050404 File Offset: 0x0004E604
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

		// Token: 0x06001D0F RID: 7439 RVA: 0x0005045C File Offset: 0x0004E65C
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

		// Token: 0x06001D10 RID: 7440 RVA: 0x000504AC File Offset: 0x0004E6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000504B8 File Offset: 0x0004E6B8
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
				if (num != 80U)
				{
					if (num != 88U)
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

		// Token: 0x0400234F RID: 9039
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002350 RID: 9040
		public const int AuxiliaryMachineEntityIdFieldNumber = 11;

		// Token: 0x04002351 RID: 9041
		private long auxiliaryMachineEntityId_;

		// Token: 0x04002352 RID: 9042
		public const int HackingEntityIdFieldNumber = 10;

		// Token: 0x04002353 RID: 9043
		private long hackingEntityId_;
	}
}
