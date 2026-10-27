using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083A RID: 2106
	public sealed class IntVector2D : IMessage<IntVector2D>, IMessage, IEquatable<IntVector2D>, IDeepCloneable<IntVector2D>, IBufferMessage
	{
		// Token: 0x0600BC16 RID: 48150 RVA: 0x001BFBEA File Offset: 0x001BDDEA
		[NullableContext(1)]
		public static IntVector2D Create()
		{
			return new IntVector2D();
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x0600BC17 RID: 48151 RVA: 0x001BFBF1 File Offset: 0x001BDDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x001BFBF4 File Offset: 0x001BDDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IntVector2D.Descriptor;
			}
		}

		// Token: 0x0600BC19 RID: 48153 RVA: 0x001BFBFB File Offset: 0x001BDDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D()
		{
		}

		// Token: 0x0600BC1A RID: 48154 RVA: 0x001BFC03 File Offset: 0x001BDE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D(IntVector2D other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC1B RID: 48155 RVA: 0x001BFC34 File Offset: 0x001BDE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D Clone()
		{
			return new IntVector2D(this);
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x001BFC3C File Offset: 0x001BDE3C
		// (set) Token: 0x0600BC1D RID: 48157 RVA: 0x001BFC44 File Offset: 0x001BDE44
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

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x001BFC4D File Offset: 0x001BDE4D
		// (set) Token: 0x0600BC1F RID: 48159 RVA: 0x001BFC55 File Offset: 0x001BDE55
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

		// Token: 0x0600BC20 RID: 48160 RVA: 0x001BFC5E File Offset: 0x001BDE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IntVector2D);
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x001BFC6C File Offset: 0x001BDE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IntVector2D other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC22 RID: 48162 RVA: 0x001BFCAC File Offset: 0x001BDEAC
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

		// Token: 0x0600BC23 RID: 48163 RVA: 0x001BFD04 File Offset: 0x001BDF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC24 RID: 48164 RVA: 0x001BFD11 File Offset: 0x001BDF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x001BFD1C File Offset: 0x001BDF1C
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

		// Token: 0x0600BC26 RID: 48166 RVA: 0x001BFD74 File Offset: 0x001BDF74
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

		// Token: 0x0600BC27 RID: 48167 RVA: 0x001BFDCC File Offset: 0x001BDFCC
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

		// Token: 0x0600BC28 RID: 48168 RVA: 0x001BFE1C File Offset: 0x001BE01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC29 RID: 48169 RVA: 0x001BFE28 File Offset: 0x001BE028
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

		// Token: 0x0400526E RID: 21102
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400526F RID: 21103
		public const int XFieldNumber = 1;

		// Token: 0x04005270 RID: 21104
		private int x_;

		// Token: 0x04005271 RID: 21105
		public const int YFieldNumber = 2;

		// Token: 0x04005272 RID: 21106
		private int y_;
	}
}
