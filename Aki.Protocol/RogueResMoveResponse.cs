using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE8 RID: 4072
	[NetMessage(EMessageId.RogueResMoveResponse)]
	public sealed class RogueResMoveResponse : IMessage<RogueResMoveResponse>, IMessage, IEquatable<RogueResMoveResponse>, IDeepCloneable<RogueResMoveResponse>, IBufferMessage
	{
		// Token: 0x06015CB5 RID: 89269 RVA: 0x0032AFC4 File Offset: 0x003291C4
		[NullableContext(1)]
		public static RogueResMoveResponse Create()
		{
			return new RogueResMoveResponse();
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x06015CB6 RID: 89270 RVA: 0x0032AFCB File Offset: 0x003291CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x06015CB7 RID: 89271 RVA: 0x0032AFCE File Offset: 0x003291CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoveResponse.Descriptor;
			}
		}

		// Token: 0x06015CB8 RID: 89272 RVA: 0x0032AFD5 File Offset: 0x003291D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveResponse()
		{
		}

		// Token: 0x06015CB9 RID: 89273 RVA: 0x0032AFDD File Offset: 0x003291DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveResponse(RogueResMoveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CBA RID: 89274 RVA: 0x0032B002 File Offset: 0x00329202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveResponse Clone()
		{
			return new RogueResMoveResponse(this);
		}

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x06015CBB RID: 89275 RVA: 0x0032B00A File Offset: 0x0032920A
		// (set) Token: 0x06015CBC RID: 89276 RVA: 0x0032B012 File Offset: 0x00329212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06015CBD RID: 89277 RVA: 0x0032B01B File Offset: 0x0032921B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoveResponse);
		}

		// Token: 0x06015CBE RID: 89278 RVA: 0x0032B029 File Offset: 0x00329229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CBF RID: 89279 RVA: 0x0032B058 File Offset: 0x00329258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CC0 RID: 89280 RVA: 0x0032B09D File Offset: 0x0032929D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CC1 RID: 89281 RVA: 0x0032B0AA File Offset: 0x003292AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CC2 RID: 89282 RVA: 0x0032B0B3 File Offset: 0x003292B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015CC3 RID: 89283 RVA: 0x0032B0E8 File Offset: 0x003292E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CC4 RID: 89284 RVA: 0x0032B126 File Offset: 0x00329326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMoveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CC5 RID: 89285 RVA: 0x0032B157 File Offset: 0x00329357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CC6 RID: 89286 RVA: 0x0032B160 File Offset: 0x00329360
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400833B RID: 33595
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400833C RID: 33596
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x0400833D RID: 33597
		private ErrorCode errCode_;
	}
}
