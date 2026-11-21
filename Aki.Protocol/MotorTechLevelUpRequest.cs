using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9A RID: 2714
	[NetMessage(EMessageId.MotorTechLevelUpRequest)]
	public sealed class MotorTechLevelUpRequest : IMessage<MotorTechLevelUpRequest>, IMessage, IEquatable<MotorTechLevelUpRequest>, IDeepCloneable<MotorTechLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600EC9E RID: 60574 RVA: 0x00229115 File Offset: 0x00227315
		[NullableContext(1)]
		public static MotorTechLevelUpRequest Create()
		{
			return new MotorTechLevelUpRequest();
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0600EC9F RID: 60575 RVA: 0x0022911C File Offset: 0x0022731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0600ECA0 RID: 60576 RVA: 0x0022911F File Offset: 0x0022731F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x00229126 File Offset: 0x00227326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpRequest()
		{
		}

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x0022912E File Offset: 0x0022732E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpRequest(MotorTechLevelUpRequest other) : this()
		{
			this.techId_ = other.techId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x00229153 File Offset: 0x00227353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpRequest Clone()
		{
			return new MotorTechLevelUpRequest(this);
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600ECA4 RID: 60580 RVA: 0x0022915B File Offset: 0x0022735B
		// (set) Token: 0x0600ECA5 RID: 60581 RVA: 0x00229163 File Offset: 0x00227363
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

		// Token: 0x0600ECA6 RID: 60582 RVA: 0x0022916C File Offset: 0x0022736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechLevelUpRequest);
		}

		// Token: 0x0600ECA7 RID: 60583 RVA: 0x0022917A File Offset: 0x0022737A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechLevelUpRequest other)
		{
			return other != null && (other == this || (this.TechId == other.TechId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECA8 RID: 60584 RVA: 0x002291A8 File Offset: 0x002273A8
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

		// Token: 0x0600ECA9 RID: 60585 RVA: 0x002291E7 File Offset: 0x002273E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECAA RID: 60586 RVA: 0x002291F4 File Offset: 0x002273F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECAB RID: 60587 RVA: 0x002291FD File Offset: 0x002273FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TechId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TechId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECAC RID: 60588 RVA: 0x00229230 File Offset: 0x00227430
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

		// Token: 0x0600ECAD RID: 60589 RVA: 0x0022926E File Offset: 0x0022746E
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

		// Token: 0x0600ECAE RID: 60590 RVA: 0x0022929F File Offset: 0x0022749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECAF RID: 60591 RVA: 0x002292A8 File Offset: 0x002274A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TechId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400604A RID: 24650
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400604B RID: 24651
		public const int TechIdFieldNumber = 10;

		// Token: 0x0400604C RID: 24652
		private int techId_;
	}
}
