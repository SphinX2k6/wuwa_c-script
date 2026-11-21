using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FD RID: 4349
	public sealed class RoleTowerTokenPanelInfo : IMessage<RoleTowerTokenPanelInfo>, IMessage, IEquatable<RoleTowerTokenPanelInfo>, IDeepCloneable<RoleTowerTokenPanelInfo>, IBufferMessage
	{
		// Token: 0x06017408 RID: 95240 RVA: 0x003626E4 File Offset: 0x003608E4
		[NullableContext(1)]
		public static RoleTowerTokenPanelInfo Create()
		{
			return new RoleTowerTokenPanelInfo();
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x06017409 RID: 95241 RVA: 0x003626EB File Offset: 0x003608EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x0601740A RID: 95242 RVA: 0x003626EE File Offset: 0x003608EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTokenPanelInfo.Descriptor;
			}
		}

		// Token: 0x0601740B RID: 95243 RVA: 0x003626F5 File Offset: 0x003608F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenPanelInfo()
		{
		}

		// Token: 0x0601740C RID: 95244 RVA: 0x00362708 File Offset: 0x00360908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenPanelInfo(RoleTowerTokenPanelInfo other) : this()
		{
			this.tokens_ = other.tokens_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601740D RID: 95245 RVA: 0x00362732 File Offset: 0x00360932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenPanelInfo Clone()
		{
			return new RoleTowerTokenPanelInfo(this);
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x0601740E RID: 95246 RVA: 0x0036273A File Offset: 0x0036093A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerTokenInfo> Tokens
		{
			get
			{
				return this.tokens_;
			}
		}

		// Token: 0x0601740F RID: 95247 RVA: 0x00362742 File Offset: 0x00360942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTokenPanelInfo);
		}

		// Token: 0x06017410 RID: 95248 RVA: 0x00362750 File Offset: 0x00360950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTokenPanelInfo other)
		{
			return other != null && (other == this || (this.tokens_.Equals(other.tokens_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017411 RID: 95249 RVA: 0x00362784 File Offset: 0x00360984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tokens_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017412 RID: 95250 RVA: 0x003627B8 File Offset: 0x003609B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017413 RID: 95251 RVA: 0x003627C5 File Offset: 0x003609C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017414 RID: 95252 RVA: 0x003627CE File Offset: 0x003609CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tokens_.WriteTo(ref output, RoleTowerTokenPanelInfo._repeated_tokens_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017415 RID: 95253 RVA: 0x003627F8 File Offset: 0x003609F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tokens_.CalculateSize(RoleTowerTokenPanelInfo._repeated_tokens_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017416 RID: 95254 RVA: 0x00362831 File Offset: 0x00360A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTokenPanelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.tokens_.Add(other.tokens_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017417 RID: 95255 RVA: 0x0036285F File Offset: 0x00360A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017418 RID: 95256 RVA: 0x00362868 File Offset: 0x00360A68
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
					this.tokens_.AddEntriesFrom(ref input, RoleTowerTokenPanelInfo._repeated_tokens_codec);
				}
			}
		}

		// Token: 0x04008B11 RID: 35601
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B12 RID: 35602
		public const int TokensFieldNumber = 2;

		// Token: 0x04008B13 RID: 35603
		private static readonly FieldCodec<RoleTowerTokenInfo> _repeated_tokens_codec = FieldCodec.ForMessage<RoleTowerTokenInfo>(18U, RoleTowerTokenInfo.Parser);

		// Token: 0x04008B14 RID: 35604
		private readonly RepeatedField<RoleTowerTokenInfo> tokens_ = new RepeatedField<RoleTowerTokenInfo>();
	}
}
