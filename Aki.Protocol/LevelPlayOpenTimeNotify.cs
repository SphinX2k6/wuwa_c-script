using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F1 RID: 2289
	[NetMessage(EMessageId.LevelPlayOpenTimeNotify)]
	public sealed class LevelPlayOpenTimeNotify : IMessage<LevelPlayOpenTimeNotify>, IMessage, IEquatable<LevelPlayOpenTimeNotify>, IDeepCloneable<LevelPlayOpenTimeNotify>, IBufferMessage
	{
		// Token: 0x0600CA94 RID: 51860 RVA: 0x001DE794 File Offset: 0x001DC994
		[NullableContext(1)]
		public static LevelPlayOpenTimeNotify Create()
		{
			return new LevelPlayOpenTimeNotify();
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x001DE79B File Offset: 0x001DC99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600CA96 RID: 51862 RVA: 0x001DE79E File Offset: 0x001DC99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenTimeNotify.Descriptor;
			}
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x001DE7A5 File Offset: 0x001DC9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenTimeNotify()
		{
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x001DE7AD File Offset: 0x001DC9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenTimeNotify(LevelPlayOpenTimeNotify other) : this()
		{
			this.id_ = other.id_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x001DE7DE File Offset: 0x001DC9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenTimeNotify Clone()
		{
			return new LevelPlayOpenTimeNotify(this);
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600CA9A RID: 51866 RVA: 0x001DE7E6 File Offset: 0x001DC9E6
		// (set) Token: 0x0600CA9B RID: 51867 RVA: 0x001DE7EE File Offset: 0x001DC9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x001DE7F7 File Offset: 0x001DC9F7
		// (set) Token: 0x0600CA9D RID: 51869 RVA: 0x001DE7FF File Offset: 0x001DC9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x0600CA9E RID: 51870 RVA: 0x001DE808 File Offset: 0x001DCA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenTimeNotify);
		}

		// Token: 0x0600CA9F RID: 51871 RVA: 0x001DE816 File Offset: 0x001DCA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenTimeNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x001DE854 File Offset: 0x001DCA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAA1 RID: 51873 RVA: 0x001DE8AC File Offset: 0x001DCAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x001DE8B9 File Offset: 0x001DCAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x001DE8C4 File Offset: 0x001DCAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.OpenTime);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x001DE920 File Offset: 0x001DCB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAA5 RID: 51877 RVA: 0x001DE978 File Offset: 0x001DCB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAA6 RID: 51878 RVA: 0x001DE9C8 File Offset: 0x001DCBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAA7 RID: 51879 RVA: 0x001DE9D4 File Offset: 0x001DCBD4
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
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.OpenTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005681 RID: 22145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005682 RID: 22146
		public const int IdFieldNumber = 13;

		// Token: 0x04005683 RID: 22147
		private int id_;

		// Token: 0x04005684 RID: 22148
		public const int OpenTimeFieldNumber = 3;

		// Token: 0x04005685 RID: 22149
		private long openTime_;
	}
}
