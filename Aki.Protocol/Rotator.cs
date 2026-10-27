using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using UnrealEngine;

namespace Aki.Protocol
{
	// Token: 0x02000005 RID: 5
	public sealed class Rotator : IRotator, IMessage<Rotator>, IMessage, IEquatable<Rotator>, IDeepCloneable<Rotator>, IBufferMessage
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000027D0 File Offset: 0x000009D0
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000027D8 File Offset: 0x000009D8
		float IRotator.Pitch
		{
			get
			{
				return this.Pitch;
			}
			set
			{
				this.Pitch = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000027E1 File Offset: 0x000009E1
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000027E9 File Offset: 0x000009E9
		float IRotator.Yaw
		{
			get
			{
				return this.Yaw;
			}
			set
			{
				this.Yaw = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000027F2 File Offset: 0x000009F2
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000027FA File Offset: 0x000009FA
		float IRotator.Roll
		{
			get
			{
				return this.Roll;
			}
			set
			{
				this.Roll = value;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002803 File Offset: 0x00000A03
		[NullableContext(1)]
		public static Rotator Create()
		{
			return new Rotator();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000280A File Offset: 0x00000A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Rotator> Parser
		{
			get
			{
				return Rotator._parser;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002811 File Offset: 0x00000A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002814 File Offset: 0x00000A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Rotator.Descriptor;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000281B File Offset: 0x00000A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002823 File Offset: 0x00000A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator(Rotator other) : this()
		{
			this.pitch_ = other.pitch_;
			this.yaw_ = other.yaw_;
			this.roll_ = other.roll_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002860 File Offset: 0x00000A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Clone()
		{
			return new Rotator(this);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002868 File Offset: 0x00000A68
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002870 File Offset: 0x00000A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Pitch
		{
			get
			{
				return this.pitch_;
			}
			set
			{
				this.pitch_ = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002879 File Offset: 0x00000A79
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002881 File Offset: 0x00000A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Yaw
		{
			get
			{
				return this.yaw_;
			}
			set
			{
				this.yaw_ = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000288A File Offset: 0x00000A8A
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002892 File Offset: 0x00000A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Roll
		{
			get
			{
				return this.roll_;
			}
			set
			{
				this.roll_ = value;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000289B File Offset: 0x00000A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Rotator);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000028AC File Offset: 0x00000AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Rotator other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Pitch, other.Pitch) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Yaw, other.Yaw) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Roll, other.Roll) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002924 File Offset: 0x00000B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Pitch != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Pitch);
			}
			if (this.Yaw != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Yaw);
			}
			if (this.Roll != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Roll);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000029AA File Offset: 0x00000BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000029B7 File Offset: 0x00000BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000029C0 File Offset: 0x00000BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pitch != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Pitch);
			}
			if (this.Yaw != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Yaw);
			}
			if (this.Roll != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Roll);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002A44 File Offset: 0x00000C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Pitch != 0f)
			{
				num += 5;
			}
			if (this.Yaw != 0f)
			{
				num += 5;
			}
			if (this.Roll != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Rotator other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Pitch != 0f)
			{
				this.Pitch = other.Pitch;
			}
			if (other.Yaw != 0f)
			{
				this.Yaw = other.Yaw;
			}
			if (other.Roll != 0f)
			{
				this.Roll = other.Roll;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002B13 File Offset: 0x00000D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002B1C File Offset: 0x00000D1C
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
						if (num != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Roll = input.ReadFloat();
						}
					}
					else
					{
						this.Yaw = input.ReadFloat();
					}
				}
				else
				{
					this.Pitch = input.ReadFloat();
				}
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly MessageParser<Rotator> _parser = new MessageParser<Rotator>(() => new Rotator());

		// Token: 0x04000014 RID: 20
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000015 RID: 21
		public const int PitchFieldNumber = 1;

		// Token: 0x04000016 RID: 22
		private float pitch_;

		// Token: 0x04000017 RID: 23
		public const int YawFieldNumber = 2;

		// Token: 0x04000018 RID: 24
		private float yaw_;

		// Token: 0x04000019 RID: 25
		public const int RollFieldNumber = 3;

		// Token: 0x0400001A RID: 26
		private float roll_;
	}
}
