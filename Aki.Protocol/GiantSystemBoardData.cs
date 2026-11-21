using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D4 RID: 1748
	public sealed class GiantSystemBoardData : IMessage<GiantSystemBoardData>, IMessage, IEquatable<GiantSystemBoardData>, IDeepCloneable<GiantSystemBoardData>, IBufferMessage
	{
		// Token: 0x06009FEE RID: 40942 RVA: 0x00183AC8 File Offset: 0x00181CC8
		[NullableContext(1)]
		public static GiantSystemBoardData Create()
		{
			return new GiantSystemBoardData();
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06009FEF RID: 40943 RVA: 0x00183ACF File Offset: 0x00181CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06009FF0 RID: 40944 RVA: 0x00183AD2 File Offset: 0x00181CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantSystemBoardData.Descriptor;
			}
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x00183AD9 File Offset: 0x00181CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData()
		{
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x00183AE1 File Offset: 0x00181CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData(GiantSystemBoardData other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x00183B06 File Offset: 0x00181D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantSystemBoardData Clone()
		{
			return new GiantSystemBoardData(this);
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06009FF4 RID: 40948 RVA: 0x00183B0E File Offset: 0x00181D0E
		// (set) Token: 0x06009FF5 RID: 40949 RVA: 0x00183B16 File Offset: 0x00181D16
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

		// Token: 0x06009FF6 RID: 40950 RVA: 0x00183B1F File Offset: 0x00181D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantSystemBoardData);
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x00183B2D File Offset: 0x00181D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantSystemBoardData other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FF8 RID: 40952 RVA: 0x00183B5C File Offset: 0x00181D5C
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

		// Token: 0x06009FF9 RID: 40953 RVA: 0x00183B9B File Offset: 0x00181D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x00183BA8 File Offset: 0x00181DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x00183BB1 File Offset: 0x00181DB1
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

		// Token: 0x06009FFC RID: 40956 RVA: 0x00183BE4 File Offset: 0x00181DE4
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

		// Token: 0x06009FFD RID: 40957 RVA: 0x00183C22 File Offset: 0x00181E22
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

		// Token: 0x06009FFE RID: 40958 RVA: 0x00183C53 File Offset: 0x00181E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x00183C5C File Offset: 0x00181E5C
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

		// Token: 0x04004AE5 RID: 19173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE6 RID: 19174
		public const int GiantEcoTypeFieldNumber = 1;

		// Token: 0x04004AE7 RID: 19175
		private int giantEcoType_;
	}
}
