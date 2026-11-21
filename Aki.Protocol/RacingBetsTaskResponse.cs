using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6A RID: 3690
	[NetMessage(EMessageId.RacingBetsTaskResponse)]
	public sealed class RacingBetsTaskResponse : IMessage<RacingBetsTaskResponse>, IMessage, IEquatable<RacingBetsTaskResponse>, IDeepCloneable<RacingBetsTaskResponse>, IBufferMessage
	{
		// Token: 0x06013D98 RID: 81304 RVA: 0x002E4979 File Offset: 0x002E2B79
		[NullableContext(1)]
		public static RacingBetsTaskResponse Create()
		{
			return new RacingBetsTaskResponse();
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x06013D99 RID: 81305 RVA: 0x002E4980 File Offset: 0x002E2B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x06013D9A RID: 81306 RVA: 0x002E4983 File Offset: 0x002E2B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskResponse.Descriptor;
			}
		}

		// Token: 0x06013D9B RID: 81307 RVA: 0x002E498A File Offset: 0x002E2B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskResponse()
		{
		}

		// Token: 0x06013D9C RID: 81308 RVA: 0x002E4992 File Offset: 0x002E2B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskResponse(RacingBetsTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D9D RID: 81309 RVA: 0x002E49B7 File Offset: 0x002E2BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskResponse Clone()
		{
			return new RacingBetsTaskResponse(this);
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x06013D9E RID: 81310 RVA: 0x002E49BF File Offset: 0x002E2BBF
		// (set) Token: 0x06013D9F RID: 81311 RVA: 0x002E49C7 File Offset: 0x002E2BC7
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

		// Token: 0x06013DA0 RID: 81312 RVA: 0x002E49D0 File Offset: 0x002E2BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskResponse);
		}

		// Token: 0x06013DA1 RID: 81313 RVA: 0x002E49DE File Offset: 0x002E2BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DA2 RID: 81314 RVA: 0x002E4A0C File Offset: 0x002E2C0C
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

		// Token: 0x06013DA3 RID: 81315 RVA: 0x002E4A51 File Offset: 0x002E2C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DA4 RID: 81316 RVA: 0x002E4A5E File Offset: 0x002E2C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DA5 RID: 81317 RVA: 0x002E4A67 File Offset: 0x002E2C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013DA6 RID: 81318 RVA: 0x002E4A9C File Offset: 0x002E2C9C
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

		// Token: 0x06013DA7 RID: 81319 RVA: 0x002E4ADA File Offset: 0x002E2CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskResponse other)
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

		// Token: 0x06013DA8 RID: 81320 RVA: 0x002E4B0B File Offset: 0x002E2D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DA9 RID: 81321 RVA: 0x002E4B14 File Offset: 0x002E2D14
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040079D7 RID: 31191
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079D8 RID: 31192
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040079D9 RID: 31193
		private ErrorCode errorCode_;
	}
}
