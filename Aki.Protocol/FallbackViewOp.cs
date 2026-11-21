using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000504 RID: 1284
	public sealed class FallbackViewOp : IMessage<FallbackViewOp>, IMessage, IEquatable<FallbackViewOp>, IDeepCloneable<FallbackViewOp>, IBufferMessage
	{
		// Token: 0x0600793D RID: 31037 RVA: 0x00127197 File Offset: 0x00125397
		[NullableContext(1)]
		public static FallbackViewOp Create()
		{
			return new FallbackViewOp();
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x0600793E RID: 31038 RVA: 0x0012719E File Offset: 0x0012539E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x001271A1 File Offset: 0x001253A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FallbackViewOp.Descriptor;
			}
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x001271A8 File Offset: 0x001253A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp()
		{
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x001271B0 File Offset: 0x001253B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp(FallbackViewOp other) : this()
		{
			this.showRestCount_ = other.showRestCount_;
			this.restCount_ = other.restCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x001271E1 File Offset: 0x001253E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp Clone()
		{
			return new FallbackViewOp(this);
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06007943 RID: 31043 RVA: 0x001271E9 File Offset: 0x001253E9
		// (set) Token: 0x06007944 RID: 31044 RVA: 0x001271F1 File Offset: 0x001253F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowRestCount
		{
			get
			{
				return this.showRestCount_;
			}
			set
			{
				this.showRestCount_ = value;
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x001271FA File Offset: 0x001253FA
		// (set) Token: 0x06007946 RID: 31046 RVA: 0x00127202 File Offset: 0x00125402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RestCount
		{
			get
			{
				return this.restCount_;
			}
			set
			{
				this.restCount_ = value;
			}
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x0012720B File Offset: 0x0012540B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FallbackViewOp);
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x00127219 File Offset: 0x00125419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FallbackViewOp other)
		{
			return other != null && (other == this || (this.ShowRestCount == other.ShowRestCount && this.RestCount == other.RestCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x00127258 File Offset: 0x00125458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowRestCount)
			{
				num ^= this.ShowRestCount.GetHashCode();
			}
			if (this.RestCount != 0)
			{
				num ^= this.RestCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x001272B0 File Offset: 0x001254B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x001272BD File Offset: 0x001254BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x001272C8 File Offset: 0x001254C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowRestCount)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ShowRestCount);
			}
			if (this.RestCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RestCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00127320 File Offset: 0x00125520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowRestCount)
			{
				num += 2;
			}
			if (this.RestCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RestCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0012736C File Offset: 0x0012556C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FallbackViewOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowRestCount)
			{
				this.ShowRestCount = other.ShowRestCount;
			}
			if (other.RestCount != 0)
			{
				this.RestCount = other.RestCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x001273BC File Offset: 0x001255BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x001273C8 File Offset: 0x001255C8
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
						this.RestCount = input.ReadInt32();
					}
				}
				else
				{
					this.ShowRestCount = input.ReadBool();
				}
			}
		}

		// Token: 0x04003EEF RID: 16111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF0 RID: 16112
		public const int ShowRestCountFieldNumber = 1;

		// Token: 0x04003EF1 RID: 16113
		private bool showRestCount_;

		// Token: 0x04003EF2 RID: 16114
		public const int RestCountFieldNumber = 2;

		// Token: 0x04003EF3 RID: 16115
		private int restCount_;
	}
}
