using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106F RID: 4207
	[NetMessage(EMessageId.RoleFavorActiveNotify)]
	public sealed class RoleFavorActiveNotify : IMessage<RoleFavorActiveNotify>, IMessage, IEquatable<RoleFavorActiveNotify>, IDeepCloneable<RoleFavorActiveNotify>, IBufferMessage
	{
		// Token: 0x060167B9 RID: 92089 RVA: 0x00344D3B File Offset: 0x00342F3B
		[NullableContext(1)]
		public static RoleFavorActiveNotify Create()
		{
			return new RoleFavorActiveNotify();
		}

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x060167BA RID: 92090 RVA: 0x00344D42 File Offset: 0x00342F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x060167BB RID: 92091 RVA: 0x00344D45 File Offset: 0x00342F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorActiveNotify.Descriptor;
			}
		}

		// Token: 0x060167BC RID: 92092 RVA: 0x00344D4C File Offset: 0x00342F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorActiveNotify()
		{
		}

		// Token: 0x060167BD RID: 92093 RVA: 0x00344D54 File Offset: 0x00342F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorActiveNotify(RoleFavorActiveNotify other) : this()
		{
			this.roleFavorInfo_ = ((other.roleFavorInfo_ != null) ? other.roleFavorInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167BE RID: 92094 RVA: 0x00344D89 File Offset: 0x00342F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorActiveNotify Clone()
		{
			return new RoleFavorActiveNotify(this);
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x060167BF RID: 92095 RVA: 0x00344D91 File Offset: 0x00342F91
		// (set) Token: 0x060167C0 RID: 92096 RVA: 0x00344D99 File Offset: 0x00342F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor RoleFavorInfo
		{
			get
			{
				return this.roleFavorInfo_;
			}
			set
			{
				this.roleFavorInfo_ = value;
			}
		}

		// Token: 0x060167C1 RID: 92097 RVA: 0x00344DA2 File Offset: 0x00342FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorActiveNotify);
		}

		// Token: 0x060167C2 RID: 92098 RVA: 0x00344DB0 File Offset: 0x00342FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorActiveNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoleFavorInfo, other.RoleFavorInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167C3 RID: 92099 RVA: 0x00344DE4 File Offset: 0x00342FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleFavorInfo_ != null)
			{
				num ^= this.RoleFavorInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060167C4 RID: 92100 RVA: 0x00344E20 File Offset: 0x00343020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167C5 RID: 92101 RVA: 0x00344E2D File Offset: 0x0034302D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167C6 RID: 92102 RVA: 0x00344E36 File Offset: 0x00343036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleFavorInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleFavorInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167C7 RID: 92103 RVA: 0x00344E68 File Offset: 0x00343068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleFavorInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleFavorInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167C8 RID: 92104 RVA: 0x00344EA8 File Offset: 0x003430A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleFavorInfo_ != null)
			{
				if (this.roleFavorInfo_ == null)
				{
					this.RoleFavorInfo = new RoleFavor();
				}
				this.RoleFavorInfo.MergeFrom(other.RoleFavorInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167C9 RID: 92105 RVA: 0x00344EFC File Offset: 0x003430FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167CA RID: 92106 RVA: 0x00344F08 File Offset: 0x00343108
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.roleFavorInfo_ == null)
					{
						this.RoleFavorInfo = new RoleFavor();
					}
					input.ReadMessage(this.RoleFavorInfo);
				}
			}
		}

		// Token: 0x0400867E RID: 34430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400867F RID: 34431
		public const int RoleFavorInfoFieldNumber = 2;

		// Token: 0x04008680 RID: 34432
		private RoleFavor roleFavorInfo_;
	}
}
