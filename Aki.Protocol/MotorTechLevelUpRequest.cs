using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAB RID: 2731
	[NetMessage(EMessageId.MotorTechLevelUpRequest)]
	public sealed class MotorTechLevelUpRequest : IMessage<MotorTechLevelUpRequest>, IMessage, IEquatable<MotorTechLevelUpRequest>, IDeepCloneable<MotorTechLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600EDB8 RID: 60856 RVA: 0x0022B311 File Offset: 0x00229511
		[NullableContext(1)]
		public static MotorTechLevelUpRequest Create()
		{
			return new MotorTechLevelUpRequest();
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x0022B318 File Offset: 0x00229518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0600EDBA RID: 60858 RVA: 0x0022B31B File Offset: 0x0022951B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600EDBB RID: 60859 RVA: 0x0022B322 File Offset: 0x00229522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpRequest()
		{
		}

		// Token: 0x0600EDBC RID: 60860 RVA: 0x0022B32A File Offset: 0x0022952A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpRequest(MotorTechLevelUpRequest other) : this()
		{
			this.techId_ = other.techId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDBD RID: 60861 RVA: 0x0022B34F File Offset: 0x0022954F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpRequest Clone()
		{
			return new MotorTechLevelUpRequest(this);
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0600EDBE RID: 60862 RVA: 0x0022B357 File Offset: 0x00229557
		// (set) Token: 0x0600EDBF RID: 60863 RVA: 0x0022B35F File Offset: 0x0022955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TechId
		{
			get
			{
				return this.techId_;
			}
			set
			{
				this.techId_ = value;
			}
		}

		// Token: 0x0600EDC0 RID: 60864 RVA: 0x0022B368 File Offset: 0x00229568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechLevelUpRequest);
		}

		// Token: 0x0600EDC1 RID: 60865 RVA: 0x0022B376 File Offset: 0x00229576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechLevelUpRequest other)
		{
			return other != null && (other == this || (this.TechId == other.TechId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDC2 RID: 60866 RVA: 0x0022B3A4 File Offset: 0x002295A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TechId != 0)
			{
				num ^= this.TechId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EDC3 RID: 60867 RVA: 0x0022B3E3 File Offset: 0x002295E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDC4 RID: 60868 RVA: 0x0022B3F0 File Offset: 0x002295F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDC5 RID: 60869 RVA: 0x0022B3F9 File Offset: 0x002295F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TechId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TechId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EDC6 RID: 60870 RVA: 0x0022B42C File Offset: 0x0022962C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TechId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TechId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EDC7 RID: 60871 RVA: 0x0022B46A File Offset: 0x0022966A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TechId != 0)
			{
				this.TechId = other.TechId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EDC8 RID: 60872 RVA: 0x0022B49B File Offset: 0x0022969B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDC9 RID: 60873 RVA: 0x0022B4A4 File Offset: 0x002296A4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TechId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006041 RID: 24641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006042 RID: 24642
		public const int TechIdFieldNumber = 13;

		// Token: 0x04006043 RID: 24643
		private int techId_;
	}
}
