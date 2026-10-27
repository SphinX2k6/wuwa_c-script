using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E4 RID: 1764
	public sealed class GiantResponsePlayAnimationPb : IMessage<GiantResponsePlayAnimationPb>, IMessage, IEquatable<GiantResponsePlayAnimationPb>, IDeepCloneable<GiantResponsePlayAnimationPb>, IBufferMessage
	{
		// Token: 0x0600A0F6 RID: 41206 RVA: 0x00185B1E File Offset: 0x00183D1E
		[NullableContext(1)]
		public static GiantResponsePlayAnimationPb Create()
		{
			return new GiantResponsePlayAnimationPb();
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x00185B25 File Offset: 0x00183D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600A0F8 RID: 41208 RVA: 0x00185B28 File Offset: 0x00183D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponsePlayAnimationPb.Descriptor;
			}
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x00185B2F File Offset: 0x00183D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb()
		{
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x00185B37 File Offset: 0x00183D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb(GiantResponsePlayAnimationPb other) : this()
		{
			this.giantAnimationId_ = other.giantAnimationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x00185B5C File Offset: 0x00183D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb Clone()
		{
			return new GiantResponsePlayAnimationPb(this);
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600A0FC RID: 41212 RVA: 0x00185B64 File Offset: 0x00183D64
		// (set) Token: 0x0600A0FD RID: 41213 RVA: 0x00185B6C File Offset: 0x00183D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GiantAnimationId
		{
			get
			{
				return this.giantAnimationId_;
			}
			set
			{
				this.giantAnimationId_ = value;
			}
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x00185B75 File Offset: 0x00183D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponsePlayAnimationPb);
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x00185B83 File Offset: 0x00183D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponsePlayAnimationPb other)
		{
			return other != null && (other == this || (this.GiantAnimationId == other.GiantAnimationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x00185BB4 File Offset: 0x00183DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantAnimationId != 0)
			{
				num ^= this.GiantAnimationId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x00185BF3 File Offset: 0x00183DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x00185C00 File Offset: 0x00183E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x00185C09 File Offset: 0x00183E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantAnimationId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GiantAnimationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x00185C3C File Offset: 0x00183E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantAnimationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiantAnimationId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x00185C7A File Offset: 0x00183E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponsePlayAnimationPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantAnimationId != 0)
			{
				this.GiantAnimationId = other.GiantAnimationId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x00185CAB File Offset: 0x00183EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x00185CB4 File Offset: 0x00183EB4
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
					this.GiantAnimationId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004AD8 RID: 19160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD9 RID: 19161
		public const int GiantAnimationIdFieldNumber = 1;

		// Token: 0x04004ADA RID: 19162
		private int giantAnimationId_;
	}
}
