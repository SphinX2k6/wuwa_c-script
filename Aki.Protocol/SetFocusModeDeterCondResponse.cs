using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D4 RID: 4564
	[NetMessage(EMessageId.SetFocusModeDeterCondResponse)]
	public sealed class SetFocusModeDeterCondResponse : IMessage<SetFocusModeDeterCondResponse>, IMessage, IEquatable<SetFocusModeDeterCondResponse>, IDeepCloneable<SetFocusModeDeterCondResponse>, IBufferMessage
	{
		// Token: 0x0601856E RID: 99694 RVA: 0x0038A7CD File Offset: 0x003889CD
		[NullableContext(1)]
		public static SetFocusModeDeterCondResponse Create()
		{
			return new SetFocusModeDeterCondResponse();
		}

		// Token: 0x170051F6 RID: 20982
		// (get) Token: 0x0601856F RID: 99695 RVA: 0x0038A7D4 File Offset: 0x003889D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x06018570 RID: 99696 RVA: 0x0038A7D7 File Offset: 0x003889D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFocusModeDeterCondResponse.Descriptor;
			}
		}

		// Token: 0x06018571 RID: 99697 RVA: 0x0038A7DE File Offset: 0x003889DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondResponse()
		{
		}

		// Token: 0x06018572 RID: 99698 RVA: 0x0038A7E6 File Offset: 0x003889E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondResponse(SetFocusModeDeterCondResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018573 RID: 99699 RVA: 0x0038A80B File Offset: 0x00388A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondResponse Clone()
		{
			return new SetFocusModeDeterCondResponse(this);
		}

		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x06018574 RID: 99700 RVA: 0x0038A813 File Offset: 0x00388A13
		// (set) Token: 0x06018575 RID: 99701 RVA: 0x0038A81B File Offset: 0x00388A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06018576 RID: 99702 RVA: 0x0038A824 File Offset: 0x00388A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFocusModeDeterCondResponse);
		}

		// Token: 0x06018577 RID: 99703 RVA: 0x0038A832 File Offset: 0x00388A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFocusModeDeterCondResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018578 RID: 99704 RVA: 0x0038A860 File Offset: 0x00388A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018579 RID: 99705 RVA: 0x0038A8A5 File Offset: 0x00388AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601857A RID: 99706 RVA: 0x0038A8B2 File Offset: 0x00388AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601857B RID: 99707 RVA: 0x0038A8BB File Offset: 0x00388ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601857C RID: 99708 RVA: 0x0038A8F0 File Offset: 0x00388AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601857D RID: 99709 RVA: 0x0038A92E File Offset: 0x00388B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFocusModeDeterCondResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601857E RID: 99710 RVA: 0x0038A95F File Offset: 0x00388B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601857F RID: 99711 RVA: 0x0038A968 File Offset: 0x00388B68
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009012 RID: 36882
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009013 RID: 36883
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009014 RID: 36884
		private ErrorCode errorCode_;
	}
}
