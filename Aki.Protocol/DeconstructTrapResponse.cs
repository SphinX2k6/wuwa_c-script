using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BE RID: 958
	[NetMessage(EMessageId.DeconstructTrapResponse)]
	public sealed class DeconstructTrapResponse : IMessage<DeconstructTrapResponse>, IMessage, IEquatable<DeconstructTrapResponse>, IDeepCloneable<DeconstructTrapResponse>, IBufferMessage
	{
		// Token: 0x06005DCB RID: 24011 RVA: 0x000E3755 File Offset: 0x000E1955
		[NullableContext(1)]
		public static DeconstructTrapResponse Create()
		{
			return new DeconstructTrapResponse();
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x000E375C File Offset: 0x000E195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x000E375F File Offset: 0x000E195F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeconstructTrapResponse.Descriptor;
			}
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x000E3766 File Offset: 0x000E1966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapResponse()
		{
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x000E376E File Offset: 0x000E196E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapResponse(DeconstructTrapResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x000E3793 File Offset: 0x000E1993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapResponse Clone()
		{
			return new DeconstructTrapResponse(this);
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x000E379B File Offset: 0x000E199B
		// (set) Token: 0x06005DD2 RID: 24018 RVA: 0x000E37A3 File Offset: 0x000E19A3
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

		// Token: 0x06005DD3 RID: 24019 RVA: 0x000E37AC File Offset: 0x000E19AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeconstructTrapResponse);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x000E37BA File Offset: 0x000E19BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeconstructTrapResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x000E37E8 File Offset: 0x000E19E8
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

		// Token: 0x06005DD6 RID: 24022 RVA: 0x000E382D File Offset: 0x000E1A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x000E383A File Offset: 0x000E1A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x000E3843 File Offset: 0x000E1A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x000E3878 File Offset: 0x000E1A78
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

		// Token: 0x06005DDA RID: 24026 RVA: 0x000E38B6 File Offset: 0x000E1AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeconstructTrapResponse other)
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

		// Token: 0x06005DDB RID: 24027 RVA: 0x000E38E7 File Offset: 0x000E1AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x000E38F0 File Offset: 0x000E1AF0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040036A5 RID: 13989
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A6 RID: 13990
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040036A7 RID: 13991
		private ErrorCode errorCode_;
	}
}
