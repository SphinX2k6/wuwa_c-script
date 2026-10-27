using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EA RID: 1770
	[NetMessage(EMessageId.GiantTotalStableValueUpdateNotify)]
	public sealed class GiantTotalStableValueUpdateNotify : IMessage<GiantTotalStableValueUpdateNotify>, IMessage, IEquatable<GiantTotalStableValueUpdateNotify>, IDeepCloneable<GiantTotalStableValueUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A16E RID: 41326 RVA: 0x00186B76 File Offset: 0x00184D76
		[NullableContext(1)]
		public static GiantTotalStableValueUpdateNotify Create()
		{
			return new GiantTotalStableValueUpdateNotify();
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600A16F RID: 41327 RVA: 0x00186B7D File Offset: 0x00184D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x00186B80 File Offset: 0x00184D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantTotalStableValueUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x00186B87 File Offset: 0x00184D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantTotalStableValueUpdateNotify()
		{
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x00186B8F File Offset: 0x00184D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantTotalStableValueUpdateNotify(GiantTotalStableValueUpdateNotify other) : this()
		{
			this.totalCount_ = other.totalCount_;
			this.newRedDot_ = other.newRedDot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x00186BC0 File Offset: 0x00184DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantTotalStableValueUpdateNotify Clone()
		{
			return new GiantTotalStableValueUpdateNotify(this);
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x0600A174 RID: 41332 RVA: 0x00186BC8 File Offset: 0x00184DC8
		// (set) Token: 0x0600A175 RID: 41333 RVA: 0x00186BD0 File Offset: 0x00184DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x0600A176 RID: 41334 RVA: 0x00186BD9 File Offset: 0x00184DD9
		// (set) Token: 0x0600A177 RID: 41335 RVA: 0x00186BE1 File Offset: 0x00184DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NewRedDot
		{
			get
			{
				return this.newRedDot_;
			}
			set
			{
				this.newRedDot_ = value;
			}
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x00186BEA File Offset: 0x00184DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantTotalStableValueUpdateNotify);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x00186BF8 File Offset: 0x00184DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantTotalStableValueUpdateNotify other)
		{
			return other != null && (other == this || (this.TotalCount == other.TotalCount && this.NewRedDot == other.NewRedDot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x00186C38 File Offset: 0x00184E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this.NewRedDot)
			{
				num ^= this.NewRedDot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x00186C90 File Offset: 0x00184E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x00186C9D File Offset: 0x00184E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x00186CA8 File Offset: 0x00184EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TotalCount);
			}
			if (this.NewRedDot)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.NewRedDot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x00186D04 File Offset: 0x00184F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this.NewRedDot)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x00186D50 File Offset: 0x00184F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantTotalStableValueUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			if (other.NewRedDot)
			{
				this.NewRedDot = other.NewRedDot;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x00186DA0 File Offset: 0x00184FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x00186DAC File Offset: 0x00184FAC
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
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NewRedDot = input.ReadBool();
					}
				}
				else
				{
					this.TotalCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004AFD RID: 19197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AFE RID: 19198
		public const int TotalCountFieldNumber = 9;

		// Token: 0x04004AFF RID: 19199
		private int totalCount_;

		// Token: 0x04004B00 RID: 19200
		public const int NewRedDotFieldNumber = 10;

		// Token: 0x04004B01 RID: 19201
		private bool newRedDot_;
	}
}
