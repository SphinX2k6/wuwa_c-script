using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDD RID: 3805
	public sealed class RelativeMoveReplaySample : IMessage<RelativeMoveReplaySample>, IMessage, IEquatable<RelativeMoveReplaySample>, IDeepCloneable<RelativeMoveReplaySample>, IBufferMessage
	{
		// Token: 0x060146B7 RID: 83639 RVA: 0x002F8334 File Offset: 0x002F6534
		[NullableContext(1)]
		public static RelativeMoveReplaySample Create()
		{
			return new RelativeMoveReplaySample();
		}

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x060146B8 RID: 83640 RVA: 0x002F833B File Offset: 0x002F653B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x060146B9 RID: 83641 RVA: 0x002F833E File Offset: 0x002F653E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelativeMoveReplaySample.Descriptor;
			}
		}

		// Token: 0x060146BA RID: 83642 RVA: 0x002F8345 File Offset: 0x002F6545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample()
		{
		}

		// Token: 0x060146BB RID: 83643 RVA: 0x002F8350 File Offset: 0x002F6550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample(RelativeMoveReplaySample other) : this()
		{
			this.baseMovementEntityId_ = other.baseMovementEntityId_;
			this.relativeLocation_ = ((other.relativeLocation_ != null) ? other.relativeLocation_.Clone() : null);
			this.relativeRotation_ = ((other.relativeRotation_ != null) ? other.relativeRotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146BC RID: 83644 RVA: 0x002F83B8 File Offset: 0x002F65B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample Clone()
		{
			return new RelativeMoveReplaySample(this);
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x060146BD RID: 83645 RVA: 0x002F83C0 File Offset: 0x002F65C0
		// (set) Token: 0x060146BE RID: 83646 RVA: 0x002F83C8 File Offset: 0x002F65C8
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

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x060146BF RID: 83647 RVA: 0x002F83D1 File Offset: 0x002F65D1
		// (set) Token: 0x060146C0 RID: 83648 RVA: 0x002F83D9 File Offset: 0x002F65D9
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

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x060146C1 RID: 83649 RVA: 0x002F83E2 File Offset: 0x002F65E2
		// (set) Token: 0x060146C2 RID: 83650 RVA: 0x002F83EA File Offset: 0x002F65EA
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

		// Token: 0x060146C3 RID: 83651 RVA: 0x002F83F3 File Offset: 0x002F65F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelativeMoveReplaySample);
		}

		// Token: 0x060146C4 RID: 83652 RVA: 0x002F8404 File Offset: 0x002F6604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelativeMoveReplaySample other)
		{
			return other != null && (other == this || (this.BaseMovementEntityId == other.BaseMovementEntityId && object.Equals(this.RelativeLocation, other.RelativeLocation) && object.Equals(this.RelativeRotation, other.RelativeRotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146C5 RID: 83653 RVA: 0x002F8468 File Offset: 0x002F6668
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

		// Token: 0x060146C6 RID: 83654 RVA: 0x002F84D3 File Offset: 0x002F66D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146C7 RID: 83655 RVA: 0x002F84E0 File Offset: 0x002F66E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146C8 RID: 83656 RVA: 0x002F84EC File Offset: 0x002F66EC
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

		// Token: 0x060146C9 RID: 83657 RVA: 0x002F8560 File Offset: 0x002F6760
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

		// Token: 0x060146CA RID: 83658 RVA: 0x002F85D0 File Offset: 0x002F67D0
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

		// Token: 0x060146CB RID: 83659 RVA: 0x002F8664 File Offset: 0x002F6864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146CC RID: 83660 RVA: 0x002F8670 File Offset: 0x002F6870
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

		// Token: 0x04007C5B RID: 31835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C5C RID: 31836
		public const int BaseMovementEntityIdFieldNumber = 1;

		// Token: 0x04007C5D RID: 31837
		private long baseMovementEntityId_;

		// Token: 0x04007C5E RID: 31838
		public const int RelativeLocationFieldNumber = 2;

		// Token: 0x04007C5F RID: 31839
		private Vector relativeLocation_;

		// Token: 0x04007C60 RID: 31840
		public const int RelativeRotationFieldNumber = 3;

		// Token: 0x04007C61 RID: 31841
		private Rotator relativeRotation_;
	}
}
