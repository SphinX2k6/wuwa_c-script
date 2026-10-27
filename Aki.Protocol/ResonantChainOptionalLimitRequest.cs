using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F29 RID: 3881
	[NetMessage(EMessageId.ResonantChainOptionalLimitRequest)]
	public sealed class ResonantChainOptionalLimitRequest : IMessage<ResonantChainOptionalLimitRequest>, IMessage, IEquatable<ResonantChainOptionalLimitRequest>, IDeepCloneable<ResonantChainOptionalLimitRequest>, IBufferMessage
	{
		// Token: 0x06014C48 RID: 85064 RVA: 0x003035EB File Offset: 0x003017EB
		[NullableContext(1)]
		public static ResonantChainOptionalLimitRequest Create()
		{
			return new ResonantChainOptionalLimitRequest();
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x06014C49 RID: 85065 RVA: 0x003035F2 File Offset: 0x003017F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x06014C4A RID: 85066 RVA: 0x003035F5 File Offset: 0x003017F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainOptionalLimitRequest.Descriptor;
			}
		}

		// Token: 0x06014C4B RID: 85067 RVA: 0x003035FC File Offset: 0x003017FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitRequest()
		{
		}

		// Token: 0x06014C4C RID: 85068 RVA: 0x00303604 File Offset: 0x00301804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitRequest(ResonantChainOptionalLimitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C4D RID: 85069 RVA: 0x0030361D File Offset: 0x0030181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitRequest Clone()
		{
			return new ResonantChainOptionalLimitRequest(this);
		}

		// Token: 0x06014C4E RID: 85070 RVA: 0x00303625 File Offset: 0x00301825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainOptionalLimitRequest);
		}

		// Token: 0x06014C4F RID: 85071 RVA: 0x00303633 File Offset: 0x00301833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainOptionalLimitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014C50 RID: 85072 RVA: 0x00303654 File Offset: 0x00301854
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

		// Token: 0x06014C51 RID: 85073 RVA: 0x0030367A File Offset: 0x0030187A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C52 RID: 85074 RVA: 0x00303687 File Offset: 0x00301887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C53 RID: 85075 RVA: 0x00303690 File Offset: 0x00301890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C54 RID: 85076 RVA: 0x003036A8 File Offset: 0x003018A8
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

		// Token: 0x06014C55 RID: 85077 RVA: 0x003036CE File Offset: 0x003018CE
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

		// Token: 0x06014C56 RID: 85078 RVA: 0x003036EB File Offset: 0x003018EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C57 RID: 85079 RVA: 0x003036F4 File Offset: 0x003018F4
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

		// Token: 0x04007D60 RID: 32096
		private UnknownFieldSet _unknownFields;
	}
}
