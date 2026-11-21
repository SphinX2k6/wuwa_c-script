using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA6 RID: 2726
	public sealed class MotorWheelInfo : IMessage<MotorWheelInfo>, IMessage, IEquatable<MotorWheelInfo>, IDeepCloneable<MotorWheelInfo>, IBufferMessage
	{
		// Token: 0x0600ED89 RID: 60809 RVA: 0x0022ADBD File Offset: 0x00228FBD
		[NullableContext(1)]
		public static MotorWheelInfo Create()
		{
			return new MotorWheelInfo();
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0600ED8A RID: 60810 RVA: 0x0022ADC4 File Offset: 0x00228FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0600ED8B RID: 60811 RVA: 0x0022ADC7 File Offset: 0x00228FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorWheelInfo.Descriptor;
			}
		}

		// Token: 0x0600ED8C RID: 60812 RVA: 0x0022ADCE File Offset: 0x00228FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo()
		{
		}

		// Token: 0x0600ED8D RID: 60813 RVA: 0x0022ADD8 File Offset: 0x00228FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo(MotorWheelInfo other) : this()
		{
			this.accel_ = other.accel_;
			this.speed_ = other.speed_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED8E RID: 60814 RVA: 0x0022AE30 File Offset: 0x00229030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo Clone()
		{
			return new MotorWheelInfo(this);
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0600ED8F RID: 60815 RVA: 0x0022AE38 File Offset: 0x00229038
		// (set) Token: 0x0600ED90 RID: 60816 RVA: 0x0022AE40 File Offset: 0x00229040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Accel
		{
			get
			{
				return this.accel_;
			}
			set
			{
				this.accel_ = value;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0600ED91 RID: 60817 RVA: 0x0022AE49 File Offset: 0x00229049
		// (set) Token: 0x0600ED92 RID: 60818 RVA: 0x0022AE51 File Offset: 0x00229051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Speed
		{
			get
			{
				return this.speed_;
			}
			set
			{
				this.speed_ = value;
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0600ED93 RID: 60819 RVA: 0x0022AE5A File Offset: 0x0022905A
		// (set) Token: 0x0600ED94 RID: 60820 RVA: 0x0022AE62 File Offset: 0x00229062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x0600ED95 RID: 60821 RVA: 0x0022AE6B File Offset: 0x0022906B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorWheelInfo);
		}

		// Token: 0x0600ED96 RID: 60822 RVA: 0x0022AE7C File Offset: 0x0022907C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorWheelInfo other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Accel, other.Accel) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Speed, other.Speed) && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED97 RID: 60823 RVA: 0x0022AEF0 File Offset: 0x002290F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Accel != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Accel);
			}
			if (this.Speed != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Speed);
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED98 RID: 60824 RVA: 0x0022AF6C File Offset: 0x0022916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED99 RID: 60825 RVA: 0x0022AF79 File Offset: 0x00229179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED9A RID: 60826 RVA: 0x0022AF84 File Offset: 0x00229184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Accel != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Accel);
			}
			if (this.Speed != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Speed);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED9B RID: 60827 RVA: 0x0022B004 File Offset: 0x00229204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Accel != 0f)
			{
				num += 5;
			}
			if (this.Speed != 0f)
			{
				num += 5;
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED9C RID: 60828 RVA: 0x0022B064 File Offset: 0x00229264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorWheelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Accel != 0f)
			{
				this.Accel = other.Accel;
			}
			if (other.Speed != 0f)
			{
				this.Speed = other.Speed;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED9D RID: 60829 RVA: 0x0022B0EA File Offset: 0x002292EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED9E RID: 60830 RVA: 0x0022B0F4 File Offset: 0x002292F4
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
				if (num != 13U)
				{
					if (num != 21U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
						}
					}
					else
					{
						this.Speed = input.ReadFloat();
					}
				}
				else
				{
					this.Accel = input.ReadFloat();
				}
			}
		}

		// Token: 0x04006082 RID: 24706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006083 RID: 24707
		public const int AccelFieldNumber = 1;

		// Token: 0x04006084 RID: 24708
		private float accel_;

		// Token: 0x04006085 RID: 24709
		public const int SpeedFieldNumber = 2;

		// Token: 0x04006086 RID: 24710
		private float speed_;

		// Token: 0x04006087 RID: 24711
		public const int LocationFieldNumber = 3;

		// Token: 0x04006088 RID: 24712
		private Vector location_;
	}
}
