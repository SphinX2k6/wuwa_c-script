using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FD RID: 1021
	[NetMessage(EMessageId.DrownEndTeleportResponse)]
	public sealed class DrownEndTeleportResponse : IMessage<DrownEndTeleportResponse>, IMessage, IEquatable<DrownEndTeleportResponse>, IDeepCloneable<DrownEndTeleportResponse>, IBufferMessage
	{
		// Token: 0x060062E8 RID: 25320 RVA: 0x000EE236 File Offset: 0x000EC436
		[NullableContext(1)]
		public static DrownEndTeleportResponse Create()
		{
			return new DrownEndTeleportResponse();
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x000EE23D File Offset: 0x000EC43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060062EA RID: 25322 RVA: 0x000EE240 File Offset: 0x000EC440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownEndTeleportResponse.Descriptor;
			}
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x000EE247 File Offset: 0x000EC447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse()
		{
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x000EE24F File Offset: 0x000EC44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse(DrownEndTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x000EE274 File Offset: 0x000EC474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse Clone()
		{
			return new DrownEndTeleportResponse(this);
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060062EE RID: 25326 RVA: 0x000EE27C File Offset: 0x000EC47C
		// (set) Token: 0x060062EF RID: 25327 RVA: 0x000EE284 File Offset: 0x000EC484
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

		// Token: 0x060062F0 RID: 25328 RVA: 0x000EE28D File Offset: 0x000EC48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownEndTeleportResponse);
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x000EE29B File Offset: 0x000EC49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownEndTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x000EE2CC File Offset: 0x000EC4CC
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

		// Token: 0x060062F3 RID: 25331 RVA: 0x000EE311 File Offset: 0x000EC511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x000EE31E File Offset: 0x000EC51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x000EE327 File Offset: 0x000EC527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x000EE35C File Offset: 0x000EC55C
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

		// Token: 0x060062F7 RID: 25335 RVA: 0x000EE39A File Offset: 0x000EC59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownEndTeleportResponse other)
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

		// Token: 0x060062F8 RID: 25336 RVA: 0x000EE3CB File Offset: 0x000EC5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x000EE3D4 File Offset: 0x000EC5D4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003854 RID: 14420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003855 RID: 14421
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003856 RID: 14422
		private ErrorCode errorCode_;
	}
}
