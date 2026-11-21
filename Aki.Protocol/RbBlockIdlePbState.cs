using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E76 RID: 3702
	public sealed class RbBlockIdlePbState : IMessage<RbBlockIdlePbState>, IMessage, IEquatable<RbBlockIdlePbState>, IDeepCloneable<RbBlockIdlePbState>, IBufferMessage
	{
		// Token: 0x06013EA5 RID: 81573 RVA: 0x002E7435 File Offset: 0x002E5635
		[NullableContext(1)]
		public static RbBlockIdlePbState Create()
		{
			return new RbBlockIdlePbState();
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x06013EA6 RID: 81574 RVA: 0x002E743C File Offset: 0x002E563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x06013EA7 RID: 81575 RVA: 0x002E743F File Offset: 0x002E563F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockIdlePbState.Descriptor;
			}
		}

		// Token: 0x06013EA8 RID: 81576 RVA: 0x002E7446 File Offset: 0x002E5646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState()
		{
		}

		// Token: 0x06013EA9 RID: 81577 RVA: 0x002E7450 File Offset: 0x002E5650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState(RbBlockIdlePbState other) : this()
		{
			this.position_ = ((other.position_ != null) ? other.position_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013EAA RID: 81578 RVA: 0x002E74AC File Offset: 0x002E56AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState Clone()
		{
			return new RbBlockIdlePbState(this);
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x06013EAB RID: 81579 RVA: 0x002E74B4 File Offset: 0x002E56B4
		// (set) Token: 0x06013EAC RID: 81580 RVA: 0x002E74BC File Offset: 0x002E56BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x06013EAD RID: 81581 RVA: 0x002E74C5 File Offset: 0x002E56C5
		// (set) Token: 0x06013EAE RID: 81582 RVA: 0x002E74CD File Offset: 0x002E56CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x06013EAF RID: 81583 RVA: 0x002E74D6 File Offset: 0x002E56D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockIdlePbState);
		}

		// Token: 0x06013EB0 RID: 81584 RVA: 0x002E74E4 File Offset: 0x002E56E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockIdlePbState other)
		{
			return other != null && (other == this || (object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013EB1 RID: 81585 RVA: 0x002E7538 File Offset: 0x002E5738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.position_ != null)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013EB2 RID: 81586 RVA: 0x002E758A File Offset: 0x002E578A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EB3 RID: 81587 RVA: 0x002E7597 File Offset: 0x002E5797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013EB4 RID: 81588 RVA: 0x002E75A0 File Offset: 0x002E57A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.position_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Position);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EB5 RID: 81589 RVA: 0x002E75FC File Offset: 0x002E57FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.position_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Position);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013EB6 RID: 81590 RVA: 0x002E7654 File Offset: 0x002E5854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockIdlePbState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.position_ != null)
			{
				if (this.position_ == null)
				{
					this.Position = new Vector();
				}
				this.Position.MergeFrom(other.Position);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Vector();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013EB7 RID: 81591 RVA: 0x002E76D4 File Offset: 0x002E58D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EB8 RID: 81592 RVA: 0x002E76E0 File Offset: 0x002E58E0
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
				if (num != 50U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Vector();
						}
						input.ReadMessage(this.Rotation);
					}
				}
				else
				{
					if (this.position_ == null)
					{
						this.Position = new Vector();
					}
					input.ReadMessage(this.Position);
				}
			}
		}

		// Token: 0x04007A33 RID: 31283
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A34 RID: 31284
		public const int PositionFieldNumber = 6;

		// Token: 0x04007A35 RID: 31285
		private Vector position_;

		// Token: 0x04007A36 RID: 31286
		public const int RotationFieldNumber = 7;

		// Token: 0x04007A37 RID: 31287
		private Vector rotation_;
	}
}
