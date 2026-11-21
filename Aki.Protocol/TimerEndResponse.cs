using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F3 RID: 5107
	[NetMessage(EMessageId.TimerEndResponse)]
	public sealed class TimerEndResponse : IMessage<TimerEndResponse>, IMessage, IEquatable<TimerEndResponse>, IDeepCloneable<TimerEndResponse>, IBufferMessage
	{
		// Token: 0x0601B28A RID: 111242 RVA: 0x003F3C3F File Offset: 0x003F1E3F
		[NullableContext(1)]
		public static TimerEndResponse Create()
		{
			return new TimerEndResponse();
		}

		// Token: 0x17005BF3 RID: 23539
		// (get) Token: 0x0601B28B RID: 111243 RVA: 0x003F3C46 File Offset: 0x003F1E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BF4 RID: 23540
		// (get) Token: 0x0601B28C RID: 111244 RVA: 0x003F3C49 File Offset: 0x003F1E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimerEndResponse.Descriptor;
			}
		}

		// Token: 0x0601B28D RID: 111245 RVA: 0x003F3C50 File Offset: 0x003F1E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndResponse()
		{
		}

		// Token: 0x0601B28E RID: 111246 RVA: 0x003F3C58 File Offset: 0x003F1E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndResponse(TimerEndResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B28F RID: 111247 RVA: 0x003F3C7D File Offset: 0x003F1E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndResponse Clone()
		{
			return new TimerEndResponse(this);
		}

		// Token: 0x17005BF5 RID: 23541
		// (get) Token: 0x0601B290 RID: 111248 RVA: 0x003F3C85 File Offset: 0x003F1E85
		// (set) Token: 0x0601B291 RID: 111249 RVA: 0x003F3C8D File Offset: 0x003F1E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601B292 RID: 111250 RVA: 0x003F3C96 File Offset: 0x003F1E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimerEndResponse);
		}

		// Token: 0x0601B293 RID: 111251 RVA: 0x003F3CA4 File Offset: 0x003F1EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimerEndResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B294 RID: 111252 RVA: 0x003F3CD4 File Offset: 0x003F1ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B295 RID: 111253 RVA: 0x003F3D19 File Offset: 0x003F1F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B296 RID: 111254 RVA: 0x003F3D26 File Offset: 0x003F1F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B297 RID: 111255 RVA: 0x003F3D2F File Offset: 0x003F1F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B298 RID: 111256 RVA: 0x003F3D64 File Offset: 0x003F1F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B299 RID: 111257 RVA: 0x003F3DA2 File Offset: 0x003F1FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimerEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B29A RID: 111258 RVA: 0x003F3DD3 File Offset: 0x003F1FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B29B RID: 111259 RVA: 0x003F3DDC File Offset: 0x003F1FDC
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E73 RID: 40563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E74 RID: 40564
		public const int ErrorIdFieldNumber = 4;

		// Token: 0x04009E75 RID: 40565
		private ErrorCode errorId_;
	}
}
