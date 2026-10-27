using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B46 RID: 2886
	[NetMessage(EMessageId.NewTowerRoleEnergyRequest)]
	public sealed class NewTowerRoleEnergyRequest : IMessage<NewTowerRoleEnergyRequest>, IMessage, IEquatable<NewTowerRoleEnergyRequest>, IDeepCloneable<NewTowerRoleEnergyRequest>, IBufferMessage
	{
		// Token: 0x0600FA65 RID: 64101 RVA: 0x00248379 File Offset: 0x00246579
		[NullableContext(1)]
		public static NewTowerRoleEnergyRequest Create()
		{
			return new NewTowerRoleEnergyRequest();
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600FA66 RID: 64102 RVA: 0x00248380 File Offset: 0x00246580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600FA67 RID: 64103 RVA: 0x00248383 File Offset: 0x00246583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRoleEnergyRequest.Descriptor;
			}
		}

		// Token: 0x0600FA68 RID: 64104 RVA: 0x0024838A File Offset: 0x0024658A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyRequest()
		{
		}

		// Token: 0x0600FA69 RID: 64105 RVA: 0x00248392 File Offset: 0x00246592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyRequest(NewTowerRoleEnergyRequest other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA6A RID: 64106 RVA: 0x002483B7 File Offset: 0x002465B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyRequest Clone()
		{
			return new NewTowerRoleEnergyRequest(this);
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600FA6B RID: 64107 RVA: 0x002483BF File Offset: 0x002465BF
		// (set) Token: 0x0600FA6C RID: 64108 RVA: 0x002483C7 File Offset: 0x002465C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x0600FA6D RID: 64109 RVA: 0x002483D0 File Offset: 0x002465D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRoleEnergyRequest);
		}

		// Token: 0x0600FA6E RID: 64110 RVA: 0x002483DE File Offset: 0x002465DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRoleEnergyRequest other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA6F RID: 64111 RVA: 0x0024840C File Offset: 0x0024660C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA70 RID: 64112 RVA: 0x0024844B File Offset: 0x0024664B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA71 RID: 64113 RVA: 0x00248458 File Offset: 0x00246658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA72 RID: 64114 RVA: 0x00248461 File Offset: 0x00246661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CycleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA73 RID: 64115 RVA: 0x00248494 File Offset: 0x00246694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA74 RID: 64116 RVA: 0x002484D2 File Offset: 0x002466D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRoleEnergyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA75 RID: 64117 RVA: 0x00248503 File Offset: 0x00246703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA76 RID: 64118 RVA: 0x0024850C File Offset: 0x0024670C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CycleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006443 RID: 25667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006444 RID: 25668
		public const int CycleIdFieldNumber = 8;

		// Token: 0x04006445 RID: 25669
		private int cycleId_;
	}
}
