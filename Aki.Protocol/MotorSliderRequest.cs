using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9F RID: 2719
	[NetMessage(EMessageId.MotorSliderRequest)]
	public sealed class MotorSliderRequest : IMessage<MotorSliderRequest>, IMessage, IEquatable<MotorSliderRequest>, IDeepCloneable<MotorSliderRequest>, IBufferMessage
	{
		// Token: 0x0600ECBD RID: 60605 RVA: 0x0022900F File Offset: 0x0022720F
		[NullableContext(1)]
		public static MotorSliderRequest Create()
		{
			return new MotorSliderRequest();
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0600ECBE RID: 60606 RVA: 0x00229016 File Offset: 0x00227216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0600ECBF RID: 60607 RVA: 0x00229019 File Offset: 0x00227219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSliderRequest.Descriptor;
			}
		}

		// Token: 0x0600ECC0 RID: 60608 RVA: 0x00229020 File Offset: 0x00227220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderRequest()
		{
		}

		// Token: 0x0600ECC1 RID: 60609 RVA: 0x00229028 File Offset: 0x00227228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderRequest(MotorSliderRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.interactType_ = other.interactType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECC2 RID: 60610 RVA: 0x00229059 File Offset: 0x00227259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderRequest Clone()
		{
			return new MotorSliderRequest(this);
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600ECC3 RID: 60611 RVA: 0x00229061 File Offset: 0x00227261
		// (set) Token: 0x0600ECC4 RID: 60612 RVA: 0x00229069 File Offset: 0x00227269
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

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600ECC5 RID: 60613 RVA: 0x00229072 File Offset: 0x00227272
		// (set) Token: 0x0600ECC6 RID: 60614 RVA: 0x0022907A File Offset: 0x0022727A
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

		// Token: 0x0600ECC7 RID: 60615 RVA: 0x00229083 File Offset: 0x00227283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSliderRequest);
		}

		// Token: 0x0600ECC8 RID: 60616 RVA: 0x00229091 File Offset: 0x00227291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSliderRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InteractType == other.InteractType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECC9 RID: 60617 RVA: 0x002290D0 File Offset: 0x002272D0
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

		// Token: 0x0600ECCA RID: 60618 RVA: 0x0022912E File Offset: 0x0022732E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECCB RID: 60619 RVA: 0x0022913B File Offset: 0x0022733B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECCC RID: 60620 RVA: 0x00229144 File Offset: 0x00227344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractType != MotorSliderInteractType.Enter)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.InteractType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECCD RID: 60621 RVA: 0x002291A0 File Offset: 0x002273A0
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

		// Token: 0x0600ECCE RID: 60622 RVA: 0x002291F8 File Offset: 0x002273F8
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

		// Token: 0x0600ECCF RID: 60623 RVA: 0x00229248 File Offset: 0x00227448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECD0 RID: 60624 RVA: 0x00229254 File Offset: 0x00227454
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
				if (num != 32U)
				{
					if (num != 96U)
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

		// Token: 0x04005FF7 RID: 24567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FF8 RID: 24568
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04005FF9 RID: 24569
		private long entityId_;

		// Token: 0x04005FFA RID: 24570
		public const int InteractTypeFieldNumber = 4;

		// Token: 0x04005FFB RID: 24571
		private MotorSliderInteractType interactType_;
	}
}
