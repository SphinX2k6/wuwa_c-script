using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8E RID: 2702
	[NetMessage(EMessageId.MotorSliderRequest)]
	public sealed class MotorSliderRequest : IMessage<MotorSliderRequest>, IMessage, IEquatable<MotorSliderRequest>, IDeepCloneable<MotorSliderRequest>, IBufferMessage
	{
		// Token: 0x0600EBA3 RID: 60323 RVA: 0x00226E17 File Offset: 0x00225017
		[NullableContext(1)]
		public static MotorSliderRequest Create()
		{
			return new MotorSliderRequest();
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0600EBA4 RID: 60324 RVA: 0x00226E1E File Offset: 0x0022501E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0600EBA5 RID: 60325 RVA: 0x00226E21 File Offset: 0x00225021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSliderRequest.Descriptor;
			}
		}

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x00226E28 File Offset: 0x00225028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderRequest()
		{
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x00226E30 File Offset: 0x00225030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderRequest(MotorSliderRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.interactType_ = other.interactType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x00226E61 File Offset: 0x00225061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderRequest Clone()
		{
			return new MotorSliderRequest(this);
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0600EBA9 RID: 60329 RVA: 0x00226E69 File Offset: 0x00225069
		// (set) Token: 0x0600EBAA RID: 60330 RVA: 0x00226E71 File Offset: 0x00225071
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

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0600EBAB RID: 60331 RVA: 0x00226E7A File Offset: 0x0022507A
		// (set) Token: 0x0600EBAC RID: 60332 RVA: 0x00226E82 File Offset: 0x00225082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderInteractType InteractType
		{
			get
			{
				return this.interactType_;
			}
			set
			{
				this.interactType_ = value;
			}
		}

		// Token: 0x0600EBAD RID: 60333 RVA: 0x00226E8B File Offset: 0x0022508B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSliderRequest);
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x00226E99 File Offset: 0x00225099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSliderRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InteractType == other.InteractType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBAF RID: 60335 RVA: 0x00226ED8 File Offset: 0x002250D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.InteractType != MotorSliderInteractType.Enter)
			{
				num ^= this.InteractType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EBB0 RID: 60336 RVA: 0x00226F36 File Offset: 0x00225136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBB1 RID: 60337 RVA: 0x00226F43 File Offset: 0x00225143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBB2 RID: 60338 RVA: 0x00226F4C File Offset: 0x0022514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractType != MotorSliderInteractType.Enter)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.InteractType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x00226FA4 File Offset: 0x002251A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.InteractType != MotorSliderInteractType.Enter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.InteractType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x00226FFC File Offset: 0x002251FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorSliderRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.InteractType != MotorSliderInteractType.Enter)
			{
				this.InteractType = other.InteractType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x0022704C File Offset: 0x0022524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x00227058 File Offset: 0x00225258
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
					if (num != 112U)
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
					this.InteractType = (MotorSliderInteractType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006000 RID: 24576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006001 RID: 24577
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04006002 RID: 24578
		private long entityId_;

		// Token: 0x04006003 RID: 24579
		public const int InteractTypeFieldNumber = 1;

		// Token: 0x04006004 RID: 24580
		private MotorSliderInteractType interactType_;
	}
}
