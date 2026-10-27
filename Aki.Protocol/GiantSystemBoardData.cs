using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E8 RID: 1768
	public sealed class GiantSystemBoardData : IMessage<GiantSystemBoardData>, IMessage, IEquatable<GiantSystemBoardData>, IDeepCloneable<GiantSystemBoardData>, IBufferMessage
	{
		// Token: 0x0600A144 RID: 41284 RVA: 0x001864FC File Offset: 0x001846FC
		[NullableContext(1)]
		public static GiantSystemBoardData Create()
		{
			return new GiantSystemBoardData();
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x00186503 File Offset: 0x00184703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600A146 RID: 41286 RVA: 0x00186506 File Offset: 0x00184706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantSystemBoardData.Descriptor;
			}
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x0018650D File Offset: 0x0018470D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData()
		{
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x00186515 File Offset: 0x00184715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData(GiantSystemBoardData other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x0018653A File Offset: 0x0018473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData Clone()
		{
			return new GiantSystemBoardData(this);
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600A14A RID: 41290 RVA: 0x00186542 File Offset: 0x00184742
		// (set) Token: 0x0600A14B RID: 41291 RVA: 0x0018654A File Offset: 0x0018474A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GiantEcoType
		{
			get
			{
				return this.giantEcoType_;
			}
			set
			{
				this.giantEcoType_ = value;
			}
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x00186553 File Offset: 0x00184753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantSystemBoardData);
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x00186561 File Offset: 0x00184761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantSystemBoardData other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x00186590 File Offset: 0x00184790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantEcoType != 0)
			{
				num ^= this.GiantEcoType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x001865CF File Offset: 0x001847CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A150 RID: 41296 RVA: 0x001865DC File Offset: 0x001847DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x001865E5 File Offset: 0x001847E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x00186618 File Offset: 0x00184818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x00186656 File Offset: 0x00184856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantSystemBoardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantEcoType != 0)
			{
				this.GiantEcoType = other.GiantEcoType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x00186687 File Offset: 0x00184887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x00186690 File Offset: 0x00184890
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
					this.GiantEcoType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004AEC RID: 19180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AED RID: 19181
		public const int GiantEcoTypeFieldNumber = 1;

		// Token: 0x04004AEE RID: 19182
		private int giantEcoType_;
	}
}
