using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F3 RID: 4851
	[NetMessage(EMessageId.SpringSignSkinRewardRequest)]
	public sealed class SpringSignSkinRewardRequest : IMessage<SpringSignSkinRewardRequest>, IMessage, IEquatable<SpringSignSkinRewardRequest>, IDeepCloneable<SpringSignSkinRewardRequest>, IBufferMessage
	{
		// Token: 0x06019E19 RID: 106009 RVA: 0x003C66ED File Offset: 0x003C48ED
		[NullableContext(1)]
		public static SpringSignSkinRewardRequest Create()
		{
			return new SpringSignSkinRewardRequest();
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x06019E1A RID: 106010 RVA: 0x003C66F4 File Offset: 0x003C48F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x06019E1B RID: 106011 RVA: 0x003C66F7 File Offset: 0x003C48F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignSkinRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019E1C RID: 106012 RVA: 0x003C66FE File Offset: 0x003C48FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardRequest()
		{
		}

		// Token: 0x06019E1D RID: 106013 RVA: 0x003C6706 File Offset: 0x003C4906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardRequest(SpringSignSkinRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E1E RID: 106014 RVA: 0x003C671F File Offset: 0x003C491F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardRequest Clone()
		{
			return new SpringSignSkinRewardRequest(this);
		}

		// Token: 0x06019E1F RID: 106015 RVA: 0x003C6727 File Offset: 0x003C4927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignSkinRewardRequest);
		}

		// Token: 0x06019E20 RID: 106016 RVA: 0x003C6735 File Offset: 0x003C4935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignSkinRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019E21 RID: 106017 RVA: 0x003C6754 File Offset: 0x003C4954
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

		// Token: 0x06019E22 RID: 106018 RVA: 0x003C677A File Offset: 0x003C497A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E23 RID: 106019 RVA: 0x003C6787 File Offset: 0x003C4987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E24 RID: 106020 RVA: 0x003C6790 File Offset: 0x003C4990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E25 RID: 106021 RVA: 0x003C67A8 File Offset: 0x003C49A8
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

		// Token: 0x06019E26 RID: 106022 RVA: 0x003C67CE File Offset: 0x003C49CE
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

		// Token: 0x06019E27 RID: 106023 RVA: 0x003C67EB File Offset: 0x003C49EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E28 RID: 106024 RVA: 0x003C67F4 File Offset: 0x003C49F4
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

		// Token: 0x040098A7 RID: 39079
		private UnknownFieldSet _unknownFields;
	}
}
