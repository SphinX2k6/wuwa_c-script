using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000233 RID: 563
	[NetMessage(EMessageId.CameraSettingQueryRequest)]
	public sealed class CameraSettingQueryRequest : IMessage<CameraSettingQueryRequest>, IMessage, IEquatable<CameraSettingQueryRequest>, IDeepCloneable<CameraSettingQueryRequest>, IBufferMessage
	{
		// Token: 0x06003D38 RID: 15672 RVA: 0x000984AD File Offset: 0x000966AD
		[NullableContext(1)]
		public static CameraSettingQueryRequest Create()
		{
			return new CameraSettingQueryRequest();
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x000984B4 File Offset: 0x000966B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x000984B7 File Offset: 0x000966B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingQueryRequest.Descriptor;
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x000984BE File Offset: 0x000966BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryRequest()
		{
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x000984C6 File Offset: 0x000966C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryRequest(CameraSettingQueryRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x000984DF File Offset: 0x000966DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryRequest Clone()
		{
			return new CameraSettingQueryRequest(this);
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x000984E7 File Offset: 0x000966E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingQueryRequest);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x000984F5 File Offset: 0x000966F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingQueryRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00098514 File Offset: 0x00096714
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

		// Token: 0x06003D41 RID: 15681 RVA: 0x0009853A File Offset: 0x0009673A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00098547 File Offset: 0x00096747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00098550 File Offset: 0x00096750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00098568 File Offset: 0x00096768
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

		// Token: 0x06003D45 RID: 15685 RVA: 0x0009858E File Offset: 0x0009678E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingQueryRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x000985AB File Offset: 0x000967AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x000985B4 File Offset: 0x000967B4
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

		// Token: 0x04002CFF RID: 11519
		private UnknownFieldSet _unknownFields;
	}
}
