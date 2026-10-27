using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000240 RID: 576
	[NetMessage(EMessageId.CdKeyVerifyRequest)]
	public sealed class CdKeyVerifyRequest : IMessage<CdKeyVerifyRequest>, IMessage, IEquatable<CdKeyVerifyRequest>, IDeepCloneable<CdKeyVerifyRequest>, IBufferMessage
	{
		// Token: 0x06003DE9 RID: 15849 RVA: 0x000991A9 File Offset: 0x000973A9
		[NullableContext(1)]
		public static CdKeyVerifyRequest Create()
		{
			return new CdKeyVerifyRequest();
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x000991B0 File Offset: 0x000973B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x000991B3 File Offset: 0x000973B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CdKeyVerifyRequest.Descriptor;
			}
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x000991BA File Offset: 0x000973BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyRequest()
		{
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x000991CD File Offset: 0x000973CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyRequest(CdKeyVerifyRequest other) : this()
		{
			this.cdKey_ = other.cdKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000991F2 File Offset: 0x000973F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyRequest Clone()
		{
			return new CdKeyVerifyRequest(this);
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x000991FA File Offset: 0x000973FA
		// (set) Token: 0x06003DF0 RID: 15856 RVA: 0x00099202 File Offset: 0x00097402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CdKey
		{
			get
			{
				return this.cdKey_;
			}
			set
			{
				this.cdKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00099215 File Offset: 0x00097415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CdKeyVerifyRequest);
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00099223 File Offset: 0x00097423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CdKeyVerifyRequest other)
		{
			return other != null && (other == this || (!(this.CdKey != other.CdKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00099258 File Offset: 0x00097458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CdKey.Length != 0)
			{
				num ^= this.CdKey.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00099299 File Offset: 0x00097499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x000992A6 File Offset: 0x000974A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x000992AF File Offset: 0x000974AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CdKey.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.CdKey);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x000992E8 File Offset: 0x000974E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CdKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CdKey);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x0009932B File Offset: 0x0009752B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CdKeyVerifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CdKey.Length != 0)
			{
				this.CdKey = other.CdKey;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00099361 File Offset: 0x00097561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x0009936C File Offset: 0x0009756C
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
					this.CdKey = input.ReadString();
				}
			}
		}

		// Token: 0x04002CC6 RID: 11462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC7 RID: 11463
		public const int CdKeyFieldNumber = 13;

		// Token: 0x04002CC8 RID: 11464
		private string cdKey_ = "";
	}
}
