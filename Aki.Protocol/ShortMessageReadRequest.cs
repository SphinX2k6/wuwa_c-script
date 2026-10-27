using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001205 RID: 4613
	[NetMessage(EMessageId.ShortMessageReadRequest)]
	public sealed class ShortMessageReadRequest : IMessage<ShortMessageReadRequest>, IMessage, IEquatable<ShortMessageReadRequest>, IDeepCloneable<ShortMessageReadRequest>, IBufferMessage
	{
		// Token: 0x0601897A RID: 100730 RVA: 0x00393C32 File Offset: 0x00391E32
		[NullableContext(1)]
		public static ShortMessageReadRequest Create()
		{
			return new ShortMessageReadRequest();
		}

		// Token: 0x170052DE RID: 21214
		// (get) Token: 0x0601897B RID: 100731 RVA: 0x00393C39 File Offset: 0x00391E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052DF RID: 21215
		// (get) Token: 0x0601897C RID: 100732 RVA: 0x00393C3C File Offset: 0x00391E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReadRequest.Descriptor;
			}
		}

		// Token: 0x0601897D RID: 100733 RVA: 0x00393C43 File Offset: 0x00391E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadRequest()
		{
		}

		// Token: 0x0601897E RID: 100734 RVA: 0x00393C4B File Offset: 0x00391E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadRequest(ShortMessageReadRequest other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601897F RID: 100735 RVA: 0x00393C70 File Offset: 0x00391E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadRequest Clone()
		{
			return new ShortMessageReadRequest(this);
		}

		// Token: 0x170052E0 RID: 21216
		// (get) Token: 0x06018980 RID: 100736 RVA: 0x00393C78 File Offset: 0x00391E78
		// (set) Token: 0x06018981 RID: 100737 RVA: 0x00393C80 File Offset: 0x00391E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06018982 RID: 100738 RVA: 0x00393C89 File Offset: 0x00391E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReadRequest);
		}

		// Token: 0x06018983 RID: 100739 RVA: 0x00393C97 File Offset: 0x00391E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReadRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018984 RID: 100740 RVA: 0x00393CC8 File Offset: 0x00391EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018985 RID: 100741 RVA: 0x00393D07 File Offset: 0x00391F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018986 RID: 100742 RVA: 0x00393D14 File Offset: 0x00391F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018987 RID: 100743 RVA: 0x00393D1D File Offset: 0x00391F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018988 RID: 100744 RVA: 0x00393D50 File Offset: 0x00391F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018989 RID: 100745 RVA: 0x00393D8E File Offset: 0x00391F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601898A RID: 100746 RVA: 0x00393DBF File Offset: 0x00391FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601898B RID: 100747 RVA: 0x00393DC8 File Offset: 0x00391FC8
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
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009162 RID: 37218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009163 RID: 37219
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009164 RID: 37220
		private int configId_;
	}
}
