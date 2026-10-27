using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F5 RID: 2293
	public sealed class LevelPlayCtxPb : IMessage<LevelPlayCtxPb>, IMessage, IEquatable<LevelPlayCtxPb>, IDeepCloneable<LevelPlayCtxPb>, IBufferMessage
	{
		// Token: 0x0600CAAE RID: 51886 RVA: 0x001DEA2A File Offset: 0x001DCC2A
		[NullableContext(1)]
		public static LevelPlayCtxPb Create()
		{
			return new LevelPlayCtxPb();
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x001DEA31 File Offset: 0x001DCC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600CAB0 RID: 51888 RVA: 0x001DEA34 File Offset: 0x001DCC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayCtxPb.Descriptor;
			}
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x001DEA3B File Offset: 0x001DCC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb()
		{
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x001DEA43 File Offset: 0x001DCC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb(LevelPlayCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x001DEA68 File Offset: 0x001DCC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb Clone()
		{
			return new LevelPlayCtxPb(this);
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x0600CAB4 RID: 51892 RVA: 0x001DEA70 File Offset: 0x001DCC70
		// (set) Token: 0x0600CAB5 RID: 51893 RVA: 0x001DEA78 File Offset: 0x001DCC78
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

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x001DEA81 File Offset: 0x001DCC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayCtxPb);
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x001DEA8F File Offset: 0x001DCC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x001DEAC0 File Offset: 0x001DCCC0
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

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x001DEAFF File Offset: 0x001DCCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x001DEB0C File Offset: 0x001DCD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x001DEB15 File Offset: 0x001DCD15
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

		// Token: 0x0600CABC RID: 51900 RVA: 0x001DEB48 File Offset: 0x001DCD48
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

		// Token: 0x0600CABD RID: 51901 RVA: 0x001DEB86 File Offset: 0x001DCD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayCtxPb other)
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

		// Token: 0x0600CABE RID: 51902 RVA: 0x001DEBB7 File Offset: 0x001DCDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x001DEBC0 File Offset: 0x001DCDC0
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

		// Token: 0x04005637 RID: 22071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005638 RID: 22072
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005639 RID: 22073
		private int levelPlayId_;
	}
}
