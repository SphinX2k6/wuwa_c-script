using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C4 RID: 196
	public sealed class AdvertisingPageData : IMessage<AdvertisingPageData>, IMessage, IEquatable<AdvertisingPageData>, IDeepCloneable<AdvertisingPageData>, IBufferMessage
	{
		// Token: 0x06001F15 RID: 7957 RVA: 0x00054B35 File Offset: 0x00052D35
		[NullableContext(1)]
		public static AdvertisingPageData Create()
		{
			return new AdvertisingPageData();
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00054B3C File Offset: 0x00052D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00054B3F File Offset: 0x00052D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvertisingPageData.Descriptor;
			}
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00054B46 File Offset: 0x00052D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData()
		{
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00054B4E File Offset: 0x00052D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData(AdvertisingPageData other) : this()
		{
			this.show_ = other.show_;
			this.pointTime_ = other.pointTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00054B7F File Offset: 0x00052D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData Clone()
		{
			return new AdvertisingPageData(this);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00054B87 File Offset: 0x00052D87
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00054B8F File Offset: 0x00052D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Show
		{
			get
			{
				return this.show_;
			}
			set
			{
				this.show_ = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00054B98 File Offset: 0x00052D98
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00054BA0 File Offset: 0x00052DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PointTime
		{
			get
			{
				return this.pointTime_;
			}
			set
			{
				this.pointTime_ = value;
			}
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00054BA9 File Offset: 0x00052DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvertisingPageData);
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00054BB7 File Offset: 0x00052DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdvertisingPageData other)
		{
			return other != null && (other == this || (this.Show == other.Show && this.PointTime == other.PointTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00054BF8 File Offset: 0x00052DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Show)
			{
				num ^= this.Show.GetHashCode();
			}
			if (this.PointTime != 0L)
			{
				num ^= this.PointTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00054C50 File Offset: 0x00052E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00054C5D File Offset: 0x00052E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00054C68 File Offset: 0x00052E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Show)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Show);
			}
			if (this.PointTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.PointTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00054CC0 File Offset: 0x00052EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Show)
			{
				num += 2;
			}
			if (this.PointTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PointTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00054D0C File Offset: 0x00052F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdvertisingPageData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Show)
			{
				this.Show = other.Show;
			}
			if (other.PointTime != 0L)
			{
				this.PointTime = other.PointTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00054D5C File Offset: 0x00052F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00054D68 File Offset: 0x00052F68
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
						this.PointTime = input.ReadInt64();
					}
				}
				else
				{
					this.Show = input.ReadBool();
				}
			}
		}

		// Token: 0x040023A1 RID: 9121
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A2 RID: 9122
		public const int ShowFieldNumber = 1;

		// Token: 0x040023A3 RID: 9123
		private bool show_;

		// Token: 0x040023A4 RID: 9124
		public const int PointTimeFieldNumber = 2;

		// Token: 0x040023A5 RID: 9125
		private long pointTime_;
	}
}
