using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001284 RID: 4740
	[NetMessage(EMessageId.SpringSignSkinRewardRequest)]
	public sealed class SpringSignSkinRewardRequest : IMessage<SpringSignSkinRewardRequest>, IMessage, IEquatable<SpringSignSkinRewardRequest>, IDeepCloneable<SpringSignSkinRewardRequest>, IBufferMessage
	{
		// Token: 0x060193E3 RID: 103395 RVA: 0x003ABFBD File Offset: 0x003AA1BD
		[NullableContext(1)]
		public static SpringSignSkinRewardRequest Create()
		{
			return new SpringSignSkinRewardRequest();
		}

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x060193E4 RID: 103396 RVA: 0x003ABFC4 File Offset: 0x003AA1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x060193E5 RID: 103397 RVA: 0x003ABFC7 File Offset: 0x003AA1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignSkinRewardRequest.Descriptor;
			}
		}

		// Token: 0x060193E6 RID: 103398 RVA: 0x003ABFCE File Offset: 0x003AA1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardRequest()
		{
		}

		// Token: 0x060193E7 RID: 103399 RVA: 0x003ABFD6 File Offset: 0x003AA1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardRequest(SpringSignSkinRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193E8 RID: 103400 RVA: 0x003ABFEF File Offset: 0x003AA1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardRequest Clone()
		{
			return new SpringSignSkinRewardRequest(this);
		}

		// Token: 0x060193E9 RID: 103401 RVA: 0x003ABFF7 File Offset: 0x003AA1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignSkinRewardRequest);
		}

		// Token: 0x060193EA RID: 103402 RVA: 0x003AC005 File Offset: 0x003AA205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignSkinRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060193EB RID: 103403 RVA: 0x003AC024 File Offset: 0x003AA224
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

		// Token: 0x060193EC RID: 103404 RVA: 0x003AC04A File Offset: 0x003AA24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193ED RID: 103405 RVA: 0x003AC057 File Offset: 0x003AA257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193EE RID: 103406 RVA: 0x003AC060 File Offset: 0x003AA260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060193EF RID: 103407 RVA: 0x003AC078 File Offset: 0x003AA278
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

		// Token: 0x060193F0 RID: 103408 RVA: 0x003AC09E File Offset: 0x003AA29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignSkinRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060193F1 RID: 103409 RVA: 0x003AC0BB File Offset: 0x003AA2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193F2 RID: 103410 RVA: 0x003AC0C4 File Offset: 0x003AA2C4
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

		// Token: 0x0400947D RID: 38013
		private UnknownFieldSet _unknownFields;
	}
}
