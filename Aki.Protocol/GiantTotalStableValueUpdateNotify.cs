using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D6 RID: 1750
	[NetMessage(EMessageId.GiantTotalStableValueUpdateNotify)]
	public sealed class GiantTotalStableValueUpdateNotify : IMessage<GiantTotalStableValueUpdateNotify>, IMessage, IEquatable<GiantTotalStableValueUpdateNotify>, IDeepCloneable<GiantTotalStableValueUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A018 RID: 40984 RVA: 0x00184142 File Offset: 0x00182342
		[NullableContext(1)]
		public static GiantTotalStableValueUpdateNotify Create()
		{
			return new GiantTotalStableValueUpdateNotify();
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x0600A019 RID: 40985 RVA: 0x00184149 File Offset: 0x00182349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x0018414C File Offset: 0x0018234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantTotalStableValueUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x00184153 File Offset: 0x00182353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantTotalStableValueUpdateNotify()
		{
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x0018415B File Offset: 0x0018235B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantTotalStableValueUpdateNotify(GiantTotalStableValueUpdateNotify other) : this()
		{
			this.totalCount_ = other.totalCount_;
			this.newRedDot_ = other.newRedDot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x0018418C File Offset: 0x0018238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantTotalStableValueUpdateNotify Clone()
		{
			return new GiantTotalStableValueUpdateNotify(this);
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x00184194 File Offset: 0x00182394
		// (set) Token: 0x0600A01F RID: 40991 RVA: 0x0018419C File Offset: 0x0018239C
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

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x001841A5 File Offset: 0x001823A5
		// (set) Token: 0x0600A021 RID: 40993 RVA: 0x001841AD File Offset: 0x001823AD
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

		// Token: 0x0600A022 RID: 40994 RVA: 0x001841B6 File Offset: 0x001823B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantTotalStableValueUpdateNotify);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x001841C4 File Offset: 0x001823C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantTotalStableValueUpdateNotify other)
		{
			return other != null && (other == this || (this.TotalCount == other.TotalCount && this.NewRedDot == other.NewRedDot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x00184204 File Offset: 0x00182404
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

		// Token: 0x0600A025 RID: 40997 RVA: 0x0018425C File Offset: 0x0018245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x00184269 File Offset: 0x00182469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x00184274 File Offset: 0x00182474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalCount);
			}
			if (this.NewRedDot)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NewRedDot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A028 RID: 41000 RVA: 0x001842D0 File Offset: 0x001824D0
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

		// Token: 0x0600A029 RID: 41001 RVA: 0x0018431C File Offset: 0x0018251C
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

		// Token: 0x0600A02A RID: 41002 RVA: 0x0018436C File Offset: 0x0018256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x00184378 File Offset: 0x00182578
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
						this.NewRedDot = input.ReadBool();
					}
				}
				else
				{
					this.TotalCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004AF6 RID: 19190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AF7 RID: 19191
		public const int TotalCountFieldNumber = 3;

		// Token: 0x04004AF8 RID: 19192
		private int totalCount_;

		// Token: 0x04004AF9 RID: 19193
		public const int NewRedDotFieldNumber = 13;

		// Token: 0x04004AFA RID: 19194
		private bool newRedDot_;
	}
}
