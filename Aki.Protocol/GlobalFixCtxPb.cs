using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E4 RID: 1764
	public sealed class GlobalFixCtxPb : IMessage<GlobalFixCtxPb>, IMessage, IEquatable<GlobalFixCtxPb>, IDeepCloneable<GlobalFixCtxPb>, IBufferMessage
	{
		// Token: 0x0600A135 RID: 41269 RVA: 0x00186704 File Offset: 0x00184904
		[NullableContext(1)]
		public static GlobalFixCtxPb Create()
		{
			return new GlobalFixCtxPb();
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600A136 RID: 41270 RVA: 0x0018670B File Offset: 0x0018490B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x0600A137 RID: 41271 RVA: 0x0018670E File Offset: 0x0018490E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalFixCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x00186715 File Offset: 0x00184915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb()
		{
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x0018671D File Offset: 0x0018491D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb(GlobalFixCtxPb other) : this()
		{
			this.fixId_ = other.fixId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x00186742 File Offset: 0x00184942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb Clone()
		{
			return new GlobalFixCtxPb(this);
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600A13B RID: 41275 RVA: 0x0018674A File Offset: 0x0018494A
		// (set) Token: 0x0600A13C RID: 41276 RVA: 0x00186752 File Offset: 0x00184952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FixId
		{
			get
			{
				return this.fixId_;
			}
			set
			{
				this.fixId_ = value;
			}
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x0018675B File Offset: 0x0018495B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalFixCtxPb);
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x00186769 File Offset: 0x00184969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GlobalFixCtxPb other)
		{
			return other != null && (other == this || (this.FixId == other.FixId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x00186798 File Offset: 0x00184998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FixId != 0)
			{
				num ^= this.FixId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x001867D7 File Offset: 0x001849D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x001867E4 File Offset: 0x001849E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x001867ED File Offset: 0x001849ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FixId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FixId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x00186820 File Offset: 0x00184A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FixId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FixId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x0018685E File Offset: 0x00184A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GlobalFixCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FixId != 0)
			{
				this.FixId = other.FixId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x0018688F File Offset: 0x00184A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x00186898 File Offset: 0x00184A98
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
					this.FixId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B48 RID: 19272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B49 RID: 19273
		public const int FixIdFieldNumber = 1;

		// Token: 0x04004B4A RID: 19274
		private int fixId_;
	}
}
