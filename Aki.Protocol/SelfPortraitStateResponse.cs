using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C3 RID: 4547
	[NetMessage(EMessageId.SelfPortraitStateResponse)]
	public sealed class SelfPortraitStateResponse : IMessage<SelfPortraitStateResponse>, IMessage, IEquatable<SelfPortraitStateResponse>, IDeepCloneable<SelfPortraitStateResponse>, IBufferMessage
	{
		// Token: 0x0601842A RID: 99370 RVA: 0x003880C9 File Offset: 0x003862C9
		[NullableContext(1)]
		public static SelfPortraitStateResponse Create()
		{
			return new SelfPortraitStateResponse();
		}

		// Token: 0x170051BA RID: 20922
		// (get) Token: 0x0601842B RID: 99371 RVA: 0x003880D0 File Offset: 0x003862D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051BB RID: 20923
		// (get) Token: 0x0601842C RID: 99372 RVA: 0x003880D3 File Offset: 0x003862D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelfPortraitStateResponse.Descriptor;
			}
		}

		// Token: 0x0601842D RID: 99373 RVA: 0x003880DA File Offset: 0x003862DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateResponse()
		{
		}

		// Token: 0x0601842E RID: 99374 RVA: 0x003880E2 File Offset: 0x003862E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateResponse(SelfPortraitStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601842F RID: 99375 RVA: 0x00388107 File Offset: 0x00386307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateResponse Clone()
		{
			return new SelfPortraitStateResponse(this);
		}

		// Token: 0x170051BC RID: 20924
		// (get) Token: 0x06018430 RID: 99376 RVA: 0x0038810F File Offset: 0x0038630F
		// (set) Token: 0x06018431 RID: 99377 RVA: 0x00388117 File Offset: 0x00386317
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

		// Token: 0x06018432 RID: 99378 RVA: 0x00388120 File Offset: 0x00386320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelfPortraitStateResponse);
		}

		// Token: 0x06018433 RID: 99379 RVA: 0x0038812E File Offset: 0x0038632E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelfPortraitStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018434 RID: 99380 RVA: 0x0038815C File Offset: 0x0038635C
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

		// Token: 0x06018435 RID: 99381 RVA: 0x003881A1 File Offset: 0x003863A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018436 RID: 99382 RVA: 0x003881AE File Offset: 0x003863AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018437 RID: 99383 RVA: 0x003881B7 File Offset: 0x003863B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018438 RID: 99384 RVA: 0x003881EC File Offset: 0x003863EC
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

		// Token: 0x06018439 RID: 99385 RVA: 0x0038822A File Offset: 0x0038642A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelfPortraitStateResponse other)
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

		// Token: 0x0601843A RID: 99386 RVA: 0x0038825B File Offset: 0x0038645B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601843B RID: 99387 RVA: 0x00388264 File Offset: 0x00386464
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FCD RID: 36813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FCE RID: 36814
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x04008FCF RID: 36815
		private ErrorCode errCode_;
	}
}
