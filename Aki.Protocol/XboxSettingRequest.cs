using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152C RID: 5420
	[NetMessage(EMessageId.XboxSettingRequest)]
	public sealed class XboxSettingRequest : IMessage<XboxSettingRequest>, IMessage, IEquatable<XboxSettingRequest>, IDeepCloneable<XboxSettingRequest>, IBufferMessage
	{
		// Token: 0x0601CA3E RID: 117310 RVA: 0x00422ACE File Offset: 0x00420CCE
		[NullableContext(1)]
		public static XboxSettingRequest Create()
		{
			return new XboxSettingRequest();
		}

		// Token: 0x1700608E RID: 24718
		// (get) Token: 0x0601CA3F RID: 117311 RVA: 0x00422AD5 File Offset: 0x00420CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700608F RID: 24719
		// (get) Token: 0x0601CA40 RID: 117312 RVA: 0x00422AD8 File Offset: 0x00420CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingRequest.Descriptor;
			}
		}

		// Token: 0x0601CA41 RID: 117313 RVA: 0x00422ADF File Offset: 0x00420CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingRequest()
		{
		}

		// Token: 0x0601CA42 RID: 117314 RVA: 0x00422AE7 File Offset: 0x00420CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingRequest(XboxSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA43 RID: 117315 RVA: 0x00422B00 File Offset: 0x00420D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingRequest Clone()
		{
			return new XboxSettingRequest(this);
		}

		// Token: 0x0601CA44 RID: 117316 RVA: 0x00422B08 File Offset: 0x00420D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingRequest);
		}

		// Token: 0x0601CA45 RID: 117317 RVA: 0x00422B16 File Offset: 0x00420D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CA46 RID: 117318 RVA: 0x00422B34 File Offset: 0x00420D34
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

		// Token: 0x0601CA47 RID: 117319 RVA: 0x00422B5A File Offset: 0x00420D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA48 RID: 117320 RVA: 0x00422B67 File Offset: 0x00420D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA49 RID: 117321 RVA: 0x00422B70 File Offset: 0x00420D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA4A RID: 117322 RVA: 0x00422B88 File Offset: 0x00420D88
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

		// Token: 0x0601CA4B RID: 117323 RVA: 0x00422BAE File Offset: 0x00420DAE
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

		// Token: 0x0601CA4C RID: 117324 RVA: 0x00422BCB File Offset: 0x00420DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA4D RID: 117325 RVA: 0x00422BD4 File Offset: 0x00420DD4
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

		// Token: 0x0400A3BE RID: 41918
		private UnknownFieldSet _unknownFields;
	}
}
