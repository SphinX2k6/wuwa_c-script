using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA2 RID: 2978
	[NetMessage(EMessageId.OrnamentInfoNotify)]
	public sealed class OrnamentInfoNotify : IMessage<OrnamentInfoNotify>, IMessage, IEquatable<OrnamentInfoNotify>, IDeepCloneable<OrnamentInfoNotify>, IBufferMessage
	{
		// Token: 0x060102B7 RID: 66231 RVA: 0x0025CC91 File Offset: 0x0025AE91
		[NullableContext(1)]
		public static OrnamentInfoNotify Create()
		{
			return new OrnamentInfoNotify();
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x060102B8 RID: 66232 RVA: 0x0025CC98 File Offset: 0x0025AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x060102B9 RID: 66233 RVA: 0x0025CC9B File Offset: 0x0025AE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentInfoNotify.Descriptor;
			}
		}

		// Token: 0x060102BA RID: 66234 RVA: 0x0025CCA2 File Offset: 0x0025AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfoNotify()
		{
		}

		// Token: 0x060102BB RID: 66235 RVA: 0x0025CCAA File Offset: 0x0025AEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfoNotify(OrnamentInfoNotify other) : this()
		{
			this.ornamentInfo_ = ((other.ornamentInfo_ != null) ? other.ornamentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102BC RID: 66236 RVA: 0x0025CCDF File Offset: 0x0025AEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfoNotify Clone()
		{
			return new OrnamentInfoNotify(this);
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x060102BD RID: 66237 RVA: 0x0025CCE7 File Offset: 0x0025AEE7
		// (set) Token: 0x060102BE RID: 66238 RVA: 0x0025CCEF File Offset: 0x0025AEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfo OrnamentInfo
		{
			get
			{
				return this.ornamentInfo_;
			}
			set
			{
				this.ornamentInfo_ = value;
			}
		}

		// Token: 0x060102BF RID: 66239 RVA: 0x0025CCF8 File Offset: 0x0025AEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentInfoNotify);
		}

		// Token: 0x060102C0 RID: 66240 RVA: 0x0025CD06 File Offset: 0x0025AF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.OrnamentInfo, other.OrnamentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102C1 RID: 66241 RVA: 0x0025CD3C File Offset: 0x0025AF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ornamentInfo_ != null)
			{
				num ^= this.OrnamentInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060102C2 RID: 66242 RVA: 0x0025CD78 File Offset: 0x0025AF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102C3 RID: 66243 RVA: 0x0025CD85 File Offset: 0x0025AF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102C4 RID: 66244 RVA: 0x0025CD8E File Offset: 0x0025AF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ornamentInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.OrnamentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060102C5 RID: 66245 RVA: 0x0025CDC0 File Offset: 0x0025AFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ornamentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OrnamentInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060102C6 RID: 66246 RVA: 0x0025CE00 File Offset: 0x0025B000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ornamentInfo_ != null)
			{
				if (this.ornamentInfo_ == null)
				{
					this.OrnamentInfo = new OrnamentInfo();
				}
				this.OrnamentInfo.MergeFrom(other.OrnamentInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060102C7 RID: 66247 RVA: 0x0025CE54 File Offset: 0x0025B054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102C8 RID: 66248 RVA: 0x0025CE60 File Offset: 0x0025B060
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.ornamentInfo_ == null)
					{
						this.OrnamentInfo = new OrnamentInfo();
					}
					input.ReadMessage(this.OrnamentInfo);
				}
			}
		}

		// Token: 0x0400676A RID: 26474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400676B RID: 26475
		public const int OrnamentInfoFieldNumber = 12;

		// Token: 0x0400676C RID: 26476
		private OrnamentInfo ornamentInfo_;
	}
}
