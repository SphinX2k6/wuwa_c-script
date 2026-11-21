using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C5 RID: 197
	public sealed class AdvertisingPageData : IMessage<AdvertisingPageData>, IMessage, IEquatable<AdvertisingPageData>, IDeepCloneable<AdvertisingPageData>, IBufferMessage
	{
		// Token: 0x06001F5E RID: 8030 RVA: 0x000557E9 File Offset: 0x000539E9
		[NullableContext(1)]
		public static AdvertisingPageData Create()
		{
			return new AdvertisingPageData();
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x000557F0 File Offset: 0x000539F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x000557F3 File Offset: 0x000539F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvertisingPageData.Descriptor;
			}
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000557FA File Offset: 0x000539FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData()
		{
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00055802 File Offset: 0x00053A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData(AdvertisingPageData other) : this()
		{
			this.show_ = other.show_;
			this.pointTime_ = other.pointTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00055833 File Offset: 0x00053A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData Clone()
		{
			return new AdvertisingPageData(this);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0005583B File Offset: 0x00053A3B
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00055843 File Offset: 0x00053A43
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0005584C File Offset: 0x00053A4C
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00055854 File Offset: 0x00053A54
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

		// Token: 0x06001F68 RID: 8040 RVA: 0x0005585D File Offset: 0x00053A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvertisingPageData);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0005586B File Offset: 0x00053A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdvertisingPageData other)
		{
			return other != null && (other == this || (this.Show == other.Show && this.PointTime == other.PointTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000558AC File Offset: 0x00053AAC
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

		// Token: 0x06001F6B RID: 8043 RVA: 0x00055904 File Offset: 0x00053B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00055911 File Offset: 0x00053B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0005591C File Offset: 0x00053B1C
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

		// Token: 0x06001F6E RID: 8046 RVA: 0x00055974 File Offset: 0x00053B74
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

		// Token: 0x06001F6F RID: 8047 RVA: 0x000559C0 File Offset: 0x00053BC0
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

		// Token: 0x06001F70 RID: 8048 RVA: 0x00055A10 File Offset: 0x00053C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00055A1C File Offset: 0x00053C1C
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

		// Token: 0x04002404 RID: 9220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002405 RID: 9221
		public const int ShowFieldNumber = 1;

		// Token: 0x04002406 RID: 9222
		private bool show_;

		// Token: 0x04002407 RID: 9223
		public const int PointTimeFieldNumber = 2;

		// Token: 0x04002408 RID: 9224
		private long pointTime_;
	}
}
