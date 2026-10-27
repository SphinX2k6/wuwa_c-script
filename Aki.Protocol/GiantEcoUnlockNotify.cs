using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DA RID: 1754
	[NetMessage(EMessageId.GiantEcoUnlockNotify)]
	public sealed class GiantEcoUnlockNotify : IMessage<GiantEcoUnlockNotify>, IMessage, IEquatable<GiantEcoUnlockNotify>, IDeepCloneable<GiantEcoUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600A029 RID: 41001 RVA: 0x00183F4C File Offset: 0x0018214C
		[NullableContext(1)]
		public static GiantEcoUnlockNotify Create()
		{
			return new GiantEcoUnlockNotify();
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600A02A RID: 41002 RVA: 0x00183F53 File Offset: 0x00182153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600A02B RID: 41003 RVA: 0x00183F56 File Offset: 0x00182156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantEcoUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x00183F5D File Offset: 0x0018215D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoUnlockNotify()
		{
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x00183F65 File Offset: 0x00182165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoUnlockNotify(GiantEcoUnlockNotify other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x00183F8A File Offset: 0x0018218A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoUnlockNotify Clone()
		{
			return new GiantEcoUnlockNotify(this);
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600A02F RID: 41007 RVA: 0x00183F92 File Offset: 0x00182192
		// (set) Token: 0x0600A030 RID: 41008 RVA: 0x00183F9A File Offset: 0x0018219A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetType GiantEcoType
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

		// Token: 0x0600A031 RID: 41009 RVA: 0x00183FA3 File Offset: 0x001821A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantEcoUnlockNotify);
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x00183FB1 File Offset: 0x001821B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantEcoUnlockNotify other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x00183FE0 File Offset: 0x001821E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num ^= this.GiantEcoType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x00184025 File Offset: 0x00182225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x00184032 File Offset: 0x00182232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x0018403B File Offset: 0x0018223B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x00184070 File Offset: 0x00182270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x001840AE File Offset: 0x001822AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantEcoUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantEcoType != GiantEcoNetType.Fire)
			{
				this.GiantEcoType = other.GiantEcoType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x001840DF File Offset: 0x001822DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x001840E8 File Offset: 0x001822E8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A9F RID: 19103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AA0 RID: 19104
		public const int GiantEcoTypeFieldNumber = 14;

		// Token: 0x04004AA1 RID: 19105
		private GiantEcoNetType giantEcoType_;
	}
}
