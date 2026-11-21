using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000243 RID: 579
	[NetMessage(EMessageId.CaughtRequest)]
	public sealed class CaughtRequest : IMessage<CaughtRequest>, IMessage, IEquatable<CaughtRequest>, IDeepCloneable<CaughtRequest>, IBufferMessage
	{
		// Token: 0x06003E6A RID: 15978 RVA: 0x0009A9C0 File Offset: 0x00098BC0
		[NullableContext(1)]
		public static CaughtRequest Create()
		{
			return new CaughtRequest();
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x0009A9C7 File Offset: 0x00098BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x0009A9CA File Offset: 0x00098BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtRequest.Descriptor;
			}
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0009A9D1 File Offset: 0x00098BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest()
		{
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0009A9D9 File Offset: 0x00098BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest(CaughtRequest other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x0009AA0E File Offset: 0x00098C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest Clone()
		{
			return new CaughtRequest(this);
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x0009AA16 File Offset: 0x00098C16
		// (set) Token: 0x06003E71 RID: 15985 RVA: 0x0009AA1E File Offset: 0x00098C1E
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

		// Token: 0x06003E72 RID: 15986 RVA: 0x0009AA27 File Offset: 0x00098C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtRequest);
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0009AA35 File Offset: 0x00098C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0009AA68 File Offset: 0x00098C68
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

		// Token: 0x06003E75 RID: 15989 RVA: 0x0009AAA4 File Offset: 0x00098CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x0009AAB1 File Offset: 0x00098CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0009AABA File Offset: 0x00098CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x0009AAEC File Offset: 0x00098CEC
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

		// Token: 0x06003E79 RID: 15993 RVA: 0x0009AB2C File Offset: 0x00098D2C
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

		// Token: 0x06003E7A RID: 15994 RVA: 0x0009AB80 File Offset: 0x00098D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0009AB8C File Offset: 0x00098D8C
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
				if (num != 74U)
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

		// Token: 0x04002D42 RID: 11586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D43 RID: 11587
		public const int InfoFieldNumber = 9;

		// Token: 0x04002D44 RID: 11588
		private CaughtInfo info_;
	}
}
