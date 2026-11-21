using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7E RID: 3710
	public sealed class RbGridPosition : IMessage<RbGridPosition>, IMessage, IEquatable<RbGridPosition>, IDeepCloneable<RbGridPosition>, IBufferMessage
	{
		// Token: 0x06013F47 RID: 81735 RVA: 0x002E8B72 File Offset: 0x002E6D72
		[NullableContext(1)]
		public static RbGridPosition Create()
		{
			return new RbGridPosition();
		}

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x06013F48 RID: 81736 RVA: 0x002E8B79 File Offset: 0x002E6D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RbGridPosition> Parser
		{
			get
			{
				return RbGridPosition._parser;
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x06013F49 RID: 81737 RVA: 0x002E8B80 File Offset: 0x002E6D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x06013F4A RID: 81738 RVA: 0x002E8B83 File Offset: 0x002E6D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbGridPosition.Descriptor;
			}
		}

		// Token: 0x06013F4B RID: 81739 RVA: 0x002E8B8A File Offset: 0x002E6D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridPosition()
		{
		}

		// Token: 0x06013F4C RID: 81740 RVA: 0x002E8B92 File Offset: 0x002E6D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridPosition(RbGridPosition other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F4D RID: 81741 RVA: 0x002E8BC3 File Offset: 0x002E6DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridPosition Clone()
		{
			return new RbGridPosition(this);
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x06013F4E RID: 81742 RVA: 0x002E8BCB File Offset: 0x002E6DCB
		// (set) Token: 0x06013F4F RID: 81743 RVA: 0x002E8BD3 File Offset: 0x002E6DD3
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

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x06013F50 RID: 81744 RVA: 0x002E8BDC File Offset: 0x002E6DDC
		// (set) Token: 0x06013F51 RID: 81745 RVA: 0x002E8BE4 File Offset: 0x002E6DE4
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

		// Token: 0x06013F52 RID: 81746 RVA: 0x002E8BED File Offset: 0x002E6DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbGridPosition);
		}

		// Token: 0x06013F53 RID: 81747 RVA: 0x002E8BFB File Offset: 0x002E6DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbGridPosition other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F54 RID: 81748 RVA: 0x002E8C3C File Offset: 0x002E6E3C
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

		// Token: 0x06013F55 RID: 81749 RVA: 0x002E8C94 File Offset: 0x002E6E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F56 RID: 81750 RVA: 0x002E8CA1 File Offset: 0x002E6EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F57 RID: 81751 RVA: 0x002E8CAC File Offset: 0x002E6EAC
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

		// Token: 0x06013F58 RID: 81752 RVA: 0x002E8D04 File Offset: 0x002E6F04
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

		// Token: 0x06013F59 RID: 81753 RVA: 0x002E8D5C File Offset: 0x002E6F5C
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

		// Token: 0x06013F5A RID: 81754 RVA: 0x002E8DAC File Offset: 0x002E6FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F5B RID: 81755 RVA: 0x002E8DB8 File Offset: 0x002E6FB8
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

		// Token: 0x04007A5B RID: 31323
		private static readonly MessageParser<RbGridPosition> _parser = new MessageParser<RbGridPosition>(() => new RbGridPosition());

		// Token: 0x04007A5C RID: 31324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A5D RID: 31325
		public const int XFieldNumber = 1;

		// Token: 0x04007A5E RID: 31326
		private int x_;

		// Token: 0x04007A5F RID: 31327
		public const int YFieldNumber = 2;

		// Token: 0x04007A60 RID: 31328
		private int y_;
	}
}
