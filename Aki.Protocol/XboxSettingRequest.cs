using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A2 RID: 5538
	[NetMessage(EMessageId.XboxSettingRequest)]
	public sealed class XboxSettingRequest : IMessage<XboxSettingRequest>, IMessage, IEquatable<XboxSettingRequest>, IDeepCloneable<XboxSettingRequest>, IBufferMessage
	{
		// Token: 0x0601D505 RID: 120069 RVA: 0x0043E58A File Offset: 0x0043C78A
		[NullableContext(1)]
		public static XboxSettingRequest Create()
		{
			return new XboxSettingRequest();
		}

		// Token: 0x1700632F RID: 25391
		// (get) Token: 0x0601D506 RID: 120070 RVA: 0x0043E591 File Offset: 0x0043C791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006330 RID: 25392
		// (get) Token: 0x0601D507 RID: 120071 RVA: 0x0043E594 File Offset: 0x0043C794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingRequest.Descriptor;
			}
		}

		// Token: 0x0601D508 RID: 120072 RVA: 0x0043E59B File Offset: 0x0043C79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingRequest()
		{
		}

		// Token: 0x0601D509 RID: 120073 RVA: 0x0043E5A3 File Offset: 0x0043C7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingRequest(XboxSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D50A RID: 120074 RVA: 0x0043E5BC File Offset: 0x0043C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingRequest Clone()
		{
			return new XboxSettingRequest(this);
		}

		// Token: 0x0601D50B RID: 120075 RVA: 0x0043E5C4 File Offset: 0x0043C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingRequest);
		}

		// Token: 0x0601D50C RID: 120076 RVA: 0x0043E5D2 File Offset: 0x0043C7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D50D RID: 120077 RVA: 0x0043E5F0 File Offset: 0x0043C7F0
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

		// Token: 0x0601D50E RID: 120078 RVA: 0x0043E616 File Offset: 0x0043C816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D50F RID: 120079 RVA: 0x0043E623 File Offset: 0x0043C823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D510 RID: 120080 RVA: 0x0043E62C File Offset: 0x0043C82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D511 RID: 120081 RVA: 0x0043E644 File Offset: 0x0043C844
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

		// Token: 0x0601D512 RID: 120082 RVA: 0x0043E66A File Offset: 0x0043C86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(XboxSettingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D513 RID: 120083 RVA: 0x0043E687 File Offset: 0x0043C887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D514 RID: 120084 RVA: 0x0043E690 File Offset: 0x0043C890
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

		// Token: 0x0400A817 RID: 43031
		private UnknownFieldSet _unknownFields;
	}
}
