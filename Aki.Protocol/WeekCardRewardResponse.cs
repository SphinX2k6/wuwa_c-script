using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157F RID: 5503
	[NetMessage(EMessageId.WeekCardRewardResponse)]
	public sealed class WeekCardRewardResponse : IMessage<WeekCardRewardResponse>, IMessage, IEquatable<WeekCardRewardResponse>, IDeepCloneable<WeekCardRewardResponse>, IBufferMessage
	{
		// Token: 0x0601D22D RID: 119341 RVA: 0x00438155 File Offset: 0x00436355
		[NullableContext(1)]
		public static WeekCardRewardResponse Create()
		{
			return new WeekCardRewardResponse();
		}

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x0601D22E RID: 119342 RVA: 0x0043815C File Offset: 0x0043635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x0601D22F RID: 119343 RVA: 0x0043815F File Offset: 0x0043635F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601D230 RID: 119344 RVA: 0x00438166 File Offset: 0x00436366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardResponse()
		{
		}

		// Token: 0x0601D231 RID: 119345 RVA: 0x0043816E File Offset: 0x0043636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardResponse(WeekCardRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D232 RID: 119346 RVA: 0x00438193 File Offset: 0x00436393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardResponse Clone()
		{
			return new WeekCardRewardResponse(this);
		}

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x0601D233 RID: 119347 RVA: 0x0043819B File Offset: 0x0043639B
		// (set) Token: 0x0601D234 RID: 119348 RVA: 0x004381A3 File Offset: 0x004363A3
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

		// Token: 0x0601D235 RID: 119349 RVA: 0x004381AC File Offset: 0x004363AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardRewardResponse);
		}

		// Token: 0x0601D236 RID: 119350 RVA: 0x004381BA File Offset: 0x004363BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D237 RID: 119351 RVA: 0x004381E8 File Offset: 0x004363E8
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

		// Token: 0x0601D238 RID: 119352 RVA: 0x0043822D File Offset: 0x0043642D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D239 RID: 119353 RVA: 0x0043823A File Offset: 0x0043643A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D23A RID: 119354 RVA: 0x00438243 File Offset: 0x00436443
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

		// Token: 0x0601D23B RID: 119355 RVA: 0x00438278 File Offset: 0x00436478
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

		// Token: 0x0601D23C RID: 119356 RVA: 0x004382B6 File Offset: 0x004364B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardRewardResponse other)
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

		// Token: 0x0601D23D RID: 119357 RVA: 0x004382E7 File Offset: 0x004364E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D23E RID: 119358 RVA: 0x004382F0 File Offset: 0x004364F0
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

		// Token: 0x0400A746 RID: 42822
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A747 RID: 42823
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A748 RID: 42824
		private ErrorCode errorCode_;
	}
}
