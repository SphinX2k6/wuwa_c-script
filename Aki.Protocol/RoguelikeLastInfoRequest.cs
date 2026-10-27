using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA3 RID: 4003
	[NetMessage(EMessageId.RoguelikeLastInfoRequest)]
	public sealed class RoguelikeLastInfoRequest : IMessage<RoguelikeLastInfoRequest>, IMessage, IEquatable<RoguelikeLastInfoRequest>, IDeepCloneable<RoguelikeLastInfoRequest>, IBufferMessage
	{
		// Token: 0x06015687 RID: 87687 RVA: 0x0031B875 File Offset: 0x00319A75
		[NullableContext(1)]
		public static RoguelikeLastInfoRequest Create()
		{
			return new RoguelikeLastInfoRequest();
		}

		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x06015688 RID: 87688 RVA: 0x0031B87C File Offset: 0x00319A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x06015689 RID: 87689 RVA: 0x0031B87F File Offset: 0x00319A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeLastInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601568A RID: 87690 RVA: 0x0031B886 File Offset: 0x00319A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoRequest()
		{
		}

		// Token: 0x0601568B RID: 87691 RVA: 0x0031B88E File Offset: 0x00319A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoRequest(RoguelikeLastInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601568C RID: 87692 RVA: 0x0031B8A7 File Offset: 0x00319AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoRequest Clone()
		{
			return new RoguelikeLastInfoRequest(this);
		}

		// Token: 0x0601568D RID: 87693 RVA: 0x0031B8AF File Offset: 0x00319AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeLastInfoRequest);
		}

		// Token: 0x0601568E RID: 87694 RVA: 0x0031B8BD File Offset: 0x00319ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeLastInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601568F RID: 87695 RVA: 0x0031B8DC File Offset: 0x00319ADC
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

		// Token: 0x06015690 RID: 87696 RVA: 0x0031B902 File Offset: 0x00319B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015691 RID: 87697 RVA: 0x0031B90F File Offset: 0x00319B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015692 RID: 87698 RVA: 0x0031B918 File Offset: 0x00319B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015693 RID: 87699 RVA: 0x0031B930 File Offset: 0x00319B30
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

		// Token: 0x06015694 RID: 87700 RVA: 0x0031B956 File Offset: 0x00319B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeLastInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015695 RID: 87701 RVA: 0x0031B973 File Offset: 0x00319B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015696 RID: 87702 RVA: 0x0031B97C File Offset: 0x00319B7C
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

		// Token: 0x040080CE RID: 32974
		private UnknownFieldSet _unknownFields;
	}
}
