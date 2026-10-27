using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124F RID: 4687
	[NetMessage(EMessageId.SlashAndTowerResetResponse)]
	public sealed class SlashAndTowerResetResponse : IMessage<SlashAndTowerResetResponse>, IMessage, IEquatable<SlashAndTowerResetResponse>, IDeepCloneable<SlashAndTowerResetResponse>, IBufferMessage
	{
		// Token: 0x06018F8D RID: 102285 RVA: 0x003A21C1 File Offset: 0x003A03C1
		[NullableContext(1)]
		public static SlashAndTowerResetResponse Create()
		{
			return new SlashAndTowerResetResponse();
		}

		// Token: 0x17005435 RID: 21557
		// (get) Token: 0x06018F8E RID: 102286 RVA: 0x003A21C8 File Offset: 0x003A03C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005436 RID: 21558
		// (get) Token: 0x06018F8F RID: 102287 RVA: 0x003A21CB File Offset: 0x003A03CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerResetResponse.Descriptor;
			}
		}

		// Token: 0x06018F90 RID: 102288 RVA: 0x003A21D2 File Offset: 0x003A03D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetResponse()
		{
		}

		// Token: 0x06018F91 RID: 102289 RVA: 0x003A21DA File Offset: 0x003A03DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetResponse(SlashAndTowerResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F92 RID: 102290 RVA: 0x003A21FF File Offset: 0x003A03FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetResponse Clone()
		{
			return new SlashAndTowerResetResponse(this);
		}

		// Token: 0x17005437 RID: 21559
		// (get) Token: 0x06018F93 RID: 102291 RVA: 0x003A2207 File Offset: 0x003A0407
		// (set) Token: 0x06018F94 RID: 102292 RVA: 0x003A220F File Offset: 0x003A040F
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

		// Token: 0x06018F95 RID: 102293 RVA: 0x003A2218 File Offset: 0x003A0418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerResetResponse);
		}

		// Token: 0x06018F96 RID: 102294 RVA: 0x003A2226 File Offset: 0x003A0426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F97 RID: 102295 RVA: 0x003A2254 File Offset: 0x003A0454
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

		// Token: 0x06018F98 RID: 102296 RVA: 0x003A2299 File Offset: 0x003A0499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F99 RID: 102297 RVA: 0x003A22A6 File Offset: 0x003A04A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F9A RID: 102298 RVA: 0x003A22AF File Offset: 0x003A04AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F9B RID: 102299 RVA: 0x003A22E4 File Offset: 0x003A04E4
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

		// Token: 0x06018F9C RID: 102300 RVA: 0x003A2322 File Offset: 0x003A0522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerResetResponse other)
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

		// Token: 0x06018F9D RID: 102301 RVA: 0x003A2353 File Offset: 0x003A0553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F9E RID: 102302 RVA: 0x003A235C File Offset: 0x003A055C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009331 RID: 37681
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009332 RID: 37682
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009333 RID: 37683
		private ErrorCode errorCode_;
	}
}
