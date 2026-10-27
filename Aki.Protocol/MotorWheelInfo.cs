using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB7 RID: 2743
	public sealed class MotorWheelInfo : IMessage<MotorWheelInfo>, IMessage, IEquatable<MotorWheelInfo>, IDeepCloneable<MotorWheelInfo>, IBufferMessage
	{
		// Token: 0x0600EEA3 RID: 61091 RVA: 0x0022CFBD File Offset: 0x0022B1BD
		[NullableContext(1)]
		public static MotorWheelInfo Create()
		{
			return new MotorWheelInfo();
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600EEA4 RID: 61092 RVA: 0x0022CFC4 File Offset: 0x0022B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600EEA5 RID: 61093 RVA: 0x0022CFC7 File Offset: 0x0022B1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorWheelInfo.Descriptor;
			}
		}

		// Token: 0x0600EEA6 RID: 61094 RVA: 0x0022CFCE File Offset: 0x0022B1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo()
		{
		}

		// Token: 0x0600EEA7 RID: 61095 RVA: 0x0022CFD8 File Offset: 0x0022B1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo(MotorWheelInfo other) : this()
		{
			this.accel_ = other.accel_;
			this.speed_ = other.speed_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEA8 RID: 61096 RVA: 0x0022D030 File Offset: 0x0022B230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorWheelInfo Clone()
		{
			return new MotorWheelInfo(this);
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600EEA9 RID: 61097 RVA: 0x0022D038 File Offset: 0x0022B238
		// (set) Token: 0x0600EEAA RID: 61098 RVA: 0x0022D040 File Offset: 0x0022B240
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

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600EEAB RID: 61099 RVA: 0x0022D049 File Offset: 0x0022B249
		// (set) Token: 0x0600EEAC RID: 61100 RVA: 0x0022D051 File Offset: 0x0022B251
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

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0600EEAD RID: 61101 RVA: 0x0022D05A File Offset: 0x0022B25A
		// (set) Token: 0x0600EEAE RID: 61102 RVA: 0x0022D062 File Offset: 0x0022B262
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

		// Token: 0x0600EEAF RID: 61103 RVA: 0x0022D06B File Offset: 0x0022B26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorWheelInfo);
		}

		// Token: 0x0600EEB0 RID: 61104 RVA: 0x0022D07C File Offset: 0x0022B27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorWheelInfo other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Accel, other.Accel) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Speed, other.Speed) && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EEB1 RID: 61105 RVA: 0x0022D0F0 File Offset: 0x0022B2F0
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

		// Token: 0x0600EEB2 RID: 61106 RVA: 0x0022D16C File Offset: 0x0022B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEB3 RID: 61107 RVA: 0x0022D179 File Offset: 0x0022B379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EEB4 RID: 61108 RVA: 0x0022D184 File Offset: 0x0022B384
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

		// Token: 0x0600EEB5 RID: 61109 RVA: 0x0022D204 File Offset: 0x0022B404
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

		// Token: 0x0600EEB6 RID: 61110 RVA: 0x0022D264 File Offset: 0x0022B464
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

		// Token: 0x0600EEB7 RID: 61111 RVA: 0x0022D2EA File Offset: 0x0022B4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEB8 RID: 61112 RVA: 0x0022D2F4 File Offset: 0x0022B4F4
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

		// Token: 0x04006079 RID: 24697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400607A RID: 24698
		public const int AccelFieldNumber = 1;

		// Token: 0x0400607B RID: 24699
		private float accel_;

		// Token: 0x0400607C RID: 24700
		public const int SpeedFieldNumber = 2;

		// Token: 0x0400607D RID: 24701
		private float speed_;

		// Token: 0x0400607E RID: 24702
		public const int LocationFieldNumber = 3;

		// Token: 0x0400607F RID: 24703
		private Vector location_;
	}
}
