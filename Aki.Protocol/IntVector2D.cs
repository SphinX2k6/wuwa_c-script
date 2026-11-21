using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000826 RID: 2086
	public sealed class IntVector2D : IMessage<IntVector2D>, IMessage, IEquatable<IntVector2D>, IDeepCloneable<IntVector2D>, IBufferMessage
	{
		// Token: 0x0600BAC0 RID: 47808 RVA: 0x001BD1AE File Offset: 0x001BB3AE
		[NullableContext(1)]
		public static IntVector2D Create()
		{
			return new IntVector2D();
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x0600BAC1 RID: 47809 RVA: 0x001BD1B5 File Offset: 0x001BB3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x001BD1B8 File Offset: 0x001BB3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IntVector2D.Descriptor;
			}
		}

		// Token: 0x0600BAC3 RID: 47811 RVA: 0x001BD1BF File Offset: 0x001BB3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D()
		{
		}

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x001BD1C7 File Offset: 0x001BB3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D(IntVector2D other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x001BD1F8 File Offset: 0x001BB3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D Clone()
		{
			return new IntVector2D(this);
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x001BD200 File Offset: 0x001BB400
		// (set) Token: 0x0600BAC7 RID: 47815 RVA: 0x001BD208 File Offset: 0x001BB408
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

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x001BD211 File Offset: 0x001BB411
		// (set) Token: 0x0600BAC9 RID: 47817 RVA: 0x001BD219 File Offset: 0x001BB419
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

		// Token: 0x0600BACA RID: 47818 RVA: 0x001BD222 File Offset: 0x001BB422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IntVector2D);
		}

		// Token: 0x0600BACB RID: 47819 RVA: 0x001BD230 File Offset: 0x001BB430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IntVector2D other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BACC RID: 47820 RVA: 0x001BD270 File Offset: 0x001BB470
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

		// Token: 0x0600BACD RID: 47821 RVA: 0x001BD2C8 File Offset: 0x001BB4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x001BD2D5 File Offset: 0x001BB4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BACF RID: 47823 RVA: 0x001BD2E0 File Offset: 0x001BB4E0
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

		// Token: 0x0600BAD0 RID: 47824 RVA: 0x001BD338 File Offset: 0x001BB538
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

		// Token: 0x0600BAD1 RID: 47825 RVA: 0x001BD390 File Offset: 0x001BB590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IntVector2D other)
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

		// Token: 0x0600BAD2 RID: 47826 RVA: 0x001BD3E0 File Offset: 0x001BB5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x001BD3EC File Offset: 0x001BB5EC
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

		// Token: 0x04005267 RID: 21095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005268 RID: 21096
		public const int XFieldNumber = 1;

		// Token: 0x04005269 RID: 21097
		private int x_;

		// Token: 0x0400526A RID: 21098
		public const int YFieldNumber = 2;

		// Token: 0x0400526B RID: 21099
		private int y_;
	}
}
