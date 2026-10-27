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
	// Token: 0x02000006 RID: 6
	public sealed class Vector : IVector, IVector2D, IMessage<Vector>, IMessage, IEquatable<Vector>, IDeepCloneable<Vector>, IBufferMessage
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002BA3 File Offset: 0x00000DA3
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002BAC File Offset: 0x00000DAC
		double IVector2D.X
		{
			get
			{
				return (double)this.X;
			}
			set
			{
				this.X = (float)value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002BB6 File Offset: 0x00000DB6
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002BBF File Offset: 0x00000DBF
		double IVector2D.Y
		{
			get
			{
				return (double)this.Y;
			}
			set
			{
				this.Y = (float)value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002BC9 File Offset: 0x00000DC9
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002BD2 File Offset: 0x00000DD2
		double IVector.Z
		{
			get
			{
				return (double)this.Z;
			}
			set
			{
				this.Z = (float)value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002BDC File Offset: 0x00000DDC
		public FVector ToFVector()
		{
			return new FVector
			{
				X = this.X,
				Y = this.Y,
				Z = this.Z
			};
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002C18 File Offset: 0x00000E18
		[NullableContext(1)]
		public static Vector Create()
		{
			return new Vector();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002C1F File Offset: 0x00000E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Vector> Parser
		{
			get
			{
				return Vector._parser;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002C26 File Offset: 0x00000E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002C29 File Offset: 0x00000E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Vector.Descriptor;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002C30 File Offset: 0x00000E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002C38 File Offset: 0x00000E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector(Vector other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002C75 File Offset: 0x00000E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Clone()
		{
			return new Vector(this);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002C7D File Offset: 0x00000E7D
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002C85 File Offset: 0x00000E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002C8E File Offset: 0x00000E8E
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002C96 File Offset: 0x00000E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002C9F File Offset: 0x00000E9F
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002CA7 File Offset: 0x00000EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Z
		{
			get
			{
				return this.z_;
			}
			set
			{
				this.z_ = value;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Vector);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002CC0 File Offset: 0x00000EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Vector other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002D38 File Offset: 0x00000F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			if (this.Y != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			if (this.Z != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Z);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002DBE File Offset: 0x00000FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002DCB File Offset: 0x00000FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.X);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Y);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Z);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002E58 File Offset: 0x00001058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0f)
			{
				num += 5;
			}
			if (this.Y != 0f)
			{
				num += 5;
			}
			if (this.Z != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002EB4 File Offset: 0x000010B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Vector other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0f)
			{
				this.X = other.X;
			}
			if (other.Y != 0f)
			{
				this.Y = other.Y;
			}
			if (other.Z != 0f)
			{
				this.Z = other.Z;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002F27 File Offset: 0x00001127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002F30 File Offset: 0x00001130
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
							this.Z = input.ReadFloat();
						}
					}
					else
					{
						this.Y = input.ReadFloat();
					}
				}
				else
				{
					this.X = input.ReadFloat();
				}
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly MessageParser<Vector> _parser = new MessageParser<Vector>(() => new Vector());

		// Token: 0x0400001C RID: 28
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400001D RID: 29
		public const int XFieldNumber = 1;

		// Token: 0x0400001E RID: 30
		private float x_;

		// Token: 0x0400001F RID: 31
		public const int YFieldNumber = 2;

		// Token: 0x04000020 RID: 32
		private float y_;

		// Token: 0x04000021 RID: 33
		public const int ZFieldNumber = 3;

		// Token: 0x04000022 RID: 34
		private float z_;
	}
}
