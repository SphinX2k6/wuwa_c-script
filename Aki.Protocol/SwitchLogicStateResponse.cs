using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001302 RID: 4866
	[NetMessage(EMessageId.SwitchLogicStateResponse)]
	public sealed class SwitchLogicStateResponse : IMessage<SwitchLogicStateResponse>, IMessage, IEquatable<SwitchLogicStateResponse>, IDeepCloneable<SwitchLogicStateResponse>, IBufferMessage
	{
		// Token: 0x06019DDA RID: 105946 RVA: 0x003C2277 File Offset: 0x003C0477
		[NullableContext(1)]
		public static SwitchLogicStateResponse Create()
		{
			return new SwitchLogicStateResponse();
		}

		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x06019DDB RID: 105947 RVA: 0x003C227E File Offset: 0x003C047E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x06019DDC RID: 105948 RVA: 0x003C2281 File Offset: 0x003C0481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStateResponse.Descriptor;
			}
		}

		// Token: 0x06019DDD RID: 105949 RVA: 0x003C2288 File Offset: 0x003C0488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse()
		{
		}

		// Token: 0x06019DDE RID: 105950 RVA: 0x003C2290 File Offset: 0x003C0490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse(SwitchLogicStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DDF RID: 105951 RVA: 0x003C22B5 File Offset: 0x003C04B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse Clone()
		{
			return new SwitchLogicStateResponse(this);
		}

		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x06019DE0 RID: 105952 RVA: 0x003C22BD File Offset: 0x003C04BD
		// (set) Token: 0x06019DE1 RID: 105953 RVA: 0x003C22C5 File Offset: 0x003C04C5
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

		// Token: 0x06019DE2 RID: 105954 RVA: 0x003C22CE File Offset: 0x003C04CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStateResponse);
		}

		// Token: 0x06019DE3 RID: 105955 RVA: 0x003C22DC File Offset: 0x003C04DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DE4 RID: 105956 RVA: 0x003C230C File Offset: 0x003C050C
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

		// Token: 0x06019DE5 RID: 105957 RVA: 0x003C2351 File Offset: 0x003C0551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DE6 RID: 105958 RVA: 0x003C235E File Offset: 0x003C055E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DE7 RID: 105959 RVA: 0x003C2367 File Offset: 0x003C0567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DE8 RID: 105960 RVA: 0x003C239C File Offset: 0x003C059C
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

		// Token: 0x06019DE9 RID: 105961 RVA: 0x003C23DA File Offset: 0x003C05DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLogicStateResponse other)
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

		// Token: 0x06019DEA RID: 105962 RVA: 0x003C240B File Offset: 0x003C060B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DEB RID: 105963 RVA: 0x003C2414 File Offset: 0x003C0614
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400973F RID: 38719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009740 RID: 38720
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009741 RID: 38721
		private ErrorCode errorCode_;
	}
}
