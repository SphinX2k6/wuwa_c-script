using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E86 RID: 3718
	public sealed class RbBlockIdlePbState : IMessage<RbBlockIdlePbState>, IMessage, IEquatable<RbBlockIdlePbState>, IDeepCloneable<RbBlockIdlePbState>, IBufferMessage
	{
		// Token: 0x06013F8A RID: 81802 RVA: 0x002E8AF1 File Offset: 0x002E6CF1
		[NullableContext(1)]
		public static RbBlockIdlePbState Create()
		{
			return new RbBlockIdlePbState();
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x06013F8B RID: 81803 RVA: 0x002E8AF8 File Offset: 0x002E6CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x06013F8C RID: 81804 RVA: 0x002E8AFB File Offset: 0x002E6CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockIdlePbState.Descriptor;
			}
		}

		// Token: 0x06013F8D RID: 81805 RVA: 0x002E8B02 File Offset: 0x002E6D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState()
		{
		}

		// Token: 0x06013F8E RID: 81806 RVA: 0x002E8B0C File Offset: 0x002E6D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState(RbBlockIdlePbState other) : this()
		{
			this.position_ = ((other.position_ != null) ? other.position_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F8F RID: 81807 RVA: 0x002E8B68 File Offset: 0x002E6D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState Clone()
		{
			return new RbBlockIdlePbState(this);
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x06013F90 RID: 81808 RVA: 0x002E8B70 File Offset: 0x002E6D70
		// (set) Token: 0x06013F91 RID: 81809 RVA: 0x002E8B78 File Offset: 0x002E6D78
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

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x06013F92 RID: 81810 RVA: 0x002E8B81 File Offset: 0x002E6D81
		// (set) Token: 0x06013F93 RID: 81811 RVA: 0x002E8B89 File Offset: 0x002E6D89
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

		// Token: 0x06013F94 RID: 81812 RVA: 0x002E8B92 File Offset: 0x002E6D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockIdlePbState);
		}

		// Token: 0x06013F95 RID: 81813 RVA: 0x002E8BA0 File Offset: 0x002E6DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockIdlePbState other)
		{
			return other != null && (other == this || (object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F96 RID: 81814 RVA: 0x002E8BF4 File Offset: 0x002E6DF4
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

		// Token: 0x06013F97 RID: 81815 RVA: 0x002E8C46 File Offset: 0x002E6E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F98 RID: 81816 RVA: 0x002E8C53 File Offset: 0x002E6E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F99 RID: 81817 RVA: 0x002E8C5C File Offset: 0x002E6E5C
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

		// Token: 0x06013F9A RID: 81818 RVA: 0x002E8CB8 File Offset: 0x002E6EB8
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

		// Token: 0x06013F9B RID: 81819 RVA: 0x002E8D10 File Offset: 0x002E6F10
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

		// Token: 0x06013F9C RID: 81820 RVA: 0x002E8D90 File Offset: 0x002E6F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F9D RID: 81821 RVA: 0x002E8D9C File Offset: 0x002E6F9C
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

		// Token: 0x04007A09 RID: 31241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A0A RID: 31242
		public const int PositionFieldNumber = 6;

		// Token: 0x04007A0B RID: 31243
		private Vector position_;

		// Token: 0x04007A0C RID: 31244
		public const int RotationFieldNumber = 7;

		// Token: 0x04007A0D RID: 31245
		private Vector rotation_;
	}
}
