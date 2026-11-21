using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F19 RID: 3865
	[NetMessage(EMessageId.ResonantChainOptionalLimitRequest)]
	public sealed class ResonantChainOptionalLimitRequest : IMessage<ResonantChainOptionalLimitRequest>, IMessage, IEquatable<ResonantChainOptionalLimitRequest>, IDeepCloneable<ResonantChainOptionalLimitRequest>, IBufferMessage
	{
		// Token: 0x06014B63 RID: 84835 RVA: 0x00301F2F File Offset: 0x0030012F
		[NullableContext(1)]
		public static ResonantChainOptionalLimitRequest Create()
		{
			return new ResonantChainOptionalLimitRequest();
		}

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x06014B64 RID: 84836 RVA: 0x00301F36 File Offset: 0x00300136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x06014B65 RID: 84837 RVA: 0x00301F39 File Offset: 0x00300139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainOptionalLimitRequest.Descriptor;
			}
		}

		// Token: 0x06014B66 RID: 84838 RVA: 0x00301F40 File Offset: 0x00300140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitRequest()
		{
		}

		// Token: 0x06014B67 RID: 84839 RVA: 0x00301F48 File Offset: 0x00300148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitRequest(ResonantChainOptionalLimitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B68 RID: 84840 RVA: 0x00301F61 File Offset: 0x00300161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitRequest Clone()
		{
			return new ResonantChainOptionalLimitRequest(this);
		}

		// Token: 0x06014B69 RID: 84841 RVA: 0x00301F69 File Offset: 0x00300169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainOptionalLimitRequest);
		}

		// Token: 0x06014B6A RID: 84842 RVA: 0x00301F77 File Offset: 0x00300177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainOptionalLimitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014B6B RID: 84843 RVA: 0x00301F98 File Offset: 0x00300198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B6C RID: 84844 RVA: 0x00301FBE File Offset: 0x003001BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B6D RID: 84845 RVA: 0x00301FCB File Offset: 0x003001CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B6E RID: 84846 RVA: 0x00301FD4 File Offset: 0x003001D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B6F RID: 84847 RVA: 0x00301FEC File Offset: 0x003001EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B70 RID: 84848 RVA: 0x00302012 File Offset: 0x00300212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainOptionalLimitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B71 RID: 84849 RVA: 0x0030202F File Offset: 0x0030022F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B72 RID: 84850 RVA: 0x00302038 File Offset: 0x00300238
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D8A RID: 32138
		private UnknownFieldSet _unknownFields;
	}
}
