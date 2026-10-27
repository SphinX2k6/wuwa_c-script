using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8A RID: 3722
	[NetMessage(EMessageId.RbBlockStateChangeNotify)]
	public sealed class RbBlockStateChangeNotify : IMessage<RbBlockStateChangeNotify>, IMessage, IEquatable<RbBlockStateChangeNotify>, IDeepCloneable<RbBlockStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06013FDC RID: 81884 RVA: 0x002E9799 File Offset: 0x002E7999
		[NullableContext(1)]
		public static RbBlockStateChangeNotify Create()
		{
			return new RbBlockStateChangeNotify();
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x06013FDD RID: 81885 RVA: 0x002E97A0 File Offset: 0x002E79A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x06013FDE RID: 81886 RVA: 0x002E97A3 File Offset: 0x002E79A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x06013FDF RID: 81887 RVA: 0x002E97AA File Offset: 0x002E79AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockStateChangeNotify()
		{
		}

		// Token: 0x06013FE0 RID: 81888 RVA: 0x002E97B4 File Offset: 0x002E79B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockStateChangeNotify(RbBlockStateChangeNotify other) : this()
		{
			this.incId_ = other.incId_;
			this.entityId_ = other.entityId_;
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FE1 RID: 81889 RVA: 0x002E980C File Offset: 0x002E7A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockStateChangeNotify Clone()
		{
			return new RbBlockStateChangeNotify(this);
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x06013FE2 RID: 81890 RVA: 0x002E9814 File Offset: 0x002E7A14
		// (set) Token: 0x06013FE3 RID: 81891 RVA: 0x002E981C File Offset: 0x002E7A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x06013FE4 RID: 81892 RVA: 0x002E9825 File Offset: 0x002E7A25
		// (set) Token: 0x06013FE5 RID: 81893 RVA: 0x002E982D File Offset: 0x002E7A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x06013FE6 RID: 81894 RVA: 0x002E9836 File Offset: 0x002E7A36
		// (set) Token: 0x06013FE7 RID: 81895 RVA: 0x002E983E File Offset: 0x002E7A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06013FE8 RID: 81896 RVA: 0x002E9847 File Offset: 0x002E7A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockStateChangeNotify);
		}

		// Token: 0x06013FE9 RID: 81897 RVA: 0x002E9858 File Offset: 0x002E7A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockStateChangeNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.EntityId == other.EntityId && object.Equals(this.State, other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FEA RID: 81898 RVA: 0x002E98B8 File Offset: 0x002E7AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.state_ != null)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013FEB RID: 81899 RVA: 0x002E9926 File Offset: 0x002E7B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FEC RID: 81900 RVA: 0x002E9933 File Offset: 0x002E7B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FED RID: 81901 RVA: 0x002E993C File Offset: 0x002E7B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.state_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.State);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.IncId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013FEE RID: 81902 RVA: 0x002E99B4 File Offset: 0x002E7BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.state_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013FEF RID: 81903 RVA: 0x002E9A24 File Offset: 0x002E7C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockStateChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.state_ != null)
			{
				if (this.state_ == null)
				{
					this.State = new RbBlockPbState();
				}
				this.State.MergeFrom(other.State);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013FF0 RID: 81904 RVA: 0x002E9AA0 File Offset: 0x002E7CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FF1 RID: 81905 RVA: 0x002E9AAC File Offset: 0x002E7CAC
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
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					if (this.state_ == null)
					{
						this.State = new RbBlockPbState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x04007A1B RID: 31259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A1C RID: 31260
		public const int IncIdFieldNumber = 8;

		// Token: 0x04007A1D RID: 31261
		private int incId_;

		// Token: 0x04007A1E RID: 31262
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04007A1F RID: 31263
		private long entityId_;

		// Token: 0x04007A20 RID: 31264
		public const int StateFieldNumber = 6;

		// Token: 0x04007A21 RID: 31265
		private RbBlockPbState state_;
	}
}
