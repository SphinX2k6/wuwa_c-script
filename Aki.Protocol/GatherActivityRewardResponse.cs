using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B9 RID: 1721
	[NetMessage(EMessageId.GatherActivityRewardResponse)]
	public sealed class GatherActivityRewardResponse : IMessage<GatherActivityRewardResponse>, IMessage, IEquatable<GatherActivityRewardResponse>, IDeepCloneable<GatherActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x06009DA8 RID: 40360 RVA: 0x0017F141 File Offset: 0x0017D341
		[NullableContext(1)]
		public static GatherActivityRewardResponse Create()
		{
			return new GatherActivityRewardResponse();
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06009DA9 RID: 40361 RVA: 0x0017F148 File Offset: 0x0017D348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06009DAA RID: 40362 RVA: 0x0017F14B File Offset: 0x0017D34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x0017F152 File Offset: 0x0017D352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardResponse()
		{
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x0017F15A File Offset: 0x0017D35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardResponse(GatherActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x0017F17F File Offset: 0x0017D37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardResponse Clone()
		{
			return new GatherActivityRewardResponse(this);
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06009DAE RID: 40366 RVA: 0x0017F187 File Offset: 0x0017D387
		// (set) Token: 0x06009DAF RID: 40367 RVA: 0x0017F18F File Offset: 0x0017D38F
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

		// Token: 0x06009DB0 RID: 40368 RVA: 0x0017F198 File Offset: 0x0017D398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherActivityRewardResponse);
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x0017F1A6 File Offset: 0x0017D3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x0017F1D4 File Offset: 0x0017D3D4
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

		// Token: 0x06009DB3 RID: 40371 RVA: 0x0017F219 File Offset: 0x0017D419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x0017F226 File Offset: 0x0017D426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x0017F22F File Offset: 0x0017D42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x0017F264 File Offset: 0x0017D464
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

		// Token: 0x06009DB7 RID: 40375 RVA: 0x0017F2A2 File Offset: 0x0017D4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherActivityRewardResponse other)
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

		// Token: 0x06009DB8 RID: 40376 RVA: 0x0017F2D3 File Offset: 0x0017D4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x0017F2DC File Offset: 0x0017D4DC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A03 RID: 18947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A04 RID: 18948
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004A05 RID: 18949
		private ErrorCode errorCode_;
	}
}
