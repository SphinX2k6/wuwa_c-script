using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2C RID: 3116
	[NetMessage(EMessageId.PhantomBattleBvBLoadingFinishRequest)]
	public sealed class PhantomBattleBvBLoadingFinishRequest : IMessage<PhantomBattleBvBLoadingFinishRequest>, IMessage, IEquatable<PhantomBattleBvBLoadingFinishRequest>, IDeepCloneable<PhantomBattleBvBLoadingFinishRequest>, IBufferMessage
	{
		// Token: 0x06010EBC RID: 69308 RVA: 0x0027A8D6 File Offset: 0x00278AD6
		[NullableContext(1)]
		public static PhantomBattleBvBLoadingFinishRequest Create()
		{
			return new PhantomBattleBvBLoadingFinishRequest();
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x06010EBD RID: 69309 RVA: 0x0027A8DD File Offset: 0x00278ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x06010EBE RID: 69310 RVA: 0x0027A8E0 File Offset: 0x00278AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBLoadingFinishRequest.Descriptor;
			}
		}

		// Token: 0x06010EBF RID: 69311 RVA: 0x0027A8E7 File Offset: 0x00278AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishRequest()
		{
		}

		// Token: 0x06010EC0 RID: 69312 RVA: 0x0027A8EF File Offset: 0x00278AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishRequest(PhantomBattleBvBLoadingFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EC1 RID: 69313 RVA: 0x0027A908 File Offset: 0x00278B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishRequest Clone()
		{
			return new PhantomBattleBvBLoadingFinishRequest(this);
		}

		// Token: 0x06010EC2 RID: 69314 RVA: 0x0027A910 File Offset: 0x00278B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBLoadingFinishRequest);
		}

		// Token: 0x06010EC3 RID: 69315 RVA: 0x0027A91E File Offset: 0x00278B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBLoadingFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010EC4 RID: 69316 RVA: 0x0027A93C File Offset: 0x00278B3C
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

		// Token: 0x06010EC5 RID: 69317 RVA: 0x0027A962 File Offset: 0x00278B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EC6 RID: 69318 RVA: 0x0027A96F File Offset: 0x00278B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EC7 RID: 69319 RVA: 0x0027A978 File Offset: 0x00278B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EC8 RID: 69320 RVA: 0x0027A990 File Offset: 0x00278B90
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

		// Token: 0x06010EC9 RID: 69321 RVA: 0x0027A9B6 File Offset: 0x00278BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBLoadingFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010ECA RID: 69322 RVA: 0x0027A9D3 File Offset: 0x00278BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010ECB RID: 69323 RVA: 0x0027A9DC File Offset: 0x00278BDC
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

		// Token: 0x04006BB4 RID: 27572
		private UnknownFieldSet _unknownFields;
	}
}
