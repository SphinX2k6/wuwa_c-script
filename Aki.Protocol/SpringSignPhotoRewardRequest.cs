using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F1 RID: 4849
	[NetMessage(EMessageId.SpringSignPhotoRewardRequest)]
	public sealed class SpringSignPhotoRewardRequest : IMessage<SpringSignPhotoRewardRequest>, IMessage, IEquatable<SpringSignPhotoRewardRequest>, IDeepCloneable<SpringSignPhotoRewardRequest>, IBufferMessage
	{
		// Token: 0x06019DF7 RID: 105975 RVA: 0x003C63D2 File Offset: 0x003C45D2
		[NullableContext(1)]
		public static SpringSignPhotoRewardRequest Create()
		{
			return new SpringSignPhotoRewardRequest();
		}

		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x06019DF8 RID: 105976 RVA: 0x003C63D9 File Offset: 0x003C45D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057A4 RID: 22436
		// (get) Token: 0x06019DF9 RID: 105977 RVA: 0x003C63DC File Offset: 0x003C45DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignPhotoRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019DFA RID: 105978 RVA: 0x003C63E3 File Offset: 0x003C45E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardRequest()
		{
		}

		// Token: 0x06019DFB RID: 105979 RVA: 0x003C63EB File Offset: 0x003C45EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardRequest(SpringSignPhotoRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DFC RID: 105980 RVA: 0x003C6404 File Offset: 0x003C4604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardRequest Clone()
		{
			return new SpringSignPhotoRewardRequest(this);
		}

		// Token: 0x06019DFD RID: 105981 RVA: 0x003C640C File Offset: 0x003C460C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignPhotoRewardRequest);
		}

		// Token: 0x06019DFE RID: 105982 RVA: 0x003C641A File Offset: 0x003C461A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignPhotoRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019DFF RID: 105983 RVA: 0x003C6438 File Offset: 0x003C4638
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

		// Token: 0x06019E00 RID: 105984 RVA: 0x003C645E File Offset: 0x003C465E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E01 RID: 105985 RVA: 0x003C646B File Offset: 0x003C466B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E02 RID: 105986 RVA: 0x003C6474 File Offset: 0x003C4674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E03 RID: 105987 RVA: 0x003C648C File Offset: 0x003C468C
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

		// Token: 0x06019E04 RID: 105988 RVA: 0x003C64B2 File Offset: 0x003C46B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignPhotoRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E05 RID: 105989 RVA: 0x003C64CF File Offset: 0x003C46CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E06 RID: 105990 RVA: 0x003C64D8 File Offset: 0x003C46D8
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

		// Token: 0x040098A3 RID: 39075
		private UnknownFieldSet _unknownFields;
	}
}
