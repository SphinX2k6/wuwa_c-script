using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB2 RID: 2994
	[NetMessage(EMessageId.OrnamentInfoNotify)]
	public sealed class OrnamentInfoNotify : IMessage<OrnamentInfoNotify>, IMessage, IEquatable<OrnamentInfoNotify>, IDeepCloneable<OrnamentInfoNotify>, IBufferMessage
	{
		// Token: 0x060103BB RID: 66491 RVA: 0x0025EB49 File Offset: 0x0025CD49
		[NullableContext(1)]
		public static OrnamentInfoNotify Create()
		{
			return new OrnamentInfoNotify();
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x060103BC RID: 66492 RVA: 0x0025EB50 File Offset: 0x0025CD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x060103BD RID: 66493 RVA: 0x0025EB53 File Offset: 0x0025CD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentInfoNotify.Descriptor;
			}
		}

		// Token: 0x060103BE RID: 66494 RVA: 0x0025EB5A File Offset: 0x0025CD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfoNotify()
		{
		}

		// Token: 0x060103BF RID: 66495 RVA: 0x0025EB62 File Offset: 0x0025CD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfoNotify(OrnamentInfoNotify other) : this()
		{
			this.ornamentInfo_ = ((other.ornamentInfo_ != null) ? other.ornamentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103C0 RID: 66496 RVA: 0x0025EB97 File Offset: 0x0025CD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentInfoNotify Clone()
		{
			return new OrnamentInfoNotify(this);
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x060103C1 RID: 66497 RVA: 0x0025EB9F File Offset: 0x0025CD9F
		// (set) Token: 0x060103C2 RID: 66498 RVA: 0x0025EBA7 File Offset: 0x0025CDA7
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

		// Token: 0x060103C3 RID: 66499 RVA: 0x0025EBB0 File Offset: 0x0025CDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentInfoNotify);
		}

		// Token: 0x060103C4 RID: 66500 RVA: 0x0025EBBE File Offset: 0x0025CDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.OrnamentInfo, other.OrnamentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103C5 RID: 66501 RVA: 0x0025EBF4 File Offset: 0x0025CDF4
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

		// Token: 0x060103C6 RID: 66502 RVA: 0x0025EC30 File Offset: 0x0025CE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103C7 RID: 66503 RVA: 0x0025EC3D File Offset: 0x0025CE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103C8 RID: 66504 RVA: 0x0025EC46 File Offset: 0x0025CE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ornamentInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.OrnamentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103C9 RID: 66505 RVA: 0x0025EC78 File Offset: 0x0025CE78
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

		// Token: 0x060103CA RID: 66506 RVA: 0x0025ECB8 File Offset: 0x0025CEB8
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

		// Token: 0x060103CB RID: 66507 RVA: 0x0025ED0C File Offset: 0x0025CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103CC RID: 66508 RVA: 0x0025ED18 File Offset: 0x0025CF18
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
				if (num != 66U)
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

		// Token: 0x0400675A RID: 26458
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400675B RID: 26459
		public const int OrnamentInfoFieldNumber = 8;

		// Token: 0x0400675C RID: 26460
		private OrnamentInfo ornamentInfo_;
	}
}
