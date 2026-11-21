using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F2 RID: 2290
	public sealed class LevelPlayRewardActionCtxPb : IMessage<LevelPlayRewardActionCtxPb>, IMessage, IEquatable<LevelPlayRewardActionCtxPb>, IDeepCloneable<LevelPlayRewardActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600CAA8 RID: 51880 RVA: 0x001DEA2C File Offset: 0x001DCC2C
		[NullableContext(1)]
		public static LevelPlayRewardActionCtxPb Create()
		{
			return new LevelPlayRewardActionCtxPb();
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x001DEA33 File Offset: 0x001DCC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600CAAA RID: 51882 RVA: 0x001DEA36 File Offset: 0x001DCC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600CAAB RID: 51883 RVA: 0x001DEA3D File Offset: 0x001DCC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb()
		{
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x001DEA45 File Offset: 0x001DCC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb(LevelPlayRewardActionCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x001DEA6A File Offset: 0x001DCC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb Clone()
		{
			return new LevelPlayRewardActionCtxPb(this);
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x0600CAAE RID: 51886 RVA: 0x001DEA72 File Offset: 0x001DCC72
		// (set) Token: 0x0600CAAF RID: 51887 RVA: 0x001DEA7A File Offset: 0x001DCC7A
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

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x001DEA83 File Offset: 0x001DCC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardActionCtxPb);
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x001DEA91 File Offset: 0x001DCC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardActionCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x001DEAC0 File Offset: 0x001DCCC0
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

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x001DEAFF File Offset: 0x001DCCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x001DEB0C File Offset: 0x001DCD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x001DEB15 File Offset: 0x001DCD15
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

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x001DEB48 File Offset: 0x001DCD48
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

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x001DEB86 File Offset: 0x001DCD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardActionCtxPb other)
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

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x001DEBB7 File Offset: 0x001DCDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x001DEBC0 File Offset: 0x001DCDC0
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

		// Token: 0x04005686 RID: 22150
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005687 RID: 22151
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005688 RID: 22152
		private int levelPlayId_;
	}
}
