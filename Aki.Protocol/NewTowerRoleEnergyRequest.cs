using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B35 RID: 2869
	[NetMessage(EMessageId.NewTowerRoleEnergyRequest)]
	public sealed class NewTowerRoleEnergyRequest : IMessage<NewTowerRoleEnergyRequest>, IMessage, IEquatable<NewTowerRoleEnergyRequest>, IDeepCloneable<NewTowerRoleEnergyRequest>, IBufferMessage
	{
		// Token: 0x0600F94B RID: 63819 RVA: 0x00246161 File Offset: 0x00244361
		[NullableContext(1)]
		public static NewTowerRoleEnergyRequest Create()
		{
			return new NewTowerRoleEnergyRequest();
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600F94C RID: 63820 RVA: 0x00246168 File Offset: 0x00244368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600F94D RID: 63821 RVA: 0x0024616B File Offset: 0x0024436B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRoleEnergyRequest.Descriptor;
			}
		}

		// Token: 0x0600F94E RID: 63822 RVA: 0x00246172 File Offset: 0x00244372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyRequest()
		{
		}

		// Token: 0x0600F94F RID: 63823 RVA: 0x0024617A File Offset: 0x0024437A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyRequest(NewTowerRoleEnergyRequest other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F950 RID: 63824 RVA: 0x0024619F File Offset: 0x0024439F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyRequest Clone()
		{
			return new NewTowerRoleEnergyRequest(this);
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600F951 RID: 63825 RVA: 0x002461A7 File Offset: 0x002443A7
		// (set) Token: 0x0600F952 RID: 63826 RVA: 0x002461AF File Offset: 0x002443AF
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

		// Token: 0x0600F953 RID: 63827 RVA: 0x002461B8 File Offset: 0x002443B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRoleEnergyRequest);
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x002461C6 File Offset: 0x002443C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRoleEnergyRequest other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x002461F4 File Offset: 0x002443F4
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

		// Token: 0x0600F956 RID: 63830 RVA: 0x00246233 File Offset: 0x00244433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x00246240 File Offset: 0x00244440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x00246249 File Offset: 0x00244449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CycleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F959 RID: 63833 RVA: 0x0024627C File Offset: 0x0024447C
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

		// Token: 0x0600F95A RID: 63834 RVA: 0x002462BA File Offset: 0x002444BA
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

		// Token: 0x0600F95B RID: 63835 RVA: 0x002462EB File Offset: 0x002444EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F95C RID: 63836 RVA: 0x002462F4 File Offset: 0x002444F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CycleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400644C RID: 25676
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400644D RID: 25677
		public const int CycleIdFieldNumber = 2;

		// Token: 0x0400644E RID: 25678
		private int cycleId_;
	}
}
