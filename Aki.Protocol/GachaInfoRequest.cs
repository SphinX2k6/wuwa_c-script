using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067E RID: 1662
	[NetMessage(EMessageId.GachaInfoRequest)]
	public sealed class GachaInfoRequest : IMessage<GachaInfoRequest>, IMessage, IEquatable<GachaInfoRequest>, IDeepCloneable<GachaInfoRequest>, IBufferMessage
	{
		// Token: 0x060098AF RID: 39087 RVA: 0x00170B04 File Offset: 0x0016ED04
		[NullableContext(1)]
		public static GachaInfoRequest Create()
		{
			return new GachaInfoRequest();
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x060098B0 RID: 39088 RVA: 0x00170B0B File Offset: 0x0016ED0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x060098B1 RID: 39089 RVA: 0x00170B0E File Offset: 0x0016ED0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfoRequest.Descriptor;
			}
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x00170B15 File Offset: 0x0016ED15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoRequest()
		{
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x00170B1D File Offset: 0x0016ED1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoRequest(GachaInfoRequest other) : this()
		{
			this.language_ = other.language_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x00170B42 File Offset: 0x0016ED42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoRequest Clone()
		{
			return new GachaInfoRequest(this);
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x00170B4A File Offset: 0x0016ED4A
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x00170B52 File Offset: 0x0016ED52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Language
		{
			get
			{
				return this.language_;
			}
			set
			{
				this.language_ = value;
			}
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x00170B5B File Offset: 0x0016ED5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfoRequest);
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x00170B69 File Offset: 0x0016ED69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfoRequest other)
		{
			return other != null && (other == this || (this.Language == other.Language && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x00170B98 File Offset: 0x0016ED98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Language != 0)
			{
				num ^= this.Language.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x00170BD7 File Offset: 0x0016EDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x00170BE4 File Offset: 0x0016EDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x00170BED File Offset: 0x0016EDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Language != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Language);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x00170C20 File Offset: 0x0016EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Language != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Language);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x00170C5E File Offset: 0x0016EE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Language != 0)
			{
				this.Language = other.Language;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x00170C8F File Offset: 0x0016EE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x00170C98 File Offset: 0x0016EE98
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
					this.Language = input.ReadInt32();
				}
			}
		}

		// Token: 0x040048D7 RID: 18647
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048D8 RID: 18648
		public const int LanguageFieldNumber = 1;

		// Token: 0x040048D9 RID: 18649
		private int language_;
	}
}
