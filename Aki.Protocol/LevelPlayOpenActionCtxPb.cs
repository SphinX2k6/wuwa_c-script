using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EE RID: 2286
	public sealed class LevelPlayOpenActionCtxPb : IMessage<LevelPlayOpenActionCtxPb>, IMessage, IEquatable<LevelPlayOpenActionCtxPb>, IDeepCloneable<LevelPlayOpenActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600CA5A RID: 51802 RVA: 0x001DE089 File Offset: 0x001DC289
		[NullableContext(1)]
		public static LevelPlayOpenActionCtxPb Create()
		{
			return new LevelPlayOpenActionCtxPb();
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x0600CA5B RID: 51803 RVA: 0x001DE090 File Offset: 0x001DC290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600CA5C RID: 51804 RVA: 0x001DE093 File Offset: 0x001DC293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600CA5D RID: 51805 RVA: 0x001DE09A File Offset: 0x001DC29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb()
		{
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x001DE0A2 File Offset: 0x001DC2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb(LevelPlayOpenActionCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x001DE0C7 File Offset: 0x001DC2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb Clone()
		{
			return new LevelPlayOpenActionCtxPb(this);
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600CA60 RID: 51808 RVA: 0x001DE0CF File Offset: 0x001DC2CF
		// (set) Token: 0x0600CA61 RID: 51809 RVA: 0x001DE0D7 File Offset: 0x001DC2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x001DE0E0 File Offset: 0x001DC2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenActionCtxPb);
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x001DE0EE File Offset: 0x001DC2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenActionCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x001DE11C File Offset: 0x001DC31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x001DE15B File Offset: 0x001DC35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x001DE168 File Offset: 0x001DC368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x001DE171 File Offset: 0x001DC371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x001DE1A4 File Offset: 0x001DC3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x001DE1E2 File Offset: 0x001DC3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x001DE213 File Offset: 0x001DC413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x001DE21C File Offset: 0x001DC41C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005674 RID: 22132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005675 RID: 22133
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005676 RID: 22134
		private int levelPlayId_;
	}
}
