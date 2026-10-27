using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EED RID: 3821
	public sealed class RelativeMoveReplaySample : IMessage<RelativeMoveReplaySample>, IMessage, IEquatable<RelativeMoveReplaySample>, IDeepCloneable<RelativeMoveReplaySample>, IBufferMessage
	{
		// Token: 0x0601479C RID: 83868 RVA: 0x002F99ED File Offset: 0x002F7BED
		[NullableContext(1)]
		public static RelativeMoveReplaySample Create()
		{
			return new RelativeMoveReplaySample();
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x0601479D RID: 83869 RVA: 0x002F99F4 File Offset: 0x002F7BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x0601479E RID: 83870 RVA: 0x002F99F7 File Offset: 0x002F7BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelativeMoveReplaySample.Descriptor;
			}
		}

		// Token: 0x0601479F RID: 83871 RVA: 0x002F99FE File Offset: 0x002F7BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample()
		{
		}

		// Token: 0x060147A0 RID: 83872 RVA: 0x002F9A08 File Offset: 0x002F7C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample(RelativeMoveReplaySample other) : this()
		{
			this.baseMovementEntityId_ = other.baseMovementEntityId_;
			this.relativeLocation_ = ((other.relativeLocation_ != null) ? other.relativeLocation_.Clone() : null);
			this.relativeRotation_ = ((other.relativeRotation_ != null) ? other.relativeRotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147A1 RID: 83873 RVA: 0x002F9A70 File Offset: 0x002F7C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample Clone()
		{
			return new RelativeMoveReplaySample(this);
		}

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x060147A2 RID: 83874 RVA: 0x002F9A78 File Offset: 0x002F7C78
		// (set) Token: 0x060147A3 RID: 83875 RVA: 0x002F9A80 File Offset: 0x002F7C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BaseMovementEntityId
		{
			get
			{
				return this.baseMovementEntityId_;
			}
			set
			{
				this.baseMovementEntityId_ = value;
			}
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x060147A4 RID: 83876 RVA: 0x002F9A89 File Offset: 0x002F7C89
		// (set) Token: 0x060147A5 RID: 83877 RVA: 0x002F9A91 File Offset: 0x002F7C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector RelativeLocation
		{
			get
			{
				return this.relativeLocation_;
			}
			set
			{
				this.relativeLocation_ = value;
			}
		}

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x060147A6 RID: 83878 RVA: 0x002F9A9A File Offset: 0x002F7C9A
		// (set) Token: 0x060147A7 RID: 83879 RVA: 0x002F9AA2 File Offset: 0x002F7CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator RelativeRotation
		{
			get
			{
				return this.relativeRotation_;
			}
			set
			{
				this.relativeRotation_ = value;
			}
		}

		// Token: 0x060147A8 RID: 83880 RVA: 0x002F9AAB File Offset: 0x002F7CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelativeMoveReplaySample);
		}

		// Token: 0x060147A9 RID: 83881 RVA: 0x002F9ABC File Offset: 0x002F7CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelativeMoveReplaySample other)
		{
			return other != null && (other == this || (this.BaseMovementEntityId == other.BaseMovementEntityId && object.Equals(this.RelativeLocation, other.RelativeLocation) && object.Equals(this.RelativeRotation, other.RelativeRotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147AA RID: 83882 RVA: 0x002F9B20 File Offset: 0x002F7D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseMovementEntityId != 0L)
			{
				num ^= this.BaseMovementEntityId.GetHashCode();
			}
			if (this.relativeLocation_ != null)
			{
				num ^= this.RelativeLocation.GetHashCode();
			}
			if (this.relativeRotation_ != null)
			{
				num ^= this.RelativeRotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060147AB RID: 83883 RVA: 0x002F9B8B File Offset: 0x002F7D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147AC RID: 83884 RVA: 0x002F9B98 File Offset: 0x002F7D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147AD RID: 83885 RVA: 0x002F9BA4 File Offset: 0x002F7DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BaseMovementEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BaseMovementEntityId);
			}
			if (this.relativeLocation_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RelativeLocation);
			}
			if (this.relativeRotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RelativeRotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147AE RID: 83886 RVA: 0x002F9C18 File Offset: 0x002F7E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseMovementEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BaseMovementEntityId);
			}
			if (this.relativeLocation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelativeLocation);
			}
			if (this.relativeRotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelativeRotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060147AF RID: 83887 RVA: 0x002F9C88 File Offset: 0x002F7E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelativeMoveReplaySample other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseMovementEntityId != 0L)
			{
				this.BaseMovementEntityId = other.BaseMovementEntityId;
			}
			if (other.relativeLocation_ != null)
			{
				if (this.relativeLocation_ == null)
				{
					this.RelativeLocation = new Vector();
				}
				this.RelativeLocation.MergeFrom(other.RelativeLocation);
			}
			if (other.relativeRotation_ != null)
			{
				if (this.relativeRotation_ == null)
				{
					this.RelativeRotation = new Rotator();
				}
				this.RelativeRotation.MergeFrom(other.RelativeRotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060147B0 RID: 83888 RVA: 0x002F9D1C File Offset: 0x002F7F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147B1 RID: 83889 RVA: 0x002F9D28 File Offset: 0x002F7F28
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.relativeRotation_ == null)
							{
								this.RelativeRotation = new Rotator();
							}
							input.ReadMessage(this.RelativeRotation);
						}
					}
					else
					{
						if (this.relativeLocation_ == null)
						{
							this.RelativeLocation = new Vector();
						}
						input.ReadMessage(this.RelativeLocation);
					}
				}
				else
				{
					this.BaseMovementEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007C31 RID: 31793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C32 RID: 31794
		public const int BaseMovementEntityIdFieldNumber = 1;

		// Token: 0x04007C33 RID: 31795
		private long baseMovementEntityId_;

		// Token: 0x04007C34 RID: 31796
		public const int RelativeLocationFieldNumber = 2;

		// Token: 0x04007C35 RID: 31797
		private Vector relativeLocation_;

		// Token: 0x04007C36 RID: 31798
		public const int RelativeRotationFieldNumber = 3;

		// Token: 0x04007C37 RID: 31799
		private Rotator relativeRotation_;
	}
}
