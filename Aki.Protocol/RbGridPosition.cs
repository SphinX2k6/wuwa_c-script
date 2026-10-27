using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8E RID: 3726
	public sealed class RbGridPosition : IMessage<RbGridPosition>, IMessage, IEquatable<RbGridPosition>, IDeepCloneable<RbGridPosition>, IBufferMessage
	{
		// Token: 0x0601402C RID: 81964 RVA: 0x002EA22E File Offset: 0x002E842E
		[NullableContext(1)]
		public static RbGridPosition Create()
		{
			return new RbGridPosition();
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x0601402D RID: 81965 RVA: 0x002EA235 File Offset: 0x002E8435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RbGridPosition> Parser
		{
			get
			{
				return RbGridPosition._parser;
			}
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x0601402E RID: 81966 RVA: 0x002EA23C File Offset: 0x002E843C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0601402F RID: 81967 RVA: 0x002EA23F File Offset: 0x002E843F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbGridPosition.Descriptor;
			}
		}

		// Token: 0x06014030 RID: 81968 RVA: 0x002EA246 File Offset: 0x002E8446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridPosition()
		{
		}

		// Token: 0x06014031 RID: 81969 RVA: 0x002EA24E File Offset: 0x002E844E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridPosition(RbGridPosition other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014032 RID: 81970 RVA: 0x002EA27F File Offset: 0x002E847F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridPosition Clone()
		{
			return new RbGridPosition(this);
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x06014033 RID: 81971 RVA: 0x002EA287 File Offset: 0x002E8487
		// (set) Token: 0x06014034 RID: 81972 RVA: 0x002EA28F File Offset: 0x002E848F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
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

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x06014035 RID: 81973 RVA: 0x002EA298 File Offset: 0x002E8498
		// (set) Token: 0x06014036 RID: 81974 RVA: 0x002EA2A0 File Offset: 0x002E84A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
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

		// Token: 0x06014037 RID: 81975 RVA: 0x002EA2A9 File Offset: 0x002E84A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbGridPosition);
		}

		// Token: 0x06014038 RID: 81976 RVA: 0x002EA2B7 File Offset: 0x002E84B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbGridPosition other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014039 RID: 81977 RVA: 0x002EA2F8 File Offset: 0x002E84F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601403A RID: 81978 RVA: 0x002EA350 File Offset: 0x002E8550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601403B RID: 81979 RVA: 0x002EA35D File Offset: 0x002E855D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601403C RID: 81980 RVA: 0x002EA368 File Offset: 0x002E8568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Y);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601403D RID: 81981 RVA: 0x002EA3C0 File Offset: 0x002E85C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601403E RID: 81982 RVA: 0x002EA418 File Offset: 0x002E8618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbGridPosition other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601403F RID: 81983 RVA: 0x002EA468 File Offset: 0x002E8668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014040 RID: 81984 RVA: 0x002EA474 File Offset: 0x002E8674
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Y = input.ReadInt32();
					}
				}
				else
				{
					this.X = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A31 RID: 31281
		private static readonly MessageParser<RbGridPosition> _parser = new MessageParser<RbGridPosition>(() => new RbGridPosition());

		// Token: 0x04007A32 RID: 31282
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A33 RID: 31283
		public const int XFieldNumber = 1;

		// Token: 0x04007A34 RID: 31284
		private int x_;

		// Token: 0x04007A35 RID: 31285
		public const int YFieldNumber = 2;

		// Token: 0x04007A36 RID: 31286
		private int y_;
	}
}
