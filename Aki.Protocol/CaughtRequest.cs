using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023E RID: 574
	[NetMessage(EMessageId.CaughtRequest)]
	public sealed class CaughtRequest : IMessage<CaughtRequest>, IMessage, IEquatable<CaughtRequest>, IDeepCloneable<CaughtRequest>, IBufferMessage
	{
		// Token: 0x06003DC5 RID: 15813 RVA: 0x00098DA4 File Offset: 0x00096FA4
		[NullableContext(1)]
		public static CaughtRequest Create()
		{
			return new CaughtRequest();
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x00098DAB File Offset: 0x00096FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x00098DAE File Offset: 0x00096FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtRequest.Descriptor;
			}
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00098DB5 File Offset: 0x00096FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest()
		{
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00098DBD File Offset: 0x00096FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest(CaughtRequest other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00098DF2 File Offset: 0x00096FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest Clone()
		{
			return new CaughtRequest(this);
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003DCB RID: 15819 RVA: 0x00098DFA File Offset: 0x00096FFA
		// (set) Token: 0x06003DCC RID: 15820 RVA: 0x00098E02 File Offset: 0x00097002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00098E0B File Offset: 0x0009700B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtRequest);
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00098E19 File Offset: 0x00097019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00098E4C File Offset: 0x0009704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00098E88 File Offset: 0x00097088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00098E95 File Offset: 0x00097095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00098E9E File Offset: 0x0009709E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00098ED0 File Offset: 0x000970D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00098F10 File Offset: 0x00097110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new CaughtInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00098F64 File Offset: 0x00097164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00098F70 File Offset: 0x00097170
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new CaughtInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002CC0 RID: 11456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC1 RID: 11457
		public const int InfoFieldNumber = 13;

		// Token: 0x04002CC2 RID: 11458
		private CaughtInfo info_;
	}
}
